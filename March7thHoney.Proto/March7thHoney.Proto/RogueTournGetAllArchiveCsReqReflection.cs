using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournGetAllArchiveCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournGetAllArchiveCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZVRvdXJuR2V0QWxsQXJjaGl2ZUNzUmVxLnByb3RvIh4KHFJvZ3Vl" + "VG91cm5HZXRBbGxBcmNoaXZlQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournGetAllArchiveCsReq), RogueTournGetAllArchiveCsReq.Parser, null, null, null, null, null)
		}));
	}
}
