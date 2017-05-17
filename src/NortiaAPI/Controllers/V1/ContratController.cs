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
    [Route("V1/Contrat", Name = "ContratDefault")]
    public class ContratController : Controller
    {
        /// <summary>
        /// Get all contrat .
        /// </summary>
        /// <returns>The list of contrat with an HTTP 200, or error message with an HTTP 500</returns>
        /// <response code="200">The list of client</response>
        /// <response code="500">Error message</response>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult GetContrats()
        {
            try
            {
                IEnumerable<NortiaContract__c> listNortiaContrat = SalesforceService.GetObject<NortiaContract__c>().Result;
                IEnumerable<Contrat> listContrat = listNortiaContrat.Select(ct => new Contrat
                {
                    Id = ct.Id,
                    Numero = ct.Name,
                });

                return Ok(listContrat);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        /// <summary>
        /// Find one Contrat by id.
        /// </summary>
        /// <param name="id">The contrat id</param>
        /// <returns>The contrat with an HTTP 200, null with an HTTP 404, or error message with an HTTP 500</returns>
        /// <response code="200">The contrat</response>
        /// <response code="404">Null (not found)</response>
        /// <response code="500">Error message</response>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult FindContratById(string id)
        {
            try
            {
                NortiaContract__c nCt = SalesforceService.GetObjectFromId<NortiaContract__c>(id).Result;
                if (nCt != null)
                {
                    Contrat ct = new Contrat
                    {
                        Id = nCt.Id,
                        Numero = nCt.Name
                    };

                    return Ok(ct);
                }
                else
                    return NotFound("Cet identifiant ne correspond à aucun contrat");
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
        /// <param name="contrat">The client properties</param>
        /// <returns>The client id with an HTTP 201, or error message with an HTTP 500</returns>
        /// <response code="201">The client id (created)</response>
        /// <response code="500">Error message</response>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public IActionResult AddContrat([FromBody, Required] Contrat contrat)
        {
            try
            {
                contrat.Id = SalesforceService.AddFromObject(new NortiaContract__c
                {
                    Name = contrat.Numero
                }).Result;

                return CreatedAtRoute("ContratDefault", contrat.Id);
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
                var retour = SalesforceService.DeleteFromID<NortiaContract__c>(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
