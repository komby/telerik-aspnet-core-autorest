using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kendo.Mvc.UI;
using WebAutorestExample.Models;
using Kendo.Mvc.Extensions;
using WebAutorestExample.ApiClient;
using AutoMapper;

namespace WebAutorestExample.Controllers
{
    public class GridController : Controller
    {
        private IExampleApplicationAPI _apiClient;

        public GridController(IExampleApplicationAPI apiclient)
        {
            this._apiClient = apiclient;
        }
		public async  Task<ActionResult> Example_Read([DataSourceRequest]DataSourceRequest request)
		{
            var results = await _apiClient.ApiExampleGetAsync(request);

            var dsResult= Mapper.Map<DataSourceResult>(results);

        
			return Json(dsResult);
		}
	}
}
