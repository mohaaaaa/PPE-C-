using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using MaBibliotheque;

namespace PPEGSB
{
    public static class Passerelle
    {
        private static SqlConnection laConnexion;

        //Methode pour se connecter à la base de données SQLServer
        public static bool seConnecter()
        {
            bool ouvert;
            laConnexion = new SqlConnection();
            laConnexion.ConnectionString =
                "Data Source=DESKTOP-403K8FO;Initial Catalog=PPEgsb;Integrated Security = true; MultipleActiveResultSets = true";

            laConnexion.Open();
            if (laConnexion.State == System.Data.ConnectionState.Open)
            {
                ouvert = true;
            }
            else
            {
                ouvert = false;
            }
            return ouvert;
        }

        //Methode pour se déconnecter de la base de données SQLServer
        public static bool seDeconnecter()
        {
            bool fermer;
            laConnexion.Close();
            if (laConnexion.State == System.Data.ConnectionState.Open)
            {
                fermer = true;
            }
            else
            {
                fermer = false;
            }
            return fermer;
        }

        //Méthode pour compter le nombre de visiteurs dans la base de données (select count)
        public static int getNombreVisiteurs()
        {
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "select count(*) from T_VISITEUR";
            int nombreVisiteurs = (int)laCommande.ExecuteScalar();
            return nombreVisiteurs;
        }

        //Methode pour avoir un produit avec son id
        public static Produit getProduit(int unIdProduit)
        {
            Produit leProduit;
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "select * from T_PRODUIT where PRO_ID = " + unIdProduit;
            SqlDataReader leLecteurP = laCommande.ExecuteReader();
            if (leLecteurP.Read())
            {
                leProduit = new Produit(unIdProduit, (String)leLecteurP.GetValue(1));
            }
            else
            {
                leProduit = null;
            }
            leLecteurP.Close();
            return leProduit;
        }

        public static Produit getProduit(String unLibelleProduit)
        {
            Produit leProduit;
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "select * from T_PRODUIT where PRO_LIBELLE = '" + unLibelleProduit + "'";
            SqlDataReader leLecteurP = laCommande.ExecuteReader();
            if (leLecteurP.Read())
            {
                leProduit = new Produit((int)leLecteurP.GetValue(0), unLibelleProduit);
            }
            else
            {
                leProduit = null;
            }
            leLecteurP.Close();
            return leProduit;
        }

        public static List<Produit> getLesProduits()
        {
            Produit leProduit;
            List<Produit> lesProduits = new List<Produit>();
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "select * from T_PRODUIT";
            SqlDataReader leLecteurP = laCommande.ExecuteReader();
            while (leLecteurP.Read())
            {
                leProduit = new Produit((int)leLecteurP.GetValue(0), (String)leLecteurP.GetValue(1));
                lesProduits.Add(leProduit);
            }
            leLecteurP.Close();
            return lesProduits;
        }

        public static bool existeProduit(String unLibelleProduit)
        {
            bool trouve = false;
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandText = "select * from T_PRODUIT where exists(select * from T_PRODUIT where PRO_LIBELLE = '" 
                + unLibelleProduit + "') and PRO_LIBELLE = '" + unLibelleProduit + "'";
            SqlDataReader leLecteur = laCommande.ExecuteReader();
            if (leLecteur.Read())
            {
                trouve = true;
            }
            return trouve;
        }

        // Methode permettant d'ajouter un nouveau produit dans la BDD
        public static void ajouterProduit(String unLibelleProduit)
        {
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandText = "insert into T_PRODUIT (PRO_LIBELLE) values ('" + unLibelleProduit + "')";
            laCommande.ExecuteNonQuery();
        }

        // Methode permettant de modifier un produit dans la BDD
        public static void modifierProduit(int unIdProduit, String unLibelleProduit)
        {
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "update T_PRODUIT set PRO_LIBELLE = '" + unLibelleProduit + "' where PRO_ID = " + unIdProduit;
            laCommande.ExecuteNonQuery();
        }

        // Methode permettant de supprimer un produit dans la BDD
        public static void supprimerProduit(int unIdProduit)
        {
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "delete from T_PRODUIT where PRO_ID = " + unIdProduit;
            laCommande.ExecuteNonQuery();
        }

