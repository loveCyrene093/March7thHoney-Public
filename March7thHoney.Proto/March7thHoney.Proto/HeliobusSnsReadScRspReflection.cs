using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusSnsReadScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusSnsReadScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpIZWxpb2J1c1Nuc1JlYWRTY1JzcC5wcm90byI8ChRIZWxpb2J1c1Nuc1Jl" + "YWRTY1JzcBIPCgdyZXRjb2RlGAUgASgNEhMKC0NES0VERlBFRklKGAogASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusSnsReadScRsp), HeliobusSnsReadScRsp.Parser, new string[2] { "Retcode", "CDKEDFPEFIJ" }, null, null, null, null)
		}));
	}
}
