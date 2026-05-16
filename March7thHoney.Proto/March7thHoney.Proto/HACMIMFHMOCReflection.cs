using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HACMIMFHMOCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HACMIMFHMOCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQUNNSU1GSE1PQy5wcm90byIiCgtIQUNNSU1GSE1PQxITCgtIRk1MTUpB" + "TExQQxgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HACMIMFHMOC), HACMIMFHMOC.Parser, new string[1] { "HFMLMJALLPC" }, null, null, null, null)
		}));
	}
}
