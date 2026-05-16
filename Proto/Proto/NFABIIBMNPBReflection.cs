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
		buffer[0] = "ChFORkFCSUlCTU5QQi5wcm90byL4AQoLTkZBQklJQk1OUEISCwoDcG9zGAEg";
		buffer[1] = "ASgNEg8KB3JvbGVfaWQYAiABKA0SEQoJcm9sZV9zdGFyGAMgASgNEhwKFGdy";
		buffer[2] = "aWRfZmlnaHRfaXRlbV9saXN0GAQgAygNElYKH2dyaWRfZmlnaHRfdmFsdWVf";
		buffer[3] = "aW5pdF9jb21wb25lbnQYBSADKAsyLS5ORkFCSUlCTU5QQi5HcmlkRmlnaHRW";
		buffer[4] = "YWx1ZUluaXRDb21wb25lbnRFbnRyeRpCCiBHcmlkRmlnaHRWYWx1ZUluaXRD";
		buffer[5] = "b21wb25lbnRFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKA06AjgB";
		buffer[6] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NFABIIBMNPB), NFABIIBMNPB.Parser, new string[5] { "Pos", "RoleId", "RoleStar", "GridFightItemList", "GridFightValueInitComponent" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
