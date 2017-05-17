using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data.Models.Salesforce;
using Entities.V1;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NortiaAPI.Controllers.V1
{

    [Route("V1/Clients", Name = "ClientDefault")]
    public class ClientController : Controller
    {
        /// <summary>
        /// Get all clients.
        /// </summary>
        /// <param name="type">The client type: null=ALL (default), 1=PP or 2=PM</param>
        /// <returns>The list of client with an HTTP 200, or error message with an HTTP 500</returns>
        /// <response code="200">The list of client</response>
        /// <response code="500">Error message</response>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult GetClients(ClientType? type = null)
        {
            try
            {
                return Ok(Account.GetClients(type));
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
        [HttpGet("{id}", Name = "FindClientById")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult FindClientById(string id)
        {
            try
            {
                Client cl = Account.GetClient(id);
                if (cl != null)
                    return Ok(cl);
                else
                    return NotFound("Cet identifiant ne correspond à aucun client");

                /*
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
                        Type = (listeRecordType.First(x => x.Id == acc.RecordTypeId).DeveloperName) == "Personne_Morale" ? ClientType.PM : ClientType.PP
                    };

                    return Ok(cl);
                }
                else
                    return NotFound("Cet identifiant ne correspond à aucun client");
                    */
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
        /// <param name="addRecord">The client properties</param>
        /// <returns>The client id with an HTTP 201, or error message with an HTTP 500</returns>
        /// <response code="201">The client id (created)</response>
        /// <response code="500">Error message</response>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public IActionResult AddClient([FromBody, Required] Client.AddClient addRecord)
        {
            try
            {
                /*
                Client cl = Account.AddClient(addRecord);
                return CreatedAtRoute("FindClientById", new { id = cl.Id }, cl);
                */

                /*
                Account accTemp = new Account(addRecord);
                string id = SalesforceService.AddFromObject(accTemp).Result;

                Account acc = SalesforceService.GetObjectFromId<Account>(id).Result;
                if (acc != null)
                {
                    return CreatedAtRoute("ClientDefault", new { id = acc.Id }, acc.ToClient());
                }
                else
                {
                    accTemp.Id = id;
                    return CreatedAtRoute("ClientDefault", new { id = accTemp.Id }, accTemp.ToClient());
                }*/

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Update a client.
        /// </summary>
        /// <param name="id">The client id</param>
        /// <param name="updateRecord">The client properties</param>
        /// <returns>The client id with an HTTP 201, or error message with an HTTP 500</returns>
        /// <response code="201">The client id (created)</response>
        /// <response code="500">Error message</response>
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [ProducesResponseType(502)]
        public IActionResult UpdateClient(string id, [FromBody, Required] Client.UpdateClient updateRecord)
        {
            /*
            Client cl = Account.GetClient(id);
            if (cl != null)
            {
                pc.UpdateParcoursClientKYC_PP(updateRecord);
                var retour = SalesforceService.UpdateFromObject(id, pc).Result;

                if (retour)
                {
                    if (!string.IsNullOrWhiteSpace(pc.Parcours_lie__c))
                        id = pc.Parcours_lie__c;

                    pc = SalesforceService.GetObjectFromId<Parcours_Client__c>(id, soqlWhere).Result;
                    if (pc != null)
                    {
                        return Ok(new ParcoursClientKYC_PP.RetourStatut { Statut = pc.Statut__c, ListeDocumentAFournir = pc.Piece_joindre__c == null ? new List<string>() : pc.Piece_joindre__c.Split(';').ToList() });
                    }
                    else
                        return NoContent();
                }
                else
                    return StatusCode(502, "Le serveur intermédiaire a renvoyé une réponse invalide lors de la mise à jour de l'objet: 'Parcours_Client__c'");
            }
            else*/
            return NotFound("Cet identifiant ne correspond à aucun client");
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
                var retour = Account.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
