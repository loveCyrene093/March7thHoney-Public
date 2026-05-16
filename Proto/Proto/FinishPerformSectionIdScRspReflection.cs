using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishPerformSectionIdScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishPerformSectionIdScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiFGaW5pc2hQZXJmb3JtU2VjdGlvbklkU2NSc3AucHJvdG8aDkl0ZW1MaXN0";
		buffer[1] = "LnByb3RvGhFNZXNzYWdlSXRlbS5wcm90byJ+ChtGaW5pc2hQZXJmb3JtU2Vj";
		buffer[2] = "dGlvbklkU2NSc3ASGQoGcmV3YXJkGAEgASgLMgkuSXRlbUxpc3QSDwoHcmV0";
		buffer[3] = "Y29kZRgGIAEoDRIfCglpdGVtX2xpc3QYDSADKAsyDC5NZXNzYWdlSXRlbRIS";
		buffer[4] = "CgpzZWN0aW9uX2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[5] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			MessageItemReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishPerformSectionIdScRsp), FinishPerformSectionIdScRsp.Parser, new string[4] { "Reward", "Retcode", "ItemList", "SectionId" }, null, null, null, null)
		}));
	}
}
