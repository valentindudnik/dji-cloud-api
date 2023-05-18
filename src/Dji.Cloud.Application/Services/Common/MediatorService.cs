using Dji.Cloud.Application.Abstracts.Interfaces.Common;
using MediatR;

namespace Dji.Cloud.Application.Services.Common;

public class MediatorService : IMediatorService
{
    private readonly IMediator _mediator;

    public MediatorService(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<TResponse> SendAsync<TResponse>(TResponse request) where TResponse : IRequest<TResponse>
    {
        var response = await _mediator.Send(request);

        return response;
    }

    public async Task SendAsync<TResponse>(IRequest request)
    {
        await _mediator.Send(request);
    }
}
