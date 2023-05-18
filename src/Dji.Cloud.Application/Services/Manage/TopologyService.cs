using AutoMapper;
using Dji.Cloud.Application.Abstracts.Interfaces.Manage;
using Dji.Cloud.Domain.Manage;
using Microsoft.Extensions.Logging;

namespace Dji.Cloud.Application.Services.Manage;

public class TopologyService : ITopologyService
{
    private readonly IDeviceService _deviceService;

    private readonly IMapper _mapper;
    private readonly ILogger _logger;

    public TopologyService(IDeviceService deviceService, IMapper mapper, ILogger logger)
    {
        _deviceService = deviceService;

        _mapper = mapper;
        _logger = logger;
    }

    /// <summary>
    /// Get device topologies
    /// </summary>
    /// <param name="workspaceId">workspace id</param>
    /// <returns>The topologies</returns>
    public async Task<IEnumerable<Topology>> GetDeviceTopologiesAsync(string workspaceId)
    {
        var result = new List<Topology>();

        // Query the information of all gateway devices in the workspace.
        var deviceEntities = await _deviceService.GetDevicesAsync(workspaceId);

        foreach (var deviceEntity in deviceEntities)
        {
            var deviceTopology = await GetDeviceTopologyAsync(deviceEntity.DeviceSerialNumber!);
            result.Add(deviceTopology);
        }

        return result;
    }

    /// <summary>
    /// Get device topology by gateway serial number
    /// </summary>
    /// <param name="serialNumber">The serial number</param>
    /// <returns>The topology</returns>
    public async Task<Topology> GetDeviceTopologyAsync(string serialNumber)
    {
        var device = await _deviceService.GetDeviceAsync(serialNumber);

        // TODO: 

        // Query the topology data of the drone based on the drone sn.

        return null;
    }

    //public Optional<TopologyDTO> getDeviceTopologyByGatewaySn(String gatewaySn)
    //{
    //    Optional<DeviceDTO> dtoOptional = deviceService.getDeviceBySn(gatewaySn);
    //    if (dtoOptional.isEmpty())
    //    {
    //        return Optional.empty();
    //    }
    //    List<TopologyDeviceDTO> parents = new ArrayList<>();
    //    DeviceDTO device = dtoOptional.get();
    //    TopologyDeviceDTO gateway = deviceService.deviceConvertToTopologyDTO(device);
    //    parents.add(gateway);

    //    // Query the topology data of the drone based on the drone sn.
    //    Optional<TopologyDeviceDTO> deviceTopo = deviceService.getDeviceTopoForPilot(device.getChildDeviceSn());
    //    List<TopologyDeviceDTO> deviceTopoList = new ArrayList<>();
    //    deviceTopo.ifPresent(deviceTopoList::add);

    //    return Optional.ofNullable(TopologyDTO.builder().parents(parents).hosts(deviceTopoList).build());
    //}
}
