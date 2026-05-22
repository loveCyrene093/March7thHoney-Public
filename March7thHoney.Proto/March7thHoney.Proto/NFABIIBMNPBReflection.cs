using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NFABIIBMNPBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NFABIIBMNPBReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFORkFCSUlCTU5QQi5wcm90byL4AQoLTkZBQklJQk1OUEISCwoDcG9zGAEg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "ASgNEg8KB3JvbGVfaWQYAiABKA0SEQoJcm9sZV9zdGFyGAMgASgNEhwKFGdy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "aWRfZmlnaHRfaXRlbV9saXN0GAQgAygNElYKH2dyaWRfZmlnaHRfdmFsdWVf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "aW5pdF9jb21wb25lbnQYBSADKAsyLS5ORkFCSUlCTU5QQi5HcmlkRmlnaHRW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "YWx1ZUluaXRDb21wb25lbnRFbnRyeRpCCiBHcmlkRmlnaHRWYWx1ZUluaXRD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "b21wb25lbnRFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKA06AjgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NFABIIBMNPB), NFABIIBMNPB.Parser, new string[5] { "Pos", "RoleId", "RoleStar", "GridFightItemList", "GridFightValueInitComponent" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
