using System;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Linq;
using Newtonsoft.Json.Linq;
using Breeze.WebApi2;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;

namespace MyNamespace
{
   [BreezeController]
   [EnableCors(origins: "*", headers: "*", methods: "*")]
   public partial class MyBreezeController : ApiController
   {
      readonly EFContextProvider<MyContext> _contextProvider;

      public MyBreezeController(EFContextProvider<MyContext> contextProvider)
      {
         _contextProvider = contextProvider;
      }

      [HttpGet]
      public string Metadata()
      {
         var metadata = _contextProvider.Metadata();
         return metadata;
      }

      [HttpGet]
      public IQueryable<Dossier_Prepension> Dossier_Prepensions()
      {
         return _contextProvider.Context.Dossier_Prepensions;
      }

      [HttpGet]
      public IQueryable<Fonds> Fonds()
      {
         return _contextProvider.Context.Fonds;
      }

      [HttpGet]
      public IQueryable<Att_A038> Att_A038s()
      {
         return _contextProvider.Context.Att_A038s;
      }

      [HttpGet]
      public IQueryable<Att_A038_IndividualAtt> Att_A038_IndividualAtts()
      {
         return _contextProvider.Context.Att_A038_IndividualAtts;
      }

      [HttpGet]
      public IQueryable<Ligne_Occupation> Ligne_Occupations()
      {
         return _contextProvider.Context.Ligne_Occupations;
      }

      [HttpGet]
      public IQueryable<Pension> Pensions()
      {
         return _contextProvider.Context.Pensions;
      }

      [HttpGet]
      public IQueryable<Pension_Contrat> Pension_Contrats()
      {
         return _contextProvider.Context.Pension_Contrats;
      }

      [HttpGet]
      public IQueryable<Att_A045_DecisionDetail> Att_A045_DecisionDetails()
      {
         return _contextProvider.Context.Att_A045_DecisionDetails;
      }

      [HttpGet]
      public IQueryable<Att_A052> Att_A052s()
      {
         return _contextProvider.Context.Att_A052s;
      }

      [HttpGet]
      public IQueryable<Att_A052_DecisionNicCin> Att_A052_DecisionNicCins()
      {
         return _contextProvider.Context.Att_A052_DecisionNicCins;
      }

      [HttpGet]
      public IQueryable<Sending_A038> Sending_A038s()
      {
         return _contextProvider.Context.Sending_A038s;
      }

      [HttpGet]
      public IQueryable<Prestation> Prestations()
      {
         return _contextProvider.Context.Prestations;
      }

      [HttpGet]
      public IQueryable<Anciennete_Contrat> Anciennete_Contrats()
      {
         return _contextProvider.Context.Anciennete_Contrats;
      }

      [HttpGet]
      public IQueryable<Declaration_CotisationPrepension> Declaration_CotisationPrepensions()
      {
         return _contextProvider.Context.Declaration_CotisationPrepensions;
      }

      [HttpGet]
      public IQueryable<Declaration_Onss> Declaration_Onsses()
      {
         return _contextProvider.Context.Declaration_Onsses;
      }

      [HttpGet]
      public IQueryable<Sending_A045> Sending_A045s()
      {
         return _contextProvider.Context.Sending_A045s;
      }

      [HttpGet]
      public IQueryable<Sending_A052> Sending_A052s()
      {
         return _contextProvider.Context.Sending_A052s;
      }

      [HttpGet]
      public IQueryable<Batch_Schedule_New> Batch_Schedule_News()
      {
         return _contextProvider.Context.Batch_Schedule_News;
      }

      [HttpGet]
      public IQueryable<Prime_Contrat> Prime_Contrats()
      {
         return _contextProvider.Context.Prime_Contrats;
      }

      [HttpGet]
      public IQueryable<Mutation_ONSS> Mutation_ONSSes()
      {
         return _contextProvider.Context.Mutation_ONSSes;
      }

      [HttpGet]
      public IQueryable<Remuneration> Remunerations()
      {
         return _contextProvider.Context.Remunerations;
      }

      [HttpGet]
      public IQueryable<Prime_Travailleur> Prime_Travailleurs()
      {
         return _contextProvider.Context.Prime_Travailleurs;
      }

      [HttpGet]
      public IQueryable<Declaration_Travailleur> Declaration_Travailleurs()
      {
         return _contextProvider.Context.Declaration_Travailleurs;
      }

      [HttpGet]
      public IQueryable<Titre> Titres()
      {
         return _contextProvider.Context.Titres;
      }

