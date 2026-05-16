using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DrinkMakerCheersGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DrinkMakerCheersGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJEcmlua01ha2VyQ2hlZXJzR2V0RGF0YUNzUmVxLnByb3RvIh4KHERyaW5r" + "TWFrZXJDaGVlcnNHZXREYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DrinkMakerCheersGetDataCsReq), DrinkMakerCheersGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
