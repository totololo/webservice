using Data.Models.Salesforce;
using Salesforce.Common;
using Salesforce.Common.Models;
using Salesforce.Force;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data.Salesforce
{
    /// <summary>
    /// Provides methods to interact with a Salesforce service.
    /// </summary>
    public static class SalesforceService
    {
        private static ForceClient Client;

        /// <summary>
        /// Gets a ForceClient that has been authenticated using the UserName, Password, and SecurityToken settings
        /// specified in the config file.
        /// </summary>
        /// <returns>The authenticated ForceClient.</returns>
        public static async Task<ForceClient> GetUserNamePasswordForceClientAsync()
        {
            using (AuthenticationClient authenticationClient = new AuthenticationClient())
            {
                await authenticationClient.UsernamePasswordAsync(
                    SalesforceService.GetAppSetting("Salesforce:ConsumerKey"),
                    SalesforceService.GetAppSetting("Salesforce:ConsumerSecret"),
                    SalesforceService.GetAppSetting("Salesforce:UserName"),
                    SalesforceService.GetAppSetting("Salesforce:Password") + SalesforceService.GetAppSetting("Salesforce:SecurityToken", true),
                    SalesforceService.GetAppSetting("Salesforce:Domain") + "/services/oauth2/token");

                return new ForceClient(
                    authenticationClient.InstanceUrl,
                    authenticationClient.AccessToken,
                    authenticationClient.ApiVersion);
            }
        }

        /// <summary>
        /// Gets the value of the AppSetting with the specified name from the config file.
        /// </summary>
        /// <param name="name">The name of the AppSetting to retrieve.</param>
        /// <param name="isOptional">A Boolean value indicating whether or not the AppSetting is considered optional.</param>
        /// <exception cref="InvalidOperationException">If isOptional is set to false and the AppSetting is not found.</exception>
        /// <returns>
        /// The value of the AppSetting if found.  If isOptional is set to true and the AppSetting is not found, null is returned.
        /// </returns>
        internal static string GetAppSetting(string name, bool isOptional = false)
        {
            string setting = ConfigurationManager.AppSettings[name];
            if (!isOptional && (String.IsNullOrWhiteSpace(setting) || string.Equals(setting, "RequiredValue", StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException(
                    String.Format(CultureInfo.InvariantCulture, "The value for the '{0}' key is missing from the appSettings section of the config file.", name));
            }
            else if (isOptional && (String.IsNullOrWhiteSpace(setting) || string.Equals(setting, "OptionalValue", StringComparison.OrdinalIgnoreCase)))
            {
                setting = null;
            }

            return setting;
        }

        public static async Task<List<T>> GetObjectFromQuery<T>(string query, bool withDeleted = false) where T : class
        {
            List<T> listeRetour = new List<T>();

            if (Client == null)
                Client = await GetUserNamePasswordForceClientAsync();


            QueryResult<T> response;
            if (withDeleted)
                response = await Client.QueryAllAsync<T>(query);
            else
                response = await Client.QueryAsync<T>(query);

            listeRetour.AddRange(response.Records);

            string nextRecordsUrl = response.NextRecordsUrl;
            while (!string.IsNullOrWhiteSpace(nextRecordsUrl))
            {
                response = await Client.QueryContinuationAsync<T>(nextRecordsUrl);
                nextRecordsUrl = response.NextRecordsUrl;

                listeRetour.AddRange(response.Records);
            }

            return listeRetour;
        }

        public static async Task<List<T>> GetObject<T>(string clauseWhere = "", bool withDeleted = false) where T : class
        {
            Type typeT = typeof(T);
            IList<PropertyInfo> propsT = new List<PropertyInfo>(typeT.GetProperties());
            string listField = string.Join(",", propsT.Select(x => x.Name));

            string soql = "SELECT " + listField + " FROM " + typeT.Name;
            if (!string.IsNullOrWhiteSpace(clauseWhere))
                soql += " WHERE " + clauseWhere;

            return (await GetObjectFromQuery<T>(soql, withDeleted));

        }
        public static async Task<T> GetObjectFromId<T>(string id,string clauseWhere="") where T : class
        {
            string soqlWhere = "Id='"+id+"'"+ (string.IsNullOrWhiteSpace(clauseWhere)?"":" and "+ clauseWhere);
            List<T> retour =(await GetObject<T>(soqlWhere));

            if (retour != null && retour.Count() > 0)
                return retour.First();
            else
                return null;
        }

        public static async Task<string> AddFromObject<T>(T record) where T : class
        {
            try
            {
                if (Client == null)
                    Client = await GetUserNamePasswordForceClientAsync();

                SuccessResponse retour = await Client.CreateAsync(typeof(T).Name, record);

                if (retour.Success)
                    return retour.Id;
                else
                    throw new Exception(retour.Errors.ToString());
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static async Task<bool> UpdateFromObject<T>(string id, T record) where T : class
        {
            try
            {
                if (Client == null)
                    Client = await GetUserNamePasswordForceClientAsync();

                SuccessResponse retour = await Client.UpdateAsync(typeof(T).Name, id, record);

                if (retour.Success)
                    return true;
                else
                    throw new Exception(retour.Errors.ToString());
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static async Task<bool> DeleteFromID<T>(string id) where T : class
        {
            try
            {
                if (Client == null)
                    Client = await GetUserNamePasswordForceClientAsync();

                bool retour = await Client.DeleteAsync(typeof(T).Name, id);

                return retour;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}