        // Methode permettant d'avoir les informations sur 
        public static Utilisateur getUtilisateur(String unLogin, String unMdp)
        {
            Utilisateur lUtilisateur;
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "select * from T_UTILISATEUR where USR_LOGIN = '" + unLogin + "' AND USR_PASSWORD = '" + unMdp + "'";
            SqlDataReader leLecteurU = laCommande.ExecuteReader();
            if (leLecteurU.Read())
            {
                lUtilisateur = new Utilisateur((int)leLecteurU.GetValue(0), (String)leLecteurU.GetValue(1),
                    (String)leLecteurU.GetValue(2), unLogin, unMdp, (String)leLecteurU.GetValue(5));
            }
            else
            {
                lUtilisateur = null;
            }
            leLecteurU.Close();
            return lUtilisateur;
        }

        public static Visiteur getVisiteur(int unIdVisiteur)
        {
            Visiteur leVisiteur;
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "select * from T_VISITEUR where VIS_ID = " + unIdVisiteur;
            SqlDataReader leLecteur = laCommande.ExecuteReader();
            if (leLecteur.Read())
            {
                leVisiteur = new Visiteur(unIdVisiteur, (String)leLecteur.GetValue(1),
                    (String)leLecteur.GetValue(2), (DateTime)leLecteur.GetValue(3), (DateTime)leLecteur.GetValue(4));
            }
            else
            {
                leVisiteur = null;
            }
            leLecteur.Close();
            return leVisiteur;
        }

        public static Visiteur getVisiteur(String unNomVisiteur, String unPrenomVisiteur)
        {
            Visiteur leVisiteur;
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "select * from T_VISITEUR where VIS_NOM = " + unNomVisiteur + " and VIS_PRENOM =" + unPrenomVisiteur;
            SqlDataReader leLecteur = laCommande.ExecuteReader();
            if (leLecteur.Read())
            {
                leVisiteur = new Visiteur((int)leLecteur.GetValue(0), unNomVisiteur,
                    unPrenomVisiteur, (DateTime)leLecteur.GetValue(3), (DateTime)leLecteur.GetValue(4));
            }
            else
            {
                leVisiteur = null;
            }
            leLecteur.Close();
            return leVisiteur;
        }

        public static List<Visiteur> getLesVisiteurs()
        {
            Visiteur leVisiteur;
            List<Visiteur> lesVisiteurs = new List<Visiteur>();
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "select * from T_VISITEUR";
            SqlDataReader leLecteurP = laCommande.ExecuteReader();
            while (leLecteurP.Read())
            {
                leVisiteur = new Visiteur((int)leLecteurP.GetValue(0), (String)leLecteurP.GetValue(1),
                    (String)leLecteurP.GetValue(2), (DateTime)leLecteurP.GetValue(3), (DateTime)leLecteurP.GetValue(4));
                lesVisiteurs.Add(leVisiteur);
            }
            leLecteurP.Close();
            return lesVisiteurs;
        }

        public static bool existeVisiteur(String unNomVisiteur, String unPrenomVisiteur)
        {
            bool trouve = false;
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandText = "select * from T_VISITEUR where exists(select * from T_VISITEUR where VIS_NOM = '" + unNomVisiteur +
                "' and VIS_PRENOM = '" + unPrenomVisiteur + "') and VIS_NOM = '" + unNomVisiteur + "' and VIS_PRENOM = '" + unPrenomVisiteur + "'";
            SqlDataReader leLecteur = laCommande.ExecuteReader();
            if (leLecteur.Read())
            {
                trouve = true;
            }
            return trouve;
        }

        public static void ajouterVisiteur(String unNomVisiteur, String unPrenomVisiteur, DateTime uneDateEmbauche, DateTime uneDateNaissance)
        {
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandText = "insert into T_VISITEUR values ('" + unNomVisiteur + "', '" + unPrenomVisiteur + "', '"
                +uneDateEmbauche + "', '" + uneDateNaissance + "')";
            laCommande.ExecuteNonQuery();
        }

        public static void modifierVisiteur(int unIdVisiteur, String unNomVisiteur, String unPrenomVisiteur, DateTime uneDateEmbauche,
            DateTime uneDateNaissance)
        {
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "update T_VISITEUR set VIS_NOM = '" + unNomVisiteur + "', VIS_PRENOM = '" + unPrenomVisiteur + 
                "', VIS_DATE_EMBAUCHE = '" + uneDateEmbauche + "', VIS_DATE_NAISSANCE = '" + uneDateNaissance + "' where VIS_ID = " + unIdVisiteur;
            laCommande.ExecuteNonQuery();
        }

        public static void supprimerVisiteur(int unIdVisiteur)
        {
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "delete from T_VISITEUR where VIS_ID = " + unIdVisiteur;
            laCommande.ExecuteNonQuery();
        }

