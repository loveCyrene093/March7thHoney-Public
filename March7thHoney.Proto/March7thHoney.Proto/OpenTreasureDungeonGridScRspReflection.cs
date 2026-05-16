using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OpenTreasureDungeonGridScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OpenTreasureDungeonGridScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJPcGVuVHJlYXN1cmVEdW5nZW9uR3JpZFNjUnNwLnByb3RvGhFLUEJHTU9D" + "Q01MQS5wcm90byJSChxPcGVuVHJlYXN1cmVEdW5nZW9uR3JpZFNjUnNwEiEK" + "C0lLSEpMTUFLTkNEGAcgASgLMgwuS1BCR01PQ0NNTEESDwoHcmV0Y29kZRgP" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { KPBGMOCCMLAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OpenTreasureDungeonGridScRsp), OpenTreasureDungeonGridScRsp.Parser, new string[2] { "IKHJLMAKNCD", "Retcode" }, null, null, null, null)
		}));
	}
}
