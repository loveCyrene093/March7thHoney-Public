using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightLockShopCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightLockShopCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHcmlkRmlnaHRMb2NrU2hvcENzUmVxLnByb3RvIisKFkdyaWRGaWdodExv" + "Y2tTaG9wQ3NSZXESEQoJaXNfbG9ja2VkGAEgASgIQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightLockShopCsReq), GridFightLockShopCsReq.Parser, new string[1] { "IsLocked" }, null, null, null, null)
		}));
	}
}
