using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MKPCNGNIFDKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MKPCNGNIFDKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNS1BDTkdOSUZESy5wcm90bxoRSkFGUE1MTE9HREkucHJvdG8iMAoLTUtQ" + "Q05HTklGREsSIQoLUEhHTEZIRERBQ00YBCADKAsyDC5KQUZQTUxMT0dESUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JAFPMLLOGDIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MKPCNGNIFDK), MKPCNGNIFDK.Parser, new string[1] { "PHGLFHDDACM" }, null, null, null, null)
		}));
	}
}
