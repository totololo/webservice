using Newtonsoft.Json;
using Salesforce.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Salesforce
{
    public class NortiaContract__c
    {
        [Key]
        [Display(Name = "Record ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Numéro du contrat")]
        [StringLength(80)]
        public string Name { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Last Activity Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastActivityDate { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Display(Name = "Apporteur")]
        public string Apporteur__c { get; set; }

        [Display(Name = "Arbitrage autorisé")]
        public string Arbitrage_autorise__c { get; set; }

        [Display(Name = "Avance")]
        public double? Avance__c { get; set; }

        [Display(Name = "Avance en cours")]
        public bool Avance_en_cours__c { get; set; }

        [Display(Name = "Banques")]
        public string Banques__c { get; set; }

        [Display(Name = "Ville")]
        [StringLength(150)]
        public string City_Fisc__c { get; set; }

        [Display(Name = "Ville")]
        [StringLength(255)]
        public string City__c { get; set; }

        [Display(Name = "Clause Bénéficiaire")]
        public string Clause_Beneficiaire__c { get; set; }

        [Display(Name = "Clé Contrat")]
        [StringLength(10)]
        public string CleContrat__c { get; set; }

        [Display(Name = "Code Apporteur")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Code_Apporteur__c { get; set; }

        [Display(Name = "Code Nortia")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Code_Nortia__c { get; set; }

        [Display(Name = "Commentaire")]
        public string Commentaire__c { get; set; }

        [Display(Name = "Pays")]
        public string Country_Fisc__c { get; set; }

        [Display(Name = "Pays")]
        public string Country__c { get; set; }

        [Display(Name = "Date de réception")]
        public DateTimeOffset? DateReception__c { get; set; }

        [Display(Name = "Date de résiliation")]
        public DateTimeOffset? DateResiliation__c { get; set; }

        [Display(Name = "Date Debut Rachat Programmé")]
        public DateTimeOffset? Date_Debut_Rachat_Programme__c { get; set; }

        [Display(Name = "Date Debut Versement Programmé")]
        public DateTimeOffset? Date_Debut_Versement_Programme__c { get; set; }

        [Display(Name = "Numéro Contrat CNP")]
        [StringLength(50)]
        public string Numero_Contrat_CNP__c { get; set; }

        [Display(Name = "Date Fin Rachat Programmé")]
        public DateTimeOffset? Date_Fin_Rachat_Programme__c { get; set; }

        [Display(Name = "Date Fin Versement Programmé")]
        public DateTimeOffset? Date_Fin_Versement_Programme__c { get; set; }

        [Display(Name = "Date Situation")]
        public DateTimeOffset? Date_Situation__c { get; set; }

        [Display(Name = "Date de statut")]
        public DateTimeOffset? Date_Statut__c { get; set; }

        [Display(Name = "Date d'avenant")]
        public DateTimeOffset? Date_avenant__c { get; set; }

        [Display(Name = "Date de création du Contrat")]
        public DateTimeOffset? Date_de_creation__c { get; set; }

        [Display(Name = "Date de signature")]
        public DateTimeOffset? Date_de_signature__c { get; set; }

        [Display(Name = "Date de début")]
        public DateTimeOffset? Date_debut__c { get; set; }

        [Display(Name = "Date d'investissement")]
        public DateTimeOffset? Date_investissement__c { get; set; }

        [Display(Name = "Date d'ouverture")]
        public DateTimeOffset? Date_ouverture__c { get; set; }

        [Display(Name = "Dénouement")]
        public string Denouement__c { get; set; }

        [Display(Name = "Destinataires")]
        public string Destinataires__c { get; set; }

        [Display(Name = "Enveloppe")]
        public string Enveloppe__c { get; set; }

        [Display(Name = "Fiscalité")]
        public string Fiscalite__c { get; set; }

        [Display(Name = "Frais de gestion")]
        public double? Frais_gestion__c { get; set; }

        [Display(Name = "ID Contrat")]
        public double? ID_DW__c { get; set; }

        [Display(Name = "Mandat de Gestion")]
        public bool Mandat_Gestion__c { get; set; }

        [Display(Name = "Mode de paiement")]
        public string Mode_paiement__c { get; set; }

        [Display(Name = "Montant Rachat Programmé")]
        public double? Montant_Rachat_Programme__c { get; set; }

        [Display(Name = "Montant Versement Programmé")]
        public double? Montant_Versement_Programme__c { get; set; }

        [Display(Name = "Motif de résiliation")]
        public string Motif_resiliation__c { get; set; }

        [Display(Name = "Nantissement")]
        public bool Nantissement__c { get; set; }

        [Display(Name = "Periodicité Rachat Programmé")]
        [StringLength(255)]
        public string Periodicite_Rachat_Programme__c { get; set; }

        [Display(Name = "Periodicité Versement Programmé")]
        [StringLength(255)]
        public string Periodicite_Versement_Programme__c { get; set; }

        [Display(Name = "Code Postal")]
        [StringLength(150)]
        public string PostalCode_Fisc__c { get; set; }

        [Display(Name = "Code Postal")]
        [StringLength(255)]
        public string PostalCode__c { get; set; }

        [Display(Name = "Procuration : Opération concernées")]
        public string Procuration_Operation_concernees__c { get; set; }

        [Display(Name = "Procuration")]
        public bool Procuration__c { get; set; }

        [Display(Name = "Rachat Programmé")]
        public bool Rachat_Programme__c { get; set; }

        [Display(Name = "Rachat")]
        public double? Rachat__c { get; set; }

        [Display(Name = "Remboursement d'avance")]
        public double? Remboursement_avance__c { get; set; }

        [Display(Name = "Reprise")]
        public bool Reprise__c { get; set; }

        [Display(Name = "Situation")]
        public double? Situation__c { get; set; }

        [Display(Name = "Statut")]
        public string Statut__c { get; set; }

        [Display(Name = "Adresse")]
        public string Street_Fisc__c { get; set; }

        [Display(Name = "Adresse")]
        public string Street__c { get; set; }

        [Display(Name = "Type de Souscription")]
        public string Type_Souscription__c { get; set; }

        [Display(Name = "Type d'option de gestion")]
        public string Type_option_de_gestion__c { get; set; }

        [Display(Name = "Versement Programmé")]
        public bool Versement_Programme__c { get; set; }

        [Display(Name = "Versement")]
        public double? Versement__c { get; set; }

        [Display(Name = "Zone")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Zone__c { get; set; }

        [Display(Name = "Date d'effet")]
        public DateTimeOffset? Date_Effet__c { get; set; }

        [Display(Name = "Droit Fiscal")]
        public string Droit_Fiscal__c { get; set; }

        [Display(Name = "Liste des documents de nantissement")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string documents_nantissement__c { get; set; }

        [Display(Name = "Option Fiscale")]
        public string Option_Fiscale__c { get; set; }

        [Display(Name = "Code Assureur")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Code_Assureur__c { get; set; }

        [Display(Name = "Code Apporteur Commission")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Code_Apporteur_Commission__c { get; set; }

        [Display(Name = "Code Apporteur Compagnie")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Code_Apporteur_Compagnie__c { get; set; }

        [Display(Name = "Appartement")]
        [StringLength(10)]
        public string Appt__c { get; set; }

        [Display(Name = "Fiscalité enveloppe")]
        public string fiscalite_enveloppe__c { get; set; }

        [Display(Name = "Apporteur Référent")]
        public string Apporteur_Referent__c { get; set; }

        [Display(Name = "Complément d'adresse")]
        [StringLength(32)]
        public string Complement_adresse__c { get; set; }

        [Display(Name = "Service de distribution éventuel")]
        [StringLength(32)]
        public string Service_distrib__c { get; set; }

    }
}
