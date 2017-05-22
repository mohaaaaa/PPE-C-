using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class Utilisateur
    {
        private int idUtilisateur;
        private String nom;
        private String prenom;
        private String login;
        private String mdp;
        private String fonction;

        public Utilisateur(int pId, String pNom, String pPrenom, String pLogin,
            String pMdp, String pFonction)
        {
            this.idUtilisateur = pId;
            this.nom = pNom;
            this.prenom = pPrenom;
            this.login = pLogin;
            this.mdp = pMdp;
            this.fonction = pFonction;
        }

        public int getId()
        {
            return this.idUtilisateur;
        }

        public String getNom()
        {
            return this.nom;
        }

        public String getPrenom()
        {
            return this.prenom;
        }

        public String getLogin()
        {
            return this.login;
        }

        public String getMdp()
        {
            return this.mdp;
        }

        public String getFonction()
        {
            return this.fonction;
        }
    }
}
