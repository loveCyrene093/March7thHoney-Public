using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridGameAugmentInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridGameAugmentInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChlHcmlkR2FtZUF1Z21lbnRJbmZvLnByb3RvGhtHcmlkRmlnaHRHYW1lSXRl";
		buffer[1] = "bUluZm8ucHJvdG8igAEKE0dyaWRHYW1lQXVnbWVudEluZm8SEwoLTkRDRkJL";
		buffer[2] = "SkRQQUgYAyABKAgSEwoLTUhNTE1LREZKTE4YCSABKAgSEgoKYXVnbWVudF9p";
		buffer[3] = "ZBgKIAEoDRIrCgtQSFBPTEhMSkdGTRgOIAMoCzIWLkdyaWRGaWdodEdhbWVJ";
		buffer[4] = "dGVtSW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightGameItemInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridGameAugmentInfo), GridGameAugmentInfo.Parser, new string[4] { "NDCFBKJDPAH", "MHMLMKDFJLN", "AugmentId", "PHPOLHLJGFM" }, null, null, null, null)
		}));
	}
}
