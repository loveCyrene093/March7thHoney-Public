using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightPortalBuffActionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightPortalBuffActionInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiNHcmlkRmlnaHRQb3J0YWxCdWZmQWN0aW9uSW5mby5wcm90byKDAQodR3Jp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ZEZpZ2h0UG9ydGFsQnVmZkFjdGlvbkluZm8SEwoLRU9PUE9GQ0NIQUEYASAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "KA0SEwoLTUdDRUxDQUpMTEcYAiABKA0SIwobZ3JpZF9maWdodF9wb3J0YWxf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "YnVmZl9saXN0GAUgAygNEhMKC0ZDSFBKS0FJQkhCGA0gASgNQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightPortalBuffActionInfo), GridFightPortalBuffActionInfo.Parser, new string[4] { "EOOPOFCCHAA", "MGCELCAJLLG", "GridFightPortalBuffList", "FCHPJKAIBHB" }, null, null, null, null)
		}));
	}
}
