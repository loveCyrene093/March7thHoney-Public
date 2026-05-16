using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwitchLineupIndexScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwitchLineupIndexScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTd2l0Y2hMaW5ldXBJbmRleFNjUnNwLnByb3RvIjgKFlN3aXRjaExpbmV1" + "cEluZGV4U2NSc3ASDwoHcmV0Y29kZRgGIAEoDRINCgVpbmRleBgKIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchLineupIndexScRsp), SwitchLineupIndexScRsp.Parser, new string[2] { "Retcode", "Index" }, null, null, null, null)
		}));
	}
}
