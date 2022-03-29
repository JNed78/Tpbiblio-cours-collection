using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6_Statique
{
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
