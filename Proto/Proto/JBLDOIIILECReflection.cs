using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JBLDOIIILECReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JBLDOIIILECReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQkxET0lJSUxFQy5wcm90bxoRRUFPRFBJRk1BTkMucHJvdG8iMAoLSkJM" + "RE9JSUlMRUMSIQoLRUJLREpITEZPR04YBCADKAsyDC5FQU9EUElGTUFOQ0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { EAODPIFMANCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JBLDOIIILEC), JBLDOIIILEC.Parser, new string[1] { "EBKDJHLFOGN" }, null, null, null, null)
		}));
	}
}
