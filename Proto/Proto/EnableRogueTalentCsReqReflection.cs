using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnableRogueTalentCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnableRogueTalentCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxFbmFibGVSb2d1ZVRhbGVudENzUmVxLnByb3RvIi0KFkVuYWJsZVJvZ3Vl" + "VGFsZW50Q3NSZXESEwoLS0ZKRU1JT0pMUEoYCCABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnableRogueTalentCsReq), EnableRogueTalentCsReq.Parser, new string[1] { "KFJEMIOJLPJ" }, null, null, null, null)
		}));
	}
}
