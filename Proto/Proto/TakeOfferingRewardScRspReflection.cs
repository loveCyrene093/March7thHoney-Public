using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeOfferingRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeOfferingRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1UYWtlT2ZmZXJpbmdSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJv";
		buffer[1] = "dG8aEk9mZmVyaW5nSW5mby5wcm90byJrChdUYWtlT2ZmZXJpbmdSZXdhcmRT";
		buffer[2] = "Y1JzcBIPCgdyZXRjb2RlGAIgASgNEhkKBnJld2FyZBgFIAEoCzIJLkl0ZW1M";
		buffer[3] = "aXN0EiQKDW9mZmVyaW5nX2luZm8YCCABKAsyDS5PZmZlcmluZ0luZm9CFqoC";
		buffer[4] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			OfferingInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeOfferingRewardScRsp), TakeOfferingRewardScRsp.Parser, new string[3] { "Retcode", "Reward", "OfferingInfo" }, null, null, null, null)
		}));
	}
}
