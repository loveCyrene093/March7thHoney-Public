using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JIBAKJGOPJMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JIBAKJGOPJMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKSUJBS0pHT1BKTS5wcm90byI3CgtKSUJBS0pHT1BKTRITCgtCUEpBRkJG" + "RlBQSBgHIAEoDRITCgtJSUdNT0lHT0VMQhgPIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JIBAKJGOPJM), JIBAKJGOPJM.Parser, new string[2] { "BPJAFBFFPPH", "IIGMOIGOELB" }, null, null, null, null)
		}));
	}
}
