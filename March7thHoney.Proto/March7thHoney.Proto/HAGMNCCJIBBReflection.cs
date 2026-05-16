using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HAGMNCCJIBBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HAGMNCCJIBBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQUdNTkNDSklCQi5wcm90bxoRQkpGSkZDRFBGTkcucHJvdG8iLgoLSEFH" + "TU5DQ0pJQkISHwoJa2lja190eXBlGAQgASgOMgwuQkpGSkZDRFBGTkdCFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { BJFJFCDPFNGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HAGMNCCJIBB), HAGMNCCJIBB.Parser, new string[1] { "KickType" }, null, null, null, null)
		}));
	}
}
