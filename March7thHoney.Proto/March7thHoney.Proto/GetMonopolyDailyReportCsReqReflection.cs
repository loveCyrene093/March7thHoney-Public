using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMonopolyDailyReportCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMonopolyDailyReportCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRNb25vcG9seURhaWx5UmVwb3J0Q3NSZXEucHJvdG8iHQobR2V0TW9u" + "b3BvbHlEYWlseVJlcG9ydENzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMonopolyDailyReportCsReq), GetMonopolyDailyReportCsReq.Parser, null, null, null, null, null)
		}));
	}
}
