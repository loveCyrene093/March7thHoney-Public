using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeLevelEndCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeLevelEndCsReqReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "Ch1NYXRjaFRocmVlTGV2ZWxFbmRDc1JlcS5wcm90byKBAgoXTWF0Y2hUaHJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "ZUxldmVsRW5kQ3NSZXESEwoLTkxPQ0RITUxHSkgYBSABKA0SPgoLS0lCR05K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "TkFEREgYByADKAsyKS5NYXRjaFRocmVlTGV2ZWxFbmRDc1JlcS5LSUJHTkpO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "QURESEVudHJ5EgwKBHV1aWQYCCABKAkSEwoLRkRET0ZGRlBBTEMYCiADKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "EwoLQk9GT09LSkNKR0cYDCABKA0SEAoIbGV2ZWxfaWQYDSABKA0SEwoLRFBD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "RkJEQ0VLSkwYDiABKA0aMgoQS0lCR05KTkFEREhFbnRyeRILCgNrZXkYASAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "KA0SDQoFdmFsdWUYAiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeLevelEndCsReq), MatchThreeLevelEndCsReq.Parser, new string[7] { "NLOCDHMLGJH", "KIBGNJNADDH", "Uuid", "FDDOFFFPALC", "BOFOOKJCJGG", "LevelId", "DPCFBDCEKJL" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
