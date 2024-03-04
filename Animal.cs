
namespace CRAM
{
    public class Animal
    {
        public string? Name { get; set; }
        public string? Family { get; set; }
        public string? Specie { get; set; }
        public int Weight { get; set; }

        public Animal(string name, string animal, string specie, int weight)
        {
            Name = name;
            Family = animal;
            Specie = specie;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"\nAquí tens la seva fitxa, per a més informació:\n+-------------------------------------------------------------------------------+\n| FITXA\t\t\t\t\t\t\t\t\t\t|\n+-------------------------------------------------------------------------------+\n| # Nom\t\t| Superfamília\t\t| Espècie\t\t| Pes aproximat |\n+-------------------------------------------------------------------------------+\n| {this.Name}\t\t| {this.Family}\t| {this.Specie}\t\t| {this.Weight} kg\t\t|\n+-------------------------------------------------------------------------------+";
        }

        public double CalculateAD(int affectDegree,int option)
        {
            const int Op2 = 2, localRescue = 5, CRAMrescue = 25;
            switch (this.Family)
            {
                case "Tortuga Marina":
                    {
                        return affectDegree - ((affectDegree - 2) * (2 * affectDegree + 3)) - localRescue;
                    }
                case "Au Marina":
                    {
                        if (option == Op2)
                        {
                            return Math.Floor(affectDegree - (Math.Pow(affectDegree, 2) + localRescue));
                        }
                        return Math.Floor(affectDegree - Math.Pow(affectDegree, 2));
                    }
                case "Cetaci":
                    {
                        if (option == Op2)
                        {
                            return Math.Floor(affectDegree - Math.Log10(affectDegree));
                        }
                        return Math.Floor(affectDegree - Math.Log10(affectDegree) - CRAMrescue);
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}
