using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesTakeQuestRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesTakeQuestRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiNQbGFuZXRGZXNUYWtlUXVlc3RSZXdhcmRTY1JzcC5wcm90bxoRSk5CR0lE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RUxPR0YucHJvdG8iZQodUGxhbmV0RmVzVGFrZVF1ZXN0UmV3YXJkU2NSc3AS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "IQoLRUFQSE1QSURFQ0kYBiABKAsyDC5KTkJHSURFTE9HRhIQCghxdWVzdF9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ZBgHIAEoDRIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { JNBGIDELOGFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesTakeQuestRewardScRsp), PlanetFesTakeQuestRewardScRsp.Parser, new string[3] { "EAPHMPIDECI", "QuestId", "Retcode" }, null, null, null, null)
		}));
	}
}
