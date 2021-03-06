﻿using System;
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
    [Route("V1/ParcoursClients/KYCPP", Name = "ParcoursClientKYCPPDefault")]
    public class ParcoursClientKYCPPController : Controller
    {
        /// <summary>
        /// Get all parcours clients connaissance client PP 
        /// </summary>
        /// <returns>The list of parcours clients connaissance client PP with an HTTP 200, or error message with an HTTP 500</returns>
        /// <response code="200">Ok</response>
        /// <response code="500">Error</response>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult GetParcoursClientsKYCPP()
        {
            try
            {
                string soqlWhere = "recordtype.DeveloperName='Connaissance_client_personne_physique'";
                IEnumerable<Parcours_Client__c> listeParClient = SalesforceService.GetObject<Parcours_Client__c>(soqlWhere).Result;
                IEnumerable<ParcoursClientKYC_PP> listeParClientKYCPP = listeParClient.Select(pc => new ParcoursClientKYC_PP
                {
                    Id = pc.Id,
                    Id_Client = pc.Compte_client__c,
                    CiviliteClient = pc.Civilite__c,
                    NomUsageClient = pc.Nom_usage__c,
                    NomNaissanceClient = pc.Nom_naissance__c,
                    Prenom1Client = pc.Prenom_1__c,
                    Prenom2Client = pc.Prenom_2__c,
                    Prenom3Client = pc.Prenom_3__c,
                    DateNaissanceClient = (pc.Date_naissance__c.HasValue ? (DateTime?)pc.Date_naissance__c.Value.Date:null),
                    DepartementNaissanceClient = pc.Dpt_naissance__c,
                    VilleNaissanceClient = pc.Ville_naissance__c,
                    Nationalite1Client = pc.Nationalite__c,
                    Nationalite2Client = pc.Nationalite_2__c,
                    Nationalite3Client = pc.Nationalite_3__c,
                    Nationalite4Client = pc.Nationalite_4__c,
                    SituationFamilialeClient = pc.Situation_familiale__c,
                    RegimeMatrimonialClient = pc.Regime_mat__c,
                    RegimeMatrimonialAutreClient = pc.Autre_regime_mat__c
                });

                return Ok(listeParClientKYCPP);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        /// <summary>
        /// Get all parcours clients connaissance client PP of one client
        /// </summary>
        /// <param name="id">The client id</param>
        /// <returns>The list of parcours clients connaissance client PP with an HTTP 200, or error message with an HTTP 500</returns>
        /// <response code="200">Ok</response>
        /// <response code="500">Error</response>
        [HttpGet("Client/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult GetParcoursClientsKYCPPByClientId(string id)
        {
            try
            {
                string soqlWhere = "recordtype.DeveloperName='Connaissance_client_personne_physique' and Compte_client__c='" + id + "'";
                IEnumerable<Parcours_Client__c> listeParClient = SalesforceService.GetObject<Parcours_Client__c>(soqlWhere).Result;
                IEnumerable<ParcoursClientKYC_PP> listeParClientCCPP = listeParClient.Select(pc => new ParcoursClientKYC_PP
                {
                    Id = pc.Id,
                    Id_Client = pc.Compte_client__c,
                    CiviliteClient = pc.Civilite__c,
                    NomUsageClient = pc.Nom_usage__c,
                    NomNaissanceClient = pc.Nom_naissance__c,
                    Prenom1Client = pc.Prenom_1__c,
                    Prenom2Client = pc.Prenom_2__c,
                    Prenom3Client = pc.Prenom_3__c,
                    DateNaissanceClient = (pc.Date_naissance__c.HasValue ? (DateTime?)pc.Date_naissance__c.Value.Date : null),
                    DepartementNaissanceClient = pc.Dpt_naissance__c,
                    VilleNaissanceClient = pc.Ville_naissance__c,
                    Nationalite1Client = pc.Nationalite__c,
                    Nationalite2Client = pc.Nationalite_2__c,
                    Nationalite3Client = pc.Nationalite_3__c,
                    Nationalite4Client = pc.Nationalite_4__c,
                    SituationFamilialeClient = pc.Situation_familiale__c,
                    RegimeMatrimonialClient = pc.Regime_mat__c,
                    RegimeMatrimonialAutreClient = pc.Autre_regime_mat__c
                });

                return Ok(listeParClientCCPP);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        /// <summary>
        /// Find parcours client connaissance client PP  by id.
        /// </summary>
        /// <param name="id">The parcours client connaissance client PP id</param>
        /// <returns>The parcours client souscription with an HTTP 200, null with an HTTP 404, or error message with an HTTP 500</returns>
        /// <response code="200">Ok</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Error</response>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult FindParcoursClientKYCPPById(string id)
        {
            try
            {
                string soqlWhere = "recordtype.DeveloperName='Connaissance_client_personne_physique'";
                Parcours_Client__c pc = SalesforceService.GetObjectFromId<Parcours_Client__c>(id, soqlWhere).Result;
                if(pc!=null)
                {
                    ParcoursClientKYC_PP pcs = new ParcoursClientKYC_PP
                    {
                        Id = pc.Id,
                        Id_Client = pc.Compte_client__c,
                        CiviliteClient = pc.Civilite__c,
                        NomUsageClient = pc.Nom_usage__c,
                        NomNaissanceClient = pc.Nom_naissance__c,
                        Prenom1Client = pc.Prenom_1__c,
                        Prenom2Client = pc.Prenom_2__c,
                        Prenom3Client = pc.Prenom_3__c,
                        DateNaissanceClient = (pc.Date_naissance__c.HasValue ? (DateTime?)pc.Date_naissance__c.Value.Date : null),
                        DepartementNaissanceClient = pc.Dpt_naissance__c,
                        VilleNaissanceClient = pc.Ville_naissance__c,
                        Nationalite1Client = pc.Nationalite__c,
                        Nationalite2Client = pc.Nationalite_2__c,
                        Nationalite3Client = pc.Nationalite_3__c,
                        Nationalite4Client = pc.Nationalite_4__c,
                        SituationFamilialeClient = pc.Situation_familiale__c,
                        RegimeMatrimonialClient = pc.Regime_mat__c,
                        RegimeMatrimonialAutreClient = pc.Autre_regime_mat__c
                    };

                    return Ok(pcs);
                }
                else
                    return NotFound("Cet identifiant ne correspond à aucun parcours client connaissance client PP");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        /// <summary>
        /// Create a parcours client connaissance client PP.
        /// </summary>
        /// <param name="idClient">The client id</param>
        /// <param name="IdParcoursClient">The Parcours Client id</param>
        /// <returns>The parcours client connaissance client PP id with an HTTP 201, or error message with an HTTP 500</returns>
        /// <response code="201">Created</response>
        /// <response code="500">Error</response>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public IActionResult AddParcoursClientKYCPP([FromBody, Required] string idClient, [FromBody] string IdParcoursClient="")
        {
            try
            {
                string soqlWhere = "IsActive=true and DeveloperName='Connaissance_client_personne_physique' and SobjectType='Parcours_Client__c'";
                RecordType recordtype = SalesforceService.GetObject<RecordType>(soqlWhere).Result.First();


                string id = SalesforceService.AddFromObject("Parcours_Client__c", new Parcours_Client__c { RecordTypeId = recordtype.Id, Compte_client__c = idClient, Parcours_lie__c= IdParcoursClient }).Result;

                return CreatedAtRoute("ParcoursClientKYCPPDefault", id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Update one parcours client souscription.
        /// </summary>
        /// <remarks>
        /// Client property not present or null ==> unchanged
        /// </remarks>
        /// <param name="id">The parcours client souscription id</param>
        /// <param name="parClKYC_PP">The parcours client connaissance client PP client properties</param>
        /// <returns>null with an HTTP 204, warning message with an HTTP 404, or error message with an HTTP 500</returns>
        /// <response code="200">Updated with status return</response>
        /// <response code="204">Updated</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Error</response>
        /// <response code="502">Error Update server distant</response>
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [ProducesResponseType(502)]
        public IActionResult UpdateParcoursClientKYCPP(string id, [FromBody, Required] ParcoursClientKYC_PP parClKYC_PP)
        {
            try
            {
                string soqlWhere = "recordtype.DeveloperName='Connaissance_client_personne_physique'";
                Parcours_Client__c pc = SalesforceService.GetObjectFromId<Parcours_Client__c>(id, soqlWhere).Result;
                if (pc != null)
                {
                    pc.Civilite__c = parClKYC_PP.CiviliteClient == null ? pc.Civilite__c : parClKYC_PP.CiviliteClient;
                    pc.Nom_usage__c = parClKYC_PP.NomUsageClient == null ? pc.Nom_usage__c : parClKYC_PP.NomUsageClient;
                    pc.Nom_naissance__c = parClKYC_PP.NomNaissanceClient == null ? pc.Nom_naissance__c : parClKYC_PP.NomNaissanceClient;
                    pc.Prenom_1__c = parClKYC_PP.Prenom1Client == null ? pc.Prenom_1__c : parClKYC_PP.Prenom1Client;
                    pc.Prenom_2__c = parClKYC_PP.Prenom2Client == null ? pc.Prenom_2__c : parClKYC_PP.Prenom2Client;
                    pc.Prenom_3__c = parClKYC_PP.Prenom3Client == null ? pc.Prenom_3__c : parClKYC_PP.Prenom3Client;
                    pc.Date_naissance__c = parClKYC_PP.DateNaissanceClient == null ? pc.Date_naissance__c : parClKYC_PP.DateNaissanceClient;
                    pc.Dpt_naissance__c = parClKYC_PP.DepartementNaissanceClient == null ? pc.Dpt_naissance__c : parClKYC_PP.DepartementNaissanceClient;
                    pc.Ville_naissance__c = parClKYC_PP.VilleNaissanceClient == null ? pc.Ville_naissance__c : parClKYC_PP.VilleNaissanceClient;
                    pc.Nationalite__c = parClKYC_PP.Nationalite1Client == null ? pc.Nationalite__c : parClKYC_PP.Nationalite1Client;
                    pc.Plusieurs_nationalites__c = parClKYC_PP.Nationalite2Client == null ? pc.Plusieurs_nationalites__c : (!string.IsNullOrWhiteSpace(parClKYC_PP.Nationalite2Client)) ? "Non" : "Oui";
                    pc.Nationalite_2__c = parClKYC_PP.Nationalite2Client == null ? pc.Nationalite_2__c : parClKYC_PP.Nationalite2Client;
                    pc.Nationalite_3__c = parClKYC_PP.Nationalite3Client == null ? pc.Nationalite_3__c : parClKYC_PP.Nationalite3Client;
                    pc.Nationalite_4__c = parClKYC_PP.Nationalite4Client == null ? pc.Nationalite_4__c : parClKYC_PP.Nationalite4Client;
                    pc.Situation_familiale__c = parClKYC_PP.SituationFamilialeClient == null ? pc.Situation_familiale__c : parClKYC_PP.SituationFamilialeClient;
                    pc.Regime_mat__c = parClKYC_PP.RegimeMatrimonialClient == null ? pc.Regime_mat__c : parClKYC_PP.RegimeMatrimonialClient;
                    pc.Autre_regime_mat__c = parClKYC_PP.RegimeMatrimonialAutreClient == null ? pc.Autre_regime_mat__c : parClKYC_PP.RegimeMatrimonialAutreClient;
                    pc.Type_piece__c = parClKYC_PP.TypePIClient == null ? pc.Type_piece__c : parClKYC_PP.TypePIClient;
                    pc.Num_piece__c = parClKYC_PP.NumeroPIClient == null ? pc.Num_piece__c : parClKYC_PP.NumeroPIClient;
                    pc.Date_expiration__c = parClKYC_PP.DateExpirationPIClient == null ? pc.Date_expiration__c : parClKYC_PP.DateExpirationPIClient;
                    
                    var retour = SalesforceService.UpdateFromObject("Parcours_Client__c", id, pc).Result;

                    if (retour)
                    {
                        if (!string.IsNullOrWhiteSpace(pc.Parcours_lie__c))
                            id = pc.Parcours_lie__c;

                        pc = SalesforceService.GetObjectFromId<Parcours_Client__c>(id, soqlWhere).Result;
                        if (pc != null)
                        {
                            return Ok(new ParcoursClientKYC_PP.RetourStatut { Statut= pc.Statut__c, ListeDocumentAFournir=pc.Piece_joindre__c.Split(';').ToList() });
                        }
                        else
                            return NoContent();
                    }
                    else
                        return StatusCode(502, "Le serveur intermédiaire a renvoyé une réponse invalide lors de la mise à jour de l'objet: 'Parcours_Client__c'");
                }
                else
                    return NotFound("Cet identifiant ne correspond à aucun parcours client connaissance client PP");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        /*
        /// <summary>
        /// Update one parcours client souscription (client - Etape1).
        /// </summary>
        /// <remarks>
        /// Client property not present or null ==> unchanged
        /// </remarks>        
        /// <param name="id">The parcours client souscription id</param>
        /// <param name="clientE1">The parcours client connaissance client PP client step 1 properties</param>
        /// <returns>null with an HTTP 204, warning message with an HTTP 404, or error message with an HTTP 500</returns>
        /// <response code="204">Updated</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Error</response>
        [HttpPut("{id}/Client/Etape1")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult UpdateParcoursClientKYCPP_Client_Etape1(string id, [FromBody,Required] ParcoursClientKYC_PP.Client_Etape1 clientE1)
        {
            try
            {
                string soqlWhere = "recordtype.DeveloperName='Connaissance_client_personne_physique'";
                Parcours_Client__c pc = SalesforceService.GetObjectFromId<Parcours_Client__c>(id, soqlWhere).Result;
                if(pc!=null)
                {
                    pc.Civilite__c = clientE1.CiviliteClient==null? pc.Civilite__c: clientE1.CiviliteClient;
                    pc.Nom_usage__c = clientE1.NomUsageClient == null ? pc.Nom_usage__c: clientE1.NomUsageClient;
                    pc.Nom_naissance__c = clientE1.NomNaissanceClient == null ? pc.Nom_naissance__c: clientE1.NomNaissanceClient;
                    pc.Prenom_1__c = clientE1.Prenom1Client == null ? pc.Prenom_1__c: clientE1.Prenom1Client;
                    pc.Prenom_2__c = clientE1.Prenom2Client == null ? pc.Prenom_2__c: clientE1.Prenom2Client;
                    pc.Prenom_3__c = clientE1.Prenom3Client == null ? pc.Prenom_3__c: clientE1.Prenom3Client;
                    pc.Date_naissance__c = clientE1.DateNaissanceClient == null ? pc.Date_naissance__c: clientE1.DateNaissanceClient;
                    pc.Dpt_naissance__c = clientE1.DepartementNaissanceClient == null ? pc.Dpt_naissance__c: clientE1.DepartementNaissanceClient;
                    pc.Ville_naissance__c = clientE1.VilleNaissanceClient == null ? pc.Ville_naissance__c: clientE1.VilleNaissanceClient;
                    pc.Nationalite__c = clientE1.Nationalite1Client == null ? pc.Nationalite__c: clientE1.Nationalite1Client;
                    pc.Plusieurs_nationalites__c = clientE1.Nationalite2Client==null? pc.Plusieurs_nationalites__c:(!string.IsNullOrWhiteSpace(clientE1.Nationalite2Client))?"Non":"Oui";
                    pc.Nationalite_2__c = clientE1.Nationalite2Client == null ? pc.Nationalite_2__c: clientE1.Nationalite2Client;
                    pc.Nationalite_3__c = clientE1.Nationalite3Client == null ? pc.Nationalite_3__c: clientE1.Nationalite3Client;
                    pc.Nationalite_4__c = clientE1.Nationalite4Client == null ? pc.Nationalite_4__c: clientE1.Nationalite4Client;
                    pc.Situation_familiale__c = clientE1.SituationFamilialeClient == null ? pc.Situation_familiale__c: clientE1.SituationFamilialeClient;
                    pc.Regime_mat__c = clientE1.RegimeMatrimonialClient == null ? pc.Regime_mat__c: clientE1.RegimeMatrimonialClient;
                    pc.Autre_regime_mat__c = clientE1.RegimeMatrimonialAutreClient == null ? pc.Autre_regime_mat__c: clientE1.RegimeMatrimonialAutreClient;

                    var retour = SalesforceService.UpdateFromObject("Parcours_Client__c", id, pc);
                    return NoContent();
                }
                else
                    return NotFound("Cet identifiant ne correspond à aucun parcours client connaissance client PP");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        */

        /*
        /// <summary>
        /// Update one parcours client souscription (client - Etape2).
        /// </summary>
        /// <remarks>
        /// Client property not present or null ==> unchanged
        /// </remarks>
        /// <param name="id">The parcours client connaissance client PP id</param>
        /// <param name="clientE2">The parcours client connaissance client PP client step 2 properties</param>
        /// <returns>null with an HTTP 204, warning message with an HTTP 404, or error message with an HTTP 500</returns>
        /// <response code="204">Updated</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Error</response>
        [HttpPut("{id}/Client/Etape2")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult UpdateParcoursClientKYCPP_Client_Etape2(string id, [FromBody, Required] ParcoursClientKYC_PP.Client_Etape2 clientE2)
        {
            try
            {
                string soqlWhere = "recordtype.DeveloperName='Connaissance_client_personne_physique'";
                Parcours_Client__c pc = SalesforceService.GetObjectFromId<Parcours_Client__c>(id, soqlWhere).Result;
                if (pc != null)
                {
                    pc.Type_piece__c = clientE2.TypePIClient == null ? pc.Type_piece__c: clientE2.TypePIClient;
                    pc.Num_piece__c = clientE2.NumeroPIClient == null ? pc.Num_piece__c: clientE2.NumeroPIClient;
                    pc.Date_expiration__c = clientE2.DateExpirationPIClient == null ? pc.Date_expiration__c: clientE2.DateExpirationPIClient;

                    var retour = SalesforceService.UpdateFromObject("Parcours_Client__c", id, pc);
                    return NoContent();
                }
                else
                    return NotFound("Cet identifiant ne correspond à aucun parcours client connaissance client PP");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        */

        /// <summary>
        /// Delete one parcours client connaissance client PP by id.
        /// </summary>
        /// <param name="id">The parcours client connaissance client PP id</param>
        /// <returns>null with an HTTP 204, or error message with an HTTP 500</returns>
        /// <response code="204">Deleted</response>
        /// <response code="500">Error</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(500)]
        public IActionResult DeleteParcoursClientKYCPPById(string id)
        {
            try
            {
                var retour = SalesforceService.DeleteFromID("Parcours_Client__c", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
