using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ContentPackageSyncDataScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ContentPackageSyncDataScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRDb250ZW50UGFja2FnZVN5bmNEYXRhU2NOb3RpZnkucHJvdG8aGENvbnRl" + "bnRQYWNrYWdlRGF0YS5wcm90byJDCh5Db250ZW50UGFja2FnZVN5bmNEYXRh" + "U2NOb3RpZnkSIQoEZGF0YRgIIAEoCzITLkNvbnRlbnRQYWNrYWdlRGF0YUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ContentPackageDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageSyncDataScNotify), ContentPackageSyncDataScNotify.Parser, new string[1] { "Data" }, null, null, null, null)
		}));
	}
}
