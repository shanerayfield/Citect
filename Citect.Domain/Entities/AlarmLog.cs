using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Citect.Domain.Entities
{
    public class LogEntry
    {
        public string LocalTimeDate { get; set; }
        public string Equip{ get; set; }
        public string Name{ get; set; }
        public string Desc { get; set; }
        public string STate { get; set; }
        public string Type { get; set; }
    }
}