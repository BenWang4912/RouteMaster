﻿using RouteMaster.Models.EFModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RouteMaster.Models.ViewModels
{
	public class AccomodationDetailsVM
	{
		public int Id { get; set; }

		public int OrderId { get; set; }

		public int AccommodationId { get; set; }

		[Required]
		public string AccommodationName { get; set; }

		[Required]
		public string RoomType { get; set; }

		[Required]
		public string RoomName { get; set; }

		public DateTime CheckIn { get; set; }

		public DateTime CheckOut { get; set; }

		public int RoomPrice { get; set; }

		public virtual Accommodation Accommodation { get; set; }

		public virtual Order Order { get; set; }
	}
}