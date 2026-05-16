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
		buffer[0] = "ChBSZXBsYXlJbmZvLnByb3RvGhFPQ0xFSkxFRkJGTy5wcm90byLcAQoKUmVw";
		buffer[1] = "bGF5SW5mbxITCgtQTkxDTUpPQURLQhgBIAEoBBIhCgtyZXBsYXlfdHlwZRgC";
		buffer[2] = "IAEoDjIMLk9DTEVKTEVGQkZPEhAKCHN0YWdlX2lkGAMgASgNEgsKA3VpZBgE";
		buffer[3] = "IAEoDRIQCghuaWNrbmFtZRgFIAEoCRIRCgloZWFkX2ljb24YBiABKA0SEwoL";
		buffer[4] = "cmVwbGF5X25hbWUYByABKAkSEwoLY3JlYXRlX3RpbWUYCCABKAQSEwoLREFG";
		buffer[5] = "RUpJRU5BQkwYCSABKA0SEwoLS0FMQUdJQkNOQU8YCiABKA1CFqoCE01hcmNo";
		buffer[6] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { OCLEJLEFBFOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReplayInfo), ReplayInfo.Parser, new string[10] { "PNLCMJOADKB", "ReplayType", "StageId", "Uid", "Nickname", "HeadIcon", "ReplayName", "CreateTime", "DAFEJIENABL", "KALAGIBCNAO" }, null, null, null, null)
		}));
	}
}
