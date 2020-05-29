using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class Owner
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "First name must not be more than 20 char")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Last name must not be more than 20 char")]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => this.FirstName + " " + this.LastName;

        [Required]
        [StringLength(20, ErrorMessage = "Street must not be more than 20 char")]
        public string Street { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "City must not be more than 20 char")]
        public string City { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Name must not be more than 20 char")]
        public string Occupation { get; set; }

        public ICollection<Pet> Enrollments { get; set; }
    }
}