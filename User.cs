
namespace CRAM
{
    public class User
    {
        public string? Name { get; set; }
        public string? Rol {  get; set; }
        public int Experience { get; set; }

        public User (string? name, string? rol, int experience)
        {
            Name = name;
            Rol = rol;
            Experience = experience;
        }
    }
}