      [HttpGet]
      public IQueryable<Pension_Travailleur> Pension_Travailleurs()
      {
         return _contextProvider.Context.Pension_Travailleurs;
      }

      [HttpGet]
      public IQueryable<Demande_Intervention_Automatique> Demande_Intervention_Automatiques()
      {
         return _contextProvider.Context.Demande_Intervention_Automatiques;
      }

      [HttpGet]
      public IQueryable<Activite_Employeur> Activite_Employeurs()
      {
         return _contextProvider.Context.Activite_Employeurs;
      }

      [HttpGet]
      public IQueryable<Journal_Fusion> Journal_Fusions()
      {
         return _contextProvider.Context.Journal_Fusions;
      }

      [HttpGet]
      public IQueryable<Batch_Schedule> Batch_Schedules()
      {
         return _contextProvider.Context.Batch_Schedules;
      }

      [HttpGet]
      public IQueryable<Fiche_Pension> Fiche_Pensions()
      {
         return _contextProvider.Context.Fiche_Pensions;
      }

      [HttpGet]
      public IQueryable<Categorie_Employeur> Categorie_Employeurs()
      {
         return _contextProvider.Context.Categorie_Employeurs;
      }

      [HttpGet]
      public IQueryable<Cheque> Cheques()
      {
         return _contextProvider.Context.Cheques;
      }

      [HttpGet]
      public IQueryable<Cheque_Compteur> Cheque_Compteurs()
      {
         return _contextProvider.Context.Cheque_Compteurs;
      }

      [HttpGet]
      public IQueryable<Compteur_Folio> Compteur_Folios()
      {
         return _contextProvider.Context.Compteur_Folios;
      }

      [HttpGet]
      public IQueryable<Assimilation> Assimilations()
      {
         return _contextProvider.Context.Assimilations;
      }

      [HttpGet]
      public IQueryable<Contrat> Contrats()
      {
         return _contextProvider.Context.Contrats;
      }

      [HttpGet]
      public IQueryable<Drs_A037ChomageTemporaire> Drs_A037ChomageTemporaires()
      {
         return _contextProvider.Context.Drs_A037ChomageTemporaires;
      }

      [HttpGet]
      public IQueryable<Drs_Envoi> Drs_Envois()
      {
         return _contextProvider.Context.Drs_Envois;
      }

      [HttpGet]
      public IQueryable<Decompte_Lot> Decompte_Lots()
      {
         return _contextProvider.Context.Decompte_Lots;
      }

      [HttpGet]
      public IQueryable<Att_A045> Att_A045s()
      {
         return _contextProvider.Context.Att_A045s;
      }

      [HttpGet]
      public IQueryable<Pension_LettreDepart> Pension_LettreDeparts()
      {
         return _contextProvider.Context.Pension_LettreDeparts;
      }

      [HttpGet]
      public IQueryable<Dossier> Dossiers()
      {
         return _contextProvider.Context.Dossiers;
      }

      [HttpGet]
      public IQueryable<Livre> Livres()
      {
         return _contextProvider.Context.Livres;
      }

      [HttpGet]
      public IQueryable<Historique> Historiques()
      {
         return _contextProvider.Context.Historiques;
      }

      [HttpGet]
      public IQueryable<Intervention> Interventions()
      {
         return _contextProvider.Context.Interventions;
      }

      [HttpGet]
      public IQueryable<Ligne_Releve> Ligne_Releves()
      {
         return _contextProvider.Context.Ligne_Releves;
      }

      [HttpGet]
      public IQueryable<Localite> Localites()
      {
         return _contextProvider.Context.Localites;
      }

      [HttpGet]
      public IQueryable<Marque> Marques()
      {
         return _contextProvider.Context.Marques;
      }

      [HttpGet]
      public IQueryable<Travailleur> Travailleurs()
      {
         return _contextProvider.Context.Travailleurs;
      }

      [HttpGet]
      public IQueryable<Mouvement_Assimilation> Mouvement_Assimilations()
      {
         return _contextProvider.Context.Mouvement_Assimilations;
      }

      [HttpGet]
      public IQueryable<Att_A045_Disease> Att_A045_Diseases()
      {
         return _contextProvider.Context.Att_A045_Diseases;
      }

      [HttpGet]
      public IQueryable<Mouvement_Remuneration> Mouvement_Remunerations()
      {
         return _contextProvider.Context.Mouvement_Remunerations;
      }

