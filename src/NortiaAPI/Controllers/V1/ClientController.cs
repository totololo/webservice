using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data.Models.Salesforce;
using Data.Salesforce;
using Entities.V1;
using System.ComponentModel.DataAnnotations;

namespace NortiaAPI.Controllers.V1
{
    [Route("V1/Clients", Name = "ClientDefault")]
    public class ClientController : Controller
    {
        /// <summary>
        /// Get all clients.
        /// </summary>
        /// <param name="type">The client type: PP or PM</param>
        /// <returns>The list of client with an HTTP 200, or error message with an HTTP 500</returns>
        /// <response code="200">The list of client</response>
        /// <response code="500">Error message</response>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult GetClients(string type = null)
        {
            try
            {
                string soql = "SELECT id,DeveloperName FROM RecordType where IsActive =true and SobjectType='Account'";
                //comment
                IEnumerable<RecordType> listeRecordType = SalesforceService.GetObjectFromQuery<RecordType>(soql).Result;

                soql = "select Id,name,firstName,lastName,RecordTypeId from account where type='Souscripteur'";

                if (!string.IsNullOrWhiteSpace(type))
                {
                    if (type.ToUpper() == "PM")
                        soql += " and recordtype.DeveloperName='Personne_Morale'";

                    if (type.ToUpper() == "PP")
                        soql += " and recordtype.DeveloperName='Personne_Physique'";
                }

                IEnumerable<Account> listeAccount = SalesforceService.GetObjectFromQuery<Account>(soql).Result;
                IEnumerable<Client> listeClient = listeAccount.Select(acc => new Client
                {
                    Id = acc.Id,
                    Nom = acc.LastName ?? acc.Name,
                    Prenom1 = acc.FirstName,
                    Type = (listeRecordType.First(x => x.Id == acc.RecordTypeId).DeveloperName) == "Personne_Morale" ? "PM" : "PP"
                });

                return Ok(listeClient);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        /// <summary>
        /// Find one client by id.
        /// </summary>
        /// <param name="id">The client id</param>
        /// <returns>The client with an HTTP 200, null with an HTTP 404, or error message with an HTTP 500</returns>
        /// <response code="200">The client</response>
        /// <response code="404">Null (not found)</response>
        /// <response code="500">Error message</response>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult FindClientById(string id)
        {
            try
            {
                string soql = "SELECT id,DeveloperName FROM RecordType where IsActive =true and SobjectType='Account'";
                IEnumerable<RecordType> listeRecordType = SalesforceService.GetObjectFromQuery<RecordType>(soql).Result;

                soql = "select Id,name,firstName,lastName,RecordTypeId from account where type='Souscripteur' and id='" + id + "'";
                IEnumerable<Account> listeAccount = SalesforceService.GetObjectFromQuery<Account>(soql).Result;

                if (listeAccount != null && listeAccount.Count() > 0)
                {
                    Account acc = listeAccount.First();
                    Client cl = new Client
                    {
                        Id = acc.Id,
                        Nom = acc.LastName ?? acc.Name,
                        Prenom1 = acc.FirstName,
                        Type = (listeRecordType.First(x => x.Id == acc.RecordTypeId).DeveloperName) == "Personne_Morale" ? "PM" : "PP"
                    };

                    return Ok(cl);
                }
                else
                    return NotFound("Cet identifiant ne correspond à aucun client");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Create a client.
        /// </summary>
        /// <remarks>
        /// Don't specify the id
        /// </remarks>
        /// <param name="client">The client properties</param>
        /// <returns>The client id with an HTTP 201, or error message with an HTTP 500</returns>
        /// <response code="201">The client id (created)</response>
        /// <response code="500">Error message</response>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public IActionResult AddClient([FromBody, Required] Client client)
        {
            try
            {
                string recordtypeName = "";
                client.Type = client.Type.ToUpper();
                if (client.Type == "PM")
                    recordtypeName = "Personne Morale";
                else
                    recordtypeName = "Personne Physique";

                string soql = "select Id from recordtype where IsActive =true and name='" + recordtypeName + "' and SobjectType='Account'";
                RecordType recordtype = SalesforceService.GetObjectFromQuery<RecordType>(soql).Result.First();

                client.Id = SalesforceService.AddFromObject(new Account
                {
                    FirstName = (client.Type == "PM") ? null : client.Prenom1,
                    LastName = (client.Type == "PM") ? null : client.Nom,
                    Name = (client.Type == "PM") ? client.Nom : null,
                    Type = "Souscripteur", IsPersonAccount = (client.Type == "PM") ? false : true,
                    RecordTypeId = recordtype.Id
                }).Result;

                return CreatedAtRoute("ClientDefault", client.Id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Delete one client by id.
        /// </summary>
        /// <param name="id">The client id</param>
        /// <returns>null with an HTTP 204, or error message with an HTTP 500</returns>
        /// <response code="204">Null (Deleted)</response>
        /// <response code="500">Error message</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(500)]
        public IActionResult DeleteClientrById(string id)
        {
            try
            {
                var retour = SalesforceService.DeleteFromID<Account>(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
