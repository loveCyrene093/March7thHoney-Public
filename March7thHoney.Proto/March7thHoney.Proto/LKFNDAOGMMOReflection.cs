using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LKFNDAOGMMOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LKFNDAOGMMOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMS0ZOREFPR01NTy5wcm90byIwCgtMS0ZOREFPR01NTxIRCgljb25maWdf" + "aWQYDSABKA0SDgoGZGFtYWdlGA4gASgBQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LKFNDAOGMMO), LKFNDAOGMMO.Parser, new string[2] { "ConfigId", "Damage" }, null, null, null, null)
		}));
	}
}
