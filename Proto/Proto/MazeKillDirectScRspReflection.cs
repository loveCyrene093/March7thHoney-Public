using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MazeKillDirectScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MazeKillDirectScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlNYXplS2lsbERpcmVjdFNjUnNwLnByb3RvIjsKE01hemVLaWxsRGlyZWN0" + "U2NSc3ASEwoLZW50aXR5X2xpc3QYAyADKA0SDwoHcmV0Y29kZRgFIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MazeKillDirectScRsp), MazeKillDirectScRsp.Parser, new string[2] { "EntityList", "Retcode" }, null, null, null, null)
		}));
	}
}
