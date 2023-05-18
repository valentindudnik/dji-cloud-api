using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Dji.Cloud.Application.Extensions;

public static class EnumExtensions
{
    public static string GetName(this Enum enumType)
    {
        return enumType.GetType()?.GetMember(enumType.ToString())
                       .First()?
                       .GetCustomAttribute<DisplayAttribute>()?
                       .Name!;
    }

    public static string GetDescription(this Enum enumType)
    {
        return enumType.GetType().GetMember(enumType.ToString())
                       .First()?
                       .GetCustomAttribute<DisplayAttribute>()?
                       .Description!;
    }
}
