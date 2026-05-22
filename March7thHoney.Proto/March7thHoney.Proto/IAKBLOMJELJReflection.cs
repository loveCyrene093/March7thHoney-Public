using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IAKBLOMJELJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IAKBLOMJELJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQUtCTE9NSkVMSi5wcm90byIzCgtJQUtCTE9NSkVMShIPCgdyZXRjb2Rl" + "GAIgASgNEhMKC0RFT0lDQkJHUElDGAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IAKBLOMJELJ), IAKBLOMJELJ.Parser, new string[2] { "Retcode", "DEOICBBGPIC" }, null, null, null, null)
		}));
	}
}
