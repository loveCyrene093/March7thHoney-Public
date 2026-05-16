using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetGameplayBirthdayScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetGameplayBirthdayScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TZXRHYW1lcGxheUJpcnRoZGF5U2NSc3AucHJvdG8iPQoYU2V0R2FtZXBs" + "YXlCaXJ0aGRheVNjUnNwEg8KB3JldGNvZGUYDCABKA0SEAoIYmlydGhkYXkY" + "DSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetGameplayBirthdayScRsp), SetGameplayBirthdayScRsp.Parser, new string[2] { "Retcode", "Birthday" }, null, null, null, null)
		}));
	}
}