        public static void ajouterCompetence(int unIdProduit, int unIdVisiteur)
        {
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = 
                "insert into T_COMPETENCE (COM_IDPRODUIT, COM_IDVISITEUR) values (" + unIdProduit + ", " + unIdVisiteur + ")";
            laCommande.ExecuteNonQuery();
        }

        public static void supprimerCompetence(int unIdProduit, int unIdVisiteur)
        {
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText =
                "delete from T_COMPETENCE where COM_IDPRODUIT = " + unIdProduit + " and COM_IDVISITEUR = '" + unIdVisiteur + "'";
            laCommande.ExecuteNonQuery();
        }

        public static List<Produit> getLesCompetencesDispo(int unIdVisiteur)
        {
            Produit leProduit;
            List<Produit> lesProduits = new List<Produit>();
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = 
                "select * from T_PRODUIT where PRO_ID not in (select COM_IDPRODUIT from T_COMPETENCE where COM_IDVISITEUR =" 
                + unIdVisiteur + ")";
            SqlDataReader leLecteurP = laCommande.ExecuteReader();
            while (leLecteurP.Read())
            {
                leProduit = new Produit((int)leLecteurP.GetValue(0), (String)leLecteurP.GetValue(1));
                lesProduits.Add(leProduit);
            }
            leLecteurP.Close();
            return lesProduits;
        }

        public static List<Produit> getLesCompetencesDuVisiteur(int unIdVisiteur)
        {
            Produit leProduit;
            List<Produit> lesProduits = new List<Produit>();
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText =
                "select * from T_PRODUIT where PRO_ID in (select COM_IDPRODUIT from T_COMPETENCE where COM_IDVISITEUR ="
                + unIdVisiteur + ")";
            SqlDataReader leLecteurP = laCommande.ExecuteReader();
            while (leLecteurP.Read())
            {
                leProduit = new Produit((int)leLecteurP.GetValue(0), (String)leLecteurP.GetValue(1));
                lesProduits.Add(leProduit);
            }
            leLecteurP.Close();
            return lesProduits;
        }

        public static DataTable getVisiteursParProduit()
        {
            DataTable lesVisiteursParProduit = new DataTable();
            lesVisiteursParProduit.Columns.Add("Nombre de visiteurs", typeof(int));
            lesVisiteursParProduit.Columns.Add("Produit", typeof(String));
            lesVisiteursParProduit.AcceptChanges();
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = 
                "select count(COM_IDVISITEUR), PRO_LIBELLE from T_COMPETENCE, T_PRODUIT where PRO_ID = COM_IDPRODUIT group by PRO_LIBELLE";
            SqlDataReader leLecteurP = laCommande.ExecuteReader();
            while (leLecteurP.Read())
            {
                lesVisiteursParProduit.Rows.Add(leLecteurP.GetValue(0), leLecteurP.GetValue(1));
                lesVisiteursParProduit.AcceptChanges();
            }
            return lesVisiteursParProduit;
        }

        public static DataTable getVisiteursParAge()
        {
            DataTable lesVisiteursParAge = new DataTable();
            lesVisiteursParAge.Columns.Add("Tranche d'age", typeof(String));
            lesVisiteursParAge.Columns.Add("Nombre de visiteurs", typeof(int));
            lesVisiteursParAge.AcceptChanges();
            SqlCommand laCommande = laConnexion.CreateCommand();
            laCommande.CommandType = System.Data.CommandType.Text;
            laCommande.CommandText = "select tranche.range as [tranche age], count(*) as [nombre de visiteurs]"
                + "from( select case when(YEAR(GETDATE()) - YEAR(VIS_DATENAISSANCE)) between 0 and 19 then '20-'"
                + "when(YEAR(GETDATE()) - YEAR(VIS_DATENAISSANCE)) between 20 and 29 then '20-29'"
                + "when(YEAR(GETDATE()) - YEAR(VIS_DATENAISSANCE)) between 30 and 39 then '30-39'"
                + "when(YEAR(GETDATE()) - YEAR(VIS_DATENAISSANCE)) between 40 and 49 then '40-49'"
                + "else '50+' end as range from T_VISITEUR) tranche group by tranche.range";
            SqlDataReader leLecteurP = laCommande.ExecuteReader();
            while (leLecteurP.Read())
            {
                lesVisiteursParAge.Rows.Add(leLecteurP.GetValue(0), leLecteurP.GetValue(1));
                lesVisiteursParAge.AcceptChanges();
            }
            return lesVisiteursParAge;
        }

    }
}

