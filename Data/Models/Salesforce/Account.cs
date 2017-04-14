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
    public class Account
    {
        [Key]
        [Display(Name = "Account ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Master Record ID")]
        [Createable(false), Updateable(false)]
        public string MasterRecordId { get; set; }

        [Display(Name = "Account Name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(80)]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [StringLength(40)]
        public string FirstName { get; set; }

        public string Salutation { get; set; }

        [Display(Name = "Account Type")]
        public string Type { get; set; }

        [Display(Name = "Record Type ID")]
        public string RecordTypeId { get; set; }

        [Display(Name = "Groupe")]
        public string ParentId { get; set; }

        [Display(Name = "Billing Street")]
        public string BillingStreet { get; set; }

        [Display(Name = "Billing City")]
        [StringLength(40)]
        public string BillingCity { get; set; }

        [Display(Name = "Billing State/Province")]
        [StringLength(80)]
        public string BillingState { get; set; }

        [Display(Name = "Billing Zip/Postal Code")]
        [StringLength(20)]
        public string BillingPostalCode { get; set; }

        [Display(Name = "Billing Country")]
        [StringLength(80)]
        public string BillingCountry { get; set; }

        [Display(Name = "Billing State/Province Code")]
        public string BillingStateCode { get; set; }

        [Display(Name = "Billing Country Code")]
        public string BillingCountryCode { get; set; }

        [Display(Name = "Billing Latitude")]
        public double? BillingLatitude { get; set; }

        [Display(Name = "Billing Longitude")]
        public double? BillingLongitude { get; set; }

        [Display(Name = "Shipping Street")]
        public string ShippingStreet { get; set; }

        [Display(Name = "Shipping City")]
        [StringLength(40)]
        public string ShippingCity { get; set; }

        [Display(Name = "Shipping State/Province")]
        [StringLength(80)]
        public string ShippingState { get; set; }

        [Display(Name = "Shipping Zip/Postal Code")]
        [StringLength(20)]
        public string ShippingPostalCode { get; set; }

        [Display(Name = "Shipping Country")]
        [StringLength(80)]
        public string ShippingCountry { get; set; }

        [Display(Name = "Shipping State/Province Code")]
        public string ShippingStateCode { get; set; }

        [Display(Name = "Shipping Country Code")]
        public string ShippingCountryCode { get; set; }

        [Display(Name = "Shipping Latitude")]
        public double? ShippingLatitude { get; set; }

        [Display(Name = "Shipping Longitude")]
        public double? ShippingLongitude { get; set; }

        [Display(Name = "Account Phone")]
        [Phone]
        public string Phone { get; set; }

        [Display(Name = "Account Fax")]
        [Phone]
        public string Fax { get; set; }

        [Display(Name = "Account Number")]
        [StringLength(40)]
        public string AccountNumber { get; set; }

        [Url]
        public string Website { get; set; }

        [Display(Name = "Photo URL")]
        [Url]
        [Createable(false), Updateable(false)]
        public string PhotoUrl { get; set; }

        [Display(Name = "SIC Code")]
        [StringLength(20)]
        public string Sic { get; set; }

        public string Industry { get; set; }

        [Display(Name = "Annual Revenue")]
        public double? AnnualRevenue { get; set; }

        [Display(Name = "Employees")]
        public int? NumberOfEmployees { get; set; }

        public string Ownership { get; set; }

        [Display(Name = "Ticker Symbol")]
        [StringLength(20)]
        public string TickerSymbol { get; set; }

        [Display(Name = "Account Description")]
        public string Description { get; set; }

        [Display(Name = "Account Rating")]
        public string Rating { get; set; }

        [Display(Name = "Account Site")]
        [StringLength(80)]
        public string Site { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

        [Display(Name = "Last Activity")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastActivityDate { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Display(Name = "Partner Account")]
        [Createable(false)]
        public bool IsPartner { get; set; }

        [Display(Name = "Customer Portal Account")]
        [Createable(false)]
        public bool IsCustomerPortal { get; set; }

        [Display(Name = "Contact ID")]
        [Createable(false), Updateable(false)]
        public string PersonContactId { get; set; }

        [Display(Name = "Is Person Account")]
        [Createable(false), Updateable(false)]
        public bool IsPersonAccount { get; set; }

        [Display(Name = "Mailing Street")]
        public string PersonMailingStreet { get; set; }

        [Display(Name = "Mailing City")]
        [StringLength(40)]
        public string PersonMailingCity { get; set; }

        [Display(Name = "Mailing State/Province")]
        [StringLength(80)]
        public string PersonMailingState { get; set; }

        [Display(Name = "Mailing Zip/Postal Code")]
        [StringLength(20)]
        public string PersonMailingPostalCode { get; set; }

        [Display(Name = "Mailing Country")]
        [StringLength(80)]
        public string PersonMailingCountry { get; set; }

        [Display(Name = "Mailing State/Province Code")]
        public string PersonMailingStateCode { get; set; }

        [Display(Name = "Mailing Country Code")]
        public string PersonMailingCountryCode { get; set; }

        [Display(Name = "Mailing Latitude")]
        public double? PersonMailingLatitude { get; set; }

        [Display(Name = "Mailing Longitude")]
        public double? PersonMailingLongitude { get; set; }

        [Display(Name = "Street")]
        public string PersonOtherStreet { get; set; }

        [Display(Name = "City")]
        [StringLength(40)]
        public string PersonOtherCity { get; set; }

        [Display(Name = "State/Province")]
        [StringLength(80)]
        public string PersonOtherState { get; set; }

        [Display(Name = "Zip/Postal Code")]
        [StringLength(20)]
        public string PersonOtherPostalCode { get; set; }

        [Display(Name = "Country")]
        [StringLength(80)]
        public string PersonOtherCountry { get; set; }

        [Display(Name = "Other State/Province Code")]
        public string PersonOtherStateCode { get; set; }

        [Display(Name = "Country Code")]
        public string PersonOtherCountryCode { get; set; }

        [Display(Name = "Other Latitude")]
        public double? PersonOtherLatitude { get; set; }

        [Display(Name = "Other Longitude")]
        public double? PersonOtherLongitude { get; set; }

        [Display(Name = "Mobile")]
        [Phone]
        public string PersonMobilePhone { get; set; }

        [Display(Name = "Home Phone")]
        [Phone]
        public string PersonHomePhone { get; set; }

        [Display(Name = "Other Phone")]
        [Phone]
        public string PersonOtherPhone { get; set; }

        [Display(Name = "Asst. Phone")]
        [Phone]
        public string PersonAssistantPhone { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string PersonEmail { get; set; }

        [Display(Name = "Title")]
        [StringLength(80)]
        public string PersonTitle { get; set; }

        [Display(Name = "Department")]
        [StringLength(80)]
        public string PersonDepartment { get; set; }

        [Display(Name = "Assistant")]
        [StringLength(40)]
        public string PersonAssistantName { get; set; }

        [Display(Name = "Lead Source")]
        public string PersonLeadSource { get; set; }

        [Display(Name = "Birthdate")]
        public DateTimeOffset? PersonBirthdate { get; set; }

        [Display(Name = "Email Opt Out")]
        public bool PersonHasOptedOutOfEmail { get; set; }

        [Display(Name = "Fax Opt Out")]
        public bool PersonHasOptedOutOfFax { get; set; }

        [Display(Name = "Do Not Call")]
        public bool PersonDoNotCall { get; set; }

        [Display(Name = "Last Stay-in-Touch Request Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? PersonLastCURequestDate { get; set; }

        [Display(Name = "Last Stay-in-Touch Save Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? PersonLastCUUpdateDate { get; set; }

        [Display(Name = "Email Bounced Reason")]
        [StringLength(255)]
        public string PersonEmailBouncedReason { get; set; }

        [Display(Name = "Email Bounced Date")]
        public DateTimeOffset? PersonEmailBouncedDate { get; set; }

        [Display(Name = "Data.com Key")]
        [StringLength(20)]
        public string Jigsaw { get; set; }

        [Display(Name = "Jigsaw Company ID")]
        [StringLength(20)]
        [Createable(false), Updateable(false)]
        public string JigsawCompanyId { get; set; }

        [Display(Name = "Account Source")]
        public string AccountSource { get; set; }

        [Display(Name = "SIC Description")]
        [StringLength(80)]
        public string SicDesc { get; set; }

        [Display(Name = "Adresse email de gestion")]
        [EmailAddress]
        public string Adresse_email_gestion__c { get; set; }

        [Display(Name = "CRM_ID")]
        [StringLength(100)]
        public string CRM_ID__c { get; set; }

        [Display(Name = "Catégorie Commission NI")]
        public string Categorie_Commission_NI__c { get; set; }

        [Display(Name = "Suspension Paiement")]
        public bool Suspension_Paiement__c { get; set; }

        [Display(Name = "Nom Comptable")]
        public string Nom_Comptable__c { get; set; }

        [Display(Name = "Catégorie Commission")]
        public string Categorie_Commission__c { get; set; }

        [Display(Name = "Actif")]
        public bool Actif__c { get; set; }

        [Display(Name = "Adresses Mails de Gestion")]
        public string Adresses_Gestion_NI__c { get; set; }

        [Display(Name = "Chambre Syndicale")]
        public string Chambre_Syndicale__c { get; set; }

        [Display(Name = "Classification")]
        public string Classification__c { get; set; }

        [Display(Name = "Clé Apporteur")]
        [StringLength(10)]
        public string CleApporteur__c { get; set; }

        [Display(Name = "Clé Groupe")]
        [StringLength(15)]
        public string Cle_Groupe__c { get; set; }

        [Display(Name = "Code AEP")]
        [StringLength(50)]
        public string Code_AEP__c { get; set; }

        [Display(Name = "Code Assureur")]
        [StringLength(10)]
        public string Code_Assureur__c { get; set; }

        [Display(Name = "Code LMP")]
        [StringLength(50)]
        public string Code_LMP__c { get; set; }

        [Display(Name = "Code LMEP")]
        [StringLength(50)]
        public string Code_LMEP__c { get; set; }

        [Display(Name = "Code Nortia")]
        [StringLength(50)]
        public string Code_Nortia__c { get; set; }

        [Display(Name = "Code Pro Capital")]
        [StringLength(50)]
        public string Code_Pro_Capital__c { get; set; }

        [Display(Name = "Code SPIRICA")]
        [StringLength(50)]
        public string Code_SPIRICA__c { get; set; }

        [Display(Name = "ADM")]
        public bool ADM__c { get; set; }

        [Display(Name = "IR")]
        public bool IR__c { get; set; }

        [Display(Name = "Groupement")]
        public string Groupement__c { get; set; }

        [Display(Name = "IS")]
        public bool IS__c { get; set; }

        [Display(Name = "Login LMEP")]
        [StringLength(50)]
        public string Login_LMEP__c { get; set; }

        [Display(Name = "NUM_DWH")]
        [StringLength(10)]
        public string NUM_DWH__c { get; set; }

        [Display(Name = "Niveau")]
        public string Niveau__c { get; set; }

        [Display(Name = "ORIAS Date Fin")]
        public DateTimeOffset? ORIAS_Date_Fin__c { get; set; }

        [Display(Name = "ORIAS")]
        [StringLength(50)]
        public string ORIAS__c { get; set; }

        [Display(Name = "Mot de passe LMEP")]
        [StringLength(50)]
        public string Password_LMEP__c { get; set; }

        [Display(Name = "Profession")]
        public string Profession__c { get; set; }

        [Display(Name = "SIRET")]
        [StringLength(50)]
        public string SIRET__c { get; set; }

        [Display(Name = "Zone Géographique")]
        public string Zone_Geo__c { get; set; }

        [Display(Name = "Code Postal")]
        [StringLength(20)]
        public string Code_Postal_NI__c { get; set; }

        [Display(Name = "Contact Commercial")]
        public string Contact_Commercial__c { get; set; }

        [Display(Name = "Adresse e-mail")]
        [EmailAddress]
        public string Email_NI__c { get; set; }

        [Display(Name = "Adresse email - DEL")]
        [EmailAddress]
        public string Email__c { get; set; }

        [Display(Name = "Entite_Tech")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Entite_Tech__c { get; set; }

        [Display(Name = "Entité")]
        public string Entite__c { get; set; }

        [Display(Name = "Fax")]
        [Phone]
        public string Fax_NI__c { get; set; }

        [Display(Name = "Forme juridique")]
        public string Forme_juridique__c { get; set; }

        [Display(Name = "Pays")]
        public string Pays_NI__c { get; set; }

        [Display(Name = "Région / Département")]
        [StringLength(80)]
        public string Region_Departement_NI__c { get; set; }

        [Display(Name = "Rue")]
        public string Rue_NI__c { get; set; }

        [Display(Name = "Suspension accès internet")]
        public string Suspension_acces_internet__c { get; set; }

        [Display(Name = "Téléphone")]
        [Phone]
        public string Telephone_NI__c { get; set; }

        [Display(Name = "Type de relation")]
        public string Type_de_relation__c { get; set; }

        [Display(Name = "Ville")]
        [StringLength(40)]
        public string Ville_NI__c { get; set; }

        [Display(Name = "Lutte contre blanchiment")]
        public bool Lutte_contre_blanchiment__c { get; set; }

        [Display(Name = "Agrégateur 1")]
        public string Agregateur1__c { get; set; }

        [Display(Name = "Agrégateur 2")]
        public string Agregateur2__c { get; set; }

        [Display(Name = "Taux TVA")]
        public string Taux_TVA__c { get; set; }

        [Display(Name = "IntraCom")]
        [StringLength(100)]
        public string IntraCom__c { get; set; }

        [Display(Name = "Id SFDC Sous")]
        [StringLength(18)]
        public string Id_SFDC_Sous__c { get; set; }

        [Display(Name = "Kbis")]
        public bool Kbis__c { get; set; }

        [Display(Name = "N° Titulaire")]
        [StringLength(9)]
        public string N_Titulaire__c { get; set; }

        [Display(Name = "PPE")]
        public bool PPE__c { get; set; }

        [Display(Name = "Statuts")]
        public bool Statuts__c { get; set; }

        [Display(Name = "Téléphone Mobile")]
        [Phone]
        public string Telephone_Mobile_NI__c { get; set; }

        [Display(Name = "Dissolution")]
        public bool Dissolution__c { get; set; }

        [Display(Name = "Conjoint")]
        public string Conjoint__c { get; set; }

        [Display(Name = "Âge")]
        [Createable(false), Updateable(false)]
        public double? Age__c { get; set; }

        [Display(Name = "Equipe Backoffice")]
        public string Equipe_Backoffice__c { get; set; }

        [Display(Name = "Cle Souscripteur")]
        [StringLength(10)]
        public string CleSouscripteur__c { get; set; }

        [Display(Name = "Date de validité pièce d'identité")]
        public DateTimeOffset? Date_validite_CNI__c { get; set; }

        [Display(Name = "Fiscalité")]
        public string Fiscalite__c { get; set; }

        [Display(Name = "Personne Protégée")]
        public bool Majeur_Protege__c { get; set; }

        [Display(Name = "Nationalité")]
        public string Nationalite__c { get; set; }

        [Display(Name = "Options de Gestion")]
        public string Options_de_Gestion__c { get; set; }

        [Display(Name = "Régime matrimonial")]
        public string Regime_matrimonial__c { get; set; }

        [Display(Name = "Reprise")]
        public bool Reprise__c { get; set; }

        [Display(Name = "Type de protection")]
        public string Type_protection__c { get; set; }

        [Display(Name = "Adresse e-mail")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Adresse_Email__c { get; set; }

        [Display(Name = "IsPartnerAccount")]
        public bool IsPartnerAccount__c { get; set; }

        [Display(Name = "Téléphone mobile")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Telephone_mobile__c { get; set; }

        [Display(Name = "Origine CGP")]
        public string Origine_CGP__c { get; set; }

        [Display(Name = "Code CNP")]
        [StringLength(50)]
        public string Code_CNP__c { get; set; }

        [Display(Name = "QIS CNP")]
        [StringLength(50)]
        public string QIS_CNP__c { get; set; }

        [Display(Name = "Apporteur Commissions")]
        public string Apporteur_Commissions__c { get; set; }

        [Display(Name = "Non validité ORIAS")]
        public bool Non_Validite_ORIAS__c { get; set; }

        [Display(Name = "Code IWI")]
        [StringLength(50)]
        public string Code_IWI__c { get; set; }

        [Display(Name = "Partenaire")]
        public bool Partenaire__c { get; set; }

        [Display(Name = "# Encours")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Encours__c { get; set; }

        [Display(Name = "# Production Brute")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Production_Brute__c { get; set; }

        [Display(Name = "# Production Nette")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Production_Nette__c { get; set; }

        [Display(Name = "# Rachats")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Rachats__c { get; set; }

        [Display(Name = "Représentant légal sur:")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Representant_legal__c { get; set; }

        [Display(Name = "Encours CGP")]
        [Createable(false), Updateable(false)]
        public double? Encours_CGP__c { get; set; }

        [Display(Name = "N° SIREN")]
        [StringLength(20)]
        public string SIREN__c { get; set; }

        [Display(Name = "Situation matrimoniale")]
        public string Situation_matrimoniale__c { get; set; }

        [Display(Name = "Code CIF")]
        [StringLength(5)]
        public string Code_CIF__c { get; set; }

        [Display(Name = "Code Catégorie Socioprofessionnelle")]
        public string Code_Categorie_Socioprof__c { get; set; }

        [Display(Name = "Envoi Courrier")]
        public string Envoi_Courrier__c { get; set; }

        [Display(Name = "Envoi Scan")]
        public string Envoi_Scan__c { get; set; }

        [Display(Name = "Type de génération Courrier")]
        public string Type_generation_Courrier__c { get; set; }

        [Display(Name = "Type de génération Scan")]
        public string Type_generation_Scan__c { get; set; }

        [Display(Name = "Pas de mail")]
        public bool Pas_de_mail__c { get; set; }

        [Display(Name = "Non validité CIF")]
        public bool Non_validit_CIF__c { get; set; }

        [Display(Name = "Lieu de naissance")]
        [StringLength(200)]
        public string Lieu_de_naissance__c { get; set; }

        [Display(Name = "Type d'envoi sur les fichiers PDF")]
        public bool Type_d_envoi_sur_les_fichiers_PDF__c { get; set; }

        [Display(Name = "# RFM")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string RFM__c { get; set; }

        [Display(Name = "Non validité IOBSP")]
        public bool Non_validit_IOBSP__c { get; set; }

        [Display(Name = "Delubac")]
        public bool Delubac__c { get; set; }

        [Display(Name = "Prévoyance")]
        public bool Pr_voyance__c { get; set; }

        [Display(Name = "CNI echue")]
        [Createable(false), Updateable(false)]
        public bool CNI_echue__c { get; set; }

        [Display(Name = "Appartement")]
        [StringLength(10)]
        public string Appt__c { get; set; }

        [Display(Name = "Complément d'adresse")]
        [StringLength(32)]
        public string Complement_adresse__c { get; set; }

        [Display(Name = "Top 50")]
        public string Top_50__c { get; set; }

        [Display(Name = "Code CIF EDD")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Code_CIF_EDD__c { get; set; }

        [Display(Name = "Service de distribution éventuel")]
        [StringLength(32)]
        public string Service_distrib__c { get; set; }

        [Display(Name = "Conjoint")]
        public string Conjoint__pc { get; set; }

        [Display(Name = "NUM_DWH")]
        [StringLength(10)]
        public string NUM_DWH__pc { get; set; }

        [Display(Name = "Profession")]
        [StringLength(255)]
        public string Profession__pc { get; set; }

        [Display(Name = "Décédé")]
        public bool? Decede__pc { get; set; }

        [Display(Name = "Apporteur")]
        public string Compte__pc { get; set; }

        [Display(Name = "Clé Souscripteur")]
        public double? Cle_Souscripteur__pc { get; set; }

        [Display(Name = "Clé Contact")]
        [StringLength(10)]
        public string Cle_Contact__pc { get; set; }

        [Display(Name = "ID Souscripteur")]
        public double? ID_Souscripteur__pc { get; set; }

        [Display(Name = "Recoit Reponses Client")]
        public bool? Recoit_Reponses_Client__pc { get; set; }

        [Display(Name = "UserId")]
        [StringLength(18)]
        public string UserId__pc { get; set; }

        [Display(Name = "Rôle")]
        public string Role__pc { get; set; }

        [Display(Name = "CRM_ID")]
        [StringLength(100)]
        public string CRM_ID__pc { get; set; }

        [Display(Name = "Fax")]
        [Phone]
        public string Fax_NI__pc { get; set; }

        [Display(Name = "Téléphone Mobile")]
        [Phone]
        public string Mobile_NI__pc { get; set; }

        [Display(Name = "Téléphone Professionnel")]
        [Phone]
        public string Telephone_Professionnel__pc { get; set; }

        [Display(Name = "Téléphone domicile")]
        [Phone]
        public string Telephone_domicile_NI__pc { get; set; }

        [Display(Name = "Téléphone domicile")]
        [Phone]
        public string Telephone_domicile__pc { get; set; }

        [Display(Name = "Adresse e-mail 2")]
        [EmailAddress]
        public string email_2__pc { get; set; }

        [Display(Name = "Adresse e-mail 3")]
        [EmailAddress]
        public string email_3__pc { get; set; }

        [Display(Name = "Adresse e-mail - DEL")]
        [EmailAddress]
        public string email_NI__pc { get; set; }

        [Display(Name = "Acte de convention de preuve")]
        [StringLength(12)]
        public string Acte_de_convention_de_preuve__pc { get; set; }

        [Display(Name = "Date du Décès")]
        public DateTimeOffset? Date_Deces__pc { get; set; }

        [Display(Name = "Date de validité pièce d'identité")]
        public DateTimeOffset? Date_validite_CNI__pc { get; set; }

        [Display(Name = "Id SFDC Sous")]
        [StringLength(18)]
        public string Id_SFDC_Sous__pc { get; set; }

        [Display(Name = "N° Titulaire")]
        [StringLength(15)]
        public string N_Titulaire__pc { get; set; }

        [Display(Name = "Date convention de preuve")]
        public DateTimeOffset? Date_convention_de_preuve__pc { get; set; }

        [Display(Name = "Type MIF")]
        public string Type_MIF__pc { get; set; }

        [Display(Name = "Date Modification MIF")]
        public DateTimeOffset? Date_Modification_MIF__pc { get; set; }

        [Display(Name = "AccountId")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string AccountId_Tech__pc { get; set; }

        [Display(Name = "Activé N+")]
        public bool? Active_NPlus__pc { get; set; }

        [Display(Name = "Catégorie Socioprofessionnelle")]
        public string Categorie_Socioprofessionnelle__pc { get; set; }

        [Display(Name = "Nom de naissance")]
        [StringLength(80)]
        public string Nom_jeune_fille__pc { get; set; }

        [Display(Name = "Code Catégorie Socioprofessionnelle")]
        public string Code_Categorie_Socioprof__pc { get; set; }

        [Display(Name = "Type de compte")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Type_de_compte__pc { get; set; }

        [Display(Name = "Nortien")]
        public bool? Nortien__pc { get; set; }

        [Display(Name = "Mobile Opt Out")]
        public bool? et4ae5__HasOptedOutOfMobile__pc { get; set; }

        [Display(Name = "Pays de naissance")]
        public string Pays_naissance__pc { get; set; }

        [Display(Name = "Département de naissance")]
        public string Dpt_naissance__pc { get; set; }

        [Display(Name = "Autre régime matrimonial")]
        [StringLength(200)]
        public string Autre_regime_mat__pc { get; set; }

        [Display(Name = "Type de pièce d'identité")]
        public string Type_piece__pc { get; set; }

        [Display(Name = "Numéro de pièce d'identité")]
        [StringLength(100)]
        public string Num_piece__pc { get; set; }

        [Display(Name = "Lieu de délivrance pièce d'identité")]
        [StringLength(100)]
        public string Lieu_delivrance__pc { get; set; }

        [Display(Name = "Date de délivrance pièce d'identité")]
        public DateTimeOffset? Date_delivrance__pc { get; set; }

        [Display(Name = "Résident fiscal français")]
        public string Resident_fisc_fr__pc { get; set; }

        [Display(Name = "Numéro fiscal français")]
        [StringLength(100)]
        public string Num_fisc_fr__pc { get; set; }

        [Display(Name = "Imposable qu'au pays de souscription ?")]
        public string Imposable_que_pays_souscription__pc { get; set; }

        [Display(Name = "Pays de résidence fiscale autre que US 1")]
        public string Pays_resid_fisc_non_US_1__pc { get; set; }

        [Display(Name = "Numéro d'identification fiscale (NIF) 1")]
        [StringLength(100)]
        public string NIF_1__pc { get; set; }

        [Display(Name = "Pays de résidence fiscale autre que US 2")]
        public string Pays_resid_fisc_non_US_2__pc { get; set; }

        [Display(Name = "Numéro d'identification fiscale (NIF) 2")]
        [StringLength(100)]
        public string NIF_2__pc { get; set; }

        [Display(Name = "Pays de résidence fiscale autre que US 3")]
        public string Pays_resid_fisc_non_US_3__pc { get; set; }

        [Display(Name = "Numéro d'identification fiscale (NIF) 3")]
        [StringLength(100)]
        public string NIF_3__pc { get; set; }

        [Display(Name = "Citoyen des Etats-Unis d’Amérique ?")]
        public string Citoyen_USA__pc { get; set; }

        [Display(Name = "Résident fiscal des USA ?")]
        public string Resident_fisc_USA__pc { get; set; }

        [Display(Name = "Numéro d'immatriculation fiscal des USA")]
        [StringLength(100)]
        public string Num_immat_fisc_USA__pc { get; set; }

        [Display(Name = "Situation professionnelle")]
        public string Situation_pro__pc { get; set; }

        [Display(Name = "Statut professionnel du salarié")]
        public string Statut_salarie__pc { get; set; }

        [Display(Name = "Secteur d'activité")]
        [StringLength(255)]
        public string Secteur_activite__pc { get; set; }

        [Display(Name = "Pays de la fonction")]
        public string Pays_fonction__pc { get; set; }

        [Display(Name = "Ville de la fonction")]
        [StringLength(100)]
        public string Ville_fonction__pc { get; set; }

        [Display(Name = "L'organisation")]
        [StringLength(255)]
        public string Organisation__pc { get; set; }

        [Display(Name = "Début de la fonction")]
        public DateTimeOffset? Debut_fonction__pc { get; set; }

        [Display(Name = "Fin de la fonction")]
        public DateTimeOffset? Fin_fonction__pc { get; set; }

        [Display(Name = "Membre de la famille du client PPE")]
        public string Proche_PPE__pc { get; set; }

        [Display(Name = "Nom du proche PPE")]
        [StringLength(80)]
        public string Proche_nom__pc { get; set; }

        [Display(Name = "Prénom(s) du proche PPE")]
        [StringLength(120)]
        public string Proche_prenom__pc { get; set; }

        [Display(Name = "Lien de parenté du proche PPE")]
        [StringLength(100)]
        public string Proche_lien__pc { get; set; }

        [Display(Name = "Fonction du proche PPE")]
        [StringLength(150)]
        public string Proche_fonction_exercee__pc { get; set; }

        [Display(Name = "Pays de la fonction du proche PPE")]
        public string Pays_fonction_proche_PPE__pc { get; set; }

        [Display(Name = "Ville de la fonction du proche PPE")]
        [StringLength(100)]
        public string Ville_fonction_proche_PPE__pc { get; set; }

        [Display(Name = "Début de la fonction du proche PPE")]
        public DateTimeOffset? Debut_fonction_proche_PPE__pc { get; set; }

        [Display(Name = "Fin de la fonction du proche PPE")]
        public DateTimeOffset? Fin_fonction_proche_PPE__pc { get; set; }

        [Display(Name = "Revenus annuels du foyer fiscal")]
        public double? Revenus_annuels_foyer_fisc__pc { get; set; }

        [Display(Name = "Salaires")]
        public bool? Nature_revenu_salaire__pc { get; set; }

        [Display(Name = "Pourcentage lié aux salaires")]
        public double? Pourcent_salaires__pc { get; set; }

        [Display(Name = "Pensions")]
        public bool? Nature_revenu_pension__pc { get; set; }

        [Display(Name = "Pourcentage lié aux pensions")]
        public double? Pourcent_pensions__pc { get; set; }

        [Display(Name = "Revenus fonciers")]
        public bool? Nature_revenu_foncier__pc { get; set; }

        [Display(Name = "Pourcentage lié aux revenus fonciers")]
        public double? Pourcent_fonciers__pc { get; set; }

        [Display(Name = "Revenus financiers")]
        public bool? Nature_revenu_financier__pc { get; set; }

        [Display(Name = "Pourcentage lié aux revenus financiers")]
        public double? Pourcent_financiers__pc { get; set; }

        [Display(Name = "Autres")]
        public bool? Nature_revenu_autre__pc { get; set; }

        [Display(Name = "Si autres revenus, précisez")]
        [StringLength(255)]
        public string Autres_revenus_precis__pc { get; set; }

        [Display(Name = "Pourcentage lié aux autres revenus")]
        public double? Pourcent_autres_revenus__pc { get; set; }

        [Display(Name = "Estimation du patrimoine du foyer fiscal")]
        public double? Estim_patrimoine_foyer_fisc__pc { get; set; }

        [Display(Name = "Placements financiers")]
        public bool? Ventile_placement_financier__pc { get; set; }

        [Display(Name = "Pourcentage lié aux placements")]
        public double? Pourcent_placements__pc { get; set; }

        [Display(Name = "Immobilier")]
        public bool? Ventile_immobilier__pc { get; set; }

        [Display(Name = "Pourcentage lié à l'immobilier")]
        public double? Pourcent_immo__pc { get; set; }

        [Display(Name = "Biens professionnels")]
        public bool? Ventile_bien_pro__pc { get; set; }

        [Display(Name = "Pourcentage lié aux biens professionnels")]
        public double? Pourcent_biens__pc { get; set; }

        [Display(Name = "Autres")]
        public bool? Ventile_autre__pc { get; set; }

        [Display(Name = "Si autres patrimoine, précisez")]
        [StringLength(255)]
        public string Autres_patrimoine_precis__pc { get; set; }

        [Display(Name = "Pourcentage lié aux autres patrimoines")]
        public double? Pourcent_autres_patri__pc { get; set; }

        [Display(Name = "Estimation des charges annuelles")]
        public double? Estim_charges_financieres__pc { get; set; }

        [Display(Name = "Dépenses courantes")]
        public bool? Charge_depense__pc { get; set; }

        [Display(Name = "Pourcentage lié aux dépenses courantes")]
        public double? Pourcent_depenses__pc { get; set; }

        [Display(Name = "Emprunt immobilier")]
        public bool? Charge_emprunt__pc { get; set; }

        [Display(Name = "Pourcentage lié aux emprunts immobiliers")]
        public double? Pourcent_emprunts__pc { get; set; }

        [Display(Name = "Autres")]
        public bool? Charge_autre__pc { get; set; }

        [Display(Name = "Si autres charges, précisez")]
        [StringLength(255)]
        public string Autres_charges_precis__pc { get; set; }

        [Display(Name = "Pourcentage lié aux autres charges")]
        public double? Pourcent_autres_charges__pc { get; set; }

        [Display(Name = "Prénom 2")]
        [StringLength(40)]
        public string Prenom_2__pc { get; set; }

        [Display(Name = "Prénom 3")]
        [StringLength(40)]
        public string Prenom_3__pc { get; set; }

        [Display(Name = "Client PPE")]
        public string Client_PPE__pc { get; set; }

        [Display(Name = "Hébergement chez un tiers")]
        public bool? Hebergement_tiers__pc { get; set; }

        [Display(Name = "Hébergeur")]
        [StringLength(32)]
        public string Hebergeur__pc { get; set; }

        [Display(Name = "Date de la dernière FRC")]
        public DateTimeOffset? Date_derniere_FRC__pc { get; set; }

        [Display(Name = "Pas de mobile")]
        public bool? Pas_mobile__pc { get; set; }

        [Display(Name = "Mobile Country Code")]
        public string et4ae5__Mobile_Country_Code__pc { get; set; }

        [Display(Name = "Fonction du PPE")]
        [StringLength(150)]
        public string PPE_fonction__pc { get; set; }

        [Display(Name = "L'organisation du proche PPE")]
        [StringLength(255)]
        public string Proche_PPE_org__pc { get; set; }

        [Display(Name = "Plusieurs nationalités")]
        public string Plusieurs_nationalites__pc { get; set; }

        [Display(Name = "Nationalité 2")]
        public string Nationalite_2__pc { get; set; }

        [Display(Name = "Nationalité 3")]
        public string Nationalite_3__pc { get; set; }

        [Display(Name = "Nationalité 4")]
        public string Nationalite_4__pc { get; set; }

        [Display(Name = "Nom de l'employeur")]
        [StringLength(100)]
        public string Nom_employeur__pc { get; set; }

        [Display(Name = "Cible de sanctions internationales")]
        public string Cible_sanctions_internat__pc { get; set; }

        [Display(Name = "Précision sur le programme concerné")]
        [StringLength(150)]
        public string Programme_concerne__pc { get; set; }

        [Display(Name = "Dirigeant ou salarié d'une société cotée")]
        public string Dirig_salarie_societe_cotee__pc { get; set; }

        [Display(Name = "Autres comptes-titres")]
        public string Autres_comptes_titres__pc { get; set; }

        [Display(Name = "Profession dans la finance ou la bourse")]
        public string Prof_finance_bourse__pc { get; set; }

        [Display(Name = "Pourcentage lié aux valeurs mobilières")]
        public double? Pourcent_val_mobilieres__pc { get; set; }

        [Display(Name = "Valeurs mobilières")]
        public bool? Patrimoine_valeurs_mobilieres__pc { get; set; }

        [Display(Name = "Année de l'estimation du patrimoine")]
        [StringLength(4)]
        public string Annee_estim_patrimoine__pc { get; set; }

        [Display(Name = "Pourcentage lié aux liquidités")]
        public double? Pourcent_liquidites__pc { get; set; }

        [Display(Name = "Liquidités")]
        public bool? Patrimoine_liquidites__pc { get; set; }

        [Display(Name = "Immobilier de rapport")]
        public bool? Patrimoine_immo_rapport__pc { get; set; }

        [Display(Name = "Immobilier de jouissance")]
        public bool? Patrimoine_immo_jouissance__pc { get; set; }

        [Display(Name = "Pourcentage lié à l'immo. de rapport")]
        public double? Pourcent_immo_rapport__pc { get; set; }

        [Display(Name = "Pourcentage lié à l'immo. de jouissance")]
        public double? Pourcent_immo_jouissance__pc { get; set; }

        [Display(Name = "Pourcentage lié à l'assurance vie")]
        public double? Pourcent_assur_vie__pc { get; set; }

        [Display(Name = "Assurance vie")]
        public bool? Patrimoine_assur_vie__pc { get; set; }

        [Display(Name = "Assujetti à l'ISF")]
        public string Assujetti_ISF__pc { get; set; }

        [Display(Name = "FRC Expiré")]
        public bool? FRC_Expire__pc { get; set; }

    }
}
