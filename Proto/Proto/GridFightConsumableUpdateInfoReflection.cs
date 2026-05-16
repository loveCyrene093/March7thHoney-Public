using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightConsumableUpdateInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightConsumableUpdateInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNHcmlkRmlnaHRDb25zdW1hYmxlVXBkYXRlSW5mby5wcm90byJXCh1Hcmlk" + "RmlnaHRDb25zdW1hYmxlVXBkYXRlSW5mbxIYChBpdGVtX3N0YWNrX2NvdW50" + "GAogASgFEgsKA251bRgLIAEoDRIPCgdpdGVtX2lkGA4gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightConsumableUpdateInfo), GridFightConsumableUpdateInfo.Parser, new string[3] { "ItemStackCount", "Num", "ItemId" }, null, null, null, null)
		}));
	}
}
