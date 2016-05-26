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

      [Column("Dpp_CodeSyndical")]
      public string CodeSyndical { get;set; }   // Dossier_Prepension.Dpp_CodeSyndical

      [Column("Dpp_SalaireONSS")]
      public decimal? SalaireONSS { get;set; }   // Dossier_Prepension.Dpp_SalaireONSS

      [Column("Dpp_JoursPrestes")]
      public decimal? JoursPrestes { get;set; }   // Dossier_Prepension.Dpp_JoursPrestes

      [Column("Dpp_SalaireHoraire")]
      public decimal? SalaireHoraire { get;set; }   // Dossier_Prepension.Dpp_SalaireHoraire

      [Column("Dpp_HeuresSemaine")]
      public decimal? HeuresSemaine { get;set; }   // Dossier_Prepension.Dpp_HeuresSemaine

      [Column("Dpp_SalaireMensuel")]
      public decimal? SalaireMensuel { get;set; }   // Dossier_Prepension.Dpp_SalaireMensuel

      [Column("Dpp_MontantPrimes")]
      public decimal? MontantPrimes { get;set; }   // Dossier_Prepension.Dpp_MontantPrimes

      [Column("Dpp_RetenueONSS")]
      public decimal? RetenueONSS { get;set; }   // Dossier_Prepension.Dpp_RetenueONSS

      [Column("Dpp_Precompte")]
      public decimal? Precompte { get;set; }   // Dossier_Prepension.Dpp_Precompte

      [Column("Dpp_SalaireReference")]
      public decimal? SalaireReference { get;set; }   // Dossier_Prepension.Dpp_SalaireReference

      [Column("Dpp_DemiSalaireReference")]
      public decimal? DemiSalaireReference { get;set; }   // Dossier_Prepension.Dpp_DemiSalaireReference

      [Column("Dpp_IndemniteExtraLegale")]
      public decimal? IndemniteExtraLegale { get;set; }   // Dossier_Prepension.Dpp_IndemniteExtraLegale

      [Column("Dpp_IndemniteBrute")]
      public decimal? IndemniteBrute { get;set; }   // Dossier_Prepension.Dpp_IndemniteBrute

      [Column("Dpp_NbreAllocations")]
      public decimal? NbreAllocations { get;set; }   // Dossier_Prepension.Dpp_NbreAllocations

      [Column("Dpp_CodeChomage")]
      public string CodeChomage { get;set; }   // Dossier_Prepension.Dpp_CodeChomage

      [Column("Dpp_MontantChomage")]
      public decimal? MontantChomage { get;set; }   // Dossier_Prepension.Dpp_MontantChomage

      [Column("Dpp_RetenueONP")]
      public decimal? RetenueONP { get;set; }   // Dossier_Prepension.Dpp_RetenueONP

      [Column("Dpp_RetenueONEM")]
      public decimal? RetenueONEM { get;set; }   // Dossier_Prepension.Dpp_RetenueONEM

      [Column("Dpp_RetenueFicale")]
      public decimal? RetenueFicale { get;set; }   // Dossier_Prepension.Dpp_RetenueFicale

      [Column("Dpp_IndemniteNette")]
      public decimal? IndemniteNette { get;set; }   // Dossier_Prepension.Dpp_IndemniteNette

      [Column("Dpp_PrimeChomage")]
      public decimal? PrimeChomage { get;set; }   // Dossier_Prepension.Dpp_PrimeChomage

      [Column("Dpp_TypeDossier")]
      public string TypeDossier { get;set; }   // Dossier_Prepension.Dpp_TypeDossier

      [Column("Dpp_Commentaire")]
      public string Commentaire { get;set; }   // Dossier_Prepension.Dpp_Commentaire

      [Column("Dpp_RepriseTravail")]
      public string RepriseTravail { get;set; }   // Dossier_Prepension.Dpp_RepriseTravail

      [Column("Dpp_ModeCalcul")]
      public string ModeCalcul { get;set; }   // Dossier_Prepension.Dpp_ModeCalcul

      [Column("Dpp_DateNotification")]
      public DateTime? DateNotification { get;set; }   // Dossier_Prepension.Dpp_DateNotification

      [Column("Dpp_CotisationPersonnelle")]
      public decimal? CotisationPersonnelle { get;set; }   // Dossier_Prepension.Dpp_CotisationPersonnelle

      [Column("Dpp_EtatEmployeur")]
      public string EtatEmployeur { get;set; }   // Dossier_Prepension.Dpp_EtatEmployeur

      [Column("Dpp_DateDebutEtat")]
      public DateTime? DateDebutEtat { get;set; }   // Dossier_Prepension.Dpp_DateDebutEtat

      [Column("Dpp_DateFinEtat")]
      public DateTime? DateFinEtat { get;set; }   // Dossier_Prepension.Dpp_DateFinEtat

      [Column("Dpp_Remplacement")]
      public string Remplacement { get;set; }   // Dossier_Prepension.Dpp_Remplacement

      [Column("Dpp_NissRemplacant")]
      public string NissRemplacant { get;set; }   // Dossier_Prepension.Dpp_NissRemplacant

      [Column("Dpp_Reprise")]
      public string Reprise { get;set; }   // Dossier_Prepension.Dpp_Reprise

      [Column("Dpp_DateDebutReprise")]
      public DateTime? DateDebutReprise { get;set; }   // Dossier_Prepension.Dpp_DateDebutReprise

      [Column("Dpp_DateFinReprise")]
      public DateTime? DateFinReprise { get;set; }   // Dossier_Prepension.Dpp_DateFinReprise

      [Column("Dpp_Frontalier")]
      public string Frontalier { get;set; }   // Dossier_Prepension.Dpp_Frontalier

      [Column("Dpp_Capitalisation")]
      public string Capitalisation { get;set; }   // Dossier_Prepension.Dpp_Capitalisation

      [Column("Dpp_CoeffCapitalisation")]
      public decimal? CoeffCapitalisation { get;set; }   // Dossier_Prepension.Dpp_CoeffCapitalisation

      [Column("Dpp_IndemTheoriqueMensuelle")]
      public decimal? IndemTheoriqueMensuelle { get;set; }   // Dossier_Prepension.Dpp_IndemTheoriqueMensuelle

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

      [Column("Fnd_NomFR")]
      public string NomFR { get;set; }   // Fonds.Fnd_NomFR

      [Column("Fnd_NomNl")]
      public string NomNl { get;set; }   // Fonds.Fnd_NomNl

      [Column("Fnd_NomGE")]
      public string NomGE { get;set; }   // Fonds.Fnd_NomGE

      [Column("Fnd_AdresseRueNL")]
      public string AdresseRueNL { get;set; }   // Fonds.Fnd_AdresseRueNL

      [Column("Fnd_AdresseRueFR")]
      public string AdresseRueFR { get;set; }   // Fonds.Fnd_AdresseRueFR

      [Column("Fnd_AdresseRueGE")]
      public string AdresseRueGE { get;set; }   // Fonds.Fnd_AdresseRueGE

      [Column("Fnd_AdresseNo")]
      public string AdresseNo { get;set; }   // Fonds.Fnd_AdresseNo

      [Column("Fnd_AdresseBte")]
      public string AdresseBte { get;set; }   // Fonds.Fnd_AdresseBte

      [Column("Fnd_CodePostal")]
      public string CodePostal { get;set; }   // Fonds.Fnd_CodePostal

      [Column("Fnd_LocaliteNL")]
      public string LocaliteNL { get;set; }   // Fonds.Fnd_LocaliteNL

      [Column("Fnd_LocaliteFR")]
      public string LocaliteFR { get;set; }   // Fonds.Fnd_LocaliteFR

      [Column("Fnd_LocaliteGE")]
      public string LocaliteGE { get;set; }   // Fonds.Fnd_LocaliteGE

      [Column("Fnd_CodePays")]
      public string CodePays { get;set; }   // Fonds.Fnd_CodePays

      [Column("Fnd_Telephone")]
      public string Telephone { get;set; }   // Fonds.Fnd_Telephone

      [Column("Fnd_Fax")]
      public string Fax { get;set; }   // Fonds.Fnd_Fax

      [Column("Fnd_NomContact")]
      public string NomContact { get;set; }   // Fonds.Fnd_NomContact

      [Column("Fnd_NissContact")]
      public string NissContact { get;set; }   // Fonds.Fnd_NissContact

      [Column("Fnd_CodeEntreprise")]
      public string CodeEntreprise { get;set; }   // Fonds.Fnd_CodeEntreprise

      [Column("Fnd_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Fonds.Fnd_CompteBancaire

      [Column("Fnd_IBAN")]
      public string IBAN { get;set; }   // Fonds.Fnd_IBAN

      [Column("Fnd_BIC")]
      public string BIC { get;set; }   // Fonds.Fnd_BIC

      [Column("Fnd_Langue")]
      public string Langue { get;set; }   // Fonds.Fnd_Langue

      [Column("Fnd_NumeroDirReg")]
      public string NumeroDirReg { get;set; }   // Fonds.Fnd_NumeroDirReg

      [Column("Fnd_NumeroBurRec")]
      public string NumeroBurRec { get;set; }   // Fonds.Fnd_NumeroBurRec

      [Column("Fnd_NomBurRec")]
      public string NomBurRec { get;set; }   // Fonds.Fnd_NomBurRec

      [Column("Fnd_NumeroAdmCD")]
      public string NumeroAdmCD { get;set; }   // Fonds.Fnd_NumeroAdmCD

      [Column("Fnd_NumeroBurCtl")]
      public string NumeroBurCtl { get;set; }   // Fonds.Fnd_NumeroBurCtl

      [Column("Fnd_NomBurCtl")]
      public string NomBurCtl { get;set; }   // Fonds.Fnd_NomBurCtl

      [Column("Fnd_NomMandat")]
      public string NomMandat { get;set; }   // Fonds.Fnd_NomMandat

      [Column("Fnd_AdresseRueMandat")]
      public string AdresseRueMandat { get;set; }   // Fonds.Fnd_AdresseRueMandat

      [Column("Fnd_AdresseNoMandat")]
      public string AdresseNoMandat { get;set; }   // Fonds.Fnd_AdresseNoMandat

      [Column("Fnd_AdresseBteMandat")]
      public string AdresseBteMandat { get;set; }   // Fonds.Fnd_AdresseBteMandat

      [Column("Fnd_CodePostalMandat")]
      public string CodePostalMandat { get;set; }   // Fonds.Fnd_CodePostalMandat

      [Column("Fnd_LocaliteMandat")]
      public string LocaliteMandat { get;set; }   // Fonds.Fnd_LocaliteMandat

      [Column("Fnd_CodePaysMandat")]
      public string CodePaysMandat { get;set; }   // Fonds.Fnd_CodePaysMandat

      [Column("Fnd_TelephoneMandat")]
      public string TelephoneMandat { get;set; }   // Fonds.Fnd_TelephoneMandat

      [Column("Fnd_FaxMandat")]
      public string FaxMandat { get;set; }   // Fonds.Fnd_FaxMandat

      [Column("Fnd_EmailContact")]
      public string EmailContact { get;set; }   // Fonds.Fnd_EmailContact

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

      [Column("Att38_Active")]
      public string Active { get;set; }   // Att_A038.Att38_Active

      [Column("Att38_INSS")]
      public string INSS { get;set; }   // Att_A038.Att38_INSS

      [Column("Att38_AttestationID")]
      public string AttestationID { get;set; }   // Att_A038.Att38_AttestationID

      [Column("Att38_SituationNbr")]
      public decimal? SituationNbr { get;set; }   // Att_A038.Att38_SituationNbr

      [Column("Att38_AttestationStatus")]
      public decimal? AttestationStatus { get;set; }   // Att_A038.Att38_AttestationStatus

      [Column("Att38_CreationDate")]
      public DateTime? CreationDate { get;set; }   // Att_A038.Att38_CreationDate

      [Column("Att38_HolidayYear")]
      public string HolidayYear { get;set; }   // Att_A038.Att38_HolidayYear

      [Column("Att38_ContractType")]
      public string ContractType { get;set; }   // Att_A038.Att38_ContractType

      [Column("Att38_LegalSingleHolidaySavings")]
      public decimal? LegalSingleHolidaySavings { get;set; }   // Att_A038.Att38_LegalSingleHolidaySavings

      [Column("Att38_LegalDoubleHolidaySavings")]
      public decimal? LegalDoubleHolidaySavings { get;set; }   // Att_A038.Att38_LegalDoubleHolidaySavings

      [Column("Att38_LegalNbrOfDays")]
      public decimal? LegalNbrOfDays { get;set; }   // Att_A038.Att38_LegalNbrOfDays

      [Column("Att38_TreatyHolidaySavings")]
      public decimal? TreatyHolidaySavings { get;set; }   // Att_A038.Att38_TreatyHolidaySavings

      [Column("Att38_TreatyNbrOfDays")]
      public decimal? TreatyNbrOfDays { get;set; }   // Att_A038.Att38_TreatyNbrOfDays

      [Column("Snd38_Id")]
      public decimal? Snd38Id_Key { get;set; }  // Att_A038.Snd38_Id (ForeignKey)

      [Column("Tra_Id")]
      public decimal? TraId_Key { get;set; }  // Att_A038.Tra_Id (ForeignKey)

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

      [Column("Ind38_AttestationID")]
      public string AttestationID { get;set; }   // Att_A038_IndividualAtt.Ind38_AttestationID

      [Column("Ind38_SituationNbr")]
      public decimal? SituationNbr { get;set; }   // Att_A038_IndividualAtt.Ind38_SituationNbr

      [Column("Ind38_AttestationStatus")]
      public decimal? AttestationStatus { get;set; }   // Att_A038_IndividualAtt.Ind38_AttestationStatus

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

      [Column("Occ_NoAttestation")]
      public string NoAttestation { get;set; }   // Ligne_Occupation.Occ_NoAttestation

      [Column("Occ_NoSituation")]
      public string NoSituation { get;set; }   // Ligne_Occupation.Occ_NoSituation

      [Column("Occ_Trimestre")]
      public string Trimestre { get;set; }   // Ligne_Occupation.Occ_Trimestre

      [Column("Occ_DateDebutOccupation")]
      public DateTime? DateDebutOccupation { get;set; }   // Ligne_Occupation.Occ_DateDebutOccupation

      [Column("Occ_DateFinOccupation")]
      public DateTime? DateFinOccupation { get;set; }   // Ligne_Occupation.Occ_DateFinOccupation

      [Column("Occ_CommissionParitaire")]
      public string CommissionParitaire { get;set; }   // Ligne_Occupation.Occ_CommissionParitaire

      [Column("Occ_Regime")]
      public decimal? Regime { get;set; }   // Ligne_Occupation.Occ_Regime

      [Column("Occ_HeuresSemTrav")]
      public decimal? HeuresSemTrav { get;set; }   // Ligne_Occupation.Occ_HeuresSemTrav

      [Column("Occ_HeuresSemTravRef")]
      public decimal? HeuresSemTravRef { get;set; }   // Ligne_Occupation.Occ_HeuresSemTravRef

      [Column("Occ_TypeContrat")]
      public string TypeContrat { get;set; }   // Ligne_Occupation.Occ_TypeContrat

      [Column("Occ_ReorganTravail")]
      public string ReorganTravail { get;set; }   // Ligne_Occupation.Occ_ReorganTravail

      [Column("Occ_PromotionEmploi")]
      public string PromotionEmploi { get;set; }   // Ligne_Occupation.Occ_PromotionEmploi

      [Column("Occ_StatutTravailleur")]
      public string StatutTravailleur { get;set; }   // Ligne_Occupation.Occ_StatutTravailleur

      [Column("Occ_Pensionne")]
      public string Pensionne { get;set; }   // Ligne_Occupation.Occ_Pensionne

      [Column("Occ_TypeApprenti")]
      public string TypeApprenti { get;set; }   // Ligne_Occupation.Occ_TypeApprenti

      [Column("Occ_ModeRemuneration")]
      public string ModeRemuneration { get;set; }   // Ligne_Occupation.Occ_ModeRemuneration

      [Column("Occ_FractionPrestation")]
      public decimal? FractionPrestation { get;set; }   // Ligne_Occupation.Occ_FractionPrestation

      [Column("Occ_JustificationJours")]
      public string JustificationJours { get;set; }   // Ligne_Occupation.Occ_JustificationJours

      [Column("Occ_TextLibre")]
      public string TextLibre { get;set; }   // Ligne_Occupation.Occ_TextLibre

      [Column("Occ_NoUniteLocale")]
      public string NoUniteLocale { get;set; }   // Ligne_Occupation.Occ_NoUniteLocale

      [Column("Occ_NISUniteLocale")]
      public string NISUniteLocale { get;set; }   // Ligne_Occupation.Occ_NISUniteLocale

      [Column("Occ_CodeRegionalisation")]
      public string CodeRegionalisation { get;set; }   // Ligne_Occupation.Occ_CodeRegionalisation

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

      [Column("Pen_DateCreation")]
      public DateTime? DateCreation { get;set; }   // Pension.Pen_DateCreation

      [Column("Pen_NoPolice")]
      public string NoPolice { get;set; }   // Pension.Pen_NoPolice

      [Column("Pen_DroitAcquis")]
      public string DroitAcquis { get;set; }   // Pension.Pen_DroitAcquis

      [Column("Pen_TrimestrePremier")]
      public string TrimestrePremier { get;set; }   // Pension.Pen_TrimestrePremier

      [Column("Pen_TrimestreDernier")]
      public string TrimestreDernier { get;set; }   // Pension.Pen_TrimestreDernier

      [Column("Pen_TypeLiquidation")]
      public string TypeLiquidation { get;set; }   // Pension.Pen_TypeLiquidation

      [Column("Pen_DateLiquidation")]
      public DateTime? DateLiquidation { get;set; }   // Pension.Pen_DateLiquidation

      [Column("Pen_TexteLibre")]
      public string TexteLibre { get;set; }   // Pension.Pen_TexteLibre

      [Column("Pen_PrimeDeces")]
      public string PrimeDeces { get;set; }   // Pension.Pen_PrimeDeces

      [Column("Pen_NoExport")]
      public string NoExport { get;set; }   // Pension.Pen_NoExport

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

      [Column("Dct_JoursOnss")]
      public decimal? JoursOnss { get;set; }   // Pension_Contrat.Dct_JoursOnss

      [Column("Dct_SalaireBrut")]
      public decimal? SalaireBrut { get;set; }   // Pension_Contrat.Dct_SalaireBrut

      [Column("Dct_PrimeInactivite")]
      public decimal? PrimeInactivite { get;set; }   // Pension_Contrat.Dct_PrimeInactivite

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

      [Column("Det45_BeginDate")]
      public DateTime? BeginDate { get;set; }   // Att_A045_DecisionDetail.Det45_BeginDate

      [Column("Det45_EndDate")]
      public DateTime? EndDate { get;set; }   // Att_A045_DecisionDetail.Det45_EndDate

      [Column("Det45_GlobalPercentage")]
      public decimal? GlobalPercentage { get;set; }   // Att_A045_DecisionDetail.Det45_GlobalPercentage

      [Column("Det45_PhysicalPercentage")]
      public decimal? PhysicalPercentage { get;set; }   // Att_A045_DecisionDetail.Det45_PhysicalPercentage

      [Column("Det45_SocioEconomicPercentage")]
      public decimal? SocioEconomicPercentage { get;set; }   // Att_A045_DecisionDetail.Det45_SocioEconomicPercentage

      [Column("Det45_AgePercentage")]
      public decimal? AgePercentage { get;set; }   // Att_A045_DecisionDetail.Det45_AgePercentage

      [Column("Det45_AbsencePercentage")]
      public decimal? AbsencePercentage { get;set; }   // Att_A045_DecisionDetail.Det45_AbsencePercentage

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

      [Column("Att52_Active")]
      public string Active { get;set; }   // Att_A052.Att52_Active

      [Column("Att52_INSS")]
      public string INSS { get;set; }   // Att_A052.Att52_INSS

      [Column("Att52_AttestationID")]
      public string AttestationID { get;set; }   // Att_A052.Att52_AttestationID

      [Column("Att52_SituationNbr")]
      public decimal? SituationNbr { get;set; }   // Att_A052.Att52_SituationNbr

      [Column("Att52_AttestationStatus")]
      public decimal? AttestationStatus { get;set; }   // Att_A052.Att52_AttestationStatus

      [Column("Att52_CreationDate")]
      public DateTime? CreationDate { get;set; }   // Att_A052.Att52_CreationDate

      [Column("Att52_Quarter")]
      public string Quarter { get;set; }   // Att_A052.Att52_Quarter

      [Column("Snd52_Id")]
      public decimal? Snd52Id_Key { get;set; }  // Att_A052.Snd52_Id (ForeignKey)

      [Column("Tra_Id")]
      public decimal? TraId_Key { get;set; }  // Att_A052.Tra_Id (ForeignKey)

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

      [Column("Dcn52_DayType")]
      public string DayType { get;set; }   // Att_A052_DecisionNicCin.Dcn52_DayType

      [Column("Dcn52_DurationUnit")]
      public string DurationUnit { get;set; }   // Att_A052_DecisionNicCin.Dcn52_DurationUnit

      [Column("Dcn52_DurationValue")]
      public decimal? DurationValue { get;set; }   // Att_A052_DecisionNicCin.Dcn52_DurationValue

      [Column("Dcn52_AllowanceType")]
      public string AllowanceType { get;set; }   // Att_A052_DecisionNicCin.Dcn52_AllowanceType

      [Column("Dcn52_KindOfAllowance")]
      public string KindOfAllowance { get;set; }   // Att_A052_DecisionNicCin.Dcn52_KindOfAllowance

      [Column("Dcn52_BeginDate")]
      public DateTime? BeginDate { get;set; }   // Att_A052_DecisionNicCin.Dcn52_BeginDate

      [Column("Dcn52_EndDate")]
      public DateTime? EndDate { get;set; }   // Att_A052_DecisionNicCin.Dcn52_EndDate

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

      [Column("Snd38_Number")]
      public string Number { get;set; }   // Sending_A038.Snd38_Number

      [Column("Snd38_SendingDate")]
      public DateTime? SendingDate { get;set; }   // Sending_A038.Snd38_SendingDate

      [Column("Snd38_CreationDate")]
      public DateTime? CreationDate { get;set; }   // Sending_A038.Snd38_CreationDate

      [Column("Snd38_AttestationCount")]
      public decimal? AttestationCount { get;set; }   // Sending_A038.Snd38_AttestationCount

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

      [Column("Prs_NoAttestation")]
      public string NoAttestation { get;set; }   // Prestation.Prs_NoAttestation

      [Column("Prs_NoSituation")]
      public string NoSituation { get;set; }   // Prestation.Prs_NoSituation

      [Column("Prs_Trimestre")]
      public string Trimestre { get;set; }   // Prestation.Prs_Trimestre

      [Column("Prs_NoLignePrestation")]
      public string NoLignePrestation { get;set; }   // Prestation.Prs_NoLignePrestation

      [Column("Prs_CodePrestation")]
      public string CodePrestation { get;set; }   // Prestation.Prs_CodePrestation

      [Column("Prs_JoursPrestation")]
      public decimal? JoursPrestation { get;set; }   // Prestation.Prs_JoursPrestation

      [Column("Prs_HeuresPrestation")]
      public decimal? HeuresPrestation { get;set; }   // Prestation.Prs_HeuresPrestation

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

      [Column("Anc_Niss")]
      public string Niss { get;set; }   // Anciennete_Contrat.Anc_Niss

      [Column("Anc_Onss")]
      public string Onss { get;set; }   // Anciennete_Contrat.Anc_Onss

      [Column("Anc_NoCalcul")]
      public string NoCalcul { get;set; }   // Anciennete_Contrat.Anc_NoCalcul

      [Column("Anc_TrimestreCalcul")]
      public string TrimestreCalcul { get;set; }   // Anciennete_Contrat.Anc_TrimestreCalcul

      [Column("Anc_DebutDerniereOccup")]
      public DateTime? DebutDerniereOccup { get;set; }   // Anciennete_Contrat.Anc_DebutDerniereOccup

      [Column("Anc_FinDerniereOccup")]
      public DateTime? FinDerniereOccup { get;set; }   // Anciennete_Contrat.Anc_FinDerniereOccup

      [Column("Anc_DateAnciennete")]
      public DateTime? DateAnciennete { get;set; }   // Anciennete_Contrat.Anc_DateAnciennete

      [Column("Anc_IndemniteRupture")]
      public string IndemniteRupture { get;set; }   // Anciennete_Contrat.Anc_IndemniteRupture

      [Column("Anc_Anomalie")]
      public string Anomalie { get;set; }   // Anciennete_Contrat.Anc_Anomalie

      [Column("Anc_RaisonAnomalie")]
      public string RaisonAnomalie { get;set; }   // Anciennete_Contrat.Anc_RaisonAnomalie

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

      [Column("Dcp_CotisationPersonnelle")]
      public decimal? CotisationPersonnelle { get;set; }   // Declaration_CotisationPrepension.Dcp_CotisationPersonnelle

      [Column("Dcp_CotisationPatronale")]
      public decimal? CotisationPatronale { get;set; }   // Declaration_CotisationPrepension.Dcp_CotisationPatronale

      [Column("Dcp_CotisationCompensatoire")]
      public decimal? CotisationCompensatoire { get;set; }   // Declaration_CotisationPrepension.Dcp_CotisationCompensatoire

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

      [Column("Dec_Type")]
      public string Type { get;set; }   // Declaration_Onss.Dec_Type

      [Column("Dec_Trimestre")]
      public string Trimestre { get;set; }   // Declaration_Onss.Dec_Trimestre

      [Column("Dec_Onss")]
      public string Onss { get;set; }   // Declaration_Onss.Dec_Onss

      [Column("Dec_DeclarationPID")]
      public decimal? DeclarationPID { get;set; }   // Declaration_Onss.Dec_DeclarationPID

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

      [Column("Snd45_Number")]
      public string Number { get;set; }   // Sending_A045.Snd45_Number

      [Column("Snd45_SendingDate")]
      public DateTime? SendingDate { get;set; }   // Sending_A045.Snd45_SendingDate

      [Column("Snd45_CreationDate")]
      public DateTime? CreationDate { get;set; }   // Sending_A045.Snd45_CreationDate

      [Column("Snd45_AttestationCount")]
      public decimal? AttestationCount { get;set; }   // Sending_A045.Snd45_AttestationCount

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

      [Column("Snd52_Number")]
      public string Number { get;set; }   // Sending_A052.Snd52_Number

      [Column("Snd52_SendingDate")]
      public DateTime? SendingDate { get;set; }   // Sending_A052.Snd52_SendingDate

      [Column("Snd52_CreationDate")]
      public DateTime? CreationDate { get;set; }   // Sending_A052.Snd52_CreationDate

      [Column("Snd52_AttestationCount")]
      public decimal? AttestationCount { get;set; }   // Sending_A052.Snd52_AttestationCount

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

      [Column("Bat_Type")]
      public string Type { get;set; }   // Batch_Schedule_New.Bat_Type

      [Column("Bat_Description")]
      public string Description { get;set; }   // Batch_Schedule_New.Bat_Description

      [Column("Bat_Etat")]
      public string Etat { get;set; }   // Batch_Schedule_New.Bat_Etat

      [Column("Bat_Parametres")]
      public string Parametres { get;set; }   // Batch_Schedule_New.Bat_Parametres

      [Column("Bat_Priorite")]
      public decimal? Priorite { get;set; }   // Batch_Schedule_New.Bat_Priorite

      [Column("Bat_DatePlanifiee")]
      public DateTime? DatePlanifiee { get;set; }   // Batch_Schedule_New.Bat_DatePlanifiee

      [Column("Bat_DateDebutExecution")]
      public DateTime? DateDebutExecution { get;set; }   // Batch_Schedule_New.Bat_DateDebutExecution

      [Column("Bat_DateFinExecution")]
      public DateTime? DateFinExecution { get;set; }   // Batch_Schedule_New.Bat_DateFinExecution

      [Column("Bat_Erreur")]
      public string Erreur { get;set; }   // Batch_Schedule_New.Bat_Erreur

      [Column("Bat_SqlText")]
      public string SqlText { get;set; }   // Batch_Schedule_New.Bat_SqlText

      [Column("Bat_Keywords")]
      public string Keywords { get;set; }   // Batch_Schedule_New.Bat_Keywords

      [Column("Bat_NombreTotal")]
      public decimal? NombreTotal { get;set; }   // Batch_Schedule_New.Bat_NombreTotal

      [Column("Bat_NombreTraites")]
      public decimal? NombreTraites { get;set; }   // Batch_Schedule_New.Bat_NombreTraites

      [Column("Bat_NombreErreurs")]
      public decimal? NombreErreurs { get;set; }   // Batch_Schedule_New.Bat_NombreErreurs

      [Column("Bat_NomFichierLog")]
      public string NomFichierLog { get;set; }   // Batch_Schedule_New.Bat_NomFichierLog

      [Column("Bat_WebApp")]
      public decimal? WebApp { get;set; }   // Batch_Schedule_New.Bat_WebApp

      [Column("Bat_UserLogin")]
      public string UserLogin { get;set; }   // Batch_Schedule_New.Bat_UserLogin

   }

   [Table("Prime_Contrat")]
   public partial class Prime_Contrat
   {

      [Key]
      [Column("Pct_Id")]
      public decimal ID { get;set; }  // Prime_Contrat.Pct_Id (PrimaryKey)

      [Column("Pct_Exercice")]
      public string Exercice { get;set; }   // Prime_Contrat.Pct_Exercice

      [Column("Pct_Niss")]
      public string Niss { get;set; }   // Prime_Contrat.Pct_Niss

      [Column("Pct_ONSS")]
      public string ONSS { get;set; }   // Prime_Contrat.Pct_ONSS

      [Column("Pct_SalaireReel")]
      public decimal? SalaireReel { get;set; }   // Prime_Contrat.Pct_SalaireReel

      [Column("Pct_SalaireAssimile")]
      public decimal? SalaireAssimile { get;set; }   // Prime_Contrat.Pct_SalaireAssimile

      [Column("Pct_JoursPrestes")]
      public decimal? JoursPrestes { get;set; }   // Prime_Contrat.Pct_JoursPrestes

      [Column("Pct_JoursVacances")]
      public decimal? JoursVacances { get;set; }   // Prime_Contrat.Pct_JoursVacances

      [Column("Pct_JoursMaladie")]
      public decimal? JoursMaladie { get;set; }   // Prime_Contrat.Pct_JoursMaladie

      [Column("Pct_JoursMaternite")]
      public decimal? JoursMaternite { get;set; }   // Prime_Contrat.Pct_JoursMaternite

      [Column("Pct_JoursAssimiles")]
      public decimal? JoursAssimiles { get;set; }   // Prime_Contrat.Pct_JoursAssimiles

      [Column("Pct_PrimeBrute")]
      public decimal? PrimeBrute { get;set; }   // Prime_Contrat.Pct_PrimeBrute

      [Column("Pct_RetenueONSS")]
      public decimal? RetenueONSS { get;set; }   // Prime_Contrat.Pct_RetenueONSS

      [Column("Pct_BaseImposable")]
      public decimal? BaseImposable { get;set; }   // Prime_Contrat.Pct_BaseImposable

      [Column("Pct_RetenueFiscale")]
      public decimal? RetenueFiscale { get;set; }   // Prime_Contrat.Pct_RetenueFiscale

      [Column("Pct_PrimeNette")]
      public decimal? PrimeNette { get;set; }   // Prime_Contrat.Pct_PrimeNette

      [Column("Pct_SFJCalcule")]
      public decimal? SFJCalcule { get;set; }   // Prime_Contrat.Pct_SFJCalcule

      [Column("Pct_SFJManuel")]
      public decimal? SFJManuel { get;set; }   // Prime_Contrat.Pct_SFJManuel

      [Column("Pct_SalaireReelT1")]
      public decimal? SalaireReelT1 { get;set; }   // Prime_Contrat.Pct_SalaireReelT1

      [Column("Pct_SalaireReelT2")]
      public decimal? SalaireReelT2 { get;set; }   // Prime_Contrat.Pct_SalaireReelT2

      [Column("Pct_SalaireReelT3")]
      public decimal? SalaireReelT3 { get;set; }   // Prime_Contrat.Pct_SalaireReelT3

      [Column("Pct_SalaireReelT4")]
      public decimal? SalaireReelT4 { get;set; }   // Prime_Contrat.Pct_SalaireReelT4

      [Column("Pct_JoursPrestesT1")]
      public decimal? JoursPrestesT1 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT1

      [Column("Pct_JoursPrestesT2")]
      public decimal? JoursPrestesT2 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT2

      [Column("Pct_JoursPrestesT3")]
      public decimal? JoursPrestesT3 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT3

      [Column("Pct_JoursPrestesT4")]
      public decimal? JoursPrestesT4 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT4

      [Column("Pct_NombreCasT1")]
      public decimal? NombreCasT1 { get;set; }   // Prime_Contrat.Pct_NombreCasT1

      [Column("Pct_NombreCasT2")]
      public decimal? NombreCasT2 { get;set; }   // Prime_Contrat.Pct_NombreCasT2

      [Column("Pct_NombreCasT3")]
      public decimal? NombreCasT3 { get;set; }   // Prime_Contrat.Pct_NombreCasT3

      [Column("Pct_NombreCasT4")]
      public decimal? NombreCasT4 { get;set; }   // Prime_Contrat.Pct_NombreCasT4

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

      [Column("Muo_ONSSOrigine")]
      public string ONSSOrigine { get;set; }   // Mutation_ONSS.Muo_ONSSOrigine

      [Column("Muo_ONSSDestination")]
      public string ONSSDestination { get;set; }   // Mutation_ONSS.Muo_ONSSDestination

      [Column("Muo_BCEOrigine")]
      public string BCEOrigine { get;set; }   // Mutation_ONSS.Muo_BCEOrigine

      [Column("Muo_BCEDestination")]
      public string BCEDestination { get;set; }   // Mutation_ONSS.Muo_BCEDestination

      [Column("Muo_DateMutation")]
      public DateTime? DateMutation { get;set; }   // Mutation_ONSS.Muo_DateMutation

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

      [Column("Rem_NoAttestation")]
      public string NoAttestation { get;set; }   // Remuneration.Rem_NoAttestation

      [Column("Rem_NoSituation")]
      public string NoSituation { get;set; }   // Remuneration.Rem_NoSituation

      [Column("Rem_Trimestre")]
      public string Trimestre { get;set; }   // Remuneration.Rem_Trimestre

      [Column("Rem_NoLigneRemuneration")]
      public string NoLigneRemuneration { get;set; }   // Remuneration.Rem_NoLigneRemuneration

      [Column("Rem_CodeRemuneration")]
      public string CodeRemuneration { get;set; }   // Remuneration.Rem_CodeRemuneration

      [Column("Rem_SalaireBrut")]
      public decimal? SalaireBrut { get;set; }   // Remuneration.Rem_SalaireBrut

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

      [Column("Ptr_Exercice")]
      public string Exercice { get;set; }   // Prime_Travailleur.Ptr_Exercice

      [Column("Ptr_Niss")]
      public string Niss { get;set; }   // Prime_Travailleur.Ptr_Niss

      [Column("Ptr_SalaireReel")]
      public decimal? SalaireReel { get;set; }   // Prime_Travailleur.Ptr_SalaireReel

      [Column("Ptr_SalaireAssimile")]
      public decimal? SalaireAssimile { get;set; }   // Prime_Travailleur.Ptr_SalaireAssimile

      [Column("Ptr_JoursPrestes")]
      public decimal? JoursPrestes { get;set; }   // Prime_Travailleur.Ptr_JoursPrestes

      [Column("Ptr_JoursVacances")]
      public decimal? JoursVacances { get;set; }   // Prime_Travailleur.Ptr_JoursVacances

      [Column("Ptr_JoursMaladie")]
      public decimal? JoursMaladie { get;set; }   // Prime_Travailleur.Ptr_JoursMaladie

      [Column("Ptr_JoursMaternite")]
      public decimal? JoursMaternite { get;set; }   // Prime_Travailleur.Ptr_JoursMaternite

      [Column("Ptr_JoursAssimiles")]
      public decimal? JoursAssimiles { get;set; }   // Prime_Travailleur.Ptr_JoursAssimiles

      [Column("Ptr_PrimeBrute")]
      public decimal? PrimeBrute { get;set; }   // Prime_Travailleur.Ptr_PrimeBrute

      [Column("Ptr_RetenueONSS")]
      public decimal? RetenueONSS { get;set; }   // Prime_Travailleur.Ptr_RetenueONSS

      [Column("Ptr_BaseImposable")]
      public decimal? BaseImposable { get;set; }   // Prime_Travailleur.Ptr_BaseImposable

      [Column("Ptr_Frontalier")]
      public string Frontalier { get;set; }   // Prime_Travailleur.Ptr_Frontalier

      [Column("Ptr_RetenueFiscale")]
      public decimal? RetenueFiscale { get;set; }   // Prime_Travailleur.Ptr_RetenueFiscale

      [Column("Ptr_PrimeNette")]
      public decimal? PrimeNette { get;set; }   // Prime_Travailleur.Ptr_PrimeNette

      [Column("Ptr_PrimeSyndicale")]
      public decimal? PrimeSyndicale { get;set; }   // Prime_Travailleur.Ptr_PrimeSyndicale

      [Column("Ptr_PrimeFormation")]
      public decimal? PrimeFormation { get;set; }   // Prime_Travailleur.Ptr_PrimeFormation

      [Column("Ptr_SoldePayable")]
      public decimal? SoldePayable { get;set; }   // Prime_Travailleur.Ptr_SoldePayable

      [Column("Ptr_BaseCalculSaisie")]
      public decimal? BaseCalculSaisie { get;set; }   // Prime_Travailleur.Ptr_BaseCalculSaisie

      [Column("Ptr_TotalPaiements")]
      public decimal? TotalPaiements { get;set; }   // Prime_Travailleur.Ptr_TotalPaiements

      [Column("Ptr_SoldeSaisissable")]
      public decimal? SoldeSaisissable { get;set; }   // Prime_Travailleur.Ptr_SoldeSaisissable

      [Column("Ptr_DateCalcul")]
      public DateTime? DateCalcul { get;set; }   // Prime_Travailleur.Ptr_DateCalcul

      [Column("Ptr_DerogationPfa")]
      public string DerogationPfa { get;set; }   // Prime_Travailleur.Ptr_DerogationPfa

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

      [Column("Dtv_Active")]
      public string Active { get;set; }   // Declaration_Travailleur.Dtv_Active

      [Column("Dtv_Trimestre")]
      public string Trimestre { get;set; }   // Declaration_Travailleur.Dtv_Trimestre

      [Column("Dtv_Niss")]
      public string Niss { get;set; }   // Declaration_Travailleur.Dtv_Niss

      [Column("Dtv_Onss")]
      public string Onss { get;set; }   // Declaration_Travailleur.Dtv_Onss

      [Column("Dtv_CodeTravailleur")]
      public string CodeTravailleur { get;set; }   // Declaration_Travailleur.Dtv_CodeTravailleur

      [Column("Dtv_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Declaration_Travailleur.Dtv_CategorieEmployeur

      [Column("Dtv_CodeAction")]
      public string CodeAction { get;set; }   // Declaration_Travailleur.Dtv_CodeAction

      [Column("Dtv_TravailleurPID")]
      public decimal? TravailleurPID { get;set; }   // Declaration_Travailleur.Dtv_TravailleurPID

      [Column("Dtv_TravailleurDeclarePID")]
      public decimal? TravailleurDeclarePID { get;set; }   // Declaration_Travailleur.Dtv_TravailleurDeclarePID

      [Column("Dtv_TravailleurDeclareNoVersion")]
      public decimal? TravailleurDeclareNoVersion { get;set; }   // Declaration_Travailleur.Dtv_TravailleurDeclareNoVersion

      [Column("Dtv_NoVersionLTR")]
      public decimal? NoVersionLTR { get;set; }   // Declaration_Travailleur.Dtv_NoVersionLTR

      [Column("Dtv_FichierDMFA")]
      public string FichierDMFA { get;set; }   // Declaration_Travailleur.Dtv_FichierDMFA

      [Column("Dtv_DateInjectionDMFA")]
      public DateTime? DateInjectionDMFA { get;set; }   // Declaration_Travailleur.Dtv_DateInjectionDMFA

      [Column("Dtv_FichierPID")]
      public string FichierPID { get;set; }   // Declaration_Travailleur.Dtv_FichierPID

      [Column("Dtv_DateInjectionPID")]
      public DateTime? DateInjectionPID { get;set; }   // Declaration_Travailleur.Dtv_DateInjectionPID

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

      [Column("Tit_Etat")]
      public string Etat { get;set; }   // Titre.Tit_Etat

      [Column("Tit_DateEmission")]
      public DateTime? DateEmission { get;set; }   // Titre.Tit_DateEmission

      [Column("Tit_DateRetour")]
      public DateTime? DateRetour { get;set; }   // Titre.Tit_DateRetour

      [Column("Tit_DateExecution")]
      public DateTime? DateExecution { get;set; }   // Titre.Tit_DateExecution

      [Column("Tit_SalaireReel")]
      public decimal? SalaireReel { get;set; }   // Titre.Tit_SalaireReel

      [Column("Tit_SalaireAssimile")]
      public decimal? SalaireAssimile { get;set; }   // Titre.Tit_SalaireAssimile

      [Column("Tit_JoursPrestes")]
      public decimal? JoursPrestes { get;set; }   // Titre.Tit_JoursPrestes

      [Column("Tit_JoursVacances")]
      public decimal? JoursVacances { get;set; }   // Titre.Tit_JoursVacances

      [Column("Tit_JoursMaladie")]
      public decimal? JoursMaladie { get;set; }   // Titre.Tit_JoursMaladie

      [Column("Tit_JoursMaternite")]
      public decimal? JoursMaternite { get;set; }   // Titre.Tit_JoursMaternite

      [Column("Tit_JoursAssimiles")]
      public decimal? JoursAssimiles { get;set; }   // Titre.Tit_JoursAssimiles

      [Column("Tit_PrimeBrute")]
      public decimal? PrimeBrute { get;set; }   // Titre.Tit_PrimeBrute

      [Column("Tit_RetenueONSS")]
      public decimal? RetenueONSS { get;set; }   // Titre.Tit_RetenueONSS

      [Column("Tit_BaseImposable")]
      public decimal? BaseImposable { get;set; }   // Titre.Tit_BaseImposable

      [Column("Tit_RetenueFiscale")]
      public decimal? RetenueFiscale { get;set; }   // Titre.Tit_RetenueFiscale

      [Column("Tit_PrimeNette")]
      public decimal? PrimeNette { get;set; }   // Titre.Tit_PrimeNette

      [Column("Tit_PrimeFormation")]
      public decimal? PrimeFormation { get;set; }   // Titre.Tit_PrimeFormation

      [Column("Tit_PrimeSyndicale")]
      public decimal? PrimeSyndicale { get;set; }   // Titre.Tit_PrimeSyndicale

      [Column("Tit_CodeSyndical")]
      public string CodeSyndical { get;set; }   // Titre.Tit_CodeSyndical

      [Column("Tit_FraisAdministratifs")]
      public decimal? FraisAdministratifs { get;set; }   // Titre.Tit_FraisAdministratifs

      [Column("Tit_Commentaire")]
      public string Commentaire { get;set; }   // Titre.Tit_Commentaire

      [Column("Tit_MontantPaye")]
      public decimal? MontantPaye { get;set; }   // Titre.Tit_MontantPaye

      [Column("Tit_DateDuplicata")]
      public DateTime? DateDuplicata { get;set; }   // Titre.Tit_DateDuplicata

      [Column("Tit_NissOrigine")]
      public string NissOrigine { get;set; }   // Titre.Tit_NissOrigine

      [Column("Tit_AdresseRue")]
      public string AdresseRue { get;set; }   // Titre.Tit_AdresseRue

      [Column("Tit_AdresseNo")]
      public string AdresseNo { get;set; }   // Titre.Tit_AdresseNo

      [Column("Tit_AdresseBte")]
      public string AdresseBte { get;set; }   // Titre.Tit_AdresseBte

      [Column("Tit_CodePostal")]
      public string CodePostal { get;set; }   // Titre.Tit_CodePostal

      [Column("Tit_Localite")]
      public string Localite { get;set; }   // Titre.Tit_Localite

      [Column("Tit_CodePays")]
      public string CodePays { get;set; }   // Titre.Tit_CodePays

      [Column("Ptr_Id")]
      public decimal? PtrId_Key { get;set; }  // Titre.Ptr_Id (ForeignKey)

      [Column("Lot_Id")]
      public decimal? LotId_Key { get;set; }  // Titre.Lot_Id (ForeignKey)

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

      [Column("Dtr_JoursOnss")]
      public decimal? JoursOnss { get;set; }   // Pension_Travailleur.Dtr_JoursOnss

      [Column("Dtr_ExportJoursOnss")]
      public decimal? ExportJoursOnss { get;set; }   // Pension_Travailleur.Dtr_ExportJoursOnss

      [Column("Dtr_DeltaJoursOnss")]
      public decimal? DeltaJoursOnss { get;set; }   // Pension_Travailleur.Dtr_DeltaJoursOnss

      [Column("Dtr_SalaireBrut")]
      public decimal? SalaireBrut { get;set; }   // Pension_Travailleur.Dtr_SalaireBrut

      [Column("Dtr_ExportSalaireBrut")]
      public decimal? ExportSalaireBrut { get;set; }   // Pension_Travailleur.Dtr_ExportSalaireBrut

      [Column("Dtr_DeltaSalaireBrut")]
      public decimal? DeltaSalaireBrut { get;set; }   // Pension_Travailleur.Dtr_DeltaSalaireBrut

      [Column("Dtr_PrimeInactivite")]
      public decimal? PrimeInactivite { get;set; }   // Pension_Travailleur.Dtr_PrimeInactivite

      [Column("Dtr_ExportPrimeInactivite")]
      public decimal? ExportPrimeInactivite { get;set; }   // Pension_Travailleur.Dtr_ExportPrimeInactivite

      [Column("Dtr_DeltaPrimeInactivite")]
      public decimal? DeltaPrimeInactivite { get;set; }   // Pension_Travailleur.Dtr_DeltaPrimeInactivite

      [Column("Dtr_PrimeDeces")]
      public string PrimeDeces { get;set; }   // Pension_Travailleur.Dtr_PrimeDeces

      [Column("Dtr_Etat")]
      public string Etat { get;set; }   // Pension_Travailleur.Dtr_Etat

      [Column("Dtr_DateEtat")]
      public DateTime? DateEtat { get;set; }   // Pension_Travailleur.Dtr_DateEtat

      [Column("Dtr_TexteLibre")]
      public string TexteLibre { get;set; }   // Pension_Travailleur.Dtr_TexteLibre

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

      [Column("Dia_Trimestre")]
      public string Trimestre { get;set; }   // Demande_Intervention_Automatique.Dia_Trimestre

      [Column("Dia_NumeroFolio")]
      public string NumeroFolio { get;set; }   // Demande_Intervention_Automatique.Dia_NumeroFolio

      [Column("Dia_TypeDemande")]
      public string TypeDemande { get;set; }   // Demande_Intervention_Automatique.Dia_TypeDemande

      [Required]
      [Column("Dia_DebutPeriode")]
      public DateTime DebutPeriode { get;set; }   // Demande_Intervention_Automatique.Dia_DebutPeriode

      [Required]
      [Column("Dia_FinPeriode")]
      public DateTime FinPeriode { get;set; }   // Demande_Intervention_Automatique.Dia_FinPeriode

      [Column("Dia_Etat")]
      public string Etat { get;set; }   // Demande_Intervention_Automatique.Dia_Etat

      [Required]
      [Column("Dia_DateEtat")]
      public DateTime DateEtat { get;set; }   // Demande_Intervention_Automatique.Dia_DateEtat

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

      [Column("Aem_ONSS")]
      public string ONSS { get;set; }   // Activite_Employeur.Aem_ONSS

      [Column("Aem_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Activite_Employeur.Aem_CategorieEmployeur

      [Column("Aem_DateAffiliation")]
      public DateTime? DateAffiliation { get;set; }   // Activite_Employeur.Aem_DateAffiliation

      [Column("Aem_DateSuppression")]
      public DateTime? DateSuppression { get;set; }   // Activite_Employeur.Aem_DateSuppression

      [Column("Aem_DateMatricule")]
      public DateTime? DateMatricule { get;set; }   // Activite_Employeur.Aem_DateMatricule

      [Column("Aem_DateRadiation")]
      public DateTime? DateRadiation { get;set; }   // Activite_Employeur.Aem_DateRadiation

      [Column("Aem_CodeNACE")]
      public string CodeNACE { get;set; }   // Activite_Employeur.Aem_CodeNACE

      [Column("Aem_CodeImportance")]
      public string CodeImportance { get;set; }   // Activite_Employeur.Aem_CodeImportance

      [Column("Emp_ID")]
      public decimal EmpId_Key { get;set; }  // Activite_Employeur.Emp_ID (ForeignKey)

      [Column("Fnd_ID")]
      public decimal? FndId_Key { get;set; }  // Activite_Employeur.Fnd_ID (ForeignKey)

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

      [Column("Bat_Type")]
      public string Type { get;set; }   // Batch_Schedule.Bat_Type

      [Column("Bat_Description")]
      public string Description { get;set; }   // Batch_Schedule.Bat_Description

      [Column("Bat_Etat")]
      public string Etat { get;set; }   // Batch_Schedule.Bat_Etat

      [Column("Bat_SqlState")]
      public string SqlState { get;set; }   // Batch_Schedule.Bat_SqlState

      [Column("Bat_SqlState3")]
      public string SqlState3 { get;set; }   // Batch_Schedule.Bat_SqlState3

      [Column("Bat_SqlState2")]
      public string SqlState2 { get;set; }   // Batch_Schedule.Bat_SqlState2

      [Column("Bat_Parametres")]
      public string Parametres { get;set; }   // Batch_Schedule.Bat_Parametres

      [Column("Bat_Priorite")]
      public decimal? Priorite { get;set; }   // Batch_Schedule.Bat_Priorite

      [Column("Bat_DatePlanifiee")]
      public DateTime? DatePlanifiee { get;set; }   // Batch_Schedule.Bat_DatePlanifiee

      [Column("Bat_DateDebutExecution")]
      public DateTime? DateDebutExecution { get;set; }   // Batch_Schedule.Bat_DateDebutExecution

      [Column("Bat_DateFinExecution")]
      public DateTime? DateFinExecution { get;set; }   // Batch_Schedule.Bat_DateFinExecution

      [Column("Bat_Erreur")]
      public string Erreur { get;set; }   // Batch_Schedule.Bat_Erreur

      [Column("Bat_SqlText")]
      public string SqlText { get;set; }   // Batch_Schedule.Bat_SqlText

      [Column("Bat_Keywords")]
      public string Keywords { get;set; }   // Batch_Schedule.Bat_Keywords

   }

   [Table("Fiche_Pension")]
   public partial class Fiche_Pension
   {

      [Key]
      [Column("Fpe_ID")]
      public decimal ID { get;set; }  // Fiche_Pension.Fpe_ID (PrimaryKey)

      [Column("Fpe_DateReference")]
      public DateTime? DateReference { get;set; }   // Fiche_Pension.Fpe_DateReference

      [Column("Fpe_Exercice")]
      public string Exercice { get;set; }   // Fiche_Pension.Fpe_Exercice

      [Column("Fpe_SalaireBrut")]
      public decimal? SalaireBrut { get;set; }   // Fiche_Pension.Fpe_SalaireBrut

      [Column("Fpe_PrimePension")]
      public decimal? PrimePension { get;set; }   // Fiche_Pension.Fpe_PrimePension

      [Column("Fpe_PrimeSolidarite")]
      public decimal? PrimeSolidarite { get;set; }   // Fiche_Pension.Fpe_PrimeSolidarite

      [Column("Fpe_ReserveAcquise")]
      public decimal? ReserveAcquise { get;set; }   // Fiche_Pension.Fpe_ReserveAcquise

      [Column("Fpe_GarantieMinimale")]
      public decimal? GarantieMinimale { get;set; }   // Fiche_Pension.Fpe_GarantieMinimale

      [Column("Fpe_EcheanceContrat")]
      public DateTime? EcheanceContrat { get;set; }   // Fiche_Pension.Fpe_EcheanceContrat

      [Column("Fpe_CapitalAcquis")]
      public decimal? CapitalAcquis { get;set; }   // Fiche_Pension.Fpe_CapitalAcquis

      [Column("Fpe_AgePension")]
      public decimal? AgePension { get;set; }   // Fiche_Pension.Fpe_AgePension

      [Column("Fpe_EstimationCapital")]
      public decimal? EstimationCapital { get;set; }   // Fiche_Pension.Fpe_EstimationCapital

      [Column("Fpe_RenteAnuelle")]
      public decimal? RenteAnuelle { get;set; }   // Fiche_Pension.Fpe_RenteAnuelle

      [Column("Fpe_Etat")]
      public string Etat { get;set; }   // Fiche_Pension.Fpe_Etat

      [Column("Fpe_DateEtat")]
      public DateTime? DateEtat { get;set; }   // Fiche_Pension.Fpe_DateEtat

      [Column("Fpe_Rue")]
      public string Rue { get;set; }   // Fiche_Pension.Fpe_Rue

      [Column("Fpe_No")]
      public string No { get;set; }   // Fiche_Pension.Fpe_No

      [Column("Fpe_Bte")]
      public string Bte { get;set; }   // Fiche_Pension.Fpe_Bte

      [Column("Fpe_CodePostal")]
      public string CodePostal { get;set; }   // Fiche_Pension.Fpe_CodePostal

      [Column("Fpe_Localite")]
      public string Localite { get;set; }   // Fiche_Pension.Fpe_Localite

      [Column("Fpe_CodePays")]
      public string CodePays { get;set; }   // Fiche_Pension.Fpe_CodePays

      [Column("Fpe_DateNaissance")]
      public DateTime? DateNaissance { get;set; }   // Fiche_Pension.Fpe_DateNaissance

      [Column("Fpe_CorrectionSalaire")]
      public decimal? CorrectionSalaire { get;set; }   // Fiche_Pension.Fpe_CorrectionSalaire

      [Column("Fpe_DateReferencePcd")]
      public DateTime? DateReferencePcd { get;set; }   // Fiche_Pension.Fpe_DateReferencePcd

      [Column("Fpe_ReserveAcquisePcd")]
      public decimal? ReserveAcquisePcd { get;set; }   // Fiche_Pension.Fpe_ReserveAcquisePcd

      [Column("Fpe_ParticipationBeneficiaire")]
      public decimal? ParticipationBeneficiaire { get;set; }   // Fiche_Pension.Fpe_ParticipationBeneficiaire

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

      [Column("Cec_DateDebutValidite")]
      public DateTime? DateDebutValidite { get;set; }   // Categorie_Employeur.Cec_DateDebutValidite

      [Column("Cec_DateFinValidite")]
      public DateTime? DateFinValidite { get;set; }   // Categorie_Employeur.Cec_DateFinValidite

      [Column("Fnd_ID")]
      public decimal? FndId_Key { get;set; }  // Categorie_Employeur.Fnd_ID (ForeignKey)

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

      [Column("Pay_ID")]
      public decimal? PayId { get;set; }   // Cheque.Pay_ID

      [Required]
      [Column("Chq_NoPayement")]
      public string NoPayement { get;set; }   // Cheque.Chq_NoPayement

      [Required]
      [Column("Chq_NoCheque")]
      public string NoCheque { get;set; }   // Cheque.Chq_NoCheque

      [Required]
      [Column("Chq_NISS")]
      public string NISS { get;set; }   // Cheque.Chq_NISS

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

      [Column("Chq_Nom")]
      public string Nom { get;set; }   // Cheque.Chq_Nom

      [Column("Chq_Prenom")]
      public string Prenom { get;set; }   // Cheque.Chq_Prenom

      [Column("Chq_AdresseRue")]
      public string AdresseRue { get;set; }   // Cheque.Chq_AdresseRue

      [Column("Chq_AdresseBte")]
      public string AdresseBte { get;set; }   // Cheque.Chq_AdresseBte

      [Column("Chq_AdresseNo")]
      public string AdresseNo { get;set; }   // Cheque.Chq_AdresseNo

      [Column("Chq_CodePostal")]
      public string CodePostal { get;set; }   // Cheque.Chq_CodePostal

      [Column("Chq_Localite")]
      public string Localite { get;set; }   // Cheque.Chq_Localite

      [Column("Chq_CodePays")]
      public string CodePays { get;set; }   // Cheque.Chq_CodePays

      [Column("Chq_DateEmission")]
      public DateTime? DateEmission { get;set; }   // Cheque.Chq_DateEmission

      [Column("Chq_DateFinValidite")]
      public DateTime? DateFinValidite { get;set; }   // Cheque.Chq_DateFinValidite

      [Column("Chq_Langue")]
      public string Langue { get;set; }   // Cheque.Chq_Langue

      [Column("Chq_PremierPayement")]
      public string PremierPayement { get;set; }   // Cheque.Chq_PremierPayement

   }

   [Table("Cheque_Compteur")]
   public partial class Cheque_Compteur
   {

      [Key]
      [Column("Che_Id")]
      public decimal ID { get;set; }  // Cheque_Compteur.Che_Id (PrimaryKey)

      [Column("Che_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Cheque_Compteur.Che_CompteBancaire

      [Column("Che_Exercice")]
      public string Exercice { get;set; }   // Cheque_Compteur.Che_Exercice

      [Column("Che_Sequence")]
      public decimal? Sequence { get;set; }   // Cheque_Compteur.Che_Sequence

      [Column("Che_Numero")]
      public decimal? Numero { get;set; }   // Cheque_Compteur.Che_Numero

      [Column("Che_NumeroMin")]
      public decimal? NumeroMin { get;set; }   // Cheque_Compteur.Che_NumeroMin

      [Column("Che_NumeroMax")]
      public decimal? NumeroMax { get;set; }   // Cheque_Compteur.Che_NumeroMax

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

      [Column("Ass_NoAttestation")]
      public string NoAttestation { get;set; }   // Assimilation.Ass_NoAttestation

      [Column("Ass_NoSituation")]
      public string NoSituation { get;set; }   // Assimilation.Ass_NoSituation

      [Column("Ass_Trimestre")]
      public string Trimestre { get;set; }   // Assimilation.Ass_Trimestre

      [Column("Ass_CodePrestation")]
      public string CodePrestation { get;set; }   // Assimilation.Ass_CodePrestation

      [Column("Ass_Etat")]
      public string Etat { get;set; }   // Assimilation.Ass_Etat

      [Column("Ass_JoursAttribues")]
      public decimal? JoursAttribues { get;set; }   // Assimilation.Ass_JoursAttribues

      [Column("Ass_DateAttribution")]
      public DateTime? DateAttribution { get;set; }   // Assimilation.Ass_DateAttribution

      [Column("Ass_Gestionnaire")]
      public string Gestionnaire { get;set; }   // Assimilation.Ass_Gestionnaire

      [Column("Ass_TextLibre")]
      public string TextLibre { get;set; }   // Assimilation.Ass_TextLibre

      [Column("Ass_F2PJoursAttribues")]
      public decimal? F2PJoursAttribues { get;set; }   // Assimilation.Ass_F2PJoursAttribues

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

      [Column("Con_NISS")]
      public string NISS { get;set; }   // Contrat.Con_NISS

      [Column("Con_ONSS")]
      public string ONSS { get;set; }   // Contrat.Con_ONSS

      [Column("Con_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Contrat.Con_CategorieEmployeur

      [Column("Con_CodeTravailleur")]
      public string CodeTravailleur { get;set; }   // Contrat.Con_CodeTravailleur

      [Column("Con_ComiteParitaire")]
      public string ComiteParitaire { get;set; }   // Contrat.Con_ComiteParitaire

      [Column("Con_DateEntree")]
      public DateTime? DateEntree { get;set; }   // Contrat.Con_DateEntree

      [Column("Con_DateSortie")]
      public DateTime? DateSortie { get;set; }   // Contrat.Con_DateSortie

      [Column("Con_NumeroMatricule")]
      public string NumeroMatricule { get;set; }   // Contrat.Con_NumeroMatricule

      [Column("Con_Division")]
      public string Division { get;set; }   // Contrat.Con_Division

      [Column("Con_TravailContinu")]
      public string TravailContinu { get;set; }   // Contrat.Con_TravailContinu

      [Column("Con_DatePrepension")]
      public DateTime? DatePrepension { get;set; }   // Contrat.Con_DatePrepension

      [Column("Con_DatePension")]
      public DateTime? DatePension { get;set; }   // Contrat.Con_DatePension

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

      [Column("D37_CodeChomage")]
      public string CodeChomage { get;set; }   // Drs_A037ChomageTemporaire.D37_CodeChomage

      [Column("D37_UniteDureePayee")]
      public string UniteDureePayee { get;set; }   // Drs_A037ChomageTemporaire.D37_UniteDureePayee

      [Column("D37_ValeurDureePayee")]
      public decimal? ValeurDureePayee { get;set; }   // Drs_A037ChomageTemporaire.D37_ValeurDureePayee

      [Column("D37_NbrAllocationPayee")]
      public decimal? NbrAllocationPayee { get;set; }   // Drs_A037ChomageTemporaire.D37_NbrAllocationPayee

      [Column("D37_UniteDureeRefusee")]
      public string UniteDureeRefusee { get;set; }   // Drs_A037ChomageTemporaire.D37_UniteDureeRefusee

      [Column("D37_ValeurDureeRefusee")]
      public decimal? ValeurDureeRefusee { get;set; }   // Drs_A037ChomageTemporaire.D37_ValeurDureeRefusee

      [Column("D37_NbrAllocationRefusee")]
      public decimal? NbrAllocationRefusee { get;set; }   // Drs_A037ChomageTemporaire.D37_NbrAllocationRefusee

      [Column("D37_NbrAllocationRefuseeAutre")]
      public decimal? NbrAllocationRefuseeAutre { get;set; }   // Drs_A037ChomageTemporaire.D37_NbrAllocationRefuseeAutre

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

      [Column("Drs_Type")]
      public string Type { get;set; }   // Drs_Envoi.Drs_Type

      [Column("Drs_NomFichier")]
      public string NomFichier { get;set; }   // Drs_Envoi.Drs_NomFichier

      [Column("Drs_DateInjection")]
      public DateTime? DateInjection { get;set; }   // Drs_Envoi.Drs_DateInjection

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

      [Column("Lot_Numero")]
      public string Numero { get;set; }   // Decompte_Lot.Lot_Numero

      [Column("Lot_NombreTitres")]
      public decimal? NombreTitres { get;set; }   // Decompte_Lot.Lot_NombreTitres

      [Column("Lot_Salaires")]
      public decimal? Salaires { get;set; }   // Decompte_Lot.Lot_Salaires

      [Column("Lot_JoursPrestes")]
      public decimal? JoursPrestes { get;set; }   // Decompte_Lot.Lot_JoursPrestes

      [Column("Lot_JoursVacances")]
      public decimal? JoursVacances { get;set; }   // Decompte_Lot.Lot_JoursVacances

      [Column("Lot_JoursMaladie")]
      public decimal? JoursMaladie { get;set; }   // Decompte_Lot.Lot_JoursMaladie

      [Column("Lot_JoursMaternite")]
      public decimal? JoursMaternite { get;set; }   // Decompte_Lot.Lot_JoursMaternite

      [Column("Lot_JoursAssimimles")]
      public decimal? JoursAssimimles { get;set; }   // Decompte_Lot.Lot_JoursAssimimles

      [Column("Lot_NbrePrimesSyndicales")]
      public decimal? NbrePrimesSyndicales { get;set; }   // Decompte_Lot.Lot_NbrePrimesSyndicales

      [Column("Lot_TotalPrimesSyndicales")]
      public decimal? TotalPrimesSyndicales { get;set; }   // Decompte_Lot.Lot_TotalPrimesSyndicales

      [Column("Lot_NbrePrimesFormation")]
      public decimal? NbrePrimesFormation { get;set; }   // Decompte_Lot.Lot_NbrePrimesFormation

      [Column("Lot_TotalPrimesFormation")]
      public decimal? TotalPrimesFormation { get;set; }   // Decompte_Lot.Lot_TotalPrimesFormation

      [Column("Lot_TotalBrutPrimes")]
      public decimal? TotalBrutPrimes { get;set; }   // Decompte_Lot.Lot_TotalBrutPrimes

      [Column("Lot_RetenueONSS")]
      public decimal? RetenueONSS { get;set; }   // Decompte_Lot.Lot_RetenueONSS

      [Column("Lot_BaseImposable")]
      public decimal? BaseImposable { get;set; }   // Decompte_Lot.Lot_BaseImposable

      [Column("Lot_RetenueFiscale")]
      public decimal? RetenueFiscale { get;set; }   // Decompte_Lot.Lot_RetenueFiscale

      [Column("Lot_NetAvantFrais")]
      public decimal? NetAvantFrais { get;set; }   // Decompte_Lot.Lot_NetAvantFrais

      [Column("Lot_FraisAdministratifs")]
      public decimal? FraisAdministratifs { get;set; }   // Decompte_Lot.Lot_FraisAdministratifs

      [Column("Lot_Net")]
      public decimal? Net { get;set; }   // Decompte_Lot.Lot_Net

      [Column("Liv_Id")]
      public decimal? LivId_Key { get;set; }  // Decompte_Lot.Liv_Id (ForeignKey)

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

      [Column("Att45_Active")]
      public string Active { get;set; }   // Att_A045.Att45_Active

      [Column("Att45_INSS")]
      public string INSS { get;set; }   // Att_A045.Att45_INSS

      [Column("Att45_AttestationID")]
      public string AttestationID { get;set; }   // Att_A045.Att45_AttestationID

      [Column("Att45_SituationNbr")]
      public decimal? SituationNbr { get;set; }   // Att_A045.Att45_SituationNbr

      [Column("Att45_AttestationStatus")]
      public decimal? AttestationStatus { get;set; }   // Att_A045.Att45_AttestationStatus

      [Column("Att45_CreationDate")]
      public DateTime? CreationDate { get;set; }   // Att_A045.Att45_CreationDate

      [Column("Att45_Quarter")]
      public string Quarter { get;set; }   // Att_A045.Att45_Quarter

      [Column("Att45_NOSSRegistrationNbr")]
      public string NOSSRegistrationNbr { get;set; }   // Att_A045.Att45_NOSSRegistrationNbr

      [Column("Att45_CompanyID")]
      public string CompanyID { get;set; }   // Att_A045.Att45_CompanyID

      [Column("Att45_EmployerClass")]
      public string EmployerClass { get;set; }   // Att_A045.Att45_EmployerClass

      [Column("Snd45_Id")]
      public decimal? Snd45Id_Key { get;set; }  // Att_A045.Snd45_Id (ForeignKey)

      [Column("Tra_Id")]
      public decimal? TraId_Key { get;set; }  // Att_A045.Tra_Id (ForeignKey)

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

      [Column("Pld_DateReference")]
      public DateTime? DateReference { get;set; }   // Pension_LettreDepart.Pld_DateReference

      [Column("Pld_ReserveAcquise")]
      public decimal? ReserveAcquise { get;set; }   // Pension_LettreDepart.Pld_ReserveAcquise

      [Column("Pld_GarantieMinimale")]
      public decimal? GarantieMinimale { get;set; }   // Pension_LettreDepart.Pld_GarantieMinimale

      [Column("Pld_EcheanceContrat")]
      public DateTime? EcheanceContrat { get;set; }   // Pension_LettreDepart.Pld_EcheanceContrat

      [Column("Pld_CapitalAcquis")]
      public decimal? CapitalAcquis { get;set; }   // Pension_LettreDepart.Pld_CapitalAcquis

      [Column("Pld_Etat")]
      public string Etat { get;set; }   // Pension_LettreDepart.Pld_Etat

      [Column("Pld_DateEtat")]
      public DateTime? DateEtat { get;set; }   // Pension_LettreDepart.Pld_DateEtat

      [Column("Pld_Rue")]
      public string Rue { get;set; }   // Pension_LettreDepart.Pld_Rue

      [Column("Pld_No")]
      public string No { get;set; }   // Pension_LettreDepart.Pld_No

      [Column("Pld_Bte")]
      public string Bte { get;set; }   // Pension_LettreDepart.Pld_Bte

      [Column("Pld_CodePostal")]
      public string CodePostal { get;set; }   // Pension_LettreDepart.Pld_CodePostal

      [Column("Pld_Localite")]
      public string Localite { get;set; }   // Pension_LettreDepart.Pld_Localite

      [Column("Pld_CodePays")]
      public string CodePays { get;set; }   // Pension_LettreDepart.Pld_CodePays

      [Column("Pld_DateNaissance")]
      public DateTime? DateNaissance { get;set; }   // Pension_LettreDepart.Pld_DateNaissance

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

      [Column("Dos_TypeObjet")]
      public decimal? TypeObjet { get;set; }   // Dossier.Dos_TypeObjet

      [Column("Dos_IdObjet")]
      public decimal? IdObjet { get;set; }   // Dossier.Dos_IdObjet

      [Column("Dos_References")]
      public string References { get;set; }   // Dossier.Dos_References

      [Column("Dos_Etat")]
      public string Etat { get;set; }   // Dossier.Dos_Etat

      [Column("Dos_Texte")]
      public string Texte { get;set; }   // Dossier.Dos_Texte

      [Column("Dos_DateCreation")]
      public DateTime? DateCreation { get;set; }   // Dossier.Dos_DateCreation

      [Column("Dos_Auteur")]
      public string Auteur { get;set; }   // Dossier.Dos_Auteur

      [Column("Dos_DateModification")]
      public DateTime? DateModification { get;set; }   // Dossier.Dos_DateModification

   }

   [Table("Livre")]
   public partial class Livre
   {

      [Key]
      [Column("Liv_Id")]
      public decimal ID { get;set; }  // Livre.Liv_Id (PrimaryKey)

      [Column("Liv_Cloture")]
      public string Cloture { get;set; }   // Livre.Liv_Cloture

      [Column("Liv_DateCloture")]
      public DateTime? DateCloture { get;set; }   // Livre.Liv_DateCloture

      [Required]
      [Column("Liv_Numero")]
      public string Numero { get;set; }   // Livre.Liv_Numero

      [Column("Liv_NombreTitres")]
      public decimal? NombreTitres { get;set; }   // Livre.Liv_NombreTitres

      [Column("Liv_Salaires")]
      public decimal? Salaires { get;set; }   // Livre.Liv_Salaires

      [Column("Liv_JoursPrestes")]
      public decimal? JoursPrestes { get;set; }   // Livre.Liv_JoursPrestes

      [Column("Liv_JoursVacances")]
      public decimal? JoursVacances { get;set; }   // Livre.Liv_JoursVacances

      [Column("Liv_JoursMaladie")]
      public decimal? JoursMaladie { get;set; }   // Livre.Liv_JoursMaladie

      [Column("Liv_JoursMaternite")]
      public decimal? JoursMaternite { get;set; }   // Livre.Liv_JoursMaternite

      [Column("Liv_JoursAssimimles")]
      public decimal? JoursAssimimles { get;set; }   // Livre.Liv_JoursAssimimles

      [Column("Liv_NbrePrimesSyndicales")]
      public decimal? NbrePrimesSyndicales { get;set; }   // Livre.Liv_NbrePrimesSyndicales

      [Column("Liv_TotalPrimesSyndicales")]
      public decimal? TotalPrimesSyndicales { get;set; }   // Livre.Liv_TotalPrimesSyndicales

      [Column("Liv_NbrePrimesFormation")]
      public decimal? NbrePrimesFormation { get;set; }   // Livre.Liv_NbrePrimesFormation

      [Column("Liv_TotalPrimesFormation")]
      public decimal? TotalPrimesFormation { get;set; }   // Livre.Liv_TotalPrimesFormation

      [Column("Liv_TotalBrutPrimes")]
      public decimal? TotalBrutPrimes { get;set; }   // Livre.Liv_TotalBrutPrimes

      [Column("Liv_RetenueONSS")]
      public decimal? RetenueONSS { get;set; }   // Livre.Liv_RetenueONSS

      [Column("Liv_BaseImposable")]
      public decimal? BaseImposable { get;set; }   // Livre.Liv_BaseImposable

      [Column("Liv_RetenueFiscale")]
      public decimal? RetenueFiscale { get;set; }   // Livre.Liv_RetenueFiscale

      [Column("Liv_NetAvantFrais")]
      public decimal? NetAvantFrais { get;set; }   // Livre.Liv_NetAvantFrais

      [Column("Liv_FraisAdministratifs")]
      public decimal? FraisAdministratifs { get;set; }   // Livre.Liv_FraisAdministratifs

      [Column("Liv_Net")]
      public decimal? Net { get;set; }   // Livre.Liv_Net

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

      [Column("Col_PrvVal")]
      public string PrvVal { get;set; }   // Historique.Col_PrvVal

      [Column("Col_CurVal")]
      public string CurVal { get;set; }   // Historique.Col_CurVal

      [Column("His_Motivation")]
      public string Motivation { get;set; }   // Historique.His_Motivation

      [Column("Mod_Date")]
      public DateTime? Date { get;set; }   // Historique.Mod_Date

      [Column("Usr_Login")]
      public string Login { get;set; }   // Historique.Usr_Login

   }

   [Table("Intervention")]
   public partial class Intervention
   {

      [Key]
      [Column("Int_Id")]
      public decimal ID { get;set; }  // Intervention.Int_Id (PrimaryKey)

      [Column("Int_FinPeriode")]
      public DateTime? FinPeriode { get;set; }   // Intervention.Int_FinPeriode

      [Column("Int_DebutPeriode")]
      public DateTime? DebutPeriode { get;set; }   // Intervention.Int_DebutPeriode

      [Column("Int_NombreJours")]
      public decimal? NombreJours { get;set; }   // Intervention.Int_NombreJours

      [Column("Int_MontantJournalier")]
      public decimal? MontantJournalier { get;set; }   // Intervention.Int_MontantJournalier

      [Column("Int_BaseImposable")]
      public decimal? BaseImposable { get;set; }   // Intervention.Int_BaseImposable

      [Column("Int_RetenueFiscale")]
      public decimal? RetenueFiscale { get;set; }   // Intervention.Int_RetenueFiscale

      [Column("Int_MontantNet")]
      public decimal? MontantNet { get;set; }   // Intervention.Int_MontantNet

      [Column("Int_Etat")]
      public string Etat { get;set; }   // Intervention.Int_Etat

      [Column("Int_DateLiquidation")]
      public DateTime? DateLiquidation { get;set; }   // Intervention.Int_DateLiquidation

      [Column("Int_Syndicat")]
      public string Syndicat { get;set; }   // Intervention.Int_Syndicat

      [Column("Int_FraisAdministratifs")]
      public decimal? FraisAdministratifs { get;set; }   // Intervention.Int_FraisAdministratifs

      [Column("Int_MontantPayable")]
      public decimal? MontantPayable { get;set; }   // Intervention.Int_MontantPayable

      [Column("Int_MontantBrut")]
      public decimal? MontantBrut { get;set; }   // Intervention.Int_MontantBrut

      [Column("Int_RetenueOnss")]
      public decimal? RetenueOnss { get;set; }   // Intervention.Int_RetenueOnss

      [Column("Int_NombreHeures")]
      public decimal? NombreHeures { get;set; }   // Intervention.Int_NombreHeures

      [Column("Int_MontantHoraire")]
      public decimal? MontantHoraire { get;set; }   // Intervention.Int_MontantHoraire

      [Column("Int_Automatique")]
      public string Automatique { get;set; }   // Intervention.Int_Automatique

      [Column("Dei_Id")]
      public decimal? DeiId_Key { get;set; }  // Intervention.Dei_Id (ForeignKey)

      [Column("Dia_Id")]
      public decimal? DiaId_Key { get;set; }  // Intervention.Dia_Id (ForeignKey)

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

      [Column("Lre_Trimestre")]
      public string Trimestre { get;set; }   // Ligne_Releve.Lre_Trimestre

      [Column("Lre_NISS")]
      public string NISS { get;set; }   // Ligne_Releve.Lre_NISS

      [Column("Lre_ONSS")]
      public string ONSS { get;set; }   // Ligne_Releve.Lre_ONSS

      [Column("Lre_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Ligne_Releve.Lre_CategorieEmployeur

      [Column("Lre_CodeTravailleur")]
      public string CodeTravailleur { get;set; }   // Ligne_Releve.Lre_CodeTravailleur

      [Column("Lre_Active")]
      public string Active { get;set; }   // Ligne_Releve.Lre_Active

      [Column("Lre_Origine")]
      public string Origine { get;set; }   // Ligne_Releve.Lre_Origine

      [Column("Lre_DNRB")]
      public string DNRB { get;set; }   // Ligne_Releve.Lre_DNRB

      [Column("Lre_LSDNR")]
      public string LSDNR { get;set; }   // Ligne_Releve.Lre_LSDNR

      [Column("Lre_DateDebutTrimestre")]
      public DateTime? DateDebutTrimestre { get;set; }   // Ligne_Releve.Lre_DateDebutTrimestre

      [Column("Lre_DateFinTrimestre")]
      public DateTime? DateFinTrimestre { get;set; }   // Ligne_Releve.Lre_DateFinTrimestre

      [Column("Lre_DateCreation")]
      public DateTime? DateCreation { get;set; }   // Ligne_Releve.Lre_DateCreation

      [Column("Lre_Source")]
      public string Source { get;set; }   // Ligne_Releve.Lre_Source

      [Column("Lre_NumeroAgent")]
      public string NumeroAgent { get;set; }   // Ligne_Releve.Lre_NumeroAgent

      [Column("Lre_TexteLibre")]
      public string TexteLibre { get;set; }   // Ligne_Releve.Lre_TexteLibre

      [Column("Lre_ExistenceAMI")]
      public string ExistenceAMI { get;set; }   // Ligne_Releve.Lre_ExistenceAMI

      [Column("Lre_ExistenceChomage")]
      public string ExistenceChomage { get;set; }   // Ligne_Releve.Lre_ExistenceChomage

      [Column("Lre_CodeArchive")]
      public string CodeArchive { get;set; }   // Ligne_Releve.Lre_CodeArchive

      [Column("Lre_ValidationCGER")]
      public string ValidationCGER { get;set; }   // Ligne_Releve.Lre_ValidationCGER

      [Column("Lre_DateInjection")]
      public DateTime? DateInjection { get;set; }   // Ligne_Releve.Lre_DateInjection

      [Column("Lre_motivation")]
      public string Motivation { get;set; }   // Ligne_Releve.Lre_motivation

      [Column("Env_Id")]
      public decimal? EnvId_Key { get;set; }  // Ligne_Releve.Env_Id (ForeignKey)

      [Column("Con_ID")]
      public decimal ConId_Key { get;set; }  // Ligne_Releve.Con_ID (ForeignKey)

      [Column("Pct_Id")]
      public decimal? PctId_Key { get;set; }  // Ligne_Releve.Pct_Id (ForeignKey)

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

      [Column("Loc_NlLocalite")]
      public string NlLocalite { get;set; }   // Localite.Loc_NlLocalite

      [Column("Loc_FrLocalite")]
      public string FrLocalite { get;set; }   // Localite.Loc_FrLocalite

      [Column("Loc_CodeLangue")]
      public string CodeLangue { get;set; }   // Localite.Loc_CodeLangue

      [Column("Loc_CodeRegion")]
      public string CodeRegion { get;set; }   // Localite.Loc_CodeRegion

      [Column("Loc_CentreTri")]
      public string CentreTri { get;set; }   // Localite.Loc_CentreTri

      [Column("Loc_CentreDistribution")]
      public string CentreDistribution { get;set; }   // Localite.Loc_CentreDistribution

      [Column("Loc_CodeProvince")]
      public string CodeProvince { get;set; }   // Localite.Loc_CodeProvince

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

      [Column("Mrq_Parent")]
      public decimal? Parent { get;set; }   // Marque.Mrq_Parent

      [Required]
      [Column("Mrq_Type")]
      public string Type { get;set; }   // Marque.Mrq_Type

      [Required]
      [Column("Mrq_DateCreation")]
      public DateTime DateCreation { get;set; }   // Marque.Mrq_DateCreation

      [Column("Mrq_Motivation")]
      public string Motivation { get;set; }   // Marque.Mrq_Motivation

      [Column("Mrq_Apposeur")]
      public string Apposeur { get;set; }   // Marque.Mrq_Apposeur

      [Column("Mrq_Destinataire")]
      public string Destinataire { get;set; }   // Marque.Mrq_Destinataire

      [Column("Mrq_Etat")]
      public string Etat { get;set; }   // Marque.Mrq_Etat

      [Column("Mrq_Priorite")]
      public string Priorite { get;set; }   // Marque.Mrq_Priorite

      [Column("Mrq_DateDebutValidite")]
      public DateTime? DateDebutValidite { get;set; }   // Marque.Mrq_DateDebutValidite

      [Column("Mrq_DateFinValidite")]
      public DateTime? DateFinValidite { get;set; }   // Marque.Mrq_DateFinValidite

      [Column("Mrq_DatePlanifiee")]
      public DateTime? DatePlanifiee { get;set; }   // Marque.Mrq_DatePlanifiee

      [Column("Mrq_DateExecution")]
      public DateTime? DateExecution { get;set; }   // Marque.Mrq_DateExecution

      [Column("Mrq_TypeValeur1")]
      public string TypeValeur1 { get;set; }   // Marque.Mrq_TypeValeur1

      [Column("Mrq_Valeur1")]
      public string Valeur1 { get;set; }   // Marque.Mrq_Valeur1

      [Column("Mrq_TypeValeur2")]
      public string TypeValeur2 { get;set; }   // Marque.Mrq_TypeValeur2

      [Column("Mrq_Valeur2")]
      public string Valeur2 { get;set; }   // Marque.Mrq_Valeur2

      [Column("Mrq_TypeValeur3")]
      public string TypeValeur3 { get;set; }   // Marque.Mrq_TypeValeur3

      [Column("Mrq_Valeur3")]
      public string Valeur3 { get;set; }   // Marque.Mrq_Valeur3

      [Column("Mrq_Niss")]
      public string Niss { get;set; }   // Marque.Mrq_Niss

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

      [Column("Tra_Nom")]
      public string Nom { get;set; }   // Travailleur.Tra_Nom

      [Column("Tra_Prenom")]
      public string Prenom { get;set; }   // Travailleur.Tra_Prenom

      [Column("Tra_Sexe")]
      public string Sexe { get;set; }   // Travailleur.Tra_Sexe

      [Column("Tra_Langue")]
      public string Langue { get;set; }   // Travailleur.Tra_Langue

      [Column("Tra_DateNaissance")]
      public DateTime? DateNaissance { get;set; }   // Travailleur.Tra_DateNaissance

      [Column("Tra_DateDeces")]
      public DateTime? DateDeces { get;set; }   // Travailleur.Tra_DateDeces

      [Column("Tra_ModePayement")]
      public string ModePayement { get;set; }   // Travailleur.Tra_ModePayement

      [Column("Tra_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Travailleur.Tra_CompteBancaire

      [Column("Tra_AdresseRue")]
      public string AdresseRue { get;set; }   // Travailleur.Tra_AdresseRue

      [Column("Tra_AdresseNo")]
      public string AdresseNo { get;set; }   // Travailleur.Tra_AdresseNo

      [Column("Tra_AdresseBte")]
      public string AdresseBte { get;set; }   // Travailleur.Tra_AdresseBte

      [Column("Tra_CodePostal")]
      public string CodePostal { get;set; }   // Travailleur.Tra_CodePostal

      [Column("Tra_Localite")]
      public string Localite { get;set; }   // Travailleur.Tra_Localite

      [Column("Tra_CodePays")]
      public string CodePays { get;set; }   // Travailleur.Tra_CodePays

      [Column("Tra_Telephone")]
      public string Telephone { get;set; }   // Travailleur.Tra_Telephone

      [Column("Tra_OrigineAdresse")]
      public string OrigineAdresse { get;set; }   // Travailleur.Tra_OrigineAdresse

      [Column("Tra_DateModifAdresse")]
      public DateTime? DateModifAdresse { get;set; }   // Travailleur.Tra_DateModifAdresse

      [Column("Tra_AdresseRueDerog")]
      public string AdresseRueDerog { get;set; }   // Travailleur.Tra_AdresseRueDerog

      [Column("Tra_AdresseNoDerog")]
      public string AdresseNoDerog { get;set; }   // Travailleur.Tra_AdresseNoDerog

      [Column("Tra_AdresseBteDerog")]
      public string AdresseBteDerog { get;set; }   // Travailleur.Tra_AdresseBteDerog

      [Column("Tra_CodePostalDerog")]
      public string CodePostalDerog { get;set; }   // Travailleur.Tra_CodePostalDerog

      [Column("Tra_LocaliteDerog")]
      public string LocaliteDerog { get;set; }   // Travailleur.Tra_LocaliteDerog

      [Column("Tra_CodePaysDerog")]
      public string CodePaysDerog { get;set; }   // Travailleur.Tra_CodePaysDerog

      [Column("Tra_TelephoneDerog")]
      public string TelephoneDerog { get;set; }   // Travailleur.Tra_TelephoneDerog

      [Column("Tra_OrigineDerog")]
      public string OrigineDerog { get;set; }   // Travailleur.Tra_OrigineDerog

      [Column("Tra_DateDebutDerog")]
      public DateTime? DateDebutDerog { get;set; }   // Travailleur.Tra_DateDebutDerog

      [Column("Tra_DateFinDerog")]
      public DateTime? DateFinDerog { get;set; }   // Travailleur.Tra_DateFinDerog

      [Column("Tra_DateModifDerog")]
      public DateTime? DateModifDerog { get;set; }   // Travailleur.Tra_DateModifDerog

      [Column("Tra_CalculManuelRetenue")]
      public string CalculManuelRetenue { get;set; }   // Travailleur.Tra_CalculManuelRetenue

      [Column("Tra_CalculManuelRangCreance")]
      public string CalculManuelRangCreance { get;set; }   // Travailleur.Tra_CalculManuelRangCreance

      [Column("Tra_NbreEnfants")]
      public decimal? NbreEnfants { get;set; }   // Travailleur.Tra_NbreEnfants

      [Column("Tra_NbreHandicapes")]
      public decimal? NbreHandicapes { get;set; }   // Travailleur.Tra_NbreHandicapes

      [Column("Tra_AutresACharge")]
      public decimal? AutresACharge { get;set; }   // Travailleur.Tra_AutresACharge

      [Column("Tra_ConjointACharge")]
      public string ConjointACharge { get;set; }   // Travailleur.Tra_ConjointACharge

      [Column("Tra_RevenusConjoint")]
      public decimal? RevenusConjoint { get;set; }   // Travailleur.Tra_RevenusConjoint

      [Column("Tra_TypeRevenusConjoint")]
      public string TypeRevenusConjoint { get;set; }   // Travailleur.Tra_TypeRevenusConjoint

      [Column("Tra_VeufCelibataire")]
      public string VeufCelibataire { get;set; }   // Travailleur.Tra_VeufCelibataire

      [Column("Tra_AdresseIncomplete")]
      public string AdresseIncomplete { get;set; }   // Travailleur.Tra_AdresseIncomplete

      [Column("Tra_Commentaire")]
      public string Commentaire { get;set; }   // Travailleur.Tra_Commentaire

      [Column("Tra_NissFusion")]
      public string NissFusion { get;set; }   // Travailleur.Tra_NissFusion

      [Column("Tra_Oriolus")]
      public string Oriolus { get;set; }   // Travailleur.Tra_Oriolus

      [Column("Tra_Nationalite")]
      public string Nationalite { get;set; }   // Travailleur.Tra_Nationalite

      [Column("Tra_IBAN")]
      public string IBAN { get;set; }   // Travailleur.Tra_IBAN

      [Column("Tra_BIC")]
      public string BIC { get;set; }   // Travailleur.Tra_BIC

      [Column("Tra_LangueDerog")]
      public string LangueDerog { get;set; }   // Travailleur.Tra_LangueDerog

      [Column("Tra_EtatCivil")]
      public string EtatCivil { get;set; }   // Travailleur.Tra_EtatCivil

      [Column("Tra_DatePension")]
      public DateTime? DatePension { get;set; }   // Travailleur.Tra_DatePension

      [Column("Tra_DateFinDroitPension")]
      public DateTime? DateFinDroitPension { get;set; }   // Travailleur.Tra_DateFinDroitPension

      [Column("Tra_DateNationalite")]
      public DateTime? DateNationalite { get;set; }   // Travailleur.Tra_DateNationalite

      [Column("Tra_PartnerNiss")]
      public string PartnerNiss { get;set; }   // Travailleur.Tra_PartnerNiss

      [Column("Tra_PartnerNom")]
      public string PartnerNom { get;set; }   // Travailleur.Tra_PartnerNom

      [Column("Tra_PartnerPrenom")]
      public string PartnerPrenom { get;set; }   // Travailleur.Tra_PartnerPrenom

      [Column("Tra_CompositionMenage")]
      public string CompositionMenage { get;set; }   // Travailleur.Tra_CompositionMenage

      [Column("Tra_DateInjection")]
      public DateTime? DateInjection { get;set; }   // Travailleur.Tra_DateInjection

      [Column("Tra_RaisonRadiation")]
      public string RaisonRadiation { get;set; }   // Travailleur.Tra_RaisonRadiation

      [Column("Tra_Ter_Id")]
      public decimal? TraTerId_Key { get;set; }  // Travailleur.Tra_Ter_Id (ForeignKey)

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

      [Column("Mas_Trimestre")]
      public string Trimestre { get;set; }   // Mouvement_Assimilation.Mas_Trimestre

      [Column("Mas_DNRB")]
      public string DNRB { get;set; }   // Mouvement_Assimilation.Mas_DNRB

      [Column("Mas_LSDNR")]
      public string LSDNR { get;set; }   // Mouvement_Assimilation.Mas_LSDNR

      [Column("Mas_Periode")]
      public decimal? Periode { get;set; }   // Mouvement_Assimilation.Mas_Periode

      [Column("Mas_Nature")]
      public string Nature { get;set; }   // Mouvement_Assimilation.Mas_Nature

      [Column("Mas_Regime")]
      public string Regime { get;set; }   // Mouvement_Assimilation.Mas_Regime

      [Column("Mas_JoursDeclares")]
      public decimal? JoursDeclares { get;set; }   // Mouvement_Assimilation.Mas_JoursDeclares

      [Column("Mas_DateDebutPeriode")]
      public DateTime? DateDebutPeriode { get;set; }   // Mouvement_Assimilation.Mas_DateDebutPeriode

      [Column("Mas_DateFinPeriode")]
      public DateTime? DateFinPeriode { get;set; }   // Mouvement_Assimilation.Mas_DateFinPeriode

      [Column("Mas_TexteLibre")]
      public string TexteLibre { get;set; }   // Mouvement_Assimilation.Mas_TexteLibre

      [Column("Mas_JoursAttribues")]
      public decimal? JoursAttribues { get;set; }   // Mouvement_Assimilation.Mas_JoursAttribues

      [Column("Mas_Motivation")]
      public string Motivation { get;set; }   // Mouvement_Assimilation.Mas_Motivation

      [Column("Mas_Gestionnaire")]
      public string Gestionnaire { get;set; }   // Mouvement_Assimilation.Mas_Gestionnaire

      [Column("Mas_DateAttribution")]
      public DateTime? DateAttribution { get;set; }   // Mouvement_Assimilation.Mas_DateAttribution

      [Column("Mas_Etat")]
      public string Etat { get;set; }   // Mouvement_Assimilation.Mas_Etat

      [Column("Mas_ModeTraitement")]
      public string ModeTraitement { get;set; }   // Mouvement_Assimilation.Mas_ModeTraitement

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

      [Column("Dis45_KindOfRequest")]
      public string KindOfRequest { get;set; }   // Att_A045_Disease.Dis45_KindOfRequest

      [Column("Dis45_CategoryOfRequest")]
      public string CategoryOfRequest { get;set; }   // Att_A045_Disease.Dis45_CategoryOfRequest

      [Column("Dis45_NotificationDate")]
      public DateTime? NotificationDate { get;set; }   // Att_A045_Disease.Dis45_NotificationDate

      [Column("Dis45_ContestationDate")]
      public DateTime? ContestationDate { get;set; }   // Att_A045_Disease.Dis45_ContestationDate

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

      [Column("Mre_Trimestre")]
      public string Trimestre { get;set; }   // Mouvement_Remuneration.Mre_Trimestre

      [Column("Mre_DNRB")]
      public string DNRB { get;set; }   // Mouvement_Remuneration.Mre_DNRB

      [Column("Mre_LSDNR")]
      public string LSDNR { get;set; }   // Mouvement_Remuneration.Mre_LSDNR

      [Column("Mre_Periode")]
      public decimal? Periode { get;set; }   // Mouvement_Remuneration.Mre_Periode

      [Column("Mre_Nature")]
      public string Nature { get;set; }   // Mouvement_Remuneration.Mre_Nature

      [Column("Mre_Regime")]
      public string Regime { get;set; }   // Mouvement_Remuneration.Mre_Regime

      [Column("Mre_JoursRemuneres")]
      public decimal? JoursRemuneres { get;set; }   // Mouvement_Remuneration.Mre_JoursRemuneres

      [Column("Mre_HeuresRemunerees")]
      public decimal? HeuresRemunerees { get;set; }   // Mouvement_Remuneration.Mre_HeuresRemunerees

      [Column("Mre_HeuresSemTravRef")]
      public decimal? HeuresSemTravRef { get;set; }   // Mouvement_Remuneration.Mre_HeuresSemTravRef

      [Column("Mre_JoursVacances")]
      public decimal? JoursVacances { get;set; }   // Mouvement_Remuneration.Mre_JoursVacances

      [Column("Mre_SalaireBrut")]
      public decimal? SalaireBrut { get;set; }   // Mouvement_Remuneration.Mre_SalaireBrut

      [Column("Mre_DateDebutPeriode")]
      public DateTime? DateDebutPeriode { get;set; }   // Mouvement_Remuneration.Mre_DateDebutPeriode

      [Column("Mre_DateFinPeriode")]
      public DateTime? DateFinPeriode { get;set; }   // Mouvement_Remuneration.Mre_DateFinPeriode

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

      [Column("Dcn45_DecisionCode")]
      public string DecisionCode { get;set; }   // Att_A045_DecisionFbzFmp.Dcn45_DecisionCode

      [Column("Dcn45_DisablementBeginDate")]
      public DateTime? DisablementBeginDate { get;set; }   // Att_A045_DecisionFbzFmp.Dcn45_DisablementBeginDate

      [Column("Dcn45_AllowanceAmount")]
      public decimal? AllowanceAmount { get;set; }   // Att_A045_DecisionFbzFmp.Dcn45_AllowanceAmount

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

      [Column("Emp_NUE")]
      public string NUE { get;set; }   // Employeur.Emp_NUE

      [Column("Emp_Nom")]
      public string Nom { get;set; }   // Employeur.Emp_Nom

      [Column("Emp_Langue")]
      public string Langue { get;set; }   // Employeur.Emp_Langue

      [Column("Emp_LangueDerog")]
      public string LangueDerog { get;set; }   // Employeur.Emp_LangueDerog

      [Column("Emp_AdresseRue")]
      public string AdresseRue { get;set; }   // Employeur.Emp_AdresseRue

      [Column("Emp_AdresseNo")]
      public string AdresseNo { get;set; }   // Employeur.Emp_AdresseNo

      [Column("Emp_AdresseBte")]
      public string AdresseBte { get;set; }   // Employeur.Emp_AdresseBte

      [Column("Emp_CodePostal")]
      public string CodePostal { get;set; }   // Employeur.Emp_CodePostal

      [Column("Emp_Localite")]
      public string Localite { get;set; }   // Employeur.Emp_Localite

      [Column("Emp_CodePays")]
      public string CodePays { get;set; }   // Employeur.Emp_CodePays

      [Column("Emp_CodeLocalite")]
      public string CodeLocalite { get;set; }   // Employeur.Emp_CodeLocalite

      [Column("Emp_DateModificationAdresse")]
      public DateTime? DateModificationAdresse { get;set; }   // Employeur.Emp_DateModificationAdresse

      [Column("Emp_IBAN")]
      public string IBAN { get;set; }   // Employeur.Emp_IBAN

      [Column("Emp_BIC")]
      public string BIC { get;set; }   // Employeur.Emp_BIC

      [Column("Emp_Telephone")]
      public string Telephone { get;set; }   // Employeur.Emp_Telephone

      [Column("Emp_Fax")]
      public string Fax { get;set; }   // Employeur.Emp_Fax

      [Column("Emp_NomContact")]
      public string NomContact { get;set; }   // Employeur.Emp_NomContact

      [Column("Emp_DateMatricule")]
      public DateTime? DateMatricule { get;set; }   // Employeur.Emp_DateMatricule

      [Column("Emp_DateFaillite")]
      public DateTime? DateFaillite { get;set; }   // Employeur.Emp_DateFaillite

      [Column("Emp_DateRadiation")]
      public DateTime? DateRadiation { get;set; }   // Employeur.Emp_DateRadiation

      [Column("Emp_Curatelle")]
      public string Curatelle { get;set; }   // Employeur.Emp_Curatelle

      [Column("Emp_AffiliationSSoc")]
      public string AffiliationSSoc { get;set; }   // Employeur.Emp_AffiliationSSoc

      [Column("Emp_SecSocialActuel")]
      public string SecSocialActuel { get;set; }   // Employeur.Emp_SecSocialActuel

      [Column("Emp_SecSocialPrecedent")]
      public string SecSocialPrecedent { get;set; }   // Employeur.Emp_SecSocialPrecedent

      [Column("Emp_SecSocialTrimestre")]
      public string SecSocialTrimestre { get;set; }   // Employeur.Emp_SecSocialTrimestre

      [Column("Emp_FormeJuridique")]
      public string FormeJuridique { get;set; }   // Employeur.Emp_FormeJuridique

      [Column("Emp_DateModification")]
      public DateTime? DateModification { get;set; }   // Employeur.Emp_DateModification

      [Column("Emp_DateInjection")]
      public DateTime? DateInjection { get;set; }   // Employeur.Emp_DateInjection

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

      [Column("Qry_Type")]
      public string Type { get;set; }   // Query.Qry_Type

      [Column("Qry_Document")]
      public string Document { get;set; }   // Query.Qry_Document

      [Column("Qry_Key")]
      public string Key { get;set; }   // Query.Qry_Key

      [Column("Qry_State")]
      public string State { get;set; }   // Query.Qry_State

      [Column("Qry_Utilisateur")]
      public string Utilisateur { get;set; }   // Query.Qry_Utilisateur

      [Column("Qry_NlKey")]
      public string NlKey { get;set; }   // Query.Qry_NlKey

      [Column("Qry_FrKey")]
      public string FrKey { get;set; }   // Query.Qry_FrKey

      [Column("Qry_NlHeader")]
      public string NlHeader { get;set; }   // Query.Qry_NlHeader

      [Column("Qry_FrHeader")]
      public string FrHeader { get;set; }   // Query.Qry_FrHeader

   }

   [Table("Retenue_Creance")]
   public partial class Retenue_Creance
   {

      [Key]
      [Column("Rcr_Id")]
      public decimal ID { get;set; }  // Retenue_Creance.Rcr_Id (PrimaryKey)

      [Column("Rcr_MontantRetenue")]
      public decimal? MontantRetenue { get;set; }   // Retenue_Creance.Rcr_MontantRetenue

      [Column("Rcr_SoldeAPayer")]
      public decimal? SoldeAPayer { get;set; }   // Retenue_Creance.Rcr_SoldeAPayer

      [Column("Rcr_DateCalcul")]
      public DateTime? DateCalcul { get;set; }   // Retenue_Creance.Rcr_DateCalcul

      [Column("Rcr_TotalPayements")]
      public decimal? TotalPayements { get;set; }   // Retenue_Creance.Rcr_TotalPayements

      [Column("Rcr_APayer")]
      public string APayer { get;set; }   // Retenue_Creance.Rcr_APayer

      [Column("Rcr_NomCreancier")]
      public string NomCreancier { get;set; }   // Retenue_Creance.Rcr_NomCreancier

      [Column("Cre_ID")]
      public decimal CreId_Key { get;set; }  // Retenue_Creance.Cre_ID (ForeignKey)

      [Column("Ptr_Id")]
      public decimal? PtrId_Key { get;set; }  // Retenue_Creance.Ptr_Id (ForeignKey)

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

      [Column("Sie_Numero")]
      public decimal? Numero { get;set; }   // Siege_Exploitation.Sie_Numero

      [Column("Sie_NomSiege")]
      public string NomSiege { get;set; }   // Siege_Exploitation.Sie_NomSiege

      [Column("Sie_NomContact")]
      public string NomContact { get;set; }   // Siege_Exploitation.Sie_NomContact

      [Column("Sie_AdresseRue")]
      public string AdresseRue { get;set; }   // Siege_Exploitation.Sie_AdresseRue

      [Column("Sie_AdresseNo")]
      public string AdresseNo { get;set; }   // Siege_Exploitation.Sie_AdresseNo

      [Column("Sie_AdresseBte")]
      public string AdresseBte { get;set; }   // Siege_Exploitation.Sie_AdresseBte

      [Column("Sie_CodePostal")]
      public string CodePostal { get;set; }   // Siege_Exploitation.Sie_CodePostal

      [Column("Sie_Localite")]
      public string Localite { get;set; }   // Siege_Exploitation.Sie_Localite

      [Column("Sie_Pays")]
      public string Pays { get;set; }   // Siege_Exploitation.Sie_Pays

      [Column("Sie_Telephone")]
      public string Telephone { get;set; }   // Siege_Exploitation.Sie_Telephone

      [Column("Sie_Fax")]
      public string Fax { get;set; }   // Siege_Exploitation.Sie_Fax

      [Column("Sie_DateLiquidation")]
      public DateTime? DateLiquidation { get;set; }   // Siege_Exploitation.Sie_DateLiquidation

      [Column("Sie_NumeroMatriculeDebut")]
      public string NumeroMatriculeDebut { get;set; }   // Siege_Exploitation.Sie_NumeroMatriculeDebut

      [Column("Sie_NumeroMatriculeFin")]
      public string NumeroMatriculeFin { get;set; }   // Siege_Exploitation.Sie_NumeroMatriculeFin

      [Column("Sie_NomSecretariatSoc")]
      public string NomSecretariatSoc { get;set; }   // Siege_Exploitation.Sie_NomSecretariatSoc

      [Column("Sie_IBAN")]
      public string IBAN { get;set; }   // Siege_Exploitation.Sie_IBAN

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

      [Column("Din_Syndicat")]
      public string Syndicat { get;set; }   // Dossier_Intervention.Din_Syndicat

      [Column("Din_ExistencePFA")]
      public string ExistencePFA { get;set; }   // Dossier_Intervention.Din_ExistencePFA

      [Column("Din_EtatDossier")]
      public string EtatDossier { get;set; }   // Dossier_Intervention.Din_EtatDossier

      [Column("Din_MontantJournalier")]
      public decimal? MontantJournalier { get;set; }   // Dossier_Intervention.Din_MontantJournalier

      [Column("Din_CreditJours")]
      public decimal? CreditJours { get;set; }   // Dossier_Intervention.Din_CreditJours

      [Column("Din_HeuresSemaine")]
      public decimal? HeuresSemaine { get;set; }   // Dossier_Intervention.Din_HeuresSemaine

      [Column("Din_TauxHoraire")]
      public decimal? TauxHoraire { get;set; }   // Dossier_Intervention.Din_TauxHoraire

      [Column("Din_SalaireBrut")]
      public decimal? SalaireBrut { get;set; }   // Dossier_Intervention.Din_SalaireBrut

      [Column("Din_RetenueONSS")]
      public decimal? RetenueONSS { get;set; }   // Dossier_Intervention.Din_RetenueONSS

      [Column("Din_BaseImposable")]
      public decimal? BaseImposable { get;set; }   // Dossier_Intervention.Din_BaseImposable

      [Column("Din_RetenueFiscale")]
      public decimal? RetenueFiscale { get;set; }   // Dossier_Intervention.Din_RetenueFiscale

      [Column("Din_SalaireNet")]
      public decimal? SalaireNet { get;set; }   // Dossier_Intervention.Din_SalaireNet

      [Column("Din_Anciennete")]
      public string Anciennete { get;set; }   // Dossier_Intervention.Din_Anciennete

      [Column("Din_DateAffiliation")]
      public DateTime? DateAffiliation { get;set; }   // Dossier_Intervention.Din_DateAffiliation

      [Column("Din_DatePerteRevenus")]
      public DateTime? DatePerteRevenus { get;set; }   // Dossier_Intervention.Din_DatePerteRevenus

      [Column("Din_AllocJournChomage")]
      public decimal? AllocJournChomage { get;set; }   // Dossier_Intervention.Din_AllocJournChomage

      [Column("Din_NbreAllocChomage")]
      public decimal? NbreAllocChomage { get;set; }   // Dossier_Intervention.Din_NbreAllocChomage

      [Column("Din_TotalAllocChomage")]
      public decimal? TotalAllocChomage { get;set; }   // Dossier_Intervention.Din_TotalAllocChomage

      [Column("Din_SalaireReference")]
      public decimal? SalaireReference { get;set; }   // Dossier_Intervention.Din_SalaireReference

      [Column("Din_Commentaire")]
      public string Commentaire { get;set; }   // Dossier_Intervention.Din_Commentaire

      [Column("Din_Frontalier")]
      public string Frontalier { get;set; }   // Dossier_Intervention.Din_Frontalier

      [Column("Din_DateDossier")]
      public DateTime? DateDossier { get;set; }   // Dossier_Intervention.Din_DateDossier

      [Column("Din_Exercice")]
      public string Exercice { get;set; }   // Dossier_Intervention.Din_Exercice

      [Column("Din_TrimestreDebutChomage")]
      public string TrimestreDebutChomage { get;set; }   // Dossier_Intervention.Din_TrimestreDebutChomage

      [Column("Din_CreditHeure")]
      public decimal? CreditHeure { get;set; }   // Dossier_Intervention.Din_CreditHeure

      [Column("Din_MontantHoraire")]
      public decimal? MontantHoraire { get;set; }   // Dossier_Intervention.Din_MontantHoraire

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

      [Column("Ltr_NoAttestation")]
      public string NoAttestation { get;set; }   // Ligne_Travailleur.Ltr_NoAttestation

      [Column("Ltr_NoSituation")]
      public string NoSituation { get;set; }   // Ligne_Travailleur.Ltr_NoSituation

      [Column("Ltr_Active")]
      public string Active { get;set; }   // Ligne_Travailleur.Ltr_Active

      [Column("Ltr_Origine")]
      public string Origine { get;set; }   // Ligne_Travailleur.Ltr_Origine

      [Column("Ltr_NISS")]
      public string NISS { get;set; }   // Ligne_Travailleur.Ltr_NISS

      [Column("Ltr_ONSS")]
      public string ONSS { get;set; }   // Ligne_Travailleur.Ltr_ONSS

      [Column("Ltr_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Ligne_Travailleur.Ltr_CategorieEmployeur

      [Column("Ltr_CodeTravailleur")]
      public string CodeTravailleur { get;set; }   // Ligne_Travailleur.Ltr_CodeTravailleur

      [Column("Ltr_Trimestre")]
      public string Trimestre { get;set; }   // Ligne_Travailleur.Ltr_Trimestre

      [Column("Ltr_DateDebutTrimestre")]
      public DateTime? DateDebutTrimestre { get;set; }   // Ligne_Travailleur.Ltr_DateDebutTrimestre

      [Column("Ltr_DateFinTrimestre")]
      public DateTime? DateFinTrimestre { get;set; }   // Ligne_Travailleur.Ltr_DateFinTrimestre

      [Column("Ltr_Frontalier")]
      public string Frontalier { get;set; }   // Ligne_Travailleur.Ltr_Frontalier

      [Column("Ltr_ActiviteRisque")]
      public string ActiviteRisque { get;set; }   // Ligne_Travailleur.Ltr_ActiviteRisque

      [Column("Ltr_UniteLocale")]
      public string UniteLocale { get;set; }   // Ligne_Travailleur.Ltr_UniteLocale

      [Column("Ltr_DateInjection")]
      public DateTime? DateInjection { get;set; }   // Ligne_Travailleur.Ltr_DateInjection

      [Column("Ltr_DateCreation")]
      public DateTime? DateCreation { get;set; }   // Ligne_Travailleur.Ltr_DateCreation

      [Column("Ltr_TextLibre")]
      public string TextLibre { get;set; }   // Ligne_Travailleur.Ltr_TextLibre

      [Column("Ltr_AttStatut")]
      public string AttStatut { get;set; }   // Ligne_Travailleur.Ltr_AttStatut

      [Column("Env_Id")]
      public decimal? EnvId_Key { get;set; }  // Ligne_Travailleur.Env_Id (ForeignKey)

      [Column("Con_Id")]
      public decimal ConId_Key { get;set; }  // Ligne_Travailleur.Con_Id (ForeignKey)

      [Column("Pct_Id")]
      public decimal? PctId_Key { get;set; }  // Ligne_Travailleur.Pct_Id (ForeignKey)

      [Column("Dct_Id")]
      public decimal? DctId_Key { get;set; }  // Ligne_Travailleur.Dct_Id (ForeignKey)

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

      [Column("Val_JoursPrestes")]
      public decimal? JoursPrestes { get;set; }   // Validation_Envoi.Val_JoursPrestes

      [Column("Val_Salaires")]
      public decimal? Salaires { get;set; }   // Validation_Envoi.Val_Salaires

      [Column("Aem_ID")]
      public decimal? AemId_Key { get;set; }  // Validation_Envoi.Aem_ID (ForeignKey)

      [Column("Env_Id")]
      public decimal? EnvId_Key { get;set; }  // Validation_Envoi.Env_Id (ForeignKey)

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

      [Column("objectid")]
      public int? Objectid { get;set; }   // dtproperties.objectid

      [Column("value")]
      public string Value { get;set; }   // dtproperties.value

      [Column("lvalue")]
      public byte[] Lvalue { get;set; }   // dtproperties.lvalue

      [Required]
      [Column("version")]
      public int Version { get;set; }   // dtproperties.version

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

      [Column("Sin_DateFin")]
      public DateTime? DateFin { get;set; }   // Solidarite_Inactivite.Sin_DateFin

      [Column("Sin_Active")]
      public string Active { get;set; }   // Solidarite_Inactivite.Sin_Active

      [Column("Sin_NoDossier")]
      public string NoDossier { get;set; }   // Solidarite_Inactivite.Sin_NoDossier

      [Column("Sin_JoursInactivite")]
      public decimal? JoursInactivite { get;set; }   // Solidarite_Inactivite.Sin_JoursInactivite

      [Column("Sin_SalaireFictifJournalier")]
      public decimal? SalaireFictifJournalier { get;set; }   // Solidarite_Inactivite.Sin_SalaireFictifJournalier

      [Column("Sin_SFJManuel")]
      public decimal? SFJManuel { get;set; }   // Solidarite_Inactivite.Sin_SFJManuel

      [Column("Sin_SalaireFictif")]
      public decimal? SalaireFictif { get;set; }   // Solidarite_Inactivite.Sin_SalaireFictif

      [Column("Sin_PrimeInactivite")]
      public decimal? PrimeInactivite { get;set; }   // Solidarite_Inactivite.Sin_PrimeInactivite

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

      [Column("Env_numeroSuiteEnvoi")]
      public string NumeroSuiteEnvoi { get;set; }   // Envoi.Env_numeroSuiteEnvoi

      [Column("Env_NomFichier")]
      public string NomFichier { get;set; }   // Envoi.Env_NomFichier

      [Column("Env_dateCreation")]
      public DateTime? DateCreation { get;set; }   // Envoi.Env_dateCreation

      [Column("Env_etat")]
      public string Etat { get;set; }   // Envoi.Env_etat

      [Column("Env_NbrRecord")]
      public decimal? NbrRecord { get;set; }   // Envoi.Env_NbrRecord

      [Column("Env_NbrRecordInjecte")]
      public decimal? NbrRecordInjecte { get;set; }   // Envoi.Env_NbrRecordInjecte

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

      [Column("Bnf_TypeApplication")]
      public string TypeApplication { get;set; }   // Beneficiaire.Bnf_TypeApplication

      [Column("Bnf_Type")]
      public string Type { get;set; }   // Beneficiaire.Bnf_Type

      [Column("Bnf_QuotePart")]
      public decimal? QuotePart { get;set; }   // Beneficiaire.Bnf_QuotePart

      [Column("Bnf_Niss")]
      public string Niss { get;set; }   // Beneficiaire.Bnf_Niss

      [Column("Bnf_Nom")]
      public string Nom { get;set; }   // Beneficiaire.Bnf_Nom

      [Column("Bnf_Prenom")]
      public string Prenom { get;set; }   // Beneficiaire.Bnf_Prenom

      [Column("Bnf_DateNaissance")]
      public DateTime? DateNaissance { get;set; }   // Beneficiaire.Bnf_DateNaissance

      [Column("Bnf_Langue")]
      public string Langue { get;set; }   // Beneficiaire.Bnf_Langue

      [Column("Bnf_Sexe")]
      public string Sexe { get;set; }   // Beneficiaire.Bnf_Sexe

      [Column("Bnf_AdresseRue")]
      public string AdresseRue { get;set; }   // Beneficiaire.Bnf_AdresseRue

      [Column("Bnf_AdresseNo")]
      public string AdresseNo { get;set; }   // Beneficiaire.Bnf_AdresseNo

      [Column("Bnf_AdresseBte")]
      public string AdresseBte { get;set; }   // Beneficiaire.Bnf_AdresseBte

      [Column("Bnf_CodePostal")]
      public string CodePostal { get;set; }   // Beneficiaire.Bnf_CodePostal

      [Column("Bnf_Localite")]
      public string Localite { get;set; }   // Beneficiaire.Bnf_Localite

      [Column("Bnf_CodePays")]
      public string CodePays { get;set; }   // Beneficiaire.Bnf_CodePays

      [Column("Bnf_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Beneficiaire.Bnf_CompteBancaire

      [Column("Bnf_IBAN")]
      public string IBAN { get;set; }   // Beneficiaire.Bnf_IBAN

      [Column("Bnf_BIC")]
      public string BIC { get;set; }   // Beneficiaire.Bnf_BIC

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

      [Column("A37_Active")]
      public string Active { get;set; }   // Drs_A037.A37_Active

      [Column("A37_Niss")]
      public string Niss { get;set; }   // Drs_A037.A37_Niss

      [Column("A37_NoAttestation")]
      public string NoAttestation { get;set; }   // Drs_A037.A37_NoAttestation

      [Column("A37_NoSituation")]
      public string NoSituation { get;set; }   // Drs_A037.A37_NoSituation

      [Column("A37_EtatAttestation")]
      public string EtatAttestation { get;set; }   // Drs_A037.A37_EtatAttestation

      [Column("A37_MoisInactivite")]
      public string MoisInactivite { get;set; }   // Drs_A037.A37_MoisInactivite

      [Column("A37_DateCreation")]
      public DateTime? DateCreation { get;set; }   // Drs_A037.A37_DateCreation

      [Column("A37_Onss")]
      public string Onss { get;set; }   // Drs_A037.A37_Onss

      [Column("A37_Bce")]
      public string Bce { get;set; }   // Drs_A037.A37_Bce

      [Column("A37_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Drs_A037.A37_CategorieEmployeur

      [Column("A37_CodeTravailleur")]
      public string CodeTravailleur { get;set; }   // Drs_A037.A37_CodeTravailleur

      [Column("A37_NoInterneOccupation")]
      public string NoInterneOccupation { get;set; }   // Drs_A037.A37_NoInterneOccupation

      [Column("A37_DateDebutOccupation")]
      public DateTime? DateDebutOccupation { get;set; }   // Drs_A037.A37_DateDebutOccupation

      [Column("A37_CommissionParitaire")]
      public string CommissionParitaire { get;set; }   // Drs_A037.A37_CommissionParitaire

      [Column("A37_HeuresSemTrav")]
      public decimal? HeuresSemTrav { get;set; }   // Drs_A037.A37_HeuresSemTrav

      [Column("A37_HeuresSemTravRef")]
      public decimal? HeuresSemTravRef { get;set; }   // Drs_A037.A37_HeuresSemTravRef

      [Column("A37_StatutTravailleur")]
      public string StatutTravailleur { get;set; }   // Drs_A037.A37_StatutTravailleur

      [Column("A37_DateDebutPeriode")]
      public DateTime? DateDebutPeriode { get;set; }   // Drs_A037.A37_DateDebutPeriode

      [Column("A37_DateFinPeriode")]
      public DateTime? DateFinPeriode { get;set; }   // Drs_A037.A37_DateFinPeriode

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

      [Column("Pay_NoPayement")]
      public string NoPayement { get;set; }   // Payement.Pay_NoPayement

      [Required]
      [Column("Pay_Type")]
      public string Type { get;set; }   // Payement.Pay_Type

      [Column("Pay_Mode")]
      public string Mode { get;set; }   // Payement.Pay_Mode

      [Column("Pay_Actif")]
      public string Actif { get;set; }   // Payement.Pay_Actif

      [Column("Pay_NoCheque")]
      public string NoCheque { get;set; }   // Payement.Pay_NoCheque

      [Column("Pay_Montant")]
      public decimal? Montant { get;set; }   // Payement.Pay_Montant

      [Column("Pay_DateDebutValidite")]
      public DateTime? DateDebutValidite { get;set; }   // Payement.Pay_DateDebutValidite

      [Column("Pay_DateFinValidite")]
      public DateTime? DateFinValidite { get;set; }   // Payement.Pay_DateFinValidite

      [Column("Pay_Etat")]
      public string Etat { get;set; }   // Payement.Pay_Etat

      [Column("Pay_DateEmission")]
      public DateTime? DateEmission { get;set; }   // Payement.Pay_DateEmission

      [Column("Pay_DateEncaissement")]
      public DateTime? DateEncaissement { get;set; }   // Payement.Pay_DateEncaissement

      [Column("Pay_DateRetour")]
      public DateTime? DateRetour { get;set; }   // Payement.Pay_DateRetour

      [Column("Pay_MotivationRetour")]
      public string MotivationRetour { get;set; }   // Payement.Pay_MotivationRetour

      [Column("Pay_Nom")]
      public string Nom { get;set; }   // Payement.Pay_Nom

      [Column("Pay_Prenom")]
      public string Prenom { get;set; }   // Payement.Pay_Prenom

      [Column("Pay_AdresseRue")]
      public string AdresseRue { get;set; }   // Payement.Pay_AdresseRue

      [Column("Pay_AdresseNo")]
      public string AdresseNo { get;set; }   // Payement.Pay_AdresseNo

      [Column("Pay_AdresseBte")]
      public string AdresseBte { get;set; }   // Payement.Pay_AdresseBte

      [Column("Pay_CodePostal")]
      public string CodePostal { get;set; }   // Payement.Pay_CodePostal

      [Column("Pay_Localite")]
      public string Localite { get;set; }   // Payement.Pay_Localite

      [Column("Pay_CodePays")]
      public string CodePays { get;set; }   // Payement.Pay_CodePays

      [Column("Pay_Langue")]
      public string Langue { get;set; }   // Payement.Pay_Langue

      [Column("Pay_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Payement.Pay_CompteBancaire

      [Column("Pay_ReferenceBancaire")]
      public string ReferenceBancaire { get;set; }   // Payement.Pay_ReferenceBancaire

      [Column("Pay_Communication")]
      public string Communication { get;set; }   // Payement.Pay_Communication

      [Column("Pay_DonneurOrdre")]
      public string DonneurOrdre { get;set; }   // Payement.Pay_DonneurOrdre

      [Column("Pay_IBANDebiteur")]
      public string IBANDebiteur { get;set; }   // Payement.Pay_IBANDebiteur

      [Column("Pay_BICDebiteur")]
      public string BICDebiteur { get;set; }   // Payement.Pay_BICDebiteur

      [Column("Pay_IBANCrediteur")]
      public string IBANCrediteur { get;set; }   // Payement.Pay_IBANCrediteur

      [Column("Pay_BICCrediteur")]
      public string BICCrediteur { get;set; }   // Payement.Pay_BICCrediteur

      [Column("Tit_Id")]
      public decimal? TitId_Key { get;set; }  // Payement.Tit_Id (ForeignKey)

      [Column("Rcr_Id")]
      public decimal? RcrId_Key { get;set; }  // Payement.Rcr_Id (ForeignKey)

      [Column("Bnf_ID")]
      public decimal? BnfId_Key { get;set; }  // Payement.Bnf_ID (ForeignKey)

      [Column("Ppp_Id")]
      public decimal? PppId_Key { get;set; }  // Payement.Ppp_Id (ForeignKey)

      [Column("Int_Id")]
      public decimal? IntId_Key { get;set; }  // Payement.Int_Id (ForeignKey)

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

      [Column("Dei_NunmeroFolio")]
      public string NunmeroFolio { get;set; }   // Demande_Intervention.Dei_NunmeroFolio

      [Column("Dei_TypeDemande")]
      public string TypeDemande { get;set; }   // Demande_Intervention.Dei_TypeDemande

      [Required]
      [Column("Dei_DebutPeriode")]
      public DateTime DebutPeriode { get;set; }   // Demande_Intervention.Dei_DebutPeriode

      [Required]
      [Column("Dei_FinPeriode")]
      public DateTime FinPeriode { get;set; }   // Demande_Intervention.Dei_FinPeriode

      [Column("Dei_HeuresSemaine")]
      public decimal? HeuresSemaine { get;set; }   // Demande_Intervention.Dei_HeuresSemaine

      [Column("Dei_TauxHoraire")]
      public decimal? TauxHoraire { get;set; }   // Demande_Intervention.Dei_TauxHoraire

      [Column("Dei_SalaireBrut")]
      public decimal? SalaireBrut { get;set; }   // Demande_Intervention.Dei_SalaireBrut

      [Column("Dei_RetenueONSS")]
      public decimal? RetenueONSS { get;set; }   // Demande_Intervention.Dei_RetenueONSS

      [Column("Dei_BaseImposable")]
      public decimal? BaseImposable { get;set; }   // Demande_Intervention.Dei_BaseImposable

      [Column("Dei_RetenueFiscale")]
      public decimal? RetenueFiscale { get;set; }   // Demande_Intervention.Dei_RetenueFiscale

      [Column("Dei_SalaireNet")]
      public decimal? SalaireNet { get;set; }   // Demande_Intervention.Dei_SalaireNet

      [Column("Dei_AllocJournChomage")]
      public decimal? AllocJournChomage { get;set; }   // Demande_Intervention.Dei_AllocJournChomage

      [Column("Dei_NbreAllocChomage")]
      public decimal? NbreAllocChomage { get;set; }   // Demande_Intervention.Dei_NbreAllocChomage

      [Column("Dei_TotalAllocChomage")]
      public decimal? TotalAllocChomage { get;set; }   // Demande_Intervention.Dei_TotalAllocChomage

      [Column("Dei_SalaireReference")]
      public decimal? SalaireReference { get;set; }   // Demande_Intervention.Dei_SalaireReference

      [Column("Dei_Difference")]
      public decimal? Difference { get;set; }   // Demande_Intervention.Dei_Difference

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

      [Column("Cet_Remuneration")]
      public decimal? Remuneration { get;set; }   // Cotisation_Etudiant.Cet_Remuneration

      [Column("Cet_Cotisation")]
      public decimal? Cotisation { get;set; }   // Cotisation_Etudiant.Cet_Cotisation

      [Column("Cet_Jours")]
      public decimal? Jours { get;set; }   // Cotisation_Etudiant.Cet_Jours

      [Column("Cet_NoUniteLocale")]
      public string NoUniteLocale { get;set; }   // Cotisation_Etudiant.Cet_NoUniteLocale

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

      [Column("Ppp_MontantChomage")]
      public decimal? MontantChomage { get;set; }   // Prime_Prepension.Ppp_MontantChomage

      [Column("Ppp_IndemniteExtraLegale")]
      public decimal? IndemniteExtraLegale { get;set; }   // Prime_Prepension.Ppp_IndemniteExtraLegale

      [Column("Ppp_IndemniteBrute")]
      public decimal? IndemniteBrute { get;set; }   // Prime_Prepension.Ppp_IndemniteBrute

      [Column("Ppp_RetenueONP")]
      public decimal? RetenueONP { get;set; }   // Prime_Prepension.Ppp_RetenueONP

      [Column("Ppp_RetenueONEM")]
      public decimal? RetenueONEM { get;set; }   // Prime_Prepension.Ppp_RetenueONEM

      [Column("Ppp_RetenueFiscale")]
      public decimal? RetenueFiscale { get;set; }   // Prime_Prepension.Ppp_RetenueFiscale

      [Column("Ppp_RevenuNet")]
      public decimal? RevenuNet { get;set; }   // Prime_Prepension.Ppp_RevenuNet

      [Column("Ppp_IndemnitePayable")]
      public decimal? IndemnitePayable { get;set; }   // Prime_Prepension.Ppp_IndemnitePayable

      [Column("Ppp_CapitativeONP")]
      public decimal? CapitativeONP { get;set; }   // Prime_Prepension.Ppp_CapitativeONP

      [Column("Ppp_CapitativeONSS")]
      public decimal? CapitativeONSS { get;set; }   // Prime_Prepension.Ppp_CapitativeONSS

      [Column("Ppp_CotisationCompensatoire")]
      public decimal? CotisationCompensatoire { get;set; }   // Prime_Prepension.Ppp_CotisationCompensatoire

      [Column("Ppp_DateExecution")]
      public DateTime? DateExecution { get;set; }   // Prime_Prepension.Ppp_DateExecution

      [Column("Ppp_ModeCalcul")]
      public string ModeCalcul { get;set; }   // Prime_Prepension.Ppp_ModeCalcul

      [Column("Ppp_CotisationPersonnelle")]
      public decimal? CotisationPersonnelle { get;set; }   // Prime_Prepension.Ppp_CotisationPersonnelle

      [Column("Ppp_CotisationPatronale")]
      public decimal? CotisationPatronale { get;set; }   // Prime_Prepension.Ppp_CotisationPatronale

      [Column("Ppp_DebiteurPrincipal")]
      public string DebiteurPrincipal { get;set; }   // Prime_Prepension.Ppp_DebiteurPrincipal

      [Column("Ppp_JoursPrestes")]
      public decimal? JoursPrestes { get;set; }   // Prime_Prepension.Ppp_JoursPrestes

      [Column("Ppp_AgeReference")]
      public decimal? AgeReference { get;set; }   // Prime_Prepension.Ppp_AgeReference

      [Column("Ppp_Plancher")]
      public string Plancher { get;set; }   // Prime_Prepension.Ppp_Plancher

      [Column("Ppp_Reprise")]
      public string Reprise { get;set; }   // Prime_Prepension.Ppp_Reprise

      [Column("Ppp_TauxReduitCompensatoire")]
      public string TauxReduitCompensatoire { get;set; }   // Prime_Prepension.Ppp_TauxReduitCompensatoire

      [Column("Ppp_EtatEmployeur")]
      public string EtatEmployeur { get;set; }   // Prime_Prepension.Ppp_EtatEmployeur

      [Column("Ppp_CodePersonnel")]
      public string CodePersonnel { get;set; }   // Prime_Prepension.Ppp_CodePersonnel

      [Column("Ppp_CodePatronal")]
      public string CodePatronal { get;set; }   // Prime_Prepension.Ppp_CodePatronal

      [Column("Ppp_CodeCompensatoire")]
      public string CodeCompensatoire { get;set; }   // Prime_Prepension.Ppp_CodeCompensatoire

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

      [Column("D44_Niss")]
      public string Niss { get;set; }   // Drs_A044_Dossier.D44_Niss

      [Column("D44_NoDossier")]
      public string NoDossier { get;set; }   // Drs_A044_Dossier.D44_NoDossier

      [Column("D44_DateAccident")]
      public DateTime? DateAccident { get;set; }   // Drs_A044_Dossier.D44_DateAccident

      [Column("D44_DateCreation")]
      public DateTime? DateCreation { get;set; }   // Drs_A044_Dossier.D44_DateCreation

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

      [Column("P44_DateDebutPayement")]
      public DateTime? DateDebutPayement { get;set; }   // Drs_A044_Payement.P44_DateDebutPayement

      [Column("P44_DateFinPayement")]
      public DateTime? DateFinPayement { get;set; }   // Drs_A044_Payement.P44_DateFinPayement

      [Column("P44_Pourcentage")]
      public decimal? Pourcentage { get;set; }   // Drs_A044_Payement.P44_Pourcentage

      [Column("P44_MontantBrut")]
      public decimal? MontantBrut { get;set; }   // Drs_A044_Payement.P44_MontantBrut

      [Column("P44_RetenueOnss")]
      public decimal? RetenueOnss { get;set; }   // Drs_A044_Payement.P44_RetenueOnss

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

      [Column("A44_Active")]
      public string Active { get;set; }   // Drs_A044_Attestation.A44_Active

      [Column("A44_NoAttestation")]
      public string NoAttestation { get;set; }   // Drs_A044_Attestation.A44_NoAttestation

      [Column("A44_NoSituation")]
      public string NoSituation { get;set; }   // Drs_A044_Attestation.A44_NoSituation

      [Column("A44_EtatAttestation")]
      public string EtatAttestation { get;set; }   // Drs_A044_Attestation.A44_EtatAttestation

      [Column("A44_DateCreation")]
      public DateTime? DateCreation { get;set; }   // Drs_A044_Attestation.A44_DateCreation

      [Column("A44_NoAccident")]
      public string NoAccident { get;set; }   // Drs_A044_Attestation.A44_NoAccident

      [Column("A44_Bce")]
      public string Bce { get;set; }   // Drs_A044_Attestation.A44_Bce

      [Column("A44_Onss")]
      public string Onss { get;set; }   // Drs_A044_Attestation.A44_Onss

      [Column("A44_CategorieEmployeur")]
      public string CategorieEmployeur { get;set; }   // Drs_A044_Attestation.A44_CategorieEmployeur

      [Column("A44_MoisInactivite")]
      public string MoisInactivite { get;set; }   // Drs_A044_Attestation.A44_MoisInactivite

      [Column("A44_DateDebutPeriode")]
      public DateTime? DateDebutPeriode { get;set; }   // Drs_A044_Attestation.A44_DateDebutPeriode

      [Column("A44_DateFinPeriode")]
      public DateTime? DateFinPeriode { get;set; }   // Drs_A044_Attestation.A44_DateFinPeriode

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

      [Column("Cre_Type")]
      public string Type { get;set; }   // Creance.Cre_Type

      [Column("Cre_Montant")]
      public decimal? Montant { get;set; }   // Creance.Cre_Montant

      [Column("Cre_Solde")]
      public decimal? Solde { get;set; }   // Creance.Cre_Solde

      [Column("Cre_LimiteRetenue")]
      public decimal? LimiteRetenue { get;set; }   // Creance.Cre_LimiteRetenue

      [Column("Cre_DateNotification")]
      public DateTime? DateNotification { get;set; }   // Creance.Cre_DateNotification

      [Column("Cre_RefNotification")]
      public string RefNotification { get;set; }   // Creance.Cre_RefNotification

      [Required]
      [Column("Cre_Etat")]
      public string Etat { get;set; }   // Creance.Cre_Etat

      [Column("Cre_DateDernierEtat")]
      public DateTime? DateDernierEtat { get;set; }   // Creance.Cre_DateDernierEtat

      [Column("Cre_EtatPrecedent")]
      public string EtatPrecedent { get;set; }   // Creance.Cre_EtatPrecedent

      [Column("Cre_ModeCalcul")]
      public string ModeCalcul { get;set; }   // Creance.Cre_ModeCalcul

      [Column("Cre_MontantFixe")]
      public decimal? MontantFixe { get;set; }   // Creance.Cre_MontantFixe

      [Column("Cre_Pourcentage")]
      public decimal? Pourcentage { get;set; }   // Creance.Cre_Pourcentage

      [Column("Cre_AuProrata")]
      public string AuProrata { get;set; }   // Creance.Cre_AuProrata

      [Column("Cre_Indexe")]
      public string Indexe { get;set; }   // Creance.Cre_Indexe

      [Column("Cre_Nom")]
      public string Nom { get;set; }   // Creance.Cre_Nom

      [Column("Cre_Prenom")]
      public string Prenom { get;set; }   // Creance.Cre_Prenom

      [Column("Cre_AdresseRue")]
      public string AdresseRue { get;set; }   // Creance.Cre_AdresseRue

      [Column("Cre_AdresseNo")]
      public string AdresseNo { get;set; }   // Creance.Cre_AdresseNo

      [Column("Cre_AdresseBte")]
      public string AdresseBte { get;set; }   // Creance.Cre_AdresseBte

      [Column("Cre_CodePostal")]
      public string CodePostal { get;set; }   // Creance.Cre_CodePostal

      [Column("Cre_Localite")]
      public string Localite { get;set; }   // Creance.Cre_Localite

      [Column("Cre_CodePays")]
      public string CodePays { get;set; }   // Creance.Cre_CodePays

      [Column("Cre_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Creance.Cre_CompteBancaire

      [Column("Cre_IBAN")]
      public string IBAN { get;set; }   // Creance.Cre_IBAN

      [Column("Cre_BIC")]
      public string BIC { get;set; }   // Creance.Cre_BIC

      [Column("Cre_Langue")]
      public string Langue { get;set; }   // Creance.Cre_Langue

      [Column("Cre_DateModification")]
      public DateTime? DateModification { get;set; }   // Creance.Cre_DateModification

      [Column("Cre_Rang")]
      public decimal? Rang { get;set; }   // Creance.Cre_Rang

      [Column("Cre_DatePayement")]
      public DateTime? DatePayement { get;set; }   // Creance.Cre_DatePayement

      [Column("Cre_DateDepotGreffe")]
      public DateTime? DateDepotGreffe { get;set; }   // Creance.Cre_DateDepotGreffe

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

      [Column("Cri_Numero")]
      public string Numero { get;set; }   // Creancier.Cri_Numero

      [Column("Cri_Nom")]
      public string Nom { get;set; }   // Creancier.Cri_Nom

      [Column("Cri_AdresseRue")]
      public string AdresseRue { get;set; }   // Creancier.Cri_AdresseRue

      [Column("Cri_AdresseNo")]
      public string AdresseNo { get;set; }   // Creancier.Cri_AdresseNo

      [Column("Cri_AdresseBte")]
      public string AdresseBte { get;set; }   // Creancier.Cri_AdresseBte

      [Column("Cri_CodePostal")]
      public string CodePostal { get;set; }   // Creancier.Cri_CodePostal

      [Column("Cri_Localite")]
      public string Localite { get;set; }   // Creancier.Cri_Localite

      [Column("Cri_CodePays")]
      public string CodePays { get;set; }   // Creancier.Cri_CodePays

      [Column("Cri_Telephone")]
      public string Telephone { get;set; }   // Creancier.Cri_Telephone

      [Column("Cri_Fax")]
      public string Fax { get;set; }   // Creancier.Cri_Fax

      [Column("Cri_CompteBancaire")]
      public string CompteBancaire { get;set; }   // Creancier.Cri_CompteBancaire

      [Column("Cri_IBAN")]
      public string IBAN { get;set; }   // Creancier.Cri_IBAN

      [Column("Cri_BIC")]
      public string BIC { get;set; }   // Creancier.Cri_BIC

      [Column("Cri_Langue")]
      public string Langue { get;set; }   // Creancier.Cri_Langue

      // Reverse Navigation

      [InverseProperty("CriId_Key")]
      public virtual List<Creance> Creance { get; set; }

   }

}
