using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournPersonaRoomCardZoneUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournPersonaRoomCardZoneUpdateScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CjFSb2d1ZVRvdXJuUGVyc29uYVJvb21DYXJkWm9uZVVwZGF0ZVNjTm90aWZ5";
		buffer[1] = "LnByb3RvGhFHTkxNRU5LQkhMRS5wcm90byJQCitSb2d1ZVRvdXJuUGVyc29u";
		buffer[2] = "YVJvb21DYXJkWm9uZVVwZGF0ZVNjTm90aWZ5EiEKC0VBSExFQktKSU1MGAgg";
		buffer[3] = "ASgLMgwuR05MTUVOS0JITEVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GNLMENKBHLEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournPersonaRoomCardZoneUpdateScNotify), RogueTournPersonaRoomCardZoneUpdateScNotify.Parser, new string[1] { "EAHLEBKJIML" }, null, null, null, null)
		}));
	}
}
