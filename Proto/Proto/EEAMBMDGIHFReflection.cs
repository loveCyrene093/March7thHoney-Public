using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EEAMBMDGIHFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EEAMBMDGIHFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRUFNQk1ER0lIRi5wcm90byIzCgtFRUFNQk1ER0lIRhITCgtNS0VHTUZN" + "QklFRBgGIAMoDRIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EEAMBMDGIHF), EEAMBMDGIHF.Parser, new string[2] { "MKEGMFMBIED", "Retcode" }, null, null, null, null)
		}));
	}
}
