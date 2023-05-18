namespace Dji.Cloud.Domain.Redis;

public class RedisConfiguration
{
    //@Bean
    //public RedisTemplate<String, Object> redisTemplate(RedisConnectionFactory factory)
    //{
    //    RedisTemplate<String, Object> redisTemplate = new RedisTemplate<>();
    //    redisTemplate.setConnectionFactory(factory);

    //    ObjectMapper objectMapper = new ObjectMapper();
    //    JavaTimeModule timeModule = new JavaTimeModule();
    //    timeModule.addDeserializer(LocalDateTime.class,
    //            new LocalDateTimeDeserializer(DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss")));
    //    timeModule.addSerializer(LocalDateTime.class,
    //            new LocalDateTimeSerializer(DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss")));
    //    objectMapper.disable(MapperFeature.IGNORE_DUPLICATE_MODULE_REGISTRATIONS);
    //    objectMapper.registerModules(timeModule);
    //    objectMapper.activateDefaultTyping(objectMapper.getPolymorphicTypeValidator(),
    //            ObjectMapper.DefaultTyping.NON_FINAL, JsonTypeInfo.As.PROPERTY);

    //    objectMapper.setPropertyNamingStrategy(PropertyNamingStrategy.SNAKE_CASE);
    //    objectMapper.setSerializationInclusion(JsonInclude.Include.NON_EMPTY);
    //    objectMapper.setSerializationInclusion(JsonInclude.Include.NON_NULL);


    //    StringRedisSerializer serializer = new StringRedisSerializer();
    //redisTemplate.setKeySerializer(serializer);
    //    redisTemplate.setHashKeySerializer(serializer);

    //    GenericJackson2JsonRedisSerializer jsonRedisSerializer = new GenericJackson2JsonRedisSerializer(objectMapper);
    //redisTemplate.setValueSerializer(jsonRedisSerializer);
    //    redisTemplate.setHashValueSerializer(jsonRedisSerializer);
    //    redisTemplate.afterPropertiesSet();
    //    return redisTemplate;

    //}
}
