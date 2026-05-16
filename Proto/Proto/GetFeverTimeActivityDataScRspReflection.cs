using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFeverTimeActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFeverTimeActivityDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNHZXRGZXZlclRpbWVBY3Rpdml0eURhdGFTY1JzcC5wcm90bxoRQUVCQ0xG" + "QkRIUEUucHJvdG8iUwodR2V0RmV2ZXJUaW1lQWN0aXZpdHlEYXRhU2NSc3AS" + "DwoHcmV0Y29kZRgIIAEoDRIhCgtQQ0RJRkRHQ0RPSxgMIAMoCzIMLkFFQkNM" + "RkJESFBFQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { AEBCLFBDHPEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFeverTimeActivityDataScRsp), GetFeverTimeActivityDataScRsp.Parser, new string[2] { "Retcode", "PCDIFDGCDOK" }, null, null, null, null)
		}));
	}
}
