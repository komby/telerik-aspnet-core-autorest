using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kendo.Mvc.UI;
using ExampleModels.Models;
using System.Net;
using Kendo.Mvc.Extensions;

namespace ApiExample.Controllers
{
    [Route("api/[controller]")]
    public class ExampleController : Controller
    {

       
        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(DataSourceResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(void), 204)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> Get([DataSourceRequest]DataSourceRequest request)
        {

            //page size and most of the properties are null
            //setting page size to force pagination
            //TODO once we get the binding correct this page size setting neeeds to be removed.
            request.PageSize = 20;
            IQueryable<ExampleModel> _exampleData = InitTestData();
            DataSourceResult result = await _exampleData.ToDataSourceResultAsync(request);
            return Ok(result);

        }

        private IQueryable<ExampleModel> InitTestData()
        {
            var data = new List<ExampleModel>();


            for (int i = 0; i < 10000; i++)
            {
                data.Add(
                    new ExampleModel() {
                        ModelId = i,
                        Title = $"Some Title{i}",
                        Description = $"Description{i}",
                        Name = $"Name {i}",
                        SomeDate = new DateTime(DateTime.Now.Ticks + i*100),
                         }
                );
            }

            return data.AsQueryable();
        }
        
    }
}
