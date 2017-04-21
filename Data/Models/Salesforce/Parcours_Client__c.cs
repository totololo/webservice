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
    public partial class Parcours_Client__c
    {
        [Key]
        [Display(Name = "Record ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Référence")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Name { get; set; }

        [Display(Name = "Record Type ID")]
        public string RecordTypeId { get; set; }

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

        [Display(Name = "Hébergement chez un tiers")]
        public bool Hebergement_tiers__c { get; set; }

        [Display(Name = "Hébergeur")]
        [StringLength(32)]
        public string Hebergeur__c { get; set; }

        [Display(Name = "Complément d'adresse")]
        [StringLength(32)]
        public string Complement_adresse__c { get; set; }

        [Display(Name = "Pas de mobile")]
        public bool Pas_mobile__c { get; set; }

        [Display(Name = "Date de naissance")]
        public DateTimeOffset? Date_naissance__c { get; set; }

        [Display(Name = "Ville de naissance")]
        [StringLength(200)]
        public string Ville_naissance__c { get; set; }

        [Display(Name = "Pays de naissance")]
        public string Pays_naissance__c { get; set; }

        [Display(Name = "Pas d'email")]
        public bool Pas_email__c { get; set; }

        [Display(Name = "Situation familiale")]
        public string Situation_familiale__c { get; set; }

        [Display(Name = "Régime matrimonial")]
        public string Regime_mat__c { get; set; }

        [Display(Name = "Type de pièce")]
        public string Type_piece__c { get; set; }

        [Display(Name = "Numéro de pièce")]
        [StringLength(100)]
        public string Num_piece__c { get; set; }

        [Display(Name = "Civilité")]
        public string Civilite__c { get; set; }

        [Display(Name = "Lieu de délivrance")]
        [StringLength(100)]
        public string Lieu_delivrance__c { get; set; }

        [Display(Name = "Service de distribution éventuel")]
        [StringLength(32)]
        public string Service_distrib__c { get; set; }

        [Display(Name = "Autre régime matrimonial")]
        [StringLength(200)]
        public string Autre_regime_mat__c { get; set; }

        [Display(Name = "Téléphone mobile")]
        [Phone]
        public string Mobile__c { get; set; }

        [Display(Name = "Adresse email")]
        [EmailAddress]
        public string Email__c { get; set; }

        [Display(Name = "Pays")]
        public string Pays__c { get; set; }

        [Display(Name = "Code postal")]
        [StringLength(10)]
        public string Code_postal__c { get; set; }

        [Display(Name = "Ville")]
        [StringLength(50)]
        public string Ville__c { get; set; }

        [Display(Name = "Adresse")]
        public string Nom_voie__c { get; set; }

        [Display(Name = "Résident fiscal français")]
        public string Resident_fisc_fr__c { get; set; }

        [Display(Name = "Fonction du PPE")]
        [StringLength(150)]
        public string PPE_fonction__c { get; set; }

        [Display(Name = "Résidence fiscale unique")]
        public string Resid_fisc_unique__c { get; set; }

        [Display(Name = "Citoyen des Etats-Unis d’Amérique")]
        public string Citoyen_USA__c { get; set; }

        [Display(Name = "Résident fiscal des USA")]
        public string Resident_fisc_USA__c { get; set; }

        [Display(Name = "Numéro fiscal français")]
        [StringLength(100)]
        public string Num_fisc_fr__c { get; set; }

        [Display(Name = "L'organisation du proche PPE")]
        [StringLength(255)]
        public string Proche_PPE_org__c { get; set; }

        [Display(Name = "Numéro d'identification fiscale (NIF) 1")]
        [StringLength(100)]
        public string NIF_1__c { get; set; }

        [Display(Name = "Plusieurs nationalités")]
        public string Plusieurs_nationalites__c { get; set; }

        [Display(Name = "Numéro d'identification fiscale (NIF) 2")]
        [StringLength(100)]
        public string NIF_2__c { get; set; }

        [Display(Name = "Nationalité 2")]
        public string Nationalite_2__c { get; set; }

        [Display(Name = "Numéro d'identification fiscale (NIF) 3")]
        [StringLength(100)]
        public string NIF_3__c { get; set; }

        [Display(Name = "Numéro d'immatriculation fiscal des USA")]
        [StringLength(100)]
        public string Num_immat_fisc_USA__c { get; set; }

        [Display(Name = "Situation professionnelle")]
        public string Situation_pro__c { get; set; }

        [Display(Name = "Secteur d'activité")]
        [StringLength(255)]
        public string Secteur_activite__c { get; set; }

        [Display(Name = "Catégorie Socio-Professionnelle")]
        public string Cat_Socio_Pro__c { get; set; }

        [Display(Name = "Personne Politiquement Exposée")]
        public string PPE__c { get; set; }

        [Display(Name = "Fonction")]
        [StringLength(150)]
        public string Fonction__c { get; set; }

        [Display(Name = "Pays de la fonction PPE")]
        public string PPE_pays__c { get; set; }

        [Display(Name = "Membre de votre famille PPE")]
        public string Proche_PPE__c { get; set; }

        [Display(Name = "Lien de parenté du proche PPE")]
        [StringLength(100)]
        public string Proche_PPE_lien__c { get; set; }

        [Display(Name = "Fonction du proche PPE")]
        [StringLength(150)]
        public string Proche_PPE_fonction__c { get; set; }

        [Display(Name = "Pays de la fonction du proche PPE")]
        public string Proche_PPE_pays__c { get; set; }

        [Display(Name = "Revenus annuels du foyer fiscal")]
        public double? Revenus_annuels_foyer_fisc__c { get; set; }

        [Display(Name = "Nationalité 3")]
        public string Nationalite_3__c { get; set; }

        [Display(Name = "Précision sur les autres revenus")]
        [StringLength(255)]
        public string Autres_revenus__c { get; set; }

        [Display(Name = "Estimation du patrimoine du foyer fiscal")]
        public double? Estim_patrimoine_foyer_fisc__c { get; set; }

        [Display(Name = "Nationalité 4")]
        public string Nationalite_4__c { get; set; }

        [Display(Name = "Précision sur les autres patrimoines")]
        [StringLength(255)]
        public string Autres_patrimoines__c { get; set; }

        [Display(Name = "Estimation des charges annuelles")]
        public double? Estim_charges_financieres__c { get; set; }

        [Display(Name = "Nom de l'employeur")]
        [StringLength(100)]
        public string Nom_employeur__c { get; set; }

        [Display(Name = "Précision sur les autres charges")]
        [StringLength(255)]
        public string Autres_charges__c { get; set; }

        [Display(Name = "Cible de sanctions internationales")]
        public string Cible_sanctions_internat__c { get; set; }

        [Display(Name = "Précision sur le programme concerné")]
        [StringLength(150)]
        public string Programme_concerne__c { get; set; }

        [Display(Name = "Dirigeant ou salarié d'une société cotée")]
        public string Dirig_salarie_societe_cotee__c { get; set; }

        [Display(Name = "Autres comptes-titres")]
        public string Autres_comptes_titres__c { get; set; }

        [Display(Name = "Profession dans la finance ou la bourse")]
        public string Prof_finance_bourse__c { get; set; }

        [Display(Name = "Année de l'estimation du patrimoine")]
        [StringLength(4)]
        public string Annee_estim_patrimoine__c { get; set; }

        [Display(Name = "Valeurs mobilières")]
        public bool Patrimoine_valeurs_mobilieres__c { get; set; }

        [Display(Name = "Pourcentage lié aux valeurs mobilières")]
        public double? Pourcent_val_mobilieres__c { get; set; }

        [Display(Name = "Assurance vie")]
        public bool Patrimoine_assur_vie__c { get; set; }

        [Display(Name = "Pourcentage lié à l'assurance vie")]
        public double? Pourcent_assur_vie__c { get; set; }

        [Display(Name = "Immobilier de jouissance")]
        public bool Patrimoine_immo_jouissance__c { get; set; }

        [Display(Name = "Pourcentage lié à l'immo. de jouissance")]
        public double? Pourcent_immo_jouissance__c { get; set; }

        [Display(Name = "Immobilier de rapport")]
        public bool Patrimoine_immo_rapport__c { get; set; }

        [Display(Name = "Pourcentage lié à l'immo. de rapport")]
        public double? Pourcent_immo_rapport__c { get; set; }

        [Display(Name = "Liquidités")]
        public bool Patrimoine_liquidites__c { get; set; }

        [Display(Name = "Pourcentage lié aux liquidités")]
        public double? Pourcent_liquidites__c { get; set; }

        [Display(Name = "Assujetti à l'ISF")]
        public string Assujetti_ISF__c { get; set; }

        [Display(Name = "Âge")]
        [Createable(false), Updateable(false)]
        public double? Age__c { get; set; }

        [Display(Name = "Durée du contrat")]
        public string Duree_contrat__c { get; set; }

        [Display(Name = "Durée en année")]
        public double? Duree_annee__c { get; set; }

        [Display(Name = "Montant du versement")]
        public double? Montant_versement__c { get; set; }

        [Display(Name = "Statut")]
        public string Statut__c { get; set; }

        [Display(Name = "Compte client")]
        public string Compte_client__c { get; set; }

        [Display(Name = "Nom de naissance")]
        [StringLength(80)]
        public string Nom_naissance__c { get; set; }

        [Display(Name = "Prénom 1")]
        [StringLength(40)]
        public string Prenom_1__c { get; set; }

        [Display(Name = "Prénom 2")]
        [StringLength(40)]
        public string Prenom_2__c { get; set; }

        [Display(Name = "Prénom 3")]
        [StringLength(40)]
        public string Prenom_3__c { get; set; }

        [Display(Name = "Nom d'usage")]
        [StringLength(80)]
        public string Nom_usage__c { get; set; }

        [Display(Name = "Nationalité")]
        public string Nationalite__c { get; set; }

        [Display(Name = "Frais d'entrée du versement")]
        public double? Frais_entree_vers__c { get; set; }

        [Display(Name = "Mode de paiement")]
        public string Mode_paiement__c { get; set; }

        [Display(Name = "Numéro de chèque")]
        [StringLength(7)]
        public string Num_cheque__c { get; set; }

        [Display(Name = "Appartement")]
        [StringLength(10)]
        public string Numero__c { get; set; }

        [Display(Name = "Numéro de compte")]
        [StringLength(12)]
        public string Num_compte__c { get; set; }

        [Display(Name = "Nom de la banque")]
        [StringLength(255)]
        public string Nom_banque__c { get; set; }

        [Display(Name = "Titulaire du compte")]
        public string Titulaire_compte__c { get; set; }

        [Display(Name = "Pays de résidence fiscale autre que US 1")]
        public string Pays_resid_fisc_non_US_1__c { get; set; }

        [Display(Name = "Pays de résidence fiscale autre que US 2")]
        public string Pays_resid_fisc_non_US_2__c { get; set; }

        [Display(Name = "Pays de résidence fiscale autre que US 3")]
        public string Pays_resid_fisc_non_US_3__c { get; set; }

        [Display(Name = "Statut professionnel du salarié")]
        public string Statut_salarie__c { get; set; }

        [Display(Name = "Lien entre titulaire et souscripteur")]
        [StringLength(100)]
        public string Lien_titulaire_souscripteur__c { get; set; }

        [Display(Name = "Clause bénéficiaire")]
        public string Clause_benef__c { get; set; }

        [Display(Name = "Transfert/Réemploi d'épargne")]
        public bool Origine_fond_transfert_epargne__c { get; set; }

        [Display(Name = "Précision du type de produit d'origine")]
        [StringLength(150)]
        public string Origine_fond_type_produit__c { get; set; }

        [Display(Name = "Montant")]
        public double? Origine_fond_transfert_montant__c { get; set; }

        [Display(Name = "Vente immobilière")]
        public bool Origine_fond_vente_immo__c { get; set; }

        [Display(Name = "Montant")]
        public double? Origine_fond_immo_montant__c { get; set; }

        [Display(Name = "Date de début PPE")]
        public DateTimeOffset? PPE_date_debut__c { get; set; }

        [Display(Name = "Date de fin PPE")]
        public DateTimeOffset? PPE_date_fin__c { get; set; }

        [Display(Name = "L'organisation du PPE")]
        [StringLength(255)]
        public string PPE_org__c { get; set; }

        [Display(Name = "Nom du proche PPE")]
        [StringLength(80)]
        public string Proche_PPE_nom__c { get; set; }

        [Display(Name = "Prénom(s) du proche PPE")]
        [StringLength(120)]
        public string Proche_PPE_prenom__c { get; set; }

        [Display(Name = "Héritage/Succession")]
        public bool Origine_fond_heritage__c { get; set; }

        [Display(Name = "Précision de la filiation")]
        [StringLength(150)]
        public string Origine_fond_heritage_filiation__c { get; set; }

        [Display(Name = "Précision de la date")]
        public DateTimeOffset? Origine_fond_heritage_date__c { get; set; }

        [Display(Name = "Montant")]
        public double? Origine_fond_heritage_montant__c { get; set; }

        [Display(Name = "Don")]
        public bool Origine_fond_don__c { get; set; }

        [Display(Name = "Montant")]
        public double? Origine_fond_don_montant__c { get; set; }

        [Display(Name = "Prestation (accident, décès, invalidité)")]
        public bool Origine_fond_prestation__c { get; set; }

        [Display(Name = "Précision sur la prestation")]
        [StringLength(150)]
        public string Origine_fond_prestation_precision__c { get; set; }

        [Display(Name = "Montant")]
        public double? Origine_fond_prestation_montant__c { get; set; }

        [Display(Name = "Indemnité (divorce, licenciement, ...)")]
        public bool Origine_fond_indemn__c { get; set; }

        [Display(Name = "Précision sur l'indemnité")]
        [StringLength(150)]
        public string Origine_fond_indemn_precision__c { get; set; }

        [Display(Name = "Montant")]
        public double? Origine_fond_indemn_montant__c { get; set; }

        [Display(Name = "Date de début proche PPE")]
        public DateTimeOffset? Proche_PPE_date_debut__c { get; set; }

        [Display(Name = "Date de fin proche PPE")]
        public DateTimeOffset? Proche_PPE_date_fin__c { get; set; }

        [Display(Name = "Revenus professionnels")]
        public bool Origine_fond_revenus_pro__c { get; set; }

        [Display(Name = "Date de délivrance")]
        public DateTimeOffset? Date_delivrance__c { get; set; }

        [Display(Name = "Montant")]
        public double? Origine_fond_revenus_pro_montant__c { get; set; }

        [Display(Name = "Cession d'actifs")]
        public bool Origine_fond_cession_actifs__c { get; set; }

        [Display(Name = "Montant")]
        public double? Origine_fond_cession_actifs_montant__c { get; set; }

        [Display(Name = "Gain au jeu")]
        public bool Origine_fond_gain_jeu__c { get; set; }

        [Display(Name = "Département de naissance")]
        public string Dpt_naissance__c { get; set; }

        [Display(Name = "XX Type de voie")]
        public string Voie__c { get; set; }

        [Display(Name = "Date d'expiration")]
        public DateTimeOffset? Date_expiration__c { get; set; }

        [Display(Name = "Code Catégorie Socio-Professionnelle")]
        public string Code_Cat_Socio_Pro__c { get; set; }

        [Display(Name = "Ville de la fonction PPE")]
        [StringLength(100)]
        public string PPE_ville__c { get; set; }

        [Display(Name = "Ville de la fonction du proche PPE")]
        [StringLength(100)]
        public string Proche_PPE_ville__c { get; set; }

        [Display(Name = "Autres")]
        public bool Nature_revenu_autre__c { get; set; }

        [Display(Name = "Autres")]
        public bool Patrimoine_autre__c { get; set; }

        [Display(Name = "Autres")]
        public bool Charge_autre__c { get; set; }

        [Display(Name = "Biens professionnels")]
        public bool Patrimoine_bien_pro__c { get; set; }

        [Display(Name = "Dépenses courantes")]
        public bool Charge_depense__c { get; set; }

        [Display(Name = "Emprunt immobilier")]
        public bool Charge_emprunt__c { get; set; }

        [Display(Name = "Nom de naissance du conjoint")]
        [StringLength(80)]
        public string Nom_naissance_conjoint__c { get; set; }

        [Display(Name = "Pensions")]
        public bool Nature_revenu_pension__c { get; set; }

        [Display(Name = "Prénom du conjoint")]
        [StringLength(40)]
        public string Prenom_conjoint__c { get; set; }

        [Display(Name = "Revenus financiers")]
        public bool Nature_revenu_financier__c { get; set; }

        [Display(Name = "Revenus fonciers")]
        public bool Nature_revenu_foncier__c { get; set; }

        [Display(Name = "Salaires")]
        public bool Nature_revenu_salaire__c { get; set; }

        [Display(Name = "Montant")]
        public double? Origine_fond_gain_jeu_montant__c { get; set; }

        [Display(Name = "Pourcentage lié aux salaires")]
        public double? Pourcent_salaires__c { get; set; }

        [Display(Name = "Pourcentage lié aux pensions")]
        public double? Pourcent_pensions__c { get; set; }

        [Display(Name = "Pourcentage lié aux revenus fonciers")]
        public double? Pourcent_fonciers__c { get; set; }

        [Display(Name = "Pourcentage lié aux revenus financiers")]
        public double? Pourcent_financiers__c { get; set; }

        [Display(Name = "Pourcentage lié aux autres revenus")]
        public double? Pourcent_autres_revenus__c { get; set; }

        [Display(Name = "Téléphone domicile")]
        [Phone]
        public string Tel_domicile__c { get; set; }

        [Display(Name = "Pourcentage lié aux biens professionnels")]
        public double? Pourcent_biens__c { get; set; }

        [Display(Name = "Pourcentage lié aux autres patrimoines")]
        public double? Pourcent_autres_patri__c { get; set; }

        [Display(Name = "Pourcentage lié aux dépenses courantes")]
        public double? Pourcent_depenses__c { get; set; }

        [Display(Name = "Pourcentage lié aux emprunts immobiliers")]
        public double? Pourcent_emprunts__c { get; set; }

        [Display(Name = "Pourcentage lié aux autres charges")]
        public double? Pourcent_autres_charges__c { get; set; }

        [Display(Name = "Autre")]
        public bool Origine_fond_autre__c { get; set; }

        [Display(Name = "Précision de la nature")]
        [StringLength(150)]
        public string Origine_fond_autre_nature__c { get; set; }

        [Display(Name = "Date de transaction de l'épargne")]
        public DateTimeOffset? Origine_fond_autre_date__c { get; set; }

        [Display(Name = "Etablissement d'origine")]
        [StringLength(150)]
        public string Origine_fond_autre_etab__c { get; set; }

        [Display(Name = "Montant")]
        public double? Origine_fond_autre_montant__c { get; set; }

        [Display(Name = "Versements programmés")]
        public string Vers_prog__c { get; set; }

        [Display(Name = "Fréquence des prélèvements")]
        public string Freq_prelev__c { get; set; }

        [Display(Name = "Date du 1er prélèvement")]
        public DateTimeOffset? Date_1er_prelev__c { get; set; }

        [Display(Name = "Durée")]
        public double? Duree_vers__c { get; set; }

        [Display(Name = "Date 1er prélèvement avec modification")]
        public DateTimeOffset? Date_1er_prelev_modif__c { get; set; }

        [Display(Name = "Confirmation arrêt versements programmés")]
        public bool Confirm_arret_vers_prog__c { get; set; }

        [Display(Name = "RIB sélectionné")]
        public string RIB__c { get; set; }

        [Display(Name = "Pièce à joindre")]
        public string Piece_joindre__c { get; set; }

        [Display(Name = "Parcours lié")]
        public string Parcours_lie__c { get; set; }

        [Display(Name = "Origine de la création")]
        [StringLength(1300)]
        [Createable(false), Updateable(false)]
        public string Origine_creation__c { get; set; }

    }
}
