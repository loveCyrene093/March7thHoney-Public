using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BatchRankUpEquipmentCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BatchRankUpEquipmentCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9CYXRjaFJhbmtVcEVxdWlwbWVudENzUmVxLnByb3RvGhFLQ0NGTk1PSU1B" + "UC5wcm90byI+ChlCYXRjaFJhbmtVcEVxdWlwbWVudENzUmVxEiEKC3N3aXRj" + "aF9saXN0GAIgAygLMgwuS0NDRk5NT0lNQVBCFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { KCCFNMOIMAPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BatchRankUpEquipmentCsReq), BatchRankUpEquipmentCsReq.Parser, new string[1] { "SwitchList" }, null, null, null, null)
		}));
	}
}
