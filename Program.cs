
using System;

namespace CRAM
{
    public class Program
    {
        public static void Main() 
        {
            const string Menu = "\nSave the ocean!\n\nQuè vols fer?\n1. Jugar!\n2. Sortir";
            const string SecondMenu = "\nPerfecte! Què vols ser?\n1. Tècnic (45 XP)\n2. Veterinari (80 XP)";
            const string MsgUserName = "\nGenial! I el teu nom?";
            const string MenuError = "\nL'opció introduïda no es correcta";
            const string ADMsg = "L'animal té un grau d’afectació (GA) del {0}%. Vols curar-la aquí (1) o traslladar-la al centre (2)?";
            const string ADResult = "El tractament aplicat ha reduït el GA fins al {0}%.";
            const string RescueFailed = "No ha estat prou efectiu i cal traslladar l’exemplar al centre. La teva experiència s’ha reduït en -20XP.\n";
            const string RescuePassed = "L’exemplar està recuperat i pot tornar al seu hàbitat. La teva experiència ha augmentat en +50XP.\n";
            const string FinalXP = "\nHas acabat amb un total de {0} XP.";
            const string Bye = "Gràcies per jugar, fins la propera!!";

            const string DefaultRol = "Tècnic", DefaultDate = "04-03-2024";
            string[] names = { "Berta", "Winnie", "William" };
            string[] families = { "Tortuga Marina", "Cetaci", "Au Marina" };
            string[] cities = { "Cadaquès", "Gavà", "Mataró" };
            string? name, family, specie;
            int option;
            double result;

            do
            {
                Console.WriteLine(Menu);
                option = Convert.ToInt32(Console.ReadLine());
                if (Validation(option)) Console.WriteLine(MenuError);

            } while (Validation(option));
            Console.Clear();

            if (option == 1)
            {
                do
                {
                    Console.WriteLine(SecondMenu);
                    option = Convert.ToInt32(Console.ReadLine());
                    if (Validation(option)) Console.WriteLine(MenuError);

                } while (Validation(option));
                Console.Clear();
                Console.WriteLine(MsgUserName);
                name = Console.ReadLine();

                User newUser = new User(name, DefaultRol, 45);
                if (option == 2)
                {
                    newUser.Rol = "Veterinari";
                    newUser.Experience = 80;
                }
                Console.Clear();

                family = RandomStrings(families);
                switch (family)
                {
                    case "Tortuga Marina":
                        specie = "Tortuga Boba";
                        break;
                    case "Au Marina":
                        specie = "Pelicà";
                        break;
                    case "Cetaci":
                        specie = "Dofí";
                        break;
                    default:
                        specie = "default";
                        break;
                }

                Animal animal = new Animal(RandomStrings(names), family, specie, RandomValues(0, 50));
                Rescue rescue = new Rescue(RandomValues(0, 999).ToString("000"), DefaultDate, animal.Family, RandomValues(1, 99), RandomStrings(cities));
                Console.WriteLine(rescue.ToString(newUser.Name));
                Console.WriteLine(animal.ToString());
                Console.WriteLine(ADMsg, rescue.AffectationDegree);
                do
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    if (Validation(option)) Console.WriteLine(MenuError);

                } while (Validation(option));
                Console.Clear();

                result = animal.CalculateAD(rescue.AffectationDegree, option);
                Console.WriteLine(ADResult, result);
                if (result <= 5)
                {
                    Console.WriteLine(RescuePassed);
                    newUser.Experience += 50;
                }
                else
                {
                    Console.WriteLine(RescueFailed);
                    newUser.Experience -= 20;
                }
                Console.WriteLine(FinalXP,newUser.Experience);
            }
            Console.WriteLine(Bye);
        }

        public static bool Validation(int option)
        {
            const int Op1 = 1, Op2 = 2;
            return option > Op2 || option < Op1;
        }

        public static int RandomValues(int min, int max)
        {
            var Random = new Random();
            return Random.Next(min,max+1);
        }

        public static string RandomStrings(string[] values)
        {
            var Random = new Random();
            return values[Random.Next(values.Length)];
        }
    }
}