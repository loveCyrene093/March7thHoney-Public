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
		buffer[0] = "Ch1NYXRjaFRocmVlTGV2ZWxFbmRDc1JlcS5wcm90byKBAgoXTWF0Y2hUaHJl";
		buffer[1] = "ZUxldmVsRW5kQ3NSZXESEwoLTkxPQ0RITUxHSkgYBSABKA0SPgoLS0lCR05K";
		buffer[2] = "TkFEREgYByADKAsyKS5NYXRjaFRocmVlTGV2ZWxFbmRDc1JlcS5LSUJHTkpO";
		buffer[3] = "QURESEVudHJ5EgwKBHV1aWQYCCABKAkSEwoLRkRET0ZGRlBBTEMYCiADKA0S";
		buffer[4] = "EwoLQk9GT09LSkNKR0cYDCABKA0SEAoIbGV2ZWxfaWQYDSABKA0SEwoLRFBD";
		buffer[5] = "RkJEQ0VLSkwYDiABKA0aMgoQS0lCR05KTkFEREhFbnRyeRILCgNrZXkYASAB";
		buffer[6] = "KA0SDQoFdmFsdWUYAiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[7] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeLevelEndCsReq), MatchThreeLevelEndCsReq.Parser, new string[7] { "NLOCDHMLGJH", "KIBGNJNADDH", "Uuid", "FDDOFFFPALC", "BOFOOKJCJGG", "LevelId", "DPCFBDCEKJL" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
