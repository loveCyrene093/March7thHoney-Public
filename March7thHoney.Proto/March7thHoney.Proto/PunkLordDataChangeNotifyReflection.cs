using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PunkLordDataChangeNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PunkLordDataChangeNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5QdW5rTG9yZERhdGFDaGFuZ2VOb3RpZnkucHJvdG8iWQoYUHVua0xvcmRE" + "YXRhQ2hhbmdlTm90aWZ5EhMKC0NMTU9ORUVJRUpFGAQgASgNEhMKC0VKRkVC" + "Q0tETk5IGAcgASgNEhMKC0RCQUtOQkhMTkpLGAwgASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordDataChangeNotify), PunkLordDataChangeNotify.Parser, new string[3] { "CLMONEEIEJE", "EJFEBCKDNNH", "DBAKNBHLNJK" }, null, null, null, null)
		}));
	}
}
