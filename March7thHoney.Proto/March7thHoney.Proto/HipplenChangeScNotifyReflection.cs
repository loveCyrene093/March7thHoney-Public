using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HipplenChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HipplenChangeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtIaXBwbGVuQ2hhbmdlU2NOb3RpZnkucHJvdG8aEUtQSElIS0dDSEdPLnBy" + "b3RvIjoKFUhpcHBsZW5DaGFuZ2VTY05vdGlmeRIhCgtDSkZCTEhOUEhBSxgL" + "IAMoCzIMLktQSElIS0dDSEdPQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { KPHIHKGCHGOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HipplenChangeScNotify), HipplenChangeScNotify.Parser, new string[1] { "CJFBLHNPHAK" }, null, null, null, null)
		}));
	}
}
