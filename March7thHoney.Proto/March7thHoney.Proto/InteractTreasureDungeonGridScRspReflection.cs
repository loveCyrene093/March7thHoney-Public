using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class InteractTreasureDungeonGridScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static InteractTreasureDungeonGridScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZJbnRlcmFjdFRyZWFzdXJlRHVuZ2VvbkdyaWRTY1JzcC5wcm90bxoRS1BC" + "R01PQ0NNTEEucHJvdG8iVgogSW50ZXJhY3RUcmVhc3VyZUR1bmdlb25Hcmlk" + "U2NSc3ASIQoLSUtISkxNQUtOQ0QYAyABKAsyDC5LUEJHTU9DQ01MQRIPCgdy" + "ZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { KPBGMOCCMLAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(InteractTreasureDungeonGridScRsp), InteractTreasureDungeonGridScRsp.Parser, new string[2] { "IKHJLMAKNCD", "Retcode" }, null, null, null, null)
		}));
	}
}
