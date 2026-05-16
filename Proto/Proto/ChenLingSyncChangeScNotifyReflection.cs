using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingSyncChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingSyncChangeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDaGVuTGluZ1N5bmNDaGFuZ2VTY05vdGlmeS5wcm90bxoRS0RPSlBES0hI" + "Q0QucHJvdG8iPwoaQ2hlbkxpbmdTeW5jQ2hhbmdlU2NOb3RpZnkSIQoLQ0pG" + "QkxITlBIQUsYDyADKAsyDC5LRE9KUERLSEhDREIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { KDOJPDKHHCDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingSyncChangeScNotify), ChenLingSyncChangeScNotify.Parser, new string[1] { "CJFBLHNPHAK" }, null, null, null, null)
		}));
	}
}
