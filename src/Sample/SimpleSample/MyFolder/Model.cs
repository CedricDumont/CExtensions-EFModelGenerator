using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MyNamespace
{

   [Table("Dossier_Prepension")]
   public partial class Dossier_Prepension
   {

      [Key]
      [Column("Dpp_Id")]
      public decimal ID { get;set; }  // Dossier_Prepension.Dpp_Id (PrimaryKey)

      [Required]
      [Column("Dpp_Etat")]
      public string Etat { get;set; }   // Dossier_Prepension.Dpp_Etat

      [Required]
      [Column("Dpp_DatePrepension")]
      public DateTime DatePrepension { get;set; }   // Dossier_Prepension.Dpp_DatePrepension

      [Required]
      [Column("Dpp_DatePension")]
      public DateTime DatePension { get;set; }   // Dossier_Prepension.Dpp_DatePension

      [Required]
      [Column("Dpp_ProfilPrepension")]
      public string ProfilPrepension { get;set; }   // Dossier_Prepension.Dpp_ProfilPrepension

      [Required]
      [Column("Dpp_MiTemps")]
      public string MiTemps { get;set; }   // Dossier_Prepension.Dpp_MiTemps

      [Required]
      [Column("Dpp_CodeSyndical")]
      public string CodeSyndical { get;set; }   // Dossier_Prepension.Dpp_CodeSyndical

      [Required]
      [Column("Dpp_SalaireONSS")]
      public decimal SalaireONSS { get;set; }   // Dossier_Prepension.Dpp_SalaireONSS

      [Required]
      [Column("Dpp_JoursPrestes")]
      public decimal JoursPrestes { get;set; }   // Dossier_Prepension.Dpp_JoursPrestes

      [Required]
      [Column("Dpp_SalaireHoraire")]
      public decimal SalaireHoraire { get;set; }   // Dossier_Prepension.Dpp_SalaireHoraire

      [Required]
      [Column("Dpp_HeuresSemaine")]
      public decimal HeuresSemaine { get;set; }   // Dossier_Prepension.Dpp_HeuresSemaine

      [Required]
      [Column("Dpp_SalaireMensuel")]
      public decimal SalaireMensuel { get;set; }   // Dossier_Prepension.Dpp_SalaireMensuel

      [Required]
      [Column("Dpp_MontantPrimes")]
      public decimal MontantPrimes { get;set; }   // Dossier_Prepension.Dpp_MontantPrimes

      [Required]
      [Column("Dpp_RetenueONSS")]
      public decimal RetenueONSS { get;set; }   // Dossier_Prepension.Dpp_RetenueONSS

      [Required]
      [Column("Dpp_Precompte")]
      public decimal Precompte { get;set; }   // Dossier_Prepension.Dpp_Precompte

      [Required]
      [Column("Dpp_SalaireReference")]
      public decimal SalaireReference { get;set; }   // Dossier_Prepension.Dpp_SalaireReference

      [Required]
      [Column("Dpp_DemiSalaireReference")]
      public decimal DemiSalaireReference { get;set; }   // Dossier_Prepension.Dpp_DemiSalaireReference

      [Required]
      [Column("Dpp_IndemniteExtraLegale")]
      public decimal IndemniteExtraLegale { get;set; }   // Dossier_Prepension.Dpp_IndemniteExtraLegale

      [Required]
      [Column("Dpp_IndemniteBrute")]
      public decimal IndemniteBrute { get;set; }   // Dossier_Prepension.Dpp_IndemniteBrute

      [Required]
      [Column("Dpp_NbreAllocations")]
      public decimal NbreAllocations { get;set; }   // Dossier_Prepension.Dpp_NbreAllocations

      [Required]
      [Column("Dpp_CodeChomage")]
      public string CodeChomage { get;set; }   // Dossier_Prepension.Dpp_CodeChomage

      [Required]
      [Column("Dpp_MontantChomage")]
      public decimal MontantChomage { get;set; }   // Dossier_Prepension.Dpp_MontantChomage

      [Required]
      [Column("Dpp_RetenueONP")]
      public decimal RetenueONP { get;set; }   // Dossier_Prepension.Dpp_RetenueONP

      [Required]
      [Column("Dpp_RetenueONEM")]
      public decimal RetenueONEM { get;set; }   // Dossier_Prepension.Dpp_RetenueONEM

      [Required]
      [Column("Dpp_RetenueFicale")]
      public decimal RetenueFicale { get;set; }   // Dossier_Prepension.Dpp_RetenueFicale

      [Required]
      [Column("Dpp_IndemniteNette")]
      public decimal IndemniteNette { get;set; }   // Dossier_Prepension.Dpp_IndemniteNette

      [Required]
      [Column("Dpp_PrimeChomage")]
      public decimal PrimeChomage { get;set; }   // Dossier_Prepension.Dpp_PrimeChomage

      [Required]
      [Column("Dpp_TypeDossier")]
      public string TypeDossier { get;set; }   // Dossier_Prepension.Dpp_TypeDossier

      [Required]
      [Column("Dpp_Commentaire")]
      public string Commentaire { get;set; }   // Dossier_Prepension.Dpp_Commentaire

      [Required]
      [Column("Dpp_RepriseTravail")]
      public string RepriseTravail { get;set; }   // Dossier_Prepension.Dpp_RepriseTravail

      [Required]
      [Column("Dpp_ModeCalcul")]
      public string ModeCalcul { get;set; }   // Dossier_Prepension.Dpp_ModeCalcul

      [Required]
      [Column("Dpp_DateNotification")]
      public DateTime DateNotification { get;set; }   // Dossier_Prepension.Dpp_DateNotification

      [Required]
      [Column("Dpp_CotisationPersonnelle")]
      public decimal CotisationPersonnelle { get;set; }   // Dossier_Prepension.Dpp_CotisationPersonnelle

      [Required]
      [Column("Dpp_EtatEmployeur")]
      public string EtatEmployeur { get;set; }   // Dossier_Prepension.Dpp_EtatEmployeur

      [Required]
      [Column("Dpp_DateDebutEtat")]
      public DateTime DateDebutEtat { get;set; }   // Dossier_Prepension.Dpp_DateDebutEtat

      [Required]
      [Column("Dpp_DateFinEtat")]
      public DateTime DateFinEtat { get;set; }   // Dossier_Prepension.Dpp_DateFinEtat

      [Required]
      [Column("Dpp_Remplacement")]
      public string Remplacement { get;set; }   // Dossier_Prepension.Dpp_Remplacement

      [Required]
      [Column("Dpp_NissRemplacant")]
      public string NissRemplacant { get;set; }   // Dossier_Prepension.Dpp_NissRemplacant

      [Required]
      [Column("Dpp_Reprise")]
      public string Reprise { get;set; }   // Dossier_Prepension.Dpp_Reprise

      [Required]
      [Column("Dpp_DateDebutReprise")]
      public DateTime DateDebutReprise { get;set; }   // Dossier_Prepension.Dpp_DateDebutReprise

      [Required]
      [Column("Dpp_DateFinReprise")]
      public DateTime DateFinReprise { get;set; }   // Dossier_Prepension.Dpp_DateFinReprise

      [Required]
      [Column("Dpp_Frontalier")]
      public string Frontalier { get;set; }   // Dossier_Prepension.Dpp_Frontalier

      [Required]
      [Column("Dpp_Capitalisation")]
      public string Capitalisation { get;set; }   // Dossier_Prepension.Dpp_Capitalisation

      [Required]
      [Column("Dpp_CoeffCapitalisation")]
      public decimal CoeffCapitalisation { get;set; }   // Dossier_Prepension.Dpp_CoeffCapitalisation

      [Required]
      [Column("Dpp_IndemTheoriqueMensuelle")]
      public decimal IndemTheoriqueMensuelle { get;set; }   // Dossier_Prepension.Dpp_IndemTheoriqueMensuelle

      [Column("Tra_ID")]
      public decimal TraId_Key { get;set; }  // Dossier_Prepension.Tra_ID (ForeignKey)

      [Column("Aem_Id")]
      public decimal AemId_Key { get;set; }  // Dossier_Prepension.Aem_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      [ForeignKey("AemId_Key")]
      public virtual Activite_Employeur Activite_Employeur { get; set; }

      // Reverse Navigation

      [InverseProperty("DppId_Key")]
      public virtual List<Prime_Prepension> Prime_Prepension { get; set; }

      [InverseProperty("DppId_Key")]
      public virtual List<Immunisation_Jours> Immunisation_Jours { get; set; }

   }

   [Table("Fonds")]
   public partial class Fonds
   {

      [Key]
      [Column("Fnd_ID")]
      public decimal ID { get;set; }  // Fonds.Fnd_ID (PrimaryKey)

      [Required]
      [Column("Fnd_NomFR")]
      public string NomFR { get;set; }   // Fonds.Fnd_NomFR

      [Required]
      [Column("Fnd_NomNl")]
      public string NomNl { get;set; }   // Fonds.Fnd_NomNl

      [Required]
      [Column("Fnd_NomGE")]
      public string NomGE { get;set; }   // Fonds.Fnd_NomGE

      [Required]
      [Column("Fnd_AdresseRueNL")]
      public string AdresseRueNL { get;set; }   // Fonds.Fnd_AdresseRueNL

      [Required]
      [Column("Fnd_AdresseRueFR")]
      public string AdresseRueFR { get;set; }   // Fonds.Fnd_AdresseRueFR

      [Required]
      [Column("Fnd_AdresseRueGE")]
      public string AdresseRueGE { get;set; }   // Fonds.Fnd_AdresseRueGE

      [Required]
      [Column("Fnd_AdresseNo")]
      public string AdresseNo { get;set; }   // Fonds.Fnd_AdresseNo

      [Required]
      [Column("Fnd_AdresseBte")]
      public string AdresseBte { get;set; }   // Fonds.Fnd_AdresseBte

      [Required]
      [Column("Fnd_CodePostal")]
      public string CodePostal { get;set; }   // Fonds.Fnd_CodePostal

      [Required]
      [Column("Fnd_LocaliteNL")]
      public string LocaliteNL { get;set; }   // Fonds.Fnd_LocaliteNL

      [Required]
      [Column("Fnd_LocaliteFR")]
      public string LocaliteFR { get;set; }   // Fonds.Fnd_LocaliteFR

      [Required]
      [Column("Fnd_LocaliteGE")]
      public string LocaliteGE { get;set; }   // Fonds.Fnd_LocaliteGE

      [Required]
      [Column("Fnd_CodePays")]
      public string CodePays { get;set; }   // Fonds.Fnd_CodePays

      [Required]
      [Column("Fnd_Telephone")]
      public string Telephone { get;set; }   // Fonds.Fnd_Telephone

      [Required]
      [Column("Fnd_Fax")]
      public string Fax { get;set; }   // Fonds.Fnd_Fax

      [Required]
      [Column("Fnd_NomContact")]
      public string NomContact { get;set; }   // Fonds.Fnd_NomContact

      [Required]
      [Column("Fnd_NissContact")]
      public string NissContact { get;set; }   // Fonds.Fnd_NissContact

      [Required]
      [Column("Fnd_CodeEntreprise")]
      public string CodeEntreprise { get;set; }   // Fonds.Fnd_CodeEntreprise

      [Required]
      [Column("Fnd_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Fonds.Fnd_CompteBancaire

      [Required]
      [Column("Fnd_IBAN")]
      public string IBAN { get;set; }   // Fonds.Fnd_IBAN

      [Required]
      [Column("Fnd_BIC")]
      public string BIC { get;set; }   // Fonds.Fnd_BIC

      [Required]
      [Column("Fnd_Langue")]
      public string Langue { get;set; }   // Fonds.Fnd_Langue

      [Required]
      [Column("Fnd_NumeroDirReg")]
      public string NumeroDirReg { get;set; }   // Fonds.Fnd_NumeroDirReg

      [Required]
      [Column("Fnd_NumeroBurRec")]
      public string NumeroBurRec { get;set; }   // Fonds.Fnd_NumeroBurRec

      [Required]
      [Column("Fnd_NomBurRec")]
      public string NomBurRec { get;set; }   // Fonds.Fnd_NomBurRec

      [Required]
      [Column("Fnd_NumeroAdmCD")]
      public string NumeroAdmCD { get;set; }   // Fonds.Fnd_NumeroAdmCD

      [Required]
      [Column("Fnd_NumeroBurCtl")]
      public string NumeroBurCtl { get;set; }   // Fonds.Fnd_NumeroBurCtl

      [Required]
      [Column("Fnd_NomBurCtl")]
      public string NomBurCtl { get;set; }   // Fonds.Fnd_NomBurCtl

      [Required]
      [Column("Fnd_NomMandat")]
      public string NomMandat { get;set; }   // Fonds.Fnd_NomMandat

      [Required]
      [Column("Fnd_AdresseRueMandat")]
      public string AdresseRueMandat { get;set; }   // Fonds.Fnd_AdresseRueMandat

      [Required]
      [Column("Fnd_AdresseNoMandat")]
      public string AdresseNoMandat { get;set; }   // Fonds.Fnd_AdresseNoMandat

      [Required]
      [Column("Fnd_AdresseBteMandat")]
      public string AdresseBteMandat { get;set; }   // Fonds.Fnd_AdresseBteMandat

      [Required]
      [Column("Fnd_CodePostalMandat")]
      public string CodePostalMandat { get;set; }   // Fonds.Fnd_CodePostalMandat

      [Required]
      [Column("Fnd_LocaliteMandat")]
      public string LocaliteMandat { get;set; }   // Fonds.Fnd_LocaliteMandat

      [Required]
      [Column("Fnd_CodePaysMandat")]
      public string CodePaysMandat { get;set; }   // Fonds.Fnd_CodePaysMandat

      [Required]
      [Column("Fnd_TelephoneMandat")]
      public string TelephoneMandat { get;set; }   // Fonds.Fnd_TelephoneMandat

      [Required]
      [Column("Fnd_FaxMandat")]
      public string FaxMandat { get;set; }   // Fonds.Fnd_FaxMandat

      [Required]
      [Column("Fnd_EmailContact")]
      public string EmailContact { get;set; }   // Fonds.Fnd_EmailContact

      [Required]
      [Column("Fnd_BCE")]
      public string BCE { get;set; }   // Fonds.Fnd_BCE

      // Reverse Navigation

      [InverseProperty("FndId_Key")]
      public virtual List<Activite_Employeur> Activite_Employeur { get; set; }

      [InverseProperty("FndId_Key")]
      public virtual List<Categorie_Employeur> Categorie_Employeur { get; set; }

   }

   [Table("Att_A038")]
   public partial class Att_A038
   {

      [Key]
      [Column("Att38_Id")]
      public decimal ID { get;set; }  // Att_A038.Att38_Id (PrimaryKey)

      [Required]
      [Column("Att38_Active")]
      public string Active { get;set; }   // Att_A038.Att38_Active

      [Required]
      [Column("Att38_INSS")]
      public string INSS { get;set; }   // Att_A038.Att38_INSS

      [Required]
      [Column("Att38_AttestationID")]
      public string AttestationID { get;set; }   // Att_A038.Att38_AttestationID

      [Required]
      [Column("Att38_SituationNbr")]
      public decimal SituationNbr { get;set; }   // Att_A038.Att38_SituationNbr

      [Required]
      [Column("Att38_AttestationStatus")]
      public decimal AttestationStatus { get;set; }   // Att_A038.Att38_AttestationStatus

      [Required]
      [Column("Att38_CreationDate")]
      public DateTime CreationDate { get;set; }   // Att_A038.Att38_CreationDate

      [Required]
      [Column("Att38_HolidayYear")]
      public string HolidayYear { get;set; }   // Att_A038.Att38_HolidayYear

      [Required]
      [Column("Att38_ContractType")]
      public string ContractType { get;set; }   // Att_A038.Att38_ContractType

      [Required]
      [Column("Att38_LegalSingleHolidaySavings")]
      public decimal LegalSingleHolidaySavings { get;set; }   // Att_A038.Att38_LegalSingleHolidaySavings

      [Required]
      [Column("Att38_LegalDoubleHolidaySavings")]
      public decimal LegalDoubleHolidaySavings { get;set; }   // Att_A038.Att38_LegalDoubleHolidaySavings

      [Required]
      [Column("Att38_LegalNbrOfDays")]
      public decimal LegalNbrOfDays { get;set; }   // Att_A038.Att38_LegalNbrOfDays

      [Required]
      [Column("Att38_TreatyHolidaySavings")]
      public decimal TreatyHolidaySavings { get;set; }   // Att_A038.Att38_TreatyHolidaySavings

      [Required]
      [Column("Att38_TreatyNbrOfDays")]
      public decimal TreatyNbrOfDays { get;set; }   // Att_A038.Att38_TreatyNbrOfDays

      [Column("Snd38_Id")]
      public decimal Snd38Id_Key { get;set; }  // Att_A038.Snd38_Id (ForeignKey)

      [Column("Tra_Id")]
      public decimal TraId_Key { get;set; }  // Att_A038.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Snd38Id_Key")]
      public virtual Sending_A038 Sending_A038 { get; set; }

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("Att38Id_Key")]
      public virtual List<Att_A038_IndividualAtt> Att_A038_IndividualAtt { get; set; }

   }

   [Table("Att_A038_IndividualAtt")]
   public partial class Att_A038_IndividualAtt
   {

      [Key]
      [Column("Ind38_Id")]
      public decimal ID { get;set; }  // Att_A038_IndividualAtt.Ind38_Id (PrimaryKey)

      [Required]
      [Column("Ind38_AttestationID")]
      public string AttestationID { get;set; }   // Att_A038_IndividualAtt.Ind38_AttestationID

      [Required]
      [Column("Ind38_SituationNbr")]
      public decimal SituationNbr { get;set; }   // Att_A038_IndividualAtt.Ind38_SituationNbr

      [Required]
      [Column("Ind38_AttestationStatus")]
      public decimal AttestationStatus { get;set; }   // Att_A038_IndividualAtt.Ind38_AttestationStatus

      [Column("Att38_Id")]
      public decimal Att38Id_Key { get;set; }  // Att_A038_IndividualAtt.Att38_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Att38Id_Key")]
      public virtual Att_A038 Att_A038 { get; set; }

   }

   [Table("Ligne_Occupation")]
   public partial class Ligne_Occupation
   {

      [Key]
      [Column("Occ_Id")]
      public decimal ID { get;set; }  // Ligne_Occupation.Occ_Id (PrimaryKey)

      [Required]
      [Column("Occ_NoAttestation")]
      public string NoAttestation { get;set; }   // Ligne_Occupation.Occ_NoAttestation

      [Required]
      [Column("Occ_NoSituation")]
      public string NoSituation { get;set; }   // Ligne_Occupation.Occ_NoSituation

      [Required]
      [Column("Occ_Trimestre")]
      public string Trimestre { get;set; }   // Ligne_Occupation.Occ_Trimestre

      [Required]
      [Column("Occ_DateDebutOccupation")]
      public DateTime DateDebutOccupation { get;set; }   // Ligne_Occupation.Occ_DateDebutOccupation

      [Required]
      [Column("Occ_DateFinOccupation")]
      public DateTime DateFinOccupation { get;set; }   // Ligne_Occupation.Occ_DateFinOccupation

      [Required]
      [Column("Occ_CommissionParitaire")]
      public string CommissionParitaire { get;set; }   // Ligne_Occupation.Occ_CommissionParitaire

      [Required]
      [Column("Occ_Regime")]
      public decimal Regime { get;set; }   // Ligne_Occupation.Occ_Regime

      [Required]
      [Column("Occ_HeuresSemTrav")]
      public decimal HeuresSemTrav { get;set; }   // Ligne_Occupation.Occ_HeuresSemTrav

      [Required]
      [Column("Occ_HeuresSemTravRef")]
      public decimal HeuresSemTravRef { get;set; }   // Ligne_Occupation.Occ_HeuresSemTravRef

      [Required]
      [Column("Occ_TypeContrat")]
      public string TypeContrat { get;set; }   // Ligne_Occupation.Occ_TypeContrat

      [Required]
      [Column("Occ_ReorganTravail")]
      public string ReorganTravail { get;set; }   // Ligne_Occupation.Occ_ReorganTravail

      [Required]
      [Column("Occ_PromotionEmploi")]
      public string PromotionEmploi { get;set; }   // Ligne_Occupation.Occ_PromotionEmploi

      [Required]
      [Column("Occ_StatutTravailleur")]
      public string StatutTravailleur { get;set; }   // Ligne_Occupation.Occ_StatutTravailleur

      [Required]
      [Column("Occ_Pensionne")]
      public string Pensionne { get;set; }   // Ligne_Occupation.Occ_Pensionne

      [Required]
      [Column("Occ_TypeApprenti")]
      public string TypeApprenti { get;set; }   // Ligne_Occupation.Occ_TypeApprenti

      [Required]
      [Column("Occ_ModeRemuneration")]
      public string ModeRemuneration { get;set; }   // Ligne_Occupation.Occ_ModeRemuneration

      [Required]
      [Column("Occ_FractionPrestation")]
      public decimal FractionPrestation { get;set; }   // Ligne_Occupation.Occ_FractionPrestation

      [Required]
      [Column("Occ_JustificationJours")]
      public string JustificationJours { get;set; }   // Ligne_Occupation.Occ_JustificationJours

      [Required]
      [Column("Occ_TextLibre")]
      public string TextLibre { get;set; }   // Ligne_Occupation.Occ_TextLibre

      [Required]
      [Column("Occ_NoUniteLocale")]
      public string NoUniteLocale { get;set; }   // Ligne_Occupation.Occ_NoUniteLocale

      [Required]
      [Column("Occ_NISUniteLocale")]
      public string NISUniteLocale { get;set; }   // Ligne_Occupation.Occ_NISUniteLocale

      [Required]
      [Column("Occ_CodeRegionalisation")]
      public string CodeRegionalisation { get;set; }   // Ligne_Occupation.Occ_CodeRegionalisation

      [Required]
      [Column("Occ_CodeFonction")]
      public string CodeFonction { get;set; }   // Ligne_Occupation.Occ_CodeFonction

      [Column("Ltr_Id")]
      public decimal LtrId_Key { get;set; }  // Ligne_Occupation.Ltr_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("LtrId_Key")]
      public virtual Ligne_Travailleur Ligne_Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("OccId_Key")]
      public virtual List<Prestation> Prestation { get; set; }

      [InverseProperty("OccId_Key")]
      public virtual List<Remuneration> Remuneration { get; set; }

   }

   [Table("Pension")]
   public partial class Pension
   {

      [Key]
      [Column("Pen_Id")]
      public decimal ID { get;set; }  // Pension.Pen_Id (PrimaryKey)

      [Required]
      [Column("Pen_Niss")]
      public string Niss { get;set; }   // Pension.Pen_Niss

      [Required]
      [Column("Pen_Etat")]
      public string Etat { get;set; }   // Pension.Pen_Etat

      [Required]
      [Column("Pen_DateCreation")]
      public DateTime DateCreation { get;set; }   // Pension.Pen_DateCreation

      [Required]
      [Column("Pen_NoPolice")]
      public string NoPolice { get;set; }   // Pension.Pen_NoPolice

      [Required]
      [Column("Pen_DroitAcquis")]
      public string DroitAcquis { get;set; }   // Pension.Pen_DroitAcquis

      [Required]
      [Column("Pen_TrimestrePremier")]
      public string TrimestrePremier { get;set; }   // Pension.Pen_TrimestrePremier

      [Required]
      [Column("Pen_TrimestreDernier")]
      public string TrimestreDernier { get;set; }   // Pension.Pen_TrimestreDernier

      [Required]
      [Column("Pen_TypeLiquidation")]
      public string TypeLiquidation { get;set; }   // Pension.Pen_TypeLiquidation

      [Required]
      [Column("Pen_DateLiquidation")]
      public DateTime DateLiquidation { get;set; }   // Pension.Pen_DateLiquidation

      [Required]
      [Column("Pen_TexteLibre")]
      public string TexteLibre { get;set; }   // Pension.Pen_TexteLibre

      [Required]
      [Column("Pen_PrimeDeces")]
      public string PrimeDeces { get;set; }   // Pension.Pen_PrimeDeces

      [Required]
      [Column("Pen_NoExport")]
      public string NoExport { get;set; }   // Pension.Pen_NoExport

      [Required]
      [Column("Pen_TypeLiquidationPrecedent")]
      public string TypeLiquidationPrecedent { get;set; }   // Pension.Pen_TypeLiquidationPrecedent

      [Column("Tra_Id")]
      public decimal TraId_Key { get;set; }  // Pension.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("PenId_Key")]
      public virtual List<Pension_Travailleur> Pension_Travailleur { get; set; }

      [InverseProperty("PenId_Key")]
      public virtual List<Fiche_Pension> Fiche_Pension { get; set; }

      [InverseProperty("PenId_Key")]
      public virtual List<Pension_LettreDepart> Pension_LettreDepart { get; set; }

   }

   [Table("Pension_Contrat")]
   public partial class Pension_Contrat
   {

      [Key]
      [Column("Dct_Id")]
      public decimal ID { get;set; }  // Pension_Contrat.Dct_Id (PrimaryKey)

      [Required]
      [Column("Dct_Niss")]
      public string Niss { get;set; }   // Pension_Contrat.Dct_Niss

      [Required]
      [Column("Dct_Onss")]
      public string Onss { get;set; }   // Pension_Contrat.Dct_Onss

      [Required]
      [Column("Dct_Exercice")]
      public string Exercice { get;set; }   // Pension_Contrat.Dct_Exercice

      [Required]
      [Column("Dct_JoursOnss")]
      public decimal JoursOnss { get;set; }   // Pension_Contrat.Dct_JoursOnss

      [Required]
      [Column("Dct_SalaireBrut")]
      public decimal SalaireBrut { get;set; }   // Pension_Contrat.Dct_SalaireBrut

      [Required]
      [Column("Dct_PrimeInactivite")]
      public decimal PrimeInactivite { get;set; }   // Pension_Contrat.Dct_PrimeInactivite

      [Required]
      [Column("Dct_TexteLibre")]
      public string TexteLibre { get;set; }   // Pension_Contrat.Dct_TexteLibre

      [Column("Dtr_Id")]
      public decimal DtrId_Key { get;set; }  // Pension_Contrat.Dtr_Id (ForeignKey)

      [Column("Con_Id")]
      public decimal ConId_Key { get;set; }  // Pension_Contrat.Con_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DtrId_Key")]
      public virtual Pension_Travailleur Pension_Travailleur { get; set; }

      [ForeignKey("ConId_Key")]
      public virtual Contrat Contrat { get; set; }

      // Reverse Navigation

      [InverseProperty("DctId_Key")]
      public virtual List<Ligne_Travailleur> Ligne_Travailleur { get; set; }

      [InverseProperty("DctId_Key")]
      public virtual List<Solidarite_Inactivite> Solidarite_Inactivite { get; set; }

   }

   [Table("Att_A045_DecisionDetail")]
   public partial class Att_A045_DecisionDetail
   {

      [Key]
      [Column("Det45_Id")]
      public decimal ID { get;set; }  // Att_A045_DecisionDetail.Det45_Id (PrimaryKey)

      [Required]
      [Column("Det45_BeginDate")]
      public DateTime BeginDate { get;set; }   // Att_A045_DecisionDetail.Det45_BeginDate

      [Required]
      [Column("Det45_EndDate")]
      public DateTime EndDate { get;set; }   // Att_A045_DecisionDetail.Det45_EndDate

      [Required]
      [Column("Det45_GlobalPercentage")]
      public decimal GlobalPercentage { get;set; }   // Att_A045_DecisionDetail.Det45_GlobalPercentage

      [Required]
      [Column("Det45_PhysicalPercentage")]
      public decimal PhysicalPercentage { get;set; }   // Att_A045_DecisionDetail.Det45_PhysicalPercentage

      [Required]
      [Column("Det45_SocioEconomicPercentage")]
      public decimal SocioEconomicPercentage { get;set; }   // Att_A045_DecisionDetail.Det45_SocioEconomicPercentage

      [Required]
      [Column("Det45_AgePercentage")]
      public decimal AgePercentage { get;set; }   // Att_A045_DecisionDetail.Det45_AgePercentage

      [Required]
      [Column("Det45_AbsencePercentage")]
      public decimal AbsencePercentage { get;set; }   // Att_A045_DecisionDetail.Det45_AbsencePercentage

      [Column("Dcn45_Id")]
      public decimal Dcn45Id_Key { get;set; }  // Att_A045_DecisionDetail.Dcn45_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Dcn45Id_Key")]
      public virtual Att_A045_DecisionFbzFmp Att_A045_DecisionFbzFmp { get; set; }

   }

   [Table("Att_A052")]
   public partial class Att_A052
   {

      [Key]
      [Column("Att52_Id")]
      public decimal ID { get;set; }  // Att_A052.Att52_Id (PrimaryKey)

      [Required]
      [Column("Att52_Active")]
      public string Active { get;set; }   // Att_A052.Att52_Active

      [Required]
      [Column("Att52_INSS")]
      public string INSS { get;set; }   // Att_A052.Att52_INSS

      [Required]
      [Column("Att52_AttestationID")]
      public string AttestationID { get;set; }   // Att_A052.Att52_AttestationID

      [Required]
      [Column("Att52_SituationNbr")]
      public decimal SituationNbr { get;set; }   // Att_A052.Att52_SituationNbr

      [Required]
      [Column("Att52_AttestationStatus")]
      public decimal AttestationStatus { get;set; }   // Att_A052.Att52_AttestationStatus

      [Required]
      [Column("Att52_CreationDate")]
      public DateTime CreationDate { get;set; }   // Att_A052.Att52_CreationDate

      [Required]
      [Column("Att52_Quarter")]
      public string Quarter { get;set; }   // Att_A052.Att52_Quarter

      [Column("Snd52_Id")]
      public decimal Snd52Id_Key { get;set; }  // Att_A052.Snd52_Id (ForeignKey)

      [Column("Tra_Id")]
      public decimal TraId_Key { get;set; }  // Att_A052.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Snd52Id_Key")]
      public virtual Sending_A052 Sending_A052 { get; set; }

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("Att52Id_Key")]
      public virtual List<Att_A052_DecisionNicCin> Att_A052_DecisionNicCin { get; set; }

   }

   [Table("Att_A052_DecisionNicCin")]
   public partial class Att_A052_DecisionNicCin
   {

      [Key]
      [Column("Dcn52_Id")]
      public decimal ID { get;set; }  // Att_A052_DecisionNicCin.Dcn52_Id (PrimaryKey)

      [Required]
      [Column("Dcn52_DayType")]
      public string DayType { get;set; }   // Att_A052_DecisionNicCin.Dcn52_DayType

      [Required]
      [Column("Dcn52_DurationUnit")]
      public string DurationUnit { get;set; }   // Att_A052_DecisionNicCin.Dcn52_DurationUnit

      [Required]
      [Column("Dcn52_DurationValue")]
      public decimal DurationValue { get;set; }   // Att_A052_DecisionNicCin.Dcn52_DurationValue

      [Required]
      [Column("Dcn52_AllowanceType")]
      public string AllowanceType { get;set; }   // Att_A052_DecisionNicCin.Dcn52_AllowanceType

      [Required]
      [Column("Dcn52_KindOfAllowance")]
      public string KindOfAllowance { get;set; }   // Att_A052_DecisionNicCin.Dcn52_KindOfAllowance

      [Required]
      [Column("Dcn52_BeginDate")]
      public DateTime BeginDate { get;set; }   // Att_A052_DecisionNicCin.Dcn52_BeginDate

      [Required]
      [Column("Dcn52_EndDate")]
      public DateTime EndDate { get;set; }   // Att_A052_DecisionNicCin.Dcn52_EndDate

      [Column("Att52_Id")]
      public decimal Att52Id_Key { get;set; }  // Att_A052_DecisionNicCin.Att52_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Att52Id_Key")]
      public virtual Att_A052 Att_A052 { get; set; }

   }

   [Table("Sending_A038")]
   public partial class Sending_A038
   {

      [Key]
      [Column("Snd38_Id")]
      public decimal ID { get;set; }  // Sending_A038.Snd38_Id (PrimaryKey)

      [Required]
      [Column("Snd38_Number")]
      public string Number { get;set; }   // Sending_A038.Snd38_Number

      [Required]
      [Column("Snd38_SendingDate")]
      public DateTime SendingDate { get;set; }   // Sending_A038.Snd38_SendingDate

      [Required]
      [Column("Snd38_CreationDate")]
      public DateTime CreationDate { get;set; }   // Sending_A038.Snd38_CreationDate

      [Required]
      [Column("Snd38_AttestationCount")]
      public decimal AttestationCount { get;set; }   // Sending_A038.Snd38_AttestationCount

      // Reverse Navigation

      [InverseProperty("Snd38Id_Key")]
      public virtual List<Att_A038> Att_A038 { get; set; }

   }

   [Table("Prestation")]
   public partial class Prestation
   {

      [Key]
      [Column("Prs_Id")]
      public decimal ID { get;set; }  // Prestation.Prs_Id (PrimaryKey)

      [Required]
      [Column("Prs_NoAttestation")]
      public string NoAttestation { get;set; }   // Prestation.Prs_NoAttestation

      [Required]
      [Column("Prs_NoSituation")]
      public string NoSituation { get;set; }   // Prestation.Prs_NoSituation

      [Required]
      [Column("Prs_Trimestre")]
      public string Trimestre { get;set; }   // Prestation.Prs_Trimestre

      [Required]
      [Column("Prs_NoLignePrestation")]
      public string NoLignePrestation { get;set; }   // Prestation.Prs_NoLignePrestation

      [Required]
      [Column("Prs_CodePrestation")]
      public string CodePrestation { get;set; }   // Prestation.Prs_CodePrestation

      [Required]
      [Column("Prs_JoursPrestation")]
      public decimal JoursPrestation { get;set; }   // Prestation.Prs_JoursPrestation

      [Required]
      [Column("Prs_HeuresPrestation")]
      public decimal HeuresPrestation { get;set; }   // Prestation.Prs_HeuresPrestation

      [Required]
      [Column("Prs_TextLibre")]
      public string TextLibre { get;set; }   // Prestation.Prs_TextLibre

      [Column("Occ_Id")]
      public decimal OccId_Key { get;set; }  // Prestation.Occ_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("OccId_Key")]
      public virtual Ligne_Occupation Ligne_Occupation { get; set; }

      // Reverse Navigation

      [InverseProperty("PrsId_Key")]
      public virtual List<Assimilation> Assimilation { get; set; }

   }

   [Table("Anciennete_Contrat")]
   public partial class Anciennete_Contrat
   {

      [Key]
      [Column("Anc_Id")]
      public decimal ID { get;set; }  // Anciennete_Contrat.Anc_Id (PrimaryKey)

      [Required]
      [Column("Anc_Niss")]
      public string Niss { get;set; }   // Anciennete_Contrat.Anc_Niss

      [Required]
      [Column("Anc_Onss")]
      public string Onss { get;set; }   // Anciennete_Contrat.Anc_Onss

      [Required]
      [Column("Anc_NoCalcul")]
      public string NoCalcul { get;set; }   // Anciennete_Contrat.Anc_NoCalcul

      [Required]
      [Column("Anc_TrimestreCalcul")]
      public string TrimestreCalcul { get;set; }   // Anciennete_Contrat.Anc_TrimestreCalcul

      [Required]
      [Column("Anc_DebutDerniereOccup")]
      public DateTime DebutDerniereOccup { get;set; }   // Anciennete_Contrat.Anc_DebutDerniereOccup

      [Required]
      [Column("Anc_FinDerniereOccup")]
      public DateTime FinDerniereOccup { get;set; }   // Anciennete_Contrat.Anc_FinDerniereOccup

      [Required]
      [Column("Anc_DateAnciennete")]
      public DateTime DateAnciennete { get;set; }   // Anciennete_Contrat.Anc_DateAnciennete

      [Required]
      [Column("Anc_IndemniteRupture")]
      public string IndemniteRupture { get;set; }   // Anciennete_Contrat.Anc_IndemniteRupture

      [Required]
      [Column("Anc_Anomalie")]
      public string Anomalie { get;set; }   // Anciennete_Contrat.Anc_Anomalie

      [Required]
      [Column("Anc_RaisonAnomalie")]
      public string RaisonAnomalie { get;set; }   // Anciennete_Contrat.Anc_RaisonAnomalie

      [Required]
      [Column("Anc_TexteLibre")]
      public string TexteLibre { get;set; }   // Anciennete_Contrat.Anc_TexteLibre

      [Column("Con_Id")]
      public decimal ConId_Key { get;set; }  // Anciennete_Contrat.Con_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("ConId_Key")]
      public virtual Contrat Contrat { get; set; }

   }

   [Table("Declaration_CotisationPrepension")]
   public partial class Declaration_CotisationPrepension
   {

      [Key]
      [Column("Dcp_Id")]
      public decimal ID { get;set; }  // Declaration_CotisationPrepension.Dcp_Id (PrimaryKey)

      [Required]
      [Column("Dcp_CotisationPersonnelle")]
      public decimal CotisationPersonnelle { get;set; }   // Declaration_CotisationPrepension.Dcp_CotisationPersonnelle

      [Required]
      [Column("Dcp_CotisationPatronale")]
      public decimal CotisationPatronale { get;set; }   // Declaration_CotisationPrepension.Dcp_CotisationPatronale

      [Required]
      [Column("Dcp_CotisationCompensatoire")]
      public decimal CotisationCompensatoire { get;set; }   // Declaration_CotisationPrepension.Dcp_CotisationCompensatoire

      [Column("Dtv_Id")]
      public decimal DtvId_Key { get;set; }  // Declaration_CotisationPrepension.Dtv_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DtvId_Key")]
      public virtual Declaration_Travailleur Declaration_Travailleur { get; set; }

   }

   [Table("Declaration_Onss")]
   public partial class Declaration_Onss
   {

      [Key]
      [Column("Dec_Id")]
      public decimal ID { get;set; }  // Declaration_Onss.Dec_Id (PrimaryKey)

      [Required]
      [Column("Dec_Type")]
      public string Type { get;set; }   // Declaration_Onss.Dec_Type

      [Required]
      [Column("Dec_Trimestre")]
      public string Trimestre { get;set; }   // Declaration_Onss.Dec_Trimestre

      [Required]
      [Column("Dec_Onss")]
      public string Onss { get;set; }   // Declaration_Onss.Dec_Onss

      [Required]
      [Column("Dec_DeclarationPID")]
      public decimal DeclarationPID { get;set; }   // Declaration_Onss.Dec_DeclarationPID

      // Reverse Navigation

      [InverseProperty("DecId_Key")]
      public virtual List<Declaration_Travailleur> Declaration_Travailleur { get; set; }

   }

   [Table("Sending_A045")]
   public partial class Sending_A045
   {

      [Key]
      [Column("Snd45_Id")]
      public decimal ID { get;set; }  // Sending_A045.Snd45_Id (PrimaryKey)

      [Required]
      [Column("Snd45_Number")]
      public string Number { get;set; }   // Sending_A045.Snd45_Number

      [Required]
      [Column("Snd45_SendingDate")]
      public DateTime SendingDate { get;set; }   // Sending_A045.Snd45_SendingDate

      [Required]
      [Column("Snd45_CreationDate")]
      public DateTime CreationDate { get;set; }   // Sending_A045.Snd45_CreationDate

      [Required]
      [Column("Snd45_AttestationCount")]
      public decimal AttestationCount { get;set; }   // Sending_A045.Snd45_AttestationCount

      // Reverse Navigation

      [InverseProperty("Snd45Id_Key")]
      public virtual List<Att_A045> Att_A045 { get; set; }

   }

   [Table("Sending_A052")]
   public partial class Sending_A052
   {

      [Key]
      [Column("Snd52_Id")]
      public decimal ID { get;set; }  // Sending_A052.Snd52_Id (PrimaryKey)

      [Required]
      [Column("Snd52_Number")]
      public string Number { get;set; }   // Sending_A052.Snd52_Number

      [Required]
      [Column("Snd52_SendingDate")]
      public DateTime SendingDate { get;set; }   // Sending_A052.Snd52_SendingDate

      [Required]
      [Column("Snd52_CreationDate")]
      public DateTime CreationDate { get;set; }   // Sending_A052.Snd52_CreationDate

      [Required]
      [Column("Snd52_AttestationCount")]
      public decimal AttestationCount { get;set; }   // Sending_A052.Snd52_AttestationCount

      // Reverse Navigation

      [InverseProperty("Snd52Id_Key")]
      public virtual List<Att_A052> Att_A052 { get; set; }

   }

   [Table("Batch_Schedule_New")]
   public partial class Batch_Schedule_New
   {

      [Key]
      [Column("Bat_Id")]
      public decimal ID { get;set; }  // Batch_Schedule_New.Bat_Id (PrimaryKey)

      [Required]
      [Column("Bat_Type")]
      public string Type { get;set; }   // Batch_Schedule_New.Bat_Type

      [Required]
      [Column("Bat_Description")]
      public string Description { get;set; }   // Batch_Schedule_New.Bat_Description

      [Required]
      [Column("Bat_Etat")]
      public string Etat { get;set; }   // Batch_Schedule_New.Bat_Etat

      [Required]
      [Column("Bat_Parametres")]
      public string Parametres { get;set; }   // Batch_Schedule_New.Bat_Parametres

      [Required]
      [Column("Bat_Priorite")]
      public decimal Priorite { get;set; }   // Batch_Schedule_New.Bat_Priorite

      [Required]
      [Column("Bat_DatePlanifiee")]
      public DateTime DatePlanifiee { get;set; }   // Batch_Schedule_New.Bat_DatePlanifiee

      [Required]
      [Column("Bat_DateDebutExecution")]
      public DateTime DateDebutExecution { get;set; }   // Batch_Schedule_New.Bat_DateDebutExecution

      [Required]
      [Column("Bat_DateFinExecution")]
      public DateTime DateFinExecution { get;set; }   // Batch_Schedule_New.Bat_DateFinExecution

      [Required]
      [Column("Bat_Erreur")]
      public string Erreur { get;set; }   // Batch_Schedule_New.Bat_Erreur

      [Required]
      [Column("Bat_SqlText")]
      public string SqlText { get;set; }   // Batch_Schedule_New.Bat_SqlText

      [Required]
      [Column("Bat_Keywords")]
      public string Keywords { get;set; }   // Batch_Schedule_New.Bat_Keywords

      [Required]
      [Column("Bat_NombreTotal")]
      public decimal NombreTotal { get;set; }   // Batch_Schedule_New.Bat_NombreTotal

      [Required]
      [Column("Bat_NombreTraites")]
      public decimal NombreTraites { get;set; }   // Batch_Schedule_New.Bat_NombreTraites

      [Required]
      [Column("Bat_NombreErreurs")]
      public decimal NombreErreurs { get;set; }   // Batch_Schedule_New.Bat_NombreErreurs

      [Required]
      [Column("Bat_NomFichierLog")]
      public string NomFichierLog { get;set; }   // Batch_Schedule_New.Bat_NomFichierLog

      [Required]
      [Column("Bat_WebApp")]
      public decimal WebApp { get;set; }   // Batch_Schedule_New.Bat_WebApp

      [Required]
      [Column("Bat_UserLogin")]
      public string UserLogin { get;set; }   // Batch_Schedule_New.Bat_UserLogin

   }

   [Table("Prime_Contrat")]
   public partial class Prime_Contrat
   {

      [Key]
      [Column("Pct_Id")]
      public decimal ID { get;set; }  // Prime_Contrat.Pct_Id (PrimaryKey)

      [Required]
      [Column("Pct_Exercice")]
      public string Exercice { get;set; }   // Prime_Contrat.Pct_Exercice

      [Required]
      [Column("Pct_Niss")]
      public string Niss { get;set; }   // Prime_Contrat.Pct_Niss

      [Required]
      [Column("Pct_ONSS")]
      public string ONSS { get;set; }   // Prime_Contrat.Pct_ONSS

      [Required]
      [Column("Pct_SalaireReel")]
      public decimal SalaireReel { get;set; }   // Prime_Contrat.Pct_SalaireReel

      [Required]
      [Column("Pct_SalaireAssimile")]
      public decimal SalaireAssimile { get;set; }   // Prime_Contrat.Pct_SalaireAssimile

      [Required]
      [Column("Pct_JoursPrestes")]
      public decimal JoursPrestes { get;set; }   // Prime_Contrat.Pct_JoursPrestes

      [Required]
      [Column("Pct_JoursVacances")]
      public decimal JoursVacances { get;set; }   // Prime_Contrat.Pct_JoursVacances

      [Required]
      [Column("Pct_JoursMaladie")]
      public decimal JoursMaladie { get;set; }   // Prime_Contrat.Pct_JoursMaladie

      [Required]
      [Column("Pct_JoursMaternite")]
      public decimal JoursMaternite { get;set; }   // Prime_Contrat.Pct_JoursMaternite

      [Required]
      [Column("Pct_JoursAssimiles")]
      public decimal JoursAssimiles { get;set; }   // Prime_Contrat.Pct_JoursAssimiles

      [Required]
      [Column("Pct_PrimeBrute")]
      public decimal PrimeBrute { get;set; }   // Prime_Contrat.Pct_PrimeBrute

      [Required]
      [Column("Pct_RetenueONSS")]
      public decimal RetenueONSS { get;set; }   // Prime_Contrat.Pct_RetenueONSS

      [Required]
      [Column("Pct_BaseImposable")]
      public decimal BaseImposable { get;set; }   // Prime_Contrat.Pct_BaseImposable

      [Required]
      [Column("Pct_RetenueFiscale")]
      public decimal RetenueFiscale { get;set; }   // Prime_Contrat.Pct_RetenueFiscale

      [Required]
      [Column("Pct_PrimeNette")]
      public decimal PrimeNette { get;set; }   // Prime_Contrat.Pct_PrimeNette

      [Required]
      [Column("Pct_SFJCalcule")]
      public decimal SFJCalcule { get;set; }   // Prime_Contrat.Pct_SFJCalcule

      [Required]
      [Column("Pct_SFJManuel")]
      public decimal SFJManuel { get;set; }   // Prime_Contrat.Pct_SFJManuel

      [Required]
      [Column("Pct_SalaireReelT1")]
      public decimal SalaireReelT1 { get;set; }   // Prime_Contrat.Pct_SalaireReelT1

      [Required]
      [Column("Pct_SalaireReelT2")]
      public decimal SalaireReelT2 { get;set; }   // Prime_Contrat.Pct_SalaireReelT2

      [Required]
      [Column("Pct_SalaireReelT3")]
      public decimal SalaireReelT3 { get;set; }   // Prime_Contrat.Pct_SalaireReelT3

      [Required]
      [Column("Pct_SalaireReelT4")]
      public decimal SalaireReelT4 { get;set; }   // Prime_Contrat.Pct_SalaireReelT4

      [Required]
      [Column("Pct_JoursPrestesT1")]
      public decimal JoursPrestesT1 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT1

      [Required]
      [Column("Pct_JoursPrestesT2")]
      public decimal JoursPrestesT2 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT2

      [Required]
      [Column("Pct_JoursPrestesT3")]
      public decimal JoursPrestesT3 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT3

      [Required]
      [Column("Pct_JoursPrestesT4")]
      public decimal JoursPrestesT4 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT4

      [Required]
      [Column("Pct_NombreCasT1")]
      public decimal NombreCasT1 { get;set; }   // Prime_Contrat.Pct_NombreCasT1

      [Required]
      [Column("Pct_NombreCasT2")]
      public decimal NombreCasT2 { get;set; }   // Prime_Contrat.Pct_NombreCasT2

      [Required]
      [Column("Pct_NombreCasT3")]
      public decimal NombreCasT3 { get;set; }   // Prime_Contrat.Pct_NombreCasT3

      [Required]
      [Column("Pct_NombreCasT4")]
      public decimal NombreCasT4 { get;set; }   // Prime_Contrat.Pct_NombreCasT4

      [Column("Ptr_Id")]
      public decimal PtrId_Key { get;set; }  // Prime_Contrat.Ptr_Id (ForeignKey)

      [Column("Con_ID")]
      public decimal ConId_Key { get;set; }  // Prime_Contrat.Con_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("PtrId_Key")]
      public virtual Prime_Travailleur Prime_Travailleur { get; set; }

      [ForeignKey("ConId_Key")]
      public virtual Contrat Contrat { get; set; }

      // Reverse Navigation

      [InverseProperty("PctId_Key")]
      public virtual List<Ligne_Releve> Ligne_Releve { get; set; }

      [InverseProperty("PctId_Key")]
      public virtual List<Ligne_Travailleur> Ligne_Travailleur { get; set; }

   }

   [Table("Mutation_ONSS")]
   public partial class Mutation_ONSS
   {

      [Key]
      [Column("Muo_Id")]
      public decimal ID { get;set; }  // Mutation_ONSS.Muo_Id (PrimaryKey)

      [Required]
      [Column("Muo_ONSSOrigine")]
      public string ONSSOrigine { get;set; }   // Mutation_ONSS.Muo_ONSSOrigine

      [Required]
      [Column("Muo_ONSSDestination")]
      public string ONSSDestination { get;set; }   // Mutation_ONSS.Muo_ONSSDestination

      [Required]
      [Column("Muo_BCEOrigine")]
      public string BCEOrigine { get;set; }   // Mutation_ONSS.Muo_BCEOrigine

      [Required]
      [Column("Muo_BCEDestination")]
      public string BCEDestination { get;set; }   // Mutation_ONSS.Muo_BCEDestination

      [Required]
      [Column("Muo_DateMutation")]
      public DateTime DateMutation { get;set; }   // Mutation_ONSS.Muo_DateMutation

      [Required]
      [Column("Muo_TypeMutation")]
      public string TypeMutation { get;set; }   // Mutation_ONSS.Muo_TypeMutation

      [Column("Emp_Id")]
      public decimal EmpId_Key { get;set; }  // Mutation_ONSS.Emp_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("EmpId_Key")]
      public virtual Employeur Employeur { get; set; }

   }

   [Table("Remuneration")]
   public partial class Remuneration
   {

      [Key]
      [Column("Rem_Id")]
      public decimal ID { get;set; }  // Remuneration.Rem_Id (PrimaryKey)

      [Required]
      [Column("Rem_NoAttestation")]
      public string NoAttestation { get;set; }   // Remuneration.Rem_NoAttestation

      [Required]
      [Column("Rem_NoSituation")]
      public string NoSituation { get;set; }   // Remuneration.Rem_NoSituation

      [Required]
      [Column("Rem_Trimestre")]
      public string Trimestre { get;set; }   // Remuneration.Rem_Trimestre

      [Required]
      [Column("Rem_NoLigneRemuneration")]
      public string NoLigneRemuneration { get;set; }   // Remuneration.Rem_NoLigneRemuneration

      [Required]
      [Column("Rem_CodeRemuneration")]
      public string CodeRemuneration { get;set; }   // Remuneration.Rem_CodeRemuneration

      [Required]
      [Column("Rem_SalaireBrut")]
      public decimal SalaireBrut { get;set; }   // Remuneration.Rem_SalaireBrut

      [Required]
      [Column("Rem_TextLibre")]
      public string TextLibre { get;set; }   // Remuneration.Rem_TextLibre

      [Column("Occ_Id")]
      public decimal OccId_Key { get;set; }  // Remuneration.Occ_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("OccId_Key")]
      public virtual Ligne_Occupation Ligne_Occupation { get; set; }

   }

   [Table("Prime_Travailleur")]
   public partial class Prime_Travailleur
   {

      [Key]
      [Column("Ptr_Id")]
      public decimal ID { get;set; }  // Prime_Travailleur.Ptr_Id (PrimaryKey)

      [Required]
      [Column("Ptr_Exercice")]
      public string Exercice { get;set; }   // Prime_Travailleur.Ptr_Exercice

      [Required]
      [Column("Ptr_Niss")]
      public string Niss { get;set; }   // Prime_Travailleur.Ptr_Niss

      [Required]
      [Column("Ptr_SalaireReel")]
      public decimal SalaireReel { get;set; }   // Prime_Travailleur.Ptr_SalaireReel

      [Required]
      [Column("Ptr_SalaireAssimile")]
      public decimal SalaireAssimile { get;set; }   // Prime_Travailleur.Ptr_SalaireAssimile

      [Required]
      [Column("Ptr_JoursPrestes")]
      public decimal JoursPrestes { get;set; }   // Prime_Travailleur.Ptr_JoursPrestes

      [Required]
      [Column("Ptr_JoursVacances")]
      public decimal JoursVacances { get;set; }   // Prime_Travailleur.Ptr_JoursVacances

      [Required]
      [Column("Ptr_JoursMaladie")]
      public decimal JoursMaladie { get;set; }   // Prime_Travailleur.Ptr_JoursMaladie

      [Required]
      [Column("Ptr_JoursMaternite")]
      public decimal JoursMaternite { get;set; }   // Prime_Travailleur.Ptr_JoursMaternite

      [Required]
      [Column("Ptr_JoursAssimiles")]
      public decimal JoursAssimiles { get;set; }   // Prime_Travailleur.Ptr_JoursAssimiles

      [Required]
      [Column("Ptr_PrimeBrute")]
      public decimal PrimeBrute { get;set; }   // Prime_Travailleur.Ptr_PrimeBrute

      [Required]
      [Column("Ptr_RetenueONSS")]
      public decimal RetenueONSS { get;set; }   // Prime_Travailleur.Ptr_RetenueONSS

      [Required]
      [Column("Ptr_BaseImposable")]
      public decimal BaseImposable { get;set; }   // Prime_Travailleur.Ptr_BaseImposable

      [Required]
      [Column("Ptr_Frontalier")]
      public string Frontalier { get;set; }   // Prime_Travailleur.Ptr_Frontalier

      [Required]
      [Column("Ptr_RetenueFiscale")]
      public decimal RetenueFiscale { get;set; }   // Prime_Travailleur.Ptr_RetenueFiscale

      [Required]
      [Column("Ptr_PrimeNette")]
      public decimal PrimeNette { get;set; }   // Prime_Travailleur.Ptr_PrimeNette

      [Required]
      [Column("Ptr_PrimeSyndicale")]
      public decimal PrimeSyndicale { get;set; }   // Prime_Travailleur.Ptr_PrimeSyndicale

      [Required]
      [Column("Ptr_PrimeFormation")]
      public decimal PrimeFormation { get;set; }   // Prime_Travailleur.Ptr_PrimeFormation

      [Required]
      [Column("Ptr_SoldePayable")]
      public decimal SoldePayable { get;set; }   // Prime_Travailleur.Ptr_SoldePayable

      [Required]
      [Column("Ptr_BaseCalculSaisie")]
      public decimal BaseCalculSaisie { get;set; }   // Prime_Travailleur.Ptr_BaseCalculSaisie

      [Required]
      [Column("Ptr_TotalPaiements")]
      public decimal TotalPaiements { get;set; }   // Prime_Travailleur.Ptr_TotalPaiements

      [Required]
      [Column("Ptr_SoldeSaisissable")]
      public decimal SoldeSaisissable { get;set; }   // Prime_Travailleur.Ptr_SoldeSaisissable

      [Required]
      [Column("Ptr_DateCalcul")]
      public DateTime DateCalcul { get;set; }   // Prime_Travailleur.Ptr_DateCalcul

      [Required]
      [Column("Ptr_DerogationPfa")]
      public string DerogationPfa { get;set; }   // Prime_Travailleur.Ptr_DerogationPfa

      [Required]
      [Column("Ptr_DerogationTitre")]
      public string DerogationTitre { get;set; }   // Prime_Travailleur.Ptr_DerogationTitre

      [Column("Tra_ID")]
      public decimal TraId_Key { get;set; }  // Prime_Travailleur.Tra_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("PtrId_Key")]
      public virtual List<Prime_Contrat> Prime_Contrat { get; set; }

      [InverseProperty("PtrId_Key")]
      public virtual List<Titre> Titre { get; set; }

      [InverseProperty("PtrId_Key")]
      public virtual List<Retenue_Creance> Retenue_Creance { get; set; }

   }

   [Table("Declaration_Travailleur")]
   public partial class Declaration_Travailleur
   {

      [Key]
      [Column("Dtv_Id")]
      public decimal ID { get;set; }  // Declaration_Travailleur.Dtv_Id (PrimaryKey)

      [Required]
      [Column("Dtv_Active")]
      public string Active { get;set; }   // Declaration_Travailleur.Dtv_Active

      [Required]
      [Column("Dtv_Trimestre")]
      public string Trimestre { get;set; }   // Declaration_Travailleur.Dtv_Trimestre

      [Required]
      [Column("Dtv_Niss")]
      public string Niss { get;set; }   // Declaration_Travailleur.Dtv_Niss

      [Required]
      [Column("Dtv_Onss")]
      public string Onss { get;set; }   // Declaration_Travailleur.Dtv_Onss

      [Required]
      [Column("Dtv_CodeTravailleur")]
      public string CodeTravailleur { get;set; }   // Declaration_Travailleur.Dtv_CodeTravailleur

      [Required]
      [Column("Dtv_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Declaration_Travailleur.Dtv_CategorieEmployeur

      [Required]
      [Column("Dtv_CodeAction")]
      public string CodeAction { get;set; }   // Declaration_Travailleur.Dtv_CodeAction

      [Required]
      [Column("Dtv_TravailleurPID")]
      public decimal TravailleurPID { get;set; }   // Declaration_Travailleur.Dtv_TravailleurPID

      [Required]
      [Column("Dtv_TravailleurDeclarePID")]
      public decimal TravailleurDeclarePID { get;set; }   // Declaration_Travailleur.Dtv_TravailleurDeclarePID

      [Required]
      [Column("Dtv_TravailleurDeclareNoVersion")]
      public decimal TravailleurDeclareNoVersion { get;set; }   // Declaration_Travailleur.Dtv_TravailleurDeclareNoVersion

      [Required]
      [Column("Dtv_NoVersionLTR")]
      public decimal NoVersionLTR { get;set; }   // Declaration_Travailleur.Dtv_NoVersionLTR

      [Required]
      [Column("Dtv_FichierDMFA")]
      public string FichierDMFA { get;set; }   // Declaration_Travailleur.Dtv_FichierDMFA

      [Required]
      [Column("Dtv_DateInjectionDMFA")]
      public DateTime DateInjectionDMFA { get;set; }   // Declaration_Travailleur.Dtv_DateInjectionDMFA

      [Required]
      [Column("Dtv_FichierPID")]
      public string FichierPID { get;set; }   // Declaration_Travailleur.Dtv_FichierPID

      [Required]
      [Column("Dtv_DateInjectionPID")]
      public DateTime DateInjectionPID { get;set; }   // Declaration_Travailleur.Dtv_DateInjectionPID

      [Required]
      [Column("Dtv_Source")]
      public string Source { get;set; }   // Declaration_Travailleur.Dtv_Source

      [Column("Dec_Id")]
      public decimal DecId_Key { get;set; }  // Declaration_Travailleur.Dec_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DecId_Key")]
      public virtual Declaration_Onss Declaration_Onss { get; set; }

      // Reverse Navigation

      [InverseProperty("DtvId_Key")]
      public virtual List<Declaration_CotisationPrepension> Declaration_CotisationPrepension { get; set; }

   }

   [Table("Titre")]
   public partial class Titre
   {

      [Key]
      [Column("Tit_Id")]
      public decimal ID { get;set; }  // Titre.Tit_Id (PrimaryKey)

      [Required]
      [Column("Tit_Numero")]
      public string Numero { get;set; }   // Titre.Tit_Numero

      [Required]
      [Column("Tit_Etat")]
      public string Etat { get;set; }   // Titre.Tit_Etat

      [Required]
      [Column("Tit_DateEmission")]
      public DateTime DateEmission { get;set; }   // Titre.Tit_DateEmission

      [Required]
      [Column("Tit_DateRetour")]
      public DateTime DateRetour { get;set; }   // Titre.Tit_DateRetour

      [Required]
      [Column("Tit_DateExecution")]
      public DateTime DateExecution { get;set; }   // Titre.Tit_DateExecution

      [Required]
      [Column("Tit_SalaireReel")]
      public decimal SalaireReel { get;set; }   // Titre.Tit_SalaireReel

      [Required]
      [Column("Tit_SalaireAssimile")]
      public decimal SalaireAssimile { get;set; }   // Titre.Tit_SalaireAssimile

      [Required]
      [Column("Tit_JoursPrestes")]
      public decimal JoursPrestes { get;set; }   // Titre.Tit_JoursPrestes

      [Required]
      [Column("Tit_JoursVacances")]
      public decimal JoursVacances { get;set; }   // Titre.Tit_JoursVacances

      [Required]
      [Column("Tit_JoursMaladie")]
      public decimal JoursMaladie { get;set; }   // Titre.Tit_JoursMaladie

      [Required]
      [Column("Tit_JoursMaternite")]
      public decimal JoursMaternite { get;set; }   // Titre.Tit_JoursMaternite

      [Required]
      [Column("Tit_JoursAssimiles")]
      public decimal JoursAssimiles { get;set; }   // Titre.Tit_JoursAssimiles

      [Required]
      [Column("Tit_PrimeBrute")]
      public decimal PrimeBrute { get;set; }   // Titre.Tit_PrimeBrute

      [Required]
      [Column("Tit_RetenueONSS")]
      public decimal RetenueONSS { get;set; }   // Titre.Tit_RetenueONSS

      [Required]
      [Column("Tit_BaseImposable")]
      public decimal BaseImposable { get;set; }   // Titre.Tit_BaseImposable

      [Required]
      [Column("Tit_RetenueFiscale")]
      public decimal RetenueFiscale { get;set; }   // Titre.Tit_RetenueFiscale

      [Required]
      [Column("Tit_PrimeNette")]
      public decimal PrimeNette { get;set; }   // Titre.Tit_PrimeNette

      [Required]
      [Column("Tit_PrimeFormation")]
      public decimal PrimeFormation { get;set; }   // Titre.Tit_PrimeFormation

      [Required]
      [Column("Tit_PrimeSyndicale")]
      public decimal PrimeSyndicale { get;set; }   // Titre.Tit_PrimeSyndicale

      [Required]
      [Column("Tit_CodeSyndical")]
      public string CodeSyndical { get;set; }   // Titre.Tit_CodeSyndical

      [Required]
      [Column("Tit_FraisAdministratifs")]
      public decimal FraisAdministratifs { get;set; }   // Titre.Tit_FraisAdministratifs

      [Required]
      [Column("Tit_Commentaire")]
      public string Commentaire { get;set; }   // Titre.Tit_Commentaire

      [Required]
      [Column("Tit_MontantPaye")]
      public decimal MontantPaye { get;set; }   // Titre.Tit_MontantPaye

      [Required]
      [Column("Tit_DateDuplicata")]
      public DateTime DateDuplicata { get;set; }   // Titre.Tit_DateDuplicata

      [Required]
      [Column("Tit_NissOrigine")]
      public string NissOrigine { get;set; }   // Titre.Tit_NissOrigine

      [Required]
      [Column("Tit_AdresseRue")]
      public string AdresseRue { get;set; }   // Titre.Tit_AdresseRue

      [Required]
      [Column("Tit_AdresseNo")]
      public string AdresseNo { get;set; }   // Titre.Tit_AdresseNo

      [Required]
      [Column("Tit_AdresseBte")]
      public string AdresseBte { get;set; }   // Titre.Tit_AdresseBte

      [Required]
      [Column("Tit_CodePostal")]
      public string CodePostal { get;set; }   // Titre.Tit_CodePostal

      [Required]
      [Column("Tit_Localite")]
      public string Localite { get;set; }   // Titre.Tit_Localite

      [Required]
      [Column("Tit_CodePays")]
      public string CodePays { get;set; }   // Titre.Tit_CodePays

      [Column("Ptr_Id")]
      public decimal PtrId_Key { get;set; }  // Titre.Ptr_Id (ForeignKey)

      [Column("Lot_Id")]
      public decimal LotId_Key { get;set; }  // Titre.Lot_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("PtrId_Key")]
      public virtual Prime_Travailleur Prime_Travailleur { get; set; }

      [ForeignKey("LotId_Key")]
      public virtual Decompte_Lot Decompte_Lot { get; set; }

      // Reverse Navigation

      [InverseProperty("TitId_Key")]
      public virtual List<Payement> Payement { get; set; }

   }

   [Table("Pension_Travailleur")]
   public partial class Pension_Travailleur
   {

      [Key]
      [Column("Dtr_Id")]
      public decimal ID { get;set; }  // Pension_Travailleur.Dtr_Id (PrimaryKey)

      [Required]
      [Column("Dtr_Niss")]
      public string Niss { get;set; }   // Pension_Travailleur.Dtr_Niss

      [Required]
      [Column("Dtr_Exercice")]
      public string Exercice { get;set; }   // Pension_Travailleur.Dtr_Exercice

      [Required]
      [Column("Dtr_JoursOnss")]
      public decimal JoursOnss { get;set; }   // Pension_Travailleur.Dtr_JoursOnss

      [Required]
      [Column("Dtr_ExportJoursOnss")]
      public decimal ExportJoursOnss { get;set; }   // Pension_Travailleur.Dtr_ExportJoursOnss

      [Required]
      [Column("Dtr_DeltaJoursOnss")]
      public decimal DeltaJoursOnss { get;set; }   // Pension_Travailleur.Dtr_DeltaJoursOnss

      [Required]
      [Column("Dtr_SalaireBrut")]
      public decimal SalaireBrut { get;set; }   // Pension_Travailleur.Dtr_SalaireBrut

      [Required]
      [Column("Dtr_ExportSalaireBrut")]
      public decimal ExportSalaireBrut { get;set; }   // Pension_Travailleur.Dtr_ExportSalaireBrut

      [Required]
      [Column("Dtr_DeltaSalaireBrut")]
      public decimal DeltaSalaireBrut { get;set; }   // Pension_Travailleur.Dtr_DeltaSalaireBrut

      [Required]
      [Column("Dtr_PrimeInactivite")]
      public decimal PrimeInactivite { get;set; }   // Pension_Travailleur.Dtr_PrimeInactivite

      [Required]
      [Column("Dtr_ExportPrimeInactivite")]
      public decimal ExportPrimeInactivite { get;set; }   // Pension_Travailleur.Dtr_ExportPrimeInactivite

      [Required]
      [Column("Dtr_DeltaPrimeInactivite")]
      public decimal DeltaPrimeInactivite { get;set; }   // Pension_Travailleur.Dtr_DeltaPrimeInactivite

      [Required]
      [Column("Dtr_PrimeDeces")]
      public string PrimeDeces { get;set; }   // Pension_Travailleur.Dtr_PrimeDeces

      [Required]
      [Column("Dtr_Etat")]
      public string Etat { get;set; }   // Pension_Travailleur.Dtr_Etat

      [Required]
      [Column("Dtr_DateEtat")]
      public DateTime DateEtat { get;set; }   // Pension_Travailleur.Dtr_DateEtat

      [Required]
      [Column("Dtr_TexteLibre")]
      public string TexteLibre { get;set; }   // Pension_Travailleur.Dtr_TexteLibre

      [Required]
      [Column("Dtr_ExportEnCours")]
      public string ExportEnCours { get;set; }   // Pension_Travailleur.Dtr_ExportEnCours

      [Column("Pen_Id")]
      public decimal PenId_Key { get;set; }  // Pension_Travailleur.Pen_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("PenId_Key")]
      public virtual Pension Pension { get; set; }

      // Reverse Navigation

      [InverseProperty("DtrId_Key")]
      public virtual List<Pension_Contrat> Pension_Contrat { get; set; }

   }

   [Table("Demande_Intervention_Automatique")]
   public partial class Demande_Intervention_Automatique
   {

      [Key]
      [Column("Dia_Id")]
      public decimal ID { get;set; }  // Demande_Intervention_Automatique.Dia_Id (PrimaryKey)

      [Required]
      [Column("Dia_Trimestre")]
      public string Trimestre { get;set; }   // Demande_Intervention_Automatique.Dia_Trimestre

      [Required]
      [Column("Dia_NumeroFolio")]
      public string NumeroFolio { get;set; }   // Demande_Intervention_Automatique.Dia_NumeroFolio

      [Required]
      [Column("Dia_TypeDemande")]
      public string TypeDemande { get;set; }   // Demande_Intervention_Automatique.Dia_TypeDemande

      [Required]
      [Column("Dia_DebutPeriode")]
      public DateTime DebutPeriode { get;set; }   // Demande_Intervention_Automatique.Dia_DebutPeriode

      [Required]
      [Column("Dia_FinPeriode")]
      public DateTime FinPeriode { get;set; }   // Demande_Intervention_Automatique.Dia_FinPeriode

      [Required]
      [Column("Dia_Etat")]
      public string Etat { get;set; }   // Demande_Intervention_Automatique.Dia_Etat

      [Required]
      [Column("Dia_DateEtat")]
      public DateTime DateEtat { get;set; }   // Demande_Intervention_Automatique.Dia_DateEtat

      [Required]
      [Column("Dia_Commentaire")]
      public string Commentaire { get;set; }   // Demande_Intervention_Automatique.Dia_Commentaire

      [Column("Din_Id")]
      public decimal DinId_Key { get;set; }  // Demande_Intervention_Automatique.Din_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DinId_Key")]
      public virtual Dossier_Intervention Dossier_Intervention { get; set; }

      // Reverse Navigation

      [InverseProperty("DiaId_Key")]
      public virtual List<Intervention> Intervention { get; set; }

   }

   [Table("Activite_Employeur")]
   public partial class Activite_Employeur
   {

      [Key]
      [Column("Aem_ID")]
      public decimal ID { get;set; }  // Activite_Employeur.Aem_ID (PrimaryKey)

      [Required]
      [Column("Aem_ONSS")]
      public string ONSS { get;set; }   // Activite_Employeur.Aem_ONSS

      [Required]
      [Column("Aem_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Activite_Employeur.Aem_CategorieEmployeur

      [Required]
      [Column("Aem_DateAffiliation")]
      public DateTime DateAffiliation { get;set; }   // Activite_Employeur.Aem_DateAffiliation

      [Required]
      [Column("Aem_DateSuppression")]
      public DateTime DateSuppression { get;set; }   // Activite_Employeur.Aem_DateSuppression

      [Required]
      [Column("Aem_DateMatricule")]
      public DateTime DateMatricule { get;set; }   // Activite_Employeur.Aem_DateMatricule

      [Required]
      [Column("Aem_DateRadiation")]
      public DateTime DateRadiation { get;set; }   // Activite_Employeur.Aem_DateRadiation

      [Required]
      [Column("Aem_CodeNACE")]
      public string CodeNACE { get;set; }   // Activite_Employeur.Aem_CodeNACE

      [Required]
      [Column("Aem_CodeImportance")]
      public string CodeImportance { get;set; }   // Activite_Employeur.Aem_CodeImportance

      [Column("Emp_ID")]
      public decimal EmpId_Key { get;set; }  // Activite_Employeur.Emp_ID (ForeignKey)

      [Column("Fnd_ID")]
      public decimal FndId_Key { get;set; }  // Activite_Employeur.Fnd_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("EmpId_Key")]
      public virtual Employeur Employeur { get; set; }

      [ForeignKey("FndId_Key")]
      public virtual Fonds Fonds { get; set; }

      // Reverse Navigation

      [InverseProperty("AemId_Key")]
      public virtual List<Dossier_Prepension> Dossier_Prepension { get; set; }

      [InverseProperty("AemId_Key")]
      public virtual List<Contrat> Contrat { get; set; }

      [InverseProperty("AemId_Key")]
      public virtual List<Validation_Envoi> Validation_Envoi { get; set; }

   }

   [Table("Journal_Fusion")]
   public partial class Journal_Fusion
   {

      [Key]
      [Column("Jfu_ID")]
      public decimal ID { get;set; }  // Journal_Fusion.Jfu_ID (PrimaryKey)

      [Required]
      [Column("Jfu_NissOrigine")]
      public string NissOrigine { get;set; }   // Journal_Fusion.Jfu_NissOrigine

      [Required]
      [Column("Jfu_NissDestination")]
      public string NissDestination { get;set; }   // Journal_Fusion.Jfu_NissDestination

      [Required]
      [Column("Jfu_DateFusion")]
      public DateTime DateFusion { get;set; }   // Journal_Fusion.Jfu_DateFusion

   }

   [Table("Batch_Schedule")]
   public partial class Batch_Schedule
   {

      [Key]
      [Column("Bat_Id")]
      public decimal ID { get;set; }  // Batch_Schedule.Bat_Id (PrimaryKey)

      [Required]
      [Column("Bat_Type")]
      public string Type { get;set; }   // Batch_Schedule.Bat_Type

      [Required]
      [Column("Bat_Description")]
      public string Description { get;set; }   // Batch_Schedule.Bat_Description

      [Required]
      [Column("Bat_Etat")]
      public string Etat { get;set; }   // Batch_Schedule.Bat_Etat

      [Required]
      [Column("Bat_SqlState")]
      public string SqlState { get;set; }   // Batch_Schedule.Bat_SqlState

      [Required]
      [Column("Bat_SqlState3")]
      public string SqlState3 { get;set; }   // Batch_Schedule.Bat_SqlState3

      [Required]
      [Column("Bat_SqlState2")]
      public string SqlState2 { get;set; }   // Batch_Schedule.Bat_SqlState2

      [Required]
      [Column("Bat_Parametres")]
      public string Parametres { get;set; }   // Batch_Schedule.Bat_Parametres

      [Required]
      [Column("Bat_Priorite")]
      public decimal Priorite { get;set; }   // Batch_Schedule.Bat_Priorite

      [Required]
      [Column("Bat_DatePlanifiee")]
      public DateTime DatePlanifiee { get;set; }   // Batch_Schedule.Bat_DatePlanifiee

      [Required]
      [Column("Bat_DateDebutExecution")]
      public DateTime DateDebutExecution { get;set; }   // Batch_Schedule.Bat_DateDebutExecution

      [Required]
      [Column("Bat_DateFinExecution")]
      public DateTime DateFinExecution { get;set; }   // Batch_Schedule.Bat_DateFinExecution

      [Required]
      [Column("Bat_Erreur")]
      public string Erreur { get;set; }   // Batch_Schedule.Bat_Erreur

      [Required]
      [Column("Bat_SqlText")]
      public string SqlText { get;set; }   // Batch_Schedule.Bat_SqlText

      [Required]
      [Column("Bat_Keywords")]
      public string Keywords { get;set; }   // Batch_Schedule.Bat_Keywords

   }

   [Table("Fiche_Pension")]
   public partial class Fiche_Pension
   {

      [Key]
      [Column("Fpe_ID")]
      public decimal ID { get;set; }  // Fiche_Pension.Fpe_ID (PrimaryKey)

      [Required]
      [Column("Fpe_DateReference")]
      public DateTime DateReference { get;set; }   // Fiche_Pension.Fpe_DateReference

      [Required]
      [Column("Fpe_Exercice")]
      public string Exercice { get;set; }   // Fiche_Pension.Fpe_Exercice

      [Required]
      [Column("Fpe_SalaireBrut")]
      public decimal SalaireBrut { get;set; }   // Fiche_Pension.Fpe_SalaireBrut

      [Required]
      [Column("Fpe_PrimePension")]
      public decimal PrimePension { get;set; }   // Fiche_Pension.Fpe_PrimePension

      [Required]
      [Column("Fpe_PrimeSolidarite")]
      public decimal PrimeSolidarite { get;set; }   // Fiche_Pension.Fpe_PrimeSolidarite

      [Required]
      [Column("Fpe_ReserveAcquise")]
      public decimal ReserveAcquise { get;set; }   // Fiche_Pension.Fpe_ReserveAcquise

      [Required]
      [Column("Fpe_GarantieMinimale")]
      public decimal GarantieMinimale { get;set; }   // Fiche_Pension.Fpe_GarantieMinimale

      [Required]
      [Column("Fpe_EcheanceContrat")]
      public DateTime EcheanceContrat { get;set; }   // Fiche_Pension.Fpe_EcheanceContrat

      [Required]
      [Column("Fpe_CapitalAcquis")]
      public decimal CapitalAcquis { get;set; }   // Fiche_Pension.Fpe_CapitalAcquis

      [Required]
      [Column("Fpe_AgePension")]
      public decimal AgePension { get;set; }   // Fiche_Pension.Fpe_AgePension

      [Required]
      [Column("Fpe_EstimationCapital")]
      public decimal EstimationCapital { get;set; }   // Fiche_Pension.Fpe_EstimationCapital

      [Required]
      [Column("Fpe_RenteAnuelle")]
      public decimal RenteAnuelle { get;set; }   // Fiche_Pension.Fpe_RenteAnuelle

      [Required]
      [Column("Fpe_Etat")]
      public string Etat { get;set; }   // Fiche_Pension.Fpe_Etat

      [Required]
      [Column("Fpe_DateEtat")]
      public DateTime DateEtat { get;set; }   // Fiche_Pension.Fpe_DateEtat

      [Required]
      [Column("Fpe_Rue")]
      public string Rue { get;set; }   // Fiche_Pension.Fpe_Rue

      [Required]
      [Column("Fpe_No")]
      public string No { get;set; }   // Fiche_Pension.Fpe_No

      [Required]
      [Column("Fpe_Bte")]
      public string Bte { get;set; }   // Fiche_Pension.Fpe_Bte

      [Required]
      [Column("Fpe_CodePostal")]
      public string CodePostal { get;set; }   // Fiche_Pension.Fpe_CodePostal

      [Required]
      [Column("Fpe_Localite")]
      public string Localite { get;set; }   // Fiche_Pension.Fpe_Localite

      [Required]
      [Column("Fpe_CodePays")]
      public string CodePays { get;set; }   // Fiche_Pension.Fpe_CodePays

      [Required]
      [Column("Fpe_DateNaissance")]
      public DateTime DateNaissance { get;set; }   // Fiche_Pension.Fpe_DateNaissance

      [Required]
      [Column("Fpe_CorrectionSalaire")]
      public decimal CorrectionSalaire { get;set; }   // Fiche_Pension.Fpe_CorrectionSalaire

      [Required]
      [Column("Fpe_DateReferencePcd")]
      public DateTime DateReferencePcd { get;set; }   // Fiche_Pension.Fpe_DateReferencePcd

      [Required]
      [Column("Fpe_ReserveAcquisePcd")]
      public decimal ReserveAcquisePcd { get;set; }   // Fiche_Pension.Fpe_ReserveAcquisePcd

      [Required]
      [Column("Fpe_ParticipationBeneficiaire")]
      public decimal ParticipationBeneficiaire { get;set; }   // Fiche_Pension.Fpe_ParticipationBeneficiaire

      [Column("Pen_ID")]
      public decimal PenId_Key { get;set; }  // Fiche_Pension.Pen_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("PenId_Key")]
      public virtual Pension Pension { get; set; }

   }

   [Table("Categorie_Employeur")]
   public partial class Categorie_Employeur
   {

      [Key]
      [Column("Cec_Id")]
      public decimal ID { get;set; }  // Categorie_Employeur.Cec_Id (PrimaryKey)

      [Required]
      [Column("Cec_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Categorie_Employeur.Cec_CategorieEmployeur

      [Required]
      [Column("Cec_CodeTravailleur")]
      public string CodeTravailleur { get;set; }   // Categorie_Employeur.Cec_CodeTravailleur

      [Required]
      [Column("Cec_DateDebutValidite")]
      public DateTime DateDebutValidite { get;set; }   // Categorie_Employeur.Cec_DateDebutValidite

      [Required]
      [Column("Cec_DateFinValidite")]
      public DateTime DateFinValidite { get;set; }   // Categorie_Employeur.Cec_DateFinValidite

      [Column("Fnd_ID")]
      public decimal FndId_Key { get;set; }  // Categorie_Employeur.Fnd_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("FndId_Key")]
      public virtual Fonds Fonds { get; set; }

   }

   [Table("Cheque")]
   public partial class Cheque
   {

      [Key]
      [Column("Chq_Id")]
      public decimal ID { get;set; }  // Cheque.Chq_Id (PrimaryKey)

      [Required]
      [Column("Pay_ID")]
      public decimal PayId { get;set; }   // Cheque.Pay_ID

      [Required]
      [Column("Chq_NoPayement")]
      public string NoPayement { get;set; }   // Cheque.Chq_NoPayement

      [Required]
      [Column("Chq_NoCheque")]
      public string NoCheque { get;set; }   // Cheque.Chq_NoCheque

      [Required]
      [Column("Chq_NISS")]
      public string NISS { get;set; }   // Cheque.Chq_NISS

      [Required]
      [Column("Chq_ONSS")]
      public string ONSS { get;set; }   // Cheque.Chq_ONSS

      [Required]
      [Column("Chq_Exercice")]
      public string Exercice { get;set; }   // Cheque.Chq_Exercice

      [Required]
      [Column("Chq_Montant")]
      public decimal Montant { get;set; }   // Cheque.Chq_Montant

      [Required]
      [Column("Chq_DonneurOrdre")]
      public string DonneurOrdre { get;set; }   // Cheque.Chq_DonneurOrdre

      [Required]
      [Column("Chq_Nom")]
      public string Nom { get;set; }   // Cheque.Chq_Nom

      [Required]
      [Column("Chq_Prenom")]
      public string Prenom { get;set; }   // Cheque.Chq_Prenom

      [Required]
      [Column("Chq_AdresseRue")]
      public string AdresseRue { get;set; }   // Cheque.Chq_AdresseRue

      [Required]
      [Column("Chq_AdresseBte")]
      public string AdresseBte { get;set; }   // Cheque.Chq_AdresseBte

      [Required]
      [Column("Chq_AdresseNo")]
      public string AdresseNo { get;set; }   // Cheque.Chq_AdresseNo

      [Required]
      [Column("Chq_CodePostal")]
      public string CodePostal { get;set; }   // Cheque.Chq_CodePostal

      [Required]
      [Column("Chq_Localite")]
      public string Localite { get;set; }   // Cheque.Chq_Localite

      [Required]
      [Column("Chq_CodePays")]
      public string CodePays { get;set; }   // Cheque.Chq_CodePays

      [Required]
      [Column("Chq_DateEmission")]
      public DateTime DateEmission { get;set; }   // Cheque.Chq_DateEmission

      [Required]
      [Column("Chq_DateFinValidite")]
      public DateTime DateFinValidite { get;set; }   // Cheque.Chq_DateFinValidite

      [Required]
      [Column("Chq_Langue")]
      public string Langue { get;set; }   // Cheque.Chq_Langue

      [Required]
      [Column("Chq_PremierPayement")]
      public string PremierPayement { get;set; }   // Cheque.Chq_PremierPayement

   }

   [Table("Cheque_Compteur")]
   public partial class Cheque_Compteur
   {

      [Key]
      [Column("Che_Id")]
      public decimal ID { get;set; }  // Cheque_Compteur.Che_Id (PrimaryKey)

      [Required]
      [Column("Che_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Cheque_Compteur.Che_CompteBancaire

      [Required]
      [Column("Che_Exercice")]
      public string Exercice { get;set; }   // Cheque_Compteur.Che_Exercice

      [Required]
      [Column("Che_Sequence")]
      public decimal Sequence { get;set; }   // Cheque_Compteur.Che_Sequence

      [Required]
      [Column("Che_Numero")]
      public decimal Numero { get;set; }   // Cheque_Compteur.Che_Numero

      [Required]
      [Column("Che_NumeroMin")]
      public decimal NumeroMin { get;set; }   // Cheque_Compteur.Che_NumeroMin

      [Required]
      [Column("Che_NumeroMax")]
      public decimal NumeroMax { get;set; }   // Cheque_Compteur.Che_NumeroMax

   }

   [Table("Compteur_Folio")]
   public partial class Compteur_Folio
   {

      [Key]
      [Column("Cfo_Id")]
      public decimal ID { get;set; }  // Compteur_Folio.Cfo_Id (PrimaryKey)

      [Required]
      [Column("Cfo_TypeIntervention")]
      public string TypeIntervention { get;set; }   // Compteur_Folio.Cfo_TypeIntervention

      [Required]
      [Column("Cfo_Prefixe")]
      public string Prefixe { get;set; }   // Compteur_Folio.Cfo_Prefixe

      [Required]
      [Column("Cfo_Valeur")]
      public decimal Valeur { get;set; }   // Compteur_Folio.Cfo_Valeur

      [Required]
      [Column("Cfo_Valeur_Auto")]
      public decimal Valeur_Auto { get;set; }   // Compteur_Folio.Cfo_Valeur_Auto

   }

   [Table("Assimilation")]
   public partial class Assimilation
   {

      [Key]
      [Column("Ass_Id")]
      public decimal ID { get;set; }  // Assimilation.Ass_Id (PrimaryKey)

      [Required]
      [Column("Ass_NoAttestation")]
      public string NoAttestation { get;set; }   // Assimilation.Ass_NoAttestation

      [Required]
      [Column("Ass_NoSituation")]
      public string NoSituation { get;set; }   // Assimilation.Ass_NoSituation

      [Required]
      [Column("Ass_Trimestre")]
      public string Trimestre { get;set; }   // Assimilation.Ass_Trimestre

      [Required]
      [Column("Ass_CodePrestation")]
      public string CodePrestation { get;set; }   // Assimilation.Ass_CodePrestation

      [Required]
      [Column("Ass_Etat")]
      public string Etat { get;set; }   // Assimilation.Ass_Etat

      [Required]
      [Column("Ass_JoursAttribues")]
      public decimal JoursAttribues { get;set; }   // Assimilation.Ass_JoursAttribues

      [Required]
      [Column("Ass_DateAttribution")]
      public DateTime DateAttribution { get;set; }   // Assimilation.Ass_DateAttribution

      [Required]
      [Column("Ass_Gestionnaire")]
      public string Gestionnaire { get;set; }   // Assimilation.Ass_Gestionnaire

      [Required]
      [Column("Ass_TextLibre")]
      public string TextLibre { get;set; }   // Assimilation.Ass_TextLibre

      [Required]
      [Column("Ass_F2PJoursAttribues")]
      public decimal F2PJoursAttribues { get;set; }   // Assimilation.Ass_F2PJoursAttribues

      [Column("Prs_Id")]
      public decimal PrsId_Key { get;set; }  // Assimilation.Prs_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("PrsId_Key")]
      public virtual Prestation Prestation { get; set; }

   }

   [Table("Contrat")]
   public partial class Contrat
   {

      [Key]
      [Column("Con_ID")]
      public decimal ID { get;set; }  // Contrat.Con_ID (PrimaryKey)

      [Required]
      [Column("Con_NISS")]
      public string NISS { get;set; }   // Contrat.Con_NISS

      [Required]
      [Column("Con_ONSS")]
      public string ONSS { get;set; }   // Contrat.Con_ONSS

      [Required]
      [Column("Con_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Contrat.Con_CategorieEmployeur

      [Required]
      [Column("Con_CodeTravailleur")]
      public string CodeTravailleur { get;set; }   // Contrat.Con_CodeTravailleur

      [Required]
      [Column("Con_ComiteParitaire")]
      public string ComiteParitaire { get;set; }   // Contrat.Con_ComiteParitaire

      [Required]
      [Column("Con_DateEntree")]
      public DateTime DateEntree { get;set; }   // Contrat.Con_DateEntree

      [Required]
      [Column("Con_DateSortie")]
      public DateTime DateSortie { get;set; }   // Contrat.Con_DateSortie

      [Required]
      [Column("Con_NumeroMatricule")]
      public string NumeroMatricule { get;set; }   // Contrat.Con_NumeroMatricule

      [Required]
      [Column("Con_Division")]
      public string Division { get;set; }   // Contrat.Con_Division

      [Required]
      [Column("Con_TravailContinu")]
      public string TravailContinu { get;set; }   // Contrat.Con_TravailContinu

      [Required]
      [Column("Con_DatePrepension")]
      public DateTime DatePrepension { get;set; }   // Contrat.Con_DatePrepension

      [Required]
      [Column("Con_DatePension")]
      public DateTime DatePension { get;set; }   // Contrat.Con_DatePension

      [Column("Aem_ID")]
      public decimal AemId_Key { get;set; }  // Contrat.Aem_ID (ForeignKey)

      [Column("Tra_ID")]
      public decimal TraId_Key { get;set; }  // Contrat.Tra_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("AemId_Key")]
      public virtual Activite_Employeur Activite_Employeur { get; set; }

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("ConId_Key")]
      public virtual List<Pension_Contrat> Pension_Contrat { get; set; }

      [InverseProperty("ConId_Key")]
      public virtual List<Anciennete_Contrat> Anciennete_Contrat { get; set; }

      [InverseProperty("ConId_Key")]
      public virtual List<Prime_Contrat> Prime_Contrat { get; set; }

      [InverseProperty("ConId_Key")]
      public virtual List<Ligne_Releve> Ligne_Releve { get; set; }

      [InverseProperty("ConId_Key")]
      public virtual List<Dossier_Intervention> Dossier_Intervention { get; set; }

      [InverseProperty("ConId_Key")]
      public virtual List<Ligne_Travailleur> Ligne_Travailleur { get; set; }

   }

   [Table("Drs_A037ChomageTemporaire")]
   public partial class Drs_A037ChomageTemporaire
   {

      [Key]
      [Column("D37_Id")]
      public decimal ID { get;set; }  // Drs_A037ChomageTemporaire.D37_Id (PrimaryKey)

      [Required]
      [Column("D37_CodeChomage")]
      public string CodeChomage { get;set; }   // Drs_A037ChomageTemporaire.D37_CodeChomage

      [Required]
      [Column("D37_UniteDureePayee")]
      public string UniteDureePayee { get;set; }   // Drs_A037ChomageTemporaire.D37_UniteDureePayee

      [Required]
      [Column("D37_ValeurDureePayee")]
      public decimal ValeurDureePayee { get;set; }   // Drs_A037ChomageTemporaire.D37_ValeurDureePayee

      [Required]
      [Column("D37_NbrAllocationPayee")]
      public decimal NbrAllocationPayee { get;set; }   // Drs_A037ChomageTemporaire.D37_NbrAllocationPayee

      [Required]
      [Column("D37_UniteDureeRefusee")]
      public string UniteDureeRefusee { get;set; }   // Drs_A037ChomageTemporaire.D37_UniteDureeRefusee

      [Required]
      [Column("D37_ValeurDureeRefusee")]
      public decimal ValeurDureeRefusee { get;set; }   // Drs_A037ChomageTemporaire.D37_ValeurDureeRefusee

      [Required]
      [Column("D37_NbrAllocationRefusee")]
      public decimal NbrAllocationRefusee { get;set; }   // Drs_A037ChomageTemporaire.D37_NbrAllocationRefusee

      [Required]
      [Column("D37_NbrAllocationRefuseeAutre")]
      public decimal NbrAllocationRefuseeAutre { get;set; }   // Drs_A037ChomageTemporaire.D37_NbrAllocationRefuseeAutre

      [Column("A37_Id")]
      public decimal A37Id_Key { get;set; }  // Drs_A037ChomageTemporaire.A37_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("A37Id_Key")]
      public virtual Drs_A037 Drs_A037 { get; set; }

   }

   [Table("Drs_Envoi")]
   public partial class Drs_Envoi
   {

      [Key]
      [Column("Drs_Id")]
      public decimal ID { get;set; }  // Drs_Envoi.Drs_Id (PrimaryKey)

      [Required]
      [Column("Drs_Type")]
      public string Type { get;set; }   // Drs_Envoi.Drs_Type

      [Required]
      [Column("Drs_NomFichier")]
      public string NomFichier { get;set; }   // Drs_Envoi.Drs_NomFichier

      [Required]
      [Column("Drs_DateInjection")]
      public DateTime DateInjection { get;set; }   // Drs_Envoi.Drs_DateInjection

      // Reverse Navigation

      [InverseProperty("DrsId_Key")]
      public virtual List<Drs_A037> Drs_A037 { get; set; }

      [InverseProperty("DrsId_Key")]
      public virtual List<Drs_A044_Attestation> Drs_A044_Attestation { get; set; }

   }

   [Table("Decompte_Lot")]
   public partial class Decompte_Lot
   {

      [Key]
      [Column("Lot_Id")]
      public decimal ID { get;set; }  // Decompte_Lot.Lot_Id (PrimaryKey)

      [Required]
      [Column("Lot_Numero")]
      public string Numero { get;set; }   // Decompte_Lot.Lot_Numero

      [Required]
      [Column("Lot_NombreTitres")]
      public decimal NombreTitres { get;set; }   // Decompte_Lot.Lot_NombreTitres

      [Required]
      [Column("Lot_Salaires")]
      public decimal Salaires { get;set; }   // Decompte_Lot.Lot_Salaires

      [Required]
      [Column("Lot_JoursPrestes")]
      public decimal JoursPrestes { get;set; }   // Decompte_Lot.Lot_JoursPrestes

      [Required]
      [Column("Lot_JoursVacances")]
      public decimal JoursVacances { get;set; }   // Decompte_Lot.Lot_JoursVacances

      [Required]
      [Column("Lot_JoursMaladie")]
      public decimal JoursMaladie { get;set; }   // Decompte_Lot.Lot_JoursMaladie

      [Required]
      [Column("Lot_JoursMaternite")]
      public decimal JoursMaternite { get;set; }   // Decompte_Lot.Lot_JoursMaternite

      [Required]
      [Column("Lot_JoursAssimimles")]
      public decimal JoursAssimimles { get;set; }   // Decompte_Lot.Lot_JoursAssimimles

      [Required]
      [Column("Lot_NbrePrimesSyndicales")]
      public decimal NbrePrimesSyndicales { get;set; }   // Decompte_Lot.Lot_NbrePrimesSyndicales

      [Required]
      [Column("Lot_TotalPrimesSyndicales")]
      public decimal TotalPrimesSyndicales { get;set; }   // Decompte_Lot.Lot_TotalPrimesSyndicales

      [Required]
      [Column("Lot_NbrePrimesFormation")]
      public decimal NbrePrimesFormation { get;set; }   // Decompte_Lot.Lot_NbrePrimesFormation

      [Required]
      [Column("Lot_TotalPrimesFormation")]
      public decimal TotalPrimesFormation { get;set; }   // Decompte_Lot.Lot_TotalPrimesFormation

      [Required]
      [Column("Lot_TotalBrutPrimes")]
      public decimal TotalBrutPrimes { get;set; }   // Decompte_Lot.Lot_TotalBrutPrimes

      [Required]
      [Column("Lot_RetenueONSS")]
      public decimal RetenueONSS { get;set; }   // Decompte_Lot.Lot_RetenueONSS

      [Required]
      [Column("Lot_BaseImposable")]
      public decimal BaseImposable { get;set; }   // Decompte_Lot.Lot_BaseImposable

      [Required]
      [Column("Lot_RetenueFiscale")]
      public decimal RetenueFiscale { get;set; }   // Decompte_Lot.Lot_RetenueFiscale

      [Required]
      [Column("Lot_NetAvantFrais")]
      public decimal NetAvantFrais { get;set; }   // Decompte_Lot.Lot_NetAvantFrais

      [Required]
      [Column("Lot_FraisAdministratifs")]
      public decimal FraisAdministratifs { get;set; }   // Decompte_Lot.Lot_FraisAdministratifs

      [Required]
      [Column("Lot_Net")]
      public decimal Net { get;set; }   // Decompte_Lot.Lot_Net

      [Column("Liv_Id")]
      public decimal LivId_Key { get;set; }  // Decompte_Lot.Liv_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("LivId_Key")]
      public virtual Livre Livre { get; set; }

      // Reverse Navigation

      [InverseProperty("LotId_Key")]
      public virtual List<Titre> Titre { get; set; }

   }

   [Table("Att_A045")]
   public partial class Att_A045
   {

      [Key]
      [Column("Att45_Id")]
      public decimal ID { get;set; }  // Att_A045.Att45_Id (PrimaryKey)

      [Required]
      [Column("Att45_Active")]
      public string Active { get;set; }   // Att_A045.Att45_Active

      [Required]
      [Column("Att45_INSS")]
      public string INSS { get;set; }   // Att_A045.Att45_INSS

      [Required]
      [Column("Att45_AttestationID")]
      public string AttestationID { get;set; }   // Att_A045.Att45_AttestationID

      [Required]
      [Column("Att45_SituationNbr")]
      public decimal SituationNbr { get;set; }   // Att_A045.Att45_SituationNbr

      [Required]
      [Column("Att45_AttestationStatus")]
      public decimal AttestationStatus { get;set; }   // Att_A045.Att45_AttestationStatus

      [Required]
      [Column("Att45_CreationDate")]
      public DateTime CreationDate { get;set; }   // Att_A045.Att45_CreationDate

      [Required]
      [Column("Att45_Quarter")]
      public string Quarter { get;set; }   // Att_A045.Att45_Quarter

      [Required]
      [Column("Att45_NOSSRegistrationNbr")]
      public string NOSSRegistrationNbr { get;set; }   // Att_A045.Att45_NOSSRegistrationNbr

      [Required]
      [Column("Att45_CompanyID")]
      public string CompanyID { get;set; }   // Att_A045.Att45_CompanyID

      [Required]
      [Column("Att45_EmployerClass")]
      public string EmployerClass { get;set; }   // Att_A045.Att45_EmployerClass

      [Column("Snd45_Id")]
      public decimal Snd45Id_Key { get;set; }  // Att_A045.Snd45_Id (ForeignKey)

      [Column("Tra_Id")]
      public decimal TraId_Key { get;set; }  // Att_A045.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Snd45Id_Key")]
      public virtual Sending_A045 Sending_A045 { get; set; }

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("Att45Id_Key")]
      public virtual List<Att_A045_Disease> Att_A045_Disease { get; set; }

   }

   [Table("Pension_LettreDepart")]
   public partial class Pension_LettreDepart
   {

      [Key]
      [Column("Pld_Id")]
      public decimal ID { get;set; }  // Pension_LettreDepart.Pld_Id (PrimaryKey)

      [Required]
      [Column("Pld_DateReference")]
      public DateTime DateReference { get;set; }   // Pension_LettreDepart.Pld_DateReference

      [Required]
      [Column("Pld_ReserveAcquise")]
      public decimal ReserveAcquise { get;set; }   // Pension_LettreDepart.Pld_ReserveAcquise

      [Required]
      [Column("Pld_GarantieMinimale")]
      public decimal GarantieMinimale { get;set; }   // Pension_LettreDepart.Pld_GarantieMinimale

      [Required]
      [Column("Pld_EcheanceContrat")]
      public DateTime EcheanceContrat { get;set; }   // Pension_LettreDepart.Pld_EcheanceContrat

      [Required]
      [Column("Pld_CapitalAcquis")]
      public decimal CapitalAcquis { get;set; }   // Pension_LettreDepart.Pld_CapitalAcquis

      [Required]
      [Column("Pld_Etat")]
      public string Etat { get;set; }   // Pension_LettreDepart.Pld_Etat

      [Required]
      [Column("Pld_DateEtat")]
      public DateTime DateEtat { get;set; }   // Pension_LettreDepart.Pld_DateEtat

      [Required]
      [Column("Pld_Rue")]
      public string Rue { get;set; }   // Pension_LettreDepart.Pld_Rue

      [Required]
      [Column("Pld_No")]
      public string No { get;set; }   // Pension_LettreDepart.Pld_No

      [Required]
      [Column("Pld_Bte")]
      public string Bte { get;set; }   // Pension_LettreDepart.Pld_Bte

      [Required]
      [Column("Pld_CodePostal")]
      public string CodePostal { get;set; }   // Pension_LettreDepart.Pld_CodePostal

      [Required]
      [Column("Pld_Localite")]
      public string Localite { get;set; }   // Pension_LettreDepart.Pld_Localite

      [Required]
      [Column("Pld_CodePays")]
      public string CodePays { get;set; }   // Pension_LettreDepart.Pld_CodePays

      [Required]
      [Column("Pld_DateNaissance")]
      public DateTime DateNaissance { get;set; }   // Pension_LettreDepart.Pld_DateNaissance

      [Column("Pen_ID")]
      public decimal PenId_Key { get;set; }  // Pension_LettreDepart.Pen_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("PenId_Key")]
      public virtual Pension Pension { get; set; }

   }

   [Table("Dossier")]
   public partial class Dossier
   {

      [Key]
      [Column("Dos_Id")]
      public decimal ID { get;set; }  // Dossier.Dos_Id (PrimaryKey)

      [Required]
      [Column("Dos_TypeObjet")]
      public decimal TypeObjet { get;set; }   // Dossier.Dos_TypeObjet

      [Required]
      [Column("Dos_IdObjet")]
      public decimal IdObjet { get;set; }   // Dossier.Dos_IdObjet

      [Required]
      [Column("Dos_References")]
      public string References { get;set; }   // Dossier.Dos_References

      [Required]
      [Column("Dos_Etat")]
      public string Etat { get;set; }   // Dossier.Dos_Etat

      [Required]
      [Column("Dos_Texte")]
      public string Texte { get;set; }   // Dossier.Dos_Texte

      [Required]
      [Column("Dos_DateCreation")]
      public DateTime DateCreation { get;set; }   // Dossier.Dos_DateCreation

      [Required]
      [Column("Dos_Auteur")]
      public string Auteur { get;set; }   // Dossier.Dos_Auteur

      [Required]
      [Column("Dos_DateModification")]
      public DateTime DateModification { get;set; }   // Dossier.Dos_DateModification

   }

   [Table("Livre")]
   public partial class Livre
   {

      [Key]
      [Column("Liv_Id")]
      public decimal ID { get;set; }  // Livre.Liv_Id (PrimaryKey)

      [Required]
      [Column("Liv_Cloture")]
      public string Cloture { get;set; }   // Livre.Liv_Cloture

      [Required]
      [Column("Liv_DateCloture")]
      public DateTime DateCloture { get;set; }   // Livre.Liv_DateCloture

      [Required]
      [Column("Liv_Numero")]
      public string Numero { get;set; }   // Livre.Liv_Numero

      [Required]
      [Column("Liv_NombreTitres")]
      public decimal NombreTitres { get;set; }   // Livre.Liv_NombreTitres

      [Required]
      [Column("Liv_Salaires")]
      public decimal Salaires { get;set; }   // Livre.Liv_Salaires

      [Required]
      [Column("Liv_JoursPrestes")]
      public decimal JoursPrestes { get;set; }   // Livre.Liv_JoursPrestes

      [Required]
      [Column("Liv_JoursVacances")]
      public decimal JoursVacances { get;set; }   // Livre.Liv_JoursVacances

      [Required]
      [Column("Liv_JoursMaladie")]
      public decimal JoursMaladie { get;set; }   // Livre.Liv_JoursMaladie

      [Required]
      [Column("Liv_JoursMaternite")]
      public decimal JoursMaternite { get;set; }   // Livre.Liv_JoursMaternite

      [Required]
      [Column("Liv_JoursAssimimles")]
      public decimal JoursAssimimles { get;set; }   // Livre.Liv_JoursAssimimles

      [Required]
      [Column("Liv_NbrePrimesSyndicales")]
      public decimal NbrePrimesSyndicales { get;set; }   // Livre.Liv_NbrePrimesSyndicales

      [Required]
      [Column("Liv_TotalPrimesSyndicales")]
      public decimal TotalPrimesSyndicales { get;set; }   // Livre.Liv_TotalPrimesSyndicales

      [Required]
      [Column("Liv_NbrePrimesFormation")]
      public decimal NbrePrimesFormation { get;set; }   // Livre.Liv_NbrePrimesFormation

      [Required]
      [Column("Liv_TotalPrimesFormation")]
      public decimal TotalPrimesFormation { get;set; }   // Livre.Liv_TotalPrimesFormation

      [Required]
      [Column("Liv_TotalBrutPrimes")]
      public decimal TotalBrutPrimes { get;set; }   // Livre.Liv_TotalBrutPrimes

      [Required]
      [Column("Liv_RetenueONSS")]
      public decimal RetenueONSS { get;set; }   // Livre.Liv_RetenueONSS

      [Required]
      [Column("Liv_BaseImposable")]
      public decimal BaseImposable { get;set; }   // Livre.Liv_BaseImposable

      [Required]
      [Column("Liv_RetenueFiscale")]
      public decimal RetenueFiscale { get;set; }   // Livre.Liv_RetenueFiscale

      [Required]
      [Column("Liv_NetAvantFrais")]
      public decimal NetAvantFrais { get;set; }   // Livre.Liv_NetAvantFrais

      [Required]
      [Column("Liv_FraisAdministratifs")]
      public decimal FraisAdministratifs { get;set; }   // Livre.Liv_FraisAdministratifs

      [Required]
      [Column("Liv_Net")]
      public decimal Net { get;set; }   // Livre.Liv_Net

      // Reverse Navigation

      [InverseProperty("LivId_Key")]
      public virtual List<Decompte_Lot> Decompte_Lot { get; set; }

   }

   [Table("Historique")]
   public partial class Historique
   {

      [Required]
      [Column("Tbl_tag")]
      public decimal Tbl_tag { get;set; }   // Historique.Tbl_tag

      [Required]
      [Column("Col_tag")]
      public decimal Col_tag { get;set; }   // Historique.Col_tag

      [Required]
      [Column("His_DbRecId")]
      public decimal DbRecId { get;set; }   // Historique.His_DbRecId

      [Required]
      [Column("Col_PrvVal")]
      public string PrvVal { get;set; }   // Historique.Col_PrvVal

      [Required]
      [Column("Col_CurVal")]
      public string CurVal { get;set; }   // Historique.Col_CurVal

      [Required]
      [Column("His_Motivation")]
      public string Motivation { get;set; }   // Historique.His_Motivation

      [Required]
      [Column("Mod_Date")]
      public DateTime Date { get;set; }   // Historique.Mod_Date

      [Required]
      [Column("Usr_Login")]
      public string Login { get;set; }   // Historique.Usr_Login

   }

   [Table("Intervention")]
   public partial class Intervention
   {

      [Key]
      [Column("Int_Id")]
      public decimal ID { get;set; }  // Intervention.Int_Id (PrimaryKey)

      [Required]
      [Column("Int_FinPeriode")]
      public DateTime FinPeriode { get;set; }   // Intervention.Int_FinPeriode

      [Required]
      [Column("Int_DebutPeriode")]
      public DateTime DebutPeriode { get;set; }   // Intervention.Int_DebutPeriode

      [Required]
      [Column("Int_NombreJours")]
      public decimal NombreJours { get;set; }   // Intervention.Int_NombreJours

      [Required]
      [Column("Int_MontantJournalier")]
      public decimal MontantJournalier { get;set; }   // Intervention.Int_MontantJournalier

      [Required]
      [Column("Int_BaseImposable")]
      public decimal BaseImposable { get;set; }   // Intervention.Int_BaseImposable

      [Required]
      [Column("Int_RetenueFiscale")]
      public decimal RetenueFiscale { get;set; }   // Intervention.Int_RetenueFiscale

      [Required]
      [Column("Int_MontantNet")]
      public decimal MontantNet { get;set; }   // Intervention.Int_MontantNet

      [Required]
      [Column("Int_Etat")]
      public string Etat { get;set; }   // Intervention.Int_Etat

      [Required]
      [Column("Int_DateLiquidation")]
      public DateTime DateLiquidation { get;set; }   // Intervention.Int_DateLiquidation

      [Required]
      [Column("Int_Syndicat")]
      public string Syndicat { get;set; }   // Intervention.Int_Syndicat

      [Required]
      [Column("Int_FraisAdministratifs")]
      public decimal FraisAdministratifs { get;set; }   // Intervention.Int_FraisAdministratifs

      [Required]
      [Column("Int_MontantPayable")]
      public decimal MontantPayable { get;set; }   // Intervention.Int_MontantPayable

      [Required]
      [Column("Int_MontantBrut")]
      public decimal MontantBrut { get;set; }   // Intervention.Int_MontantBrut

      [Required]
      [Column("Int_RetenueOnss")]
      public decimal RetenueOnss { get;set; }   // Intervention.Int_RetenueOnss

      [Required]
      [Column("Int_NombreHeures")]
      public decimal NombreHeures { get;set; }   // Intervention.Int_NombreHeures

      [Required]
      [Column("Int_MontantHoraire")]
      public decimal MontantHoraire { get;set; }   // Intervention.Int_MontantHoraire

      [Required]
      [Column("Int_Automatique")]
      public string Automatique { get;set; }   // Intervention.Int_Automatique

      [Column("Dei_Id")]
      public decimal DeiId_Key { get;set; }  // Intervention.Dei_Id (ForeignKey)

      [Column("Dia_Id")]
      public decimal DiaId_Key { get;set; }  // Intervention.Dia_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DeiId_Key")]
      public virtual Demande_Intervention Demande_Intervention { get; set; }

      [ForeignKey("DiaId_Key")]
      public virtual Demande_Intervention_Automatique Demande_Intervention_Automatique { get; set; }

      // Reverse Navigation

      [InverseProperty("IntId_Key")]
      public virtual List<Payement> Payement { get; set; }

   }

   [Table("Ligne_Releve")]
   public partial class Ligne_Releve
   {

      [Key]
      [Column("Lre_ID")]
      public decimal ID { get;set; }  // Ligne_Releve.Lre_ID (PrimaryKey)

      [Required]
      [Column("Lre_Trimestre")]
      public string Trimestre { get;set; }   // Ligne_Releve.Lre_Trimestre

      [Required]
      [Column("Lre_NISS")]
      public string NISS { get;set; }   // Ligne_Releve.Lre_NISS

      [Required]
      [Column("Lre_ONSS")]
      public string ONSS { get;set; }   // Ligne_Releve.Lre_ONSS

      [Required]
      [Column("Lre_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Ligne_Releve.Lre_CategorieEmployeur

      [Required]
      [Column("Lre_CodeTravailleur")]
      public string CodeTravailleur { get;set; }   // Ligne_Releve.Lre_CodeTravailleur

      [Required]
      [Column("Lre_Active")]
      public string Active { get;set; }   // Ligne_Releve.Lre_Active

      [Required]
      [Column("Lre_Origine")]
      public string Origine { get;set; }   // Ligne_Releve.Lre_Origine

      [Required]
      [Column("Lre_DNRB")]
      public string DNRB { get;set; }   // Ligne_Releve.Lre_DNRB

      [Required]
      [Column("Lre_LSDNR")]
      public string LSDNR { get;set; }   // Ligne_Releve.Lre_LSDNR

      [Required]
      [Column("Lre_DateDebutTrimestre")]
      public DateTime DateDebutTrimestre { get;set; }   // Ligne_Releve.Lre_DateDebutTrimestre

      [Required]
      [Column("Lre_DateFinTrimestre")]
      public DateTime DateFinTrimestre { get;set; }   // Ligne_Releve.Lre_DateFinTrimestre

      [Required]
      [Column("Lre_DateCreation")]
      public DateTime DateCreation { get;set; }   // Ligne_Releve.Lre_DateCreation

      [Required]
      [Column("Lre_Source")]
      public string Source { get;set; }   // Ligne_Releve.Lre_Source

      [Required]
      [Column("Lre_NumeroAgent")]
      public string NumeroAgent { get;set; }   // Ligne_Releve.Lre_NumeroAgent

      [Required]
      [Column("Lre_TexteLibre")]
      public string TexteLibre { get;set; }   // Ligne_Releve.Lre_TexteLibre

      [Required]
      [Column("Lre_ExistenceAMI")]
      public string ExistenceAMI { get;set; }   // Ligne_Releve.Lre_ExistenceAMI

      [Required]
      [Column("Lre_ExistenceChomage")]
      public string ExistenceChomage { get;set; }   // Ligne_Releve.Lre_ExistenceChomage

      [Required]
      [Column("Lre_CodeArchive")]
      public string CodeArchive { get;set; }   // Ligne_Releve.Lre_CodeArchive

      [Required]
      [Column("Lre_ValidationCGER")]
      public string ValidationCGER { get;set; }   // Ligne_Releve.Lre_ValidationCGER

      [Required]
      [Column("Lre_DateInjection")]
      public DateTime DateInjection { get;set; }   // Ligne_Releve.Lre_DateInjection

      [Required]
      [Column("Lre_motivation")]
      public string Motivation { get;set; }   // Ligne_Releve.Lre_motivation

      [Column("Env_Id")]
      public decimal EnvId_Key { get;set; }  // Ligne_Releve.Env_Id (ForeignKey)

      [Column("Con_ID")]
      public decimal ConId_Key { get;set; }  // Ligne_Releve.Con_ID (ForeignKey)

      [Column("Pct_Id")]
      public decimal PctId_Key { get;set; }  // Ligne_Releve.Pct_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("EnvId_Key")]
      public virtual Envoi Envoi { get; set; }

      [ForeignKey("ConId_Key")]
      public virtual Contrat Contrat { get; set; }

      [ForeignKey("PctId_Key")]
      public virtual Prime_Contrat Prime_Contrat { get; set; }

      // Reverse Navigation

      [InverseProperty("LreId_Key")]
      public virtual List<Mouvement_Assimilation> Mouvement_Assimilation { get; set; }

      [InverseProperty("LreId_Key")]
      public virtual List<Mouvement_Remuneration> Mouvement_Remuneration { get; set; }

   }

   [Table("Localite")]
   public partial class Localite
   {

      [Key]
      [Column("Loc_CodePostal")]
      public string ID { get;set; }  // Localite.Loc_CodePostal (PrimaryKey)

      [Required]
      [Column("Loc_NlLocalite")]
      public string NlLocalite { get;set; }   // Localite.Loc_NlLocalite

      [Required]
      [Column("Loc_FrLocalite")]
      public string FrLocalite { get;set; }   // Localite.Loc_FrLocalite

      [Required]
      [Column("Loc_CodeLangue")]
      public string CodeLangue { get;set; }   // Localite.Loc_CodeLangue

      [Required]
      [Column("Loc_CodeRegion")]
      public string CodeRegion { get;set; }   // Localite.Loc_CodeRegion

      [Required]
      [Column("Loc_CentreTri")]
      public string CentreTri { get;set; }   // Localite.Loc_CentreTri

      [Required]
      [Column("Loc_CentreDistribution")]
      public string CentreDistribution { get;set; }   // Localite.Loc_CentreDistribution

      [Required]
      [Column("Loc_CodeProvince")]
      public string CodeProvince { get;set; }   // Localite.Loc_CodeProvince

      [Required]
      [Column("Loc_CodeArrondissement")]
      public string CodeArrondissement { get;set; }   // Localite.Loc_CodeArrondissement

   }

   [Table("Marque")]
   public partial class Marque
   {

      [Key]
      [Column("Mrq_Id")]
      public decimal ID { get;set; }  // Marque.Mrq_Id (PrimaryKey)

      [Required]
      [Column("Mrq_TypeObjet")]
      public decimal TypeObjet { get;set; }   // Marque.Mrq_TypeObjet

      [Required]
      [Column("Mrq_IdObjet")]
      public decimal IdObjet { get;set; }   // Marque.Mrq_IdObjet

      [Required]
      [Column("Mrq_Parent")]
      public decimal Parent { get;set; }   // Marque.Mrq_Parent

      [Required]
      [Column("Mrq_Type")]
      public string Type { get;set; }   // Marque.Mrq_Type

      [Required]
      [Column("Mrq_DateCreation")]
      public DateTime DateCreation { get;set; }   // Marque.Mrq_DateCreation

      [Required]
      [Column("Mrq_Motivation")]
      public string Motivation { get;set; }   // Marque.Mrq_Motivation

      [Required]
      [Column("Mrq_Apposeur")]
      public string Apposeur { get;set; }   // Marque.Mrq_Apposeur

      [Required]
      [Column("Mrq_Destinataire")]
      public string Destinataire { get;set; }   // Marque.Mrq_Destinataire

      [Required]
      [Column("Mrq_Etat")]
      public string Etat { get;set; }   // Marque.Mrq_Etat

      [Required]
      [Column("Mrq_Priorite")]
      public string Priorite { get;set; }   // Marque.Mrq_Priorite

      [Required]
      [Column("Mrq_DateDebutValidite")]
      public DateTime DateDebutValidite { get;set; }   // Marque.Mrq_DateDebutValidite

      [Required]
      [Column("Mrq_DateFinValidite")]
      public DateTime DateFinValidite { get;set; }   // Marque.Mrq_DateFinValidite

      [Required]
      [Column("Mrq_DatePlanifiee")]
      public DateTime DatePlanifiee { get;set; }   // Marque.Mrq_DatePlanifiee

      [Required]
      [Column("Mrq_DateExecution")]
      public DateTime DateExecution { get;set; }   // Marque.Mrq_DateExecution

      [Required]
      [Column("Mrq_TypeValeur1")]
      public string TypeValeur1 { get;set; }   // Marque.Mrq_TypeValeur1

      [Required]
      [Column("Mrq_Valeur1")]
      public string Valeur1 { get;set; }   // Marque.Mrq_Valeur1

      [Required]
      [Column("Mrq_TypeValeur2")]
      public string TypeValeur2 { get;set; }   // Marque.Mrq_TypeValeur2

      [Required]
      [Column("Mrq_Valeur2")]
      public string Valeur2 { get;set; }   // Marque.Mrq_Valeur2

      [Required]
      [Column("Mrq_TypeValeur3")]
      public string TypeValeur3 { get;set; }   // Marque.Mrq_TypeValeur3

      [Required]
      [Column("Mrq_Valeur3")]
      public string Valeur3 { get;set; }   // Marque.Mrq_Valeur3

      [Required]
      [Column("Mrq_Niss")]
      public string Niss { get;set; }   // Marque.Mrq_Niss

      [Required]
      [Column("Mrq_Onss")]
      public string Onss { get;set; }   // Marque.Mrq_Onss

   }

   [Table("Travailleur")]
   public partial class Travailleur
   {

      [Key]
      [Column("Tra_ID")]
      public decimal ID { get;set; }  // Travailleur.Tra_ID (PrimaryKey)

      [Required]
      [Column("Tra_NISS")]
      public string NISS { get;set; }   // Travailleur.Tra_NISS

      [Required]
      [Column("Tra_Nom")]
      public string Nom { get;set; }   // Travailleur.Tra_Nom

      [Required]
      [Column("Tra_Prenom")]
      public string Prenom { get;set; }   // Travailleur.Tra_Prenom

      [Required]
      [Column("Tra_Sexe")]
      public string Sexe { get;set; }   // Travailleur.Tra_Sexe

      [Required]
      [Column("Tra_Langue")]
      public string Langue { get;set; }   // Travailleur.Tra_Langue

      [Required]
      [Column("Tra_DateNaissance")]
      public DateTime DateNaissance { get;set; }   // Travailleur.Tra_DateNaissance

      [Required]
      [Column("Tra_DateDeces")]
      public DateTime DateDeces { get;set; }   // Travailleur.Tra_DateDeces

      [Required]
      [Column("Tra_ModePayement")]
      public string ModePayement { get;set; }   // Travailleur.Tra_ModePayement

      [Required]
      [Column("Tra_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Travailleur.Tra_CompteBancaire

      [Required]
      [Column("Tra_AdresseRue")]
      public string AdresseRue { get;set; }   // Travailleur.Tra_AdresseRue

      [Required]
      [Column("Tra_AdresseNo")]
      public string AdresseNo { get;set; }   // Travailleur.Tra_AdresseNo

      [Required]
      [Column("Tra_AdresseBte")]
      public string AdresseBte { get;set; }   // Travailleur.Tra_AdresseBte

      [Required]
      [Column("Tra_CodePostal")]
      public string CodePostal { get;set; }   // Travailleur.Tra_CodePostal

      [Required]
      [Column("Tra_Localite")]
      public string Localite { get;set; }   // Travailleur.Tra_Localite

      [Required]
      [Column("Tra_CodePays")]
      public string CodePays { get;set; }   // Travailleur.Tra_CodePays

      [Required]
      [Column("Tra_Telephone")]
      public string Telephone { get;set; }   // Travailleur.Tra_Telephone

      [Required]
      [Column("Tra_OrigineAdresse")]
      public string OrigineAdresse { get;set; }   // Travailleur.Tra_OrigineAdresse

      [Required]
      [Column("Tra_DateModifAdresse")]
      public DateTime DateModifAdresse { get;set; }   // Travailleur.Tra_DateModifAdresse

      [Required]
      [Column("Tra_AdresseRueDerog")]
      public string AdresseRueDerog { get;set; }   // Travailleur.Tra_AdresseRueDerog

      [Required]
      [Column("Tra_AdresseNoDerog")]
      public string AdresseNoDerog { get;set; }   // Travailleur.Tra_AdresseNoDerog

      [Required]
      [Column("Tra_AdresseBteDerog")]
      public string AdresseBteDerog { get;set; }   // Travailleur.Tra_AdresseBteDerog

      [Required]
      [Column("Tra_CodePostalDerog")]
      public string CodePostalDerog { get;set; }   // Travailleur.Tra_CodePostalDerog

      [Required]
      [Column("Tra_LocaliteDerog")]
      public string LocaliteDerog { get;set; }   // Travailleur.Tra_LocaliteDerog

      [Required]
      [Column("Tra_CodePaysDerog")]
      public string CodePaysDerog { get;set; }   // Travailleur.Tra_CodePaysDerog

      [Required]
      [Column("Tra_TelephoneDerog")]
      public string TelephoneDerog { get;set; }   // Travailleur.Tra_TelephoneDerog

      [Required]
      [Column("Tra_OrigineDerog")]
      public string OrigineDerog { get;set; }   // Travailleur.Tra_OrigineDerog

      [Required]
      [Column("Tra_DateDebutDerog")]
      public DateTime DateDebutDerog { get;set; }   // Travailleur.Tra_DateDebutDerog

      [Required]
      [Column("Tra_DateFinDerog")]
      public DateTime DateFinDerog { get;set; }   // Travailleur.Tra_DateFinDerog

      [Required]
      [Column("Tra_DateModifDerog")]
      public DateTime DateModifDerog { get;set; }   // Travailleur.Tra_DateModifDerog

      [Required]
      [Column("Tra_CalculManuelRetenue")]
      public string CalculManuelRetenue { get;set; }   // Travailleur.Tra_CalculManuelRetenue

      [Required]
      [Column("Tra_CalculManuelRangCreance")]
      public string CalculManuelRangCreance { get;set; }   // Travailleur.Tra_CalculManuelRangCreance

      [Required]
      [Column("Tra_NbreEnfants")]
      public decimal NbreEnfants { get;set; }   // Travailleur.Tra_NbreEnfants

      [Required]
      [Column("Tra_NbreHandicapes")]
      public decimal NbreHandicapes { get;set; }   // Travailleur.Tra_NbreHandicapes

      [Required]
      [Column("Tra_AutresACharge")]
      public decimal AutresACharge { get;set; }   // Travailleur.Tra_AutresACharge

      [Required]
      [Column("Tra_ConjointACharge")]
      public string ConjointACharge { get;set; }   // Travailleur.Tra_ConjointACharge

      [Required]
      [Column("Tra_RevenusConjoint")]
      public decimal RevenusConjoint { get;set; }   // Travailleur.Tra_RevenusConjoint

      [Required]
      [Column("Tra_TypeRevenusConjoint")]
      public string TypeRevenusConjoint { get;set; }   // Travailleur.Tra_TypeRevenusConjoint

      [Required]
      [Column("Tra_VeufCelibataire")]
      public string VeufCelibataire { get;set; }   // Travailleur.Tra_VeufCelibataire

      [Required]
      [Column("Tra_AdresseIncomplete")]
      public string AdresseIncomplete { get;set; }   // Travailleur.Tra_AdresseIncomplete

      [Required]
      [Column("Tra_Commentaire")]
      public string Commentaire { get;set; }   // Travailleur.Tra_Commentaire

      [Required]
      [Column("Tra_NissFusion")]
      public string NissFusion { get;set; }   // Travailleur.Tra_NissFusion

      [Required]
      [Column("Tra_Oriolus")]
      public string Oriolus { get;set; }   // Travailleur.Tra_Oriolus

      [Required]
      [Column("Tra_Nationalite")]
      public string Nationalite { get;set; }   // Travailleur.Tra_Nationalite

      [Required]
      [Column("Tra_IBAN")]
      public string IBAN { get;set; }   // Travailleur.Tra_IBAN

      [Required]
      [Column("Tra_BIC")]
      public string BIC { get;set; }   // Travailleur.Tra_BIC

      [Required]
      [Column("Tra_LangueDerog")]
      public string LangueDerog { get;set; }   // Travailleur.Tra_LangueDerog

      [Required]
      [Column("Tra_EtatCivil")]
      public string EtatCivil { get;set; }   // Travailleur.Tra_EtatCivil

      [Required]
      [Column("Tra_DatePension")]
      public DateTime DatePension { get;set; }   // Travailleur.Tra_DatePension

      [Required]
      [Column("Tra_DateFinDroitPension")]
      public DateTime DateFinDroitPension { get;set; }   // Travailleur.Tra_DateFinDroitPension

      [Required]
      [Column("Tra_DateNationalite")]
      public DateTime DateNationalite { get;set; }   // Travailleur.Tra_DateNationalite

      [Required]
      [Column("Tra_PartnerNiss")]
      public string PartnerNiss { get;set; }   // Travailleur.Tra_PartnerNiss

      [Required]
      [Column("Tra_PartnerNom")]
      public string PartnerNom { get;set; }   // Travailleur.Tra_PartnerNom

      [Required]
      [Column("Tra_PartnerPrenom")]
      public string PartnerPrenom { get;set; }   // Travailleur.Tra_PartnerPrenom

      [Required]
      [Column("Tra_CompositionMenage")]
      public string CompositionMenage { get;set; }   // Travailleur.Tra_CompositionMenage

      [Required]
      [Column("Tra_DateInjection")]
      public DateTime DateInjection { get;set; }   // Travailleur.Tra_DateInjection

      [Required]
      [Column("Tra_RaisonRadiation")]
      public string RaisonRadiation { get;set; }   // Travailleur.Tra_RaisonRadiation

      [Column("Tra_Ter_Id")]
      public decimal TraTerId_Key { get;set; }  // Travailleur.Tra_Ter_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraTerId_Key")]
      public virtual Travailleur Travailleur_TraTerId_Key { get; set; }

      // Reverse Navigation

      [InverseProperty("TraId_Key")]
      public virtual List<Dossier_Prepension> Dossier_Prepension { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Att_A038> Att_A038 { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Pension> Pension { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Att_A052> Att_A052 { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Prime_Travailleur> Prime_Travailleur { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Contrat> Contrat { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Att_A045> Att_A045 { get; set; }

      [InverseProperty("TraTerId_Key")]
      public virtual List<Travailleur> Travailleur_1 { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Dossier_Intervention> Dossier_Intervention { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Drs_A037_DossierAnnuel> Drs_A037_DossierAnnuel { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Beneficiaire> Beneficiaire { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Drs_A037> Drs_A037 { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Drs_A044_Dossier> Drs_A044_Dossier { get; set; }

      [InverseProperty("TraId_Key")]
      public virtual List<Creance> Creance { get; set; }

   }

   [Table("Mouvement_Assimilation")]
   public partial class Mouvement_Assimilation
   {

      [Key]
      [Column("Mas_ID")]
      public decimal ID { get;set; }  // Mouvement_Assimilation.Mas_ID (PrimaryKey)

      [Required]
      [Column("Mas_Trimestre")]
      public string Trimestre { get;set; }   // Mouvement_Assimilation.Mas_Trimestre

      [Required]
      [Column("Mas_DNRB")]
      public string DNRB { get;set; }   // Mouvement_Assimilation.Mas_DNRB

      [Required]
      [Column("Mas_LSDNR")]
      public string LSDNR { get;set; }   // Mouvement_Assimilation.Mas_LSDNR

      [Required]
      [Column("Mas_Periode")]
      public decimal Periode { get;set; }   // Mouvement_Assimilation.Mas_Periode

      [Required]
      [Column("Mas_Nature")]
      public string Nature { get;set; }   // Mouvement_Assimilation.Mas_Nature

      [Required]
      [Column("Mas_Regime")]
      public string Regime { get;set; }   // Mouvement_Assimilation.Mas_Regime

      [Required]
      [Column("Mas_JoursDeclares")]
      public decimal JoursDeclares { get;set; }   // Mouvement_Assimilation.Mas_JoursDeclares

      [Required]
      [Column("Mas_DateDebutPeriode")]
      public DateTime DateDebutPeriode { get;set; }   // Mouvement_Assimilation.Mas_DateDebutPeriode

      [Required]
      [Column("Mas_DateFinPeriode")]
      public DateTime DateFinPeriode { get;set; }   // Mouvement_Assimilation.Mas_DateFinPeriode

      [Required]
      [Column("Mas_TexteLibre")]
      public string TexteLibre { get;set; }   // Mouvement_Assimilation.Mas_TexteLibre

      [Required]
      [Column("Mas_JoursAttribues")]
      public decimal JoursAttribues { get;set; }   // Mouvement_Assimilation.Mas_JoursAttribues

      [Required]
      [Column("Mas_Motivation")]
      public string Motivation { get;set; }   // Mouvement_Assimilation.Mas_Motivation

      [Required]
      [Column("Mas_Gestionnaire")]
      public string Gestionnaire { get;set; }   // Mouvement_Assimilation.Mas_Gestionnaire

      [Required]
      [Column("Mas_DateAttribution")]
      public DateTime DateAttribution { get;set; }   // Mouvement_Assimilation.Mas_DateAttribution

      [Required]
      [Column("Mas_Etat")]
      public string Etat { get;set; }   // Mouvement_Assimilation.Mas_Etat

      [Required]
      [Column("Mas_ModeTraitement")]
      public string ModeTraitement { get;set; }   // Mouvement_Assimilation.Mas_ModeTraitement

      [Required]
      [Column("Mas_ModeAttribution")]
      public string ModeAttribution { get;set; }   // Mouvement_Assimilation.Mas_ModeAttribution

      [Column("Lre_Id")]
      public decimal LreId_Key { get;set; }  // Mouvement_Assimilation.Lre_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("LreId_Key")]
      public virtual Ligne_Releve Ligne_Releve { get; set; }

   }

   [Table("Att_A045_Disease")]
   public partial class Att_A045_Disease
   {

      [Key]
      [Column("Dis45_Id")]
      public decimal ID { get;set; }  // Att_A045_Disease.Dis45_Id (PrimaryKey)

      [Required]
      [Column("Dis45_KindOfRequest")]
      public string KindOfRequest { get;set; }   // Att_A045_Disease.Dis45_KindOfRequest

      [Required]
      [Column("Dis45_CategoryOfRequest")]
      public string CategoryOfRequest { get;set; }   // Att_A045_Disease.Dis45_CategoryOfRequest

      [Required]
      [Column("Dis45_NotificationDate")]
      public DateTime NotificationDate { get;set; }   // Att_A045_Disease.Dis45_NotificationDate

      [Required]
      [Column("Dis45_ContestationDate")]
      public DateTime ContestationDate { get;set; }   // Att_A045_Disease.Dis45_ContestationDate

      [Column("Att45_Id")]
      public decimal Att45Id_Key { get;set; }  // Att_A045_Disease.Att45_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Att45Id_Key")]
      public virtual Att_A045 Att_A045 { get; set; }

      // Reverse Navigation

      [InverseProperty("Dis45Id_Key")]
      public virtual List<Att_A045_DecisionFbzFmp> Att_A045_DecisionFbzFmp { get; set; }

   }

   [Table("Mouvement_Remuneration")]
   public partial class Mouvement_Remuneration
   {

      [Key]
      [Column("Mre_Id")]
      public decimal ID { get;set; }  // Mouvement_Remuneration.Mre_Id (PrimaryKey)

      [Required]
      [Column("Mre_Trimestre")]
      public string Trimestre { get;set; }   // Mouvement_Remuneration.Mre_Trimestre

      [Required]
      [Column("Mre_DNRB")]
      public string DNRB { get;set; }   // Mouvement_Remuneration.Mre_DNRB

      [Required]
      [Column("Mre_LSDNR")]
      public string LSDNR { get;set; }   // Mouvement_Remuneration.Mre_LSDNR

      [Required]
      [Column("Mre_Periode")]
      public decimal Periode { get;set; }   // Mouvement_Remuneration.Mre_Periode

      [Required]
      [Column("Mre_Nature")]
      public string Nature { get;set; }   // Mouvement_Remuneration.Mre_Nature

      [Required]
      [Column("Mre_Regime")]
      public string Regime { get;set; }   // Mouvement_Remuneration.Mre_Regime

      [Required]
      [Column("Mre_JoursRemuneres")]
      public decimal JoursRemuneres { get;set; }   // Mouvement_Remuneration.Mre_JoursRemuneres

      [Required]
      [Column("Mre_HeuresRemunerees")]
      public decimal HeuresRemunerees { get;set; }   // Mouvement_Remuneration.Mre_HeuresRemunerees

      [Required]
      [Column("Mre_HeuresSemTravRef")]
      public decimal HeuresSemTravRef { get;set; }   // Mouvement_Remuneration.Mre_HeuresSemTravRef

      [Required]
      [Column("Mre_JoursVacances")]
      public decimal JoursVacances { get;set; }   // Mouvement_Remuneration.Mre_JoursVacances

      [Required]
      [Column("Mre_SalaireBrut")]
      public decimal SalaireBrut { get;set; }   // Mouvement_Remuneration.Mre_SalaireBrut

      [Required]
      [Column("Mre_DateDebutPeriode")]
      public DateTime DateDebutPeriode { get;set; }   // Mouvement_Remuneration.Mre_DateDebutPeriode

      [Required]
      [Column("Mre_DateFinPeriode")]
      public DateTime DateFinPeriode { get;set; }   // Mouvement_Remuneration.Mre_DateFinPeriode

      [Required]
      [Column("Mre_TexteLibre")]
      public string TexteLibre { get;set; }   // Mouvement_Remuneration.Mre_TexteLibre

      [Column("Lre_Id")]
      public decimal LreId_Key { get;set; }  // Mouvement_Remuneration.Lre_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("LreId_Key")]
      public virtual Ligne_Releve Ligne_Releve { get; set; }

   }

   [Table("Payement_Compteur")]
   public partial class Payement_Compteur
   {

      [Key]
      [Column("Pac_Id")]
      public decimal ID { get;set; }  // Payement_Compteur.Pac_Id (PrimaryKey)

      [Required]
      [Column("Pac_Exercice")]
      public decimal Exercice { get;set; }   // Payement_Compteur.Pac_Exercice

      [Required]
      [Column("Pac_Prefixe")]
      public string Prefixe { get;set; }   // Payement_Compteur.Pac_Prefixe

      [Required]
      [Column("Pac_Numero")]
      public decimal Numero { get;set; }   // Payement_Compteur.Pac_Numero

   }

   [Table("Att_A045_DecisionFbzFmp")]
   public partial class Att_A045_DecisionFbzFmp
   {

      [Key]
      [Column("Dcn45_Id")]
      public decimal ID { get;set; }  // Att_A045_DecisionFbzFmp.Dcn45_Id (PrimaryKey)

      [Required]
      [Column("Dcn45_DecisionCode")]
      public string DecisionCode { get;set; }   // Att_A045_DecisionFbzFmp.Dcn45_DecisionCode

      [Required]
      [Column("Dcn45_DisablementBeginDate")]
      public DateTime DisablementBeginDate { get;set; }   // Att_A045_DecisionFbzFmp.Dcn45_DisablementBeginDate

      [Required]
      [Column("Dcn45_AllowanceAmount")]
      public decimal AllowanceAmount { get;set; }   // Att_A045_DecisionFbzFmp.Dcn45_AllowanceAmount

      [Column("Dis45_Id")]
      public decimal Dis45Id_Key { get;set; }  // Att_A045_DecisionFbzFmp.Dis45_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Dis45Id_Key")]
      public virtual Att_A045_Disease Att_A045_Disease { get; set; }

      // Reverse Navigation

      [InverseProperty("Dcn45Id_Key")]
      public virtual List<Att_A045_DecisionDetail> Att_A045_DecisionDetail { get; set; }

   }

   [Table("Employeur")]
   public partial class Employeur
   {

      [Key]
      [Column("Emp_ID")]
      public decimal ID { get;set; }  // Employeur.Emp_ID (PrimaryKey)

      [Required]
      [Column("Emp_ONSS")]
      public string ONSS { get;set; }   // Employeur.Emp_ONSS

      [Required]
      [Column("Emp_NUE")]
      public string NUE { get;set; }   // Employeur.Emp_NUE

      [Required]
      [Column("Emp_Nom")]
      public string Nom { get;set; }   // Employeur.Emp_Nom

      [Required]
      [Column("Emp_Langue")]
      public string Langue { get;set; }   // Employeur.Emp_Langue

      [Required]
      [Column("Emp_LangueDerog")]
      public string LangueDerog { get;set; }   // Employeur.Emp_LangueDerog

      [Required]
      [Column("Emp_AdresseRue")]
      public string AdresseRue { get;set; }   // Employeur.Emp_AdresseRue

      [Required]
      [Column("Emp_AdresseNo")]
      public string AdresseNo { get;set; }   // Employeur.Emp_AdresseNo

      [Required]
      [Column("Emp_AdresseBte")]
      public string AdresseBte { get;set; }   // Employeur.Emp_AdresseBte

      [Required]
      [Column("Emp_CodePostal")]
      public string CodePostal { get;set; }   // Employeur.Emp_CodePostal

      [Required]
      [Column("Emp_Localite")]
      public string Localite { get;set; }   // Employeur.Emp_Localite

      [Required]
      [Column("Emp_CodePays")]
      public string CodePays { get;set; }   // Employeur.Emp_CodePays

      [Required]
      [Column("Emp_CodeLocalite")]
      public string CodeLocalite { get;set; }   // Employeur.Emp_CodeLocalite

      [Required]
      [Column("Emp_DateModificationAdresse")]
      public DateTime DateModificationAdresse { get;set; }   // Employeur.Emp_DateModificationAdresse

      [Required]
      [Column("Emp_IBAN")]
      public string IBAN { get;set; }   // Employeur.Emp_IBAN

      [Required]
      [Column("Emp_BIC")]
      public string BIC { get;set; }   // Employeur.Emp_BIC

      [Required]
      [Column("Emp_Telephone")]
      public string Telephone { get;set; }   // Employeur.Emp_Telephone

      [Required]
      [Column("Emp_Fax")]
      public string Fax { get;set; }   // Employeur.Emp_Fax

      [Required]
      [Column("Emp_NomContact")]
      public string NomContact { get;set; }   // Employeur.Emp_NomContact

      [Required]
      [Column("Emp_DateMatricule")]
      public DateTime DateMatricule { get;set; }   // Employeur.Emp_DateMatricule

      [Required]
      [Column("Emp_DateFaillite")]
      public DateTime DateFaillite { get;set; }   // Employeur.Emp_DateFaillite

      [Required]
      [Column("Emp_DateRadiation")]
      public DateTime DateRadiation { get;set; }   // Employeur.Emp_DateRadiation

      [Required]
      [Column("Emp_Curatelle")]
      public string Curatelle { get;set; }   // Employeur.Emp_Curatelle

      [Required]
      [Column("Emp_AffiliationSSoc")]
      public string AffiliationSSoc { get;set; }   // Employeur.Emp_AffiliationSSoc

      [Required]
      [Column("Emp_SecSocialActuel")]
      public string SecSocialActuel { get;set; }   // Employeur.Emp_SecSocialActuel

      [Required]
      [Column("Emp_SecSocialPrecedent")]
      public string SecSocialPrecedent { get;set; }   // Employeur.Emp_SecSocialPrecedent

      [Required]
      [Column("Emp_SecSocialTrimestre")]
      public string SecSocialTrimestre { get;set; }   // Employeur.Emp_SecSocialTrimestre

      [Required]
      [Column("Emp_FormeJuridique")]
      public string FormeJuridique { get;set; }   // Employeur.Emp_FormeJuridique

      [Required]
      [Column("Emp_DateModification")]
      public DateTime DateModification { get;set; }   // Employeur.Emp_DateModification

      [Required]
      [Column("Emp_DateInjection")]
      public DateTime DateInjection { get;set; }   // Employeur.Emp_DateInjection

      [Required]
      [Column("Emp_NoUGBN")]
      public string NoUGBN { get;set; }   // Employeur.Emp_NoUGBN

      // Reverse Navigation

      [InverseProperty("EmpId_Key")]
      public virtual List<Mutation_ONSS> Mutation_ONSS { get; set; }

      [InverseProperty("EmpId_Key")]
      public virtual List<Activite_Employeur> Activite_Employeur { get; set; }

      [InverseProperty("EmpId_Key")]
      public virtual List<Siege_Exploitation> Siege_Exploitation { get; set; }

   }

   [Table("Query")]
   public partial class Query
   {

      [Key]
      [Column("Qry_Id")]
      public decimal ID { get;set; }  // Query.Qry_Id (PrimaryKey)

      [Required]
      [Column("Qry_Groupe")]
      public string Groupe { get;set; }   // Query.Qry_Groupe

      [Required]
      [Column("Qry_TagApplication")]
      public decimal TagApplication { get;set; }   // Query.Qry_TagApplication

      [Required]
      [Column("Qry_TagDialogue")]
      public decimal TagDialogue { get;set; }   // Query.Qry_TagDialogue

      [Required]
      [Column("Qry_Type")]
      public string Type { get;set; }   // Query.Qry_Type

      [Required]
      [Column("Qry_Document")]
      public string Document { get;set; }   // Query.Qry_Document

      [Required]
      [Column("Qry_Key")]
      public string Key { get;set; }   // Query.Qry_Key

      [Required]
      [Column("Qry_State")]
      public string State { get;set; }   // Query.Qry_State

      [Required]
      [Column("Qry_Utilisateur")]
      public string Utilisateur { get;set; }   // Query.Qry_Utilisateur

      [Required]
      [Column("Qry_NlKey")]
      public string NlKey { get;set; }   // Query.Qry_NlKey

      [Required]
      [Column("Qry_FrKey")]
      public string FrKey { get;set; }   // Query.Qry_FrKey

      [Required]
      [Column("Qry_NlHeader")]
      public string NlHeader { get;set; }   // Query.Qry_NlHeader

      [Required]
      [Column("Qry_FrHeader")]
      public string FrHeader { get;set; }   // Query.Qry_FrHeader

   }

   [Table("Retenue_Creance")]
   public partial class Retenue_Creance
   {

      [Key]
      [Column("Rcr_Id")]
      public decimal ID { get;set; }  // Retenue_Creance.Rcr_Id (PrimaryKey)

      [Required]
      [Column("Rcr_MontantRetenue")]
      public decimal MontantRetenue { get;set; }   // Retenue_Creance.Rcr_MontantRetenue

      [Required]
      [Column("Rcr_SoldeAPayer")]
      public decimal SoldeAPayer { get;set; }   // Retenue_Creance.Rcr_SoldeAPayer

      [Required]
      [Column("Rcr_DateCalcul")]
      public DateTime DateCalcul { get;set; }   // Retenue_Creance.Rcr_DateCalcul

      [Required]
      [Column("Rcr_TotalPayements")]
      public decimal TotalPayements { get;set; }   // Retenue_Creance.Rcr_TotalPayements

      [Required]
      [Column("Rcr_APayer")]
      public string APayer { get;set; }   // Retenue_Creance.Rcr_APayer

      [Required]
      [Column("Rcr_NomCreancier")]
      public string NomCreancier { get;set; }   // Retenue_Creance.Rcr_NomCreancier

      [Column("Cre_ID")]
      public decimal CreId_Key { get;set; }  // Retenue_Creance.Cre_ID (ForeignKey)

      [Column("Ptr_Id")]
      public decimal PtrId_Key { get;set; }  // Retenue_Creance.Ptr_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("CreId_Key")]
      public virtual Creance Creance { get; set; }

      [ForeignKey("PtrId_Key")]
      public virtual Prime_Travailleur Prime_Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("RcrId_Key")]
      public virtual List<Payement> Payement { get; set; }

   }

   [Table("Siege_Exploitation")]
   public partial class Siege_Exploitation
   {

      [Key]
      [Column("Sie_ID")]
      public decimal ID { get;set; }  // Siege_Exploitation.Sie_ID (PrimaryKey)

      [Required]
      [Column("Sie_Numero")]
      public decimal Numero { get;set; }   // Siege_Exploitation.Sie_Numero

      [Required]
      [Column("Sie_NomSiege")]
      public string NomSiege { get;set; }   // Siege_Exploitation.Sie_NomSiege

      [Required]
      [Column("Sie_NomContact")]
      public string NomContact { get;set; }   // Siege_Exploitation.Sie_NomContact

      [Required]
      [Column("Sie_AdresseRue")]
      public string AdresseRue { get;set; }   // Siege_Exploitation.Sie_AdresseRue

      [Required]
      [Column("Sie_AdresseNo")]
      public string AdresseNo { get;set; }   // Siege_Exploitation.Sie_AdresseNo

      [Required]
      [Column("Sie_AdresseBte")]
      public string AdresseBte { get;set; }   // Siege_Exploitation.Sie_AdresseBte

      [Required]
      [Column("Sie_CodePostal")]
      public string CodePostal { get;set; }   // Siege_Exploitation.Sie_CodePostal

      [Required]
      [Column("Sie_Localite")]
      public string Localite { get;set; }   // Siege_Exploitation.Sie_Localite

      [Required]
      [Column("Sie_Pays")]
      public string Pays { get;set; }   // Siege_Exploitation.Sie_Pays

      [Required]
      [Column("Sie_Telephone")]
      public string Telephone { get;set; }   // Siege_Exploitation.Sie_Telephone

      [Required]
      [Column("Sie_Fax")]
      public string Fax { get;set; }   // Siege_Exploitation.Sie_Fax

      [Required]
      [Column("Sie_DateLiquidation")]
      public DateTime DateLiquidation { get;set; }   // Siege_Exploitation.Sie_DateLiquidation

      [Required]
      [Column("Sie_NumeroMatriculeDebut")]
      public string NumeroMatriculeDebut { get;set; }   // Siege_Exploitation.Sie_NumeroMatriculeDebut

      [Required]
      [Column("Sie_NumeroMatriculeFin")]
      public string NumeroMatriculeFin { get;set; }   // Siege_Exploitation.Sie_NumeroMatriculeFin

      [Required]
      [Column("Sie_NomSecretariatSoc")]
      public string NomSecretariatSoc { get;set; }   // Siege_Exploitation.Sie_NomSecretariatSoc

      [Required]
      [Column("Sie_IBAN")]
      public string IBAN { get;set; }   // Siege_Exploitation.Sie_IBAN

      [Required]
      [Column("Sie_BIC")]
      public string BIC { get;set; }   // Siege_Exploitation.Sie_BIC

      [Column("Emp_ID")]
      public decimal EmpId_Key { get;set; }  // Siege_Exploitation.Emp_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("EmpId_Key")]
      public virtual Employeur Employeur { get; set; }

   }

   [Table("Dossier_Intervention")]
   public partial class Dossier_Intervention
   {

      [Key]
      [Column("Din_Id")]
      public decimal ID { get;set; }  // Dossier_Intervention.Din_Id (PrimaryKey)

      [Required]
      [Column("Din_TypeIntervention")]
      public string TypeIntervention { get;set; }   // Dossier_Intervention.Din_TypeIntervention

      [Required]
      [Column("Din_Syndicat")]
      public string Syndicat { get;set; }   // Dossier_Intervention.Din_Syndicat

      [Required]
      [Column("Din_ExistencePFA")]
      public string ExistencePFA { get;set; }   // Dossier_Intervention.Din_ExistencePFA

      [Required]
      [Column("Din_EtatDossier")]
      public string EtatDossier { get;set; }   // Dossier_Intervention.Din_EtatDossier

      [Required]
      [Column("Din_MontantJournalier")]
      public decimal MontantJournalier { get;set; }   // Dossier_Intervention.Din_MontantJournalier

      [Required]
      [Column("Din_CreditJours")]
      public decimal CreditJours { get;set; }   // Dossier_Intervention.Din_CreditJours

      [Required]
      [Column("Din_HeuresSemaine")]
      public decimal HeuresSemaine { get;set; }   // Dossier_Intervention.Din_HeuresSemaine

      [Required]
      [Column("Din_TauxHoraire")]
      public decimal TauxHoraire { get;set; }   // Dossier_Intervention.Din_TauxHoraire

      [Required]
      [Column("Din_SalaireBrut")]
      public decimal SalaireBrut { get;set; }   // Dossier_Intervention.Din_SalaireBrut

      [Required]
      [Column("Din_RetenueONSS")]
      public decimal RetenueONSS { get;set; }   // Dossier_Intervention.Din_RetenueONSS

      [Required]
      [Column("Din_BaseImposable")]
      public decimal BaseImposable { get;set; }   // Dossier_Intervention.Din_BaseImposable

      [Required]
      [Column("Din_RetenueFiscale")]
      public decimal RetenueFiscale { get;set; }   // Dossier_Intervention.Din_RetenueFiscale

      [Required]
      [Column("Din_SalaireNet")]
      public decimal SalaireNet { get;set; }   // Dossier_Intervention.Din_SalaireNet

      [Required]
      [Column("Din_Anciennete")]
      public string Anciennete { get;set; }   // Dossier_Intervention.Din_Anciennete

      [Required]
      [Column("Din_DateAffiliation")]
      public DateTime DateAffiliation { get;set; }   // Dossier_Intervention.Din_DateAffiliation

      [Required]
      [Column("Din_DatePerteRevenus")]
      public DateTime DatePerteRevenus { get;set; }   // Dossier_Intervention.Din_DatePerteRevenus

      [Required]
      [Column("Din_AllocJournChomage")]
      public decimal AllocJournChomage { get;set; }   // Dossier_Intervention.Din_AllocJournChomage

      [Required]
      [Column("Din_NbreAllocChomage")]
      public decimal NbreAllocChomage { get;set; }   // Dossier_Intervention.Din_NbreAllocChomage

      [Required]
      [Column("Din_TotalAllocChomage")]
      public decimal TotalAllocChomage { get;set; }   // Dossier_Intervention.Din_TotalAllocChomage

      [Required]
      [Column("Din_SalaireReference")]
      public decimal SalaireReference { get;set; }   // Dossier_Intervention.Din_SalaireReference

      [Required]
      [Column("Din_Commentaire")]
      public string Commentaire { get;set; }   // Dossier_Intervention.Din_Commentaire

      [Required]
      [Column("Din_Frontalier")]
      public string Frontalier { get;set; }   // Dossier_Intervention.Din_Frontalier

      [Required]
      [Column("Din_DateDossier")]
      public DateTime DateDossier { get;set; }   // Dossier_Intervention.Din_DateDossier

      [Required]
      [Column("Din_Exercice")]
      public string Exercice { get;set; }   // Dossier_Intervention.Din_Exercice

      [Required]
      [Column("Din_TrimestreDebutChomage")]
      public string TrimestreDebutChomage { get;set; }   // Dossier_Intervention.Din_TrimestreDebutChomage

      [Required]
      [Column("Din_CreditHeure")]
      public decimal CreditHeure { get;set; }   // Dossier_Intervention.Din_CreditHeure

      [Required]
      [Column("Din_MontantHoraire")]
      public decimal MontantHoraire { get;set; }   // Dossier_Intervention.Din_MontantHoraire

      [Column("Con_ID")]
      public decimal ConId_Key { get;set; }  // Dossier_Intervention.Con_ID (ForeignKey)

      [Column("Tra_ID")]
      public decimal TraId_Key { get;set; }  // Dossier_Intervention.Tra_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("ConId_Key")]
      public virtual Contrat Contrat { get; set; }

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("DinId_Key")]
      public virtual List<Demande_Intervention_Automatique> Demande_Intervention_Automatique { get; set; }

      [InverseProperty("DinId_Key")]
      public virtual List<Demande_Intervention> Demande_Intervention { get; set; }

   }

   [Table("Ligne_Travailleur")]
   public partial class Ligne_Travailleur
   {

      [Key]
      [Column("Ltr_Id")]
      public decimal ID { get;set; }  // Ligne_Travailleur.Ltr_Id (PrimaryKey)

      [Required]
      [Column("Ltr_NoAttestation")]
      public string NoAttestation { get;set; }   // Ligne_Travailleur.Ltr_NoAttestation

      [Required]
      [Column("Ltr_NoSituation")]
      public string NoSituation { get;set; }   // Ligne_Travailleur.Ltr_NoSituation

      [Required]
      [Column("Ltr_Active")]
      public string Active { get;set; }   // Ligne_Travailleur.Ltr_Active

      [Required]
      [Column("Ltr_Origine")]
      public string Origine { get;set; }   // Ligne_Travailleur.Ltr_Origine

      [Required]
      [Column("Ltr_NISS")]
      public string NISS { get;set; }   // Ligne_Travailleur.Ltr_NISS

      [Required]
      [Column("Ltr_ONSS")]
      public string ONSS { get;set; }   // Ligne_Travailleur.Ltr_ONSS

      [Required]
      [Column("Ltr_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Ligne_Travailleur.Ltr_CategorieEmployeur

      [Required]
      [Column("Ltr_CodeTravailleur")]
      public string CodeTravailleur { get;set; }   // Ligne_Travailleur.Ltr_CodeTravailleur

      [Required]
      [Column("Ltr_Trimestre")]
      public string Trimestre { get;set; }   // Ligne_Travailleur.Ltr_Trimestre

      [Required]
      [Column("Ltr_DateDebutTrimestre")]
      public DateTime DateDebutTrimestre { get;set; }   // Ligne_Travailleur.Ltr_DateDebutTrimestre

      [Required]
      [Column("Ltr_DateFinTrimestre")]
      public DateTime DateFinTrimestre { get;set; }   // Ligne_Travailleur.Ltr_DateFinTrimestre

      [Required]
      [Column("Ltr_Frontalier")]
      public string Frontalier { get;set; }   // Ligne_Travailleur.Ltr_Frontalier

      [Required]
      [Column("Ltr_ActiviteRisque")]
      public string ActiviteRisque { get;set; }   // Ligne_Travailleur.Ltr_ActiviteRisque

      [Required]
      [Column("Ltr_UniteLocale")]
      public string UniteLocale { get;set; }   // Ligne_Travailleur.Ltr_UniteLocale

      [Required]
      [Column("Ltr_DateInjection")]
      public DateTime DateInjection { get;set; }   // Ligne_Travailleur.Ltr_DateInjection

      [Required]
      [Column("Ltr_DateCreation")]
      public DateTime DateCreation { get;set; }   // Ligne_Travailleur.Ltr_DateCreation

      [Required]
      [Column("Ltr_TextLibre")]
      public string TextLibre { get;set; }   // Ligne_Travailleur.Ltr_TextLibre

      [Required]
      [Column("Ltr_AttStatut")]
      public string AttStatut { get;set; }   // Ligne_Travailleur.Ltr_AttStatut

      [Column("Env_Id")]
      public decimal EnvId_Key { get;set; }  // Ligne_Travailleur.Env_Id (ForeignKey)

      [Column("Con_Id")]
      public decimal ConId_Key { get;set; }  // Ligne_Travailleur.Con_Id (ForeignKey)

      [Column("Pct_Id")]
      public decimal PctId_Key { get;set; }  // Ligne_Travailleur.Pct_Id (ForeignKey)

      [Column("Dct_Id")]
      public decimal DctId_Key { get;set; }  // Ligne_Travailleur.Dct_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("EnvId_Key")]
      public virtual Envoi Envoi { get; set; }

      [ForeignKey("ConId_Key")]
      public virtual Contrat Contrat { get; set; }

      [ForeignKey("PctId_Key")]
      public virtual Prime_Contrat Prime_Contrat { get; set; }

      [ForeignKey("DctId_Key")]
      public virtual Pension_Contrat Pension_Contrat { get; set; }

      // Reverse Navigation

      [InverseProperty("LtrId_Key")]
      public virtual List<Ligne_Occupation> Ligne_Occupation { get; set; }

      [InverseProperty("LtrId_Key")]
      public virtual List<Cotisation_Etudiant> Cotisation_Etudiant { get; set; }

   }

   [Table("Titre_Compteur")]
   public partial class Titre_Compteur
   {

      [Key]
      [Column("Tct_Id")]
      public decimal ID { get;set; }  // Titre_Compteur.Tct_Id (PrimaryKey)

      [Required]
      [Column("Tct_Exercice")]
      public string Exercice { get;set; }   // Titre_Compteur.Tct_Exercice

      [Required]
      [Column("Tct_Numero")]
      public decimal Numero { get;set; }   // Titre_Compteur.Tct_Numero

   }

   [Table("Validation_Envoi")]
   public partial class Validation_Envoi
   {

      [Key]
      [Column("Val_Id")]
      public decimal ID { get;set; }  // Validation_Envoi.Val_Id (PrimaryKey)

      [Required]
      [Column("Val_JoursPrestes")]
      public decimal JoursPrestes { get;set; }   // Validation_Envoi.Val_JoursPrestes

      [Required]
      [Column("Val_Salaires")]
      public decimal Salaires { get;set; }   // Validation_Envoi.Val_Salaires

      [Column("Aem_ID")]
      public decimal AemId_Key { get;set; }  // Validation_Envoi.Aem_ID (ForeignKey)

      [Column("Env_Id")]
      public decimal EnvId_Key { get;set; }  // Validation_Envoi.Env_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("AemId_Key")]
      public virtual Activite_Employeur Activite_Employeur { get; set; }

      [ForeignKey("EnvId_Key")]
      public virtual Envoi Envoi { get; set; }

   }

   [Table("dtproperties")]
   public partial class dtproperties
   {

      [Key]
      [Column("id")]
      public int Id { get;set; }  // dtproperties.id (PrimaryKey)

      [Key]
      [Column("property")]
      public string Property { get;set; }  // dtproperties.property (PrimaryKey)

      [Required]
      [Column("objectid")]
      public int Objectid { get;set; }   // dtproperties.objectid

      [Required]
      [Column("value")]
      public string Value { get;set; }   // dtproperties.value

      [Required]
      [Column("lvalue")]
      public byte[] Lvalue { get;set; }   // dtproperties.lvalue

      [Required]
      [Column("version")]
      public int Version { get;set; }   // dtproperties.version

      [Required]
      [Column("uvalue")]
      public string Uvalue { get;set; }   // dtproperties.uvalue

   }

   [Table("Solidarite_Compteur")]
   public partial class Solidarite_Compteur
   {

      [Key]
      [Column("Sco_Id")]
      public decimal ID { get;set; }  // Solidarite_Compteur.Sco_Id (PrimaryKey)

      [Required]
      [Column("Sco_Exercice")]
      public string Exercice { get;set; }   // Solidarite_Compteur.Sco_Exercice

      [Required]
      [Column("Sco_Prefixe")]
      public string Prefixe { get;set; }   // Solidarite_Compteur.Sco_Prefixe

      [Required]
      [Column("Sco_Numero")]
      public decimal Numero { get;set; }   // Solidarite_Compteur.Sco_Numero

   }

   [Table("Solidarite_Inactivite")]
   public partial class Solidarite_Inactivite
   {

      [Key]
      [Column("Sin_Id")]
      public decimal ID { get;set; }  // Solidarite_Inactivite.Sin_Id (PrimaryKey)

      [Required]
      [Column("Sin_Type")]
      public string Type { get;set; }   // Solidarite_Inactivite.Sin_Type

      [Required]
      [Column("Sin_DateDebut")]
      public DateTime DateDebut { get;set; }   // Solidarite_Inactivite.Sin_DateDebut

      [Required]
      [Column("Sin_DateFin")]
      public DateTime DateFin { get;set; }   // Solidarite_Inactivite.Sin_DateFin

      [Required]
      [Column("Sin_Active")]
      public string Active { get;set; }   // Solidarite_Inactivite.Sin_Active

      [Required]
      [Column("Sin_NoDossier")]
      public string NoDossier { get;set; }   // Solidarite_Inactivite.Sin_NoDossier

      [Required]
      [Column("Sin_JoursInactivite")]
      public decimal JoursInactivite { get;set; }   // Solidarite_Inactivite.Sin_JoursInactivite

      [Required]
      [Column("Sin_SalaireFictifJournalier")]
      public decimal SalaireFictifJournalier { get;set; }   // Solidarite_Inactivite.Sin_SalaireFictifJournalier

      [Required]
      [Column("Sin_SFJManuel")]
      public decimal SFJManuel { get;set; }   // Solidarite_Inactivite.Sin_SFJManuel

      [Required]
      [Column("Sin_SalaireFictif")]
      public decimal SalaireFictif { get;set; }   // Solidarite_Inactivite.Sin_SalaireFictif

      [Required]
      [Column("Sin_PrimeInactivite")]
      public decimal PrimeInactivite { get;set; }   // Solidarite_Inactivite.Sin_PrimeInactivite

      [Required]
      [Column("Sin_TexteLibre")]
      public string TexteLibre { get;set; }   // Solidarite_Inactivite.Sin_TexteLibre

      [Column("Dct_Id")]
      public decimal DctId_Key { get;set; }  // Solidarite_Inactivite.Dct_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DctId_Key")]
      public virtual Pension_Contrat Pension_Contrat { get; set; }

   }

   [Table("Drs_A037_DossierAnnuel")]
   public partial class Drs_A037_DossierAnnuel
   {

      [Key]
      [Column("Y37_Id")]
      public decimal ID { get;set; }  // Drs_A037_DossierAnnuel.Y37_Id (PrimaryKey)

      [Required]
      [Column("Y37_Exercice")]
      public string Exercice { get;set; }   // Drs_A037_DossierAnnuel.Y37_Exercice

      [Column("Tra_Id")]
      public decimal TraId_Key { get;set; }  // Drs_A037_DossierAnnuel.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("Y37Id_Key")]
      public virtual List<Drs_A037> Drs_A037 { get; set; }

   }

   [Table("Envoi")]
   public partial class Envoi
   {

      [Key]
      [Column("Env_Id")]
      public decimal ID { get;set; }  // Envoi.Env_Id (PrimaryKey)

      [Required]
      [Column("Env_trimestre")]
      public string Trimestre { get;set; }   // Envoi.Env_trimestre

      [Required]
      [Column("Env_numeroEnvoi")]
      public string NumeroEnvoi { get;set; }   // Envoi.Env_numeroEnvoi

      [Required]
      [Column("Env_numeroSuiteEnvoi")]
      public string NumeroSuiteEnvoi { get;set; }   // Envoi.Env_numeroSuiteEnvoi

      [Required]
      [Column("Env_NomFichier")]
      public string NomFichier { get;set; }   // Envoi.Env_NomFichier

      [Required]
      [Column("Env_dateCreation")]
      public DateTime DateCreation { get;set; }   // Envoi.Env_dateCreation

      [Required]
      [Column("Env_etat")]
      public string Etat { get;set; }   // Envoi.Env_etat

      [Required]
      [Column("Env_NbrRecord")]
      public decimal NbrRecord { get;set; }   // Envoi.Env_NbrRecord

      [Required]
      [Column("Env_NbrRecordInjecte")]
      public decimal NbrRecordInjecte { get;set; }   // Envoi.Env_NbrRecordInjecte

      // Reverse Navigation

      [InverseProperty("EnvId_Key")]
      public virtual List<Ligne_Releve> Ligne_Releve { get; set; }

      [InverseProperty("EnvId_Key")]
      public virtual List<Ligne_Travailleur> Ligne_Travailleur { get; set; }

      [InverseProperty("EnvId_Key")]
      public virtual List<Validation_Envoi> Validation_Envoi { get; set; }

   }

   [Table("Beneficiaire")]
   public partial class Beneficiaire
   {

      [Key]
      [Column("Bnf_ID")]
      public decimal ID { get;set; }  // Beneficiaire.Bnf_ID (PrimaryKey)

      [Required]
      [Column("Bnf_TypeApplication")]
      public string TypeApplication { get;set; }   // Beneficiaire.Bnf_TypeApplication

      [Required]
      [Column("Bnf_Type")]
      public string Type { get;set; }   // Beneficiaire.Bnf_Type

      [Required]
      [Column("Bnf_QuotePart")]
      public decimal QuotePart { get;set; }   // Beneficiaire.Bnf_QuotePart

      [Required]
      [Column("Bnf_Niss")]
      public string Niss { get;set; }   // Beneficiaire.Bnf_Niss

      [Required]
      [Column("Bnf_Nom")]
      public string Nom { get;set; }   // Beneficiaire.Bnf_Nom

      [Required]
      [Column("Bnf_Prenom")]
      public string Prenom { get;set; }   // Beneficiaire.Bnf_Prenom

      [Required]
      [Column("Bnf_DateNaissance")]
      public DateTime DateNaissance { get;set; }   // Beneficiaire.Bnf_DateNaissance

      [Required]
      [Column("Bnf_Langue")]
      public string Langue { get;set; }   // Beneficiaire.Bnf_Langue

      [Required]
      [Column("Bnf_Sexe")]
      public string Sexe { get;set; }   // Beneficiaire.Bnf_Sexe

      [Required]
      [Column("Bnf_AdresseRue")]
      public string AdresseRue { get;set; }   // Beneficiaire.Bnf_AdresseRue

      [Required]
      [Column("Bnf_AdresseNo")]
      public string AdresseNo { get;set; }   // Beneficiaire.Bnf_AdresseNo

      [Required]
      [Column("Bnf_AdresseBte")]
      public string AdresseBte { get;set; }   // Beneficiaire.Bnf_AdresseBte

      [Required]
      [Column("Bnf_CodePostal")]
      public string CodePostal { get;set; }   // Beneficiaire.Bnf_CodePostal

      [Required]
      [Column("Bnf_Localite")]
      public string Localite { get;set; }   // Beneficiaire.Bnf_Localite

      [Required]
      [Column("Bnf_CodePays")]
      public string CodePays { get;set; }   // Beneficiaire.Bnf_CodePays

      [Required]
      [Column("Bnf_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Beneficiaire.Bnf_CompteBancaire

      [Required]
      [Column("Bnf_IBAN")]
      public string IBAN { get;set; }   // Beneficiaire.Bnf_IBAN

      [Required]
      [Column("Bnf_BIC")]
      public string BIC { get;set; }   // Beneficiaire.Bnf_BIC

      [Required]
      [Column("Bnf_Communication")]
      public string Communication { get;set; }   // Beneficiaire.Bnf_Communication

      [Column("Tra_ID")]
      public decimal TraId_Key { get;set; }  // Beneficiaire.Tra_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("BnfId_Key")]
      public virtual List<Payement> Payement { get; set; }

   }

   [Table("Drs_A037")]
   public partial class Drs_A037
   {

      [Key]
      [Column("A37_Id")]
      public decimal ID { get;set; }  // Drs_A037.A37_Id (PrimaryKey)

      [Required]
      [Column("A37_Active")]
      public string Active { get;set; }   // Drs_A037.A37_Active

      [Required]
      [Column("A37_Niss")]
      public string Niss { get;set; }   // Drs_A037.A37_Niss

      [Required]
      [Column("A37_NoAttestation")]
      public string NoAttestation { get;set; }   // Drs_A037.A37_NoAttestation

      [Required]
      [Column("A37_NoSituation")]
      public string NoSituation { get;set; }   // Drs_A037.A37_NoSituation

      [Required]
      [Column("A37_EtatAttestation")]
      public string EtatAttestation { get;set; }   // Drs_A037.A37_EtatAttestation

      [Required]
      [Column("A37_MoisInactivite")]
      public string MoisInactivite { get;set; }   // Drs_A037.A37_MoisInactivite

      [Required]
      [Column("A37_DateCreation")]
      public DateTime DateCreation { get;set; }   // Drs_A037.A37_DateCreation

      [Required]
      [Column("A37_Onss")]
      public string Onss { get;set; }   // Drs_A037.A37_Onss

      [Required]
      [Column("A37_Bce")]
      public string Bce { get;set; }   // Drs_A037.A37_Bce

      [Required]
      [Column("A37_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Drs_A037.A37_CategorieEmployeur

      [Required]
      [Column("A37_CodeTravailleur")]
      public string CodeTravailleur { get;set; }   // Drs_A037.A37_CodeTravailleur

      [Required]
      [Column("A37_NoInterneOccupation")]
      public string NoInterneOccupation { get;set; }   // Drs_A037.A37_NoInterneOccupation

      [Required]
      [Column("A37_DateDebutOccupation")]
      public DateTime DateDebutOccupation { get;set; }   // Drs_A037.A37_DateDebutOccupation

      [Required]
      [Column("A37_CommissionParitaire")]
      public string CommissionParitaire { get;set; }   // Drs_A037.A37_CommissionParitaire

      [Required]
      [Column("A37_HeuresSemTrav")]
      public decimal HeuresSemTrav { get;set; }   // Drs_A037.A37_HeuresSemTrav

      [Required]
      [Column("A37_HeuresSemTravRef")]
      public decimal HeuresSemTravRef { get;set; }   // Drs_A037.A37_HeuresSemTravRef

      [Required]
      [Column("A37_StatutTravailleur")]
      public string StatutTravailleur { get;set; }   // Drs_A037.A37_StatutTravailleur

      [Required]
      [Column("A37_DateDebutPeriode")]
      public DateTime DateDebutPeriode { get;set; }   // Drs_A037.A37_DateDebutPeriode

      [Required]
      [Column("A37_DateFinPeriode")]
      public DateTime DateFinPeriode { get;set; }   // Drs_A037.A37_DateFinPeriode

      [Column("Tra_Id")]
      public decimal TraId_Key { get;set; }  // Drs_A037.Tra_Id (ForeignKey)

      [Column("Drs_Id")]
      public decimal DrsId_Key { get;set; }  // Drs_A037.Drs_Id (ForeignKey)

      [Column("Y37_Id")]
      public decimal Y37Id_Key { get;set; }  // Drs_A037.Y37_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      [ForeignKey("DrsId_Key")]
      public virtual Drs_Envoi Drs_Envoi { get; set; }

      [ForeignKey("Y37Id_Key")]
      public virtual Drs_A037_DossierAnnuel Drs_A037_DossierAnnuel { get; set; }

      // Reverse Navigation

      [InverseProperty("A37Id_Key")]
      public virtual List<Drs_A037ChomageTemporaire> Drs_A037ChomageTemporaire { get; set; }

   }

   [Table("Payement")]
   public partial class Payement
   {

      [Key]
      [Column("Pay_ID")]
      public decimal ID { get;set; }  // Payement.Pay_ID (PrimaryKey)

      [Required]
      [Column("Pay_NoPayement")]
      public string NoPayement { get;set; }   // Payement.Pay_NoPayement

      [Required]
      [Column("Pay_Type")]
      public string Type { get;set; }   // Payement.Pay_Type

      [Required]
      [Column("Pay_Mode")]
      public string Mode { get;set; }   // Payement.Pay_Mode

      [Required]
      [Column("Pay_Actif")]
      public string Actif { get;set; }   // Payement.Pay_Actif

      [Required]
      [Column("Pay_NoCheque")]
      public string NoCheque { get;set; }   // Payement.Pay_NoCheque

      [Required]
      [Column("Pay_Montant")]
      public decimal Montant { get;set; }   // Payement.Pay_Montant

      [Required]
      [Column("Pay_DateDebutValidite")]
      public DateTime DateDebutValidite { get;set; }   // Payement.Pay_DateDebutValidite

      [Required]
      [Column("Pay_DateFinValidite")]
      public DateTime DateFinValidite { get;set; }   // Payement.Pay_DateFinValidite

      [Required]
      [Column("Pay_Etat")]
      public string Etat { get;set; }   // Payement.Pay_Etat

      [Required]
      [Column("Pay_DateEmission")]
      public DateTime DateEmission { get;set; }   // Payement.Pay_DateEmission

      [Required]
      [Column("Pay_DateEncaissement")]
      public DateTime DateEncaissement { get;set; }   // Payement.Pay_DateEncaissement

      [Required]
      [Column("Pay_DateRetour")]
      public DateTime DateRetour { get;set; }   // Payement.Pay_DateRetour

      [Required]
      [Column("Pay_MotivationRetour")]
      public string MotivationRetour { get;set; }   // Payement.Pay_MotivationRetour

      [Required]
      [Column("Pay_Nom")]
      public string Nom { get;set; }   // Payement.Pay_Nom

      [Required]
      [Column("Pay_Prenom")]
      public string Prenom { get;set; }   // Payement.Pay_Prenom

      [Required]
      [Column("Pay_AdresseRue")]
      public string AdresseRue { get;set; }   // Payement.Pay_AdresseRue

      [Required]
      [Column("Pay_AdresseNo")]
      public string AdresseNo { get;set; }   // Payement.Pay_AdresseNo

      [Required]
      [Column("Pay_AdresseBte")]
      public string AdresseBte { get;set; }   // Payement.Pay_AdresseBte

      [Required]
      [Column("Pay_CodePostal")]
      public string CodePostal { get;set; }   // Payement.Pay_CodePostal

      [Required]
      [Column("Pay_Localite")]
      public string Localite { get;set; }   // Payement.Pay_Localite

      [Required]
      [Column("Pay_CodePays")]
      public string CodePays { get;set; }   // Payement.Pay_CodePays

      [Required]
      [Column("Pay_Langue")]
      public string Langue { get;set; }   // Payement.Pay_Langue

      [Required]
      [Column("Pay_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Payement.Pay_CompteBancaire

      [Required]
      [Column("Pay_ReferenceBancaire")]
      public string ReferenceBancaire { get;set; }   // Payement.Pay_ReferenceBancaire

      [Required]
      [Column("Pay_Communication")]
      public string Communication { get;set; }   // Payement.Pay_Communication

      [Required]
      [Column("Pay_DonneurOrdre")]
      public string DonneurOrdre { get;set; }   // Payement.Pay_DonneurOrdre

      [Required]
      [Column("Pay_IBANDebiteur")]
      public string IBANDebiteur { get;set; }   // Payement.Pay_IBANDebiteur

      [Required]
      [Column("Pay_BICDebiteur")]
      public string BICDebiteur { get;set; }   // Payement.Pay_BICDebiteur

      [Required]
      [Column("Pay_IBANCrediteur")]
      public string IBANCrediteur { get;set; }   // Payement.Pay_IBANCrediteur

      [Required]
      [Column("Pay_BICCrediteur")]
      public string BICCrediteur { get;set; }   // Payement.Pay_BICCrediteur

      [Column("Tit_Id")]
      public decimal TitId_Key { get;set; }  // Payement.Tit_Id (ForeignKey)

      [Column("Rcr_Id")]
      public decimal RcrId_Key { get;set; }  // Payement.Rcr_Id (ForeignKey)

      [Column("Bnf_ID")]
      public decimal BnfId_Key { get;set; }  // Payement.Bnf_ID (ForeignKey)

      [Column("Ppp_Id")]
      public decimal PppId_Key { get;set; }  // Payement.Ppp_Id (ForeignKey)

      [Column("Int_Id")]
      public decimal IntId_Key { get;set; }  // Payement.Int_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TitId_Key")]
      public virtual Titre Titre { get; set; }

      [ForeignKey("RcrId_Key")]
      public virtual Retenue_Creance Retenue_Creance { get; set; }

      [ForeignKey("BnfId_Key")]
      public virtual Beneficiaire Beneficiaire { get; set; }

      [ForeignKey("PppId_Key")]
      public virtual Prime_Prepension Prime_Prepension { get; set; }

      [ForeignKey("IntId_Key")]
      public virtual Intervention Intervention { get; set; }

   }

   [Table("Demande_Intervention")]
   public partial class Demande_Intervention
   {

      [Key]
      [Column("Dei_Id")]
      public decimal ID { get;set; }  // Demande_Intervention.Dei_Id (PrimaryKey)

      [Required]
      [Column("Dei_NunmeroFolio")]
      public string NunmeroFolio { get;set; }   // Demande_Intervention.Dei_NunmeroFolio

      [Required]
      [Column("Dei_TypeDemande")]
      public string TypeDemande { get;set; }   // Demande_Intervention.Dei_TypeDemande

      [Required]
      [Column("Dei_DebutPeriode")]
      public DateTime DebutPeriode { get;set; }   // Demande_Intervention.Dei_DebutPeriode

      [Required]
      [Column("Dei_FinPeriode")]
      public DateTime FinPeriode { get;set; }   // Demande_Intervention.Dei_FinPeriode

      [Required]
      [Column("Dei_HeuresSemaine")]
      public decimal HeuresSemaine { get;set; }   // Demande_Intervention.Dei_HeuresSemaine

      [Required]
      [Column("Dei_TauxHoraire")]
      public decimal TauxHoraire { get;set; }   // Demande_Intervention.Dei_TauxHoraire

      [Required]
      [Column("Dei_SalaireBrut")]
      public decimal SalaireBrut { get;set; }   // Demande_Intervention.Dei_SalaireBrut

      [Required]
      [Column("Dei_RetenueONSS")]
      public decimal RetenueONSS { get;set; }   // Demande_Intervention.Dei_RetenueONSS

      [Required]
      [Column("Dei_BaseImposable")]
      public decimal BaseImposable { get;set; }   // Demande_Intervention.Dei_BaseImposable

      [Required]
      [Column("Dei_RetenueFiscale")]
      public decimal RetenueFiscale { get;set; }   // Demande_Intervention.Dei_RetenueFiscale

      [Required]
      [Column("Dei_SalaireNet")]
      public decimal SalaireNet { get;set; }   // Demande_Intervention.Dei_SalaireNet

      [Required]
      [Column("Dei_AllocJournChomage")]
      public decimal AllocJournChomage { get;set; }   // Demande_Intervention.Dei_AllocJournChomage

      [Required]
      [Column("Dei_NbreAllocChomage")]
      public decimal NbreAllocChomage { get;set; }   // Demande_Intervention.Dei_NbreAllocChomage

      [Required]
      [Column("Dei_TotalAllocChomage")]
      public decimal TotalAllocChomage { get;set; }   // Demande_Intervention.Dei_TotalAllocChomage

      [Required]
      [Column("Dei_SalaireReference")]
      public decimal SalaireReference { get;set; }   // Demande_Intervention.Dei_SalaireReference

      [Required]
      [Column("Dei_Difference")]
      public decimal Difference { get;set; }   // Demande_Intervention.Dei_Difference

      [Required]
      [Column("Dei_Commentaire")]
      public string Commentaire { get;set; }   // Demande_Intervention.Dei_Commentaire

      [Column("Din_Id")]
      public decimal DinId_Key { get;set; }  // Demande_Intervention.Din_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DinId_Key")]
      public virtual Dossier_Intervention Dossier_Intervention { get; set; }

      // Reverse Navigation

      [InverseProperty("DeiId_Key")]
      public virtual List<Intervention> Intervention { get; set; }

   }

   [Table("Cotisation_Etudiant")]
   public partial class Cotisation_Etudiant
   {

      [Key]
      [Column("Cet_Id")]
      public decimal ID { get;set; }  // Cotisation_Etudiant.Cet_Id (PrimaryKey)

      [Required]
      [Column("Cet_Remuneration")]
      public decimal Remuneration { get;set; }   // Cotisation_Etudiant.Cet_Remuneration

      [Required]
      [Column("Cet_Cotisation")]
      public decimal Cotisation { get;set; }   // Cotisation_Etudiant.Cet_Cotisation

      [Required]
      [Column("Cet_Jours")]
      public decimal Jours { get;set; }   // Cotisation_Etudiant.Cet_Jours

      [Required]
      [Column("Cet_NoUniteLocale")]
      public string NoUniteLocale { get;set; }   // Cotisation_Etudiant.Cet_NoUniteLocale

      [Required]
      [Column("Cet_TexteLibre")]
      public string TexteLibre { get;set; }   // Cotisation_Etudiant.Cet_TexteLibre

      [Column("Ltr_Id")]
      public decimal LtrId_Key { get;set; }  // Cotisation_Etudiant.Ltr_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("LtrId_Key")]
      public virtual Ligne_Travailleur Ligne_Travailleur { get; set; }

   }

   [Table("Prime_Prepension")]
   public partial class Prime_Prepension
   {

      [Key]
      [Column("Ppp_Id")]
      public decimal ID { get;set; }  // Prime_Prepension.Ppp_Id (PrimaryKey)

      [Required]
      [Column("Ppp_Mois")]
      public string Mois { get;set; }   // Prime_Prepension.Ppp_Mois

      [Required]
      [Column("Ppp_Etat")]
      public string Etat { get;set; }   // Prime_Prepension.Ppp_Etat

      [Required]
      [Column("Ppp_MontantChomage")]
      public decimal MontantChomage { get;set; }   // Prime_Prepension.Ppp_MontantChomage

      [Required]
      [Column("Ppp_IndemniteExtraLegale")]
      public decimal IndemniteExtraLegale { get;set; }   // Prime_Prepension.Ppp_IndemniteExtraLegale

      [Required]
      [Column("Ppp_IndemniteBrute")]
      public decimal IndemniteBrute { get;set; }   // Prime_Prepension.Ppp_IndemniteBrute

      [Required]
      [Column("Ppp_RetenueONP")]
      public decimal RetenueONP { get;set; }   // Prime_Prepension.Ppp_RetenueONP

      [Required]
      [Column("Ppp_RetenueONEM")]
      public decimal RetenueONEM { get;set; }   // Prime_Prepension.Ppp_RetenueONEM

      [Required]
      [Column("Ppp_RetenueFiscale")]
      public decimal RetenueFiscale { get;set; }   // Prime_Prepension.Ppp_RetenueFiscale

      [Required]
      [Column("Ppp_RevenuNet")]
      public decimal RevenuNet { get;set; }   // Prime_Prepension.Ppp_RevenuNet

      [Required]
      [Column("Ppp_IndemnitePayable")]
      public decimal IndemnitePayable { get;set; }   // Prime_Prepension.Ppp_IndemnitePayable

      [Required]
      [Column("Ppp_CapitativeONP")]
      public decimal CapitativeONP { get;set; }   // Prime_Prepension.Ppp_CapitativeONP

      [Required]
      [Column("Ppp_CapitativeONSS")]
      public decimal CapitativeONSS { get;set; }   // Prime_Prepension.Ppp_CapitativeONSS

      [Required]
      [Column("Ppp_CotisationCompensatoire")]
      public decimal CotisationCompensatoire { get;set; }   // Prime_Prepension.Ppp_CotisationCompensatoire

      [Required]
      [Column("Ppp_DateExecution")]
      public DateTime DateExecution { get;set; }   // Prime_Prepension.Ppp_DateExecution

      [Required]
      [Column("Ppp_ModeCalcul")]
      public string ModeCalcul { get;set; }   // Prime_Prepension.Ppp_ModeCalcul

      [Required]
      [Column("Ppp_CotisationPersonnelle")]
      public decimal CotisationPersonnelle { get;set; }   // Prime_Prepension.Ppp_CotisationPersonnelle

      [Required]
      [Column("Ppp_CotisationPatronale")]
      public decimal CotisationPatronale { get;set; }   // Prime_Prepension.Ppp_CotisationPatronale

      [Required]
      [Column("Ppp_DebiteurPrincipal")]
      public string DebiteurPrincipal { get;set; }   // Prime_Prepension.Ppp_DebiteurPrincipal

      [Required]
      [Column("Ppp_JoursPrestes")]
      public decimal JoursPrestes { get;set; }   // Prime_Prepension.Ppp_JoursPrestes

      [Required]
      [Column("Ppp_AgeReference")]
      public decimal AgeReference { get;set; }   // Prime_Prepension.Ppp_AgeReference

      [Required]
      [Column("Ppp_Plancher")]
      public string Plancher { get;set; }   // Prime_Prepension.Ppp_Plancher

      [Required]
      [Column("Ppp_Reprise")]
      public string Reprise { get;set; }   // Prime_Prepension.Ppp_Reprise

      [Required]
      [Column("Ppp_TauxReduitCompensatoire")]
      public string TauxReduitCompensatoire { get;set; }   // Prime_Prepension.Ppp_TauxReduitCompensatoire

      [Required]
      [Column("Ppp_EtatEmployeur")]
      public string EtatEmployeur { get;set; }   // Prime_Prepension.Ppp_EtatEmployeur

      [Required]
      [Column("Ppp_CodePersonnel")]
      public string CodePersonnel { get;set; }   // Prime_Prepension.Ppp_CodePersonnel

      [Required]
      [Column("Ppp_CodePatronal")]
      public string CodePatronal { get;set; }   // Prime_Prepension.Ppp_CodePatronal

      [Required]
      [Column("Ppp_CodeCompensatoire")]
      public string CodeCompensatoire { get;set; }   // Prime_Prepension.Ppp_CodeCompensatoire

      [Required]
      [Column("Ppp_CodeAge")]
      public string CodeAge { get;set; }   // Prime_Prepension.Ppp_CodeAge

      [Column("Dpp_Id")]
      public decimal DppId_Key { get;set; }  // Prime_Prepension.Dpp_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DppId_Key")]
      public virtual Dossier_Prepension Dossier_Prepension { get; set; }

      // Reverse Navigation

      [InverseProperty("PppId_Key")]
      public virtual List<Payement> Payement { get; set; }

   }

   [Table("Drs_A044_Dossier")]
   public partial class Drs_A044_Dossier
   {

      [Key]
      [Column("D44_Id")]
      public decimal ID { get;set; }  // Drs_A044_Dossier.D44_Id (PrimaryKey)

      [Required]
      [Column("D44_Niss")]
      public string Niss { get;set; }   // Drs_A044_Dossier.D44_Niss

      [Required]
      [Column("D44_NoDossier")]
      public string NoDossier { get;set; }   // Drs_A044_Dossier.D44_NoDossier

      [Required]
      [Column("D44_DateAccident")]
      public DateTime DateAccident { get;set; }   // Drs_A044_Dossier.D44_DateAccident

      [Required]
      [Column("D44_DateCreation")]
      public DateTime DateCreation { get;set; }   // Drs_A044_Dossier.D44_DateCreation

      [Column("Tra_Id")]
      public decimal TraId_Key { get;set; }  // Drs_A044_Dossier.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("D44Id_Key")]
      public virtual List<Drs_A044_Attestation> Drs_A044_Attestation { get; set; }

   }

   [Table("Drs_A044_Payement")]
   public partial class Drs_A044_Payement
   {

      [Key]
      [Column("P44_Id")]
      public decimal ID { get;set; }  // Drs_A044_Payement.P44_Id (PrimaryKey)

      [Required]
      [Column("P44_DateDebutPayement")]
      public DateTime DateDebutPayement { get;set; }   // Drs_A044_Payement.P44_DateDebutPayement

      [Required]
      [Column("P44_DateFinPayement")]
      public DateTime DateFinPayement { get;set; }   // Drs_A044_Payement.P44_DateFinPayement

      [Required]
      [Column("P44_Pourcentage")]
      public decimal Pourcentage { get;set; }   // Drs_A044_Payement.P44_Pourcentage

      [Required]
      [Column("P44_MontantBrut")]
      public decimal MontantBrut { get;set; }   // Drs_A044_Payement.P44_MontantBrut

      [Required]
      [Column("P44_RetenueOnss")]
      public decimal RetenueOnss { get;set; }   // Drs_A044_Payement.P44_RetenueOnss

      [Column("A44_Id")]
      public decimal A44Id_Key { get;set; }  // Drs_A044_Payement.A44_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("A44Id_Key")]
      public virtual Drs_A044_Attestation Drs_A044_Attestation { get; set; }

   }

   [Table("Immunisation_Jours")]
   public partial class Immunisation_Jours
   {

      [Key]
      [Column("Imj_Id")]
      public decimal ID { get;set; }  // Immunisation_Jours.Imj_Id (PrimaryKey)

      [Required]
      [Column("Imj_Mois")]
      public string Mois { get;set; }   // Immunisation_Jours.Imj_Mois

      [Required]
      [Column("Imj_JoursImmunises")]
      public decimal JoursImmunises { get;set; }   // Immunisation_Jours.Imj_JoursImmunises

      [Required]
      [Column("Imj_Raison")]
      public string Raison { get;set; }   // Immunisation_Jours.Imj_Raison

      [Column("Dpp_Id")]
      public decimal DppId_Key { get;set; }  // Immunisation_Jours.Dpp_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DppId_Key")]
      public virtual Dossier_Prepension Dossier_Prepension { get; set; }

   }

   [Table("Drs_A044_Attestation")]
   public partial class Drs_A044_Attestation
   {

      [Key]
      [Column("A44_Id")]
      public decimal ID { get;set; }  // Drs_A044_Attestation.A44_Id (PrimaryKey)

      [Required]
      [Column("A44_Active")]
      public string Active { get;set; }   // Drs_A044_Attestation.A44_Active

      [Required]
      [Column("A44_NoAttestation")]
      public string NoAttestation { get;set; }   // Drs_A044_Attestation.A44_NoAttestation

      [Required]
      [Column("A44_NoSituation")]
      public string NoSituation { get;set; }   // Drs_A044_Attestation.A44_NoSituation

      [Required]
      [Column("A44_EtatAttestation")]
      public string EtatAttestation { get;set; }   // Drs_A044_Attestation.A44_EtatAttestation

      [Required]
      [Column("A44_DateCreation")]
      public DateTime DateCreation { get;set; }   // Drs_A044_Attestation.A44_DateCreation

      [Required]
      [Column("A44_NoAccident")]
      public string NoAccident { get;set; }   // Drs_A044_Attestation.A44_NoAccident

      [Required]
      [Column("A44_Bce")]
      public string Bce { get;set; }   // Drs_A044_Attestation.A44_Bce

      [Required]
      [Column("A44_Onss")]
      public string Onss { get;set; }   // Drs_A044_Attestation.A44_Onss

      [Required]
      [Column("A44_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Drs_A044_Attestation.A44_CategorieEmployeur

      [Required]
      [Column("A44_MoisInactivite")]
      public string MoisInactivite { get;set; }   // Drs_A044_Attestation.A44_MoisInactivite

      [Required]
      [Column("A44_DateDebutPeriode")]
      public DateTime DateDebutPeriode { get;set; }   // Drs_A044_Attestation.A44_DateDebutPeriode

      [Required]
      [Column("A44_DateFinPeriode")]
      public DateTime DateFinPeriode { get;set; }   // Drs_A044_Attestation.A44_DateFinPeriode

      [Column("D44_Id")]
      public decimal D44Id_Key { get;set; }  // Drs_A044_Attestation.D44_Id (ForeignKey)

      [Column("Drs_Id")]
      public decimal DrsId_Key { get;set; }  // Drs_A044_Attestation.Drs_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("D44Id_Key")]
      public virtual Drs_A044_Dossier Drs_A044_Dossier { get; set; }

      [ForeignKey("DrsId_Key")]
      public virtual Drs_Envoi Drs_Envoi { get; set; }

      // Reverse Navigation

      [InverseProperty("A44Id_Key")]
      public virtual List<Drs_A044_Payement> Drs_A044_Payement { get; set; }

   }

   [Table("Creance")]
   public partial class Creance
   {

      [Key]
      [Column("Cre_ID")]
      public decimal ID { get;set; }  // Creance.Cre_ID (PrimaryKey)

      [Required]
      [Column("Cre_Type")]
      public string Type { get;set; }   // Creance.Cre_Type

      [Required]
      [Column("Cre_Montant")]
      public decimal Montant { get;set; }   // Creance.Cre_Montant

      [Required]
      [Column("Cre_Solde")]
      public decimal Solde { get;set; }   // Creance.Cre_Solde

      [Required]
      [Column("Cre_LimiteRetenue")]
      public decimal LimiteRetenue { get;set; }   // Creance.Cre_LimiteRetenue

      [Required]
      [Column("Cre_DateNotification")]
      public DateTime DateNotification { get;set; }   // Creance.Cre_DateNotification

      [Required]
      [Column("Cre_RefNotification")]
      public string RefNotification { get;set; }   // Creance.Cre_RefNotification

      [Required]
      [Column("Cre_Etat")]
      public string Etat { get;set; }   // Creance.Cre_Etat

      [Required]
      [Column("Cre_DateDernierEtat")]
      public DateTime DateDernierEtat { get;set; }   // Creance.Cre_DateDernierEtat

      [Required]
      [Column("Cre_EtatPrecedent")]
      public string EtatPrecedent { get;set; }   // Creance.Cre_EtatPrecedent

      [Required]
      [Column("Cre_ModeCalcul")]
      public string ModeCalcul { get;set; }   // Creance.Cre_ModeCalcul

      [Required]
      [Column("Cre_MontantFixe")]
      public decimal MontantFixe { get;set; }   // Creance.Cre_MontantFixe

      [Required]
      [Column("Cre_Pourcentage")]
      public decimal Pourcentage { get;set; }   // Creance.Cre_Pourcentage

      [Required]
      [Column("Cre_AuProrata")]
      public string AuProrata { get;set; }   // Creance.Cre_AuProrata

      [Required]
      [Column("Cre_Indexe")]
      public string Indexe { get;set; }   // Creance.Cre_Indexe

      [Required]
      [Column("Cre_Nom")]
      public string Nom { get;set; }   // Creance.Cre_Nom

      [Required]
      [Column("Cre_Prenom")]
      public string Prenom { get;set; }   // Creance.Cre_Prenom

      [Required]
      [Column("Cre_AdresseRue")]
      public string AdresseRue { get;set; }   // Creance.Cre_AdresseRue

      [Required]
      [Column("Cre_AdresseNo")]
      public string AdresseNo { get;set; }   // Creance.Cre_AdresseNo

      [Required]
      [Column("Cre_AdresseBte")]
      public string AdresseBte { get;set; }   // Creance.Cre_AdresseBte

      [Required]
      [Column("Cre_CodePostal")]
      public string CodePostal { get;set; }   // Creance.Cre_CodePostal

      [Required]
      [Column("Cre_Localite")]
      public string Localite { get;set; }   // Creance.Cre_Localite

      [Required]
      [Column("Cre_CodePays")]
      public string CodePays { get;set; }   // Creance.Cre_CodePays

      [Required]
      [Column("Cre_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Creance.Cre_CompteBancaire

      [Required]
      [Column("Cre_IBAN")]
      public string IBAN { get;set; }   // Creance.Cre_IBAN

      [Required]
      [Column("Cre_BIC")]
      public string BIC { get;set; }   // Creance.Cre_BIC

      [Required]
      [Column("Cre_Langue")]
      public string Langue { get;set; }   // Creance.Cre_Langue

      [Required]
      [Column("Cre_DateModification")]
      public DateTime DateModification { get;set; }   // Creance.Cre_DateModification

      [Required]
      [Column("Cre_Rang")]
      public decimal Rang { get;set; }   // Creance.Cre_Rang

      [Required]
      [Column("Cre_DatePayement")]
      public DateTime DatePayement { get;set; }   // Creance.Cre_DatePayement

      [Required]
      [Column("Cre_DateDepotGreffe")]
      public DateTime DateDepotGreffe { get;set; }   // Creance.Cre_DateDepotGreffe

      [Required]
      [Column("Cre_Numero")]
      public string Numero { get;set; }   // Creance.Cre_Numero

      [Column("Cri_ID")]
      public decimal CriId_Key { get;set; }  // Creance.Cri_ID (ForeignKey)

      [Column("Tra_ID")]
      public decimal TraId_Key { get;set; }  // Creance.Tra_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("CriId_Key")]
      public virtual Creancier Creancier { get; set; }

      [ForeignKey("TraId_Key")]
      public virtual Travailleur Travailleur { get; set; }

      // Reverse Navigation

      [InverseProperty("CreId_Key")]
      public virtual List<Retenue_Creance> Retenue_Creance { get; set; }

   }

   [Table("Creancier")]
   public partial class Creancier
   {

      [Key]
      [Column("Cri_ID")]
      public decimal ID { get;set; }  // Creancier.Cri_ID (PrimaryKey)

      [Required]
      [Column("Cri_Numero")]
      public string Numero { get;set; }   // Creancier.Cri_Numero

      [Required]
      [Column("Cri_Nom")]
      public string Nom { get;set; }   // Creancier.Cri_Nom

      [Required]
      [Column("Cri_AdresseRue")]
      public string AdresseRue { get;set; }   // Creancier.Cri_AdresseRue

      [Required]
      [Column("Cri_AdresseNo")]
      public string AdresseNo { get;set; }   // Creancier.Cri_AdresseNo

      [Required]
      [Column("Cri_AdresseBte")]
      public string AdresseBte { get;set; }   // Creancier.Cri_AdresseBte

      [Required]
      [Column("Cri_CodePostal")]
      public string CodePostal { get;set; }   // Creancier.Cri_CodePostal

      [Required]
      [Column("Cri_Localite")]
      public string Localite { get;set; }   // Creancier.Cri_Localite

      [Required]
      [Column("Cri_CodePays")]
      public string CodePays { get;set; }   // Creancier.Cri_CodePays

      [Required]
      [Column("Cri_Telephone")]
      public string Telephone { get;set; }   // Creancier.Cri_Telephone

      [Required]
      [Column("Cri_Fax")]
      public string Fax { get;set; }   // Creancier.Cri_Fax

      [Required]
      [Column("Cri_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Creancier.Cri_CompteBancaire

      [Required]
      [Column("Cri_IBAN")]
      public string IBAN { get;set; }   // Creancier.Cri_IBAN

      [Required]
      [Column("Cri_BIC")]
      public string BIC { get;set; }   // Creancier.Cri_BIC

      [Required]
      [Column("Cri_Langue")]
      public string Langue { get;set; }   // Creancier.Cri_Langue

      // Reverse Navigation

      [InverseProperty("CriId_Key")]
      public virtual List<Creance> Creance { get; set; }

   }

}
