using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RaidCollectionDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RaidCollectionDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1SYWlkQ29sbGVjdGlvbkRhdGFTY1JzcC5wcm90bxoRQUxFT0lMQ0lGSU4u" + "cHJvdG8iUAoXUmFpZENvbGxlY3Rpb25EYXRhU2NSc3ASJAoOY2hhbGxlbmdl" + "X2xpc3QYCCADKAsyDC5BTEVPSUxDSUZJThIPCgdyZXRjb2RlGA0gASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ALEOILCIFINReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RaidCollectionDataScRsp), RaidCollectionDataScRsp.Parser, new string[2] { "ChallengeList", "Retcode" }, null, null, null, null)
		}));
	}
}
