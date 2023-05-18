namespace Dji.Cloud.Domain.Mqtt.Models;

[Serializable]
public enum RequestsMethodEnum
{
    //STORAGE_CONFIG_GET("storage_config_get", ChannelName.INBOUND_REQUESTS_STORAGE_CONFIG_GET),
    StorageConfigGet = 0,

    //AIRPORT_BIND_STATUS("airport_bind_status", ChannelName.INBOUND_REQUESTS_AIRPORT_BIND_STATUS),
    AirportBindStatus = 1,

    //AIRPORT_ORGANIZATION_BIND("airport_organization_bind", ChannelName.INBOUND_REQUESTS_AIRPORT_ORGANIZATION_BIND),
    AirportOrganizationBind = 2,

    //AIRPORT_ORGANIZATION_GET("airport_organization_get", ChannelName.INBOUND_REQUESTS_AIRPORT_ORGANIZATION_GET),
    AirportOrganizationGet = 3,

    //FLIGHT_TASK_RESOURCE_GET("flighttask_resource_get", ChannelName.INBOUND_REQUESTS_FLIGHT_TASK_RESOURCE_GET),
    FlightTaskResourceGet = 4,

    //CONFIG("config", ChannelName.INBOUND_REQUESTS_CONFIG),
    Config = 5,

    //UNKNOWN("Unknown", ChannelName.DEFAULT);
    Unknown = 6
}
