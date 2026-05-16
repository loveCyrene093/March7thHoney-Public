using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetLineupNameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetLineupNameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRMaW5ldXBOYW1lU2NSc3AucHJvdG8iQgoSU2V0TGluZXVwTmFtZVNj" + "UnNwEg8KB3JldGNvZGUYASABKA0SDAoEbmFtZRgKIAEoCRINCgVpbmRleBgL" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetLineupNameScRsp), SetLineupNameScRsp.Parser, new string[3] { "Retcode", "Name", "Index" }, null, null, null, null)
		}));
	}
}
