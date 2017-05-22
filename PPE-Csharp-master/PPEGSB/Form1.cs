using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaBibliotheque;

namespace PPEGSB
{
    public partial class Form1 : Form
    {
        //variables permettant de stocker les ids du produit et du visiteur selectionne dans les datagridviews
        int idVisiteur = 0, idProduit = 0;

        // Lancement de l'application
        public Form1()
        {
            InitializeComponent();
        }

        // Chargement de la page principale
        private void Form1_Load(object sender, EventArgs e)
        {
            Passerelle.seConnecter();
            tabControl.TabPages.Remove(tabProduit); // Permet de ne pas afficher les tabPages
            tabControl.TabPages.Remove(tabVisiteur);
            tabControl.TabPages.Remove(tabVisParProd);
            tabControl.TabPages.Remove(tabGestion);
            tabControl.TabPages.Remove(tabVisiteurAge);
            dtpEmbauche.MaxDate = DateTime.Today;
        }

        //Action lorsqu'on clique sur le bouton "quitter" de la page principale
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment quitter ?";
            string titre = "Fermeture de l'application";
            MessageBoxButtons boutons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Affiche la boite de confirmation.

            result = MessageBox.Show(this, message, titre, boutons);

            if (result == DialogResult.Yes)
            {
                dgvVisiteurs.Rows.Clear();
                dgvVisiteurCompetences.Rows.Clear();
                // Ferme le formulaire parent
                this.Close();

            }
        }

