using System;
using System.ComponentModel.DataAnnotations;          
using System.ComponentModel.DataAnnotations.Schema;   
using System.Collections.Generic;   

namespace my.business.space
{

   [Table("Dossier_Prepension")]
   public partial class DossierPrepension
   {

      [Key]
      [Column("Dpp_Id")]
      public decimal DppId { get;set; }  // Dossier_Prepension.Dpp_Id (PrimaryKey)

      [Required]
      [Column("Dpp_Etat")]
      public string DppEtat { get;set; }   // Dossier_Prepension.Dpp_Etat

      [Required]
      [Column("Dpp_DatePrepension")]
      public DateTime DppDateprepension { get;set; }   // Dossier_Prepension.Dpp_DatePrepension

      [Required]
      [Column("Dpp_DatePension")]
      public DateTime DppDatepension { get;set; }   // Dossier_Prepension.Dpp_DatePension

      [Required]
      [Column("Dpp_ProfilPrepension")]
      public string DppProfilprepension { get;set; }   // Dossier_Prepension.Dpp_ProfilPrepension

      [Required]
      [Column("Dpp_MiTemps")]
      public string DppMitemps { get;set; }   // Dossier_Prepension.Dpp_MiTemps

      [Required]
      [Column("Dpp_CodeSyndical")]
      public string DppCodesyndical { get;set; }   // Dossier_Prepension.Dpp_CodeSyndical

      [Required]
      [Column("Dpp_SalaireONSS")]
      public decimal DppSalaireonss { get;set; }   // Dossier_Prepension.Dpp_SalaireONSS

      [Required]
      [Column("Dpp_JoursPrestes")]
      public decimal DppJoursprestes { get;set; }   // Dossier_Prepension.Dpp_JoursPrestes

      [Required]
      [Column("Dpp_SalaireHoraire")]
      public decimal DppSalairehoraire { get;set; }   // Dossier_Prepension.Dpp_SalaireHoraire

      [Required]
      [Column("Dpp_HeuresSemaine")]
      public decimal DppHeuressemaine { get;set; }   // Dossier_Prepension.Dpp_HeuresSemaine

      [Required]
      [Column("Dpp_SalaireMensuel")]
      public decimal DppSalairemensuel { get;set; }   // Dossier_Prepension.Dpp_SalaireMensuel

      [Required]
      [Column("Dpp_MontantPrimes")]
      public decimal DppMontantprimes { get;set; }   // Dossier_Prepension.Dpp_MontantPrimes

      [Required]
      [Column("Dpp_RetenueONSS")]
      public decimal DppRetenueonss { get;set; }   // Dossier_Prepension.Dpp_RetenueONSS

      [Required]
      [Column("Dpp_Precompte")]
      public decimal DppPrecompte { get;set; }   // Dossier_Prepension.Dpp_Precompte

      [Required]
      [Column("Dpp_SalaireReference")]
      public decimal DppSalairereference { get;set; }   // Dossier_Prepension.Dpp_SalaireReference

      [Required]
      [Column("Dpp_DemiSalaireReference")]
      public decimal DppDemisalairereference { get;set; }   // Dossier_Prepension.Dpp_DemiSalaireReference

      [Required]
      [Column("Dpp_IndemniteExtraLegale")]
      public decimal DppIndemniteextralegale { get;set; }   // Dossier_Prepension.Dpp_IndemniteExtraLegale

      [Required]
      [Column("Dpp_IndemniteBrute")]
      public decimal DppIndemnitebrute { get;set; }   // Dossier_Prepension.Dpp_IndemniteBrute

      [Required]
      [Column("Dpp_NbreAllocations")]
      public decimal DppNbreallocations { get;set; }   // Dossier_Prepension.Dpp_NbreAllocations

      [Required]
      [Column("Dpp_CodeChomage")]
      public string DppCodechomage { get;set; }   // Dossier_Prepension.Dpp_CodeChomage

      [Required]
      [Column("Dpp_MontantChomage")]
      public decimal DppMontantchomage { get;set; }   // Dossier_Prepension.Dpp_MontantChomage

      [Required]
      [Column("Dpp_RetenueONP")]
      public decimal DppRetenueonp { get;set; }   // Dossier_Prepension.Dpp_RetenueONP

      [Required]
      [Column("Dpp_RetenueONEM")]
      public decimal DppRetenueonem { get;set; }   // Dossier_Prepension.Dpp_RetenueONEM

      [Required]
      [Column("Dpp_RetenueFicale")]
      public decimal DppRetenueficale { get;set; }   // Dossier_Prepension.Dpp_RetenueFicale

      [Required]
      [Column("Dpp_IndemniteNette")]
      public decimal DppIndemnitenette { get;set; }   // Dossier_Prepension.Dpp_IndemniteNette

      [Required]
      [Column("Dpp_PrimeChomage")]
      public decimal DppPrimechomage { get;set; }   // Dossier_Prepension.Dpp_PrimeChomage

      [Required]
      [Column("Dpp_TypeDossier")]
      public string DppTypedossier { get;set; }   // Dossier_Prepension.Dpp_TypeDossier

      [Required]
      [Column("Dpp_Commentaire")]
      public string DppCommentaire { get;set; }   // Dossier_Prepension.Dpp_Commentaire

      [Required]
      [Column("Dpp_RepriseTravail")]
      public string DppReprisetravail { get;set; }   // Dossier_Prepension.Dpp_RepriseTravail

      [Required]
      [Column("Dpp_ModeCalcul")]
      public string DppModecalcul { get;set; }   // Dossier_Prepension.Dpp_ModeCalcul

      [Required]
      [Column("Dpp_DateNotification")]
      public DateTime DppDatenotification { get;set; }   // Dossier_Prepension.Dpp_DateNotification

      [Required]
      [Column("Dpp_CotisationPersonnelle")]
      public decimal DppCotisationpersonnelle { get;set; }   // Dossier_Prepension.Dpp_CotisationPersonnelle

      [Required]
      [Column("Dpp_EtatEmployeur")]
      public string DppEtatemployeur { get;set; }   // Dossier_Prepension.Dpp_EtatEmployeur

      [Required]
      [Column("Dpp_DateDebutEtat")]
      public DateTime DppDatedebutetat { get;set; }   // Dossier_Prepension.Dpp_DateDebutEtat

      [Required]
      [Column("Dpp_DateFinEtat")]
      public DateTime DppDatefinetat { get;set; }   // Dossier_Prepension.Dpp_DateFinEtat

      [Required]
      [Column("Dpp_Remplacement")]
      public string DppRemplacement { get;set; }   // Dossier_Prepension.Dpp_Remplacement

      [Required]
      [Column("Dpp_NissRemplacant")]
      public string DppNissremplacant { get;set; }   // Dossier_Prepension.Dpp_NissRemplacant

      [Required]
      [Column("Dpp_Reprise")]
      public string DppReprise { get;set; }   // Dossier_Prepension.Dpp_Reprise

      [Required]
      [Column("Dpp_DateDebutReprise")]
      public DateTime DppDatedebutreprise { get;set; }   // Dossier_Prepension.Dpp_DateDebutReprise

      [Required]
      [Column("Dpp_DateFinReprise")]
      public DateTime DppDatefinreprise { get;set; }   // Dossier_Prepension.Dpp_DateFinReprise

      [Required]
      [Column("Dpp_Frontalier")]
      public string DppFrontalier { get;set; }   // Dossier_Prepension.Dpp_Frontalier

      [Required]
      [Column("Dpp_Capitalisation")]
      public string DppCapitalisation { get;set; }   // Dossier_Prepension.Dpp_Capitalisation

      [Required]
      [Column("Dpp_CoeffCapitalisation")]
      public decimal DppCoeffcapitalisation { get;set; }   // Dossier_Prepension.Dpp_CoeffCapitalisation

      [Required]
      [Column("Dpp_IndemTheoriqueMensuelle")]
      public decimal DppIndemtheoriquemensuelle { get;set; }   // Dossier_Prepension.Dpp_IndemTheoriqueMensuelle

      [Column("Tra_ID")]
      public decimal TraId { get;set; }  // Dossier_Prepension.Tra_ID (ForeignKey)

      [Column("Aem_Id")]
      public decimal AemId { get;set; }  // Dossier_Prepension.Aem_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur_TraId { get; set; }

      [ForeignKey("AemId")]
      public virtual ActiviteEmployeur ActiviteEmployeur_AemId { get; set; }

   }

   [Table("Fonds")]
   public partial class Fonds
   {

      [Key]
      [Column("Fnd_ID")]
      public decimal FndId { get;set; }  // Fonds.Fnd_ID (PrimaryKey)

      [Required]
      [Column("Fnd_NomFR")]
      public string FndNomfr { get;set; }   // Fonds.Fnd_NomFR

      [Required]
      [Column("Fnd_NomNl")]
      public string FndNomnl { get;set; }   // Fonds.Fnd_NomNl

      [Required]
      [Column("Fnd_NomGE")]
      public string FndNomge { get;set; }   // Fonds.Fnd_NomGE

      [Required]
      [Column("Fnd_AdresseRueNL")]
      public string FndAdresseruenl { get;set; }   // Fonds.Fnd_AdresseRueNL

      [Required]
      [Column("Fnd_AdresseRueFR")]
      public string FndAdresseruefr { get;set; }   // Fonds.Fnd_AdresseRueFR

      [Required]
      [Column("Fnd_AdresseRueGE")]
      public string FndAdresseruege { get;set; }   // Fonds.Fnd_AdresseRueGE

      [Required]
      [Column("Fnd_AdresseNo")]
      public string FndAdresseno { get;set; }   // Fonds.Fnd_AdresseNo

      [Required]
      [Column("Fnd_AdresseBte")]
      public string FndAdressebte { get;set; }   // Fonds.Fnd_AdresseBte

      [Required]
      [Column("Fnd_CodePostal")]
      public string FndCodepostal { get;set; }   // Fonds.Fnd_CodePostal

      [Required]
      [Column("Fnd_LocaliteNL")]
      public string FndLocalitenl { get;set; }   // Fonds.Fnd_LocaliteNL

      [Required]
      [Column("Fnd_LocaliteFR")]
      public string FndLocalitefr { get;set; }   // Fonds.Fnd_LocaliteFR

      [Required]
      [Column("Fnd_LocaliteGE")]
      public string FndLocalitege { get;set; }   // Fonds.Fnd_LocaliteGE

      [Required]
      [Column("Fnd_CodePays")]
      public string FndCodepays { get;set; }   // Fonds.Fnd_CodePays

      [Required]
      [Column("Fnd_Telephone")]
      public string FndTelephone { get;set; }   // Fonds.Fnd_Telephone

      [Required]
      [Column("Fnd_Fax")]
      public string FndFax { get;set; }   // Fonds.Fnd_Fax

      [Required]
      [Column("Fnd_NomContact")]
      public string FndNomcontact { get;set; }   // Fonds.Fnd_NomContact

      [Required]
      [Column("Fnd_NissContact")]
      public string FndNisscontact { get;set; }   // Fonds.Fnd_NissContact

      [Required]
      [Column("Fnd_CodeEntreprise")]
      public string FndCodeentreprise { get;set; }   // Fonds.Fnd_CodeEntreprise

      [Required]
      [Column("Fnd_CompteBancaire")]
      public string FndComptebancaire { get;set; }   // Fonds.Fnd_CompteBancaire

      [Required]
      [Column("Fnd_IBAN")]
      public string FndIban { get;set; }   // Fonds.Fnd_IBAN

      [Required]
      [Column("Fnd_BIC")]
      public string FndBic { get;set; }   // Fonds.Fnd_BIC

      [Required]
      [Column("Fnd_Langue")]
      public string FndLangue { get;set; }   // Fonds.Fnd_Langue

      [Required]
      [Column("Fnd_NumeroDirReg")]
      public string FndNumerodirreg { get;set; }   // Fonds.Fnd_NumeroDirReg

      [Required]
      [Column("Fnd_NumeroBurRec")]
      public string FndNumeroburrec { get;set; }   // Fonds.Fnd_NumeroBurRec

      [Required]
      [Column("Fnd_NomBurRec")]
      public string FndNomburrec { get;set; }   // Fonds.Fnd_NomBurRec

      [Required]
      [Column("Fnd_NumeroAdmCD")]
      public string FndNumeroadmcd { get;set; }   // Fonds.Fnd_NumeroAdmCD

      [Required]
      [Column("Fnd_NumeroBurCtl")]
      public string FndNumeroburctl { get;set; }   // Fonds.Fnd_NumeroBurCtl

      [Required]
      [Column("Fnd_NomBurCtl")]
      public string FndNomburctl { get;set; }   // Fonds.Fnd_NomBurCtl

      [Required]
      [Column("Fnd_NomMandat")]
      public string FndNommandat { get;set; }   // Fonds.Fnd_NomMandat

      [Required]
      [Column("Fnd_AdresseRueMandat")]
      public string FndAdresseruemandat { get;set; }   // Fonds.Fnd_AdresseRueMandat

      [Required]
      [Column("Fnd_AdresseNoMandat")]
      public string FndAdressenomandat { get;set; }   // Fonds.Fnd_AdresseNoMandat

      [Required]
      [Column("Fnd_AdresseBteMandat")]
      public string FndAdressebtemandat { get;set; }   // Fonds.Fnd_AdresseBteMandat

      [Required]
      [Column("Fnd_CodePostalMandat")]
      public string FndCodepostalmandat { get;set; }   // Fonds.Fnd_CodePostalMandat

      [Required]
      [Column("Fnd_LocaliteMandat")]
      public string FndLocalitemandat { get;set; }   // Fonds.Fnd_LocaliteMandat

      [Required]
      [Column("Fnd_CodePaysMandat")]
      public string FndCodepaysmandat { get;set; }   // Fonds.Fnd_CodePaysMandat

      [Required]
      [Column("Fnd_TelephoneMandat")]
      public string FndTelephonemandat { get;set; }   // Fonds.Fnd_TelephoneMandat

      [Required]
      [Column("Fnd_FaxMandat")]
      public string FndFaxmandat { get;set; }   // Fonds.Fnd_FaxMandat

      [Required]
      [Column("Fnd_EmailContact")]
      public string FndEmailcontact { get;set; }   // Fonds.Fnd_EmailContact

      [Required]
      [Column("Fnd_BCE")]
      public string FndBce { get;set; }   // Fonds.Fnd_BCE

   }

   [Table("Att_A038")]
   public partial class AttA038
   {

      [Key]
      [Column("Att38_Id")]
      public decimal Att38Id { get;set; }  // Att_A038.Att38_Id (PrimaryKey)

      [Required]
      [Column("Att38_Active")]
      public string Att38Active { get;set; }   // Att_A038.Att38_Active

      [Required]
      [Column("Att38_INSS")]
      public string Att38Inss { get;set; }   // Att_A038.Att38_INSS

      [Required]
      [Column("Att38_AttestationID")]
      public string Att38Attestationid { get;set; }   // Att_A038.Att38_AttestationID

      [Required]
      [Column("Att38_SituationNbr")]
      public decimal Att38Situationnbr { get;set; }   // Att_A038.Att38_SituationNbr

      [Required]
      [Column("Att38_AttestationStatus")]
      public decimal Att38Attestationstatus { get;set; }   // Att_A038.Att38_AttestationStatus

      [Required]
      [Column("Att38_CreationDate")]
      public DateTime Att38Creationdate { get;set; }   // Att_A038.Att38_CreationDate

      [Required]
      [Column("Att38_HolidayYear")]
      public string Att38Holidayyear { get;set; }   // Att_A038.Att38_HolidayYear

      [Required]
      [Column("Att38_ContractType")]
      public string Att38Contracttype { get;set; }   // Att_A038.Att38_ContractType

      [Required]
      [Column("Att38_LegalSingleHolidaySavings")]
      public decimal Att38Legalsingleholidaysavings { get;set; }   // Att_A038.Att38_LegalSingleHolidaySavings

      [Required]
      [Column("Att38_LegalDoubleHolidaySavings")]
      public decimal Att38Legaldoubleholidaysavings { get;set; }   // Att_A038.Att38_LegalDoubleHolidaySavings

      [Required]
      [Column("Att38_LegalNbrOfDays")]
      public decimal Att38Legalnbrofdays { get;set; }   // Att_A038.Att38_LegalNbrOfDays

      [Required]
      [Column("Att38_TreatyHolidaySavings")]
      public decimal Att38Treatyholidaysavings { get;set; }   // Att_A038.Att38_TreatyHolidaySavings

      [Required]
      [Column("Att38_TreatyNbrOfDays")]
      public decimal Att38Treatynbrofdays { get;set; }   // Att_A038.Att38_TreatyNbrOfDays

      [Column("Snd38_Id")]
      public decimal Snd38Id { get;set; }  // Att_A038.Snd38_Id (ForeignKey)

      [Column("Tra_Id")]
      public decimal TraId { get;set; }  // Att_A038.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Snd38Id")]
      public virtual SendingA038 SendingA038_Snd38Id { get; set; }

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur_TraId { get; set; }

   }

   [Table("Att_A038_IndividualAtt")]
   public partial class AttA038Individualatt
   {

      [Key]
      [Column("Ind38_Id")]
      public decimal Ind38Id { get;set; }  // Att_A038_IndividualAtt.Ind38_Id (PrimaryKey)

      [Required]
      [Column("Ind38_AttestationID")]
      public string Ind38Attestationid { get;set; }   // Att_A038_IndividualAtt.Ind38_AttestationID

      [Required]
      [Column("Ind38_SituationNbr")]
      public decimal Ind38Situationnbr { get;set; }   // Att_A038_IndividualAtt.Ind38_SituationNbr

      [Required]
      [Column("Ind38_AttestationStatus")]
      public decimal Ind38Attestationstatus { get;set; }   // Att_A038_IndividualAtt.Ind38_AttestationStatus

      [Column("Att38_Id")]
      public decimal Att38Id { get;set; }  // Att_A038_IndividualAtt.Att38_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Att38Id")]
      public virtual AttA038 AttA038 { get; set; }

   }

   [Table("Ligne_Occupation")]
   public partial class LigneOccupation
   {

      [Key]
      [Column("Occ_Id")]
      public decimal OccId { get;set; }  // Ligne_Occupation.Occ_Id (PrimaryKey)

      [Required]
      [Column("Occ_NoAttestation")]
      public string OccNoattestation { get;set; }   // Ligne_Occupation.Occ_NoAttestation

      [Required]
      [Column("Occ_NoSituation")]
      public string OccNosituation { get;set; }   // Ligne_Occupation.Occ_NoSituation

      [Required]
      [Column("Occ_Trimestre")]
      public string OccTrimestre { get;set; }   // Ligne_Occupation.Occ_Trimestre

      [Required]
      [Column("Occ_DateDebutOccupation")]
      public DateTime OccDatedebutoccupation { get;set; }   // Ligne_Occupation.Occ_DateDebutOccupation

      [Required]
      [Column("Occ_DateFinOccupation")]
      public DateTime OccDatefinoccupation { get;set; }   // Ligne_Occupation.Occ_DateFinOccupation

      [Required]
      [Column("Occ_CommissionParitaire")]
      public string OccCommissionparitaire { get;set; }   // Ligne_Occupation.Occ_CommissionParitaire

      [Required]
      [Column("Occ_Regime")]
      public decimal OccRegime { get;set; }   // Ligne_Occupation.Occ_Regime

      [Required]
      [Column("Occ_HeuresSemTrav")]
      public decimal OccHeuressemtrav { get;set; }   // Ligne_Occupation.Occ_HeuresSemTrav

      [Required]
      [Column("Occ_HeuresSemTravRef")]
      public decimal OccHeuressemtravref { get;set; }   // Ligne_Occupation.Occ_HeuresSemTravRef

      [Required]
      [Column("Occ_TypeContrat")]
      public string OccTypecontrat { get;set; }   // Ligne_Occupation.Occ_TypeContrat

      [Required]
      [Column("Occ_ReorganTravail")]
      public string OccReorgantravail { get;set; }   // Ligne_Occupation.Occ_ReorganTravail

      [Required]
      [Column("Occ_PromotionEmploi")]
      public string OccPromotionemploi { get;set; }   // Ligne_Occupation.Occ_PromotionEmploi

      [Required]
      [Column("Occ_StatutTravailleur")]
      public string OccStatuttravailleur { get;set; }   // Ligne_Occupation.Occ_StatutTravailleur

      [Required]
      [Column("Occ_Pensionne")]
      public string OccPensionne { get;set; }   // Ligne_Occupation.Occ_Pensionne

      [Required]
      [Column("Occ_TypeApprenti")]
      public string OccTypeapprenti { get;set; }   // Ligne_Occupation.Occ_TypeApprenti

      [Required]
      [Column("Occ_ModeRemuneration")]
      public string OccModeremuneration { get;set; }   // Ligne_Occupation.Occ_ModeRemuneration

      [Required]
      [Column("Occ_FractionPrestation")]
      public decimal OccFractionprestation { get;set; }   // Ligne_Occupation.Occ_FractionPrestation

      [Required]
      [Column("Occ_JustificationJours")]
      public string OccJustificationjours { get;set; }   // Ligne_Occupation.Occ_JustificationJours

      [Required]
      [Column("Occ_TextLibre")]
      public string OccTextlibre { get;set; }   // Ligne_Occupation.Occ_TextLibre

      [Required]
      [Column("Occ_NoUniteLocale")]
      public string OccNounitelocale { get;set; }   // Ligne_Occupation.Occ_NoUniteLocale

      [Required]
      [Column("Occ_NISUniteLocale")]
      public string OccNisunitelocale { get;set; }   // Ligne_Occupation.Occ_NISUniteLocale

      [Required]
      [Column("Occ_CodeRegionalisation")]
      public string OccCoderegionalisation { get;set; }   // Ligne_Occupation.Occ_CodeRegionalisation

      [Required]
      [Column("Occ_CodeFonction")]
      public string OccCodefonction { get;set; }   // Ligne_Occupation.Occ_CodeFonction

      [Column("Ltr_Id")]
      public decimal LtrId { get;set; }  // Ligne_Occupation.Ltr_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("LtrId")]
      public virtual LigneTravailleur LigneTravailleur { get; set; }

   }

   [Table("Pension")]
   public partial class Pension
   {

      [Key]
      [Column("Pen_Id")]
      public decimal PenId { get;set; }  // Pension.Pen_Id (PrimaryKey)

      [Required]
      [Column("Pen_Niss")]
      public string PenNiss { get;set; }   // Pension.Pen_Niss

      [Required]
      [Column("Pen_Etat")]
      public string PenEtat { get;set; }   // Pension.Pen_Etat

      [Required]
      [Column("Pen_DateCreation")]
      public DateTime PenDatecreation { get;set; }   // Pension.Pen_DateCreation

      [Required]
      [Column("Pen_NoPolice")]
      public string PenNopolice { get;set; }   // Pension.Pen_NoPolice

      [Required]
      [Column("Pen_DroitAcquis")]
      public string PenDroitacquis { get;set; }   // Pension.Pen_DroitAcquis

      [Required]
      [Column("Pen_TrimestrePremier")]
      public string PenTrimestrepremier { get;set; }   // Pension.Pen_TrimestrePremier

      [Required]
      [Column("Pen_TrimestreDernier")]
      public string PenTrimestredernier { get;set; }   // Pension.Pen_TrimestreDernier

      [Required]
      [Column("Pen_TypeLiquidation")]
      public string PenTypeliquidation { get;set; }   // Pension.Pen_TypeLiquidation

      [Required]
      [Column("Pen_DateLiquidation")]
      public DateTime PenDateliquidation { get;set; }   // Pension.Pen_DateLiquidation

      [Required]
      [Column("Pen_TexteLibre")]
      public string PenTextelibre { get;set; }   // Pension.Pen_TexteLibre

      [Required]
      [Column("Pen_PrimeDeces")]
      public string PenPrimedeces { get;set; }   // Pension.Pen_PrimeDeces

      [Required]
      [Column("Pen_NoExport")]
      public string PenNoexport { get;set; }   // Pension.Pen_NoExport

      [Required]
      [Column("Pen_TypeLiquidationPrecedent")]
      public string PenTypeliquidationprecedent { get;set; }   // Pension.Pen_TypeLiquidationPrecedent

      [Column("Tra_Id")]
      public decimal TraId { get;set; }  // Pension.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur { get; set; }

   }

   [Table("Pension_Contrat")]
   public partial class PensionContrat
   {

      [Key]
      [Column("Dct_Id")]
      public decimal DctId { get;set; }  // Pension_Contrat.Dct_Id (PrimaryKey)

