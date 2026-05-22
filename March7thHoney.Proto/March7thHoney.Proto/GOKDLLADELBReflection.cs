using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GOKDLLADELBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GOKDLLADELBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHT0tETExBREVMQi5wcm90bxoRUm90YXRlckRhdGEucHJvdG8iMAoLR09L" + "RExMQURFTEISIQoLREpIRERPRkhNQ0YYBSADKAsyDC5Sb3RhdGVyRGF0YUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { RotaterDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GOKDLLADELB), GOKDLLADELB.Parser, new string[1] { "DJHDDOFHMCF" }, null, null, null, null)
		}));
	}
}
