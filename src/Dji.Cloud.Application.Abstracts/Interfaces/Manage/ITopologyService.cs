using Dji.Cloud.Domain.Manage;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface ITopologyService
{
    /// <summary>
    /// Get the topology list of all devices in the workspace for pilot display.
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <returns></returns>
    Task<IEnumerable<Topology>> GetDeviceTopologiesAsync(string workspaceId);

    /// <summary>
    /// Query the topology according to the gateway sn.
    /// </summary>
    /// <param name="gatewaySerialNumber">gateway serial number</param>
    /// <returns></returns>
    Task<Topology> GetDeviceTopologyAsync(string gatewaySerialNumber);
}
