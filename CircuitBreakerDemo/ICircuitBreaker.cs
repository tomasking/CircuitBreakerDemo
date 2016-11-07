using System;
using System.Threading.Tasks;

namespace CircuitBreakerDemo
{
    public interface ICircuitBreaker
    {
        Task<TResult> ExecuteAsync<TResult>(Func<Task<TResult>> task);
    }
}