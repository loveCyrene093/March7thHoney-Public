using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AiPamMotionScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AiPamMotionScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlBaVBhbU1vdGlvblNjTm90aWZ5LnByb3RvIioKE0FpUGFtTW90aW9uU2NO" + "b3RpZnkSEwoLQkRKQUNIR0hDSEYYBiADKAlCFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AiPamMotionScNotify), AiPamMotionScNotify.Parser, new string[1] { "BDJACHGHCHF" }, null, null, null, null)
		}));
	}
}
