using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FNJHKMNEOCBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FNJHKMNEOCBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTkpIS01ORU9DQi5wcm90byINCgtGTkpIS01ORU9DQkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FNJHKMNEOCB), FNJHKMNEOCB.Parser, null, null, null, null, null)
		}));
	}
}
