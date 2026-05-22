using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RaidCollectionEnterNextRaidCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RaidCollectionEnterNextRaidCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiZSYWlkQ29sbGVjdGlvbkVudGVyTmV4dFJhaWRDc1JlcS5wcm90byJuCiBS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "YWlkQ29sbGVjdGlvbkVudGVyTmV4dFJhaWRDc1JlcRITCgthdmF0YXJfbGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dBgDIAMoDRIPCgdyYWlkX2lkGAQgASgNEg8KB2lzX3NhdmUYBiABKA0SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "d29ybGRfbGV2ZWwYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RaidCollectionEnterNextRaidCsReq), RaidCollectionEnterNextRaidCsReq.Parser, new string[4] { "AvatarList", "RaidId", "IsSave", "WorldLevel" }, null, null, null, null)
		}));
	}
}
