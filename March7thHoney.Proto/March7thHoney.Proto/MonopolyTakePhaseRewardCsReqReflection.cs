using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyTakePhaseRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyTakePhaseRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJNb25vcG9seVRha2VQaGFzZVJld2FyZENzUmVxLnByb3RvIjMKHE1vbm9w" + "b2x5VGFrZVBoYXNlUmV3YXJkQ3NSZXESEwoLRkZKRUNBTUlFREwYCiADKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyTakePhaseRewardCsReq), MonopolyTakePhaseRewardCsReq.Parser, new string[1] { "FFJECAMIEDL" }, null, null, null, null)
		}));
	}
}
