using Dji.Cloud.Application.Abstracts.Interfaces.Oss;
using System.Runtime.InteropServices;
using System;
using Dji.Cloud.Domain.Media;

namespace Dji.Cloud.Application.Services.Oss;

public class MinIOService : IOssService
{
    //private MinioClient client;

    //@Override
    //public String getOssType()
    //{
    //    return OssTypeEnum.MINIO.getType();
    //}

    //@Override
    //public CredentialsDTO getCredentials()
    //{
    //    try
    //    {
    //        AssumeRoleProvider provider = new AssumeRoleProvider(OssConfiguration.endpoint, OssConfiguration.accessKey,
    //                OssConfiguration.secretKey, Math.toIntExact(OssConfiguration.expire),
    //                null, OssConfiguration.region, null, null, null, null);
    //        return new CredentialsDTO(provider.fetch(), OssConfiguration.expire);
    //    }
    //    catch (NoSuchAlgorithmException e)
    //    {
    //        log.debug("Failed to obtain sts.");
    //        e.printStackTrace();
    //    }
    //    return null;
    //}

    //@Override
    //public URL getObjectUrl(String bucket, String objectKey)
    //{
    //    try
    //    {
    //        return new URL(
    //                client.getPresignedObjectUrl(
    //                                GetPresignedObjectUrlArgs.builder()
    //                                        .method(Method.GET)
    //                                        .bucket(bucket)
    //                                        .object(objectKey)
    //                                        .expiry(Math.toIntExact(OssConfiguration.expire))
    //                                        .build()));
    //    }
    //    catch (ErrorResponseException | InsufficientDataException | InternalException |
    //            InvalidKeyException | InvalidResponseException | IOException |
    //            NoSuchAlgorithmException | XmlParserException | ServerException e) {
    //        throw new RuntimeException("The file does not exist on the OssConfiguration.");
    //    }
    //    }

    //    @Override
    //public Boolean deleteObject(String bucket, String objectKey)
    //    {
    //        try
    //        {
    //            client.removeObject(RemoveObjectArgs.builder().bucket(bucket).object(objectKey).build());
    //        }
    //        catch (MinioException | NoSuchAlgorithmException | IOException | InvalidKeyException e) {
    //        log.error("Failed to delete file.");
    //        e.printStackTrace();
    //        return false;
    //    }
    //    return true;
    //}

    //@Override
    //public InputStream getObject(String bucket, String objectKey)
    //{
    //    try
    //    {
    //        GetObjectResponse object = client.getObject(GetObjectArgs.builder().bucket(bucket).object(objectKey).build());
    //        return new ByteArrayInputStream(object.readAllBytes());
    //    }
    //    catch (ErrorResponseException | InsufficientDataException | InternalException | InvalidKeyException | InvalidResponseException | IOException | NoSuchAlgorithmException | ServerException | XmlParserException e) {
    //        e.printStackTrace();
    //    }
    //    return InputStream.nullInputStream();
    //    }

    //    @Override
    //public void putObject(String bucket, String objectKey, InputStream input)
    //    {
    //        try
    //        {
    //            client.statObject(StatObjectArgs.builder().bucket(bucket).object(objectKey).build());
    //            throw new RuntimeException("The filename already exists.");
    //        }
    //        catch (MinioException | InvalidKeyException | IOException | NoSuchAlgorithmException e) {
    //        log.info("The file does not exist, start uploading.");
    //        try
    //        {
    //            ObjectWriteResponse response = client.putObject(
    //                    PutObjectArgs.builder().bucket(bucket).object(objectKey).stream(input, input.available(), 0).build());
    //            log.info("Upload File: {}", response.etag());
    //        }
    //        catch (MinioException | IOException | InvalidKeyException | NoSuchAlgorithmException ex) {
    //            log.error("Failed to upload File {}.", objectKey);
    //            ex.printStackTrace();
    //        }
    //        }
    //    }

    //    public void createClient()
    //    {
    //        if (Objects.nonNull(this.client))
    //        {
    //            return;
    //        }
    //        this.client = MinioClient.builder()
    //                .endpoint(OssConfiguration.endpoint)
    //                .credentials(OssConfiguration.accessKey, OssConfiguration.secretKey)
    //                .region(OssConfiguration.region)
    //                .build();
    //    }
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
