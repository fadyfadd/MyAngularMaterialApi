using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAngularMaterialApi
{
    public class Process
    {
        public Int32 BasePriority { set; get; } 
        public Int32 Id { set; get; }
        public String MachineName { set; get; }
        public DateTime? ExitTime { set; get; }
        public String MainWindowTitle { set; get; }
        public Boolean HasExisted { set; get; }
        public Int32? SessionId { set; get; }
    }
}
