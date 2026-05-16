using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGetDailyInitItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGetDailyInitItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNNb25vcG9seUdldERhaWx5SW5pdEl0ZW1Dc1JlcS5wcm90byI0Ch1Nb25v" + "cG9seUdldERhaWx5SW5pdEl0ZW1Dc1JlcRITCgtHSUlEQkZKQ0xERRgGIAEo" + "CEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGetDailyInitItemCsReq), MonopolyGetDailyInitItemCsReq.Parser, new string[1] { "GIIDBFJCLDE" }, null, null, null, null)
		}));
	}
}
