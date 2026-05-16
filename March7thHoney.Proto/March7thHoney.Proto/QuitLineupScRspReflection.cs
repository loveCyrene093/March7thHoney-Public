using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuitLineupScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuitLineupScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVRdWl0TGluZXVwU2NSc3AucHJvdG8idQoPUXVpdExpbmV1cFNjUnNwEhYK" + "DmJhc2VfYXZhdGFyX2lkGAUgASgNEhIKCmlzX3ZpcnR1YWwYByABKAgSEwoL" + "TEdGSUZKREdFS0IYCyABKAgSEAoIcGxhbmVfaWQYDCABKA0SDwoHcmV0Y29k" + "ZRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuitLineupScRsp), QuitLineupScRsp.Parser, new string[5] { "BaseAvatarId", "IsVirtual", "LGFIFJDGEKB", "PlaneId", "Retcode" }, null, null, null, null)
		}));
	}
}
