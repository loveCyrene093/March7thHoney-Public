using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeKilledPunkLordMonsterScoreCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeKilledPunkLordMonsterScoreCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CilUYWtlS2lsbGVkUHVua0xvcmRNb25zdGVyU2NvcmVDc1JlcS5wcm90bxoR";
		buffer[1] = "SkxMSURESUJPSEkucHJvdG8iXQojVGFrZUtpbGxlZFB1bmtMb3JkTW9uc3Rl";
		buffer[2] = "clNjb3JlQ3NSZXESIQoLSklQQUxCTE9QRkkYCSABKAsyDC5KTExJRERJQk9I";
		buffer[3] = "SRITCgtNRE5GTEhNT0xOQhgLIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JLLIDDIBOHIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeKilledPunkLordMonsterScoreCsReq), TakeKilledPunkLordMonsterScoreCsReq.Parser, new string[2] { "JIPALBLOPFI", "MDNFLHMOLNB" }, null, null, null, null)
		}));
	}
}
