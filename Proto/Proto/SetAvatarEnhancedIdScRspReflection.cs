using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetAvatarEnhancedIdScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetAvatarEnhancedIdScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TZXRBdmF0YXJFbmhhbmNlZElkU2NSc3AucHJvdG8iXgoYU2V0QXZhdGFy" + "RW5oYW5jZWRJZFNjUnNwEhgKEGdyb3d0aF9hdmF0YXJfaWQYBSABKA0SDwoH" + "cmV0Y29kZRgGIAEoDRIXCg91bmtfZW5oYW5jZWRfaWQYCyABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetAvatarEnhancedIdScRsp), SetAvatarEnhancedIdScRsp.Parser, new string[3] { "GrowthAvatarId", "Retcode", "UnkEnhancedId" }, null, null, null, null)
		}));
	}
}
