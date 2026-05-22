using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueAdventureRoomGameplayWolfGunTargetReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueAdventureRoomGameplayWolfGunTargetReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "Ci1Sb2d1ZUFkdmVudHVyZVJvb21HYW1lcGxheVdvbGZHdW5UYXJnZXQucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "dG8aEUJIRU9LR0FLR01BLnByb3RvGhFLSURBTE1NRElFRi5wcm90bxoRTERI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "T0tHTEZQS0YucHJvdG8aEU1IUE1BUEdLSUxFLnByb3RvItIBCidSb2d1ZUFk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "dmVudHVyZVJvb21HYW1lcGxheVdvbGZHdW5UYXJnZXQSIwoLdGFyZ2V0X25v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "bmUYASABKAsyDC5LSURBTE1NRElFRkgAEiYKDnRhcmdldF9ydWFubWVpGAcg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "ASgLMgwuQkhFT0tHQUtHTUFIABIjCgt0YXJnZXRfY29pbhgMIAEoCzIMLkxE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "SE9LR0xGUEtGSAASJgoOdGFyZ2V0X21pcmFjbGUYDyABKAsyDC5NSFBNQVBH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "S0lMRUgAQg0KC3RhcmdldF9pbXBsQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[4]
		{
			BHEOKGAKGMAReflection.Descriptor,
			KIDALMMDIEFReflection.Descriptor,
			LDHOKGLFPKFReflection.Descriptor,
			MHPMAPGKILEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueAdventureRoomGameplayWolfGunTarget), RogueAdventureRoomGameplayWolfGunTarget.Parser, new string[4] { "TargetNone", "TargetRuanmei", "TargetCoin", "TargetMiracle" }, new string[1] { "TargetImpl" }, null, null, null)
		}));
	}
}
