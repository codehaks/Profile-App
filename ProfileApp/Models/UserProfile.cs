using System;

namespace ProfileApp.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
