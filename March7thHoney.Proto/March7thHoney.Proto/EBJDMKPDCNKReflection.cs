using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EBJDMKPDCNKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EBJDMKPDCNKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQkpETUtQRENOSy5wcm90bxoRSkFGTUZHSkxHR0EucHJvdG8iMAoLRUJK" + "RE1LUERDTksSIQoLbGluZXVwX2xpc3QYASADKAsyDC5KQUZNRkdKTEdHQUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JAFMFGJLGGAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EBJDMKPDCNK), EBJDMKPDCNK.Parser, new string[1] { "LineupList" }, null, null, null, null)
		}));
	}
}
