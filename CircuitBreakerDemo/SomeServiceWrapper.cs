using CircuitBreakerDemo.CircuitBreaker;

namespace CircuitBreakerDemo
{
    public class SomeServiceWrapper
    {
        private readonly ICircuitBreaker circuitBreaker;

        public SomeServiceWrapper(ICircuitBreaker circuitBreaker)
        {
            this.circuitBreaker = circuitBreaker;
        }
    }
}
