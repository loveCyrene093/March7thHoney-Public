using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMbtiReportCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMbtiReportCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHZXRNYnRpUmVwb3J0Q3NSZXEucHJvdG8iFAoSR2V0TWJ0aVJlcG9ydENz" + "UmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMbtiReportCsReq), GetMbtiReportCsReq.Parser, null, null, null, null, null)
		}));
	}
}
