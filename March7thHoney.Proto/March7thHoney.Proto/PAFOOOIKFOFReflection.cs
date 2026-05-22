using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PAFOOOIKFOFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PAFOOOIKFOFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQUZPT09JS0ZPRi5wcm90byIvCgtQQUZPT09JS0ZPRhITCgtIQ1BBSFBD" + "T0VLSxgDIAEoDRILCgNudW0YByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PAFOOOIKFOF), PAFOOOIKFOF.Parser, new string[2] { "HCPAHPCOEKK", "Num" }, null, null, null, null)
		}));
	}
}
