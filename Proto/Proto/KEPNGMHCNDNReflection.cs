using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KEPNGMHCNDNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KEPNGMHCNDNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRVBOR01IQ05ETi5wcm90byIjCgtLRVBOR01IQ05EThIUCgxtYXplX2J1" + "ZmZfaWQYBCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KEPNGMHCNDN), KEPNGMHCNDN.Parser, new string[1] { "MazeBuffId" }, null, null, null, null)
		}));
	}
}
