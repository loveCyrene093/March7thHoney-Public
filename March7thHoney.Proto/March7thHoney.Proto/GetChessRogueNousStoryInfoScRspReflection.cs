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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiVHZXRDaGVzc1JvZ3VlTm91c1N0b3J5SW5mb1NjUnNwLnByb3RvGhFDQUNM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "RENBRkNLSC5wcm90bxoRREhHUENQTUlGREMucHJvdG8ieAofR2V0Q2hlc3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "b2d1ZU5vdXNTdG9yeUluZm9TY1JzcBIhCgtPTEhOQkVQSEhGRxgKIAMoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "LkNBQ0xEQ0FGQ0tIEiEKC0RPS0hET0dBUEtEGAsgAygLMgwuREhHUENQTUlG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "REMSDwoHcmV0Y29kZRgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			CACLDCAFCKHReflection.Descriptor,
			DHGPCPMIFDCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChessRogueNousStoryInfoScRsp), GetChessRogueNousStoryInfoScRsp.Parser, new string[3] { "OLHNBEPHHFG", "DOKHDOGAPKD", "Retcode" }, null, null, null, null)
		}));
	}
}
