using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NpcRogueGameInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NpcRogueGameInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChZOcGNSb2d1ZUdhbWVJbmZvLnByb3RvIv0BChBOcGNSb2d1ZUdhbWVJbmZv";
		buffer[1] = "EhMKC0lJTkhQSk5IR0FIGAEgASgIEhMKC0RISUxHQkNLUENMGAIgASgIEhMK";
		buffer[2] = "C0pCRUlMTUZJSUdNGAMgASgNEhMKC0hPSEFOUEpOQU5BGAYgASgNEhMKC0tJ";
		buffer[3] = "R0xMSktERE5FGAogASgIEjcKC0ZPRUpGRU1MUFBDGA0gAygLMiIuTnBjUm9n";
		buffer[4] = "dWVHYW1lSW5mby5GT0VKRkVNTFBQQ0VudHJ5EhMKC0FIS0ZGQ0lFUERHGA4g";
		buffer[5] = "ASgNGjIKEEZPRUpGRU1MUFBDRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVl";
		buffer[6] = "GAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NpcRogueGameInfo), NpcRogueGameInfo.Parser, new string[7] { "IINHPJNHGAH", "DHILGBCKPCL", "JBEILMFIIGM", "HOHANPJNANA", "KIGLLJKDDNE", "FOEJFEMLPPC", "AHKFFCIEPDG" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
