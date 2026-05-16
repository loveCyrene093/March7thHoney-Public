using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAuthkeyCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAuthkeyCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVHZXRBdXRoa2V5Q3NSZXEucHJvdG8iTQoPR2V0QXV0aGtleUNzUmVxEhMK" + "C2F1dGhrZXlfdmVyGAMgASgNEhEKCXNpZ25fdHlwZRgHIAEoDRISCgphdXRo" + "X2FwcGlkGA8gASgJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAuthkeyCsReq), GetAuthkeyCsReq.Parser, new string[3] { "AuthkeyVer", "SignType", "AuthAppid" }, null, null, null, null)
		}));
	}
}
