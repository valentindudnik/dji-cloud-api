using AutoMapper;
using Dji.Cloud.Application.Abstracts.Interfaces.Common;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Dji.Cloud.Application.Services.Common;

public class MediatorService : IMediatorService
{
    private readonly IMediator _mediator;

    private readonly IMapper _mapper;
    private readonly ILogger<MediatorService> _logger;

    public MediatorService(IMediator mediator,
                          IMapper mapper,
                          ILogger<MediatorService> logger)
    {
        _mediator = mediator;

        _mapper = mapper;
        _logger = logger;
    }

    public async Task SendAsync<TRequest>(TRequest request) where TRequest : IRequest<Unit>
    {
        _logger.LogInformation($"{nameof(SendAsync)}");

        var response = await _mediator.Send(request);

        _logger.LogInformation($"Request was send successfully.");
    }

    public async Task<TResponse> SendAsync<TRequest, TResponse>(TRequest request) where TRequest : IRequest<TResponse>
                                                                                  where TResponse : class
    {
        _logger.LogInformation($"{nameof(SendAsync)}");

        var response = await _mediator.Send(request);

        _logger.LogInformation($"Request was send successfully.");

        return response;
    }

    public async Task<TResponse> SendAsync<TInputRequest, TRequest, TResponse>(TInputRequest inputRequest) where TInputRequest : class
                                                                                                           where TRequest : IRequest<TResponse>
                                                                                                           where TResponse : class
    {
        _logger.LogInformation($"{nameof(SendAsync)}");

        var request = _mapper.Map<TRequest>(inputRequest);

        var response = await _mediator.Send(request);

        _logger.LogInformation($"Request was send successfully.");

        return response;
    }
}
