using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NpcDialogueEventParamReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NpcDialogueEventParamReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtOcGNEaWFsb2d1ZUV2ZW50UGFyYW0ucHJvdG8iSAoVTnBjRGlhbG9ndWVF" + "dmVudFBhcmFtEg4KBmFyZ19pZBgJIAEoDRIfChdyb2d1ZV9kaWFsb2d1ZV9l" + "dmVudF9pZBgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NpcDialogueEventParam), NpcDialogueEventParam.Parser, new string[2] { "ArgId", "RogueDialogueEventId" }, null, null, null, null)
		}));
	}
}
