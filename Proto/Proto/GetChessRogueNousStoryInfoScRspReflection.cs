using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChessRogueNousStoryInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChessRogueNousStoryInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiVHZXRDaGVzc1JvZ3VlTm91c1N0b3J5SW5mb1NjUnNwLnByb3RvGhFDQUNM";
		buffer[1] = "RENBRkNLSC5wcm90bxoRREhHUENQTUlGREMucHJvdG8ieAofR2V0Q2hlc3NS";
		buffer[2] = "b2d1ZU5vdXNTdG9yeUluZm9TY1JzcBIhCgtPTEhOQkVQSEhGRxgKIAMoCzIM";
		buffer[3] = "LkNBQ0xEQ0FGQ0tIEiEKC0RPS0hET0dBUEtEGAsgAygLMgwuREhHUENQTUlG";
		buffer[4] = "REMSDwoHcmV0Y29kZRgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[5] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CACLDCAFCKHReflection.Descriptor,
			DHGPCPMIFDCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChessRogueNousStoryInfoScRsp), GetChessRogueNousStoryInfoScRsp.Parser, new string[3] { "OLHNBEPHHFG", "DOKHDOGAPKD", "Retcode" }, null, null, null, null)
		}));
	}
}
