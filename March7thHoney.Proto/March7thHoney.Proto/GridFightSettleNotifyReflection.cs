using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSettleNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSettleNotifyReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChtHcmlkRmlnaHRTZXR0bGVOb3RpZnkucHJvdG8aGUdyaWRGaWdodEZpbmlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "aEluZm8ucHJvdG8i7AEKFUdyaWRGaWdodFNldHRsZU5vdGlmeRITCgtJSUdN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "T0lHT0VMQhgDIAEoDRITCgtQR01KUExMTklBSxgFIAEoDRITCgtFREtJSUNJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "S0pLTBgGIAEoDRITCgtFRElHRk5GUEJLQRgHIAEoDRITCgtCSExEQUVLTk1D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "RBgJIAEoDRITCgtPSE9QS0FBS09HRhgMIAEoDRITCgtDQU1MREFKSktCTxgg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "IAEoDRIqCgtFREtKTVBBQ0hOShjWASABKAsyFC5HcmlkRmlnaHRGaW5pc2hJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "bmZvEhQKC0hJRk5DUFBKRkVOGJwFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[1] { GridFightFinishInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSettleNotify), GridFightSettleNotify.Parser, new string[9] { "IIGMOIGOELB", "PGMJPLLNIAK", "EDKIICIKJKL", "EDIGFNFPBKA", "BHLDAEKNMCD", "OHOPKAAKOGF", "CAMLDAJJKBO", "EDKJMPACHNJ", "HIFNCPPJFEN" }, null, null, null, null)
		}));
	}
}
