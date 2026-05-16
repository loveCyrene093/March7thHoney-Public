using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BatchRankUpEquipmentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BatchRankUpEquipmentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9CYXRjaFJhbmtVcEVxdWlwbWVudFNjUnNwLnByb3RvIiwKGUJhdGNoUmFu" + "a1VwRXF1aXBtZW50U2NSc3ASDwoHcmV0Y29kZRgMIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BatchRankUpEquipmentScRsp), BatchRankUpEquipmentScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
