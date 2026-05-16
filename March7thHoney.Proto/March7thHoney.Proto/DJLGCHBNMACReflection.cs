using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DJLGCHBNMACReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DJLGCHBNMACReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFESkxHQ0hCTk1BQy5wcm90byIjCgtESkxHQ0hCTk1BQxIUCgxjaGFsbGVu" + "Z2VfaWQYBiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DJLGCHBNMAC), DJLGCHBNMAC.Parser, new string[1] { "ChallengeId" }, null, null, null, null)
		}));
	}
}
