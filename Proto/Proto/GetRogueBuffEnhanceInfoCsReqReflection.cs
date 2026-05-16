using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueBuffEnhanceInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueBuffEnhanceInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHZXRSb2d1ZUJ1ZmZFbmhhbmNlSW5mb0NzUmVxLnByb3RvIh4KHEdldFJv" + "Z3VlQnVmZkVuaGFuY2VJbmZvQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueBuffEnhanceInfoCsReq), GetRogueBuffEnhanceInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
