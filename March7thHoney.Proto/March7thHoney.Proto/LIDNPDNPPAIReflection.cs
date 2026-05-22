using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LIDNPDNPPAIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LIDNPDNPPAIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMSUROUEROUFBBSS5wcm90byIyCgtMSUROUEROUFBBSRIRCgltYXhfc2Nv" + "cmUYCCABKA0SEAoIc3RhZ2VfaWQYCyABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LIDNPDNPPAI), LIDNPDNPPAI.Parser, new string[2] { "MaxScore", "StageId" }, null, null, null, null)
		}));
	}
}