      [Required]
      [Column("Dct_Niss")]
      public string DctNiss { get;set; }   // Pension_Contrat.Dct_Niss

      [Required]
      [Column("Dct_Onss")]
      public string DctOnss { get;set; }   // Pension_Contrat.Dct_Onss

      [Required]
      [Column("Dct_Exercice")]
      public string DctExercice { get;set; }   // Pension_Contrat.Dct_Exercice

      [Required]
      [Column("Dct_JoursOnss")]
      public decimal DctJoursonss { get;set; }   // Pension_Contrat.Dct_JoursOnss

      [Required]
      [Column("Dct_SalaireBrut")]
      public decimal DctSalairebrut { get;set; }   // Pension_Contrat.Dct_SalaireBrut

      [Required]
      [Column("Dct_PrimeInactivite")]
      public decimal DctPrimeinactivite { get;set; }   // Pension_Contrat.Dct_PrimeInactivite

      [Required]
      [Column("Dct_TexteLibre")]
      public string DctTextelibre { get;set; }   // Pension_Contrat.Dct_TexteLibre

      [Column("Dtr_Id")]
      public decimal DtrId { get;set; }  // Pension_Contrat.Dtr_Id (ForeignKey)

      [Column("Con_Id")]
      public decimal ConId { get;set; }  // Pension_Contrat.Con_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DtrId")]
      public virtual PensionTravailleur PensionTravailleur_DtrId { get; set; }

      [ForeignKey("ConId")]
      public virtual Contrat Contrat_ConId { get; set; }

   }

   [Table("Att_A045_DecisionDetail")]
   public partial class AttA045Decisiondetail
   {

      [Key]
      [Column("Det45_Id")]
      public decimal Det45Id { get;set; }  // Att_A045_DecisionDetail.Det45_Id (PrimaryKey)

      [Required]
      [Column("Det45_BeginDate")]
      public DateTime Det45Begindate { get;set; }   // Att_A045_DecisionDetail.Det45_BeginDate

      [Required]
      [Column("Det45_EndDate")]
      public DateTime Det45Enddate { get;set; }   // Att_A045_DecisionDetail.Det45_EndDate

      [Required]
      [Column("Det45_GlobalPercentage")]
      public decimal Det45Globalpercentage { get;set; }   // Att_A045_DecisionDetail.Det45_GlobalPercentage

      [Required]
      [Column("Det45_PhysicalPercentage")]
      public decimal Det45Physicalpercentage { get;set; }   // Att_A045_DecisionDetail.Det45_PhysicalPercentage

      [Required]
      [Column("Det45_SocioEconomicPercentage")]
      public decimal Det45Socioeconomicpercentage { get;set; }   // Att_A045_DecisionDetail.Det45_SocioEconomicPercentage

      [Required]
      [Column("Det45_AgePercentage")]
      public decimal Det45Agepercentage { get;set; }   // Att_A045_DecisionDetail.Det45_AgePercentage

      [Required]
      [Column("Det45_AbsencePercentage")]
      public decimal Det45Absencepercentage { get;set; }   // Att_A045_DecisionDetail.Det45_AbsencePercentage

      [Column("Dcn45_Id")]
      public decimal Dcn45Id { get;set; }  // Att_A045_DecisionDetail.Dcn45_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Dcn45Id")]
      public virtual AttA045Decisionfbzfmp AttA045Decisionfbzfmp { get; set; }

   }

   [Table("Att_A052")]
   public partial class AttA052
   {

      [Key]
      [Column("Att52_Id")]
      public decimal Att52Id { get;set; }  // Att_A052.Att52_Id (PrimaryKey)

      [Required]
      [Column("Att52_Active")]
      public string Att52Active { get;set; }   // Att_A052.Att52_Active

      [Required]
      [Column("Att52_INSS")]
      public string Att52Inss { get;set; }   // Att_A052.Att52_INSS

      [Required]
      [Column("Att52_AttestationID")]
      public string Att52Attestationid { get;set; }   // Att_A052.Att52_AttestationID

      [Required]
      [Column("Att52_SituationNbr")]
      public decimal Att52Situationnbr { get;set; }   // Att_A052.Att52_SituationNbr

      [Required]
      [Column("Att52_AttestationStatus")]
      public decimal Att52Attestationstatus { get;set; }   // Att_A052.Att52_AttestationStatus

      [Required]
      [Column("Att52_CreationDate")]
      public DateTime Att52Creationdate { get;set; }   // Att_A052.Att52_CreationDate

      [Required]
      [Column("Att52_Quarter")]
      public string Att52Quarter { get;set; }   // Att_A052.Att52_Quarter

      [Column("Snd52_Id")]
      public decimal Snd52Id { get;set; }  // Att_A052.Snd52_Id (ForeignKey)

      [Column("Tra_Id")]
      public decimal TraId { get;set; }  // Att_A052.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Snd52Id")]
      public virtual SendingA052 SendingA052_Snd52Id { get; set; }

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur_TraId { get; set; }

   }

   [Table("Att_A052_Activity")]
   public partial class AttA052Activity
   {

      [Key]
      [Column("Act52_Id")]
      public decimal Act52Id { get;set; }  // Att_A052_Activity.Act52_Id (PrimaryKey)

      [Required]
      [Column("Att52_Id")]
      public decimal Att52Id { get;set; }   // Att_A052_Activity.Att52_Id

      [Required]
      [Column("Act52_NOSSRegistrationNbr")]
      public string Act52Nossregistrationnbr { get;set; }   // Att_A052_Activity.Act52_NOSSRegistrationNbr

      [Required]
      [Column("Act52_CompanyID")]
      public string Act52Companyid { get;set; }   // Att_A052_Activity.Act52_CompanyID

      [Required]
      [Column("Act52_EmployerClass")]
      public string Act52Employerclass { get;set; }   // Att_A052_Activity.Act52_EmployerClass

      [Required]
      [Column("Act52_OccupationBeginDate")]
      public DateTime Act52Occupationbegindate { get;set; }   // Att_A052_Activity.Act52_OccupationBeginDate

      [Required]
      [Column("Act52_JointCommissionNbr")]
      public string Act52Jointcommissionnbr { get;set; }   // Att_A052_Activity.Act52_JointCommissionNbr

      [Required]
      [Column("Act52_WorkerCode")]
      public string Act52Workercode { get;set; }   // Att_A052_Activity.Act52_WorkerCode

      [Required]
      [Column("Act52_MeanWorkingHours")]
      public decimal Act52Meanworkinghours { get;set; }   // Att_A052_Activity.Act52_MeanWorkingHours

      [Required]
      [Column("Act52_RefMeanWorkingHours")]
      public decimal Act52Refmeanworkinghours { get;set; }   // Att_A052_Activity.Act52_RefMeanWorkingHours

      [Required]
      [Column("Act52_WorkerStatus")]
      public string Act52Workerstatus { get;set; }   // Att_A052_Activity.Act52_WorkerStatus

      [Required]
      [Column("Act52_InternalOccupationNbr")]
      public string Act52Internaloccupationnbr { get;set; }   // Att_A052_Activity.Act52_InternalOccupationNbr

      [Column("Act52_Id")]
      public decimal Act52Id { get;set; }  // Att_A052_Activity.Act52_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Act52Id")]
      public virtual AttA052 AttA052 { get; set; }

   }

   [Table("Att_A052_DecisionNicCin")]
   public partial class AttA052Decisionniccin
   {

      [Key]
      [Column("Dcn52_Id")]
      public decimal Dcn52Id { get;set; }  // Att_A052_DecisionNicCin.Dcn52_Id (PrimaryKey)

      [Required]
      [Column("Dcn52_DayType")]
      public string Dcn52Daytype { get;set; }   // Att_A052_DecisionNicCin.Dcn52_DayType

      [Required]
      [Column("Dcn52_DurationUnit")]
      public string Dcn52Durationunit { get;set; }   // Att_A052_DecisionNicCin.Dcn52_DurationUnit

      [Required]
      [Column("Dcn52_DurationValue")]
      public decimal Dcn52Durationvalue { get;set; }   // Att_A052_DecisionNicCin.Dcn52_DurationValue

      [Required]
      [Column("Dcn52_AllowanceType")]
      public string Dcn52Allowancetype { get;set; }   // Att_A052_DecisionNicCin.Dcn52_AllowanceType

      [Required]
      [Column("Dcn52_KindOfAllowance")]
      public string Dcn52Kindofallowance { get;set; }   // Att_A052_DecisionNicCin.Dcn52_KindOfAllowance

      [Required]
      [Column("Dcn52_BeginDate")]
      public DateTime Dcn52Begindate { get;set; }   // Att_A052_DecisionNicCin.Dcn52_BeginDate

      [Required]
      [Column("Dcn52_EndDate")]
      public DateTime Dcn52Enddate { get;set; }   // Att_A052_DecisionNicCin.Dcn52_EndDate

      [Column("Att52_Id")]
      public decimal Att52Id { get;set; }  // Att_A052_DecisionNicCin.Att52_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Att52Id")]
      public virtual AttA052 AttA052 { get; set; }

   }

   [Table("Sending_A038")]
   public partial class SendingA038
   {

      [Key]
      [Column("Snd38_Id")]
      public decimal Snd38Id { get;set; }  // Sending_A038.Snd38_Id (PrimaryKey)

      [Required]
      [Column("Snd38_Number")]
      public string Snd38Number { get;set; }   // Sending_A038.Snd38_Number

      [Required]
      [Column("Snd38_SendingDate")]
      public DateTime Snd38Sendingdate { get;set; }   // Sending_A038.Snd38_SendingDate

      [Required]
      [Column("Snd38_CreationDate")]
      public DateTime Snd38Creationdate { get;set; }   // Sending_A038.Snd38_CreationDate

      [Required]
      [Column("Snd38_AttestationCount")]
      public decimal Snd38Attestationcount { get;set; }   // Sending_A038.Snd38_AttestationCount

   }

   [Table("Prestation")]
   public partial class Prestation
   {

      [Key]
      [Column("Prs_Id")]
      public decimal PrsId { get;set; }  // Prestation.Prs_Id (PrimaryKey)

      [Required]
      [Column("Prs_NoAttestation")]
      public string PrsNoattestation { get;set; }   // Prestation.Prs_NoAttestation

      [Required]
      [Column("Prs_NoSituation")]
      public string PrsNosituation { get;set; }   // Prestation.Prs_NoSituation

      [Required]
      [Column("Prs_Trimestre")]
      public string PrsTrimestre { get;set; }   // Prestation.Prs_Trimestre

      [Required]
      [Column("Prs_NoLignePrestation")]
      public string PrsNoligneprestation { get;set; }   // Prestation.Prs_NoLignePrestation

      [Required]
      [Column("Prs_CodePrestation")]
      public string PrsCodeprestation { get;set; }   // Prestation.Prs_CodePrestation

      [Required]
      [Column("Prs_JoursPrestation")]
      public decimal PrsJoursprestation { get;set; }   // Prestation.Prs_JoursPrestation

      [Required]
      [Column("Prs_HeuresPrestation")]
      public decimal PrsHeuresprestation { get;set; }   // Prestation.Prs_HeuresPrestation

      [Required]
      [Column("Prs_TextLibre")]
      public string PrsTextlibre { get;set; }   // Prestation.Prs_TextLibre

      [Column("Occ_Id")]
      public decimal OccId { get;set; }  // Prestation.Occ_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("OccId")]
      public virtual LigneOccupation LigneOccupation { get; set; }

   }

   [Table("Anciennete_Contrat")]
   public partial class AncienneteContrat
   {

      [Key]
      [Column("Anc_Id")]
      public decimal AncId { get;set; }  // Anciennete_Contrat.Anc_Id (PrimaryKey)

      [Required]
      [Column("Anc_Niss")]
      public string AncNiss { get;set; }   // Anciennete_Contrat.Anc_Niss

      [Required]
      [Column("Anc_Onss")]
      public string AncOnss { get;set; }   // Anciennete_Contrat.Anc_Onss

      [Required]
      [Column("Anc_NoCalcul")]
      public string AncNocalcul { get;set; }   // Anciennete_Contrat.Anc_NoCalcul

      [Required]
      [Column("Anc_TrimestreCalcul")]
      public string AncTrimestrecalcul { get;set; }   // Anciennete_Contrat.Anc_TrimestreCalcul

      [Required]
      [Column("Anc_DebutDerniereOccup")]
      public DateTime AncDebutderniereoccup { get;set; }   // Anciennete_Contrat.Anc_DebutDerniereOccup

      [Required]
      [Column("Anc_FinDerniereOccup")]
      public DateTime AncFinderniereoccup { get;set; }   // Anciennete_Contrat.Anc_FinDerniereOccup

      [Required]
      [Column("Anc_DateAnciennete")]
      public DateTime AncDateanciennete { get;set; }   // Anciennete_Contrat.Anc_DateAnciennete

      [Required]
      [Column("Anc_IndemniteRupture")]
      public string AncIndemniterupture { get;set; }   // Anciennete_Contrat.Anc_IndemniteRupture

      [Required]
      [Column("Anc_Anomalie")]
      public string AncAnomalie { get;set; }   // Anciennete_Contrat.Anc_Anomalie

      [Required]
      [Column("Anc_RaisonAnomalie")]
      public string AncRaisonanomalie { get;set; }   // Anciennete_Contrat.Anc_RaisonAnomalie

      [Required]
      [Column("Anc_TexteLibre")]
      public string AncTextelibre { get;set; }   // Anciennete_Contrat.Anc_TexteLibre

      [Column("Con_Id")]
      public decimal ConId { get;set; }  // Anciennete_Contrat.Con_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("ConId")]
      public virtual Contrat Contrat { get; set; }

   }

   [Table("Declaration_CotisationPrepension")]
   public partial class DeclarationCotisationprepension
   {

      [Key]
      [Column("Dcp_Id")]
      public decimal DcpId { get;set; }  // Declaration_CotisationPrepension.Dcp_Id (PrimaryKey)

      [Required]
      [Column("Dcp_CotisationPersonnelle")]
      public decimal DcpCotisationpersonnelle { get;set; }   // Declaration_CotisationPrepension.Dcp_CotisationPersonnelle

      [Required]
      [Column("Dcp_CotisationPatronale")]
      public decimal DcpCotisationpatronale { get;set; }   // Declaration_CotisationPrepension.Dcp_CotisationPatronale

      [Required]
      [Column("Dcp_CotisationCompensatoire")]
      public decimal DcpCotisationcompensatoire { get;set; }   // Declaration_CotisationPrepension.Dcp_CotisationCompensatoire

      [Column("Dtv_Id")]
      public decimal DtvId { get;set; }  // Declaration_CotisationPrepension.Dtv_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DtvId")]
      public virtual DeclarationTravailleur DeclarationTravailleur { get; set; }

   }

   [Table("Declaration_Onss")]
   public partial class DeclarationOnss
   {

      [Key]
      [Column("Dec_Id")]
      public decimal DecId { get;set; }  // Declaration_Onss.Dec_Id (PrimaryKey)

      [Required]
      [Column("Dec_Type")]
      public string DecType { get;set; }   // Declaration_Onss.Dec_Type

      [Required]
      [Column("Dec_Trimestre")]
      public string DecTrimestre { get;set; }   // Declaration_Onss.Dec_Trimestre

      [Required]
      [Column("Dec_Onss")]
      public string DecOnss { get;set; }   // Declaration_Onss.Dec_Onss

      [Required]
      [Column("Dec_DeclarationPID")]
      public decimal DecDeclarationpid { get;set; }   // Declaration_Onss.Dec_DeclarationPID

   }

   [Table("Sending_A045")]
   public partial class SendingA045
   {

      [Key]
      [Column("Snd45_Id")]
      public decimal Snd45Id { get;set; }  // Sending_A045.Snd45_Id (PrimaryKey)

      [Required]
      [Column("Snd45_Number")]
      public string Snd45Number { get;set; }   // Sending_A045.Snd45_Number

      [Required]
      [Column("Snd45_SendingDate")]
      public DateTime Snd45Sendingdate { get;set; }   // Sending_A045.Snd45_SendingDate

      [Required]
      [Column("Snd45_CreationDate")]
      public DateTime Snd45Creationdate { get;set; }   // Sending_A045.Snd45_CreationDate

      [Required]
      [Column("Snd45_AttestationCount")]
      public decimal Snd45Attestationcount { get;set; }   // Sending_A045.Snd45_AttestationCount

   }

   [Table("Sending_A052")]
   public partial class SendingA052
   {

      [Key]
      [Column("Snd52_Id")]
      public decimal Snd52Id { get;set; }  // Sending_A052.Snd52_Id (PrimaryKey)

      [Required]
      [Column("Snd52_Number")]
      public string Snd52Number { get;set; }   // Sending_A052.Snd52_Number

      [Required]
      [Column("Snd52_SendingDate")]
      public DateTime Snd52Sendingdate { get;set; }   // Sending_A052.Snd52_SendingDate

      [Required]
      [Column("Snd52_CreationDate")]
      public DateTime Snd52Creationdate { get;set; }   // Sending_A052.Snd52_CreationDate

      [Required]
      [Column("Snd52_AttestationCount")]
      public decimal Snd52Attestationcount { get;set; }   // Sending_A052.Snd52_AttestationCount

   }

   [Table("Batch_Schedule_New")]
   public partial class BatchScheduleNew
   {

      [Key]
      [Column("Bat_Id")]
      public decimal BatId { get;set; }  // Batch_Schedule_New.Bat_Id (PrimaryKey)

      [Required]
      [Column("Bat_Type")]
      public string BatType { get;set; }   // Batch_Schedule_New.Bat_Type

      [Required]
      [Column("Bat_Description")]
      public string BatDescription { get;set; }   // Batch_Schedule_New.Bat_Description

      [Required]
      [Column("Bat_Etat")]
      public string BatEtat { get;set; }   // Batch_Schedule_New.Bat_Etat

      [Required]
      [Column("Bat_Parametres")]
      public string BatParametres { get;set; }   // Batch_Schedule_New.Bat_Parametres

      [Required]
      [Column("Bat_Priorite")]
      public decimal BatPriorite { get;set; }   // Batch_Schedule_New.Bat_Priorite

      [Required]
      [Column("Bat_DatePlanifiee")]
      public DateTime BatDateplanifiee { get;set; }   // Batch_Schedule_New.Bat_DatePlanifiee

      [Required]
      [Column("Bat_DateDebutExecution")]
      public DateTime BatDatedebutexecution { get;set; }   // Batch_Schedule_New.Bat_DateDebutExecution

      [Required]
      [Column("Bat_DateFinExecution")]
      public DateTime BatDatefinexecution { get;set; }   // Batch_Schedule_New.Bat_DateFinExecution

      [Required]
      [Column("Bat_Erreur")]
      public string BatErreur { get;set; }   // Batch_Schedule_New.Bat_Erreur

      [Required]
      [Column("Bat_SqlText")]
      public string BatSqltext { get;set; }   // Batch_Schedule_New.Bat_SqlText

      [Required]
      [Column("Bat_Keywords")]
      public string BatKeywords { get;set; }   // Batch_Schedule_New.Bat_Keywords

      [Required]
      [Column("Bat_NombreTotal")]
      public decimal BatNombretotal { get;set; }   // Batch_Schedule_New.Bat_NombreTotal

      [Required]
      [Column("Bat_NombreTraites")]
      public decimal BatNombretraites { get;set; }   // Batch_Schedule_New.Bat_NombreTraites

      [Required]
      [Column("Bat_NombreErreurs")]
      public decimal BatNombreerreurs { get;set; }   // Batch_Schedule_New.Bat_NombreErreurs

      [Required]
      [Column("Bat_NomFichierLog")]
      public string BatNomfichierlog { get;set; }   // Batch_Schedule_New.Bat_NomFichierLog

      [Required]
      [Column("Bat_WebApp")]
      public decimal BatWebapp { get;set; }   // Batch_Schedule_New.Bat_WebApp

      [Required]
      [Column("Bat_UserLogin")]
      public string BatUserlogin { get;set; }   // Batch_Schedule_New.Bat_UserLogin

   }

   [Table("Prime_Contrat")]
   public partial class PrimeContrat
   {

      [Key]
      [Column("Pct_Id")]
      public decimal PctId { get;set; }  // Prime_Contrat.Pct_Id (PrimaryKey)

      [Required]
      [Column("Pct_Exercice")]
      public string PctExercice { get;set; }   // Prime_Contrat.Pct_Exercice

      [Required]
      [Column("Pct_Niss")]
      public string PctNiss { get;set; }   // Prime_Contrat.Pct_Niss

      [Required]
      [Column("Pct_ONSS")]
      public string PctOnss { get;set; }   // Prime_Contrat.Pct_ONSS

      [Required]
      [Column("Pct_SalaireReel")]
      public decimal PctSalairereel { get;set; }   // Prime_Contrat.Pct_SalaireReel

      [Required]
      [Column("Pct_SalaireAssimile")]
      public decimal PctSalaireassimile { get;set; }   // Prime_Contrat.Pct_SalaireAssimile

      [Required]
      [Column("Pct_JoursPrestes")]
      public decimal PctJoursprestes { get;set; }   // Prime_Contrat.Pct_JoursPrestes

      [Required]
      [Column("Pct_JoursVacances")]
      public decimal PctJoursvacances { get;set; }   // Prime_Contrat.Pct_JoursVacances

      [Required]
      [Column("Pct_JoursMaladie")]
      public decimal PctJoursmaladie { get;set; }   // Prime_Contrat.Pct_JoursMaladie

      [Required]
      [Column("Pct_JoursMaternite")]
      public decimal PctJoursmaternite { get;set; }   // Prime_Contrat.Pct_JoursMaternite

      [Required]
      [Column("Pct_JoursAssimiles")]
      public decimal PctJoursassimiles { get;set; }   // Prime_Contrat.Pct_JoursAssimiles

      [Required]
      [Column("Pct_PrimeBrute")]
      public decimal PctPrimebrute { get;set; }   // Prime_Contrat.Pct_PrimeBrute

      [Required]
      [Column("Pct_RetenueONSS")]
      public decimal PctRetenueonss { get;set; }   // Prime_Contrat.Pct_RetenueONSS

      [Required]
      [Column("Pct_BaseImposable")]
      public decimal PctBaseimposable { get;set; }   // Prime_Contrat.Pct_BaseImposable

      [Required]
      [Column("Pct_RetenueFiscale")]
      public decimal PctRetenuefiscale { get;set; }   // Prime_Contrat.Pct_RetenueFiscale

      [Required]
      [Column("Pct_PrimeNette")]
      public decimal PctPrimenette { get;set; }   // Prime_Contrat.Pct_PrimeNette

      [Required]
      [Column("Pct_SFJCalcule")]
      public decimal PctSfjcalcule { get;set; }   // Prime_Contrat.Pct_SFJCalcule

      [Required]
      [Column("Pct_SFJManuel")]
      public decimal PctSfjmanuel { get;set; }   // Prime_Contrat.Pct_SFJManuel

      [Required]
      [Column("Pct_SalaireReelT1")]
      public decimal PctSalairereelt1 { get;set; }   // Prime_Contrat.Pct_SalaireReelT1

      [Required]
      [Column("Pct_SalaireReelT2")]
      public decimal PctSalairereelt2 { get;set; }   // Prime_Contrat.Pct_SalaireReelT2

      [Required]
      [Column("Pct_SalaireReelT3")]
      public decimal PctSalairereelt3 { get;set; }   // Prime_Contrat.Pct_SalaireReelT3

      [Required]
      [Column("Pct_SalaireReelT4")]
      public decimal PctSalairereelt4 { get;set; }   // Prime_Contrat.Pct_SalaireReelT4

      [Required]
      [Column("Pct_JoursPrestesT1")]
      public decimal PctJoursprestest1 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT1

      [Required]
      [Column("Pct_JoursPrestesT2")]
      public decimal PctJoursprestest2 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT2

      [Required]
      [Column("Pct_JoursPrestesT3")]
      public decimal PctJoursprestest3 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT3

      [Required]
      [Column("Pct_JoursPrestesT4")]
      public decimal PctJoursprestest4 { get;set; }   // Prime_Contrat.Pct_JoursPrestesT4

      [Required]
      [Column("Pct_NombreCasT1")]
      public decimal PctNombrecast1 { get;set; }   // Prime_Contrat.Pct_NombreCasT1

      [Required]
      [Column("Pct_NombreCasT2")]
      public decimal PctNombrecast2 { get;set; }   // Prime_Contrat.Pct_NombreCasT2

      [Required]
      [Column("Pct_NombreCasT3")]
      public decimal PctNombrecast3 { get;set; }   // Prime_Contrat.Pct_NombreCasT3

