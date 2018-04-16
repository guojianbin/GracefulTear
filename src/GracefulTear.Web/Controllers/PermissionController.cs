﻿using GracefulTear.Core.Domains.Repositories;
using GracefulTear.Core.Services.Role;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GracefulTear.Web.Controllers
{
	public class PermissionController : Controller
	{
		private readonly IRoleService roleService;

		public PermissionController(IRoleService roleService)
		{
			this.roleService = roleService;
		}

		[HttpGet]
		public IActionResult Index([FromQuery]PaginationQuery input)
		{
			return View(roleService.Find(input));
		}
	}
}