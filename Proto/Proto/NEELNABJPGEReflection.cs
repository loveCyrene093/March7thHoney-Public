using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NEELNABJPGEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NEELNABJPGEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORUVMTkFCSlBHRS5wcm90bxoRRUxMTkRORUJIREsucHJvdG8iQQoLTkVF" + "TE5BQkpQR0USDwoHcmV0Y29kZRgGIAEoDRIhCgtGTUVDQUhBTFBLRxgMIAEo" + "CzIMLkVMTE5ETkVCSERLQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { ELLNDNEBHDKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NEELNABJPGE), NEELNABJPGE.Parser, new string[2] { "Retcode", "FMECAHALPKG" }, null, null, null, null)
		}));
	}
}