        // Action lorsqu'on clique sur le bouton "se connecter"
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            Utilisateur lUtilisateur = Passerelle.getUtilisateur(txtIdUser.Text, txtMdpUser.Text);
            if (lUtilisateur == null)
            {
                MessageBox.Show("Verifiez le login ou le mot de passe !", "Connexion impossible");
            }
            else
            {
                lblNomUserConnecte.Text = lUtilisateur.getNom() + " " + lUtilisateur.getPrenom();
                lblFonctionUser.Text = lUtilisateur.getFonction();
                tabControl.TabPages.Remove(tabConnexion);
                btnDeconnecter.Visible = true; // Affiche le bouton de deconnexion
                if(lUtilisateur.getFonction() == "Secretaire DRH")
                {
                    tabControl.TabPages.Add(tabProduit); //Permet d'afficher la tabPage dans le tabControl
                    tabControl.TabPages.Add(tabVisiteur);
                    tabControl.TabPages.Add(tabGestion);
                    foreach (Produit unProduit in Passerelle.getLesProduits()) //pour chaque produit dans la BDD
                    {
                        dgvProduits.Rows.Add(unProduit.getId(), unProduit.getLibelle()); //on remplit le dataGridView des produits
                    }
                    foreach (Visiteur unVisiteur in Passerelle.getLesVisiteurs()) // pour chaque visiteur dans la BDD
                    {
                        dgvVisiteurs.Rows.Add(unVisiteur.getId(), unVisiteur.getNom(), unVisiteur.getPrenom(),
                            unVisiteur.getDateEmbauche(), unVisiteur.getDateNaissance()); //on remplit le dataGridView des visiteurs
                        dgvVisiteurCompetences.Rows.Add(unVisiteur.getId(), unVisiteur.getNom(), unVisiteur.getPrenom());
                    }
                }
                else if(lUtilisateur.getFonction() == "DRH")
                {
                    tabControl.TabPages.Add(tabVisParProd);
                    tabControl.TabPages.Add(tabVisiteurAge);
                    chart1.DataSource = Passerelle.getVisiteursParProduit();
                    chart1.Series["Nombre de visiteurs"].XValueMember = "Produit";
                    chart1.Series["Nombre de visiteurs"].YValueMembers = "Nombre de visiteurs";
                    chart1.DataBind();
                    chart2.DataSource = Passerelle.getVisiteursParAge();
                    chart2.Series["Series1"].XValueMember = "Tranche d'age";
                    chart2.Series["Series1"].YValueMembers = "Nombre de visiteurs";
                    chart2.DataBind();
                }

            }
        }

        // Action lorsqu'on clique sur le bouton "se deconnecter"
        private void btnDeconnecter_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment vous deconnecter ?";
            string titre = "Deconnexion";
            MessageBoxButtons boutons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Affiche la boite de confirmation.

            result = MessageBox.Show(this, message, titre, boutons);

            if (result == DialogResult.Yes)
            {
                tabControl.TabPages.Remove(tabProduit); // Permet de ne pas afficher les tabPages
                tabControl.TabPages.Remove(tabVisiteur);
                tabControl.TabPages.Remove(tabVisParProd);
                tabControl.TabPages.Remove(tabGestion);
                tabControl.TabPages.Remove(tabVisiteurAge);
                tabControl.TabPages.Add(tabConnexion); // Permet d'afficher la tabPage
                dgvVisiteurs.Rows.Clear();
                dgvVisiteurCompetences.Rows.Clear();
                btnDeconnecter.Visible = false;
                MessageBox.Show("Vous etes bien deconnecte.\nA bientot");
            }
        }

        // Recupere les valeurs de la ligne selectionnee dans la liste des visiteurs
        private void dgvVisiteurs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idVisiteur = Convert.ToInt32(dgvVisiteurs.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNomVisiteur.Text = dgvVisiteurs.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrenomVisiteur.Text = dgvVisiteurs.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpEmbauche.Value = Convert.ToDateTime(dgvVisiteurs.Rows[e.RowIndex].Cells[3].Value.ToString());
            dtpNaissance.Value = Convert.ToDateTime(dgvVisiteurs.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void btnAjouterVisiteur_Click(object sender, EventArgs e)
        {
            if(Passerelle.existeVisiteur(txtNomVisiteur.Text, txtPrenomVisiteur.Text) == true)
            {
                MessageBox.Show("Le visiteur que vous voulez ajouter existe deja!", "Ajout annule");
            }
            else
            {
                dgvVisiteurs.Rows.Clear();
                dgvVisiteurCompetences.Rows.Clear();
                Passerelle.ajouterVisiteur(txtNomVisiteur.Text, txtPrenomVisiteur.Text, dtpEmbauche.Value, dtpNaissance.Value);
                foreach (Visiteur unVisiteur in Passerelle.getLesVisiteurs())
                {
                    dgvVisiteurs.Rows.Add(unVisiteur.getId(), unVisiteur.getNom(), unVisiteur.getPrenom(),
                        unVisiteur.getDateEmbauche(), unVisiteur.getDateNaissance());
                    dgvVisiteurCompetences.Rows.Add(unVisiteur.getId(), unVisiteur.getNom(), unVisiteur.getPrenom());
                }
                MessageBox.Show("Le visiteur a ete ajoute", "Ajout effectue");
            }
        }

        private void btnModifierVisiteur_Click(object sender, EventArgs e)
        {
            if (idVisiteur == 0)
            {
                MessageBox.Show("Vous devez selectionner un visiteur");
            }
            else
            {
                string message = "Le visiteur '" + Passerelle.getVisiteur(idVisiteur).getNom() + " " + Passerelle.getVisiteur(idVisiteur).getPrenom() + 
                    "' sera modifie. Voulez-vous continuer?";
                string titre = "Modification d'un visiteur";
                MessageBoxButtons boutons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Affiche la boite de confirmation avant modification

                result = MessageBox.Show(this, message, titre, boutons);

                if (result == DialogResult.Yes)
                {
                    dgvVisiteurs.Rows.Clear();
                    dgvVisiteurCompetences.Rows.Clear();
                    Passerelle.modifierVisiteur(idVisiteur, txtNomVisiteur.Text, txtPrenomVisiteur.Text, dtpEmbauche.Value, dtpNaissance.Value);
                    foreach (Visiteur unVisiteur in Passerelle.getLesVisiteurs())
                    {
                        dgvVisiteurs.Rows.Add(unVisiteur.getId(), unVisiteur.getNom(), unVisiteur.getPrenom(),
                            unVisiteur.getDateEmbauche(), unVisiteur.getDateNaissance());
                        dgvVisiteurCompetences.Rows.Add(unVisiteur.getId(), unVisiteur.getNom(), unVisiteur.getPrenom());
                    }
                    MessageBox.Show("Le visiteur a bien ete modifie!");
                }
                else
                {
                    MessageBox.Show("La modification a ete annule");
                }
            }

        }

        private void btnSupprimerVisiteur_Click(object sender, EventArgs e)
        { 
            if(idVisiteur == 0)
            {
                MessageBox.Show("Vous devez selectionner un visiteur");
            }
            else
            {
                string message = "Le visiteur '" + Passerelle.getVisiteur(idVisiteur).getNom() + " " + 
                    Passerelle.getVisiteur(idVisiteur).getPrenom() + "' sera supprime. \nVoulez-vous continuer?";
                string titre = "Suppression d'un visiteur";
                MessageBoxButtons boutons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Affiche la boite de confirmation avant suppression

                result = MessageBox.Show(this, message, titre, boutons);

                if (result == DialogResult.Yes)
                {
                    dgvVisiteurs.Rows.Clear();
                    dgvVisiteurCompetences.Rows.Clear();
                    Passerelle.supprimerVisiteur(idVisiteur);
                    foreach (Visiteur unVisiteur in Passerelle.getLesVisiteurs())
                    {
                        dgvVisiteurs.Rows.Add(unVisiteur.getId(), unVisiteur.getNom(), unVisiteur.getPrenom(), 
                            unVisiteur.getDateEmbauche(), unVisiteur.getDateNaissance());
                        dgvVisiteurCompetences.Rows.Add(unVisiteur.getId(), unVisiteur.getNom(), unVisiteur.getPrenom());
                    }
                    MessageBox.Show("Le visiteur a bien ete supprime!");
                }
                else
                {
                    MessageBox.Show("La modification a ete annule");
                }
            }
        }

        // Recupere les valeurs de la ligne selectionnee dans la liste des produits
        private void dgvProduits_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtLibelleProduit.Text = dgvProduits.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        // Permet d'ajouter un nouveau produit dans la liste
        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            if (Passerelle.existeProduit(txtLibelleProduit.Text) == true)
            {
                MessageBox.Show("Le produit que vous voulez ajouter existe deja!", "Ajout annule");
            }
            else
            {
                Passerelle.ajouterProduit(txtLibelleProduit.Text);
                dgvProduits.Rows.Clear();
                foreach (Produit unProduit in Passerelle.getLesProduits())
                {
                    chkCompetencesDispo.Items.Add(unProduit.getLibelle());
                    dgvProduits.Rows.Add(unProduit.getId(), unProduit.getLibelle());
                }
                MessageBox.Show("Le produit a ete ajoute!", "Ajout effectue");
            }
        }


        // Permet de supprimer un produit selectionne dans la liste
        private void btnSupprimerProduit_Click(object sender, EventArgs e)
        {
            if(idProduit == 0)
            {
                MessageBox.Show("Vous devez selectionner un produit!");
            }
            else
            {
                string message = "Le produit '" + Passerelle.getProduit(idProduit).getLibelle() + "' sera supprime. \nVoulez-vous continuer?";
                string titre = "Suppression d'un produit";
                MessageBoxButtons boutons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Affiche la boite de confirmation avant suppression

                result = MessageBox.Show(this, message, titre, boutons);

                if (result == DialogResult.Yes)
                {
                    Passerelle.supprimerProduit(idProduit);
                    dgvProduits.Rows.Clear();
                    foreach (Produit unProduit in Passerelle.getLesProduits())
                    {
                        chkCompetencesDispo.Items.Add(unProduit.getLibelle());
                        dgvProduits.Rows.Add(unProduit.getId(), unProduit.getLibelle());
                    }
                    MessageBox.Show("Le produit a bien ete supprime!");
                }
                else
                {
                    MessageBox.Show("La modification a ete annule");
                }
            }
        }

        private void btnAjoutCompetences_Click(object sender, EventArgs e)
        {
            if (chkCompetencesDispo.CheckedItems.Count == 0)
            {
                return;
            }
            else if (idVisiteur <= 0)
            {
                MessageBox.Show("Vous devez selectionner un visiteur !");
            }
            else
            {
                foreach (String unLibelleProduit in chkCompetencesDispo.CheckedItems)
                {
                    Passerelle.ajouterCompetence(Passerelle.getProduit(unLibelleProduit).getId(), idVisiteur);
                }
                chkCompetencesDispo.Items.Clear();
                chkCompetencesVisiteur.Items.Clear();
                foreach (Produit unProduit in Passerelle.getLesCompetencesDispo(idVisiteur))
                {
                    chkCompetencesDispo.Items.Add(unProduit.getLibelle());
                }
                foreach (Produit unProduit in Passerelle.getLesCompetencesDuVisiteur(idVisiteur))
                {
                    chkCompetencesVisiteur.Items.Add(unProduit.getLibelle());
                }
            } 
        }

        private void btnSupprCompetences_Click(object sender, EventArgs e)
        {
            if (chkCompetencesVisiteur.CheckedItems.Count == 0)
            {
                return;
            }
            else if (idVisiteur <= 0)
            {
                MessageBox.Show("Vous devez selectionner un visiteur !");
            }
            else
            {
                foreach (String unLibelleProduit in chkCompetencesVisiteur.CheckedItems)
                {
                    Passerelle.supprimerCompetence(Passerelle.getProduit(unLibelleProduit).getId(), idVisiteur);
                }
                chkCompetencesDispo.Items.Clear();
                chkCompetencesVisiteur.Items.Clear();
                foreach (Produit unProduit in Passerelle.getLesCompetencesDispo(idVisiteur))
                {
                    chkCompetencesDispo.Items.Add(unProduit.getLibelle());
                }
                foreach (Produit unProduit in Passerelle.getLesCompetencesDuVisiteur(idVisiteur))
                {
                    chkCompetencesVisiteur.Items.Add(unProduit.getLibelle());
                }
            }
        }

        private void dgvVisiteurCompetences_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            chkCompetencesDispo.Items.Clear();
            chkCompetencesVisiteur.Items.Clear();
            idVisiteur = Convert.ToInt32(dgvVisiteurCompetences.Rows[e.RowIndex].Cells[0].Value.ToString());
            foreach (Produit unProduit in Passerelle.getLesCompetencesDispo(idVisiteur))
            {
                chkCompetencesDispo.Items.Add(unProduit.getLibelle());
            }
            foreach (Produit unProduit in Passerelle.getLesCompetencesDuVisiteur(idVisiteur))
            {
                chkCompetencesVisiteur.Items.Add(unProduit.getLibelle());
            }
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            idVisiteur = 0;
            idProduit = 0;
            chkCompetencesDispo.Items.Clear();
            chkCompetencesVisiteur.Items.Clear();
        }

        // Permet de modifier un produit selectionne dans la liste
        private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            if (idProduit == 0)
            {
                MessageBox.Show("Vous devez selectionner un produit!");
            }
            else
            {
                string message = "Le produit '" + Passerelle.getProduit(idProduit).getLibelle() + "' sera modifie. Voulez-vous continuer?";
                string titre = "Modification d'un produit";
                MessageBoxButtons boutons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Affiche la boite de confirmation avant modification

                result = MessageBox.Show(this, message, titre, boutons);

                if (result == DialogResult.Yes)
                {
                    Passerelle.modifierProduit(idProduit, txtLibelleProduit.Text);
                    dgvProduits.Rows.Clear();
                    chkCompetencesDispo.Items.Clear();
                    chkCompetencesVisiteur.Items.Clear();
                    foreach (Produit unProduit in Passerelle.getLesProduits())
                    {
                        dgvProduits.Rows.Add(unProduit.getId(), unProduit.getLibelle());
                    }

                    MessageBox.Show("Le produit a bien ete modifie!");
                }
                else
                {
                    MessageBox.Show("La modification a ete annule");
                }
            }
        }
    }
}

