using Dji.Cloud.Application.Abstracts.Interfaces.Oss;
using Dji.Cloud.Domain.Media;

namespace Dji.Cloud.Application.Services.Oss;

public class AliyunOssService : IOssService
{
    //private OSS ossClient;

    //@Override
    //public String getOssType()
    //{
    //    return OssTypeEnum.ALIYUN.getType();
    //}

    //@Override
    //public CredentialsDTO getCredentials()
    //{

    //    try
    //    {
    //        DefaultProfile profile = DefaultProfile.getProfile(
    //                OssConfiguration.region, OssConfiguration.accessKey, OssConfiguration.secretKey);
    //        IAcsClient client = new DefaultAcsClient(profile);

    //        AssumeRoleRequest request = new AssumeRoleRequest();
    //        request.setDurationSeconds(OssConfiguration.expire);
    //        request.setRoleArn(OssConfiguration.roleArn);
    //        request.setRoleSessionName(OssConfiguration.roleSessionName);

    //        AssumeRoleResponse response = client.getAcsResponse(request);
    //        return new CredentialsDTO(response.getCredentials(), OssConfiguration.expire);

    //    }
    //    catch (ClientException e)
    //    {
    //        log.debug("Failed to obtain sts.");
    //        e.printStackTrace();
    //    }
    //    return null;
    //}

    //@Override
    //public URL getObjectUrl(String bucket, String objectKey)
    //{
    //    // First check if the object can be fetched.
    //    boolean isExist = ossClient.doesObjectExist(bucket, objectKey);
    //    if (!isExist)
    //    {
    //        throw new OSSException("The object does not exist.");
    //    }

    //    return ossClient.generatePresignedUrl(bucket, objectKey,
    //            new Date(System.currentTimeMillis() + OssConfiguration.expire * 1000));
    //}

    //@Override
    //public Boolean deleteObject(String bucket, String objectKey)
    //{
    //    if (!ossClient.doesObjectExist(bucket, objectKey))
    //    {
    //        return true;
    //    }
    //    ossClient.deleteObject(bucket, objectKey);
    //    return true;
    //}

    //@Override
    //public InputStream getObject(String bucket, String objectKey)
    //{
    //    return ossClient.getObject(bucket, objectKey).getObjectContent();
    //}

    //@Override
    //public void putObject(String bucket, String objectKey, InputStream input)
    //{
    //    if (ossClient.doesObjectExist(bucket, objectKey))
    //    {
    //        throw new RuntimeException("The filename already exists.");
    //    }
    //    PutObjectResult objectResult = ossClient.putObject(new PutObjectRequest(bucket, objectKey, input, new ObjectMetadata()));
    //    log.info("Upload File: {}", objectResult.getETag());
    //}

    //public void createClient()
    //{
    //    if (Objects.nonNull(this.ossClient))
    //    {
    //        return;
    //    }
    //    this.ossClient = new OSSClientBuilder()
    //            .build(OssConfiguration.endpoint, OssConfiguration.accessKey, OssConfiguration.secretKey);
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
