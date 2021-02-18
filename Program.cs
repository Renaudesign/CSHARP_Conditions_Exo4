using System;

namespace CHSARP_Conditions_Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            const string login = "operateur";
            const string password = "1234";

            Console.WriteLine("Veuillez indiquer votre identifiant d'utilisateur:");
            string saisieLogin = Console.ReadLine();

            Console.WriteLine("Merci Utilisateur.Veuillez maintenant saisir votre mot de passe: ");
            string saisiePassword = Console.ReadLine();

            //pour analyser plusieurs variables, les séparer par une virgule. respecter la même structure pour le case avec les variables correspondantes

            switch (saisieLogin, saisiePassword)
            {
                case (login, password):
                    Console.WriteLine("Bienvenue à l'abri 404.");
                    break;
                default:
                    Console.Write("Echec système : mauvais identifiant ou mot de passe");
                    break;
            }

        }
    }
}
