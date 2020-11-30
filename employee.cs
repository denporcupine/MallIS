namespace MallIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public Employee()
        {
            Rents = new HashSet<Rent>();
        }

        [Required]
        [StringLength(100)]
        public string Fio { get; set; }

        [Required]
        [StringLength(100)]
        public string Login { get; set; }

        [Required]
        [StringLength(18)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string Role { get; set; }

        [StringLength(18)]
        public string Phone { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Employee_id { get; set; }

        public byte[] Photo { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }
    }
}
