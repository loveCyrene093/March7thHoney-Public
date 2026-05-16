using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CEIIEHNDPAJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CEIIEHNDPAJReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFDRUlJRUhORFBBSi5wcm90bxoXR3JpZEZpZ2h0U3luY0RhdGEucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "HEdyaWRGaWdodFVwZGF0ZVNyY1R5cGUucHJvdG8ikAEKC0NFSUlFSE5EUEFK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "EjAKD2dyaWRfdXBkYXRlX3NyYxgDIAEoDjIXLkdyaWRGaWdodFVwZGF0ZVNy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "Y1R5cGUSLwoTdXBkYXRlX2R5bmFtaWNfbGlzdBgHIAMoCzISLkdyaWRGaWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "dFN5bmNEYXRhEh4KFnN5bmNfZWZmZWN0X3BhcmFtX2xpc3QYCyADKA1CFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			GridFightSyncDataReflection.Descriptor,
			GridFightUpdateSrcTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CEIIEHNDPAJ), CEIIEHNDPAJ.Parser, new string[3] { "GridUpdateSrc", "UpdateDynamicList", "SyncEffectParamList" }, null, null, null, null)
		}));
	}
}
