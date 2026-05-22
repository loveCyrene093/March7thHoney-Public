using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CIGIICEJLJEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CIGIICEJLJEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDSUdJSUNFSkxKRS5wcm90byJpCgtDSUdJSUNFSkxKRRIbChNiYXNlX2F2" + "YXRhcl9pZF9saXN0GAIgAygNEiUKHXVuZmluaXNoZWRfc3RvcnlfbGluZV9p" + "ZF9saXN0GAwgAygNEhYKDnByb3BfZW50aXR5X2lkGA4gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CIGIICEJLJE), CIGIICEJLJE.Parser, new string[3] { "BaseAvatarIdList", "UnfinishedStoryLineIdList", "PropEntityId" }, null, null, null, null)
		}));
	}
}
