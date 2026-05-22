using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FIHMEHKCDALReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FIHMEHKCDALReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFGSUhNRUhLQ0RBTC5wcm90bxoRQkFBSElHTk5DSUEucHJvdG8aEU1FSFBK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "S1BNREFOLnByb3RvImYKC0ZJSE1FSEtDREFMEiMKC0VMQUVNT1BCRExQGAEg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgLMgwuTUVIUEpLUE1EQU5IABIjCgtHRU1BQkhJUExHQhgCIAEoCzIMLkJB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "QUhJR05OQ0lBSABCDQoLTkxQUFBDSEdHUEZCFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			BAAHIGNNCIAReflection.Descriptor,
			MEHPJKPMDANReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FIHMEHKCDAL), FIHMEHKCDAL.Parser, new string[2] { "ELAEMOPBDLP", "GEMABHIPLGB" }, new string[1] { "NLPPPCHGGPF" }, null, null, null)
		}));
	}
}
