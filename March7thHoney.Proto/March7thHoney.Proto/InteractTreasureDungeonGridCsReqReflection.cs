using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class InteractTreasureDungeonGridCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static InteractTreasureDungeonGridCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZJbnRlcmFjdFRyZWFzdXJlRHVuZ2VvbkdyaWRDc1JlcS5wcm90byJjCiBJ" + "bnRlcmFjdFRyZWFzdXJlRHVuZ2VvbkdyaWRDc1JlcRIVCg1kaXNwbGF5X3Zh" + "bHVlGAogASgNEhMKC3RhcmdldF9zaWRlGAsgASgNEhMKC0NKT1BORkRCSkhE" + "GA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(InteractTreasureDungeonGridCsReq), InteractTreasureDungeonGridCsReq.Parser, new string[3] { "DisplayValue", "TargetSide", "CJOPNFDBJHD" }, null, null, null, null)
		}));
	}
}
