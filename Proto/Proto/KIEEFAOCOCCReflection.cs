using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KIEEFAOCOCCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KIEEFAOCOCCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSUVFRkFPQ09DQy5wcm90bxoRQ0dMSUxERUJCSUgucHJvdG8iMAoLS0lF" + "RUZBT0NPQ0MSIQoLTUROT0tKRUFMTlAYASABKAsyDC5DR0xJTERFQkJJSEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { CGLILDEBBIHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KIEEFAOCOCC), KIEEFAOCOCC.Parser, new string[1] { "MDNOKJEALNP" }, null, null, null, null)
		}));
	}
}
