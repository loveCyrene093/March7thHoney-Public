using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BABKEAFELGEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BABKEAFELGEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQUJLRUFGRUxHRS5wcm90bxoRQUtHT0FJUExKTEoucHJvdG8iMAoLQkFC" + "S0VBRkVMR0USIQoLRkVJTE5JS05QQ0IYBSABKAsyDC5BS0dPQUlQTEpMSkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { AKGOAIPLJLJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BABKEAFELGE), BABKEAFELGE.Parser, new string[1] { "FEILNIKNPCB" }, null, null, null, null)
		}));
	}
}
