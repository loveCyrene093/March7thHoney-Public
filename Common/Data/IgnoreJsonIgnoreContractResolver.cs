using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace March7thHoney.Data;

public class IgnoreJsonIgnoreContractResolver : DefaultContractResolver
{
	protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
	{
		JsonProperty jsonProperty = base.CreateProperty(member, memberSerialization);
		jsonProperty.Ignored = false;
		return jsonProperty;
	}
}
