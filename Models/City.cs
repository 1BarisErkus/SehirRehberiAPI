namespace SehirRehberiAPI.Models
{
    public class City
    {
        public City()
        {
            Photos = new List<Photo>();
        }

        public int Id { get; set; } = 0;
        public string Description { get; set; } = "";
        public string Name { get; set; } = "";
        public int UserId { get; set; } = 0;

        public List<Photo> Photos { get; set; } = new List<Photo>();
        public User User { get; set; } = new User();
    }
}
