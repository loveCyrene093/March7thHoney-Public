using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReplayInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReplayInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChBSZXBsYXlJbmZvLnByb3RvGhFPQ0xFSkxFRkJGTy5wcm90byLcAQoKUmVw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "bGF5SW5mbxITCgtQTkxDTUpPQURLQhgBIAEoBBIhCgtyZXBsYXlfdHlwZRgC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "IAEoDjIMLk9DTEVKTEVGQkZPEhAKCHN0YWdlX2lkGAMgASgNEgsKA3VpZBgE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "IAEoDRIQCghuaWNrbmFtZRgFIAEoCRIRCgloZWFkX2ljb24YBiABKA0SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "cmVwbGF5X25hbWUYByABKAkSEwoLY3JlYXRlX3RpbWUYCCABKAQSEwoLREFG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "RUpJRU5BQkwYCSABKA0SEwoLS0FMQUdJQkNOQU8YCiABKA1CFqoCE01hcmNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[1] { OCLEJLEFBFOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReplayInfo), ReplayInfo.Parser, new string[10] { "PNLCMJOADKB", "ReplayType", "StageId", "Uid", "Nickname", "HeadIcon", "ReplayName", "CreateTime", "DAFEJIENABL", "KALAGIBCNAO" }, null, null, null, null)
		}));
	}
}
