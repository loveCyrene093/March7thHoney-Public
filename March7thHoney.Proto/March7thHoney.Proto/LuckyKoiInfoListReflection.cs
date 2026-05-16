using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LuckyKoiInfoListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LuckyKoiInfoListReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZMdWNreUtvaUluZm9MaXN0LnByb3RvIk8KEEx1Y2t5S29pSW5mb0xpc3QS" + "EQoJaGVhZF9pY29uGAIgASgNEhMKC0lLRENGRU5ERE9CGAMgASgJEhMKC1BO" + "RkZMQ0xNRkxPGA8gASgJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LuckyKoiInfoList), LuckyKoiInfoList.Parser, new string[3] { "HeadIcon", "IKDCFENDDOB", "PNFFLCLMFLO" }, null, null, null, null)
		}));
	}
}
