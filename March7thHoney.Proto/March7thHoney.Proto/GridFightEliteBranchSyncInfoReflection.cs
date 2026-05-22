using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEliteBranchSyncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEliteBranchSyncInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHcmlkRmlnaHRFbGl0ZUJyYW5jaFN5bmNJbmZvLnByb3RvIjcKHEdyaWRG" + "aWdodEVsaXRlQnJhbmNoU3luY0luZm8SFwoPZWxpdGVfYnJhbmNoX2lkGAQg" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightEliteBranchSyncInfo), GridFightEliteBranchSyncInfo.Parser, new string[1] { "EliteBranchId" }, null, null, null, null)
		}));
	}
}
