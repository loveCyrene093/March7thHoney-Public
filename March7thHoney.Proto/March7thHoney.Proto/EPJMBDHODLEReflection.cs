using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EPJMBDHODLEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EPJMBDHODLEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFUEpNQkRIT0RMRS5wcm90byIyCgtFUEpNQkRIT0RMRRITCgtFRkRETk1H" + "TEFORhgEIAEoDRIOCgZpc193aW4YBiABKAhCFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EPJMBDHODLE), EPJMBDHODLE.Parser, new string[2] { "EFDDNMGLANF", "IsWin" }, null, null, null, null)
		}));
	}
}
