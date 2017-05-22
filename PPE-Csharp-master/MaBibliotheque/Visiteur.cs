using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class Visiteur
    {
        private int idVisiteur;
        private String nomVisiteur;
        private String prenomVisiteur;
        private DateTime dateEmbauche;
        private DateTime dateNaissance;
        private List<Produit> lesCompetences;

        //Le constructeur
        public Visiteur(int unIdVisiteur, String unNomVisiteur, String unPrenomVisiteur,
            DateTime uneDateEmbauche, DateTime uneDateNaissance)
        {
            this.idVisiteur = unIdVisiteur;
            this.nomVisiteur = unNomVisiteur;
            this.prenomVisiteur = unPrenomVisiteur;
            this.dateEmbauche = uneDateEmbauche;
            this.dateNaissance = uneDateNaissance;
        }

        // Les accesseurs
        public int getId()
        {
            return this.idVisiteur;
        }

        public String getNom()
        {
            return this.nomVisiteur;
        }

        public String getPrenom()
        {
            return this.prenomVisiteur;
        }

        public DateTime getDateEmbauche()
        {
            return this.dateEmbauche;
        }

        public DateTime getDateNaissance()
        {
            return this.dateNaissance;
        }

        public List<Produit> getLesCompetences()
        {
            return this.lesCompetences;
        }

        //Pour ajouter une compétence (renvoie false si compétence déjà présente)
        public bool ajouterCompetence(Produit uneCompetence)
        {
            bool ajout;
            try
            {
                this.lesCompetences.Add(uneCompetence);
                ajout = true;
            }
            catch
            {
                ajout = false;
            }
            return ajout;
        }
    }
}
