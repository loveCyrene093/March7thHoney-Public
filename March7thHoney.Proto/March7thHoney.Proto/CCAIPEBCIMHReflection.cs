using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CCAIPEBCIMHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CCAIPEBCIMHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQ0FJUEVCQ0lNSC5wcm90byIsCgtDQ0FJUEVCQ0lNSBIPCgdwcm9wX2lk" + "GAMgASgNEgwKBHRpbWUYCiABKANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CCAIPEBCIMH), CCAIPEBCIMH.Parser, new string[2] { "PropId", "Time" }, null, null, null, null)
		}));
	}
}
