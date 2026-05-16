using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerGetFightGateCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerGetFightGateCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1QbGF5ZXJHZXRGaWdodEdhdGVDc1JlcS5wcm90byIuChdQbGF5ZXJHZXRG" + "aWdodEdhdGVDc1JlcRITCgtwbGF5ZXJfZGF0YRgEIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerGetFightGateCsReq), PlayerGetFightGateCsReq.Parser, new string[1] { "PlayerData" }, null, null, null, null)
		}));
	}
}
