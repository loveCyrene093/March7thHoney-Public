using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingActionTurnSettleScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingActionTurnSettleScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CitTd29yZFRyYWluaW5nQWN0aW9uVHVyblNldHRsZVNjTm90aWZ5LnByb3Rv";
		buffer[1] = "GhFCQ0lDRU1EREdFTS5wcm90byJfCiVTd29yZFRyYWluaW5nQWN0aW9uVHVy";
		buffer[2] = "blNldHRsZVNjTm90aWZ5EiEKC0dCSkZOR0RNT0tIGAYgAygLMgwuQkNJQ0VN";
		buffer[3] = "RERHRU0SEwoLSUdPSE9IREtFSkQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BCICEMDDGEMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingActionTurnSettleScNotify), SwordTrainingActionTurnSettleScNotify.Parser, new string[2] { "GBJFNGDMOKH", "IGOHOHDKEJD" }, null, null, null, null)
		}));
	}
}
