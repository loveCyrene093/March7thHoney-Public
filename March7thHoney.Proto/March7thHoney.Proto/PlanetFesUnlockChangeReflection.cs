using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesUnlockChangeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesUnlockChangeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtQbGFuZXRGZXNVbmxvY2tDaGFuZ2UucHJvdG8aEUlQSU1FR0NQQkdNLnBy" + "b3RvIk4KFVBsYW5ldEZlc1VubG9ja0NoYW5nZRISCgpoYXNfcGFzc2VkGAgg" + "ASgIEiEKC0ZDQVBCUEhMTkNKGAwgASgLMgwuSVBJTUVHQ1BCR01CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { IPIMEGCPBGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesUnlockChange), PlanetFesUnlockChange.Parser, new string[2] { "HasPassed", "FCAPBPHLNCJ" }, null, null, null, null)
		}));
	}
}
