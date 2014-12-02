using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Citect.Domain.Entities;

namespace Citect.Domain.DataAccess
{
    public class AlarmLog
    {
        List<LogEntry> log = new List<LogEntry>();

        public AlarmLog()
        {
            for (int i = 0; i < 10; i++)
            {
                log.Add(new LogEntry { LocalTimeDate = "2014/10/10 12:12:0" + i, Name = "Test Name " + i, Desc = "Test Desc" + i, Equip = "Test Equip " + i, STate = "OFF", Type = "Acknowledged" });
            }

        }

        public List<LogEntry> GetLog()
        {
            return log;
        }

        public int GetLogLen()
        {
            return log.Count;
        }
    }
}