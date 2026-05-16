using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusSnsLikeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusSnsLikeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpIZWxpb2J1c1Nuc0xpa2VTY1JzcC5wcm90byJRChRIZWxpb2J1c1Nuc0xp" + "a2VTY1JzcBITCgtDREtFREZQRUZJShgFIAEoDRITCgtCT0xDQUVQSUhKSBgI" + "IAEoCBIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusSnsLikeScRsp), HeliobusSnsLikeScRsp.Parser, new string[3] { "CDKEDFPEFIJ", "BOLCAEPIHJH", "Retcode" }, null, null, null, null)
		}));
	}
}
