using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EDIKJLBEAEAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EDIKJLBEAEAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRElLSkxCRUFFQS5wcm90bxoRRE9JSk5DTEpHS08ucHJvdG8iMAoLRURJ" + "S0pMQkVBRUESIQoLUEhQT0xITEpHRk0YCSADKAsyDC5ET0lKTkNMSkdLT0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DOIJNCLJGKOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EDIKJLBEAEA), EDIKJLBEAEA.Parser, new string[1] { "PHPOLHLJGFM" }, null, null, null, null)
		}));
	}
}