      [Required]
      [Column("Pct_NombreCasT4")]
      public decimal PctNombrecast4 { get;set; }   // Prime_Contrat.Pct_NombreCasT4

      [Column("Ptr_Id")]
      public decimal PtrId { get;set; }  // Prime_Contrat.Ptr_Id (ForeignKey)

      [Column("Con_ID")]
      public decimal ConId { get;set; }  // Prime_Contrat.Con_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("PtrId")]
      public virtual PrimeTravailleur PrimeTravailleur_PtrId { get; set; }

      [ForeignKey("ConId")]
      public virtual Contrat Contrat_ConId { get; set; }

   }

   [Table("Mutation_ONSS")]
   public partial class MutationOnss
   {

      [Key]
      [Column("Muo_Id")]
      public decimal MuoId { get;set; }  // Mutation_ONSS.Muo_Id (PrimaryKey)

      [Required]
      [Column("Muo_ONSSOrigine")]
      public string MuoOnssorigine { get;set; }   // Mutation_ONSS.Muo_ONSSOrigine

      [Required]
      [Column("Muo_ONSSDestination")]
      public string MuoOnssdestination { get;set; }   // Mutation_ONSS.Muo_ONSSDestination

      [Required]
      [Column("Muo_BCEOrigine")]
      public string MuoBceorigine { get;set; }   // Mutation_ONSS.Muo_BCEOrigine

      [Required]
      [Column("Muo_BCEDestination")]
      public string MuoBcedestination { get;set; }   // Mutation_ONSS.Muo_BCEDestination

      [Required]
      [Column("Muo_DateMutation")]
      public DateTime MuoDatemutation { get;set; }   // Mutation_ONSS.Muo_DateMutation

      [Required]
      [Column("Muo_TypeMutation")]
      public string MuoTypemutation { get;set; }   // Mutation_ONSS.Muo_TypeMutation

      [Column("Emp_Id")]
      public decimal EmpId { get;set; }  // Mutation_ONSS.Emp_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("EmpId")]
      public virtual Employeur Employeur { get; set; }

   }

   [Table("Remuneration")]
   public partial class Remuneration
   {

      [Key]
      [Column("Rem_Id")]
      public decimal RemId { get;set; }  // Remuneration.Rem_Id (PrimaryKey)

      [Required]
      [Column("Rem_NoAttestation")]
      public string RemNoattestation { get;set; }   // Remuneration.Rem_NoAttestation

      [Required]
      [Column("Rem_NoSituation")]
      public string RemNosituation { get;set; }   // Remuneration.Rem_NoSituation

      [Required]
      [Column("Rem_Trimestre")]
      public string RemTrimestre { get;set; }   // Remuneration.Rem_Trimestre

      [Required]
      [Column("Rem_NoLigneRemuneration")]
      public string RemNoligneremuneration { get;set; }   // Remuneration.Rem_NoLigneRemuneration

      [Required]
      [Column("Rem_CodeRemuneration")]
      public string RemCoderemuneration { get;set; }   // Remuneration.Rem_CodeRemuneration

      [Required]
      [Column("Rem_SalaireBrut")]
      public decimal RemSalairebrut { get;set; }   // Remuneration.Rem_SalaireBrut

      [Required]
      [Column("Rem_TextLibre")]
      public string RemTextlibre { get;set; }   // Remuneration.Rem_TextLibre

      [Column("Occ_Id")]
      public decimal OccId { get;set; }  // Remuneration.Occ_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("OccId")]
      public virtual LigneOccupation LigneOccupation { get; set; }

   }

   [Table("Prime_Travailleur")]
   public partial class PrimeTravailleur
   {

      [Key]
      [Column("Ptr_Id")]
      public decimal PtrId { get;set; }  // Prime_Travailleur.Ptr_Id (PrimaryKey)

      [Required]
      [Column("Ptr_Exercice")]
      public string PtrExercice { get;set; }   // Prime_Travailleur.Ptr_Exercice

      [Required]
      [Column("Ptr_Niss")]
      public string PtrNiss { get;set; }   // Prime_Travailleur.Ptr_Niss

      [Required]
      [Column("Ptr_SalaireReel")]
      public decimal PtrSalairereel { get;set; }   // Prime_Travailleur.Ptr_SalaireReel

      [Required]
      [Column("Ptr_SalaireAssimile")]
      public decimal PtrSalaireassimile { get;set; }   // Prime_Travailleur.Ptr_SalaireAssimile

      [Required]
      [Column("Ptr_JoursPrestes")]
      public decimal PtrJoursprestes { get;set; }   // Prime_Travailleur.Ptr_JoursPrestes

      [Required]
      [Column("Ptr_JoursVacances")]
      public decimal PtrJoursvacances { get;set; }   // Prime_Travailleur.Ptr_JoursVacances

      [Required]
      [Column("Ptr_JoursMaladie")]
      public decimal PtrJoursmaladie { get;set; }   // Prime_Travailleur.Ptr_JoursMaladie

      [Required]
      [Column("Ptr_JoursMaternite")]
      public decimal PtrJoursmaternite { get;set; }   // Prime_Travailleur.Ptr_JoursMaternite

      [Required]
      [Column("Ptr_JoursAssimiles")]
      public decimal PtrJoursassimiles { get;set; }   // Prime_Travailleur.Ptr_JoursAssimiles

      [Required]
      [Column("Ptr_PrimeBrute")]
      public decimal PtrPrimebrute { get;set; }   // Prime_Travailleur.Ptr_PrimeBrute

      [Required]
      [Column("Ptr_RetenueONSS")]
      public decimal PtrRetenueonss { get;set; }   // Prime_Travailleur.Ptr_RetenueONSS

      [Required]
      [Column("Ptr_BaseImposable")]
      public decimal PtrBaseimposable { get;set; }   // Prime_Travailleur.Ptr_BaseImposable

      [Required]
      [Column("Ptr_Frontalier")]
      public string PtrFrontalier { get;set; }   // Prime_Travailleur.Ptr_Frontalier

      [Required]
      [Column("Ptr_RetenueFiscale")]
      public decimal PtrRetenuefiscale { get;set; }   // Prime_Travailleur.Ptr_RetenueFiscale

      [Required]
      [Column("Ptr_PrimeNette")]
      public decimal PtrPrimenette { get;set; }   // Prime_Travailleur.Ptr_PrimeNette

      [Required]
      [Column("Ptr_PrimeSyndicale")]
      public decimal PtrPrimesyndicale { get;set; }   // Prime_Travailleur.Ptr_PrimeSyndicale

      [Required]
      [Column("Ptr_PrimeFormation")]
      public decimal PtrPrimeformation { get;set; }   // Prime_Travailleur.Ptr_PrimeFormation

      [Required]
      [Column("Ptr_SoldePayable")]
      public decimal PtrSoldepayable { get;set; }   // Prime_Travailleur.Ptr_SoldePayable

      [Required]
      [Column("Ptr_BaseCalculSaisie")]
      public decimal PtrBasecalculsaisie { get;set; }   // Prime_Travailleur.Ptr_BaseCalculSaisie

      [Required]
      [Column("Ptr_TotalPaiements")]
      public decimal PtrTotalpaiements { get;set; }   // Prime_Travailleur.Ptr_TotalPaiements

      [Required]
      [Column("Ptr_SoldeSaisissable")]
      public decimal PtrSoldesaisissable { get;set; }   // Prime_Travailleur.Ptr_SoldeSaisissable

      [Required]
      [Column("Ptr_DateCalcul")]
      public DateTime PtrDatecalcul { get;set; }   // Prime_Travailleur.Ptr_DateCalcul

      [Required]
      [Column("Ptr_DerogationPfa")]
      public string PtrDerogationpfa { get;set; }   // Prime_Travailleur.Ptr_DerogationPfa

      [Required]
      [Column("Ptr_DerogationTitre")]
      public string PtrDerogationtitre { get;set; }   // Prime_Travailleur.Ptr_DerogationTitre

      [Column("Tra_ID")]
      public decimal TraId { get;set; }  // Prime_Travailleur.Tra_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur { get; set; }

   }

   [Table("Declaration_Travailleur")]
   public partial class DeclarationTravailleur
   {

      [Key]
      [Column("Dtv_Id")]
      public decimal DtvId { get;set; }  // Declaration_Travailleur.Dtv_Id (PrimaryKey)

      [Required]
      [Column("Dtv_Active")]
      public string DtvActive { get;set; }   // Declaration_Travailleur.Dtv_Active

      [Required]
      [Column("Dtv_Trimestre")]
      public string DtvTrimestre { get;set; }   // Declaration_Travailleur.Dtv_Trimestre

      [Required]
      [Column("Dtv_Niss")]
      public string DtvNiss { get;set; }   // Declaration_Travailleur.Dtv_Niss

      [Required]
      [Column("Dtv_Onss")]
      public string DtvOnss { get;set; }   // Declaration_Travailleur.Dtv_Onss

      [Required]
      [Column("Dtv_CodeTravailleur")]
      public string DtvCodetravailleur { get;set; }   // Declaration_Travailleur.Dtv_CodeTravailleur

      [Required]
      [Column("Dtv_CategorieEmployeur")]
      public string DtvCategorieemployeur { get;set; }   // Declaration_Travailleur.Dtv_CategorieEmployeur

      [Required]
      [Column("Dtv_CodeAction")]
      public string DtvCodeaction { get;set; }   // Declaration_Travailleur.Dtv_CodeAction

      [Required]
      [Column("Dtv_TravailleurPID")]
      public decimal DtvTravailleurpid { get;set; }   // Declaration_Travailleur.Dtv_TravailleurPID

      [Required]
      [Column("Dtv_TravailleurDeclarePID")]
      public decimal DtvTravailleurdeclarepid { get;set; }   // Declaration_Travailleur.Dtv_TravailleurDeclarePID

      [Required]
      [Column("Dtv_TravailleurDeclareNoVersion")]
      public decimal DtvTravailleurdeclarenoversion { get;set; }   // Declaration_Travailleur.Dtv_TravailleurDeclareNoVersion

      [Required]
      [Column("Dtv_NoVersionLTR")]
      public decimal DtvNoversionltr { get;set; }   // Declaration_Travailleur.Dtv_NoVersionLTR

      [Required]
      [Column("Dtv_FichierDMFA")]
      public string DtvFichierdmfa { get;set; }   // Declaration_Travailleur.Dtv_FichierDMFA

      [Required]
      [Column("Dtv_DateInjectionDMFA")]
      public DateTime DtvDateinjectiondmfa { get;set; }   // Declaration_Travailleur.Dtv_DateInjectionDMFA

      [Required]
      [Column("Dtv_FichierPID")]
      public string DtvFichierpid { get;set; }   // Declaration_Travailleur.Dtv_FichierPID

      [Required]
      [Column("Dtv_DateInjectionPID")]
      public DateTime DtvDateinjectionpid { get;set; }   // Declaration_Travailleur.Dtv_DateInjectionPID

      [Required]
      [Column("Dtv_Source")]
      public string DtvSource { get;set; }   // Declaration_Travailleur.Dtv_Source

      [Column("Dec_Id")]
      public decimal DecId { get;set; }  // Declaration_Travailleur.Dec_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DecId")]
      public virtual DeclarationOnss DeclarationOnss { get; set; }

   }

   [Table("Titre")]
   public partial class Titre
   {

      [Key]
      [Column("Tit_Id")]
      public decimal TitId { get;set; }  // Titre.Tit_Id (PrimaryKey)

      [Required]
      [Column("Tit_Numero")]
      public string TitNumero { get;set; }   // Titre.Tit_Numero

      [Required]
      [Column("Tit_Etat")]
      public string TitEtat { get;set; }   // Titre.Tit_Etat

      [Required]
      [Column("Tit_DateEmission")]
      public DateTime TitDateemission { get;set; }   // Titre.Tit_DateEmission

      [Required]
      [Column("Tit_DateRetour")]
      public DateTime TitDateretour { get;set; }   // Titre.Tit_DateRetour

      [Required]
      [Column("Tit_DateExecution")]
      public DateTime TitDateexecution { get;set; }   // Titre.Tit_DateExecution

      [Required]
      [Column("Tit_SalaireReel")]
      public decimal TitSalairereel { get;set; }   // Titre.Tit_SalaireReel

      [Required]
      [Column("Tit_SalaireAssimile")]
      public decimal TitSalaireassimile { get;set; }   // Titre.Tit_SalaireAssimile

      [Required]
      [Column("Tit_JoursPrestes")]
      public decimal TitJoursprestes { get;set; }   // Titre.Tit_JoursPrestes

      [Required]
      [Column("Tit_JoursVacances")]
      public decimal TitJoursvacances { get;set; }   // Titre.Tit_JoursVacances

      [Required]
      [Column("Tit_JoursMaladie")]
      public decimal TitJoursmaladie { get;set; }   // Titre.Tit_JoursMaladie

      [Required]
      [Column("Tit_JoursMaternite")]
      public decimal TitJoursmaternite { get;set; }   // Titre.Tit_JoursMaternite

      [Required]
      [Column("Tit_JoursAssimiles")]
      public decimal TitJoursassimiles { get;set; }   // Titre.Tit_JoursAssimiles

      [Required]
      [Column("Tit_PrimeBrute")]
      public decimal TitPrimebrute { get;set; }   // Titre.Tit_PrimeBrute

      [Required]
      [Column("Tit_RetenueONSS")]
      public decimal TitRetenueonss { get;set; }   // Titre.Tit_RetenueONSS

      [Required]
      [Column("Tit_BaseImposable")]
      public decimal TitBaseimposable { get;set; }   // Titre.Tit_BaseImposable

      [Required]
      [Column("Tit_RetenueFiscale")]
      public decimal TitRetenuefiscale { get;set; }   // Titre.Tit_RetenueFiscale

      [Required]
      [Column("Tit_PrimeNette")]
      public decimal TitPrimenette { get;set; }   // Titre.Tit_PrimeNette

      [Required]
      [Column("Tit_PrimeFormation")]
      public decimal TitPrimeformation { get;set; }   // Titre.Tit_PrimeFormation

      [Required]
      [Column("Tit_PrimeSyndicale")]
      public decimal TitPrimesyndicale { get;set; }   // Titre.Tit_PrimeSyndicale

      [Required]
      [Column("Tit_CodeSyndical")]
      public string TitCodesyndical { get;set; }   // Titre.Tit_CodeSyndical

      [Required]
      [Column("Tit_FraisAdministratifs")]
      public decimal TitFraisadministratifs { get;set; }   // Titre.Tit_FraisAdministratifs

      [Required]
      [Column("Tit_Commentaire")]
      public string TitCommentaire { get;set; }   // Titre.Tit_Commentaire

      [Required]
      [Column("Tit_MontantPaye")]
      public decimal TitMontantpaye { get;set; }   // Titre.Tit_MontantPaye

      [Required]
      [Column("Tit_DateDuplicata")]
      public DateTime TitDateduplicata { get;set; }   // Titre.Tit_DateDuplicata

      [Required]
      [Column("Tit_NissOrigine")]
      public string TitNissorigine { get;set; }   // Titre.Tit_NissOrigine

      [Required]
      [Column("Tit_AdresseRue")]
      public string TitAdresserue { get;set; }   // Titre.Tit_AdresseRue

      [Required]
      [Column("Tit_AdresseNo")]
      public string TitAdresseno { get;set; }   // Titre.Tit_AdresseNo

      [Required]
      [Column("Tit_AdresseBte")]
      public string TitAdressebte { get;set; }   // Titre.Tit_AdresseBte

      [Required]
      [Column("Tit_CodePostal")]
      public string TitCodepostal { get;set; }   // Titre.Tit_CodePostal

      [Required]
      [Column("Tit_Localite")]
      public string TitLocalite { get;set; }   // Titre.Tit_Localite

      [Required]
      [Column("Tit_CodePays")]
      public string TitCodepays { get;set; }   // Titre.Tit_CodePays

      [Column("Ptr_Id")]
      public decimal PtrId { get;set; }  // Titre.Ptr_Id (ForeignKey)

      [Column("Lot_Id")]
      public decimal LotId { get;set; }  // Titre.Lot_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("PtrId")]
      public virtual PrimeTravailleur PrimeTravailleur_PtrId { get; set; }

      [ForeignKey("LotId")]
      public virtual DecompteLot DecompteLot_LotId { get; set; }

   }

   [Table("Pension_Travailleur")]
   public partial class PensionTravailleur
   {

      [Key]
      [Column("Dtr_Id")]
      public decimal DtrId { get;set; }  // Pension_Travailleur.Dtr_Id (PrimaryKey)

      [Required]
      [Column("Dtr_Niss")]
      public string DtrNiss { get;set; }   // Pension_Travailleur.Dtr_Niss

      [Required]
      [Column("Dtr_Exercice")]
      public string DtrExercice { get;set; }   // Pension_Travailleur.Dtr_Exercice

      [Required]
      [Column("Dtr_JoursOnss")]
      public decimal DtrJoursonss { get;set; }   // Pension_Travailleur.Dtr_JoursOnss

      [Required]
      [Column("Dtr_ExportJoursOnss")]
      public decimal DtrExportjoursonss { get;set; }   // Pension_Travailleur.Dtr_ExportJoursOnss

      [Required]
      [Column("Dtr_DeltaJoursOnss")]
      public decimal DtrDeltajoursonss { get;set; }   // Pension_Travailleur.Dtr_DeltaJoursOnss

      [Required]
      [Column("Dtr_SalaireBrut")]
      public decimal DtrSalairebrut { get;set; }   // Pension_Travailleur.Dtr_SalaireBrut

      [Required]
      [Column("Dtr_ExportSalaireBrut")]
      public decimal DtrExportsalairebrut { get;set; }   // Pension_Travailleur.Dtr_ExportSalaireBrut

      [Required]
      [Column("Dtr_DeltaSalaireBrut")]
      public decimal DtrDeltasalairebrut { get;set; }   // Pension_Travailleur.Dtr_DeltaSalaireBrut

      [Required]
      [Column("Dtr_PrimeInactivite")]
      public decimal DtrPrimeinactivite { get;set; }   // Pension_Travailleur.Dtr_PrimeInactivite

      [Required]
      [Column("Dtr_ExportPrimeInactivite")]
      public decimal DtrExportprimeinactivite { get;set; }   // Pension_Travailleur.Dtr_ExportPrimeInactivite

      [Required]
      [Column("Dtr_DeltaPrimeInactivite")]
      public decimal DtrDeltaprimeinactivite { get;set; }   // Pension_Travailleur.Dtr_DeltaPrimeInactivite

      [Required]
      [Column("Dtr_PrimeDeces")]
      public string DtrPrimedeces { get;set; }   // Pension_Travailleur.Dtr_PrimeDeces

      [Required]
      [Column("Dtr_Etat")]
      public string DtrEtat { get;set; }   // Pension_Travailleur.Dtr_Etat

      [Required]
      [Column("Dtr_DateEtat")]
      public DateTime DtrDateetat { get;set; }   // Pension_Travailleur.Dtr_DateEtat

      [Required]
      [Column("Dtr_TexteLibre")]
      public string DtrTextelibre { get;set; }   // Pension_Travailleur.Dtr_TexteLibre

      [Required]
      [Column("Dtr_ExportEnCours")]
      public string DtrExportencours { get;set; }   // Pension_Travailleur.Dtr_ExportEnCours

      [Column("Pen_Id")]
      public decimal PenId { get;set; }  // Pension_Travailleur.Pen_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("PenId")]
      public virtual Pension Pension { get; set; }

   }

   [Table("Demande_Intervention_Automatique")]
   public partial class DemandeInterventionAutomatique
   {

      [Key]
      [Column("Dia_Id")]
      public decimal DiaId { get;set; }  // Demande_Intervention_Automatique.Dia_Id (PrimaryKey)

      [Required]
      [Column("Dia_Trimestre")]
      public string DiaTrimestre { get;set; }   // Demande_Intervention_Automatique.Dia_Trimestre

      [Required]
      [Column("Dia_NumeroFolio")]
      public string DiaNumerofolio { get;set; }   // Demande_Intervention_Automatique.Dia_NumeroFolio

      [Required]
      [Column("Dia_TypeDemande")]
      public string DiaTypedemande { get;set; }   // Demande_Intervention_Automatique.Dia_TypeDemande

      [Required]
      [Column("Dia_DebutPeriode")]
      public DateTime DiaDebutperiode { get;set; }   // Demande_Intervention_Automatique.Dia_DebutPeriode

      [Required]
      [Column("Dia_FinPeriode")]
      public DateTime DiaFinperiode { get;set; }   // Demande_Intervention_Automatique.Dia_FinPeriode

      [Required]
      [Column("Dia_Etat")]
      public string DiaEtat { get;set; }   // Demande_Intervention_Automatique.Dia_Etat

      [Required]
      [Column("Dia_DateEtat")]
      public DateTime DiaDateetat { get;set; }   // Demande_Intervention_Automatique.Dia_DateEtat

      [Column("Din_Id")]
      public decimal DinId { get;set; }  // Demande_Intervention_Automatique.Din_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DinId")]
      public virtual DossierIntervention DossierIntervention { get; set; }

   }

   [Table("Activite_Employeur")]
   public partial class ActiviteEmployeur
   {

      [Key]
      [Column("Aem_ID")]
      public decimal AemId { get;set; }  // Activite_Employeur.Aem_ID (PrimaryKey)

      [Required]
      [Column("Aem_ONSS")]
      public string AemOnss { get;set; }   // Activite_Employeur.Aem_ONSS

      [Required]
      [Column("Aem_CategorieEmployeur")]
      public string AemCategorieemployeur { get;set; }   // Activite_Employeur.Aem_CategorieEmployeur

      [Required]
      [Column("Aem_DateAffiliation")]
      public DateTime AemDateaffiliation { get;set; }   // Activite_Employeur.Aem_DateAffiliation

      [Required]
      [Column("Aem_DateSuppression")]
      public DateTime AemDatesuppression { get;set; }   // Activite_Employeur.Aem_DateSuppression

      [Required]
      [Column("Aem_DateMatricule")]
      public DateTime AemDatematricule { get;set; }   // Activite_Employeur.Aem_DateMatricule

      [Required]
      [Column("Aem_DateRadiation")]
      public DateTime AemDateradiation { get;set; }   // Activite_Employeur.Aem_DateRadiation

      [Required]
      [Column("Aem_CodeNACE")]
      public string AemCodenace { get;set; }   // Activite_Employeur.Aem_CodeNACE

      [Required]
      [Column("Aem_CodeImportance")]
      public string AemCodeimportance { get;set; }   // Activite_Employeur.Aem_CodeImportance

      [Column("Emp_ID")]
      public decimal EmpId { get;set; }  // Activite_Employeur.Emp_ID (ForeignKey)

      [Column("Fnd_ID")]
      public decimal FndId { get;set; }  // Activite_Employeur.Fnd_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("EmpId")]
      public virtual Employeur Employeur_EmpId { get; set; }

      [ForeignKey("FndId")]
      public virtual Fonds Fonds_FndId { get; set; }

   }

   [Table("Journal_Fusion")]
   public partial class JournalFusion
   {

      [Key]
      [Column("Jfu_ID")]
      public decimal JfuId { get;set; }  // Journal_Fusion.Jfu_ID (PrimaryKey)

      [Required]
      [Column("Jfu_NissOrigine")]
      public string JfuNissorigine { get;set; }   // Journal_Fusion.Jfu_NissOrigine

      [Required]
      [Column("Jfu_NissDestination")]
      public string JfuNissdestination { get;set; }   // Journal_Fusion.Jfu_NissDestination

      [Required]
      [Column("Jfu_DateFusion")]
      public DateTime JfuDatefusion { get;set; }   // Journal_Fusion.Jfu_DateFusion

   }

   [Table("Batch_Schedule")]
   public partial class BatchSchedule
   {

      [Key]
      [Column("Bat_Id")]
      public decimal BatId { get;set; }  // Batch_Schedule.Bat_Id (PrimaryKey)

      [Required]
      [Column("Bat_Type")]
      public string BatType { get;set; }   // Batch_Schedule.Bat_Type

      [Required]
      [Column("Bat_Description")]
      public string BatDescription { get;set; }   // Batch_Schedule.Bat_Description

      [Required]
      [Column("Bat_Etat")]
      public string BatEtat { get;set; }   // Batch_Schedule.Bat_Etat

      [Required]
      [Column("Bat_SqlState")]
      public string BatSqlstate { get;set; }   // Batch_Schedule.Bat_SqlState

