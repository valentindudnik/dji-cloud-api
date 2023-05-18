using MediatR;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Common;

public interface IMediatorService
{
    Task<TResponse> SendAsync<TResponse>(TResponse request) where TResponse : IRequest<TResponse>;
    Task SendAsync<TResponse>(IRequest request);
}
