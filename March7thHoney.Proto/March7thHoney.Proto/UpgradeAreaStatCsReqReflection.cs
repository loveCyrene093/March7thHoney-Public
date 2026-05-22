using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpgradeAreaStatCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpgradeAreaStatCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpVcGdyYWRlQXJlYVN0YXRDc1JlcS5wcm90bxoOU3RhdFR5cGUucHJvdG8i" + "VgoUVXBncmFkZUFyZWFTdGF0Q3NSZXESDQoFbGV2ZWwYByABKA0SHgoLREdG" + "R05NSkFMR0oYDCABKA4yCS5TdGF0VHlwZRIPCgdhcmVhX2lkGA4gASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { StatTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpgradeAreaStatCsReq), UpgradeAreaStatCsReq.Parser, new string[3] { "Level", "DGFGNMJALGJ", "AreaId" }, null, null, null, null)
		}));
	}
}
