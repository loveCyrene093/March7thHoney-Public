using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NFPEDBOOFFFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NFPEDBOOFFFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORlBFREJPT0ZGRi5wcm90bxoRT01OSk5LTk1MS0wucHJvdG8iQQoLTkZQ" + "RURCT09GRkYSDwoHcmV0Y29kZRgBIAEoDRIhCgtOQ0pIRkZEREhMSRgKIAEo" + "CzIMLk9NTkpOS05NTEtMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { OMNJNKNMLKLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NFPEDBOOFFF), NFPEDBOOFFF.Parser, new string[2] { "Retcode", "NCJHFFDDHLI" }, null, null, null, null)
		}));
	}
}
