using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerSqueezedScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerSqueezedScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxQbGF5ZXJTcXVlZXplZFNjTm90aWZ5LnByb3RvGg9CbGFja0luZm8ucHJv";
		buffer[1] = "dG8aDktpY2tUeXBlLnByb3RvIlYKFlBsYXllclNxdWVlemVkU2NOb3RpZnkS";
		buffer[2] = "HAoJa2lja190eXBlGAIgASgOMgkuS2lja1R5cGUSHgoKYmxhY2tfaW5mbxgE";
		buffer[3] = "IAEoCzIKLkJsYWNrSW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BlackInfoReflection.Descriptor,
			KickTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerSqueezedScNotify), PlayerSqueezedScNotify.Parser, new string[2] { "KickType", "BlackInfo" }, null, null, null, null)
		}));
	}
}
