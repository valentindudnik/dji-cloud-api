namespace Dji.Cloud.Application.Abstracts.Responses.Common;

public class PaginationResponse<T>
{
    public Pagination? Pagination { get; set; }
    public IEnumerable<T>? List { get; set; }
}
