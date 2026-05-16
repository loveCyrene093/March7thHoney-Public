using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPlayerBoardDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPlayerBoardDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRQbGF5ZXJCb2FyZERhdGFDc1JlcS5wcm90byIZChdHZXRQbGF5ZXJC" + "b2FyZERhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPlayerBoardDataCsReq), GetPlayerBoardDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
