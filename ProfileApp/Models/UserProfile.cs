using System;
using System.ComponentModel.DataAnnotations;

namespace ProfileApp.Models
{
    public class UserProfile
    {
        public int Id { get; set; }

        [Display(Name="نام")]
        public string FirstName { get; set; }

        [Display(Name = "نام")]
        public string LastName { get; set; }

        [Display(Name = "استان")]
        public int ProvinceId { get; set; }

        public string ProvinceName { get; set; }

        [Display(Name = "شهر")]
        public int CityId { get; set; }
        public string CityName { get; set; }

        public DateTime TimeCreated { get; set; }
    }
}
