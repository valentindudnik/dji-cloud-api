using Dji.Cloud.Domain.Media;

namespace Dji.Cloud.Application.Abstracts.Interfaces.Oss;

public interface IOssService
{
    /// <summary>
    /// Get oss type
    /// </summary>
    /// <returns></returns>
    Task<string> GetOssTypeAsync();

    /// <summary>
    /// Get temporary credentials.
    /// </summary>
    /// <returns>credentials</returns>
    Task<Credentials> GetCredentialsAsync();

    /// <summary>
    /// Get the address of the object based on the bucket name and the object name.
    /// </summary>
    /// <param name="bucket">bucket name</param>
    /// <param name="objectKey">object key name</param>
    /// <returns>uri</returns>
    Task<Uri> GetObjectUriAsync(string bucket, string objectKey);

    /// <summary>
    /// Deletes the object in the storage bucket.
    /// </summary>
    /// <param name="bucket">bucket name</param>
    /// <param name="objectKey">object key</param>
    /// <returns>status</returns>
    Task<bool> DeleteObjectAsync(string bucket, string objectKey);

    ///**
    // * Get the contents of an object.
    // * @param bucket
    // * @param objectKey
    // * @return
    // */
    //InputStream getObject(String bucket, String objectKey);

    //void putObject(String bucket, String objectKey, InputStream input);

    //void createClient();
}
