namespace Musicana.Data.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Album")]
    public partial class Album
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Songs = new HashSet<Song>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        public decimal? Discount { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Pic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Song> Songs { get; set; }
    }
}
