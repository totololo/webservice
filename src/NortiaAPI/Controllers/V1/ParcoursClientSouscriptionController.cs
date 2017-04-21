using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data.Models.Salesforce;
using Entities.V1;
using Data.Salesforce;
using System.ComponentModel.DataAnnotations;

namespace NortiaAPI.Controllers.V1
{
    [Route("V1/ParcoursClients/Souscriptions", Name = "ParcoursClientSouscriptionDefault")]
    public class ParcoursClientSouscriptionController : Controller
    {
        /// <summary>
        /// Get all parcours clients souscriptions
        /// </summary>
        /// <returns>The list of parcours clients souscriptions with an HTTP 200, or error message with an HTTP 500</returns>
        /// <response code="200">Ok</response>
        /// <response code="500">Error</response>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult GetParcoursClientsSouscriptions()
        {
            try
            {

               string soqlWhere = "recordtype.DeveloperName='Souscription'"; 
                IEnumerable<Parcours_Client__c> listeParClient = SalesforceService.GetObject<Parcours_Client__c>(soqlWhere).Result;
                IEnumerable<ParcoursClientSouscription> listeParClientSous = listeParClient.Select(pc => new ParcoursClientSouscription
                {
                    Id = pc.Id,
                    Id_Client = pc.Compte_client__c,

                });

                return Ok(listeParClientSous);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        /// <summary>
        /// Get all parcours clients souscriptions of one client
        /// </summary>
        /// <param name="id">The client id</param>
        /// <returns>The list of parcours clients souscriptions with an HTTP 200, or error message with an HTTP 500</returns>
        /// <response code="200">Ok</response>
        /// <response code="500">Error</response>
        [HttpGet("Client/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult GetParcoursClientsSouscriptionsByClientId(string id)
        {
            try
            {
                string soqlWhere = "recordtype.DeveloperName='Souscription' and Compte_client__c='" + id + "'";
                IEnumerable<Parcours_Client__c> listeParClient = SalesforceService.GetObject<Parcours_Client__c>(soqlWhere).Result;
                IEnumerable<ParcoursClientSouscription> listeParClientSous = listeParClient.Select(pc => new ParcoursClientSouscription
                {
                    Id = pc.Id,
                    Id_Client = pc.Compte_client__c,

                });

                return Ok(listeParClientSous);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        /// <summary>
        /// Find parcours client souscription by id.
        /// </summary>
        /// <param name="id">The parcours client souscription id</param>
        /// <returns>The parcours client souscription with an HTTP 200, null with an HTTP 404, or error message with an HTTP 500</returns>
        /// <response code="200">Ok</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Error</response>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult FindParcoursClientSouscriptionById(string id)
        {
            try
            {
                string soql = "select Id,Compte_client__c,Civilite__c,Nom_usage__c,Nom_naissance__c,Prenom_1__c from Parcours_Client__c where recordtype.DeveloperName='Souscription' and id='" + id + "'";
                IEnumerable<Parcours_Client__c> listeParClient = SalesforceService.GetObjectFromQuery<Parcours_Client__c>(soql).Result;

                if (listeParClient != null && listeParClient.Count() > 0)
                {
                    Parcours_Client__c pc = listeParClient.First();
                    ParcoursClientSouscription pcs = new ParcoursClientSouscription
                    {
                        Id = pc.Id,
                        Id_Client = pc.Compte_client__c,

                    };

                    return Ok(pcs);
                }
                else
                    return NotFound("Cet identifiant ne correspond à aucun parcours client souscription");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        /// <summary>
        /// Create a parcours client souscription.
        /// </summary>
        /// <param name="idClient">The client id</param>
        /// <returns>The parcours client souscription id with an HTTP 201, or error message with an HTTP 500</returns>
        /// <response code="201">Created</response>
        /// <response code="500">Error</response>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public IActionResult AddParcoursClientSouscription([FromBody, Required] string idClient)
        {
            try
            {
                string soql = "select Id from recordtype where IsActive =true and name='Souscription' and SobjectType='Parcours_Client__c'";
                RecordType recordtype = SalesforceService.GetObjectFromQuery<RecordType>(soql).Result.First();

                string id = SalesforceService.AddFromObject(new Parcours_Client__c { RecordTypeId = recordtype.Id, Compte_client__c = idClient }).Result;

                return CreatedAtRoute("ParcoursClientSouscriptionDefault", id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        /// <summary>
        /// Delete one parcours client souscription by id.
        /// </summary>
        /// <param name="id">The parcours client souscription id</param>
        /// <returns>null with an HTTP 204, or error message with an HTTP 500</returns>
        /// <response code="204">Deleted</response>
        /// <response code="500">Error</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(500)]
        public IActionResult DeleteParcoursClientSouscriptionById(string id)
        {
            try
            {
                var retour = SalesforceService.DeleteFromID<Parcours_Client__c>(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
