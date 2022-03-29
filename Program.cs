using System;

namespace Tpbiblio
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliothèque bi = new Bibliothèque("Gutenberg \n");
            bi.AjouterLivre(new Livre("L1", "Quatre vingt treize", "Dunod", "Victor Hugo", 1870));
            bi.AjouterLivre(new Livre("L2", "les misérables", "Folio", "Victor Hugo", 1873));
            bi.AjouterLivre(new Livre("L3", "l'âme du mal", "Poche", "Maxime Chatam", 2005));
            bi.AjouterLivre(new Livre("L4", "Desert", "Folio", "Le clezio", 1980));
            bi.AjouterLivre(new Livre("L5", "Diégo et Frida", "Poche", "Le clezio", 1975));
            bi.AjouterLivre(new Livre("L6", "L'étranger", "Folio", "Camus", 1950));


            Console.WriteLine(bi);
            Console.ReadKey();
            bi.AfficheParAuteur("Victor Hugo");
            Console.ReadKey();
            bi.AfficheParEditeur("Poche");
            Console.ReadKey();
            bi.SupprimerLivre("Desert");
            Console.WriteLine(bi);
            Console.ReadKey();
            bi.SupprimerLivreAuteur("Victor Hugo");
            Console.WriteLine(bi);
            Console.ReadKey();

        }

    }
    public static class Entree
    {
        public static int entier(String msg) /// saisie d'un entier
        {
            Console.WriteLine(msg); try
            {
                int valeur = Convert.ToInt32(Console.ReadLine());
                return valeur;
            }
            catch (FormatException e)
            { return Entree.entier("Zone absente ou type incorrect, essayez a nouveau"); }
        }
        public static float flottant(String msg) /// saisie d'un float
        {
            Console.WriteLine(msg);
            try
            {
                float valeur = Convert.ToSingle(Console.ReadLine()); return valeur;
            }
            catch (FormatException e)
            { return Entree.flottant("Zone absente ou type incorrect, essayez a nouveau"); }
        }
        public static double reeldouble(String msg) /// saisie d'un double
        {
            Console.WriteLine(msg); try
            {
                Double valeur = Convert.ToDouble(Console.ReadLine()); return valeur;
            }
            catch (FormatException e)
            { return Entree.reeldouble("Zone absente ou type incorrect, essaye a nouveau"); }
        }
        public static string chaine(String msg) /// saisie d'une chaine
        {
            Console.WriteLine(msg);
            try
            {
                string valeur = Console.ReadLine(); return valeur;
            }
            catch (Exception e)
            { return Entree.chaine("problème de saisie chaîne"); }
        }
        public static char caractere(String msg) /// saisie et renvoi d'un caractère
        {
            Console.WriteLine(msg);
            try
            {
                string valeur = Console.ReadLine();
                return valeur[0];
            }
            catch (Exception e)
            { return Entree.caractere("problème de saisie chaîne"); }
        }
    }

}
