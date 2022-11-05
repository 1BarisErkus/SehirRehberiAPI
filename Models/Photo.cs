namespace SehirRehberiAPI.Models
{
    public class Photo
    {
        public int Id { get; set; } = 0;
        public int CityId { get; set; } = 0;
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public string Description { get; set; } = "";
        public bool IsMain { get; set; } = false;
        public string Url { get; set; } = "";
        public string PublicId { get; set; } = "";

        public City City{ get; set; } = new City();
    }
}
