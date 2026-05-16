using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockPhoneCaseScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockPhoneCaseScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1VbmxvY2tQaG9uZUNhc2VTY05vdGlmeS5wcm90byIwChdVbmxvY2tQaG9u" + "ZUNhc2VTY05vdGlmeRIVCg1waG9uZV9jYXNlX2lkGAkgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockPhoneCaseScNotify), UnlockPhoneCaseScNotify.Parser, new string[1] { "PhoneCaseId" }, null, null, null, null)
		}));
	}
}
