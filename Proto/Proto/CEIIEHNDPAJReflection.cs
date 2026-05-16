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
		buffer[0] = "ChFDRUlJRUhORFBBSi5wcm90bxoXR3JpZEZpZ2h0U3luY0RhdGEucHJvdG8a";
		buffer[1] = "HEdyaWRGaWdodFVwZGF0ZVNyY1R5cGUucHJvdG8ikAEKC0NFSUlFSE5EUEFK";
		buffer[2] = "EjAKD2dyaWRfdXBkYXRlX3NyYxgDIAEoDjIXLkdyaWRGaWdodFVwZGF0ZVNy";
		buffer[3] = "Y1R5cGUSLwoTdXBkYXRlX2R5bmFtaWNfbGlzdBgHIAMoCzISLkdyaWRGaWdo";
		buffer[4] = "dFN5bmNEYXRhEh4KFnN5bmNfZWZmZWN0X3BhcmFtX2xpc3QYCyADKA1CFqoC";
		buffer[5] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GridFightSyncDataReflection.Descriptor,
			GridFightUpdateSrcTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CEIIEHNDPAJ), CEIIEHNDPAJ.Parser, new string[3] { "GridUpdateSrc", "UpdateDynamicList", "SyncEffectParamList" }, null, null, null, null)
		}));
	}
}