      [HttpGet]
      public IQueryable<Payement_Compteur> Payement_Compteurs()
      {
         return _contextProvider.Context.Payement_Compteurs;
      }

      [HttpGet]
      public IQueryable<Att_A045_DecisionFbzFmp> Att_A045_DecisionFbzFmps()
      {
         return _contextProvider.Context.Att_A045_DecisionFbzFmps;
      }

      [HttpGet]
      public IQueryable<Employeur> Employeurs()
      {
         return _contextProvider.Context.Employeurs;
      }

      [HttpGet]
      public IQueryable<Query> Queries()
      {
         return _contextProvider.Context.Queries;
      }

      [HttpGet]
      public IQueryable<Retenue_Creance> Retenue_Creances()
      {
         return _contextProvider.Context.Retenue_Creances;
      }

      [HttpGet]
      public IQueryable<Siege_Exploitation> Siege_Exploitations()
      {
         return _contextProvider.Context.Siege_Exploitations;
      }

      [HttpGet]
      public IQueryable<Dossier_Intervention> Dossier_Interventions()
      {
         return _contextProvider.Context.Dossier_Interventions;
      }

      [HttpGet]
      public IQueryable<Ligne_Travailleur> Ligne_Travailleurs()
      {
         return _contextProvider.Context.Ligne_Travailleurs;
      }

      [HttpGet]
      public IQueryable<Titre_Compteur> Titre_Compteurs()
      {
         return _contextProvider.Context.Titre_Compteurs;
      }

      [HttpGet]
      public IQueryable<Validation_Envoi> Validation_Envois()
      {
         return _contextProvider.Context.Validation_Envois;
      }

      [HttpGet]
      public IQueryable<dtproperties> dtproperties()
      {
         return _contextProvider.Context.dtproperties;
      }

      [HttpGet]
      public IQueryable<Solidarite_Compteur> Solidarite_Compteurs()
      {
         return _contextProvider.Context.Solidarite_Compteurs;
      }

      [HttpGet]
      public IQueryable<Solidarite_Inactivite> Solidarite_Inactivites()
      {
         return _contextProvider.Context.Solidarite_Inactivites;
      }

      [HttpGet]
      public IQueryable<Drs_A037_DossierAnnuel> Drs_A037_DossierAnnuels()
      {
         return _contextProvider.Context.Drs_A037_DossierAnnuels;
      }

      [HttpGet]
      public IQueryable<Envoi> Envois()
      {
         return _contextProvider.Context.Envois;
      }

      [HttpGet]
      public IQueryable<Beneficiaire> Beneficiaires()
      {
         return _contextProvider.Context.Beneficiaires;
      }

      [HttpGet]
      public IQueryable<Drs_A037> Drs_A037s()
      {
         return _contextProvider.Context.Drs_A037s;
      }

      [HttpGet]
      public IQueryable<Payement> Payements()
      {
         return _contextProvider.Context.Payements;
      }

      [HttpGet]
      public IQueryable<Demande_Intervention> Demande_Interventions()
      {
         return _contextProvider.Context.Demande_Interventions;
      }

      [HttpGet]
      public IQueryable<Cotisation_Etudiant> Cotisation_Etudiants()
      {
         return _contextProvider.Context.Cotisation_Etudiants;
      }

      [HttpGet]
      public IQueryable<Prime_Prepension> Prime_Prepensions()
      {
         return _contextProvider.Context.Prime_Prepensions;
      }

      [HttpGet]
      public IQueryable<Drs_A044_Dossier> Drs_A044_Dossiers()
      {
         return _contextProvider.Context.Drs_A044_Dossiers;
      }

      [HttpGet]
      public IQueryable<Drs_A044_Payement> Drs_A044_Payements()
      {
         return _contextProvider.Context.Drs_A044_Payements;
      }

      [HttpGet]
      public IQueryable<Immunisation_Jours> Immunisation_Jours()
      {
         return _contextProvider.Context.Immunisation_Jours;
      }

      [HttpGet]
      public IQueryable<Drs_A044_Attestation> Drs_A044_Attestations()
      {
         return _contextProvider.Context.Drs_A044_Attestations;
      }

      [HttpGet]
      public IQueryable<Creance> Creances()
      {
         return _contextProvider.Context.Creances;
      }

      [HttpGet]
      public IQueryable<Creancier> Creanciers()
      {
         return _contextProvider.Context.Creanciers;
      }

      [HttpPost]
      public SaveResult SaveChanges(JObject saveBundle)
      {
         return _contextProvider.SaveChanges(saveBundle);
      }
   }
}
