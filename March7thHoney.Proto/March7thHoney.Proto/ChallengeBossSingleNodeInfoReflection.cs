using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeBossSingleNodeInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeBossSingleNodeInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDaGFsbGVuZ2VCb3NzU2luZ2xlTm9kZUluZm8ucHJvdG8iZgobQ2hhbGxl" + "bmdlQm9zc1NpbmdsZU5vZGVJbmZvEhEKCW1heF9zY29yZRgDIAEoDRIOCgZp" + "c193aW4YBCABKAgSEwoLSkJKT0RFSEFESkIYByABKAgSDwoHYnVmZl9pZBgI" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossSingleNodeInfo), ChallengeBossSingleNodeInfo.Parser, new string[4] { "MaxScore", "IsWin", "JBJODEHADJB", "BuffId" }, null, null, null, null)
		}));
	}
}
