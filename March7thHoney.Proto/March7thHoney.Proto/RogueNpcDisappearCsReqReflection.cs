using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueNpcDisappearCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueNpcDisappearCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSb2d1ZU5wY0Rpc2FwcGVhckNzUmVxLnByb3RvIi0KFlJvZ3VlTnBjRGlz" + "YXBwZWFyQ3NSZXESEwoLQ0NMTkRJSk5KRFAYDiABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueNpcDisappearCsReq), RogueNpcDisappearCsReq.Parser, new string[1] { "CCLNDIJNJDP" }, null, null, null, null)
		}));
	}
}
