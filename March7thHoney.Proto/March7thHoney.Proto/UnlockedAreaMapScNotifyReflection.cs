using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockedAreaMapScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockedAreaMapScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1VbmxvY2tlZEFyZWFNYXBTY05vdGlmeS5wcm90byIwChdVbmxvY2tlZEFy" + "ZWFNYXBTY05vdGlmeRIVCg1lbnRyeV9pZF9saXN0GAogAygNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockedAreaMapScNotify), UnlockedAreaMapScNotify.Parser, new string[1] { "EntryIdList" }, null, null, null, null)
		}));
	}
}