      [Required]
      [Column("Bat_SqlState3")]
      public string BatSqlstate3 { get;set; }   // Batch_Schedule.Bat_SqlState3

      [Required]
      [Column("Bat_SqlState2")]
      public string BatSqlstate2 { get;set; }   // Batch_Schedule.Bat_SqlState2

      [Required]
      [Column("Bat_Parametres")]
      public string BatParametres { get;set; }   // Batch_Schedule.Bat_Parametres

      [Required]
      [Column("Bat_Priorite")]
      public decimal BatPriorite { get;set; }   // Batch_Schedule.Bat_Priorite

      [Required]
      [Column("Bat_DatePlanifiee")]
      public DateTime BatDateplanifiee { get;set; }   // Batch_Schedule.Bat_DatePlanifiee

      [Required]
      [Column("Bat_DateDebutExecution")]
      public DateTime BatDatedebutexecution { get;set; }   // Batch_Schedule.Bat_DateDebutExecution

      [Required]
      [Column("Bat_DateFinExecution")]
      public DateTime BatDatefinexecution { get;set; }   // Batch_Schedule.Bat_DateFinExecution

      [Required]
      [Column("Bat_Erreur")]
      public string BatErreur { get;set; }   // Batch_Schedule.Bat_Erreur

      [Required]
      [Column("Bat_SqlText")]
      public string BatSqltext { get;set; }   // Batch_Schedule.Bat_SqlText

      [Required]
      [Column("Bat_Keywords")]
      public string BatKeywords { get;set; }   // Batch_Schedule.Bat_Keywords

   }

   [Table("Fiche_Pension")]
   public partial class FichePension
   {

      [Key]
      [Column("Fpe_ID")]
      public decimal FpeId { get;set; }  // Fiche_Pension.Fpe_ID (PrimaryKey)

      [Required]
      [Column("Fpe_DateReference")]
      public DateTime FpeDatereference { get;set; }   // Fiche_Pension.Fpe_DateReference

      [Required]
      [Column("Fpe_Exercice")]
      public string FpeExercice { get;set; }   // Fiche_Pension.Fpe_Exercice

      [Required]
      [Column("Fpe_SalaireBrut")]
      public decimal FpeSalairebrut { get;set; }   // Fiche_Pension.Fpe_SalaireBrut

      [Required]
      [Column("Fpe_PrimePension")]
      public decimal FpePrimepension { get;set; }   // Fiche_Pension.Fpe_PrimePension

      [Required]
      [Column("Fpe_PrimeSolidarite")]
      public decimal FpePrimesolidarite { get;set; }   // Fiche_Pension.Fpe_PrimeSolidarite

      [Required]
      [Column("Fpe_ReserveAcquise")]
      public decimal FpeReserveacquise { get;set; }   // Fiche_Pension.Fpe_ReserveAcquise

      [Required]
      [Column("Fpe_GarantieMinimale")]
      public decimal FpeGarantieminimale { get;set; }   // Fiche_Pension.Fpe_GarantieMinimale

      [Required]
      [Column("Fpe_EcheanceContrat")]
      public DateTime FpeEcheancecontrat { get;set; }   // Fiche_Pension.Fpe_EcheanceContrat

      [Required]
      [Column("Fpe_CapitalAcquis")]
      public decimal FpeCapitalacquis { get;set; }   // Fiche_Pension.Fpe_CapitalAcquis

      [Required]
      [Column("Fpe_AgePension")]
      public decimal FpeAgepension { get;set; }   // Fiche_Pension.Fpe_AgePension

      [Required]
      [Column("Fpe_EstimationCapital")]
      public decimal FpeEstimationcapital { get;set; }   // Fiche_Pension.Fpe_EstimationCapital

      [Required]
      [Column("Fpe_RenteAnuelle")]
      public decimal FpeRenteanuelle { get;set; }   // Fiche_Pension.Fpe_RenteAnuelle

      [Required]
      [Column("Fpe_Etat")]
      public string FpeEtat { get;set; }   // Fiche_Pension.Fpe_Etat

      [Required]
      [Column("Fpe_DateEtat")]
      public DateTime FpeDateetat { get;set; }   // Fiche_Pension.Fpe_DateEtat

      [Required]
      [Column("Fpe_Rue")]
      public string FpeRue { get;set; }   // Fiche_Pension.Fpe_Rue

      [Required]
      [Column("Fpe_No")]
      public string FpeNo { get;set; }   // Fiche_Pension.Fpe_No

      [Required]
      [Column("Fpe_Bte")]
      public string FpeBte { get;set; }   // Fiche_Pension.Fpe_Bte

      [Required]
      [Column("Fpe_CodePostal")]
      public string FpeCodepostal { get;set; }   // Fiche_Pension.Fpe_CodePostal

      [Required]
      [Column("Fpe_Localite")]
      public string FpeLocalite { get;set; }   // Fiche_Pension.Fpe_Localite

      [Required]
      [Column("Fpe_CodePays")]
      public string FpeCodepays { get;set; }   // Fiche_Pension.Fpe_CodePays

      [Required]
      [Column("Fpe_DateNaissance")]
      public DateTime FpeDatenaissance { get;set; }   // Fiche_Pension.Fpe_DateNaissance

      [Required]
      [Column("Fpe_CorrectionSalaire")]
      public decimal FpeCorrectionsalaire { get;set; }   // Fiche_Pension.Fpe_CorrectionSalaire

      [Required]
      [Column("Fpe_DateReferencePcd")]
      public DateTime FpeDatereferencepcd { get;set; }   // Fiche_Pension.Fpe_DateReferencePcd

      [Required]
      [Column("Fpe_ReserveAcquisePcd")]
      public decimal FpeReserveacquisepcd { get;set; }   // Fiche_Pension.Fpe_ReserveAcquisePcd

      [Required]
      [Column("Fpe_ParticipationBeneficiaire")]
      public decimal FpeParticipationbeneficiaire { get;set; }   // Fiche_Pension.Fpe_ParticipationBeneficiaire

      [Column("Pen_ID")]
      public decimal PenId { get;set; }  // Fiche_Pension.Pen_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("PenId")]
      public virtual Pension Pension { get; set; }

   }

   [Table("Categorie_Employeur")]
   public partial class CategorieEmployeur
   {

      [Key]
      [Column("Cec_Id")]
      public decimal CecId { get;set; }  // Categorie_Employeur.Cec_Id (PrimaryKey)

      [Required]
      [Column("Cec_CategorieEmployeur")]
      public string CecCategorieemployeur { get;set; }   // Categorie_Employeur.Cec_CategorieEmployeur

      [Required]
      [Column("Cec_CodeTravailleur")]
      public string CecCodetravailleur { get;set; }   // Categorie_Employeur.Cec_CodeTravailleur

      [Required]
      [Column("Cec_DateDebutValidite")]
      public DateTime CecDatedebutvalidite { get;set; }   // Categorie_Employeur.Cec_DateDebutValidite

      [Required]
      [Column("Cec_DateFinValidite")]
      public DateTime CecDatefinvalidite { get;set; }   // Categorie_Employeur.Cec_DateFinValidite

      [Column("Fnd_ID")]
      public decimal FndId { get;set; }  // Categorie_Employeur.Fnd_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("FndId")]
      public virtual Fonds Fonds { get; set; }

   }

   [Table("Cheque")]
   public partial class Cheque
   {

      [Key]
      [Column("Chq_Id")]
      public decimal ChqId { get;set; }  // Cheque.Chq_Id (PrimaryKey)

      [Required]
      [Column("Pay_ID")]
      public decimal PayId { get;set; }   // Cheque.Pay_ID

      [Required]
      [Column("Chq_NoPayement")]
      public string ChqNopayement { get;set; }   // Cheque.Chq_NoPayement

      [Required]
      [Column("Chq_NoCheque")]
      public string ChqNocheque { get;set; }   // Cheque.Chq_NoCheque

      [Required]
      [Column("Chq_NISS")]
      public string ChqNiss { get;set; }   // Cheque.Chq_NISS

      [Required]
      [Column("Chq_ONSS")]
      public string ChqOnss { get;set; }   // Cheque.Chq_ONSS

      [Required]
      [Column("Chq_Exercice")]
      public string ChqExercice { get;set; }   // Cheque.Chq_Exercice

      [Required]
      [Column("Chq_Montant")]
      public decimal ChqMontant { get;set; }   // Cheque.Chq_Montant

      [Required]
      [Column("Chq_DonneurOrdre")]
      public string ChqDonneurordre { get;set; }   // Cheque.Chq_DonneurOrdre

      [Required]
      [Column("Chq_Nom")]
      public string ChqNom { get;set; }   // Cheque.Chq_Nom

      [Required]
      [Column("Chq_Prenom")]
      public string ChqPrenom { get;set; }   // Cheque.Chq_Prenom

      [Required]
      [Column("Chq_AdresseRue")]
      public string ChqAdresserue { get;set; }   // Cheque.Chq_AdresseRue

      [Required]
      [Column("Chq_AdresseBte")]
      public string ChqAdressebte { get;set; }   // Cheque.Chq_AdresseBte

      [Required]
      [Column("Chq_AdresseNo")]
      public string ChqAdresseno { get;set; }   // Cheque.Chq_AdresseNo

      [Required]
      [Column("Chq_CodePostal")]
      public string ChqCodepostal { get;set; }   // Cheque.Chq_CodePostal

      [Required]
      [Column("Chq_Localite")]
      public string ChqLocalite { get;set; }   // Cheque.Chq_Localite

      [Required]
      [Column("Chq_CodePays")]
      public string ChqCodepays { get;set; }   // Cheque.Chq_CodePays

      [Required]
      [Column("Chq_DateEmission")]
      public DateTime ChqDateemission { get;set; }   // Cheque.Chq_DateEmission

      [Required]
      [Column("Chq_DateFinValidite")]
      public DateTime ChqDatefinvalidite { get;set; }   // Cheque.Chq_DateFinValidite

      [Required]
      [Column("Chq_Langue")]
      public string ChqLangue { get;set; }   // Cheque.Chq_Langue

      [Required]
      [Column("Chq_PremierPayement")]
      public string ChqPremierpayement { get;set; }   // Cheque.Chq_PremierPayement

   }

   [Table("Cheque_Compteur")]
   public partial class ChequeCompteur
   {

      [Key]
      [Column("Che_Id")]
      public decimal CheId { get;set; }  // Cheque_Compteur.Che_Id (PrimaryKey)

      [Required]
      [Column("Che_CompteBancaire")]
      public string CheComptebancaire { get;set; }   // Cheque_Compteur.Che_CompteBancaire

      [Required]
      [Column("Che_Exercice")]
      public string CheExercice { get;set; }   // Cheque_Compteur.Che_Exercice

      [Required]
      [Column("Che_Sequence")]
      public decimal CheSequence { get;set; }   // Cheque_Compteur.Che_Sequence

      [Required]
      [Column("Che_Numero")]
      public decimal CheNumero { get;set; }   // Cheque_Compteur.Che_Numero

      [Required]
      [Column("Che_NumeroMin")]
      public decimal CheNumeromin { get;set; }   // Cheque_Compteur.Che_NumeroMin

      [Required]
      [Column("Che_NumeroMax")]
      public decimal CheNumeromax { get;set; }   // Cheque_Compteur.Che_NumeroMax

   }

   [Table("Compteur_Folio")]
   public partial class CompteurFolio
   {

      [Key]
      [Column("Cfo_Id")]
      public decimal CfoId { get;set; }  // Compteur_Folio.Cfo_Id (PrimaryKey)

      [Required]
      [Column("Cfo_TypeIntervention")]
      public string CfoTypeintervention { get;set; }   // Compteur_Folio.Cfo_TypeIntervention

      [Required]
      [Column("Cfo_Prefixe")]
      public string CfoPrefixe { get;set; }   // Compteur_Folio.Cfo_Prefixe

      [Required]
      [Column("Cfo_Valeur")]
      public decimal CfoValeur { get;set; }   // Compteur_Folio.Cfo_Valeur

      [Required]
      [Column("Cfo_Valeur_Auto")]
      public decimal CfoValeurAuto { get;set; }   // Compteur_Folio.Cfo_Valeur_Auto

   }

   [Table("Assimilation")]
   public partial class Assimilation
   {

      [Key]
      [Column("Ass_Id")]
      public decimal AssId { get;set; }  // Assimilation.Ass_Id (PrimaryKey)

      [Required]
      [Column("Ass_NoAttestation")]
      public string AssNoattestation { get;set; }   // Assimilation.Ass_NoAttestation

      [Required]
      [Column("Ass_NoSituation")]
      public string AssNosituation { get;set; }   // Assimilation.Ass_NoSituation

      [Required]
      [Column("Ass_Trimestre")]
      public string AssTrimestre { get;set; }   // Assimilation.Ass_Trimestre

      [Required]
      [Column("Ass_CodePrestation")]
      public string AssCodeprestation { get;set; }   // Assimilation.Ass_CodePrestation

      [Required]
      [Column("Ass_Etat")]
      public string AssEtat { get;set; }   // Assimilation.Ass_Etat

      [Required]
      [Column("Ass_JoursAttribues")]
      public decimal AssJoursattribues { get;set; }   // Assimilation.Ass_JoursAttribues

      [Required]
      [Column("Ass_DateAttribution")]
      public DateTime AssDateattribution { get;set; }   // Assimilation.Ass_DateAttribution

      [Required]
      [Column("Ass_Gestionnaire")]
      public string AssGestionnaire { get;set; }   // Assimilation.Ass_Gestionnaire

      [Required]
      [Column("Ass_TextLibre")]
      public string AssTextlibre { get;set; }   // Assimilation.Ass_TextLibre

      [Required]
      [Column("Ass_F2PJoursAttribues")]
      public decimal AssF2pjoursattribues { get;set; }   // Assimilation.Ass_F2PJoursAttribues

      [Column("Prs_Id")]
      public decimal PrsId { get;set; }  // Assimilation.Prs_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("PrsId")]
      public virtual Prestation Prestation { get; set; }

   }

   [Table("Contrat")]
   public partial class Contrat
   {

      [Key]
      [Column("Con_ID")]
      public decimal ConId { get;set; }  // Contrat.Con_ID (PrimaryKey)

      [Required]
      [Column("Con_NISS")]
      public string ConNiss { get;set; }   // Contrat.Con_NISS

      [Required]
      [Column("Con_ONSS")]
      public string ConOnss { get;set; }   // Contrat.Con_ONSS

      [Required]
      [Column("Con_CategorieEmployeur")]
      public string ConCategorieemployeur { get;set; }   // Contrat.Con_CategorieEmployeur

      [Required]
      [Column("Con_CodeTravailleur")]
      public string ConCodetravailleur { get;set; }   // Contrat.Con_CodeTravailleur

      [Required]
      [Column("Con_ComiteParitaire")]
      public string ConComiteparitaire { get;set; }   // Contrat.Con_ComiteParitaire

      [Required]
      [Column("Con_DateEntree")]
      public DateTime ConDateentree { get;set; }   // Contrat.Con_DateEntree

      [Required]
      [Column("Con_DateSortie")]
      public DateTime ConDatesortie { get;set; }   // Contrat.Con_DateSortie

      [Required]
      [Column("Con_NumeroMatricule")]
      public string ConNumeromatricule { get;set; }   // Contrat.Con_NumeroMatricule

      [Required]
      [Column("Con_Division")]
      public string ConDivision { get;set; }   // Contrat.Con_Division

      [Required]
      [Column("Con_TravailContinu")]
      public string ConTravailcontinu { get;set; }   // Contrat.Con_TravailContinu

      [Required]
      [Column("Con_DatePrepension")]
      public DateTime ConDateprepension { get;set; }   // Contrat.Con_DatePrepension

      [Required]
      [Column("Con_DatePension")]
      public DateTime ConDatepension { get;set; }   // Contrat.Con_DatePension

      [Column("Aem_ID")]
      public decimal AemId { get;set; }  // Contrat.Aem_ID (ForeignKey)

      [Column("Tra_ID")]
      public decimal TraId { get;set; }  // Contrat.Tra_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("AemId")]
      public virtual ActiviteEmployeur ActiviteEmployeur_AemId { get; set; }

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur_TraId { get; set; }

   }

   [Table("Drs_A037ChomageTemporaire")]
   public partial class DrsA037chomagetemporaire
   {

      [Key]
      [Column("D37_Id")]
      public decimal D37Id { get;set; }  // Drs_A037ChomageTemporaire.D37_Id (PrimaryKey)

      [Required]
      [Column("D37_CodeChomage")]
      public string D37Codechomage { get;set; }   // Drs_A037ChomageTemporaire.D37_CodeChomage

      [Required]
      [Column("D37_UniteDureePayee")]
      public string D37Unitedureepayee { get;set; }   // Drs_A037ChomageTemporaire.D37_UniteDureePayee

      [Required]
      [Column("D37_ValeurDureePayee")]
      public decimal D37Valeurdureepayee { get;set; }   // Drs_A037ChomageTemporaire.D37_ValeurDureePayee

      [Required]
      [Column("D37_NbrAllocationPayee")]
      public decimal D37Nbrallocationpayee { get;set; }   // Drs_A037ChomageTemporaire.D37_NbrAllocationPayee

      [Required]
      [Column("D37_UniteDureeRefusee")]
      public string D37Unitedureerefusee { get;set; }   // Drs_A037ChomageTemporaire.D37_UniteDureeRefusee

      [Required]
      [Column("D37_ValeurDureeRefusee")]
      public decimal D37Valeurdureerefusee { get;set; }   // Drs_A037ChomageTemporaire.D37_ValeurDureeRefusee

      [Required]
      [Column("D37_NbrAllocationRefusee")]
      public decimal D37Nbrallocationrefusee { get;set; }   // Drs_A037ChomageTemporaire.D37_NbrAllocationRefusee

      [Required]
      [Column("D37_NbrAllocationRefuseeAutre")]
      public decimal D37Nbrallocationrefuseeautre { get;set; }   // Drs_A037ChomageTemporaire.D37_NbrAllocationRefuseeAutre

      [Column("A37_Id")]
      public decimal A37Id { get;set; }  // Drs_A037ChomageTemporaire.A37_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("A37Id")]
      public virtual DrsA037 DrsA037 { get; set; }

   }

   [Table("Drs_Envoi")]
   public partial class DrsEnvoi
   {

      [Key]
      [Column("Drs_Id")]
      public decimal DrsId { get;set; }  // Drs_Envoi.Drs_Id (PrimaryKey)

      [Required]
      [Column("Drs_Type")]
      public string DrsType { get;set; }   // Drs_Envoi.Drs_Type

      [Required]
      [Column("Drs_NomFichier")]
      public string DrsNomfichier { get;set; }   // Drs_Envoi.Drs_NomFichier

      [Required]
      [Column("Drs_DateInjection")]
      public DateTime DrsDateinjection { get;set; }   // Drs_Envoi.Drs_DateInjection

   }

   [Table("Decompte_Lot")]
   public partial class DecompteLot
   {

      [Key]
      [Column("Lot_Id")]
      public decimal LotId { get;set; }  // Decompte_Lot.Lot_Id (PrimaryKey)

      [Required]
      [Column("Lot_Numero")]
      public string LotNumero { get;set; }   // Decompte_Lot.Lot_Numero

      [Required]
      [Column("Lot_NombreTitres")]
      public decimal LotNombretitres { get;set; }   // Decompte_Lot.Lot_NombreTitres

      [Required]
      [Column("Lot_Salaires")]
      public decimal LotSalaires { get;set; }   // Decompte_Lot.Lot_Salaires

      [Required]
      [Column("Lot_JoursPrestes")]
      public decimal LotJoursprestes { get;set; }   // Decompte_Lot.Lot_JoursPrestes

      [Required]
      [Column("Lot_JoursVacances")]
      public decimal LotJoursvacances { get;set; }   // Decompte_Lot.Lot_JoursVacances

      [Required]
      [Column("Lot_JoursMaladie")]
      public decimal LotJoursmaladie { get;set; }   // Decompte_Lot.Lot_JoursMaladie

      [Required]
      [Column("Lot_JoursMaternite")]
      public decimal LotJoursmaternite { get;set; }   // Decompte_Lot.Lot_JoursMaternite

      [Required]
      [Column("Lot_JoursAssimimles")]
      public decimal LotJoursassimimles { get;set; }   // Decompte_Lot.Lot_JoursAssimimles

      [Required]
      [Column("Lot_NbrePrimesSyndicales")]
      public decimal LotNbreprimessyndicales { get;set; }   // Decompte_Lot.Lot_NbrePrimesSyndicales

      [Required]
      [Column("Lot_TotalPrimesSyndicales")]
      public decimal LotTotalprimessyndicales { get;set; }   // Decompte_Lot.Lot_TotalPrimesSyndicales

      [Required]
      [Column("Lot_NbrePrimesFormation")]
      public decimal LotNbreprimesformation { get;set; }   // Decompte_Lot.Lot_NbrePrimesFormation

      [Required]
      [Column("Lot_TotalPrimesFormation")]
      public decimal LotTotalprimesformation { get;set; }   // Decompte_Lot.Lot_TotalPrimesFormation

      [Required]
      [Column("Lot_TotalBrutPrimes")]
      public decimal LotTotalbrutprimes { get;set; }   // Decompte_Lot.Lot_TotalBrutPrimes

      [Required]
      [Column("Lot_RetenueONSS")]
      public decimal LotRetenueonss { get;set; }   // Decompte_Lot.Lot_RetenueONSS

      [Required]
      [Column("Lot_BaseImposable")]
      public decimal LotBaseimposable { get;set; }   // Decompte_Lot.Lot_BaseImposable

      [Required]
      [Column("Lot_RetenueFiscale")]
      public decimal LotRetenuefiscale { get;set; }   // Decompte_Lot.Lot_RetenueFiscale

      [Required]
      [Column("Lot_NetAvantFrais")]
      public decimal LotNetavantfrais { get;set; }   // Decompte_Lot.Lot_NetAvantFrais

      [Required]
      [Column("Lot_FraisAdministratifs")]
      public decimal LotFraisadministratifs { get;set; }   // Decompte_Lot.Lot_FraisAdministratifs

      [Required]
      [Column("Lot_Net")]
      public decimal LotNet { get;set; }   // Decompte_Lot.Lot_Net

      [Column("Liv_Id")]
      public decimal LivId { get;set; }  // Decompte_Lot.Liv_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("LivId")]
      public virtual Livre Livre { get; set; }

   }

   [Table("Att_A045")]
   public partial class AttA045
   {

      [Key]
      [Column("Att45_Id")]
      public decimal Att45Id { get;set; }  // Att_A045.Att45_Id (PrimaryKey)

      [Required]
      [Column("Att45_Active")]
      public string Att45Active { get;set; }   // Att_A045.Att45_Active

      [Required]
      [Column("Att45_INSS")]
      public string Att45Inss { get;set; }   // Att_A045.Att45_INSS

      [Required]
      [Column("Att45_AttestationID")]
      public string Att45Attestationid { get;set; }   // Att_A045.Att45_AttestationID

      [Required]
      [Column("Att45_SituationNbr")]
      public decimal Att45Situationnbr { get;set; }   // Att_A045.Att45_SituationNbr

      [Required]
      [Column("Att45_AttestationStatus")]
      public decimal Att45Attestationstatus { get;set; }   // Att_A045.Att45_AttestationStatus

      [Required]
      [Column("Att45_CreationDate")]
      public DateTime Att45Creationdate { get;set; }   // Att_A045.Att45_CreationDate

      [Required]
      [Column("Att45_Quarter")]
      public string Att45Quarter { get;set; }   // Att_A045.Att45_Quarter

      [Required]
      [Column("Att45_NOSSRegistrationNbr")]
      public string Att45Nossregistrationnbr { get;set; }   // Att_A045.Att45_NOSSRegistrationNbr

      [Required]
      [Column("Att45_CompanyID")]
      public string Att45Companyid { get;set; }   // Att_A045.Att45_CompanyID

      [Required]
      [Column("Att45_EmployerClass")]
      public string Att45Employerclass { get;set; }   // Att_A045.Att45_EmployerClass

      [Column("Snd45_Id")]
      public decimal Snd45Id { get;set; }  // Att_A045.Snd45_Id (ForeignKey)

      [Column("Tra_Id")]
      public decimal TraId { get;set; }  // Att_A045.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Snd45Id")]
      public virtual SendingA045 SendingA045_Snd45Id { get; set; }

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur_TraId { get; set; }

   }

   [Table("Pension_LettreDepart")]
   public partial class PensionLettredepart
   {

