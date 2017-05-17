using Entities.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Salesforce
{
    public partial class Parcours_Client__c
    {
        public Parcours_Client__c() { }


        //Parcours Client KYC
        public Parcours_Client__c(ParcoursClientKYC_PP.AddParcoursClientKYC_PP addRecord)
        {
            RecordTypeId = addRecord.Id_RecordType;
            Compte_client__c = addRecord.Id_Client;
            Parcours_lie__c = addRecord.Id_ParcoursClient;
        }

        public ParcoursClientKYC_PP GetParcoursClientKYC_PP()
        {
            ParcoursClientKYC_PP pcKYC_PP = new ParcoursClientKYC_PP();

            pcKYC_PP.Id = Id;
            pcKYC_PP.Id_Client = Compte_client__c;
            pcKYC_PP.CiviliteClient = Civilite__c;
            pcKYC_PP.NomUsageClient = Nom_usage__c;
            pcKYC_PP.NomNaissanceClient = Nom_naissance__c;
            pcKYC_PP.Prenom1Client = Prenom_1__c;
            pcKYC_PP.Prenom2Client = Prenom_2__c;
            pcKYC_PP.Prenom3Client = Prenom_3__c;
            pcKYC_PP.DateNaissanceClient = (Date_naissance__c.HasValue ? (DateTime?)Date_naissance__c.Value.Date : null);
            pcKYC_PP.DepartementNaissanceClient = Dpt_naissance__c;
            pcKYC_PP.VilleNaissanceClient = Ville_naissance__c;
            pcKYC_PP.Nationalite1Client = Nationalite__c;
            pcKYC_PP.Nationalite2Client = Nationalite_2__c;
            pcKYC_PP.Nationalite3Client = Nationalite_3__c;
            pcKYC_PP.Nationalite4Client = Nationalite_4__c;
            pcKYC_PP.SituationFamilialeClient = Situation_familiale__c;
            pcKYC_PP.RegimeMatrimonialClient = Regime_mat__c;
            pcKYC_PP.RegimeMatrimonialAutreClient = Autre_regime_mat__c;
            pcKYC_PP.Statut = Statut__c;
            pcKYC_PP.ListeDocumentAFournir = Piece_joindre__c == null ? new List<string>() : Piece_joindre__c.Split(';').ToList();

            return pcKYC_PP;
        }

        public void UpdateParcoursClientKYC_PP(ParcoursClientKYC_PP.UpdateParcoursClientKYC_PP updateRecord)
        {
            Civilite__c = updateRecord.CiviliteClient == null ? Civilite__c : updateRecord.CiviliteClient;
            Nom_usage__c = updateRecord.NomUsageClient == null ? Nom_usage__c : updateRecord.NomUsageClient;
            Nom_naissance__c = updateRecord.NomNaissanceClient == null ? Nom_naissance__c : updateRecord.NomNaissanceClient;
            Prenom_1__c = updateRecord.Prenom1Client == null ? Prenom_1__c : updateRecord.Prenom1Client;
            Prenom_2__c = updateRecord.Prenom2Client == null ? Prenom_2__c : updateRecord.Prenom2Client;
            Prenom_3__c = updateRecord.Prenom3Client == null ? Prenom_3__c : updateRecord.Prenom3Client;
            Date_naissance__c = updateRecord.DateNaissanceClient == null ? Date_naissance__c : updateRecord.DateNaissanceClient;
            Dpt_naissance__c = updateRecord.DepartementNaissanceClient == null ? Dpt_naissance__c : updateRecord.DepartementNaissanceClient;
            Ville_naissance__c = updateRecord.VilleNaissanceClient == null ? Ville_naissance__c : updateRecord.VilleNaissanceClient;
            Nationalite__c = updateRecord.Nationalite1Client == null ? Nationalite__c : updateRecord.Nationalite1Client;
            Plusieurs_nationalites__c = updateRecord.Nationalite2Client == null ? Plusieurs_nationalites__c : (!string.IsNullOrWhiteSpace(updateRecord.Nationalite2Client)) ? "Non" : "Oui";
            Nationalite_2__c = updateRecord.Nationalite2Client == null ? Nationalite_2__c : updateRecord.Nationalite2Client;
            Nationalite_3__c = updateRecord.Nationalite3Client == null ? Nationalite_3__c : updateRecord.Nationalite3Client;
            Nationalite_4__c = updateRecord.Nationalite4Client == null ? Nationalite_4__c : updateRecord.Nationalite4Client;
            Situation_familiale__c = updateRecord.SituationFamilialeClient == null ? Situation_familiale__c : updateRecord.SituationFamilialeClient;
            Regime_mat__c = updateRecord.RegimeMatrimonialClient == null ? Regime_mat__c : updateRecord.RegimeMatrimonialClient;
            Autre_regime_mat__c = updateRecord.RegimeMatrimonialAutreClient == null ? Autre_regime_mat__c : updateRecord.RegimeMatrimonialAutreClient;
            Type_piece__c = updateRecord.TypePIClient == null ? Type_piece__c : updateRecord.TypePIClient;
            Num_piece__c = updateRecord.NumeroPIClient == null ? Num_piece__c : updateRecord.NumeroPIClient;
            Date_expiration__c = updateRecord.DateExpirationPIClient == null ? Date_expiration__c : updateRecord.DateExpirationPIClient;
        }


        //Parcours Client Souscription
        //public Parcours_Client__c(ParcoursClientSouscription.Add addRecord){}
        public ParcoursClientSouscription GetParcoursSouscription()
        {
            ParcoursClientSouscription pcs = new ParcoursClientSouscription();

            return pcs;
        }

        //public void ParcoursClientSouscription(ParcoursClientSouscription.Update updateRecord) {}
    }
}
