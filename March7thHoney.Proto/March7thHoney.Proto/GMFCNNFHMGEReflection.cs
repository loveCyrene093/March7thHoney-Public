using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GMFCNNFHMGEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GMFCNNFHMGEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTUZDTk5GSE1HRS5wcm90byIxCgtHTUZDTk5GSE1HRRIPCgdjYXJkX2lk" + "GAIgASgNEhEKCXVuaXF1ZV9pZBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GMFCNNFHMGE), GMFCNNFHMGE.Parser, new string[2] { "CardId", "UniqueId" }, null, null, null, null)
		}));
	}
}
