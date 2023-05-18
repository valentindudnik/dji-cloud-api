namespace Dji.Cloud.Application.Abstracts.Interfaces.Manage;

public interface IRequestsConfigService
{
    /// <summary>
    /// Get the parameters required by config method.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <returns></returns>
    Task<TEntity> GetConfigAsync<TEntity>() where TEntity : class;
}
