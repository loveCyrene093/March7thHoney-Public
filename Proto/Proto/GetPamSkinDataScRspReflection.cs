using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPamSkinDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPamSkinDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRQYW1Ta2luRGF0YVNjUnNwLnByb3RvIlIKE0dldFBhbVNraW5EYXRh" + "U2NSc3ASEAoIY3VyX3NraW4YAiABKA0SGAoQdW5sb2NrX3NraW5fbGlzdBgF" + "IAMoDRIPCgdyZXRjb2RlGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPamSkinDataScRsp), GetPamSkinDataScRsp.Parser, new string[3] { "CurSkin", "UnlockSkinList", "Retcode" }, null, null, null, null)
		}));
	}
}
