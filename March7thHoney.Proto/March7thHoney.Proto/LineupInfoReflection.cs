using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LineupInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LineupInfoReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 0) = "ChBMaW5ldXBJbmZvLnByb3RvGhVFeHRyYUxpbmV1cFR5cGUucHJvdG8aEkxp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 1) = "bmV1cEF2YXRhci5wcm90byLPAgoKTGluZXVwSW5mbxITCgtPQk1FRk9NRkdG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 2) = "RBgBIAMoDRIiCgthdmF0YXJfbGlzdBgCIAMoCzINLkxpbmV1cEF2YXRhchIh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 3) = "ChlzdG9yeV9saW5lX2F2YXRhcl9pZF9saXN0GAMgAygNEg4KBm1heF9tcBgE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 4) = "IAEoDRIKCgJtcBgGIAEoDRISCgppc192aXJ0dWFsGAcgASgIEg0KBWluZGV4";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 5) = "GAggASgNEisKEWV4dHJhX2xpbmV1cF90eXBlGAkgASgOMhAuRXh0cmFMaW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 6) = "dXBUeXBlEhoKEmdhbWVfc3RvcnlfbGluZV9pZBgKIAEoDRIMCgRuYW1lGAsg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 7) = "ASgJEhMKC0dMTERFTERGREVFGAwgASgIEhMKC0FHT1BGSUZESkZOGA0gAygN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 8) = "EhMKC2xlYWRlcl9zbG90GA4gASgNEhAKCHBsYW5lX2lkGA8gASgNQhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 9) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray10<string>, string>(in buffer, 10))), new FileDescriptor[2]
		{
			ExtraLineupTypeReflection.Descriptor,
			LineupAvatarReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LineupInfo), LineupInfo.Parser, new string[14]
			{
				"OBMEFOMFGFD", "AvatarList", "StoryLineAvatarIdList", "MaxMp", "Mp", "IsVirtual", "Index", "ExtraLineupType", "GameStoryLineId", "Name",
				"GLLDELDFDEE", "AGOPFIFDJFN", "LeaderSlot", "PlaneId"
			}, null, null, null, null)
		}));
	}
}
