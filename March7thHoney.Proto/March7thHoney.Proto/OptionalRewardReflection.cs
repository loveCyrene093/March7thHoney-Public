using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OptionalRewardReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OptionalRewardReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRPcHRpb25hbFJld2FyZC5wcm90byI7Cg5PcHRpb25hbFJld2FyZBIaChJv" + "cHRpb25hbF9yZXdhcmRfaWQYBCABKA0SDQoFbGV2ZWwYCCABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OptionalReward), OptionalReward.Parser, new string[2] { "OptionalRewardId", "Level" }, null, null, null, null)
		}));
	}
}
