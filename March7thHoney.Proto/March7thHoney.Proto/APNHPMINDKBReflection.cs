using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APNHPMINDKBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APNHPMINDKBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBUE5IUE1JTkRLQi5wcm90bxoRQkFJS01PTUVKTUIucHJvdG8iMAoLQVBO" + "SFBNSU5ES0ISIQoLSkpBQUJMQ01GTFAYCiADKAsyDC5CQUlLTU9NRUpNQkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BAIKMOMEJMBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APNHPMINDKB), APNHPMINDKB.Parser, new string[1] { "JJAABLCMFLP" }, null, null, null, null)
		}));
	}
}
