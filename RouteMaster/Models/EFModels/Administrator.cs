namespace RouteMaster.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Administrator
    {
        public int Id { get; set; }

        [Display(Name ="�޲z�̼h��")]
        public int? PermissionId { get; set; }

		[Display(Name = "�W")]
		[Required]
        [StringLength(50)]
        public string FirstName { get; set; }

		[Display(Name = "�m")]
		[Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string EncryptedPassword { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public DateTime CreateDate { get; set; }

        public string ConfirmCode { get; set; }

        public bool? IsSuspended { get; set; }

        public virtual Permission Permission { get; set; }
    }
}
