using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingHandlePendingActionsCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingHandlePendingActionsCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CidDaGVuTGluZ0hhbmRsZVBlbmRpbmdBY3Rpb25zQ3NSZXEucHJvdG8aEU5H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RE9MSE9OS0lBLnByb3RvIloKIUNoZW5MaW5nSGFuZGxlUGVuZGluZ0FjdGlv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "bnNDc1JlcRIRCgl1bmlxdWVfaWQYDCABKA0SIgoLSUNLSUlCR0pNTk0Yjggg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ASgLMgwuTkdET0xIT05LSUFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { NGDOLHONKIAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingHandlePendingActionsCsReq), ChenLingHandlePendingActionsCsReq.Parser, new string[2] { "UniqueId", "ICKIIBGJMNM" }, null, null, null, null)
		}));
	}
}
