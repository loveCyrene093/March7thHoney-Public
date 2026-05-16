using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IAHHLIOLCDBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IAHHLIOLCDBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQUhITElPTENEQi5wcm90byI3CgtJQUhITElPTENEQhITCgtOTkJLUERL" + "UElHSRgGIAEoDRITCgtCSEFQRERKRUhQShgNIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IAHHLIOLCDB), IAHHLIOLCDB.Parser, new string[2] { "NNBKPDKPIGI", "BHAPDDJEHPJ" }, null, null, null, null)
		}));
	}
}
