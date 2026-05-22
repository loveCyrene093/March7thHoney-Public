using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SubmitEmotionItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SubmitEmotionItemScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxTdWJtaXRFbW90aW9uSXRlbVNjUnNwLnByb3RvIjwKFlN1Ym1pdEVtb3Rp" + "b25JdGVtU2NSc3ASDwoHcmV0Y29kZRgKIAEoDRIRCglzY3JpcHRfaWQYDyAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SubmitEmotionItemScRsp), SubmitEmotionItemScRsp.Parser, new string[2] { "Retcode", "ScriptId" }, null, null, null, null)
		}));
	}
}
