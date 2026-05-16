using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBIINELNDKHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBIINELNDKHReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFCQklJTkVMTkRLSC5wcm90byKFAgoLQkJJSU5FTE5ES0gSGwoTbW9uc3Rl";
		buffer[1] = "cl9iYXR0bGVfdHlwZRgBIAEoDRITCgtHSk9KTEVPQkpGShgCIAEoBBIQCghs";
		buffer[2] = "ZXZlbF9pZBgDIAEoDRITCgtJT0pLREdDRkNHRxgEIAEoDRITCgtJQUhETU1H";
		buffer[3] = "TktFUBgFIAEoCBITCgtCQ0pNT0VNREdKSxgGIAEoDRIMCgRyYW5rGAcgASgN";
		buffer[4] = "EhMKC0JFRkpMRktKRkpEGAggASgEEhMKC1BCTUxET0VCREVHGAkgASgNEhMK";
		buffer[5] = "C0NFQ0dLTUhJSkhJGAogASgNEhEKCWJ1ZmZfbGlzdBgLIAMoDRITCgtMSUhD";
		buffer[6] = "TktIR0JJTRgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBIINELNDKH), BBIINELNDKH.Parser, new string[12]
			{
				"MonsterBattleType", "GJOJLEOBJFJ", "LevelId", "IOJKDGCFCGG", "IAHDMMGNKEP", "BCJMOEMDGJK", "Rank", "BEFJLFKJFJD", "PBMLDOEBDEG", "CECGKMHIJHI",
				"BuffList", "LIHCNKHGBIM"
			}, null, null, null, null)
		}));
	}
}
