namespace RouteMaster.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner()
        {
            Accommodations = new HashSet<Accommodation>();
        }

        public int Id { get; set; }

        [Display(Name = "�W")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

		[Display(Name = "�m")]
		[Required]
        [StringLength(50)]
        public string LastName { get; set; }

		[Display(Name = "�H�c")]
		[Required]
        [StringLength(255)]
        public string Email { get; set; }


        [Required]
        [StringLength(255)]
        public string EncryptedPassword { get; set; }

		[Display(Name = "���U���")]
		public DateTime CreateDate { get; set; }

		[Display(Name = "�ҥ�")]
		public bool IsConfirmed { get; set; }


        public string ConfirmCode { get; set; }

		[Display(Name = "���v")]
		public bool? IsSuspended { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accommodation> Accommodations { get; set; }
    }
}
