using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DoGachaCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DoGachaCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJEb0dhY2hhQ3NSZXEucHJvdG8iYQoMRG9HYWNoYUNzUmVxEhQKDGdhY2hh" + "X3JhbmRvbRgCIAEoDRIWCg5zaW11bGF0ZV9tYWdpYxgKIAEoDRIQCghnYWNo" + "YV9pZBgMIAEoDRIRCglnYWNoYV9udW0YDyABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DoGachaCsReq), DoGachaCsReq.Parser, new string[4] { "GachaRandom", "SimulateMagic", "GachaId", "GachaNum" }, null, null, null, null)
		}));
	}
}
