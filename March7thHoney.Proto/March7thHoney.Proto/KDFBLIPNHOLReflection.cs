using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KDFBLIPNHOLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KDFBLIPNHOLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLREZCTElQTkhPTC5wcm90byJXCgtLREZCTElQTkhPTBIQCghwYW5lbF9p" + "ZBgHIAEoDRITCgtPR0hGTU9BTFBFTxgMIAEoDRIQCghncm91cF9pZBgNIAEo" + "DRIPCgdyZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KDFBLIPNHOL), KDFBLIPNHOL.Parser, new string[4] { "PanelId", "OGHFMOALPEO", "GroupId", "Retcode" }, null, null, null, null)
		}));
	}
}
