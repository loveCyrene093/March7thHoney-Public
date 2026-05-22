using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ENDOLEJCHKPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ENDOLEJCHKPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTkRPTEVKQ0hLUC5wcm90byIxCgtFTkRPTEVKQ0hLUBIPCgdyYWlkX2lk" + "GAggASgNEhEKCW1heF9zY29yZRgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ENDOLEJCHKP), ENDOLEJCHKP.Parser, new string[2] { "RaidId", "MaxScore" }, null, null, null, null)
		}));
	}
}
