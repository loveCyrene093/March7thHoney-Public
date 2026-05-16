using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AiPamResponseFeedbackCommentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AiPamResponseFeedbackCommentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidBaVBhbVJlc3BvbnNlRmVlZGJhY2tDb21tZW50U2NSc3AucHJvdG8iNAoh" + "QWlQYW1SZXNwb25zZUZlZWRiYWNrQ29tbWVudFNjUnNwEg8KB3JldGNvZGUY" + "CyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AiPamResponseFeedbackCommentScRsp), AiPamResponseFeedbackCommentScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