      [Key]
      [Column("Pld_Id")]
      public decimal PldId { get;set; }  // Pension_LettreDepart.Pld_Id (PrimaryKey)

      [Required]
      [Column("Pld_DateReference")]
      public DateTime PldDatereference { get;set; }   // Pension_LettreDepart.Pld_DateReference

      [Required]
      [Column("Pld_ReserveAcquise")]
      public decimal PldReserveacquise { get;set; }   // Pension_LettreDepart.Pld_ReserveAcquise

      [Required]
      [Column("Pld_GarantieMinimale")]
      public decimal PldGarantieminimale { get;set; }   // Pension_LettreDepart.Pld_GarantieMinimale

      [Required]
      [Column("Pld_EcheanceContrat")]
      public DateTime PldEcheancecontrat { get;set; }   // Pension_LettreDepart.Pld_EcheanceContrat

      [Required]
      [Column("Pld_CapitalAcquis")]
      public decimal PldCapitalacquis { get;set; }   // Pension_LettreDepart.Pld_CapitalAcquis

      [Required]
      [Column("Pld_Etat")]
      public string PldEtat { get;set; }   // Pension_LettreDepart.Pld_Etat

      [Required]
      [Column("Pld_DateEtat")]
      public DateTime PldDateetat { get;set; }   // Pension_LettreDepart.Pld_DateEtat

      [Required]
      [Column("Pld_Rue")]
      public string PldRue { get;set; }   // Pension_LettreDepart.Pld_Rue

      [Required]
      [Column("Pld_No")]
      public string PldNo { get;set; }   // Pension_LettreDepart.Pld_No

      [Required]
      [Column("Pld_Bte")]
      public string PldBte { get;set; }   // Pension_LettreDepart.Pld_Bte

      [Required]
      [Column("Pld_CodePostal")]
      public string PldCodepostal { get;set; }   // Pension_LettreDepart.Pld_CodePostal

      [Required]
      [Column("Pld_Localite")]
      public string PldLocalite { get;set; }   // Pension_LettreDepart.Pld_Localite

      [Required]
      [Column("Pld_CodePays")]
      public string PldCodepays { get;set; }   // Pension_LettreDepart.Pld_CodePays

      [Required]
      [Column("Pld_DateNaissance")]
      public DateTime PldDatenaissance { get;set; }   // Pension_LettreDepart.Pld_DateNaissance

      [Column("Pen_ID")]
      public decimal PenId { get;set; }  // Pension_LettreDepart.Pen_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("PenId")]
      public virtual Pension Pension { get; set; }

   }

   [Table("Dossier")]
   public partial class Dossier
   {

      [Key]
      [Column("Dos_Id")]
      public decimal DosId { get;set; }  // Dossier.Dos_Id (PrimaryKey)

      [Required]
      [Column("Dos_TypeObjet")]
      public decimal DosTypeobjet { get;set; }   // Dossier.Dos_TypeObjet

      [Required]
      [Column("Dos_IdObjet")]
      public decimal DosIdobjet { get;set; }   // Dossier.Dos_IdObjet

      [Required]
      [Column("Dos_References")]
      public string DosReferences { get;set; }   // Dossier.Dos_References

      [Required]
      [Column("Dos_Etat")]
      public string DosEtat { get;set; }   // Dossier.Dos_Etat

      [Required]
      [Column("Dos_Texte")]
      public string DosTexte { get;set; }   // Dossier.Dos_Texte

      [Required]
      [Column("Dos_DateCreation")]
      public DateTime DosDatecreation { get;set; }   // Dossier.Dos_DateCreation

      [Required]
      [Column("Dos_Auteur")]
      public string DosAuteur { get;set; }   // Dossier.Dos_Auteur

      [Required]
      [Column("Dos_DateModification")]
      public DateTime DosDatemodification { get;set; }   // Dossier.Dos_DateModification

   }

   [Table("Livre")]
   public partial class Livre
   {

      [Key]
      [Column("Liv_Id")]
      public decimal LivId { get;set; }  // Livre.Liv_Id (PrimaryKey)

      [Required]
      [Column("Liv_Cloture")]
      public string LivCloture { get;set; }   // Livre.Liv_Cloture

      [Required]
      [Column("Liv_DateCloture")]
      public DateTime LivDatecloture { get;set; }   // Livre.Liv_DateCloture

      [Required]
      [Column("Liv_Numero")]
      public string LivNumero { get;set; }   // Livre.Liv_Numero

      [Required]
      [Column("Liv_NombreTitres")]
      public decimal LivNombretitres { get;set; }   // Livre.Liv_NombreTitres

      [Required]
      [Column("Liv_Salaires")]
      public decimal LivSalaires { get;set; }   // Livre.Liv_Salaires

      [Required]
      [Column("Liv_JoursPrestes")]
      public decimal LivJoursprestes { get;set; }   // Livre.Liv_JoursPrestes

      [Required]
      [Column("Liv_JoursVacances")]
      public decimal LivJoursvacances { get;set; }   // Livre.Liv_JoursVacances

      [Required]
      [Column("Liv_JoursMaladie")]
      public decimal LivJoursmaladie { get;set; }   // Livre.Liv_JoursMaladie

      [Required]
      [Column("Liv_JoursMaternite")]
      public decimal LivJoursmaternite { get;set; }   // Livre.Liv_JoursMaternite

      [Required]
      [Column("Liv_JoursAssimimles")]
      public decimal LivJoursassimimles { get;set; }   // Livre.Liv_JoursAssimimles

      [Required]
      [Column("Liv_NbrePrimesSyndicales")]
      public decimal LivNbreprimessyndicales { get;set; }   // Livre.Liv_NbrePrimesSyndicales

      [Required]
      [Column("Liv_TotalPrimesSyndicales")]
      public decimal LivTotalprimessyndicales { get;set; }   // Livre.Liv_TotalPrimesSyndicales

      [Required]
      [Column("Liv_NbrePrimesFormation")]
      public decimal LivNbreprimesformation { get;set; }   // Livre.Liv_NbrePrimesFormation

      [Required]
      [Column("Liv_TotalPrimesFormation")]
      public decimal LivTotalprimesformation { get;set; }   // Livre.Liv_TotalPrimesFormation

      [Required]
      [Column("Liv_TotalBrutPrimes")]
      public decimal LivTotalbrutprimes { get;set; }   // Livre.Liv_TotalBrutPrimes

      [Required]
      [Column("Liv_RetenueONSS")]
      public decimal LivRetenueonss { get;set; }   // Livre.Liv_RetenueONSS

      [Required]
      [Column("Liv_BaseImposable")]
      public decimal LivBaseimposable { get;set; }   // Livre.Liv_BaseImposable

      [Required]
      [Column("Liv_RetenueFiscale")]
      public decimal LivRetenuefiscale { get;set; }   // Livre.Liv_RetenueFiscale

      [Required]
      [Column("Liv_NetAvantFrais")]
      public decimal LivNetavantfrais { get;set; }   // Livre.Liv_NetAvantFrais

      [Required]
      [Column("Liv_FraisAdministratifs")]
      public decimal LivFraisadministratifs { get;set; }   // Livre.Liv_FraisAdministratifs

      [Required]
      [Column("Liv_Net")]
      public decimal LivNet { get;set; }   // Livre.Liv_Net

   }

   [Table("Historique")]
   public partial class Historique
   {

      [Required]
      [Column("Tbl_tag")]
      public decimal TblTag { get;set; }   // Historique.Tbl_tag

      [Required]
      [Column("Col_tag")]
      public decimal ColTag { get;set; }   // Historique.Col_tag

      [Required]
      [Column("His_DbRecId")]
      public decimal HisDbrecid { get;set; }   // Historique.His_DbRecId

      [Required]
      [Column("Col_PrvVal")]
      public string ColPrvval { get;set; }   // Historique.Col_PrvVal

      [Required]
      [Column("Col_CurVal")]
      public string ColCurval { get;set; }   // Historique.Col_CurVal

      [Required]
      [Column("His_Motivation")]
      public string HisMotivation { get;set; }   // Historique.His_Motivation

      [Required]
      [Column("Mod_Date")]
      public DateTime ModDate { get;set; }   // Historique.Mod_Date

      [Required]
      [Column("Usr_Login")]
      public string UsrLogin { get;set; }   // Historique.Usr_Login

   }

   [Table("Intervention")]
   public partial class Intervention
   {

      [Key]
      [Column("Int_Id")]
      public decimal IntId { get;set; }  // Intervention.Int_Id (PrimaryKey)

      [Required]
      [Column("Int_FinPeriode")]
      public DateTime IntFinperiode { get;set; }   // Intervention.Int_FinPeriode

      [Required]
      [Column("Int_DebutPeriode")]
      public DateTime IntDebutperiode { get;set; }   // Intervention.Int_DebutPeriode

      [Required]
      [Column("Int_NombreJours")]
      public decimal IntNombrejours { get;set; }   // Intervention.Int_NombreJours

      [Required]
      [Column("Int_MontantJournalier")]
      public decimal IntMontantjournalier { get;set; }   // Intervention.Int_MontantJournalier

      [Required]
      [Column("Int_BaseImposable")]
      public decimal IntBaseimposable { get;set; }   // Intervention.Int_BaseImposable

      [Required]
      [Column("Int_RetenueFiscale")]
      public decimal IntRetenuefiscale { get;set; }   // Intervention.Int_RetenueFiscale

      [Required]
      [Column("Int_MontantNet")]
      public decimal IntMontantnet { get;set; }   // Intervention.Int_MontantNet

      [Required]
      [Column("Int_Etat")]
      public string IntEtat { get;set; }   // Intervention.Int_Etat

      [Required]
      [Column("Int_DateLiquidation")]
      public DateTime IntDateliquidation { get;set; }   // Intervention.Int_DateLiquidation

      [Required]
      [Column("Int_Syndicat")]
      public string IntSyndicat { get;set; }   // Intervention.Int_Syndicat

      [Required]
      [Column("Int_FraisAdministratifs")]
      public decimal IntFraisadministratifs { get;set; }   // Intervention.Int_FraisAdministratifs

      [Required]
      [Column("Int_MontantPayable")]
      public decimal IntMontantpayable { get;set; }   // Intervention.Int_MontantPayable

      [Required]
      [Column("Int_MontantBrut")]
      public decimal IntMontantbrut { get;set; }   // Intervention.Int_MontantBrut

      [Required]
      [Column("Int_RetenueOnss")]
      public decimal IntRetenueonss { get;set; }   // Intervention.Int_RetenueOnss

      [Required]
      [Column("Int_NombreHeures")]
      public decimal IntNombreheures { get;set; }   // Intervention.Int_NombreHeures

      [Required]
      [Column("Int_MontantHoraire")]
      public decimal IntMontanthoraire { get;set; }   // Intervention.Int_MontantHoraire

      [Required]
      [Column("Int_Automatique")]
      public string IntAutomatique { get;set; }   // Intervention.Int_Automatique

      [Column("Dei_Id")]
      public decimal DeiId { get;set; }  // Intervention.Dei_Id (ForeignKey)

      [Column("Dia_Id")]
      public decimal DiaId { get;set; }  // Intervention.Dia_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DeiId")]
      public virtual DemandeIntervention DemandeIntervention_DeiId { get; set; }

      [ForeignKey("DiaId")]
      public virtual DemandeInterventionAutomatique DemandeInterventionAutomatique_DiaId { get; set; }

   }

   [Table("Ligne_Releve")]
   public partial class LigneReleve
   {

      [Key]
      [Column("Lre_ID")]
      public decimal LreId { get;set; }  // Ligne_Releve.Lre_ID (PrimaryKey)

      [Required]
      [Column("Lre_Trimestre")]
      public string LreTrimestre { get;set; }   // Ligne_Releve.Lre_Trimestre

      [Required]
      [Column("Lre_NISS")]
      public string LreNiss { get;set; }   // Ligne_Releve.Lre_NISS

      [Required]
      [Column("Lre_ONSS")]
      public string LreOnss { get;set; }   // Ligne_Releve.Lre_ONSS

      [Required]
      [Column("Lre_CategorieEmployeur")]
      public string LreCategorieemployeur { get;set; }   // Ligne_Releve.Lre_CategorieEmployeur

      [Required]
      [Column("Lre_CodeTravailleur")]
      public string LreCodetravailleur { get;set; }   // Ligne_Releve.Lre_CodeTravailleur

      [Required]
      [Column("Lre_Active")]
      public string LreActive { get;set; }   // Ligne_Releve.Lre_Active

      [Required]
      [Column("Lre_Origine")]
      public string LreOrigine { get;set; }   // Ligne_Releve.Lre_Origine

      [Required]
      [Column("Lre_DNRB")]
      public string LreDnrb { get;set; }   // Ligne_Releve.Lre_DNRB

      [Required]
      [Column("Lre_LSDNR")]
      public string LreLsdnr { get;set; }   // Ligne_Releve.Lre_LSDNR

      [Required]
      [Column("Lre_DateDebutTrimestre")]
      public DateTime LreDatedebuttrimestre { get;set; }   // Ligne_Releve.Lre_DateDebutTrimestre

      [Required]
      [Column("Lre_DateFinTrimestre")]
      public DateTime LreDatefintrimestre { get;set; }   // Ligne_Releve.Lre_DateFinTrimestre

      [Required]
      [Column("Lre_DateCreation")]
      public DateTime LreDatecreation { get;set; }   // Ligne_Releve.Lre_DateCreation

      [Required]
      [Column("Lre_Source")]
      public string LreSource { get;set; }   // Ligne_Releve.Lre_Source

      [Required]
      [Column("Lre_NumeroAgent")]
      public string LreNumeroagent { get;set; }   // Ligne_Releve.Lre_NumeroAgent

      [Required]
      [Column("Lre_TexteLibre")]
      public string LreTextelibre { get;set; }   // Ligne_Releve.Lre_TexteLibre

      [Required]
      [Column("Lre_ExistenceAMI")]
      public string LreExistenceami { get;set; }   // Ligne_Releve.Lre_ExistenceAMI

      [Required]
      [Column("Lre_ExistenceChomage")]
      public string LreExistencechomage { get;set; }   // Ligne_Releve.Lre_ExistenceChomage

      [Required]
      [Column("Lre_CodeArchive")]
      public string LreCodearchive { get;set; }   // Ligne_Releve.Lre_CodeArchive

      [Required]
      [Column("Lre_ValidationCGER")]
      public string LreValidationcger { get;set; }   // Ligne_Releve.Lre_ValidationCGER

      [Required]
      [Column("Lre_DateInjection")]
      public DateTime LreDateinjection { get;set; }   // Ligne_Releve.Lre_DateInjection

      [Required]
      [Column("Lre_motivation")]
      public string LreMotivation { get;set; }   // Ligne_Releve.Lre_motivation

      [Column("Env_Id")]
      public decimal EnvId { get;set; }  // Ligne_Releve.Env_Id (ForeignKey)

      [Column("Con_ID")]
      public decimal ConId { get;set; }  // Ligne_Releve.Con_ID (ForeignKey)

      [Column("Pct_Id")]
      public decimal PctId { get;set; }  // Ligne_Releve.Pct_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("EnvId")]
      public virtual Envoi Envoi_EnvId { get; set; }

      [ForeignKey("ConId")]
      public virtual Contrat Contrat_ConId { get; set; }

      [ForeignKey("PctId")]
      public virtual PrimeContrat PrimeContrat_PctId { get; set; }

   }

   [Table("Localite")]
   public partial class Localite
   {

      [Key]
      [Column("Loc_CodePostal")]
      public string LocCodepostal { get;set; }  // Localite.Loc_CodePostal (PrimaryKey)

      [Required]
      [Column("Loc_NlLocalite")]
      public string LocNllocalite { get;set; }   // Localite.Loc_NlLocalite

      [Required]
      [Column("Loc_FrLocalite")]
      public string LocFrlocalite { get;set; }   // Localite.Loc_FrLocalite

      [Required]
      [Column("Loc_CodeLangue")]
      public string LocCodelangue { get;set; }   // Localite.Loc_CodeLangue

      [Required]
      [Column("Loc_CodeRegion")]
      public string LocCoderegion { get;set; }   // Localite.Loc_CodeRegion

      [Required]
      [Column("Loc_CentreTri")]
      public string LocCentretri { get;set; }   // Localite.Loc_CentreTri

      [Required]
      [Column("Loc_CentreDistribution")]
      public string LocCentredistribution { get;set; }   // Localite.Loc_CentreDistribution

      [Required]
      [Column("Loc_CodeProvince")]
      public string LocCodeprovince { get;set; }   // Localite.Loc_CodeProvince

      [Required]
      [Column("Loc_CodeArrondissement")]
      public string LocCodearrondissement { get;set; }   // Localite.Loc_CodeArrondissement

   }

   [Table("Marque")]
   public partial class Marque
   {

      [Key]
      [Column("Mrq_Id")]
      public decimal MrqId { get;set; }  // Marque.Mrq_Id (PrimaryKey)

      [Required]
      [Column("Mrq_TypeObjet")]
      public decimal MrqTypeobjet { get;set; }   // Marque.Mrq_TypeObjet

      [Required]
      [Column("Mrq_IdObjet")]
      public decimal MrqIdobjet { get;set; }   // Marque.Mrq_IdObjet

      [Required]
      [Column("Mrq_Parent")]
      public decimal MrqParent { get;set; }   // Marque.Mrq_Parent

      [Required]
      [Column("Mrq_Type")]
      public string MrqType { get;set; }   // Marque.Mrq_Type

      [Required]
      [Column("Mrq_DateCreation")]
      public DateTime MrqDatecreation { get;set; }   // Marque.Mrq_DateCreation

      [Required]
      [Column("Mrq_Motivation")]
      public string MrqMotivation { get;set; }   // Marque.Mrq_Motivation

      [Required]
      [Column("Mrq_Apposeur")]
      public string MrqApposeur { get;set; }   // Marque.Mrq_Apposeur

      [Required]
      [Column("Mrq_Destinataire")]
      public string MrqDestinataire { get;set; }   // Marque.Mrq_Destinataire

      [Required]
      [Column("Mrq_Etat")]
      public string MrqEtat { get;set; }   // Marque.Mrq_Etat

      [Required]
      [Column("Mrq_Priorite")]
      public string MrqPriorite { get;set; }   // Marque.Mrq_Priorite

      [Required]
      [Column("Mrq_DateDebutValidite")]
      public DateTime MrqDatedebutvalidite { get;set; }   // Marque.Mrq_DateDebutValidite

      [Required]
      [Column("Mrq_DateFinValidite")]
      public DateTime MrqDatefinvalidite { get;set; }   // Marque.Mrq_DateFinValidite

      [Required]
      [Column("Mrq_DatePlanifiee")]
      public DateTime MrqDateplanifiee { get;set; }   // Marque.Mrq_DatePlanifiee

      [Required]
      [Column("Mrq_DateExecution")]
      public DateTime MrqDateexecution { get;set; }   // Marque.Mrq_DateExecution

      [Required]
      [Column("Mrq_TypeValeur1")]
      public string MrqTypevaleur1 { get;set; }   // Marque.Mrq_TypeValeur1

      [Required]
      [Column("Mrq_Valeur1")]
      public string MrqValeur1 { get;set; }   // Marque.Mrq_Valeur1

      [Required]
      [Column("Mrq_TypeValeur2")]
      public string MrqTypevaleur2 { get;set; }   // Marque.Mrq_TypeValeur2

      [Required]
      [Column("Mrq_Valeur2")]
      public string MrqValeur2 { get;set; }   // Marque.Mrq_Valeur2

      [Required]
      [Column("Mrq_TypeValeur3")]
      public string MrqTypevaleur3 { get;set; }   // Marque.Mrq_TypeValeur3

      [Required]
      [Column("Mrq_Valeur3")]
      public string MrqValeur3 { get;set; }   // Marque.Mrq_Valeur3

      [Required]
      [Column("Mrq_Niss")]
      public string MrqNiss { get;set; }   // Marque.Mrq_Niss

      [Required]
      [Column("Mrq_Onss")]
      public string MrqOnss { get;set; }   // Marque.Mrq_Onss

   }

   [Table("Travailleur")]
   public partial class Travailleur
   {

      [Key]
      [Column("Tra_ID")]
      public decimal TraId { get;set; }  // Travailleur.Tra_ID (PrimaryKey)

      [Required]
      [Column("Tra_NISS")]
      public string TraNiss { get;set; }   // Travailleur.Tra_NISS

      [Required]
      [Column("Tra_Nom")]
      public string TraNom { get;set; }   // Travailleur.Tra_Nom

      [Required]
      [Column("Tra_Prenom")]
      public string TraPrenom { get;set; }   // Travailleur.Tra_Prenom

      [Required]
      [Column("Tra_Sexe")]
      public string TraSexe { get;set; }   // Travailleur.Tra_Sexe

      [Required]
      [Column("Tra_Langue")]
      public string TraLangue { get;set; }   // Travailleur.Tra_Langue

      [Required]
      [Column("Tra_DateNaissance")]
      public DateTime TraDatenaissance { get;set; }   // Travailleur.Tra_DateNaissance

      [Required]
      [Column("Tra_DateDeces")]
      public DateTime TraDatedeces { get;set; }   // Travailleur.Tra_DateDeces

      [Required]
      [Column("Tra_ModePayement")]
      public string TraModepayement { get;set; }   // Travailleur.Tra_ModePayement

      [Required]
      [Column("Tra_CompteBancaire")]
      public string TraComptebancaire { get;set; }   // Travailleur.Tra_CompteBancaire

      [Required]
      [Column("Tra_AdresseRue")]
      public string TraAdresserue { get;set; }   // Travailleur.Tra_AdresseRue

      [Required]
      [Column("Tra_AdresseNo")]
      public string TraAdresseno { get;set; }   // Travailleur.Tra_AdresseNo

      [Required]
      [Column("Tra_AdresseBte")]
      public string TraAdressebte { get;set; }   // Travailleur.Tra_AdresseBte

      [Required]
      [Column("Tra_CodePostal")]
      public string TraCodepostal { get;set; }   // Travailleur.Tra_CodePostal

      [Required]
      [Column("Tra_Localite")]
      public string TraLocalite { get;set; }   // Travailleur.Tra_Localite

      [Required]
      [Column("Tra_CodePays")]
      public string TraCodepays { get;set; }   // Travailleur.Tra_CodePays

      [Required]
      [Column("Tra_Telephone")]
      public string TraTelephone { get;set; }   // Travailleur.Tra_Telephone

      [Required]
      [Column("Tra_OrigineAdresse")]
      public string TraOrigineadresse { get;set; }   // Travailleur.Tra_OrigineAdresse

      [Required]
      [Column("Tra_DateModifAdresse")]
      public DateTime TraDatemodifadresse { get;set; }   // Travailleur.Tra_DateModifAdresse

      [Required]
      [Column("Tra_AdresseRueDerog")]
      public string TraAdresseruederog { get;set; }   // Travailleur.Tra_AdresseRueDerog

      [Required]
      [Column("Tra_AdresseNoDerog")]
      public string TraAdressenoderog { get;set; }   // Travailleur.Tra_AdresseNoDerog

      [Required]
      [Column("Tra_AdresseBteDerog")]
      public string TraAdressebtederog { get;set; }   // Travailleur.Tra_AdresseBteDerog

      [Required]
      [Column("Tra_CodePostalDerog")]
      public string TraCodepostalderog { get;set; }   // Travailleur.Tra_CodePostalDerog

      [Required]
      [Column("Tra_LocaliteDerog")]
      public string TraLocalitederog { get;set; }   // Travailleur.Tra_LocaliteDerog

      [Required]
      [Column("Tra_CodePaysDerog")]
      public string TraCodepaysderog { get;set; }   // Travailleur.Tra_CodePaysDerog

      [Required]
      [Column("Tra_TelephoneDerog")]
      public string TraTelephonederog { get;set; }   // Travailleur.Tra_TelephoneDerog

      [Required]
      [Column("Tra_OrigineDerog")]
      public string TraOriginederog { get;set; }   // Travailleur.Tra_OrigineDerog

      [Required]
      [Column("Tra_DateDebutDerog")]
      public DateTime TraDatedebutderog { get;set; }   // Travailleur.Tra_DateDebutDerog

      [Required]
      [Column("Tra_DateFinDerog")]
      public DateTime TraDatefinderog { get;set; }   // Travailleur.Tra_DateFinDerog

      [Required]
      [Column("Tra_DateModifDerog")]
      public DateTime TraDatemodifderog { get;set; }   // Travailleur.Tra_DateModifDerog

      [Required]
      [Column("Tra_CalculManuelRetenue")]
      public string TraCalculmanuelretenue { get;set; }   // Travailleur.Tra_CalculManuelRetenue

