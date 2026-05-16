using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ActiveFarmElementCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ActiveFarmElementCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxBY3RpdmVGYXJtRWxlbWVudENzUmVxLnByb3RvIk8KFkFjdGl2ZUZhcm1F" + "bGVtZW50Q3NSZXESEwoLd29ybGRfbGV2ZWwYASABKA0SDQoFQ291bnQYByAB" + "KA0SEQoJZW50aXR5X2lkGAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ActiveFarmElementCsReq), ActiveFarmElementCsReq.Parser, new string[3] { "WorldLevel", "Count", "EntityId" }, null, null, null, null)
		}));
	}
}
