using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OLNPCLEFANNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OLNPCLEFANNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTE5QQ0xFRkFOTi5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIlUKC09M" + "TlBDTEVGQU5OEiAKCWNvc3RfZGF0YRgBIAEoCzINLkl0ZW1Db3N0RGF0YRIT" + "CgtLQ0FKRkxBTU1BQxgGIAEoAhIPCgdidWZmX2lkGAsgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OLNPCLEFANN), OLNPCLEFANN.Parser, new string[3] { "CostData", "KCAJFLAMMAC", "BuffId" }, null, null, null, null)
		}));
	}
}
