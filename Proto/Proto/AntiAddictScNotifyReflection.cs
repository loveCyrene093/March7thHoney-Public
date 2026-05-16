using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AntiAddictScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AntiAddictScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhBbnRpQWRkaWN0U2NOb3RpZnkucHJvdG8iQgoSQW50aUFkZGljdFNjTm90" + "aWZ5Eg0KBWxldmVsGAMgASgJEhAKCG1zZ190eXBlGAcgASgNEgsKA21zZxgP" + "IAEoCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AntiAddictScNotify), AntiAddictScNotify.Parser, new string[3] { "Level", "MsgType", "Msg" }, null, null, null, null)
		}));
	}
}
