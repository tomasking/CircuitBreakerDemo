using System;

namespace CircuitBreakerDemo
{
    public interface ICircuitBreakerSettings
    {
        TimeSpan TimePeriodToBreakCircuitFor { get; set; }

        int BreakOnNumberOfExceptions { get; set; }

        bool KillSwitchEnabled { get; set; }
    }
}