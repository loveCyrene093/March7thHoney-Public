using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DelMailScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DelMailScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJEZWxNYWlsU2NSc3AucHJvdG8iMAoMRGVsTWFpbFNjUnNwEg8KB2lkX2xp" + "c3QYASADKA0SDwoHcmV0Y29kZRgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DelMailScRsp), DelMailScRsp.Parser, new string[2] { "IdList", "Retcode" }, null, null, null, null)
		}));
	}
}
