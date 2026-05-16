using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSystemInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSystemInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChlHcmlkRmlnaHRTeXN0ZW1JbmZvLnByb3RvGh1HcmlkRmlnaHRTdGF0aWNH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YW1lSW5mby5wcm90bxoRTUlHRUFIREVCT0UucHJvdG8iZwoTR3JpZEZpZ2h0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "U3lzdGVtSW5mbxItCgtFR0xDS0dLRUNBShgIIAEoCzIYLkdyaWRGaWdodFN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "YXRpY0dhbWVJbmZvEiEKC0ZDS0tHRkZMREZBGA0gASgLMgwuTUlHRUFIREVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "T0VCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GridFightStaticGameInfoReflection.Descriptor,
			MIGEAHDEBOEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSystemInfo), GridFightSystemInfo.Parser, new string[2] { "EGLCKGKECAJ", "FCKKGFFLDFA" }, null, null, null, null)
		}));
	}
}
