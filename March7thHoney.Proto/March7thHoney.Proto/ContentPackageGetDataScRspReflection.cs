using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ContentPackageGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ContentPackageGetDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDb250ZW50UGFja2FnZUdldERhdGFTY1JzcC5wcm90bxoYQ29udGVudFBh" + "Y2thZ2VEYXRhLnByb3RvIlAKGkNvbnRlbnRQYWNrYWdlR2V0RGF0YVNjUnNw" + "EiEKBGRhdGEYAyABKAsyEy5Db250ZW50UGFja2FnZURhdGESDwoHcmV0Y29k" + "ZRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ContentPackageDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageGetDataScRsp), ContentPackageGetDataScRsp.Parser, new string[2] { "Data", "Retcode" }, null, null, null, null)
		}));
	}
}
