using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MIIOLIIOGIGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MIIOLIIOGIGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSUlPTElJT0dJRy5wcm90bxoRSUVERU1GS0JIRkwucHJvdG8iMAoLTUlJ" + "T0xJSU9HSUcSIQoLS0pPUENESkJMR04YDCABKAsyDC5JRURFTUZLQkhGTEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { IEDEMFKBHFLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MIIOLIIOGIG), MIIOLIIOGIG.Parser, new string[1] { "KJOPCDJBLGN" }, null, null, null, null)
		}));
	}
}
