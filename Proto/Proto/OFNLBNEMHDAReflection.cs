using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OFNLBNEMHDAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OFNLBNEMHDAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRk5MQk5FTUhEQS5wcm90byJGCgtPRk5MQk5FTUhEQRITCgtPR0hGTU9B" + "TFBFTxgBIAEoDRIQCghwYW5lbF9pZBgMIAEoDRIQCghncm91cF9pZBgNIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OFNLBNEMHDA), OFNLBNEMHDA.Parser, new string[3] { "OGHFMOALPEO", "PanelId", "GroupId" }, null, null, null, null)
		}));
	}
}
