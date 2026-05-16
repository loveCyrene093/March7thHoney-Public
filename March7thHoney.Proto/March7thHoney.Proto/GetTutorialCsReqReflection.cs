using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTutorialCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTutorialCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHZXRUdXRvcmlhbENzUmVxLnByb3RvIhIKEEdldFR1dG9yaWFsQ3NSZXFC" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTutorialCsReq), GetTutorialCsReq.Parser, null, null, null, null, null)
		}));
	}
}
