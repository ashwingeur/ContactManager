using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class Program
    {
        static List<string> contacts = new List<string>();
        static void Main(string[] args)
        {
            AfficherMenu();
            Console.ReadKey();
        }
        static void AfficherMenu()
        {
            
            Console.WriteLine("1.ListerContact");
            Console.WriteLine("2.Ajouter");
            Console.WriteLine("3.Supprimer");
            Console.WriteLine("4.Quitter");
            Console.WriteLine("Que souhaitez vous ? ");
        
            

            string val = Console.ReadLine();
            if(val == "1")
            {
                AfficherContact(contacts);
             }
            else if ( val == "2")
            {
                AjouterContact(contacts);
            }
            else if (val == "3")
            {
               SupprimerContact();
            }
            else if (val == "4")
            {
                Console.WriteLine("en etes vous sur ?");
            }

        }
        static void AfficherContact(List<string> ListContact)
        {
            foreach ( string name in ListContact)
            {
                Console.WriteLine(name);
            }
            
        }
        static void AjouterContact(List<string> ListContact)
        {
            Console.WriteLine("Nom");
            Console.ReadLine();
            ListContact.Add(Console.ReadLine());

        }
        static void SupprimerContact()
        {}
        
    }
}
