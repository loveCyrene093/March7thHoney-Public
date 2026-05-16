using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeBpRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeBpRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUYWtlQnBSZXdhcmRDc1JlcS5wcm90bxoSQnBSZXdhcmRUeXBlLnByb3Rv" + "IlsKEVRha2VCcFJld2FyZENzUmVxEhsKBHR5cGUYAiABKA4yDS5CcFJld2Fy" + "ZFR5cGUSGgoSb3B0aW9uYWxfcmV3YXJkX2lkGAUgASgNEg0KBWxldmVsGA0g" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { BpRewardTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeBpRewardCsReq), TakeBpRewardCsReq.Parser, new string[3] { "Type", "OptionalRewardId", "Level" }, null, null, null, null)
		}));
	}
}
