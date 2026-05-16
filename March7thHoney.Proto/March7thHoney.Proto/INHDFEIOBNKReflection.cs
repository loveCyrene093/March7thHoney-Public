using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class INHDFEIOBNKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static INHDFEIOBNKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTkhERkVJT0JOSy5wcm90bxoaR3JpZEZpZ2h0Q3VycmVudEluZm8ucHJv" + "dG8iUQoLSU5IREZFSU9CTksSMQoSZmlnaHRfY3VycmVudF9pbmZvGAsgASgL" + "MhUuR3JpZEZpZ2h0Q3VycmVudEluZm8SDwoHcmV0Y29kZRgPIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GridFightCurrentInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(INHDFEIOBNK), INHDFEIOBNK.Parser, new string[2] { "FightCurrentInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
