using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BAMHNJKNNAMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BAMHNJKNNAMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQU1ITkpLTk5BTS5wcm90byIzCgtCQU1ITkpLTk5BTRIPCgdhcmVhX2lk" + "GAQgASgNEhMKC09OT0RPQ09OQkRBGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BAMHNJKNNAM), BAMHNJKNNAM.Parser, new string[2] { "AreaId", "ONODOCONBDA" }, null, null, null, null)
		}));
	}
}