      [Required]
      [Column("Tra_CalculManuelRangCreance")]
      public string TraCalculmanuelrangcreance { get;set; }   // Travailleur.Tra_CalculManuelRangCreance

      [Required]
      [Column("Tra_NbreEnfants")]
      public decimal TraNbreenfants { get;set; }   // Travailleur.Tra_NbreEnfants

      [Required]
      [Column("Tra_NbreHandicapes")]
      public decimal TraNbrehandicapes { get;set; }   // Travailleur.Tra_NbreHandicapes

      [Required]
      [Column("Tra_AutresACharge")]
      public decimal TraAutresacharge { get;set; }   // Travailleur.Tra_AutresACharge

      [Required]
      [Column("Tra_ConjointACharge")]
      public string TraConjointacharge { get;set; }   // Travailleur.Tra_ConjointACharge

      [Required]
      [Column("Tra_RevenusConjoint")]
      public decimal TraRevenusconjoint { get;set; }   // Travailleur.Tra_RevenusConjoint

      [Required]
      [Column("Tra_TypeRevenusConjoint")]
      public string TraTyperevenusconjoint { get;set; }   // Travailleur.Tra_TypeRevenusConjoint

      [Required]
      [Column("Tra_VeufCelibataire")]
      public string TraVeufcelibataire { get;set; }   // Travailleur.Tra_VeufCelibataire

      [Required]
      [Column("Tra_AdresseIncomplete")]
      public string TraAdresseincomplete { get;set; }   // Travailleur.Tra_AdresseIncomplete

      [Required]
      [Column("Tra_Commentaire")]
      public string TraCommentaire { get;set; }   // Travailleur.Tra_Commentaire

      [Required]
      [Column("Tra_NissFusion")]
      public string TraNissfusion { get;set; }   // Travailleur.Tra_NissFusion

      [Required]
      [Column("Tra_Oriolus")]
      public string TraOriolus { get;set; }   // Travailleur.Tra_Oriolus

      [Required]
      [Column("Tra_Nationalite")]
      public string TraNationalite { get;set; }   // Travailleur.Tra_Nationalite

      [Required]
      [Column("Tra_IBAN")]
      public string TraIban { get;set; }   // Travailleur.Tra_IBAN

      [Required]
      [Column("Tra_BIC")]
      public string TraBic { get;set; }   // Travailleur.Tra_BIC

      [Required]
      [Column("Tra_LangueDerog")]
      public string TraLanguederog { get;set; }   // Travailleur.Tra_LangueDerog

      [Required]
      [Column("Tra_EtatCivil")]
      public string TraEtatcivil { get;set; }   // Travailleur.Tra_EtatCivil

      [Required]
      [Column("Tra_DatePension")]
      public DateTime TraDatepension { get;set; }   // Travailleur.Tra_DatePension

      [Required]
      [Column("Tra_DateFinDroitPension")]
      public DateTime TraDatefindroitpension { get;set; }   // Travailleur.Tra_DateFinDroitPension

      [Required]
      [Column("Tra_DateNationalite")]
      public DateTime TraDatenationalite { get;set; }   // Travailleur.Tra_DateNationalite

      [Required]
      [Column("Tra_PartnerNiss")]
      public string TraPartnerniss { get;set; }   // Travailleur.Tra_PartnerNiss

      [Required]
      [Column("Tra_PartnerNom")]
      public string TraPartnernom { get;set; }   // Travailleur.Tra_PartnerNom

      [Required]
      [Column("Tra_PartnerPrenom")]
      public string TraPartnerprenom { get;set; }   // Travailleur.Tra_PartnerPrenom

      [Required]
      [Column("Tra_CompositionMenage")]
      public string TraCompositionmenage { get;set; }   // Travailleur.Tra_CompositionMenage

      [Required]
      [Column("Tra_DateInjection")]
      public DateTime TraDateinjection { get;set; }   // Travailleur.Tra_DateInjection

      [Required]
      [Column("Tra_RaisonRadiation")]
      public string TraRaisonradiation { get;set; }   // Travailleur.Tra_RaisonRadiation

      [Column("Tra_Ter_Id")]
      public decimal TraTerId { get;set; }  // Travailleur.Tra_Ter_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraTerId")]
      public virtual Travailleur Travailleur_TraTerId { get; set; }

   }

   [Table("Mouvement_Assimilation")]
   public partial class MouvementAssimilation
   {

      [Key]
      [Column("Mas_ID")]
      public decimal MasId { get;set; }  // Mouvement_Assimilation.Mas_ID (PrimaryKey)

      [Required]
      [Column("Mas_Trimestre")]
      public string MasTrimestre { get;set; }   // Mouvement_Assimilation.Mas_Trimestre

      [Required]
      [Column("Mas_DNRB")]
      public string MasDnrb { get;set; }   // Mouvement_Assimilation.Mas_DNRB

      [Required]
      [Column("Mas_LSDNR")]
      public string MasLsdnr { get;set; }   // Mouvement_Assimilation.Mas_LSDNR

      [Required]
      [Column("Mas_Periode")]
      public decimal MasPeriode { get;set; }   // Mouvement_Assimilation.Mas_Periode

      [Required]
      [Column("Mas_Nature")]
      public string MasNature { get;set; }   // Mouvement_Assimilation.Mas_Nature

      [Required]
      [Column("Mas_Regime")]
      public string MasRegime { get;set; }   // Mouvement_Assimilation.Mas_Regime

      [Required]
      [Column("Mas_JoursDeclares")]
      public decimal MasJoursdeclares { get;set; }   // Mouvement_Assimilation.Mas_JoursDeclares

      [Required]
      [Column("Mas_DateDebutPeriode")]
      public DateTime MasDatedebutperiode { get;set; }   // Mouvement_Assimilation.Mas_DateDebutPeriode

      [Required]
      [Column("Mas_DateFinPeriode")]
      public DateTime MasDatefinperiode { get;set; }   // Mouvement_Assimilation.Mas_DateFinPeriode

      [Required]
      [Column("Mas_TexteLibre")]
      public string MasTextelibre { get;set; }   // Mouvement_Assimilation.Mas_TexteLibre

      [Required]
      [Column("Mas_JoursAttribues")]
      public decimal MasJoursattribues { get;set; }   // Mouvement_Assimilation.Mas_JoursAttribues

      [Required]
      [Column("Mas_Motivation")]
      public string MasMotivation { get;set; }   // Mouvement_Assimilation.Mas_Motivation

      [Required]
      [Column("Mas_Gestionnaire")]
      public string MasGestionnaire { get;set; }   // Mouvement_Assimilation.Mas_Gestionnaire

      [Required]
      [Column("Mas_DateAttribution")]
      public DateTime MasDateattribution { get;set; }   // Mouvement_Assimilation.Mas_DateAttribution

      [Required]
      [Column("Mas_Etat")]
      public string MasEtat { get;set; }   // Mouvement_Assimilation.Mas_Etat

      [Required]
      [Column("Mas_ModeTraitement")]
      public string MasModetraitement { get;set; }   // Mouvement_Assimilation.Mas_ModeTraitement

      [Required]
      [Column("Mas_ModeAttribution")]
      public string MasModeattribution { get;set; }   // Mouvement_Assimilation.Mas_ModeAttribution

      [Column("Lre_Id")]
      public decimal LreId { get;set; }  // Mouvement_Assimilation.Lre_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("LreId")]
      public virtual LigneReleve LigneReleve { get; set; }

   }

   [Table("Att_A045_Disease")]
   public partial class AttA045Disease
   {

      [Key]
      [Column("Dis45_Id")]
      public decimal Dis45Id { get;set; }  // Att_A045_Disease.Dis45_Id (PrimaryKey)

      [Required]
      [Column("Dis45_KindOfRequest")]
      public string Dis45Kindofrequest { get;set; }   // Att_A045_Disease.Dis45_KindOfRequest

      [Required]
      [Column("Dis45_CategoryOfRequest")]
      public string Dis45Categoryofrequest { get;set; }   // Att_A045_Disease.Dis45_CategoryOfRequest

      [Required]
      [Column("Dis45_NotificationDate")]
      public DateTime Dis45Notificationdate { get;set; }   // Att_A045_Disease.Dis45_NotificationDate

      [Required]
      [Column("Dis45_ContestationDate")]
      public DateTime Dis45Contestationdate { get;set; }   // Att_A045_Disease.Dis45_ContestationDate

      [Column("Att45_Id")]
      public decimal Att45Id { get;set; }  // Att_A045_Disease.Att45_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Att45Id")]
      public virtual AttA045 AttA045 { get; set; }

   }

   [Table("Mouvement_Remuneration")]
   public partial class MouvementRemuneration
   {

      [Key]
      [Column("Mre_Id")]
      public decimal MreId { get;set; }  // Mouvement_Remuneration.Mre_Id (PrimaryKey)

      [Required]
      [Column("Mre_Trimestre")]
      public string MreTrimestre { get;set; }   // Mouvement_Remuneration.Mre_Trimestre

      [Required]
      [Column("Mre_DNRB")]
      public string MreDnrb { get;set; }   // Mouvement_Remuneration.Mre_DNRB

      [Required]
      [Column("Mre_LSDNR")]
      public string MreLsdnr { get;set; }   // Mouvement_Remuneration.Mre_LSDNR

      [Required]
      [Column("Mre_Periode")]
      public decimal MrePeriode { get;set; }   // Mouvement_Remuneration.Mre_Periode

      [Required]
      [Column("Mre_Nature")]
      public string MreNature { get;set; }   // Mouvement_Remuneration.Mre_Nature

      [Required]
      [Column("Mre_Regime")]
      public string MreRegime { get;set; }   // Mouvement_Remuneration.Mre_Regime

      [Required]
      [Column("Mre_JoursRemuneres")]
      public decimal MreJoursremuneres { get;set; }   // Mouvement_Remuneration.Mre_JoursRemuneres

      [Required]
      [Column("Mre_HeuresRemunerees")]
      public decimal MreHeuresremunerees { get;set; }   // Mouvement_Remuneration.Mre_HeuresRemunerees

      [Required]
      [Column("Mre_HeuresSemTravRef")]
      public decimal MreHeuressemtravref { get;set; }   // Mouvement_Remuneration.Mre_HeuresSemTravRef

      [Required]
      [Column("Mre_JoursVacances")]
      public decimal MreJoursvacances { get;set; }   // Mouvement_Remuneration.Mre_JoursVacances

      [Required]
      [Column("Mre_SalaireBrut")]
      public decimal MreSalairebrut { get;set; }   // Mouvement_Remuneration.Mre_SalaireBrut

      [Required]
      [Column("Mre_DateDebutPeriode")]
      public DateTime MreDatedebutperiode { get;set; }   // Mouvement_Remuneration.Mre_DateDebutPeriode

      [Required]
      [Column("Mre_DateFinPeriode")]
      public DateTime MreDatefinperiode { get;set; }   // Mouvement_Remuneration.Mre_DateFinPeriode

      [Required]
      [Column("Mre_TexteLibre")]
      public string MreTextelibre { get;set; }   // Mouvement_Remuneration.Mre_TexteLibre

      [Column("Lre_Id")]
      public decimal LreId { get;set; }  // Mouvement_Remuneration.Lre_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("LreId")]
      public virtual LigneReleve LigneReleve { get; set; }

   }

   [Table("Payement_Compteur")]
   public partial class PayementCompteur
   {

      [Key]
      [Column("Pac_Id")]
      public decimal PacId { get;set; }  // Payement_Compteur.Pac_Id (PrimaryKey)

      [Required]
      [Column("Pac_Exercice")]
      public decimal PacExercice { get;set; }   // Payement_Compteur.Pac_Exercice

      [Required]
      [Column("Pac_Prefixe")]
      public string PacPrefixe { get;set; }   // Payement_Compteur.Pac_Prefixe

      [Required]
      [Column("Pac_Numero")]
      public decimal PacNumero { get;set; }   // Payement_Compteur.Pac_Numero

   }

   [Table("Att_A045_DecisionFbzFmp")]
   public partial class AttA045Decisionfbzfmp
   {

      [Key]
      [Column("Dcn45_Id")]
      public decimal Dcn45Id { get;set; }  // Att_A045_DecisionFbzFmp.Dcn45_Id (PrimaryKey)

      [Required]
      [Column("Dcn45_DecisionCode")]
      public string Dcn45Decisioncode { get;set; }   // Att_A045_DecisionFbzFmp.Dcn45_DecisionCode

      [Required]
      [Column("Dcn45_DisablementBeginDate")]
      public DateTime Dcn45Disablementbegindate { get;set; }   // Att_A045_DecisionFbzFmp.Dcn45_DisablementBeginDate

      [Required]
      [Column("Dcn45_AllowanceAmount")]
      public decimal Dcn45Allowanceamount { get;set; }   // Att_A045_DecisionFbzFmp.Dcn45_AllowanceAmount

      [Column("Dis45_Id")]
      public decimal Dis45Id { get;set; }  // Att_A045_DecisionFbzFmp.Dis45_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("Dis45Id")]
      public virtual AttA045Disease AttA045Disease { get; set; }

   }

   [Table("Employeur")]
   public partial class Employeur
   {

      [Key]
      [Column("Emp_ID")]
      public decimal EmpId { get;set; }  // Employeur.Emp_ID (PrimaryKey)

      [Required]
      [Column("Emp_ONSS")]
      public string EmpOnss { get;set; }   // Employeur.Emp_ONSS

      [Required]
      [Column("Emp_NUE")]
      public string EmpNue { get;set; }   // Employeur.Emp_NUE

      [Required]
      [Column("Emp_Nom")]
      public string EmpNom { get;set; }   // Employeur.Emp_Nom

      [Required]
      [Column("Emp_Langue")]
      public string EmpLangue { get;set; }   // Employeur.Emp_Langue

      [Required]
      [Column("Emp_LangueDerog")]
      public string EmpLanguederog { get;set; }   // Employeur.Emp_LangueDerog

      [Required]
      [Column("Emp_AdresseRue")]
      public string EmpAdresserue { get;set; }   // Employeur.Emp_AdresseRue

      [Required]
      [Column("Emp_AdresseNo")]
      public string EmpAdresseno { get;set; }   // Employeur.Emp_AdresseNo

      [Required]
      [Column("Emp_AdresseBte")]
      public string EmpAdressebte { get;set; }   // Employeur.Emp_AdresseBte

      [Required]
      [Column("Emp_CodePostal")]
      public string EmpCodepostal { get;set; }   // Employeur.Emp_CodePostal

      [Required]
      [Column("Emp_Localite")]
      public string EmpLocalite { get;set; }   // Employeur.Emp_Localite

      [Required]
      [Column("Emp_CodePays")]
      public string EmpCodepays { get;set; }   // Employeur.Emp_CodePays

      [Required]
      [Column("Emp_CodeLocalite")]
      public string EmpCodelocalite { get;set; }   // Employeur.Emp_CodeLocalite

      [Required]
      [Column("Emp_DateModificationAdresse")]
      public DateTime EmpDatemodificationadresse { get;set; }   // Employeur.Emp_DateModificationAdresse

      [Required]
      [Column("Emp_IBAN")]
      public string EmpIban { get;set; }   // Employeur.Emp_IBAN

      [Required]
      [Column("Emp_BIC")]
      public string EmpBic { get;set; }   // Employeur.Emp_BIC

      [Required]
      [Column("Emp_Telephone")]
      public string EmpTelephone { get;set; }   // Employeur.Emp_Telephone

      [Required]
      [Column("Emp_Fax")]
      public string EmpFax { get;set; }   // Employeur.Emp_Fax

      [Required]
      [Column("Emp_NomContact")]
      public string EmpNomcontact { get;set; }   // Employeur.Emp_NomContact

      [Required]
      [Column("Emp_DateMatricule")]
      public DateTime EmpDatematricule { get;set; }   // Employeur.Emp_DateMatricule

      [Required]
      [Column("Emp_DateFaillite")]
      public DateTime EmpDatefaillite { get;set; }   // Employeur.Emp_DateFaillite

      [Required]
      [Column("Emp_DateRadiation")]
      public DateTime EmpDateradiation { get;set; }   // Employeur.Emp_DateRadiation

      [Required]
      [Column("Emp_Curatelle")]
      public string EmpCuratelle { get;set; }   // Employeur.Emp_Curatelle

      [Required]
      [Column("Emp_AffiliationSSoc")]
      public string EmpAffiliationssoc { get;set; }   // Employeur.Emp_AffiliationSSoc

      [Required]
      [Column("Emp_SecSocialActuel")]
      public string EmpSecsocialactuel { get;set; }   // Employeur.Emp_SecSocialActuel

      [Required]
      [Column("Emp_SecSocialPrecedent")]
      public string EmpSecsocialprecedent { get;set; }   // Employeur.Emp_SecSocialPrecedent

      [Required]
      [Column("Emp_SecSocialTrimestre")]
      public string EmpSecsocialtrimestre { get;set; }   // Employeur.Emp_SecSocialTrimestre

      [Required]
      [Column("Emp_FormeJuridique")]
      public string EmpFormejuridique { get;set; }   // Employeur.Emp_FormeJuridique

      [Required]
      [Column("Emp_DateModification")]
      public DateTime EmpDatemodification { get;set; }   // Employeur.Emp_DateModification

      [Required]
      [Column("Emp_DateInjection")]
      public DateTime EmpDateinjection { get;set; }   // Employeur.Emp_DateInjection

      [Required]
      [Column("Emp_NoUGBN")]
      public string EmpNougbn { get;set; }   // Employeur.Emp_NoUGBN

   }

   [Table("Query")]
   public partial class Query
   {

      [Key]
      [Column("Qry_Id")]
      public decimal QryId { get;set; }  // Query.Qry_Id (PrimaryKey)

      [Required]
      [Column("Qry_Groupe")]
      public string QryGroupe { get;set; }   // Query.Qry_Groupe

      [Required]
      [Column("Qry_TagApplication")]
      public decimal QryTagapplication { get;set; }   // Query.Qry_TagApplication

      [Required]
      [Column("Qry_TagDialogue")]
      public decimal QryTagdialogue { get;set; }   // Query.Qry_TagDialogue

      [Required]
      [Column("Qry_Type")]
      public string QryType { get;set; }   // Query.Qry_Type

      [Required]
      [Column("Qry_Document")]
      public string QryDocument { get;set; }   // Query.Qry_Document

      [Required]
      [Column("Qry_Key")]
      public string QryKey { get;set; }   // Query.Qry_Key

      [Required]
      [Column("Qry_State")]
      public string QryState { get;set; }   // Query.Qry_State

      [Required]
      [Column("Qry_Utilisateur")]
      public string QryUtilisateur { get;set; }   // Query.Qry_Utilisateur

      [Required]
      [Column("Qry_NlKey")]
      public string QryNlkey { get;set; }   // Query.Qry_NlKey

      [Required]
      [Column("Qry_FrKey")]
      public string QryFrkey { get;set; }   // Query.Qry_FrKey

      [Required]
      [Column("Qry_NlHeader")]
      public string QryNlheader { get;set; }   // Query.Qry_NlHeader

      [Required]
      [Column("Qry_FrHeader")]
      public string QryFrheader { get;set; }   // Query.Qry_FrHeader

   }

   [Table("Retenue_Creance")]
   public partial class RetenueCreance
   {

      [Key]
      [Column("Rcr_Id")]
      public decimal RcrId { get;set; }  // Retenue_Creance.Rcr_Id (PrimaryKey)

      [Required]
      [Column("Rcr_MontantRetenue")]
      public decimal RcrMontantretenue { get;set; }   // Retenue_Creance.Rcr_MontantRetenue

      [Required]
      [Column("Rcr_SoldeAPayer")]
      public decimal RcrSoldeapayer { get;set; }   // Retenue_Creance.Rcr_SoldeAPayer

      [Required]
      [Column("Rcr_DateCalcul")]
      public DateTime RcrDatecalcul { get;set; }   // Retenue_Creance.Rcr_DateCalcul

      [Required]
      [Column("Rcr_TotalPayements")]
      public decimal RcrTotalpayements { get;set; }   // Retenue_Creance.Rcr_TotalPayements

      [Required]
      [Column("Rcr_APayer")]
      public string RcrApayer { get;set; }   // Retenue_Creance.Rcr_APayer

      [Required]
      [Column("Rcr_NomCreancier")]
      public string RcrNomcreancier { get;set; }   // Retenue_Creance.Rcr_NomCreancier

      [Column("Cre_ID")]
      public decimal CreId { get;set; }  // Retenue_Creance.Cre_ID (ForeignKey)

      [Column("Ptr_Id")]
      public decimal PtrId { get;set; }  // Retenue_Creance.Ptr_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("CreId")]
      public virtual Creance Creance_CreId { get; set; }

      [ForeignKey("PtrId")]
      public virtual PrimeTravailleur PrimeTravailleur_PtrId { get; set; }

   }

   [Table("Siege_Exploitation")]
   public partial class SiegeExploitation
   {

      [Key]
      [Column("Sie_ID")]
      public decimal SieId { get;set; }  // Siege_Exploitation.Sie_ID (PrimaryKey)

      [Required]
      [Column("Sie_Numero")]
      public decimal SieNumero { get;set; }   // Siege_Exploitation.Sie_Numero

      [Required]
      [Column("Sie_NomSiege")]
      public string SieNomsiege { get;set; }   // Siege_Exploitation.Sie_NomSiege

      [Required]
      [Column("Sie_NomContact")]
      public string SieNomcontact { get;set; }   // Siege_Exploitation.Sie_NomContact

      [Required]
      [Column("Sie_AdresseRue")]
      public string SieAdresserue { get;set; }   // Siege_Exploitation.Sie_AdresseRue

      [Required]
      [Column("Sie_AdresseNo")]
      public string SieAdresseno { get;set; }   // Siege_Exploitation.Sie_AdresseNo

      [Required]
      [Column("Sie_AdresseBte")]
      public string SieAdressebte { get;set; }   // Siege_Exploitation.Sie_AdresseBte

      [Required]
      [Column("Sie_CodePostal")]
      public string SieCodepostal { get;set; }   // Siege_Exploitation.Sie_CodePostal

      [Required]
      [Column("Sie_Localite")]
      public string SieLocalite { get;set; }   // Siege_Exploitation.Sie_Localite

      [Required]
      [Column("Sie_Pays")]
      public string SiePays { get;set; }   // Siege_Exploitation.Sie_Pays

      [Required]
      [Column("Sie_Telephone")]
      public string SieTelephone { get;set; }   // Siege_Exploitation.Sie_Telephone

      [Required]
      [Column("Sie_Fax")]
      public string SieFax { get;set; }   // Siege_Exploitation.Sie_Fax

      [Required]
      [Column("Sie_DateLiquidation")]
      public DateTime SieDateliquidation { get;set; }   // Siege_Exploitation.Sie_DateLiquidation

      [Required]
      [Column("Sie_NumeroMatriculeDebut")]
      public string SieNumeromatriculedebut { get;set; }   // Siege_Exploitation.Sie_NumeroMatriculeDebut

      [Required]
      [Column("Sie_NumeroMatriculeFin")]
      public string SieNumeromatriculefin { get;set; }   // Siege_Exploitation.Sie_NumeroMatriculeFin

      [Required]
      [Column("Sie_NomSecretariatSoc")]
      public string SieNomsecretariatsoc { get;set; }   // Siege_Exploitation.Sie_NomSecretariatSoc

      [Required]
      [Column("Sie_IBAN")]
      public string SieIban { get;set; }   // Siege_Exploitation.Sie_IBAN

      [Required]
      [Column("Sie_BIC")]
      public string SieBic { get;set; }   // Siege_Exploitation.Sie_BIC

      [Column("Emp_ID")]
      public decimal EmpId { get;set; }  // Siege_Exploitation.Emp_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("EmpId")]
      public virtual Employeur Employeur { get; set; }

   }

   [Table("Dossier_Intervention")]
   public partial class DossierIntervention
   {

      [Key]
      [Column("Din_Id")]
      public decimal DinId { get;set; }  // Dossier_Intervention.Din_Id (PrimaryKey)

      [Required]
      [Column("Din_TypeIntervention")]
      public string DinTypeintervention { get;set; }   // Dossier_Intervention.Din_TypeIntervention

      [Required]
      [Column("Din_Syndicat")]
      public string DinSyndicat { get;set; }   // Dossier_Intervention.Din_Syndicat

      [Required]
      [Column("Din_ExistencePFA")]
      public string DinExistencepfa { get;set; }   // Dossier_Intervention.Din_ExistencePFA

