using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KCHEPLKMONLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KCHEPLKMONLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLQ0hFUExLTU9OTC5wcm90bxoRQ0NCS0dKR05EQ0wucHJvdG8iQQoLS0NI" + "RVBMS01PTkwSDwoHcmV0Y29kZRgBIAEoDRIhCgtLREtCTk1FSkxGUBgJIAMo" + "CzIMLkNDQktHSkdORENMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { CCBKGJGNDCLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KCHEPLKMONL), KCHEPLKMONL.Parser, new string[2] { "Retcode", "KDKBNMEJLFP" }, null, null, null, null)
		}));
	}
}
