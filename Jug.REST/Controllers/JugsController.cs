using Jug.REST.Models.Helpers;
using Jug.REST.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Jug.REST.Controllers
{
    [EnableCors("*","*","*")]
    public class JugsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetSolution(int jug1,int jug2,int final)
        {
            
            Jug.REST.Models.Jug A = new Models.Jug(jug1);
            Jug.REST.Models.Jug B = new Models.Jug(jug2);
            if (Solution.IsSolutionPossible(A, B, final))
            {
                Result result1 = Solution.Solve(A, B, final);
                Result result2 = Solution.Solve(new Models.Jug(jug2), new Models.Jug(jug1), final);
                List<List<string>> newResult = new List<List<string>>();
                newResult.Add(result1.Status);
                newResult.Add(result2.Status);
                return Ok(newResult);
            }
            return BadRequest();
        }

        
    }
}