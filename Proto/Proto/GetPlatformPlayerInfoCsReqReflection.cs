using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPlatformPlayerInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPlatformPlayerInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRQbGF0Zm9ybVBsYXllckluZm9Dc1JlcS5wcm90bxoSUGxhdGZvcm1U" + "eXBlLnByb3RvIlIKGkdldFBsYXRmb3JtUGxheWVySW5mb0NzUmVxEhMKC1BC" + "SExIRlBJQUNQGAEgAygJEh8KCHBsYXRmb3JtGA4gASgOMg0uUGxhdGZvcm1U" + "eXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PlatformTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPlatformPlayerInfoCsReq), GetPlatformPlayerInfoCsReq.Parser, new string[2] { "PBHLHFPIACP", "Platform" }, null, null, null, null)
		}));
	}
}
