using System;

namespace CircuitBreakerDemo
{
    public class CircuitBreakerSettings : ICircuitBreakerSettings
    {
        public TimeSpan TimePeriodToBreakCircuitFor { get; set; } 

        public int BreakOnNumberOfExceptions { get; set; }

        public bool KillSwitchEnabled { get; set; }
    }
}