using System.Collections.Generic;

namespace VKontakte.Net.Models
{
    public class UsersCareer
    {
        public int? CityId { get; set; } 

        public string Company { get; set; } 

        public int? CountryId { get; set; } 

        public int? From { get; set; } 

        public int? GroupId { get; set; } 

        public int? Id { get; set; } 

        public string Position { get; set; } 

        public int? Until { get; set; } 
    }

    public class UsersCropPhoto
    {
        public UsersCropPhotoCrop Crop { get; set; } 

        public PhotosPhoto Photo { get; set; } 

        public UsersCropPhotoRect Rect { get; set; } 
    }

    public class UsersCropPhotoCrop
    {
        public double? X { get; set; } 

        public double? X2 { get; set; } 

        public double? Y { get; set; } 

        public double? Y2 { get; set; } 
    }

    public class UsersCropPhotoRect
    {
        public double? X { get; set; } 

        public double? X2 { get; set; } 

        public double? Y { get; set; } 

        public double? Y2 { get; set; } 
    }

    public class UsersExports
    {
        public int? Facebook { get; set; } 

        public int? Livejournal { get; set; } 

        public int? Twitter { get; set; } 
    }

    public class UsersFields
    {
    }

    public class UsersLastSeen
    {
        public int? Platform { get; set; } 

        public int? Time { get; set; } 
    }

    public class UsersMilitary
    {
        public int? CountryId { get; set; } 

        public int? From { get; set; } 

        public int? Id { get; set; } 

        public string Unit { get; set; } 

        public int? UnitId { get; set; } 

        public int? Until { get; set; } 
    }

    public class UsersOccupation
    {
        public int? Id { get; set; } 

        public string Name { get; set; } 

        public string Type { get; set; } 
    }

    public class UsersPersonal
    {
        public int? Alcohol { get; set; } 

        public string InspiredBy { get; set; } 

        public IEnumerable<object> Langs { get; set; } 

        public int? LifeMain { get; set; } 

        public int? PeopleMain { get; set; } 

        public int? Political { get; set; } 

        public string Religion { get; set; } 

        public int? Smoking { get; set; } 
    }

    public class UsersRelative
    {
        public string BirthDate { get; set; } 

        public int? Id { get; set; } 

        public string Name { get; set; } 

        public string Type { get; set; } 
    }

    public class UsersSchool
    {
        public int? City { get; set; } 

        public string Class { get; set; } 

        public int? Country { get; set; } 

        public string Id { get; set; } 

        public string Name { get; set; } 

        public int? Type { get; set; } 

        public string TypeStr { get; set; } 

        public int? YearFrom { get; set; } 

        public int? YearGraduated { get; set; } 

        public int? YearTo { get; set; } 
    }

    public class UsersUniversity
    {
        public int? Chair { get; set; } 

        public string ChairName { get; set; } 

        public int? City { get; set; } 

        public int? Country { get; set; } 

        public string EducationForm { get; set; } 

        public string EducationStatus { get; set; } 

        public int? Faculty { get; set; } 

        public string FacultyName { get; set; } 

        public int? Graduation { get; set; } 

        public int? Id { get; set; } 

        public string Name { get; set; } 
    }

    public class UsersUser
    {
    }

    public class UsersUserCounters
    {
        public int? Albums { get; set; } 

        public int? Audios { get; set; } 

        public int? Followers { get; set; } 

        public int? Friends { get; set; } 

        public int? Gifts { get; set; } 

        public int? Groups { get; set; } 

        public int? Notes { get; set; } 

        public int? OnlineFriends { get; set; } 

        public int? Pages { get; set; } 

        public int? Photos { get; set; } 

        public int? Subscriptions { get; set; } 

        public int? UserPhotos { get; set; } 

        public int? UserVideos { get; set; } 

        public int? Videos { get; set; } 
    }

    public class UsersUserFull
    {
    }

    public class UsersUserMin
    {
        public string Deactivated { get; set; } 

        public string FirstName { get; set; } 

        public int? Hidden { get; set; } 

        public int? Id { get; set; } 

        public string LastName { get; set; } 
    }

    public class UsersUsersArray
    {
        public int? Count { get; set; } 

        public IEnumerable<object> Items { get; set; } 
    }

    public class UsersUserType
    {
    }

    public class UsersUserXtrCounters
    {
    }

    public class UsersUserXtrType
    {
    }
}