      [Required]
      [Column("Din_EtatDossier")]
      public string DinEtatdossier { get;set; }   // Dossier_Intervention.Din_EtatDossier

      [Required]
      [Column("Din_MontantJournalier")]
      public decimal DinMontantjournalier { get;set; }   // Dossier_Intervention.Din_MontantJournalier

      [Required]
      [Column("Din_CreditJours")]
      public decimal DinCreditjours { get;set; }   // Dossier_Intervention.Din_CreditJours

      [Required]
      [Column("Din_HeuresSemaine")]
      public decimal DinHeuressemaine { get;set; }   // Dossier_Intervention.Din_HeuresSemaine

      [Required]
      [Column("Din_TauxHoraire")]
      public decimal DinTauxhoraire { get;set; }   // Dossier_Intervention.Din_TauxHoraire

      [Required]
      [Column("Din_SalaireBrut")]
      public decimal DinSalairebrut { get;set; }   // Dossier_Intervention.Din_SalaireBrut

      [Required]
      [Column("Din_RetenueONSS")]
      public decimal DinRetenueonss { get;set; }   // Dossier_Intervention.Din_RetenueONSS

      [Required]
      [Column("Din_BaseImposable")]
      public decimal DinBaseimposable { get;set; }   // Dossier_Intervention.Din_BaseImposable

      [Required]
      [Column("Din_RetenueFiscale")]
      public decimal DinRetenuefiscale { get;set; }   // Dossier_Intervention.Din_RetenueFiscale

      [Required]
      [Column("Din_SalaireNet")]
      public decimal DinSalairenet { get;set; }   // Dossier_Intervention.Din_SalaireNet

      [Required]
      [Column("Din_Anciennete")]
      public string DinAnciennete { get;set; }   // Dossier_Intervention.Din_Anciennete

      [Required]
      [Column("Din_DateAffiliation")]
      public DateTime DinDateaffiliation { get;set; }   // Dossier_Intervention.Din_DateAffiliation

      [Required]
      [Column("Din_DatePerteRevenus")]
      public DateTime DinDateperterevenus { get;set; }   // Dossier_Intervention.Din_DatePerteRevenus

      [Required]
      [Column("Din_AllocJournChomage")]
      public decimal DinAllocjournchomage { get;set; }   // Dossier_Intervention.Din_AllocJournChomage

      [Required]
      [Column("Din_NbreAllocChomage")]
      public decimal DinNbreallocchomage { get;set; }   // Dossier_Intervention.Din_NbreAllocChomage

      [Required]
      [Column("Din_TotalAllocChomage")]
      public decimal DinTotalallocchomage { get;set; }   // Dossier_Intervention.Din_TotalAllocChomage

      [Required]
      [Column("Din_SalaireReference")]
      public decimal DinSalairereference { get;set; }   // Dossier_Intervention.Din_SalaireReference

      [Required]
      [Column("Din_Commentaire")]
      public string DinCommentaire { get;set; }   // Dossier_Intervention.Din_Commentaire

      [Required]
      [Column("Din_Frontalier")]
      public string DinFrontalier { get;set; }   // Dossier_Intervention.Din_Frontalier

      [Required]
      [Column("Din_DateDossier")]
      public DateTime DinDatedossier { get;set; }   // Dossier_Intervention.Din_DateDossier

      [Required]
      [Column("Din_Exercice")]
      public string DinExercice { get;set; }   // Dossier_Intervention.Din_Exercice

      [Required]
      [Column("Din_TrimestreDebutChomage")]
      public string DinTrimestredebutchomage { get;set; }   // Dossier_Intervention.Din_TrimestreDebutChomage

      [Required]
      [Column("Din_CreditHeure")]
      public decimal DinCreditheure { get;set; }   // Dossier_Intervention.Din_CreditHeure

      [Required]
      [Column("Din_MontantHoraire")]
      public decimal DinMontanthoraire { get;set; }   // Dossier_Intervention.Din_MontantHoraire

      [Column("Con_ID")]
      public decimal ConId { get;set; }  // Dossier_Intervention.Con_ID (ForeignKey)

      [Column("Tra_ID")]
      public decimal TraId { get;set; }  // Dossier_Intervention.Tra_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("ConId")]
      public virtual Contrat Contrat_ConId { get; set; }

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur_TraId { get; set; }

   }

   [Table("Ligne_Travailleur")]
   public partial class LigneTravailleur
   {

      [Key]
      [Column("Ltr_Id")]
      public decimal LtrId { get;set; }  // Ligne_Travailleur.Ltr_Id (PrimaryKey)

      [Required]
      [Column("Ltr_NoAttestation")]
      public string LtrNoattestation { get;set; }   // Ligne_Travailleur.Ltr_NoAttestation

      [Required]
      [Column("Ltr_NoSituation")]
      public string LtrNosituation { get;set; }   // Ligne_Travailleur.Ltr_NoSituation

      [Required]
      [Column("Ltr_Active")]
      public string LtrActive { get;set; }   // Ligne_Travailleur.Ltr_Active

      [Required]
      [Column("Ltr_Origine")]
      public string LtrOrigine { get;set; }   // Ligne_Travailleur.Ltr_Origine

      [Required]
      [Column("Ltr_NISS")]
      public string LtrNiss { get;set; }   // Ligne_Travailleur.Ltr_NISS

      [Required]
      [Column("Ltr_ONSS")]
      public string LtrOnss { get;set; }   // Ligne_Travailleur.Ltr_ONSS

      [Required]
      [Column("Ltr_CategorieEmployeur")]
      public string LtrCategorieemployeur { get;set; }   // Ligne_Travailleur.Ltr_CategorieEmployeur

      [Required]
      [Column("Ltr_CodeTravailleur")]
      public string LtrCodetravailleur { get;set; }   // Ligne_Travailleur.Ltr_CodeTravailleur

      [Required]
      [Column("Ltr_Trimestre")]
      public string LtrTrimestre { get;set; }   // Ligne_Travailleur.Ltr_Trimestre

      [Required]
      [Column("Ltr_DateDebutTrimestre")]
      public DateTime LtrDatedebuttrimestre { get;set; }   // Ligne_Travailleur.Ltr_DateDebutTrimestre

      [Required]
      [Column("Ltr_DateFinTrimestre")]
      public DateTime LtrDatefintrimestre { get;set; }   // Ligne_Travailleur.Ltr_DateFinTrimestre

      [Required]
      [Column("Ltr_Frontalier")]
      public string LtrFrontalier { get;set; }   // Ligne_Travailleur.Ltr_Frontalier

      [Required]
      [Column("Ltr_ActiviteRisque")]
      public string LtrActiviterisque { get;set; }   // Ligne_Travailleur.Ltr_ActiviteRisque

      [Required]
      [Column("Ltr_UniteLocale")]
      public string LtrUnitelocale { get;set; }   // Ligne_Travailleur.Ltr_UniteLocale

      [Required]
      [Column("Ltr_DateInjection")]
      public DateTime LtrDateinjection { get;set; }   // Ligne_Travailleur.Ltr_DateInjection

      [Required]
      [Column("Ltr_DateCreation")]
      public DateTime LtrDatecreation { get;set; }   // Ligne_Travailleur.Ltr_DateCreation

      [Required]
      [Column("Ltr_TextLibre")]
      public string LtrTextlibre { get;set; }   // Ligne_Travailleur.Ltr_TextLibre

      [Required]
      [Column("Ltr_AttStatut")]
      public string LtrAttstatut { get;set; }   // Ligne_Travailleur.Ltr_AttStatut

      [Column("Env_Id")]
      public decimal EnvId { get;set; }  // Ligne_Travailleur.Env_Id (ForeignKey)

      [Column("Con_Id")]
      public decimal ConId { get;set; }  // Ligne_Travailleur.Con_Id (ForeignKey)

      [Column("Pct_Id")]
      public decimal PctId { get;set; }  // Ligne_Travailleur.Pct_Id (ForeignKey)

      [Column("Dct_Id")]
      public decimal DctId { get;set; }  // Ligne_Travailleur.Dct_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("EnvId")]
      public virtual Envoi Envoi_EnvId { get; set; }

      [ForeignKey("ConId")]
      public virtual Contrat Contrat_ConId { get; set; }

      [ForeignKey("PctId")]
      public virtual PrimeContrat PrimeContrat_PctId { get; set; }

      [ForeignKey("DctId")]
      public virtual PensionContrat PensionContrat_DctId { get; set; }

   }

   [Table("Titre_Compteur")]
   public partial class TitreCompteur
   {

      [Key]
      [Column("Tct_Id")]
      public decimal TctId { get;set; }  // Titre_Compteur.Tct_Id (PrimaryKey)

      [Required]
      [Column("Tct_Exercice")]
      public string TctExercice { get;set; }   // Titre_Compteur.Tct_Exercice

      [Required]
      [Column("Tct_Numero")]
      public decimal TctNumero { get;set; }   // Titre_Compteur.Tct_Numero

   }

   [Table("Validation_Envoi")]
   public partial class ValidationEnvoi
   {

      [Key]
      [Column("Val_Id")]
      public decimal ValId { get;set; }  // Validation_Envoi.Val_Id (PrimaryKey)

      [Required]
      [Column("Val_JoursPrestes")]
      public decimal ValJoursprestes { get;set; }   // Validation_Envoi.Val_JoursPrestes

      [Required]
      [Column("Val_Salaires")]
      public decimal ValSalaires { get;set; }   // Validation_Envoi.Val_Salaires

      [Column("Aem_ID")]
      public decimal AemId { get;set; }  // Validation_Envoi.Aem_ID (ForeignKey)

      [Column("Env_Id")]
      public decimal EnvId { get;set; }  // Validation_Envoi.Env_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("AemId")]
      public virtual ActiviteEmployeur ActiviteEmployeur_AemId { get; set; }

      [ForeignKey("EnvId")]
      public virtual Envoi Envoi_EnvId { get; set; }

   }

   [Table("dtproperties")]
   public partial class Dtproperties
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
   public partial class SolidariteCompteur
   {

      [Key]
      [Column("Sco_Id")]
      public decimal ScoId { get;set; }  // Solidarite_Compteur.Sco_Id (PrimaryKey)

      [Required]
      [Column("Sco_Exercice")]
      public string ScoExercice { get;set; }   // Solidarite_Compteur.Sco_Exercice

      [Required]
      [Column("Sco_Prefixe")]
      public string ScoPrefixe { get;set; }   // Solidarite_Compteur.Sco_Prefixe

      [Required]
      [Column("Sco_Numero")]
      public decimal ScoNumero { get;set; }   // Solidarite_Compteur.Sco_Numero

   }

   [Table("Solidarite_Inactivite")]
   public partial class SolidariteInactivite
   {

      [Key]
      [Column("Sin_Id")]
      public decimal SinId { get;set; }  // Solidarite_Inactivite.Sin_Id (PrimaryKey)

      [Required]
      [Column("Sin_Type")]
      public string SinType { get;set; }   // Solidarite_Inactivite.Sin_Type

      [Required]
      [Column("Sin_DateDebut")]
      public DateTime SinDatedebut { get;set; }   // Solidarite_Inactivite.Sin_DateDebut

      [Required]
      [Column("Sin_DateFin")]
      public DateTime SinDatefin { get;set; }   // Solidarite_Inactivite.Sin_DateFin

      [Required]
      [Column("Sin_Active")]
      public string SinActive { get;set; }   // Solidarite_Inactivite.Sin_Active

      [Required]
      [Column("Sin_NoDossier")]
      public string SinNodossier { get;set; }   // Solidarite_Inactivite.Sin_NoDossier

      [Required]
      [Column("Sin_JoursInactivite")]
      public decimal SinJoursinactivite { get;set; }   // Solidarite_Inactivite.Sin_JoursInactivite

      [Required]
      [Column("Sin_SalaireFictifJournalier")]
      public decimal SinSalairefictifjournalier { get;set; }   // Solidarite_Inactivite.Sin_SalaireFictifJournalier

      [Required]
      [Column("Sin_SFJManuel")]
      public decimal SinSfjmanuel { get;set; }   // Solidarite_Inactivite.Sin_SFJManuel

      [Required]
      [Column("Sin_SalaireFictif")]
      public decimal SinSalairefictif { get;set; }   // Solidarite_Inactivite.Sin_SalaireFictif

      [Required]
      [Column("Sin_PrimeInactivite")]
      public decimal SinPrimeinactivite { get;set; }   // Solidarite_Inactivite.Sin_PrimeInactivite

      [Required]
      [Column("Sin_TexteLibre")]
      public string SinTextelibre { get;set; }   // Solidarite_Inactivite.Sin_TexteLibre

      [Column("Dct_Id")]
      public decimal DctId { get;set; }  // Solidarite_Inactivite.Dct_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DctId")]
      public virtual PensionContrat PensionContrat { get; set; }

   }

   [Table("Drs_A037_DossierAnnuel")]
   public partial class DrsA037Dossierannuel
   {

      [Key]
      [Column("Y37_Id")]
      public decimal Y37Id { get;set; }  // Drs_A037_DossierAnnuel.Y37_Id (PrimaryKey)

      [Required]
      [Column("Y37_Exercice")]
      public string Y37Exercice { get;set; }   // Drs_A037_DossierAnnuel.Y37_Exercice

      [Column("Tra_Id")]
      public decimal TraId { get;set; }  // Drs_A037_DossierAnnuel.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur { get; set; }

   }

   [Table("Envoi")]
   public partial class Envoi
   {

      [Key]
      [Column("Env_Id")]
      public decimal EnvId { get;set; }  // Envoi.Env_Id (PrimaryKey)

      [Required]
      [Column("Env_trimestre")]
      public string EnvTrimestre { get;set; }   // Envoi.Env_trimestre

      [Required]
      [Column("Env_numeroEnvoi")]
      public string EnvNumeroenvoi { get;set; }   // Envoi.Env_numeroEnvoi

      [Required]
      [Column("Env_numeroSuiteEnvoi")]
      public string EnvNumerosuiteenvoi { get;set; }   // Envoi.Env_numeroSuiteEnvoi

      [Required]
      [Column("Env_NomFichier")]
      public string EnvNomfichier { get;set; }   // Envoi.Env_NomFichier

      [Required]
      [Column("Env_dateCreation")]
      public DateTime EnvDatecreation { get;set; }   // Envoi.Env_dateCreation

      [Required]
      [Column("Env_etat")]
      public string EnvEtat { get;set; }   // Envoi.Env_etat

      [Required]
      [Column("Env_NbrRecord")]
      public decimal EnvNbrrecord { get;set; }   // Envoi.Env_NbrRecord

      [Required]
      [Column("Env_NbrRecordInjecte")]
      public decimal EnvNbrrecordinjecte { get;set; }   // Envoi.Env_NbrRecordInjecte

   }

   [Table("Beneficiaire")]
   public partial class Beneficiaire
   {

      [Key]
      [Column("Bnf_ID")]
      public decimal BnfId { get;set; }  // Beneficiaire.Bnf_ID (PrimaryKey)

      [Required]
      [Column("Bnf_TypeApplication")]
      public string BnfTypeapplication { get;set; }   // Beneficiaire.Bnf_TypeApplication

      [Required]
      [Column("Bnf_Type")]
      public string BnfType { get;set; }   // Beneficiaire.Bnf_Type

      [Required]
      [Column("Bnf_QuotePart")]
      public decimal BnfQuotepart { get;set; }   // Beneficiaire.Bnf_QuotePart

      [Required]
      [Column("Bnf_Niss")]
      public string BnfNiss { get;set; }   // Beneficiaire.Bnf_Niss

      [Required]
      [Column("Bnf_Nom")]
      public string BnfNom { get;set; }   // Beneficiaire.Bnf_Nom

      [Required]
      [Column("Bnf_Prenom")]
      public string BnfPrenom { get;set; }   // Beneficiaire.Bnf_Prenom

      [Required]
      [Column("Bnf_DateNaissance")]
      public DateTime BnfDatenaissance { get;set; }   // Beneficiaire.Bnf_DateNaissance

      [Required]
      [Column("Bnf_Langue")]
      public string BnfLangue { get;set; }   // Beneficiaire.Bnf_Langue

      [Required]
      [Column("Bnf_Sexe")]
      public string BnfSexe { get;set; }   // Beneficiaire.Bnf_Sexe

      [Required]
      [Column("Bnf_AdresseRue")]
      public string BnfAdresserue { get;set; }   // Beneficiaire.Bnf_AdresseRue

      [Required]
      [Column("Bnf_AdresseNo")]
      public string BnfAdresseno { get;set; }   // Beneficiaire.Bnf_AdresseNo

      [Required]
      [Column("Bnf_AdresseBte")]
      public string BnfAdressebte { get;set; }   // Beneficiaire.Bnf_AdresseBte

      [Required]
      [Column("Bnf_CodePostal")]
      public string BnfCodepostal { get;set; }   // Beneficiaire.Bnf_CodePostal

      [Required]
      [Column("Bnf_Localite")]
      public string BnfLocalite { get;set; }   // Beneficiaire.Bnf_Localite

      [Required]
      [Column("Bnf_CodePays")]
      public string BnfCodepays { get;set; }   // Beneficiaire.Bnf_CodePays

      [Required]
      [Column("Bnf_CompteBancaire")]
      public string BnfComptebancaire { get;set; }   // Beneficiaire.Bnf_CompteBancaire

      [Required]
      [Column("Bnf_IBAN")]
      public string BnfIban { get;set; }   // Beneficiaire.Bnf_IBAN

      [Required]
      [Column("Bnf_BIC")]
      public string BnfBic { get;set; }   // Beneficiaire.Bnf_BIC

      [Required]
      [Column("Bnf_Communication")]
      public string BnfCommunication { get;set; }   // Beneficiaire.Bnf_Communication

      [Column("Tra_ID")]
      public decimal TraId { get;set; }  // Beneficiaire.Tra_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur { get; set; }

   }

   [Table("Drs_A037")]
   public partial class DrsA037
   {

      [Key]
      [Column("A37_Id")]
      public decimal A37Id { get;set; }  // Drs_A037.A37_Id (PrimaryKey)

      [Required]
      [Column("A37_Active")]
      public string A37Active { get;set; }   // Drs_A037.A37_Active

      [Required]
      [Column("A37_Niss")]
      public string A37Niss { get;set; }   // Drs_A037.A37_Niss

      [Required]
      [Column("A37_NoAttestation")]
      public string A37Noattestation { get;set; }   // Drs_A037.A37_NoAttestation

      [Required]
      [Column("A37_NoSituation")]
      public string A37Nosituation { get;set; }   // Drs_A037.A37_NoSituation

      [Required]
      [Column("A37_EtatAttestation")]
      public string A37Etatattestation { get;set; }   // Drs_A037.A37_EtatAttestation

      [Required]
      [Column("A37_MoisInactivite")]
      public string A37Moisinactivite { get;set; }   // Drs_A037.A37_MoisInactivite

      [Required]
      [Column("A37_DateCreation")]
      public DateTime A37Datecreation { get;set; }   // Drs_A037.A37_DateCreation

      [Required]
      [Column("A37_Onss")]
      public string A37Onss { get;set; }   // Drs_A037.A37_Onss

      [Required]
      [Column("A37_Bce")]
      public string A37Bce { get;set; }   // Drs_A037.A37_Bce

      [Required]
      [Column("A37_CategorieEmployeur")]
      public string A37Categorieemployeur { get;set; }   // Drs_A037.A37_CategorieEmployeur

      [Required]
      [Column("A37_CodeTravailleur")]
      public string A37Codetravailleur { get;set; }   // Drs_A037.A37_CodeTravailleur

      [Required]
      [Column("A37_NoInterneOccupation")]
      public string A37Nointerneoccupation { get;set; }   // Drs_A037.A37_NoInterneOccupation

      [Required]
      [Column("A37_DateDebutOccupation")]
      public DateTime A37Datedebutoccupation { get;set; }   // Drs_A037.A37_DateDebutOccupation

      [Required]
      [Column("A37_CommissionParitaire")]
      public string A37Commissionparitaire { get;set; }   // Drs_A037.A37_CommissionParitaire

      [Required]
      [Column("A37_HeuresSemTrav")]
      public decimal A37Heuressemtrav { get;set; }   // Drs_A037.A37_HeuresSemTrav

      [Required]
      [Column("A37_HeuresSemTravRef")]
      public decimal A37Heuressemtravref { get;set; }   // Drs_A037.A37_HeuresSemTravRef

      [Required]
      [Column("A37_StatutTravailleur")]
      public string A37Statuttravailleur { get;set; }   // Drs_A037.A37_StatutTravailleur

      [Required]
      [Column("A37_DateDebutPeriode")]
      public DateTime A37Datedebutperiode { get;set; }   // Drs_A037.A37_DateDebutPeriode

      [Required]
      [Column("A37_DateFinPeriode")]
      public DateTime A37Datefinperiode { get;set; }   // Drs_A037.A37_DateFinPeriode

      [Column("Tra_Id")]
      public decimal TraId { get;set; }  // Drs_A037.Tra_Id (ForeignKey)

      [Column("Drs_Id")]
      public decimal DrsId { get;set; }  // Drs_A037.Drs_Id (ForeignKey)

      [Column("Y37_Id")]
      public decimal Y37Id { get;set; }  // Drs_A037.Y37_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur_TraId { get; set; }

      [ForeignKey("DrsId")]
      public virtual DrsEnvoi DrsEnvoi_DrsId { get; set; }

      [ForeignKey("Y37Id")]
      public virtual DrsA037Dossierannuel DrsA037Dossierannuel_Y37Id { get; set; }

   }

   [Table("Payement")]
   public partial class Payement
   {

      [Key]
      [Column("Pay_ID")]
      public decimal PayId { get;set; }  // Payement.Pay_ID (PrimaryKey)

      [Required]
      [Column("Pay_NoPayement")]
      public string PayNopayement { get;set; }   // Payement.Pay_NoPayement

      [Required]
      [Column("Pay_Type")]
      public string PayType { get;set; }   // Payement.Pay_Type

      [Required]
      [Column("Pay_Mode")]
      public string PayMode { get;set; }   // Payement.Pay_Mode

      [Required]
      [Column("Pay_Actif")]
      public string PayActif { get;set; }   // Payement.Pay_Actif

      [Required]
      [Column("Pay_NoCheque")]
      public string PayNocheque { get;set; }   // Payement.Pay_NoCheque

      [Required]
      [Column("Pay_Montant")]
      public decimal PayMontant { get;set; }   // Payement.Pay_Montant

      [Required]
      [Column("Pay_DateDebutValidite")]
      public DateTime PayDatedebutvalidite { get;set; }   // Payement.Pay_DateDebutValidite

      [Required]
      [Column("Pay_DateFinValidite")]
      public DateTime PayDatefinvalidite { get;set; }   // Payement.Pay_DateFinValidite

      [Required]
      [Column("Pay_Etat")]
      public string PayEtat { get;set; }   // Payement.Pay_Etat

      [Required]
      [Column("Pay_DateEmission")]
      public DateTime PayDateemission { get;set; }   // Payement.Pay_DateEmission

      [Required]
      [Column("Pay_DateEncaissement")]
      public DateTime PayDateencaissement { get;set; }   // Payement.Pay_DateEncaissement

      [Required]
      [Column("Pay_DateRetour")]
      public DateTime PayDateretour { get;set; }   // Payement.Pay_DateRetour

      [Required]
      [Column("Pay_MotivationRetour")]
      public string PayMotivationretour { get;set; }   // Payement.Pay_MotivationRetour

      [Required]
      [Column("Pay_Nom")]
      public string PayNom { get;set; }   // Payement.Pay_Nom

      [Required]
      [Column("Pay_Prenom")]
      public string PayPrenom { get;set; }   // Payement.Pay_Prenom

      [Required]
      [Column("Pay_AdresseRue")]
      public string PayAdresserue { get;set; }   // Payement.Pay_AdresseRue

      [Required]
      [Column("Pay_AdresseNo")]
      public string PayAdresseno { get;set; }   // Payement.Pay_AdresseNo

      [Required]
      [Column("Pay_AdresseBte")]
      public string PayAdressebte { get;set; }   // Payement.Pay_AdresseBte

      [Required]
      [Column("Pay_CodePostal")]
      public string PayCodepostal { get;set; }   // Payement.Pay_CodePostal

      [Required]
      [Column("Pay_Localite")]
      public string PayLocalite { get;set; }   // Payement.Pay_Localite

      [Required]
      [Column("Pay_CodePays")]
      public string PayCodepays { get;set; }   // Payement.Pay_CodePays

