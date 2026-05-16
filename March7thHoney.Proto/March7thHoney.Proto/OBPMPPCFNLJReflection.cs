using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OBPMPPCFNLJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OBPMPPCFNLJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQlBNUFBDRk5MSi5wcm90byIpCgtPQlBNUFBDRk5MShINCgV2YWx1ZRgB" + "IAEoARILCgNrZXkYAyABKAlCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OBPMPPCFNLJ), OBPMPPCFNLJ.Parser, new string[2] { "Value", "Key" }, null, null, null, null)
		}));
	}
}
