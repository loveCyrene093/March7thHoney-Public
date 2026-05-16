using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarkChestInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarkChestInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNNYXJrQ2hlc3RJbmZvLnByb3RvIm0KDU1hcmtDaGVzdEluZm8SEQoJY29u" + "ZmlnX2lkGAIgASgNEhMKC0ZETE1HRkpESVBDGAMgASgNEhAKCHBsYW5lX2lk" + "GAQgASgNEhAKCGZsb29yX2lkGAUgASgNEhAKCGdyb3VwX2lkGAggASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarkChestInfo), MarkChestInfo.Parser, new string[5] { "ConfigId", "FDLMGFJDIPC", "PlaneId", "FloorId", "GroupId" }, null, null, null, null)
		}));
	}
}
