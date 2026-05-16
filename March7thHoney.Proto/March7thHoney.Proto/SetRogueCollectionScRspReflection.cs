using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetRogueCollectionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetRogueCollectionScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch1TZXRSb2d1ZUNvbGxlY3Rpb25TY1JzcC5wcm90bxoRRVBMR01DQ05BTEcu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cHJvdG8aEU1NUE9PQkdBRUtFLnByb3RvInAKF1NldFJvZ3VlQ29sbGVjdGlv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "blNjUnNwEiEKC0lCTk5PQUpNQUtFGAEgAygLMgwuTU1QT09CR0FFS0USIQoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TE5JTk9NUEVCT0IYCCADKAsyDC5FUExHTUNDTkFMRxIPCgdyZXRjb2RlGA8g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			EPLGMCCNALGReflection.Descriptor,
			MMPOOBGAEKEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetRogueCollectionScRsp), SetRogueCollectionScRsp.Parser, new string[3] { "IBNNOAJMAKE", "LNINOMPEBOB", "Retcode" }, null, null, null, null)
		}));
	}
}
