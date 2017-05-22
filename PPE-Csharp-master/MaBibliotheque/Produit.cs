using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class Produit
    {
        private int idProduit;
        private String libelleProduit;

        // Le constructeur
        public Produit(int unId, String unLibelle)
        {
            this.idProduit = unId;
            this.libelleProduit = unLibelle;
        }

        // Les accesseurs
        public int getId()
        {
            return this.idProduit;
        }

        public String getLibelle()
        {
            return this.libelleProduit;
        }
    }
}
