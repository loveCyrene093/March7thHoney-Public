using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PHDKMFDPABIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PHDKMFDPABIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQSERLTUZEUEFCSS5wcm90byIjCgtQSERLTUZEUEFCSRIUCgxtYXplX2J1" + "ZmZfaWQYCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PHDKMFDPABI), PHDKMFDPABI.Parser, new string[1] { "MazeBuffId" }, null, null, null, null)
		}));
	}
}
