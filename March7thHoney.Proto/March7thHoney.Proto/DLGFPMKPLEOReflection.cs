using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DLGFPMKPLEOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DLGFPMKPLEOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETEdGUE1LUExFTy5wcm90byIwCgtETEdGUE1LUExFTxIMCgRzbG90GAgg" + "ASgNEhMKC01KSVBPSkpMTk1FGA4gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DLGFPMKPLEO), DLGFPMKPLEO.Parser, new string[2] { "Slot", "MJIPOJJLNME" }, null, null, null, null)
		}));
	}
}
