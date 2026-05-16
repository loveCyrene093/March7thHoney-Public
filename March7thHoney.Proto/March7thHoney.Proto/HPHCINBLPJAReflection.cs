using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HPHCINBLPJAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HPHCINBLPJAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIUEhDSU5CTFBKQS5wcm90byINCgtIUEhDSU5CTFBKQUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HPHCINBLPJA), HPHCINBLPJA.Parser, null, null, null, null, null)
		}));
	}
}
