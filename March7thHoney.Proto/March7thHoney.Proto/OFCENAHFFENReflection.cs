using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OFCENAHFFENReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OFCENAHFFENReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRkNFTkFIRkZFTi5wcm90bxoRTWFpbk1pc3Npb24ucHJvdG8iQQoLT0ZD" + "RU5BSEZGRU4SDwoHcmV0Y29kZRgJIAEoDRIhCgtIRkxDTEZMQ0NMSxgLIAEo" + "CzIMLk1haW5NaXNzaW9uQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { MainMissionReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OFCENAHFFEN), OFCENAHFFEN.Parser, new string[2] { "Retcode", "HFLCLFLCCLK" }, null, null, null, null)
		}));
	}
}
