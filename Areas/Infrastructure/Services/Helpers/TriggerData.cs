﻿using System;
using Quartz;

namespace PikaCore.Areas.Infrastructure.Services.Helpers
{
    public class TriggerData
    {
        public TriggerIdentity TriggerIdentity { get; set; }

        public bool ShouldStartNow { get; set; } = true;

        public IScheduleBuilder ScheduleBuilder { get; set; }

        public DateTimeOffset When { get; set; } = DateTimeOffset.Now;
    }
}
