using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetShareDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetShareDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRTaGFyZURhdGFTY1JzcC5wcm90bxoRTEhNSEZOQk9BR0MucHJvdG8i" + "RwoRR2V0U2hhcmVEYXRhU2NSc3ASDwoHcmV0Y29kZRgHIAEoDRIhCgtIQkRL" + "T0ZJRUpMSxgMIAMoCzIMLkxITUhGTkJPQUdDQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { LHMHFNBOAGCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetShareDataScRsp), GetShareDataScRsp.Parser, new string[2] { "Retcode", "HBDKOFIEJLK" }, null, null, null, null)
		}));
	}
}
