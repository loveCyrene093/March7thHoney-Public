using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMailTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMailTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFDbWRNYWlsVHlwZS5wcm90byqNAgoLQ21kTWFpbFR5cGUSGwoXREhMRUhL";
		buffer[1] = "RUlNTU5fUENQREhFTFBLRU0QABIUCg9DbWRHZXRNYWlsQ3NSZXEQ+wYSGQoU";
		buffer[2] = "Q21kTWFya1JlYWRNYWlsQ3NSZXEQ/gYSHwoaQ21kVGFrZU1haWxBdHRhY2ht";
		buffer[3] = "ZW50U2NSc3AQggcSHwoaQ21kVGFrZU1haWxBdHRhY2htZW50Q3NSZXEQqQYS";
		buffer[4] = "FwoSQ21kTmV3TWFpbFNjTm90aWZ5EN8GEhQKD0NtZERlbE1haWxDc1JlcRCu";
		buffer[5] = "BhIUCg9DbWRHZXRNYWlsU2NSc3AQqgYSFAoPQ21kRGVsTWFpbFNjUnNwELIG";
		buffer[6] = "EhMKDkNtZExPSEdCTkFJQUlMEP8GQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[7] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMailType) }, null, null));
	}
}
