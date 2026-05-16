using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeSetBirdPosCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeSetBirdPosCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9NYXRjaFRocmVlU2V0QmlyZFBvc0NzUmVxLnByb3RvIj0KGU1hdGNoVGhy" + "ZWVTZXRCaXJkUG9zQ3NSZXESCwoDcG9zGAcgASgNEhMKC05MT0NESE1MR0pI" + "GAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeSetBirdPosCsReq), MatchThreeSetBirdPosCsReq.Parser, new string[2] { "Pos", "NLOCDHMLGJH" }, null, null, null, null)
		}));
	}
}
