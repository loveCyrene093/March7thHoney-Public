using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncBattleCollegeDataChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncBattleCollegeDataChangeScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CilTeW5jQmF0dGxlQ29sbGVnZURhdGFDaGFuZ2VTY05vdGlmeS5wcm90bxoO";
		buffer[1] = "SXRlbUxpc3QucHJvdG8idwojU3luY0JhdHRsZUNvbGxlZ2VEYXRhQ2hhbmdl";
		buffer[2] = "U2NOb3RpZnkSGQoGcmV3YXJkGAQgASgLMgkuSXRlbUxpc3QSEwoLTENEQUxF";
		buffer[3] = "RUVESkoYBSABKA0SIAoYZmluaXNoZWRfY29sbGVnZV9pZF9saXN0GAcgAygN";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncBattleCollegeDataChangeScNotify), SyncBattleCollegeDataChangeScNotify.Parser, new string[3] { "Reward", "LCDALEEEDJJ", "FinishedCollegeIdList" }, null, null, null, null)
		}));
	}
}
