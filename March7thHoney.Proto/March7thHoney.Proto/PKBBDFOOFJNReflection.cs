using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PKBBDFOOFJNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PKBBDFOOFJNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQS0JCREZPT0ZKTi5wcm90byIgCgtQS0JCREZPT0ZKThIRCglyb2xlX3N0" + "YXIYZSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PKBBDFOOFJN), PKBBDFOOFJN.Parser, new string[1] { "RoleStar" }, null, null, null, null)
		}));
	}
}
