namespace server.Models
{
    public class MoviesModel
    {
        public int id { get; set; }
        public int year { get; set; }
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public List<Actor> actors { get; set; }

        public List<Image> images { get; set; }
    }

    public class Actor
    {
        public int Id { get; set; }
        public string full_name { get; set; } = string.Empty;
    }

    public class Image
    {
        public int Id { get; set; }
        public string image_name { get; set; } = string.Empty;
        public string image_path { get; set; } = string.Empty;

        public string image_description { get; set; } = string.Empty;
    }
}