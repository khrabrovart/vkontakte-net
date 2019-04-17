
namespace VKontakte.Net.Models
{
    public class DatabaseCity
    {
    }

    public class DatabaseFaculty
    {
        public int? Id { get; set; } 

        public string Title { get; set; } 
    }

    public class DatabaseRegion
    {
        public int? Id { get; set; } 

        public string Title { get; set; } 
    }

    public class DatabaseSchool
    {
        public int? Id { get; set; } 

        public string Title { get; set; } 
    }

    public class DatabaseStation
    {
        public int? CityId { get; set; } 

        public string Color { get; set; } 

        public int? Id { get; set; } 

        public string Name { get; set; } 
    }

    public class DatabaseUniversity
    {
        public int? Id { get; set; } 

        public string Title { get; set; } 
    }
}
