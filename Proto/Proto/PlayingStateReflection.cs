using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayingStateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayingStateReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChJQbGF5aW5nU3RhdGUucHJvdG8quQIKDFBsYXlpbmdTdGF0ZRIWChJQTEFZ";
		buffer[1] = "SU5HX1NUQVRFX05PTkUQABIYChRQTEFZSU5HX1JPR1VFX0NPU01PUxABEhcK";
		buffer[2] = "E1BMQVlJTkdfUk9HVUVfQ0hFU1MQAhIcChhQTEFZSU5HX1JPR1VFX0NIRVNT";
		buffer[3] = "X05PVVMQAxIcChhQTEFZSU5HX0NIQUxMRU5HRV9NRU1PUlkQBBIbChdQTEFZ";
		buffer[4] = "SU5HX0NIQUxMRU5HRV9TVE9SWRAFEhoKFlBMQVlJTkdfQ0hBTExFTkdFX0JP";
		buffer[5] = "U1MQBhIXChNQTEFZSU5HX1JPR1VFX1RPVVJOEAcSFwoTUExBWUlOR19ST0dV";
		buffer[6] = "RV9NQUdJQxAIEhoKFlBMQVlJTkdfQ0hBTExFTkdFX1BFQUsQCRIbChdMR0dF";
		buffer[7] = "TE5FTkRBT19PS0dBSEdCS0ZEShAKQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[8] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PlayingState) }, null, null));
	}
}
