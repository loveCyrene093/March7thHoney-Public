using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FJPONJFLOOHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FJPONJFLOOHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSlBPTkpGTE9PSC5wcm90bxoRTUpKRUhDQk5PS0kucHJvdG8iMAoLRkpQ" + "T05KRkxPT0gSIQoLRURKUE1OTExHR0IYCyADKAsyDC5NSkpFSENCTk9LSUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { MJJEHCBNOKIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FJPONJFLOOH), FJPONJFLOOH.Parser, new string[1] { "EDJPMNLLGGB" }, null, null, null, null)
		}));
	}
}
