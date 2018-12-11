namespace PopcornTime_2._0.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Genre(int id, string Name)
        {
            this.Id = id;
            this.Name = Name;
        }




    }
}