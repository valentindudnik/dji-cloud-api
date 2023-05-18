using Dji.Cloud.Application.Abstracts.Interfaces.Oss;
using Dji.Cloud.Domain.Media;

namespace Dji.Cloud.Application.Services.Oss;

public class AmazonS3Service : IOssService
{
    //private AmazonS3 client;

    //@Override
    //public String getOssType()
    //{
    //    return OssTypeEnum.AWS.getType();
    //}

    //@Override
    //public CredentialsDTO getCredentials()
    //{
    //    AWSSecurityTokenService stsClient = AWSSecurityTokenServiceClientBuilder.standard()
    //            .withCredentials(new AWSStaticCredentialsProvider(
    //                    new BasicAWSCredentials(OssConfiguration.accessKey, OssConfiguration.secretKey)))
    //            .withRegion(OssConfiguration.region).build();

    //    AssumeRoleRequest request = new AssumeRoleRequest()
    //            .withRoleArn(OssConfiguration.roleArn)
    //            .withRoleSessionName(OssConfiguration.roleSessionName)
    //            .withDurationSeconds(Math.toIntExact(OssConfiguration.expire));
    //    AssumeRoleResult result = stsClient.assumeRole(request);
    //    Credentials credentials = result.getCredentials();
    //    return new CredentialsDTO(credentials);
    //}

    //@Override
    //public URL getObjectUrl(String bucket, String objectKey)
    //{
    //    return client.generatePresignedUrl(bucket, objectKey,
    //            new Date(System.currentTimeMillis() + OssConfiguration.expire * 1000), HttpMethod.GET);
    //}

    //@Override
    //public Boolean deleteObject(String bucket, String objectKey)
    //{
    //    if (!client.doesObjectExist(bucket, objectKey))
    //    {
    //        return true;
    //    }
    //    client.deleteObject(bucket, objectKey);
    //    return true;
    //}

    //public InputStream getObject(String bucket, String objectKey)
    //{
    //    return client.getObject(bucket, objectKey).getObjectContent().getDelegateStream();
    //}

    //@Override
    //public void putObject(String bucket, String objectKey, InputStream input)
    //{
    //    if (client.doesObjectExist(bucket, objectKey))
    //    {
    //        throw new RuntimeException("The filename already exists.");
    //    }
    //    PutObjectResult objectResult = client.putObject(new PutObjectRequest(bucket, objectKey, input, new ObjectMetadata()));
    //    log.info("Upload File: {}", objectResult.toString());
    //}

    //public void createClient()
    //{
    //    if (Objects.nonNull(this.client))
    //    {
    //        return;
    //    }
    //    this.client = AmazonS3ClientBuilder.standard()
    //            .withCredentials(
    //                    new AWSStaticCredentialsProvider(
    //                            new BasicAWSCredentials(OssConfiguration.accessKey, OssConfiguration.secretKey)))
    //            .withRegion(OssConfiguration.region)
    //            .build();
    //}

    ///**
    // * Configuring cross-origin resource sharing
    // */
    //@PostConstruct
    //private void configCORS()
    //{
    //    if (!OssConfiguration.enable || !OssTypeEnum.AWS.getType().equals(OssConfiguration.provider))
    //    {
    //        return;
    //    }
    //    List<CORSRule.AllowedMethods> allowedMethods = new ArrayList<>();
    //    allowedMethods.add(CORSRule.AllowedMethods.GET);
    //    allowedMethods.add(CORSRule.AllowedMethods.POST);
    //    allowedMethods.add(CORSRule.AllowedMethods.DELETE);

    //    CORSRule rule = new CORSRule()
    //            .withId("CORSAccessRule")
    //            .withAllowedOrigins(List.of("*"))
    //            .withAllowedHeaders(List.of(AuthInterceptor.PARAM_TOKEN))
    //            .withAllowedMethods(allowedMethods);

    //    client.setBucketCrossOriginConfiguration(OssConfiguration.bucket,
    //            new BucketCrossOriginConfiguration().withRules(rule));

    //}
    public Task<bool> DeleteObjectAsync(string bucket, string objectKey)
    {
        throw new NotImplementedException();
    }

    public Task<Credentials> GetCredentialsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Uri> GetObjectUriAsync(string bucket, string objectKey)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetOssTypeAsync()
    {
        throw new NotImplementedException();
    }
}
