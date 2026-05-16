using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMovieRacingDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMovieRacingDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRNb3ZpZVJhY2luZ0RhdGFDc1JlcS5wcm90byIZChdHZXRNb3ZpZVJh" + "Y2luZ0RhdGFDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMovieRacingDataCsReq), GetMovieRacingDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
