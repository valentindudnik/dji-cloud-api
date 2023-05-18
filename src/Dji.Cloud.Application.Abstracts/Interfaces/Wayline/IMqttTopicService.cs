namespace Dji.Cloud.Application.Abstracts.Interfaces.Wayline;

public interface IMqttTopicService
{
    Task SubscribeAsync();

  //  /**
  //* Subscribe to a specific topic.
  //* @param topic target
  //*/
  //  void subscribe(@Header(MqttHeaders.TOPIC) String topic);

  //  /**
  //   * Subscribe to a specific topic using a specific qos.
  //   * @param topic target
  //   * @param qos   qos
  //   */
  //  void subscribe(@Header(MqttHeaders.TOPIC) String topic, int qos);

  //  /**
  //   * Unsubscribe from a specific topic.
  //   * @param topic target
  //   */
  //  void unsubscribe(@Header(MqttHeaders.TOPIC) String topic);

  //  /**
  //   * Get all the subscribed topics.
  //   * @return topics
  //   */
  //  String[] getSubscribedTopic();
}
