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
		buffer[0] = "CiNQbGFuZXRGZXNUYWtlUXVlc3RSZXdhcmRTY1JzcC5wcm90bxoRSk5CR0lE";
		buffer[1] = "RUxPR0YucHJvdG8iZQodUGxhbmV0RmVzVGFrZVF1ZXN0UmV3YXJkU2NSc3AS";
		buffer[2] = "IQoLRUFQSE1QSURFQ0kYBiABKAsyDC5KTkJHSURFTE9HRhIQCghxdWVzdF9p";
		buffer[3] = "ZBgHIAEoDRIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JNBGIDELOGFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesTakeQuestRewardScRsp), PlanetFesTakeQuestRewardScRsp.Parser, new string[3] { "EAPHMPIDECI", "QuestId", "Retcode" }, null, null, null, null)
		}));
	}
}
