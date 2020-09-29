using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyAngularMaterialApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataProviderController : ControllerBase
    {
        public DataProviderController()
        {
             
        }
        
        [HttpGet("process-list")]
        public IEnumerable<Process> GetProcesses()
        {
            var list = System.Diagnostics.Process.GetProcesses().Select(a => 
            new Process() { Id = a.Id, BasePriority = a.BasePriority , MachineName = a.MachineName , MainWindowTitle = a.MainWindowTitle , SessionId = a.SessionId }
            
            ).ToList();
              return list; 
        }
    }
}
