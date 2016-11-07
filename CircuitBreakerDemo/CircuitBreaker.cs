using System;
using System.Threading.Tasks;

using Polly;
using Polly.CircuitBreaker;

namespace CircuitBreakerDemo
{
    public class CircuitBreaker : ICircuitBreaker
    {
        private readonly ICircuitBreakerSettings circuitBreakerSettings;

        private Policy policy;

        private bool isKillSwitchEnabled;

        public CircuitBreaker(ICircuitBreakerSettings circuitBreakerSettings)
        {
            this.circuitBreakerSettings = circuitBreakerSettings;
            ConfigurePolicy();
            //// this.circuitBreakerSettings.RegisterForChange(ConfigurePolicy);
        }

        public async Task<TResult> ExecuteAsync<TResult>(Func<Task<TResult>> task)
        {
            if (isKillSwitchEnabled)
            {
                throw new BrokenCircuitException("Kill Switch Enabled");
            }

            return await policy.ExecuteAsync(task);
        }

        private void ConfigurePolicy()
        {
            isKillSwitchEnabled = circuitBreakerSettings.KillSwitchEnabled;
            policy = Policy.Handle<Exception>()
                .CircuitBreakerAsync(circuitBreakerSettings.BreakOnNumberOfExceptions, circuitBreakerSettings.TimePeriodToBreakCircuitFor);
        }
    }
}