using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ActiveFarmElementScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ActiveFarmElementScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxBY3RpdmVGYXJtRWxlbWVudFNjUnNwLnByb3RvIlEKFkFjdGl2ZUZhcm1F" + "bGVtZW50U2NSc3ASDwoHcmV0Y29kZRgEIAEoDRIRCgllbnRpdHlfaWQYCSAB" + "KA0SEwoLd29ybGRfbGV2ZWwYCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ActiveFarmElementScRsp), ActiveFarmElementScRsp.Parser, new string[3] { "Retcode", "EntityId", "WorldLevel" }, null, null, null, null)
		}));
	}
}
