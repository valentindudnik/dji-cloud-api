using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Dji.Cloud.Domain.Enums;

[Serializable]
public enum OssTypes
{
    [Display(Name = "Ali", Description = "Ali"),
     EnumMember(Value = "Ali")]
    Aliyun = 0,
    
    [Display(Name = "Aws", Description = "Aws"),
     EnumMember(Value = "Aws")]
    Aws = 1,

    [Display(Name = "Minio", Description = "Minio"),
     EnumMember(Value = "Minio")]
    Minio = 2
}
