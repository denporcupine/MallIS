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
        public string FIO { get; set; }

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
        public int Employee_id { get; set; }

        public byte[] Photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
