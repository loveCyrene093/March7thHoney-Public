using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncGetStuffScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncGetStuffScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTeW5jR2V0U3R1ZmZTY05vdGlmeS5wcm90bxoSR2V0U3R1ZmZUeXBlLnBy" + "b3RvIk8KFFN5bmNHZXRTdHVmZlNjTm90aWZ5EiIKC0pGR0tBTUtISEVGGA0g" + "ASgOMg0uR2V0U3R1ZmZUeXBlEhMKC0dLRkVHSUJHRUdJGA8gASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { GetStuffTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncGetStuffScNotify), SyncGetStuffScNotify.Parser, new string[2] { "JFGKAMKHHEF", "GKFEGIBGEGI" }, null, null, null, null)
		}));
	}
}
