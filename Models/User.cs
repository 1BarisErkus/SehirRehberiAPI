namespace SehirRehberiAPI.Models
{
    public class User
    {
        public User()
        {
            Cities = new List<City>();
        }

        public int Id { get; set; } = 0;
        public byte[] PasswordHash { get; set; } = new byte[32];
        public byte[] PasswordSalt { get; set; } = new byte[32];
        public string Username { get; set; } = "";

        List<City> Cities { get; set; } = new List<City>();
    }
}
