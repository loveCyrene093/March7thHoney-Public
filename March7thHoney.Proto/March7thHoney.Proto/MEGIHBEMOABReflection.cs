using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MEGIHBEMOABReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MEGIHBEMOABReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFNRUdJSEJFTU9BQi5wcm90bxoRRE9CSU9PSExHQUEucHJvdG8aEUpBRlBN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "TExPR0RJLnByb3RvIqUBCgtNRUdJSEJFTU9BQhITCgtJQkVCSk1NQ0lESBgC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "IAMoDRITCgtGTktLSURKUEtJSBgEIAEoDRIhCgtETU1OQ05HR1BITBgFIAMo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "CzIMLkRPQklPT0hMR0FBEiEKC1BIR0xGSEREQUNNGAYgAygLMgwuSkFGUE1M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "TE9HREkSEwoLQUZPTElGRkNESEoYCiABKA0SEQoJY3VyX2luZGV4GAsgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			DOBIOOHLGAAReflection.Descriptor,
			JAFPMLLOGDIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MEGIHBEMOAB), MEGIHBEMOAB.Parser, new string[6] { "IBEBJMMCIDH", "FNKKIDJPKIH", "DMMNCNGGPHL", "PHGLFHDDACM", "AFOLIFFCDHJ", "CurIndex" }, null, null, null, null)
		}));
	}
}
