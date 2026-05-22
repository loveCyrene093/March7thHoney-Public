using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KLKJIBBIBIMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KLKJIBBIBIMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTEtKSUJCSUJJTS5wcm90byIeCgtLTEtKSUJCSUJJTRIPCgdzaG9wX2lk" + "GAEgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KLKJIBBIBIM), KLKJIBBIBIM.Parser, new string[1] { "ShopId" }, null, null, null, null)
		}));
	}
}
