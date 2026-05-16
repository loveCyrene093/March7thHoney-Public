using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LBMDGNJPPKOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LBMDGNJPPKOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQk1ER05KUFBLTy5wcm90byIbCgtMQk1ER05KUFBLTxIMCgRnb2xkGAUg" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LBMDGNJPPKO), LBMDGNJPPKO.Parser, new string[1] { "Gold" }, null, null, null, null)
		}));
	}
}
