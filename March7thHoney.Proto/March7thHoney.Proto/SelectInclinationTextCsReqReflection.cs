using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectInclinationTextCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectInclinationTextCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTZWxlY3RJbmNsaW5hdGlvblRleHRDc1JlcS5wcm90byI2ChpTZWxlY3RJ" + "bmNsaW5hdGlvblRleHRDc1JlcRIYChB0YWxrX3NlbnRlbmNlX2lkGAkgASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectInclinationTextCsReq), SelectInclinationTextCsReq.Parser, new string[1] { "TalkSentenceId" }, null, null, null, null)
		}));
	}
}
