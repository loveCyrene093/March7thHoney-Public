using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightQuitLeaveGamePlayCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightQuitLeaveGamePlayCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVHcmlkRmlnaHRRdWl0TGVhdmVHYW1lUGxheUNzUmVxLnByb3RvIiEKH0dy" + "aWRGaWdodFF1aXRMZWF2ZUdhbWVQbGF5Q3NSZXFCFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightQuitLeaveGamePlayCsReq), GridFightQuitLeaveGamePlayCsReq.Parser, null, null, null, null, null)
		}));
	}
}
