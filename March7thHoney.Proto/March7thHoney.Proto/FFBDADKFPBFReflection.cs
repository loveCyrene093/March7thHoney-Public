using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FFBDADKFPBFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FFBDADKFPBFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFGRkJEQURLRlBCRi5wcm90bxoRQ1BJT0NISFBJQ0QucHJvdG8aEUVGRUdL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "REhFTUZOLnByb3RvGhFMTExBUE5ERERLTS5wcm90byKLAQoLRkZCREFES0ZQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "QkYSIQoLS1BPUEVDS0NETUcYAyABKAsyDC5FRkVHS0RIRU1GThIhCgtDQkVK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "TU1EREJKTBgFIAMoCzIMLkNQSU9DSEhQSUNEEiEKC0pPSkRKQUVDSEtBGAgg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "AygLMgwuTExMQVBORERES00SEwoLTkhDQUdQRkRMRVAYDyADKA1CFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[3]
		{
			CPIOCHHPICDReflection.Descriptor,
			EFEGKDHEMFNReflection.Descriptor,
			LLLAPNDDDKMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FFBDADKFPBF), FFBDADKFPBF.Parser, new string[4] { "KPOPECKCDMG", "CBEJMMDDBJL", "JOJDJAECHKA", "NHCAGPFDLEP" }, null, null, null, null)
		}));
	}
}
