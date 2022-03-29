using System;
using System.Collections.Generic;
using System.Text;

namespace Tpbiblio
{
    class Bibliothèque
    {
        private string nom;
        List<Livre> lesLivres = new List<Livre>();
        
        public Bibliothèque(string nom)
        {
            this.nom = nom;
        }

        public Livre LivreExiste(string t)
        {
            Livre exemp = null;
            foreach (Livre a in lesLivres)
            {
                if (t == a.Ti)
                {
                    exemp = a;
                }
            }
            return exemp;
        }

        public void AjouterLivre(Livre i)
        {
            lesLivres.Add(i);
        }

        public int Cardinal()
        {
            return lesLivres.Count;
        }
        public override string ToString()
        {
            string tout = nom;
            foreach(Livre a in lesLivres)
            {
                tout += a + "\n";
            }
            return tout + "La collection contient " + this.Cardinal()+" livres.";
        }

        public void AfficheParAuteur(string a)
        {
            Console.WriteLine("Les livres de l'auteur choisi sont: \n");
            foreach (Livre aa in lesLivres)
            {
                if(aa.Aut ==a)
                {
                    Console.WriteLine(aa);
                }
                
            }
        }
        public void AfficheParEditeur(string e)
        {
            Console.WriteLine("Les livres de l'édition choisi sont: \n");
            foreach (Livre ee in lesLivres)
            {
                if (ee.Ed == e)
                {
                    Console.WriteLine(ee);
                }
            }
        }
        public Boolean SupprimerLivre(string t)
        {
            bool rep = false;
            Livre suprr = null;
            foreach (Livre tt in lesLivres)
            {
                if (tt.Ti == t)
                {
                    suprr = tt;
                }
            }
            rep = lesLivres.Remove(suprr);
            return rep;
        }

        public void SupprimerLivreAuteur(string Aut)
        { 
            bool sup = false;
           while(sup == false)
           { 
            Livre suprr = null;
            foreach (Livre aaa in lesLivres)
            {
                if (aaa.Aut == Aut)
                {
                     suprr = aaa;
                }
            }
                if(suprr == null){
                    sup = true;
                }
                lesLivres.Remove(suprr);
           }
        }
    }
}
