using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EvolveBuildQueryInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EvolveBuildQueryInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Fdm9sdmVCdWlsZFF1ZXJ5SW5mb0NzUmVxLnByb3RvIhsKGUV2b2x2ZUJ1" + "aWxkUXVlcnlJbmZvQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildQueryInfoCsReq), EvolveBuildQueryInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
