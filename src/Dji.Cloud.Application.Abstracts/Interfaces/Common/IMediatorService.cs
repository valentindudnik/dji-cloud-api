using MediatR;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Common;

public interface IMediatorService
{
    Task SendAsync<TRequest>(TRequest request) where TRequest : IRequest<Unit>;

    Task<TResponse> SendAsync<TRequest, TResponse>(TRequest request) where TRequest : IRequest<TResponse>
                                                                     where TResponse : class;

    Task<TResponse> SendAsync<TInputRequest, TRequest, TResponse>(TInputRequest request) where TInputRequest : class
                                                                                         where TRequest : IRequest<TResponse>
                                                                                         where TResponse : class;
}
