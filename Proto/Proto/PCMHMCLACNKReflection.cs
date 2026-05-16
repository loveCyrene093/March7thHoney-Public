using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCMHMCLACNKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCMHMCLACNKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQ01ITUNMQUNOSy5wcm90byJECgtQQ01ITUNMQUNOSxITCgtHUEpISk9P" + "SUpKQxgFIAEoDRILCgN1aWQYCCABKA0SEwoLSEhLQ0FES0NMSkMYDCABKARC" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PCMHMCLACNK), PCMHMCLACNK.Parser, new string[3] { "GPJHJOOIJJC", "Uid", "HHKCADKCLJC" }, null, null, null, null)
		}));
	}
}
