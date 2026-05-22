using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class POFKPELNBBLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static POFKPELNBBLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQT0ZLUEVMTkJCTC5wcm90bxoRSkVMREFLS0hBTkMucHJvdG8iMAoLUE9G" + "S1BFTE5CQkwSIQoLQUJJSEhBQ0JQUEYYDyADKAsyDC5KRUxEQUtLSEFOQ0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JELDAKKHANCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(POFKPELNBBL), POFKPELNBBL.Parser, new string[1] { "ABIHHACBPPF" }, null, null, null, null)
		}));
	}
}
