using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCAOLJLFPBAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCAOLJLFPBAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQQ0FPTEpMRlBCQS5wcm90byKhAQoLUENBT0xKTEZQQkESEwoLTExISkFH";
		buffer[1] = "R0VHT0sYASABKA0SEwoLUE5DTkdNRkJBTkQYAiABKA0SEwoLRERHRU9PTEhB";
		buffer[2] = "UEcYBCABKA0SEwoLRUxFQkdOSEVJTUwYBiABKA0SCgoCaHAYByABKAUSEwoL";
		buffer[3] = "TUxMR0VPSU5KT0cYCiABKA0SDQoFaW5kZXgYCyABKA0SDgoGYXR0YWNrGA4g";
		buffer[4] = "ASgFQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PCAOLJLFPBA), PCAOLJLFPBA.Parser, new string[8] { "LLHJAGGEGOK", "PNCNGMFBAND", "DDGEOOLHAPG", "ELEBGNHEIML", "Hp", "MLLGEOINJOG", "Index", "Attack" }, null, null, null, null)
		}));
	}
}
