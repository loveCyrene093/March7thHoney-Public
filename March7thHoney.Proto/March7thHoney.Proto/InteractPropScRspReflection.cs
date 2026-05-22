using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class InteractPropScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static InteractPropScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdJbnRlcmFjdFByb3BTY1JzcC5wcm90byJQChFJbnRlcmFjdFByb3BTY1Jz" + "cBISCgpwcm9wX3N0YXRlGAUgASgNEhYKDnByb3BfZW50aXR5X2lkGAsgASgN" + "Eg8KB3JldGNvZGUYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(InteractPropScRsp), InteractPropScRsp.Parser, new string[3] { "PropState", "PropEntityId", "Retcode" }, null, null, null, null)
		}));
	}
}
