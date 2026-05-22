using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NewMailScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NewMailScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVOZXdNYWlsU2NOb3RpZnkucHJvdG8iJwoPTmV3TWFpbFNjTm90aWZ5EhQK" + "DG1haWxfaWRfbGlzdBgIIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NewMailScNotify), NewMailScNotify.Parser, new string[1] { "MailIdList" }, null, null, null, null)
		}));
	}
}
