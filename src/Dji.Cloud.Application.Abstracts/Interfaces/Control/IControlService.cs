using Dji.Cloud.Application.Abstracts.Requests.Control;
using Dji.Cloud.Application.Abstracts.Responses.Control;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Control;

public interface IControlService
{
    ///**
    //* Remotely debug the dock via commands.
    //* @param sn
    //* @param serviceIdentifier
    //* @param param
    //* @return
    //*/
    Task<RemoteResponse> ControlDockAsync(string serialNumber, string serviceIdentifier, RemoteDebugRequest request);

    ///**
    // * Handles multi-state command progress information.
    // * @param receiver
    // * @param headers
    // */
    //void handleControlProgress(CommonTopicReceiver receiver, MessageHeaders headers);
}
