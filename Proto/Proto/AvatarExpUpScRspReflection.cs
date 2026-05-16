using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarExpUpScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarExpUpScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBdmF0YXJFeHBVcFNjUnNwLnByb3RvGg5QaWxlSXRlbS5wcm90byJIChBB" + "dmF0YXJFeHBVcFNjUnNwEiMKEHJldHVybl9pdGVtX2xpc3QYBiADKAsyCS5Q" + "aWxlSXRlbRIPCgdyZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[1] { PileItemReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarExpUpScRsp), AvatarExpUpScRsp.Parser, new string[2] { "ReturnItemList", "Retcode" }, null, null, null, null)
		}));
	}
}
