using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterTreasureDungeonScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterTreasureDungeonScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9FbnRlclRyZWFzdXJlRHVuZ2VvblNjUnNwLnByb3RvGhFLUEJHTU9DQ01M" + "QS5wcm90byJPChlFbnRlclRyZWFzdXJlRHVuZ2VvblNjUnNwEiEKC0lLSEpM" + "TUFLTkNEGAYgASgLMgwuS1BCR01PQ0NNTEESDwoHcmV0Y29kZRgOIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { KPBGMOCCMLAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterTreasureDungeonScRsp), EnterTreasureDungeonScRsp.Parser, new string[2] { "IKHJLMAKNCD", "Retcode" }, null, null, null, null)
		}));
	}
}
