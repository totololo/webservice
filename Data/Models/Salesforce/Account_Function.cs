using Data.Salesforce;
using Entities.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Salesforce
{
    public partial class Account
    {
        public Account() { }

        public static IEnumerable<RecordType> listeRecordType = SalesforceService.GetObject<RecordType>("IsActive =true and SobjectType='Account'").Result;

        public static bool Delete(string id)
        {
            return SalesforceService.DeleteFromID<Account>(id).Result;
        }

        //Client
        public static List<string> ClientPropertyNames = new List<string> { "Id", "AccountNumber", "Salutation", "LastName","Prenom_2__pc", "Prenom_3__pc", "Name", "FirstName", "RecordTypeId" };

        public Account(Client.AddClient client)
        {
            Salutation = (client.Type == ClientType.PM) ? null : (client.Civilite==ClientCivilite.Madame? "Madame" : client.Civilite == ClientCivilite.Monsieur?"Monsieur":null);
            FirstName = (client.Type == ClientType.PM) ? null : client.Prenom1;
            Prenom_2__pc = (client.Type == ClientType.PM) ? null : client.Prenom2;
            Prenom_3__pc = (client.Type == ClientType.PM) ? null : client.Prenom3;
            LastName = (client.Type == ClientType.PM) ? null : client.Nom;
            Name = (client.Type == ClientType.PM) ? client.Nom : null;
            Type = "Souscripteur";
            IsPersonAccount = (client.Type == ClientType.PM) ? false : true;
            RecordTypeId = listeRecordType.First(x => x.DeveloperName == (client.Type == ClientType.PM ? "Personne_Morale" : "Personne_Physique")).Id;
        }

        public Client ToClient()
        {
            Client client = new Client();

            client.Id = Id;
            client.CodeNortia = AccountNumber;
            if (string.IsNullOrWhiteSpace(Salutation))
                client.Civilite =null;
            else
                client.Civilite = Salutation == "Madame" ? ClientCivilite.Madame : ClientCivilite.Monsieur;
            client.Nom = LastName ?? Name;
            client.Prenom1 = FirstName;
            client.Prenom2 = Prenom_2__pc;
            client.Prenom3 = Prenom_3__pc;
            client.Type = (listeRecordType.First(x => x.Id == RecordTypeId).DeveloperName) == "Personne_Morale" ? ClientType.PM : ClientType.PP;

            return client;
        }
        
        public static IEnumerable<Client> GetClients(ClientType? type = null)
        {
            string soqlWhere = "type='Souscripteur'";
            if (type != null)
            {
                if (type == ClientType.PM)
                    soqlWhere += " and recordtype.DeveloperName='Personne_Morale'";

                if (type == ClientType.PP)
                    soqlWhere += " and recordtype.DeveloperName='Personne_Physique'";
            }

            IEnumerable<Account> listeAccount = SalesforceService.GetObject<Account>(soqlWhere, false, ClientPropertyNames).Result;
            IEnumerable<Client> listeClient = listeAccount.Select(acc => acc.ToClient());

            return listeClient;
        }

        public static Client GetClient(string id)
        {
            string soqlWhere = "type='Souscripteur'";
            Account ac = SalesforceService.GetObjectFromId<Account>(id, soqlWhere).Result;

            if (ac != null)
                return ac.ToClient();
            else
                return null;
        }

        public static Client AddClient(Client.AddClient addRecord)
        {
            Account accTemp = new Account(addRecord);
            string id = SalesforceService.AddFromObject(accTemp).Result;

            Account acc = SalesforceService.GetObjectFromId<Account>(id).Result;
            if (acc != null)
                return acc.ToClient();
            else
            {
                accTemp.Id = id;
                return  accTemp.ToClient();
            }
        }


        public void SetClient(Client.UpdateClient updateRecord)
        {
            bool pm = listeRecordType.Where(x => x.DeveloperName == "Personne_Morale").First().Id == RecordTypeId;

            Salutation = updateRecord.Civilite == null ? Salutation:(pm ? null : (updateRecord.Civilite == ClientCivilite.Madame ? "Madame" : updateRecord.Civilite == ClientCivilite.Monsieur ? "Monsieur" : null));
            FirstName = updateRecord.Prenom1 == null ? FirstName : (pm ? null : updateRecord.Prenom1);
            Prenom_2__pc = updateRecord.Prenom2 == null ? Prenom_2__pc : (pm ? null : updateRecord.Prenom2);
            Prenom_3__pc = updateRecord.Prenom3 == null ? Prenom_3__pc : (pm ? null : updateRecord.Prenom3);
            LastName = updateRecord.Nom == null ? LastName : (pm ? null : updateRecord.Nom);
            Name = updateRecord.Nom == null ? Name : (pm ? updateRecord.Nom : null);
        }


        public static void UpdateClient(Client.UpdateClient updateRecord)
        {

        }

    }
}
