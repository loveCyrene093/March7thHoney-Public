using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExpUpEquipmentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExpUpEquipmentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlFeHBVcEVxdWlwbWVudFNjUnNwLnByb3RvGg5QaWxlSXRlbS5wcm90byJL" + "ChNFeHBVcEVxdWlwbWVudFNjUnNwEiMKEHJldHVybl9pdGVtX2xpc3QYAiAD" + "KAsyCS5QaWxlSXRlbRIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PileItemReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExpUpEquipmentScRsp), ExpUpEquipmentScRsp.Parser, new string[2] { "ReturnItemList", "Retcode" }, null, null, null, null)
		}));
	}
}
