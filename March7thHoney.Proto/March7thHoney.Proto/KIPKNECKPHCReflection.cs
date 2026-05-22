using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KIPKNECKPHCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KIPKNECKPHCReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFLSVBLTkVDS1BIQy5wcm90bxotUm9ndWVBZHZlbnR1cmVSb29tR2FtZXBs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YXlXb2xmR3VuVGFyZ2V0LnByb3RvImgKC0tJUEtORUNLUEhDEkQKEmJhdHRs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZV90YXJnZXRfbGlzdBgFIAMoCzIoLlJvZ3VlQWR2ZW50dXJlUm9vbUdhbWVw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "bGF5V29sZkd1blRhcmdldBITCgtBT0JQRkxFSEJPSBgPIAEoDUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { RogueAdventureRoomGameplayWolfGunTargetReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KIPKNECKPHC), KIPKNECKPHC.Parser, new string[2] { "BattleTargetList", "AOBPFLEHBOH" }, null, null, null, null)
		}));
	}
}