      [Required]
      [Column("Pay_Langue")]
      public string PayLangue { get;set; }   // Payement.Pay_Langue

      [Required]
      [Column("Pay_CompteBancaire")]
      public string PayComptebancaire { get;set; }   // Payement.Pay_CompteBancaire

      [Required]
      [Column("Pay_ReferenceBancaire")]
      public string PayReferencebancaire { get;set; }   // Payement.Pay_ReferenceBancaire

      [Required]
      [Column("Pay_Communication")]
      public string PayCommunication { get;set; }   // Payement.Pay_Communication

      [Required]
      [Column("Pay_DonneurOrdre")]
      public string PayDonneurordre { get;set; }   // Payement.Pay_DonneurOrdre

      [Required]
      [Column("Pay_IBANDebiteur")]
      public string PayIbandebiteur { get;set; }   // Payement.Pay_IBANDebiteur

      [Required]
      [Column("Pay_BICDebiteur")]
      public string PayBicdebiteur { get;set; }   // Payement.Pay_BICDebiteur

      [Required]
      [Column("Pay_IBANCrediteur")]
      public string PayIbancrediteur { get;set; }   // Payement.Pay_IBANCrediteur

      [Required]
      [Column("Pay_BICCrediteur")]
      public string PayBiccrediteur { get;set; }   // Payement.Pay_BICCrediteur

      [Column("Tit_Id")]
      public decimal TitId { get;set; }  // Payement.Tit_Id (ForeignKey)

      [Column("Rcr_Id")]
      public decimal RcrId { get;set; }  // Payement.Rcr_Id (ForeignKey)

      [Column("Bnf_ID")]
      public decimal BnfId { get;set; }  // Payement.Bnf_ID (ForeignKey)

      [Column("Ppp_Id")]
      public decimal PppId { get;set; }  // Payement.Ppp_Id (ForeignKey)

      [Column("Int_Id")]
      public decimal IntId { get;set; }  // Payement.Int_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TitId")]
      public virtual Titre Titre_TitId { get; set; }

      [ForeignKey("RcrId")]
      public virtual RetenueCreance RetenueCreance_RcrId { get; set; }

      [ForeignKey("BnfId")]
      public virtual Beneficiaire Beneficiaire_BnfId { get; set; }

      [ForeignKey("PppId")]
      public virtual PrimePrepension PrimePrepension_PppId { get; set; }

      [ForeignKey("IntId")]
      public virtual Intervention Intervention_IntId { get; set; }

   }

   [Table("Demande_Intervention")]
   public partial class DemandeIntervention
   {

      [Key]
      [Column("Dei_Id")]
      public decimal DeiId { get;set; }  // Demande_Intervention.Dei_Id (PrimaryKey)

      [Required]
      [Column("Dei_NunmeroFolio")]
      public string DeiNunmerofolio { get;set; }   // Demande_Intervention.Dei_NunmeroFolio

      [Required]
      [Column("Dei_TypeDemande")]
      public string DeiTypedemande { get;set; }   // Demande_Intervention.Dei_TypeDemande

      [Required]
      [Column("Dei_DebutPeriode")]
      public DateTime DeiDebutperiode { get;set; }   // Demande_Intervention.Dei_DebutPeriode

      [Required]
      [Column("Dei_FinPeriode")]
      public DateTime DeiFinperiode { get;set; }   // Demande_Intervention.Dei_FinPeriode

      [Required]
      [Column("Dei_HeuresSemaine")]
      public decimal DeiHeuressemaine { get;set; }   // Demande_Intervention.Dei_HeuresSemaine

      [Required]
      [Column("Dei_TauxHoraire")]
      public decimal DeiTauxhoraire { get;set; }   // Demande_Intervention.Dei_TauxHoraire

      [Required]
      [Column("Dei_SalaireBrut")]
      public decimal DeiSalairebrut { get;set; }   // Demande_Intervention.Dei_SalaireBrut

      [Required]
      [Column("Dei_RetenueONSS")]
      public decimal DeiRetenueonss { get;set; }   // Demande_Intervention.Dei_RetenueONSS

      [Required]
      [Column("Dei_BaseImposable")]
      public decimal DeiBaseimposable { get;set; }   // Demande_Intervention.Dei_BaseImposable

      [Required]
      [Column("Dei_RetenueFiscale")]
      public decimal DeiRetenuefiscale { get;set; }   // Demande_Intervention.Dei_RetenueFiscale

      [Required]
      [Column("Dei_SalaireNet")]
      public decimal DeiSalairenet { get;set; }   // Demande_Intervention.Dei_SalaireNet

      [Required]
      [Column("Dei_AllocJournChomage")]
      public decimal DeiAllocjournchomage { get;set; }   // Demande_Intervention.Dei_AllocJournChomage

      [Required]
      [Column("Dei_NbreAllocChomage")]
      public decimal DeiNbreallocchomage { get;set; }   // Demande_Intervention.Dei_NbreAllocChomage

      [Required]
      [Column("Dei_TotalAllocChomage")]
      public decimal DeiTotalallocchomage { get;set; }   // Demande_Intervention.Dei_TotalAllocChomage

      [Required]
      [Column("Dei_SalaireReference")]
      public decimal DeiSalairereference { get;set; }   // Demande_Intervention.Dei_SalaireReference

      [Required]
      [Column("Dei_Difference")]
      public decimal DeiDifference { get;set; }   // Demande_Intervention.Dei_Difference

      [Required]
      [Column("Dei_Commentaire")]
      public string DeiCommentaire { get;set; }   // Demande_Intervention.Dei_Commentaire

      [Column("Din_Id")]
      public decimal DinId { get;set; }  // Demande_Intervention.Din_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DinId")]
      public virtual DossierIntervention DossierIntervention { get; set; }

   }

   [Table("Cotisation_Etudiant")]
   public partial class CotisationEtudiant
   {

      [Key]
      [Column("Cet_Id")]
      public decimal CetId { get;set; }  // Cotisation_Etudiant.Cet_Id (PrimaryKey)

      [Required]
      [Column("Cet_Remuneration")]
      public decimal CetRemuneration { get;set; }   // Cotisation_Etudiant.Cet_Remuneration

      [Required]
      [Column("Cet_Cotisation")]
      public decimal CetCotisation { get;set; }   // Cotisation_Etudiant.Cet_Cotisation

      [Required]
      [Column("Cet_Jours")]
      public decimal CetJours { get;set; }   // Cotisation_Etudiant.Cet_Jours

      [Required]
      [Column("Cet_NoUniteLocale")]
      public string CetNounitelocale { get;set; }   // Cotisation_Etudiant.Cet_NoUniteLocale

      [Required]
      [Column("Cet_TexteLibre")]
      public string CetTextelibre { get;set; }   // Cotisation_Etudiant.Cet_TexteLibre

      [Column("Ltr_Id")]
      public decimal LtrId { get;set; }  // Cotisation_Etudiant.Ltr_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("LtrId")]
      public virtual LigneTravailleur LigneTravailleur { get; set; }

   }

   [Table("Prime_Prepension")]
   public partial class PrimePrepension
   {

      [Key]
      [Column("Ppp_Id")]
      public decimal PppId { get;set; }  // Prime_Prepension.Ppp_Id (PrimaryKey)

      [Required]
      [Column("Ppp_Mois")]
      public string PppMois { get;set; }   // Prime_Prepension.Ppp_Mois

      [Required]
      [Column("Ppp_Etat")]
      public string PppEtat { get;set; }   // Prime_Prepension.Ppp_Etat

      [Required]
      [Column("Ppp_MontantChomage")]
      public decimal PppMontantchomage { get;set; }   // Prime_Prepension.Ppp_MontantChomage

      [Required]
      [Column("Ppp_IndemniteExtraLegale")]
      public decimal PppIndemniteextralegale { get;set; }   // Prime_Prepension.Ppp_IndemniteExtraLegale

      [Required]
      [Column("Ppp_IndemniteBrute")]
      public decimal PppIndemnitebrute { get;set; }   // Prime_Prepension.Ppp_IndemniteBrute

      [Required]
      [Column("Ppp_RetenueONP")]
      public decimal PppRetenueonp { get;set; }   // Prime_Prepension.Ppp_RetenueONP

      [Required]
      [Column("Ppp_RetenueONEM")]
      public decimal PppRetenueonem { get;set; }   // Prime_Prepension.Ppp_RetenueONEM

      [Required]
      [Column("Ppp_RetenueFiscale")]
      public decimal PppRetenuefiscale { get;set; }   // Prime_Prepension.Ppp_RetenueFiscale

      [Required]
      [Column("Ppp_RevenuNet")]
      public decimal PppRevenunet { get;set; }   // Prime_Prepension.Ppp_RevenuNet

      [Required]
      [Column("Ppp_IndemnitePayable")]
      public decimal PppIndemnitepayable { get;set; }   // Prime_Prepension.Ppp_IndemnitePayable

      [Required]
      [Column("Ppp_CapitativeONP")]
      public decimal PppCapitativeonp { get;set; }   // Prime_Prepension.Ppp_CapitativeONP

      [Required]
      [Column("Ppp_CapitativeONSS")]
      public decimal PppCapitativeonss { get;set; }   // Prime_Prepension.Ppp_CapitativeONSS

      [Required]
      [Column("Ppp_CotisationCompensatoire")]
      public decimal PppCotisationcompensatoire { get;set; }   // Prime_Prepension.Ppp_CotisationCompensatoire

      [Required]
      [Column("Ppp_DateExecution")]
      public DateTime PppDateexecution { get;set; }   // Prime_Prepension.Ppp_DateExecution

      [Required]
      [Column("Ppp_ModeCalcul")]
      public string PppModecalcul { get;set; }   // Prime_Prepension.Ppp_ModeCalcul

      [Required]
      [Column("Ppp_CotisationPersonnelle")]
      public decimal PppCotisationpersonnelle { get;set; }   // Prime_Prepension.Ppp_CotisationPersonnelle

      [Required]
      [Column("Ppp_CotisationPatronale")]
      public decimal PppCotisationpatronale { get;set; }   // Prime_Prepension.Ppp_CotisationPatronale

      [Required]
      [Column("Ppp_DebiteurPrincipal")]
      public string PppDebiteurprincipal { get;set; }   // Prime_Prepension.Ppp_DebiteurPrincipal

      [Required]
      [Column("Ppp_JoursPrestes")]
      public decimal PppJoursprestes { get;set; }   // Prime_Prepension.Ppp_JoursPrestes

      [Required]
      [Column("Ppp_AgeReference")]
      public decimal PppAgereference { get;set; }   // Prime_Prepension.Ppp_AgeReference

      [Required]
      [Column("Ppp_Plancher")]
      public string PppPlancher { get;set; }   // Prime_Prepension.Ppp_Plancher

      [Required]
      [Column("Ppp_Reprise")]
      public string PppReprise { get;set; }   // Prime_Prepension.Ppp_Reprise

      [Required]
      [Column("Ppp_TauxReduitCompensatoire")]
      public string PppTauxreduitcompensatoire { get;set; }   // Prime_Prepension.Ppp_TauxReduitCompensatoire

      [Required]
      [Column("Ppp_EtatEmployeur")]
      public string PppEtatemployeur { get;set; }   // Prime_Prepension.Ppp_EtatEmployeur

      [Required]
      [Column("Ppp_CodePersonnel")]
      public string PppCodepersonnel { get;set; }   // Prime_Prepension.Ppp_CodePersonnel

      [Required]
      [Column("Ppp_CodePatronal")]
      public string PppCodepatronal { get;set; }   // Prime_Prepension.Ppp_CodePatronal

      [Required]
      [Column("Ppp_CodeCompensatoire")]
      public string PppCodecompensatoire { get;set; }   // Prime_Prepension.Ppp_CodeCompensatoire

      [Required]
      [Column("Ppp_CodeAge")]
      public string PppCodeage { get;set; }   // Prime_Prepension.Ppp_CodeAge

      [Column("Dpp_Id")]
      public decimal DppId { get;set; }  // Prime_Prepension.Dpp_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DppId")]
      public virtual DossierPrepension DossierPrepension { get; set; }

   }

   [Table("Drs_A044_Dossier")]
   public partial class DrsA044Dossier
   {

      [Key]
      [Column("D44_Id")]
      public decimal D44Id { get;set; }  // Drs_A044_Dossier.D44_Id (PrimaryKey)

      [Required]
      [Column("D44_Niss")]
      public string D44Niss { get;set; }   // Drs_A044_Dossier.D44_Niss

      [Required]
      [Column("D44_NoDossier")]
      public string D44Nodossier { get;set; }   // Drs_A044_Dossier.D44_NoDossier

      [Required]
      [Column("D44_DateAccident")]
      public DateTime D44Dateaccident { get;set; }   // Drs_A044_Dossier.D44_DateAccident

      [Required]
      [Column("D44_DateCreation")]
      public DateTime D44Datecreation { get;set; }   // Drs_A044_Dossier.D44_DateCreation

      [Column("Tra_Id")]
      public decimal TraId { get;set; }  // Drs_A044_Dossier.Tra_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur { get; set; }

   }

   [Table("Drs_A044_Payement")]
   public partial class DrsA044Payement
   {

      [Key]
      [Column("P44_Id")]
      public decimal P44Id { get;set; }  // Drs_A044_Payement.P44_Id (PrimaryKey)

      [Required]
      [Column("P44_DateDebutPayement")]
      public DateTime P44Datedebutpayement { get;set; }   // Drs_A044_Payement.P44_DateDebutPayement

      [Required]
      [Column("P44_DateFinPayement")]
      public DateTime P44Datefinpayement { get;set; }   // Drs_A044_Payement.P44_DateFinPayement

      [Required]
      [Column("P44_Pourcentage")]
      public decimal P44Pourcentage { get;set; }   // Drs_A044_Payement.P44_Pourcentage

      [Required]
      [Column("P44_MontantBrut")]
      public decimal P44Montantbrut { get;set; }   // Drs_A044_Payement.P44_MontantBrut

      [Required]
      [Column("P44_RetenueOnss")]
      public decimal P44Retenueonss { get;set; }   // Drs_A044_Payement.P44_RetenueOnss

      [Column("A44_Id")]
      public decimal A44Id { get;set; }  // Drs_A044_Payement.A44_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("A44Id")]
      public virtual DrsA044Attestation DrsA044Attestation { get; set; }

   }

   [Table("Immunisation_Jours")]
   public partial class ImmunisationJours
   {

      [Key]
      [Column("Imj_Id")]
      public decimal ImjId { get;set; }  // Immunisation_Jours.Imj_Id (PrimaryKey)

      [Required]
      [Column("Imj_Mois")]
      public string ImjMois { get;set; }   // Immunisation_Jours.Imj_Mois

      [Required]
      [Column("Imj_JoursImmunises")]
      public decimal ImjJoursimmunises { get;set; }   // Immunisation_Jours.Imj_JoursImmunises

      [Required]
      [Column("Imj_Raison")]
      public string ImjRaison { get;set; }   // Immunisation_Jours.Imj_Raison

      [Column("Dpp_Id")]
      public decimal DppId { get;set; }  // Immunisation_Jours.Dpp_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("DppId")]
      public virtual DossierPrepension DossierPrepension { get; set; }

   }

   [Table("Drs_A044_Attestation")]
   public partial class DrsA044Attestation
   {

      [Key]
      [Column("A44_Id")]
      public decimal A44Id { get;set; }  // Drs_A044_Attestation.A44_Id (PrimaryKey)

      [Required]
      [Column("A44_Active")]
      public string A44Active { get;set; }   // Drs_A044_Attestation.A44_Active

      [Required]
      [Column("A44_NoAttestation")]
      public string A44Noattestation { get;set; }   // Drs_A044_Attestation.A44_NoAttestation

      [Required]
      [Column("A44_NoSituation")]
      public string A44Nosituation { get;set; }   // Drs_A044_Attestation.A44_NoSituation

      [Required]
      [Column("A44_EtatAttestation")]
      public string A44Etatattestation { get;set; }   // Drs_A044_Attestation.A44_EtatAttestation

      [Required]
      [Column("A44_DateCreation")]
      public DateTime A44Datecreation { get;set; }   // Drs_A044_Attestation.A44_DateCreation

      [Required]
      [Column("A44_NoAccident")]
      public string A44Noaccident { get;set; }   // Drs_A044_Attestation.A44_NoAccident

      [Required]
      [Column("A44_Bce")]
      public string A44Bce { get;set; }   // Drs_A044_Attestation.A44_Bce

      [Required]
      [Column("A44_Onss")]
      public string A44Onss { get;set; }   // Drs_A044_Attestation.A44_Onss

      [Required]
      [Column("A44_CategorieEmployeur")]
      public string A44Categorieemployeur { get;set; }   // Drs_A044_Attestation.A44_CategorieEmployeur

      [Required]
      [Column("A44_MoisInactivite")]
      public string A44Moisinactivite { get;set; }   // Drs_A044_Attestation.A44_MoisInactivite

      [Required]
      [Column("A44_DateDebutPeriode")]
      public DateTime A44Datedebutperiode { get;set; }   // Drs_A044_Attestation.A44_DateDebutPeriode

      [Required]
      [Column("A44_DateFinPeriode")]
      public DateTime A44Datefinperiode { get;set; }   // Drs_A044_Attestation.A44_DateFinPeriode

      [Column("D44_Id")]
      public decimal D44Id { get;set; }  // Drs_A044_Attestation.D44_Id (ForeignKey)

      [Column("Drs_Id")]
      public decimal DrsId { get;set; }  // Drs_A044_Attestation.Drs_Id (ForeignKey)

      // ForeignKeys

      [ForeignKey("D44Id")]
      public virtual DrsA044Dossier DrsA044Dossier_D44Id { get; set; }

      [ForeignKey("DrsId")]
      public virtual DrsEnvoi DrsEnvoi_DrsId { get; set; }

   }

   [Table("Creance")]
   public partial class Creance
   {

      [Key]
      [Column("Cre_ID")]
      public decimal CreId { get;set; }  // Creance.Cre_ID (PrimaryKey)

      [Required]
      [Column("Cre_Type")]
      public string CreType { get;set; }   // Creance.Cre_Type

      [Required]
      [Column("Cre_Montant")]
      public decimal CreMontant { get;set; }   // Creance.Cre_Montant

      [Required]
      [Column("Cre_Solde")]
      public decimal CreSolde { get;set; }   // Creance.Cre_Solde

      [Required]
      [Column("Cre_LimiteRetenue")]
      public decimal CreLimiteretenue { get;set; }   // Creance.Cre_LimiteRetenue

      [Required]
      [Column("Cre_DateNotification")]
      public DateTime CreDatenotification { get;set; }   // Creance.Cre_DateNotification

      [Required]
      [Column("Cre_RefNotification")]
      public string CreRefnotification { get;set; }   // Creance.Cre_RefNotification

      [Required]
      [Column("Cre_Etat")]
      public string CreEtat { get;set; }   // Creance.Cre_Etat

      [Required]
      [Column("Cre_DateDernierEtat")]
      public DateTime CreDatedernieretat { get;set; }   // Creance.Cre_DateDernierEtat

      [Required]
      [Column("Cre_EtatPrecedent")]
      public string CreEtatprecedent { get;set; }   // Creance.Cre_EtatPrecedent

      [Required]
      [Column("Cre_ModeCalcul")]
      public string CreModecalcul { get;set; }   // Creance.Cre_ModeCalcul

      [Required]
      [Column("Cre_MontantFixe")]
      public decimal CreMontantfixe { get;set; }   // Creance.Cre_MontantFixe

      [Required]
      [Column("Cre_Pourcentage")]
      public decimal CrePourcentage { get;set; }   // Creance.Cre_Pourcentage

      [Required]
      [Column("Cre_AuProrata")]
      public string CreAuprorata { get;set; }   // Creance.Cre_AuProrata

      [Required]
      [Column("Cre_Indexe")]
      public string CreIndexe { get;set; }   // Creance.Cre_Indexe

      [Required]
      [Column("Cre_Nom")]
      public string CreNom { get;set; }   // Creance.Cre_Nom

      [Required]
      [Column("Cre_Prenom")]
      public string CrePrenom { get;set; }   // Creance.Cre_Prenom

      [Required]
      [Column("Cre_AdresseRue")]
      public string CreAdresserue { get;set; }   // Creance.Cre_AdresseRue

      [Required]
      [Column("Cre_AdresseNo")]
      public string CreAdresseno { get;set; }   // Creance.Cre_AdresseNo

      [Required]
      [Column("Cre_AdresseBte")]
      public string CreAdressebte { get;set; }   // Creance.Cre_AdresseBte

      [Required]
      [Column("Cre_CodePostal")]
      public string CreCodepostal { get;set; }   // Creance.Cre_CodePostal

      [Required]
      [Column("Cre_Localite")]
      public string CreLocalite { get;set; }   // Creance.Cre_Localite

      [Required]
      [Column("Cre_CodePays")]
      public string CreCodepays { get;set; }   // Creance.Cre_CodePays

      [Required]
      [Column("Cre_CompteBancaire")]
      public string CreComptebancaire { get;set; }   // Creance.Cre_CompteBancaire

      [Required]
      [Column("Cre_IBAN")]
      public string CreIban { get;set; }   // Creance.Cre_IBAN

      [Required]
      [Column("Cre_BIC")]
      public string CreBic { get;set; }   // Creance.Cre_BIC

      [Required]
      [Column("Cre_Langue")]
      public string CreLangue { get;set; }   // Creance.Cre_Langue

      [Required]
      [Column("Cre_DateModification")]
      public DateTime CreDatemodification { get;set; }   // Creance.Cre_DateModification

      [Required]
      [Column("Cre_Rang")]
      public decimal CreRang { get;set; }   // Creance.Cre_Rang

      [Required]
      [Column("Cre_DatePayement")]
      public DateTime CreDatepayement { get;set; }   // Creance.Cre_DatePayement

      [Required]
      [Column("Cre_DateDepotGreffe")]
      public DateTime CreDatedepotgreffe { get;set; }   // Creance.Cre_DateDepotGreffe

      [Required]
      [Column("Cre_Numero")]
      public string CreNumero { get;set; }   // Creance.Cre_Numero

      [Column("Cri_ID")]
      public decimal CriId { get;set; }  // Creance.Cri_ID (ForeignKey)

      [Column("Tra_ID")]
      public decimal TraId { get;set; }  // Creance.Tra_ID (ForeignKey)

      // ForeignKeys

      [ForeignKey("CriId")]
      public virtual Creancier Creancier_CriId { get; set; }

      [ForeignKey("TraId")]
      public virtual Travailleur Travailleur_TraId { get; set; }

   }

   [Table("Creancier")]
   public partial class Creancier
   {

      [Key]
      [Column("Cri_ID")]
      public decimal CriId { get;set; }  // Creancier.Cri_ID (PrimaryKey)

      [Required]
      [Column("Cri_Numero")]
      public string CriNumero { get;set; }   // Creancier.Cri_Numero

      [Required]
      [Column("Cri_Nom")]
      public string CriNom { get;set; }   // Creancier.Cri_Nom

      [Required]
      [Column("Cri_AdresseRue")]
      public string CriAdresserue { get;set; }   // Creancier.Cri_AdresseRue

      [Required]
      [Column("Cri_AdresseNo")]
      public string CriAdresseno { get;set; }   // Creancier.Cri_AdresseNo

      [Required]
      [Column("Cri_AdresseBte")]
      public string CriAdressebte { get;set; }   // Creancier.Cri_AdresseBte

      [Required]
      [Column("Cri_CodePostal")]
      public string CriCodepostal { get;set; }   // Creancier.Cri_CodePostal

      [Required]
      [Column("Cri_Localite")]
      public string CriLocalite { get;set; }   // Creancier.Cri_Localite

      [Required]
      [Column("Cri_CodePays")]
      public string CriCodepays { get;set; }   // Creancier.Cri_CodePays

      [Required]
      [Column("Cri_Telephone")]
      public string CriTelephone { get;set; }   // Creancier.Cri_Telephone

      [Required]
      [Column("Cri_Fax")]
      public string CriFax { get;set; }   // Creancier.Cri_Fax

      [Required]
      [Column("Cri_CompteBancaire")]
      public string CriComptebancaire { get;set; }   // Creancier.Cri_CompteBancaire

      [Required]
      [Column("Cri_IBAN")]
      public string CriIban { get;set; }   // Creancier.Cri_IBAN

      [Required]
      [Column("Cri_BIC")]
      public string CriBic { get;set; }   // Creancier.Cri_BIC

      [Required]
      [Column("Cri_Langue")]
      public string CriLangue { get;set; }   // Creancier.Cri_Langue

   }

}
