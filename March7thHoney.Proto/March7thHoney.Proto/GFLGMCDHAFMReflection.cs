using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GFLGMCDHAFMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GFLGMCDHAFMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHRkxHTUNESEFGTS5wcm90bxoRSkFGUE1MTE9HREkucHJvdG8iMAoLR0ZM" + "R01DREhBRk0SIQoLSERLSEVDSFBJR0oYAiABKAsyDC5KQUZQTUxMT0dESUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JAFPMLLOGDIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GFLGMCDHAFM), GFLGMCDHAFM.Parser, new string[1] { "HDKHECHPIGJ" }, null, null, null, null)
		}));
	}
}
