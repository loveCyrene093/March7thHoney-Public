using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengePeakGroupDataUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengePeakGroupDataUpdateScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CipDaGFsbGVuZ2VQZWFrR3JvdXBEYXRhVXBkYXRlU2NOb3RpZnkucHJvdG8a";
		buffer[1] = "GENoYWxsZW5nZVBlYWtHcm91cC5wcm90byJZCiRDaGFsbGVuZ2VQZWFrR3Jv";
		buffer[2] = "dXBEYXRhVXBkYXRlU2NOb3RpZnkSMQoUY2hhbGxlbmdlX3BlYWtfZ3JvdXAY";
		buffer[3] = "AiABKAsyEy5DaGFsbGVuZ2VQZWFrR3JvdXBCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ChallengePeakGroupReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeakGroupDataUpdateScNotify), ChallengePeakGroupDataUpdateScNotify.Parser, new string[1] { "ChallengePeakGroup" }, null, null, null, null)
		}));
	}
}
