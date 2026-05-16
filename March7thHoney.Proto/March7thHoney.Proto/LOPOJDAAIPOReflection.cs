using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LOPOJDAAIPOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LOPOJDAAIPOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMT1BPSkRBQUlQTy5wcm90bxoRQkdLSU5DRkdLR0kucHJvdG8iMAoLTE9Q" + "T0pEQUFJUE8SIQoLQUhCRkFBTU5LTk8YASABKAsyDC5CR0tJTkNGR0tHSUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BGKINCFGKGIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LOPOJDAAIPO), LOPOJDAAIPO.Parser, new string[1] { "AHBFAAMNKNO" }, null, null, null, null)
		}));
	}
}
