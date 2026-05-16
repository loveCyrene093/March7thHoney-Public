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
		buffer[0] = "ChtHcmlkRmlnaHRTZXR0bGVOb3RpZnkucHJvdG8aGUdyaWRGaWdodEZpbmlz";
		buffer[1] = "aEluZm8ucHJvdG8i7AEKFUdyaWRGaWdodFNldHRsZU5vdGlmeRITCgtJSUdN";
		buffer[2] = "T0lHT0VMQhgDIAEoDRITCgtQR01KUExMTklBSxgFIAEoDRITCgtFREtJSUNJ";
		buffer[3] = "S0pLTBgGIAEoDRITCgtFRElHRk5GUEJLQRgHIAEoDRITCgtCSExEQUVLTk1D";
		buffer[4] = "RBgJIAEoDRITCgtPSE9QS0FBS09HRhgMIAEoDRITCgtDQU1MREFKSktCTxgg";
		buffer[5] = "IAEoDRIqCgtFREtKTVBBQ0hOShjWASABKAsyFC5HcmlkRmlnaHRGaW5pc2hJ";
		buffer[6] = "bmZvEhQKC0hJRk5DUFBKRkVOGJwFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[7] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightFinishInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSettleNotify), GridFightSettleNotify.Parser, new string[9] { "IIGMOIGOELB", "PGMJPLLNIAK", "EDKIICIKJKL", "EDIGFNFPBKA", "BHLDAEKNMCD", "OHOPKAAKOGF", "CAMLDAJJKBO", "EDKJMPACHNJ", "HIFNCPPJFEN" }, null, null, null, null)
		}));
	}
}
