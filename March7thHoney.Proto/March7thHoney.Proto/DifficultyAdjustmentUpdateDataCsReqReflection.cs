using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DifficultyAdjustmentUpdateDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DifficultyAdjustmentUpdateDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilEaWZmaWN1bHR5QWRqdXN0bWVudFVwZGF0ZURhdGFDc1JlcS5wcm90bxoR" + "TE1IT0lNTEdOR00ucHJvdG8iQQojRGlmZmljdWx0eUFkanVzdG1lbnRVcGRh" + "dGVEYXRhQ3NSZXESGgoEZGF0YRgCIAEoCzIMLkxNSE9JTUxHTkdNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { LMHOIMLGNGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DifficultyAdjustmentUpdateDataCsReq), DifficultyAdjustmentUpdateDataCsReq.Parser, new string[1] { "Data" }, null, null, null, null)
		}));
	}
}
