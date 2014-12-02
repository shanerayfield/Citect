using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Citect.Domain.DataAccess;

namespace Citect.Models
{
    public class AlarmLogView
    {
        public AlarmLog alarmLog;

        public AlarmLogView(AlarmLog _alarmLog)
        {
            alarmLog = _alarmLog;
        }

    }
}