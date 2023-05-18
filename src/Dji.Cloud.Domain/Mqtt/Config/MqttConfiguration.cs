﻿namespace Dji.Cloud.Domain.Mqtt.Config;

public class MqttConfiguration
{
    public string? MqttAddress { get; set; }

    //@Autowired
    //private MqttPahoClientFactory mqttClientFactory;

    //@Resource(name = ChannelName.INBOUND)
    //private MessageChannel inboundChannel;

    ///**
    // * Clients of inbound message channels.
    // * @return
    // */
    //@Bean(name = "adapter")
    //public MessageProducerSupport mqttInbound()
    //{
    //    MqttClientOptions options = MqttConfiguration.getBasicClientOptions();
    //    MqttPahoMessageDrivenChannelAdapter adapter = new MqttPahoMessageDrivenChannelAdapter(
    //            options.getClientId() + "_consumer_" + System.currentTimeMillis(),
    //            mqttClientFactory, options.getInboundTopic().split(","));
    //    DefaultPahoMessageConverter converter = new DefaultPahoMessageConverter();
    //    // use byte types uniformly
    //    converter.setPayloadAsBytes(true);
    //    adapter.setConverter(converter);
    //    adapter.setQos(1);
    //    adapter.setOutputChannel(inboundChannel);
    //    return adapter;
    //}

    ///**
    // * Define a default channel to handle messages that have no effect.
    // * @return
    // */
    //@Bean
    //@ServiceActivator(inputChannel = ChannelName.DEFAULT)
    //public MessageHandler defaultInboundHandler()
    //{
    //    return message-> {
    //        log.info("The default channel does not handle messages." +
    //                "\nTopic: " + message.getHeaders().get(MqttHeaders.RECEIVED_TOPIC) +
    //                "\nPayload: " + message.getPayload());
    //    };
    //}


    //private static Map<MqttUseEnum, MqttClientOptions> mqtt;

    //public void setMqtt(Map<MqttUseEnum, MqttClientOptions> mqtt)
    //{
    //    MqttConfiguration.mqtt = mqtt;
    //}

    ///**
    // * Get the configuration options of the basic link of the mqtt client.
    // * @return
    // */
    //static MqttClientOptions getBasicClientOptions()
    //{
    //    if (!mqtt.containsKey(MqttUseEnum.BASIC))
    //    {
    //        throw new Error("Please configure the basic mqtt connection parameters first, otherwise application cannot be started.");
    //    }
    //    return mqtt.get(MqttUseEnum.BASIC);
    //}

    ///**
    // * Get the mqtt address of the basic link.
    // * @return
    // */
    //public static String getBasicMqttAddress()
    //{
    //    return getMqttAddress(getBasicClientOptions());
    //}

    ///**
    // * Splice the mqtt address according to the parameters of different clients.
    // * @param options
    // * @return
    // */
    //private static String getMqttAddress(MqttClientOptions options)
    //{
    //    StringBuilder addr = new StringBuilder()
    //            .append(options.getProtocol().getProtocolAddr())
    //            .append(options.getHost().trim())
    //            .append(":")
    //            .append(options.getPort());
    //    if ((options.getProtocol() == MqttProtocolEnum.WS || options.getProtocol() == MqttProtocolEnum.WSS)
    //            && StringUtils.hasText(options.getPath()))
    //    {
    //        addr.append(options.getPath());
    //    }
    //    return addr.toString();
    //}

    //@Bean
    //public MqttConnectOptions mqttConnectOptions()
    //{
    //    MqttClientOptions customizeOptions = getBasicClientOptions();
    //    MqttConnectOptions mqttConnectOptions = new MqttConnectOptions();
    //    mqttConnectOptions.setServerURIs(new String[] { getBasicMqttAddress() });
    //    mqttConnectOptions.setUserName(customizeOptions.getUsername());
    //    mqttConnectOptions.setPassword(StringUtils.hasText(customizeOptions.getPassword()) ?
    //            customizeOptions.getPassword().toCharArray() : new char[0]);
    //    mqttConnectOptions.setAutomaticReconnect(true);
    //    mqttConnectOptions.setKeepAliveInterval(10);
    //    return mqttConnectOptions;
    //}

    //@Bean
    //public MqttPahoClientFactory mqttClientFactory()
    //{
    //    DefaultMqttPahoClientFactory factory = new DefaultMqttPahoClientFactory();
    //    factory.setConnectionOptions(mqttConnectOptions());
    //    return factory;
    //}
}
