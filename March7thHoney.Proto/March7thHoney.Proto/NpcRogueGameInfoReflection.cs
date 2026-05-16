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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChZOcGNSb2d1ZUdhbWVJbmZvLnByb3RvIv0BChBOcGNSb2d1ZUdhbWVJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "EhMKC0lJTkhQSk5IR0FIGAEgASgIEhMKC0RISUxHQkNLUENMGAIgASgIEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "C0pCRUlMTUZJSUdNGAMgASgNEhMKC0hPSEFOUEpOQU5BGAYgASgNEhMKC0tJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "R0xMSktERE5FGAogASgIEjcKC0ZPRUpGRU1MUFBDGA0gAygLMiIuTnBjUm9n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "dWVHYW1lSW5mby5GT0VKRkVNTFBQQ0VudHJ5EhMKC0FIS0ZGQ0lFUERHGA4g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "ASgNGjIKEEZPRUpGRU1MUFBDRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "GAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NpcRogueGameInfo), NpcRogueGameInfo.Parser, new string[7] { "IINHPJNHGAH", "DHILGBCKPCL", "JBEILMFIIGM", "HOHANPJNANA", "KIGLLJKDDNE", "FOEJFEMLPPC", "AHKFFCIEPDG" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
