using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class V2FinishPveStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static V2FinishPveStageCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtWMkZpbmlzaFB2ZVN0YWdlQ3NSZXEucHJvdG8itQEKFVYyRmluaXNoUHZl";
		buffer[1] = "U3RhZ2VDc1JlcRITCgtJSE9OREpPQVBCTRgHIAEoDRITCgtMTk9QS01NRUxD";
		buffer[2] = "QxgIIAEoDRITCgtCSU9EQUpMTElOTxgJIAEoCBITCgtJSUFKUEFET0xNQxgK";
		buffer[3] = "IAEoDRITCgtNTUxLRkpJQUtLSBgLIAEoDRITCgtCRUVNSkVDRE1HQhgMIAEo";
		buffer[4] = "DRIOCgZpc193aW4YDSABKAgSDgoGZGFtYWdlGA4gASgNQhaqAhNNYXJjaDd0";
		buffer[5] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(V2FinishPveStageCsReq), V2FinishPveStageCsReq.Parser, new string[8] { "IHONDJOAPBM", "LNOPKMMELCC", "BIODAJLLINO", "IIAJPADOLMC", "MMLKFJIAKKH", "BEEMJECDMGB", "IsWin", "Damage" }, null, null, null, null)
		}));
	}
}
