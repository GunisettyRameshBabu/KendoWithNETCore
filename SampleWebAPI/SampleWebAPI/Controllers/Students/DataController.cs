using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Queries.Requests;
using SampleWebAPI.Queries.Responses;

namespace SampleWebAPI.Controllers.Students
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetStudent()
        {
            // Note : Custom Middleware added to handle the exceptions globally


            var result = await Mediator.Send(new GetStudentRequestQuery());
            return Ok(new { students = result });
        }
    }
}
