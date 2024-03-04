
namespace CRAM
{
    public class Rescue
    {
        public string? RescueId { get; set; }
        public string? RescueDate { get; set; }
        public string? RescuedAnimal { get; set; }
        public int AffectationDegree { get; set; }
        public string? Location { get; set; }

        public Rescue(string rescueId, string rescueDate, string rescuedAnimal, int affectationDegree, string location)
        {
            RescueId = "RES"+rescueId;
            RescueDate = rescueDate;
            RescuedAnimal = rescuedAnimal;
            AffectationDegree = affectationDegree;
            Location = location;
        }
        public string ToString(string? userName)
        {
            return $"\nHola, {userName}! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar.\nLes dades que ens han donat són les següents:\n+-------------------------------------------------------------------------------+\n| RESCAT\t\t\t\t\t\t\t\t\t|\n+-------------------------------------------------------------------------------+\n| # Rescat\t| Data rescat\t| Superfamília\t\t| GA\t| Localització\t|\n+-------------------------------------------------------------------------------+\n| {this.RescueId}\t| {this.RescueDate}\t| {this.RescuedAnimal}\t\t| {this.AffectationDegree}%\t| {this.Location}\t|\n+-------------------------------------------------------------------------------+\n";
        }
    }
}
