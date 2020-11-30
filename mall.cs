namespace MallIS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mall
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mall()
        {
            Pavilions = new HashSet<Pavilion>();
            Rents = new HashSet<Rent>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Mall_id { get; set; }

        [Required]
        [StringLength(100)]
        public string Mall_name { get; set; }

        [Required]
        [StringLength(100)]
        public string Status { get; set; }

        public short? Pavilions_quantity { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public decimal Added_value_ratio { get; set; }

        public byte Floors { get; set; }

        public byte[] Photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pavilion> Pavilions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
