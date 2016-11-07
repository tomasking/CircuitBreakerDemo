using System;

namespace CircuitBreakerDemo.Configuration
{
    public class CircuitBreakerSettings : ICircuitBreakerSettings
    {
        public TimeSpan TimePeriodToBreakCircuitFor { get; set; } 

        public int BreakOnNumberOfExceptions { get; set; }

        public bool KillSwitchEnabled { get; set; }
    }
}