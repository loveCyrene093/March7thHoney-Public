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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChlHcmlkR2FtZUF1Z21lbnRJbmZvLnByb3RvGhtHcmlkRmlnaHRHYW1lSXRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bUluZm8ucHJvdG8igAEKE0dyaWRHYW1lQXVnbWVudEluZm8SEwoLTkRDRkJL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "SkRQQUgYAyABKAgSEwoLTUhNTE1LREZKTE4YCSABKAgSEgoKYXVnbWVudF9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ZBgKIAEoDRIrCgtQSFBPTEhMSkdGTRgOIAMoCzIWLkdyaWRGaWdodEdhbWVJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dGVtSW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GridFightGameItemInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridGameAugmentInfo), GridGameAugmentInfo.Parser, new string[4] { "NDCFBKJDPAH", "MHMLMKDFJLN", "AugmentId", "PHPOLHLJGFM" }, null, null, null, null)
		}));
	}
}
