using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CKMIGEIACIOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CKMIGEIACIOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDS01JR0VJQUNJTy5wcm90byIzCgtDS01JR0VJQUNJTxITCgt0ZWxlcG9y" + "dF9pZBgIIAEoDRIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CKMIGEIACIO), CKMIGEIACIO.Parser, new string[2] { "TeleportId", "Retcode" }, null, null, null, null)
		}));
	}
}
