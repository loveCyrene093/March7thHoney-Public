using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IENNMHMOONMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IENNMHMOONMReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFJRU5OTUhNT09OTS5wcm90bxoRQkdOR0xISEJHTUkucHJvdG8aJEJhdHRs";
		buffer[1] = "ZUdyaWRGaWdodFRyYWl0RWZmZWN0SW5mby5wcm90byK9AQoLSUVOTk1ITU9P";
		buffer[2] = "Tk0SEAoIdHJhaXRfaWQYASABKA0SEwoLTktGREJFSFBOTEcYAiABKA0SOgoR";
		buffer[3] = "dHJhaXRfZWZmZWN0X2xpc3QYAyADKAsyHy5CYXR0bGVHcmlkRmlnaHRUcmFp";
		buffer[4] = "dEVmZmVjdEluZm8SIQoLTUVFUEZLTExJSkIYBSADKAsyDC5CR05HTEhIQkdN";
		buffer[5] = "SRITCgtKSkZOTUFJUERFQhgGIAEoDRITCgtLSU5JS0ZDS0dERhgHIAEoDUIW";
		buffer[6] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BGNGLHHBGMIReflection.Descriptor,
			BattleGridFightTraitEffectInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IENNMHMOONM), IENNMHMOONM.Parser, new string[6] { "TraitId", "NKFDBEHPNLG", "TraitEffectList", "MEEPFKLLIJB", "JJFNMAIPDEB", "KINIKFCKGDF" }, null, null, null, null)
		}));
	}
}
