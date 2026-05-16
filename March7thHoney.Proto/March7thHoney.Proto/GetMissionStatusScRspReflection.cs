using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMissionStatusScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMissionStatusScRspReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 0) = "ChtHZXRNaXNzaW9uU3RhdHVzU2NSc3AucHJvdG8aHE1haW5NaXNzaW9uQ3Vz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 1) = "dG9tVmFsdWUucHJvdG8aDU1pc3Npb24ucHJvdG8itAIKFUdldE1pc3Npb25T";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 2) = "dGF0dXNTY1JzcBIwCihjdXJ2ZXJzaW9uX2ZpbmlzaGVkX21haW5fbWlzc2lv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 3) = "bl9pZF9saXN0GAEgAygNEikKF3N1Yl9taXNzaW9uX3N0YXR1c19saXN0GAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 4) = "AygLMgguTWlzc2lvbhIlCh1kaXNhYmxlZF9tYWluX21pc3Npb25faWRfbGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 5) = "dBgGIAMoDRInCh91bmZpbmlzaGVkX21haW5fbWlzc2lvbl9pZF9saXN0GAcg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 6) = "AygNEiUKHWZpbmlzaGVkX21haW5fbWlzc2lvbl9pZF9saXN0GAkgAygNEjYK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 7) = "FW1haW5fbWlzc2lvbl9tY3ZfbGlzdBgLIAMoCzIXLk1haW5NaXNzaW9uQ3Vz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 8) = "dG9tVmFsdWUSDwoHcmV0Y29kZRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 9) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray10<string>, string>(in buffer, 10))), new FileDescriptor[2]
		{
			MainMissionCustomValueReflection.Descriptor,
			MissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMissionStatusScRsp), GetMissionStatusScRsp.Parser, new string[7] { "CurversionFinishedMainMissionIdList", "SubMissionStatusList", "DisabledMainMissionIdList", "UnfinishedMainMissionIdList", "FinishedMainMissionIdList", "MainMissionMcvList", "Retcode" }, null, null, null, null)
		}));
	}
}
