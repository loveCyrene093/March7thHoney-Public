using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FarmElementSweepCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FarmElementSweepCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtGYXJtRWxlbWVudFN3ZWVwQ3NSZXEucHJvdG8iQwoVRmFybUVsZW1lbnRT" + "d2VlcENzUmVxEhUKDUZhcm1FbGVtZW50SWQYASABKA0SEwoLd29ybGRfbGV2" + "ZWwYBiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FarmElementSweepCsReq), FarmElementSweepCsReq.Parser, new string[2] { "FarmElementId", "WorldLevel" }, null, null, null, null)
		}));
	}
}
