using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionSnapshotReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChVNaXNzaW9uU25hcHNob3QucHJvdG8aHE1haW5NaXNzaW9uTWN2U25hcHNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "b3QucHJvdG8aGU1haW5NaXNzaW9uU25hcHNob3QucHJvdG8ijwIKD01pc3Np";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "b25TbmFwc2hvdBIwCg9zZXJ2ZXJfbWN2X2xpc3QYASADKAsyFy5NYWluTWlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "c2lvbk1jdlNuYXBzaG90EjAKD2NsaWVudF9tY3ZfbGlzdBgCIAMoCzIXLk1h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "aW5NaXNzaW9uTWN2U25hcHNob3QSMwoVdHJhY2tpbmdfbWFpbl9taXNzaW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "GAMgASgLMhQuTWFpbk1pc3Npb25TbmFwc2hvdBIiChpoYXNfbWlzc2lvbl9h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "dWRpb19zbmFwc2hvdBgEIAEoCBIfChdjdXJfYXVkaW9fZW1vdGlvbl9zdGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "ZRgFIAEoCRIeChZjdXJfc291bmRfZWZmZWN0X3N0YXRlGAYgASgJQhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[2]
		{
			MainMissionMcvSnapshotReflection.Descriptor,
			MainMissionSnapshotReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MissionSnapshot), MissionSnapshot.Parser, new string[6] { "ServerMcvList", "ClientMcvList", "TrackingMainMission", "HasMissionAudioSnapshot", "CurAudioEmotionState", "CurSoundEffectState" }, null, null, null, null)
		}));
	}
}
