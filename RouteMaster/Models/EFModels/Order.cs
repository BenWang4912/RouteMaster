namespace RouteMaster.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            AccommodationDetails = new HashSet<AccommodationDetail>();
            ActivitiesDetails = new HashSet<ActivitiesDetail>();
            ExtraServicesDetails = new HashSet<ExtraServicesDetail>();
        }
		[Display(Name = "�q��s��")]
		public int Id { get; set; }
		[Display(Name = "�q�ʤH�s��")]
		public int MemberId { get; set; }
		[Display(Name = "�Ȧ�p�e�s��")]
		public int TravelPlanId { get; set; }
		[Display(Name = "�I�ڤ覡�N��")]
		public int PaymentMethodId { get; set; }
		[Display(Name = "�I�ڪ��A")]
		public int PaymentStatus { get; set; }
		[Display(Name = "�q�榨�ߤ��")]
		[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
		public DateTime? CreateDate { get; set; }
		[Display(Name = "�`���B")]
		[DisplayFormat(DataFormatString = "{0:#,#}")]
		public int Total { get; set; }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccommodationDetail> AccommodationDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivitiesDetail> ActivitiesDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtraServicesDetail> ExtraServicesDetails { get; set; }

        public virtual Member Member { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual TravelPlan TravelPlan { get; set; }
    }
}
