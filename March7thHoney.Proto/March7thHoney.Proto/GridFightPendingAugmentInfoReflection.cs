using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightPendingAugmentInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightPendingAugmentInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHcmlkRmlnaHRQZW5kaW5nQXVnbWVudEluZm8ucHJvdG8iWwobR3JpZEZp" + "Z2h0UGVuZGluZ0F1Z21lbnRJbmZvEhMKC09MRExER0NFSU1GGAIgASgNEhIK" + "CmF1Z21lbnRfaWQYBSABKA0SEwoLQUxKQkFERU9QQUgYDCABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightPendingAugmentInfo), GridFightPendingAugmentInfo.Parser, new string[3] { "OLDLDGCEIMF", "AugmentId", "ALJBADEOPAH" }, null, null, null, null)
		}));
	}
}
