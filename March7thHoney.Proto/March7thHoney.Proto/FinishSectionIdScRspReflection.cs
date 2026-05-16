using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishSectionIdScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishSectionIdScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpGaW5pc2hTZWN0aW9uSWRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8i" + "VgoURmluaXNoU2VjdGlvbklkU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIZCgZy" + "ZXdhcmQYAyABKAsyCS5JdGVtTGlzdBISCgpzZWN0aW9uX2lkGAwgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishSectionIdScRsp), FinishSectionIdScRsp.Parser, new string[3] { "Retcode", "Reward", "SectionId" }, null, null, null, null)
		}));
	}
}
