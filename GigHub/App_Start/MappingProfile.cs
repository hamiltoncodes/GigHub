using AutoMapper;
using GigHub.Controllers.Api;
using GigHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHub.App_Start
{
	public class MappingProfile :Profile
	{
		public MappingProfile()
		{
			var gigMap = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<ApplicationUser, UserDto>();
				cfg.CreateMap<Gig, GigDto>();
				cfg.CreateMap<Notification, NotificationDto>();
			});
		}
	}
}