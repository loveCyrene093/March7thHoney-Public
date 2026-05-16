using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LGKDBECKMBMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LGKDBECKMBMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMR0tEQkVDS01CTS5wcm90bxoRRkdQRUZFRUxPQ08ucHJvdG8iMAoLTEdL" + "REJFQ0tNQk0SIQoLSktQQURQSENPSkoYCSABKAsyDC5GR1BFRkVFTE9DT0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { FGPEFEELOCOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LGKDBECKMBM), LGKDBECKMBM.Parser, new string[1] { "JKPADPHCOJJ" }, null, null, null, null)
		}));
	}
}
