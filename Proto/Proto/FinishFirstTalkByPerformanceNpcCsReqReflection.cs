using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishFirstTalkByPerformanceNpcCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishFirstTalkByPerformanceNpcCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipGaW5pc2hGaXJzdFRhbGtCeVBlcmZvcm1hbmNlTnBjQ3NSZXEucHJvdG8i" + "PgokRmluaXNoRmlyc3RUYWxrQnlQZXJmb3JtYW5jZU5wY0NzUmVxEhYKDnBl" + "cmZvcm1hbmNlX2lkGAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishFirstTalkByPerformanceNpcCsReq), FinishFirstTalkByPerformanceNpcCsReq.Parser, new string[1] { "PerformanceId" }, null, null, null, null)
		}));
	}
}
