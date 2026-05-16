using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JBJAKAMMKMDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JBJAKAMMKMDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQkpBS0FNTUtNRC5wcm90bxoRTkdQS0tBTUFETkEucHJvdG8iMAoLSkJK" + "QUtBTU1LTUQSIQoLQU9CTk1DSUVORk4YASABKAsyDC5OR1BLS0FNQUROQUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NGPKKAMADNAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JBJAKAMMKMD), JBJAKAMMKMD.Parser, new string[1] { "AOBNMCIENFN" }, null, null, null, null)
		}));
	}
}
