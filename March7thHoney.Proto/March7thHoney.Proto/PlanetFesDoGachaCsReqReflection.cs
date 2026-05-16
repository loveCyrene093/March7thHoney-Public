using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesDoGachaCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesDoGachaCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtQbGFuZXRGZXNEb0dhY2hhQ3NSZXEucHJvdG8iVgoVUGxhbmV0RmVzRG9H" + "YWNoYUNzUmVxEhMKC2dhY2hhX2NvdW50GAUgASgNEhAKCGdhY2hhX2lkGAog" + "ASgNEhYKDnNpbXVsYXRlX21hZ2ljGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesDoGachaCsReq), PlanetFesDoGachaCsReq.Parser, new string[3] { "GachaCount", "GachaId", "SimulateMagic" }, null, null, null, null)
		}));
	}
}
