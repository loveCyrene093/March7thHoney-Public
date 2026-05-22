using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeGetDataDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeGetDataDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBNYXRjaFRocmVlR2V0RGF0YURhdGFTY1JzcC5wcm90bxoRTUpNUERHTkZJ" + "S04ucHJvdG8iUAoaTWF0Y2hUaHJlZUdldERhdGFEYXRhU2NSc3ASDwoHcmV0" + "Y29kZRgMIAEoDRIhCgtEQ0ZHT0ZOQkxDTRgNIAEoCzIMLk1KTVBER05GSUtO" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MJMPDGNFIKNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeGetDataDataScRsp), MatchThreeGetDataDataScRsp.Parser, new string[2] { "Retcode", "DCFGOFNBLCM" }, null, null, null, null)
		}));
	}
}
