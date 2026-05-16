using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRaidInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRaidInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHZXRSYWlkSW5mb0NzUmVxLnByb3RvIhIKEEdldFJhaWRJbmZvQ3NSZXFC" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRaidInfoCsReq), GetRaidInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
