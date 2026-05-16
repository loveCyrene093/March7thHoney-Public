using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyCharacterStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyCharacterStatusReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChpMb2JieUNoYXJhY3RlclN0YXR1cy5wcm90byr+AQoUTG9iYnlDaGFyYWN0";
		buffer[1] = "ZXJTdGF0dXMSGwoXSk9CQktMTkdBTlBfUENQREhFTFBLRU0QABIbChdKT0JC";
		buffer[2] = "S0xOR0FOUF9HSEdBUE9BS0dBQhABEhsKF0pPQkJLTE5HQU5QX0JQQ0VLTUxQ";
		buffer[3] = "SkNKEAISGwoXSk9CQktMTkdBTlBfR1BKTUtLQURMREMQAxIbChdKT0JCS0xO";
		buffer[4] = "R0FOUF9DQkJIUEdBR0NPRRAEEhsKF0pPQkJLTE5HQU5QX0pOQUFBSUdMSEhJ";
		buffer[5] = "EAUSGwoXSk9CQktMTkdBTlBfSUtOR0JDR0xNSUkQBhIbChdKT0JCS0xOR0FO";
		buffer[6] = "UF9CUERQSVBCSkVNRBAHQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[7] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LobbyCharacterStatus) }, null, null));
	}
}
