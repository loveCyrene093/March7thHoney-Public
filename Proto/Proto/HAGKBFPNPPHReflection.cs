using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HAGKBFPNPPHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HAGKBFPNPPHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQUdLQkZQTlBQSC5wcm90byJTCgtIQUdLQkZQTlBQSBILCgNwb3MYASAB" + "KA0SEwoLQk9GT09LSkNKR0cYBCABKA0SEwoLTkxPQ0RITUxHSkgYCyABKA0S" + "DQoFY291bnQYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HAGKBFPNPPH), HAGKBFPNPPH.Parser, new string[4] { "Pos", "BOFOOKJCJGG", "NLOCDHMLGJH", "Count" }, null, null, null, null)
		}));
	}
}
