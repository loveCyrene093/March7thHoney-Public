using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RankUpEquipmentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RankUpEquipmentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSYW5rVXBFcXVpcG1lbnRTY1JzcC5wcm90byInChRSYW5rVXBFcXVpcG1l" + "bnRTY1JzcBIPCgdyZXRjb2RlGAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RankUpEquipmentScRsp), RankUpEquipmentScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
