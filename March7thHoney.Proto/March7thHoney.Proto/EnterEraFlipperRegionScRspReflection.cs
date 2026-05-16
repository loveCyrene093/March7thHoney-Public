using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterEraFlipperRegionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterEraFlipperRegionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBFbnRlckVyYUZsaXBwZXJSZWdpb25TY1JzcC5wcm90byJCChpFbnRlckVy" + "YUZsaXBwZXJSZWdpb25TY1JzcBITCgtKSERMTkJQTkVLRxgGIAEoDRIPCgdy" + "ZXRjb2RlGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterEraFlipperRegionScRsp), EnterEraFlipperRegionScRsp.Parser, new string[2] { "JHDLNBPNEKG", "Retcode" }, null, null, null, null)
		}));
	}
}
