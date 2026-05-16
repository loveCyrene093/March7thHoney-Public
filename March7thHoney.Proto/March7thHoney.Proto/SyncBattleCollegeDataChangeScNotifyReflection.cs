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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CilTeW5jQmF0dGxlQ29sbGVnZURhdGFDaGFuZ2VTY05vdGlmeS5wcm90bxoO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SXRlbUxpc3QucHJvdG8idwojU3luY0JhdHRsZUNvbGxlZ2VEYXRhQ2hhbmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "U2NOb3RpZnkSGQoGcmV3YXJkGAQgASgLMgkuSXRlbUxpc3QSEwoLTENEQUxF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RUVESkoYBSABKA0SIAoYZmluaXNoZWRfY29sbGVnZV9pZF9saXN0GAcgAygN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncBattleCollegeDataChangeScNotify), SyncBattleCollegeDataChangeScNotify.Parser, new string[3] { "Reward", "LCDALEEEDJJ", "FinishedCollegeIdList" }, null, null, null, null)
		}));
	}
}
