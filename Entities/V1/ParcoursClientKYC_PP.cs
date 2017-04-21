using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.V1
{
    public class ParcoursClientKYC_PP
    {
        public string Id { get; set; }
        public string Id_Client { get; set; }
        public string Id_ParcoursClient { get; set; }


        //Etat civil
        public string CiviliteClient { get; set; }
        public string NomUsageClient { get; set; }
        public string NomNaissanceClient { get; set; }
        public string Prenom1Client { get; set; }
        public string Prenom2Client { get; set; }
        public string Prenom3Client { get; set; }
        public DateTime? DateNaissanceClient { get; set; }
        public string DepartementNaissanceClient { get; set; }
        public string VilleNaissanceClient { get; set; }
        public string Nationalite1Client { get; set; }
        public string Nationalite2Client { get; set; }
        public string Nationalite3Client { get; set; }
        public string Nationalite4Client { get; set; }
        public string SituationFamilialeClient { get; set; }
        public string RegimeMatrimonialClient { get; set; }
        public string RegimeMatrimonialAutreClient { get; set; }
        public string NomNaissanceConjoint { get; set; }
        public string PrenomNaissanceConjoint { get; set; }

        //PI: Piece Identite
        public string TypePIClient { get; set; }
        public string NumeroPIClient { get; set; }
        public DateTime? DateExpirationPIClient { get; set; }

        //Coordonnees
        public string TelephoneDomicileClient { get; set; }
        public string TelephoneMobileClient { get; set; }
        public string AdresseEmailClient { get; set; }


        //technique
        public string Statut { get; set; }
        public List<string> ListeDocumentAFournir { get; set; }

        public ParcoursClientKYC_PP() { }

        /*
        public ParcoursClientKYC_PP(Parcours_Client__c pc)
        {
            Id = pc.Id;
            Id_Client = pc.Compte_client__c;
            CiviliteClient = pc.Civilite__c;
            NomUsageClient = pc.Nom_usage__c;
            NomNaissanceClient = pc.Nom_naissance__c;
            Prenom1Client = pc.Prenom_1__c;
            Prenom2Client = pc.Prenom_2__c;
            Prenom3Client = pc.Prenom_3__c;
            DateNaissanceClient = (pc.Date_naissance__c.HasValue ? (DateTime?)pc.Date_naissance__c.Value.Date : null);
            DepartementNaissanceClient = pc.Dpt_naissance__c;
            VilleNaissanceClient = pc.Ville_naissance__c;
            Nationalite1Client = pc.Nationalite__c;
            Nationalite2Client = pc.Nationalite_2__c;
            Nationalite3Client = pc.Nationalite_3__c;
            Nationalite4Client = pc.Nationalite_4__c;
            SituationFamilialeClient = pc.Situation_familiale__c;
            RegimeMatrimonialClient = pc.Regime_mat__c;
            RegimeMatrimonialAutreClient = pc.Autre_regime_mat__c;
            Statut = pc.Statut__c;
            ListeDocumentAFournir = pc.Piece_joindre__c==null?new List<string>():pc.Piece_joindre__c.Split(';').ToList();
        }
        */


        public class RetourStatut
        {
            public string Statut { get; set; }
            public List<string> ListeDocumentAFournir { get; set; }
        }

        public class Update
        {
            //Etat civil
            public string CiviliteClient { get; set; }
            public string NomUsageClient { get; set; }
            public string NomNaissanceClient { get; set; }
            public string Prenom1Client { get; set; }
            public string Prenom2Client { get; set; }
            public string Prenom3Client { get; set; }
            public DateTime? DateNaissanceClient { get; set; }
            public string DepartementNaissanceClient { get; set; }
            public string VilleNaissanceClient { get; set; }
            public string Nationalite1Client { get; set; }
            public string Nationalite2Client { get; set; }
            public string Nationalite3Client { get; set; }
            public string Nationalite4Client { get; set; }
            public string SituationFamilialeClient { get; set; }
            public string RegimeMatrimonialClient { get; set; }
            public string RegimeMatrimonialAutreClient { get; set; }
            public string NomNaissanceConjoint { get; set; }
            public string PrenomNaissanceConjoint { get; set; }

            //PI: Piece Identite
            public string TypePIClient { get; set; }
            public string NumeroPIClient { get; set; }
            public DateTime? DateExpirationPIClient { get; set; }

            //Coordonnees
            public string TelephoneDomicileClient { get; set; }
            public string TelephoneMobileClient { get; set; }
            public string AdresseEmailClient { get; set; }
        }

        /*
        public class Client_Etape1
        {
            public string CiviliteClient { get; set; }
            public string NomUsageClient { get; set; }
            public string NomNaissanceClient { get; set; }
            public string Prenom1Client { get; set; }
            public string Prenom2Client { get; set; }
            public string Prenom3Client { get; set; }
            public DateTime? DateNaissanceClient { get; set; }
            public string DepartementNaissanceClient { get; set; }
            public string VilleNaissanceClient { get; set; }
            public string Nationalite1Client { get; set; }
            public string Nationalite2Client { get; set; }
            public string Nationalite3Client { get; set; }
            public string Nationalite4Client { get; set; }
            public string SituationFamilialeClient { get; set; }
            public string RegimeMatrimonialClient { get; set; }
            public string RegimeMatrimonialAutreClient { get; set; }
            public string NomNaissanceConjoint { get; set; }
            public string PrenomNaissanceConjoint { get; set; }
        }

        public class Client_Etape2
        {
            public string TypePIClient { get; set; }
            public string NumeroPIClient { get; set; }
            public DateTime? DateExpirationPIClient { get; set; }
        }

        public class Client_Etape3
        {
            public string TelephoneDomicileClient { get; set; }
            public string TelephoneMobileClient { get; set; }
            public string AdresseEmailClient { get; set; }
        }
        */
    }
}
