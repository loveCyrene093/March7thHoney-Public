using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BIBLMLDGCOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BIBLMLDGCOBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSUJMTUxER0NPQi5wcm90byIvCgtCSUJMTUxER0NPQhITCgtLREhMQ0VQ" + "UENDShgCIAEoDRILCgN1aWQYBCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BIBLMLDGCOB), BIBLMLDGCOB.Parser, new string[2] { "KDHLCEPPCCJ", "Uid" }, null, null, null, null)
		}));
	}
}
