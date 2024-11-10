namespace WisardLib
{
    public class Location
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Discription { get; set; }
        public List<Location> WaysOut { get; set; } = new List<Location>();
        public string Img { get; set; }

    }
}