using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectInclinationTextScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectInclinationTextScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTZWxlY3RJbmNsaW5hdGlvblRleHRTY1JzcC5wcm90byJHChpTZWxlY3RJ" + "bmNsaW5hdGlvblRleHRTY1JzcBIYChB0YWxrX3NlbnRlbmNlX2lkGAkgASgN" + "Eg8KB3JldGNvZGUYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectInclinationTextScRsp), SelectInclinationTextScRsp.Parser, new string[2] { "TalkSentenceId", "Retcode" }, null, null, null, null)
		}));
	}
}
