using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GateServerReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GateServerReflection()
	{
		InlineArray13<string> buffer = default(InlineArray13<string>);
		buffer[0] = "ChBHYXRlU2VydmVyLnByb3RvIpAECgpHYXRlU2VydmVyEgoKAmlwGAMgASgJ";
		buffer[1] = "Eg8KB2x1YV91cmwYBiABKAkSDAoEcG9ydBgHIAEoDRITCgtyZWdpb25fbmFt";
		buffer[2] = "ZRgJIAEoCRIMCgR1bmsxGAogASgIEhcKD2V4X3Jlc291cmNlX3VybBgLIAEo";
		buffer[3] = "CRIYChBhc3NldF9idW5kbGVfdXJsGAwgASgJEg8KB3JldGNvZGUYDiABKA0S";
		buffer[4] = "DAoEdW5rMhgPIAEoCBILCgNtc2cYKyABKAkSDAoEdW5rMxhDIAEoCBIMCgR1";
		buffer[5] = "bms0GE8gASgIEg0KBXVuazEwGHAgASgIEg0KBHVuazUYuAEgASgIEg0KBHVu";
		buffer[6] = "azYYyAEgASgIEg4KBXVuazE0GNABIAEoCBIOCgV1bmsxMxiJAyABKAgSDQoE";
		buffer[7] = "dW5rNxjGAyABKAgSDQoEdW5rOBiRBCABKAgSDgoFdW5rMTUYoQcgASgIEg4K";
		buffer[8] = "BXVuazE2GM8HIAEoCBIVCgxpZml4X3ZlcnNpb24YmgkgASgJEhgKD21ka19y";
		buffer[9] = "ZXNfdmVyc2lvbhjWCSABKAkSDgoFdW5rMTIY/AkgASgIEiEKGGFzc2V0X2J1";
		buffer[10] = "bmRsZV91cmxfYW5kcm9pZBiJCyABKAkSDgoFdW5rMTEYoAsgASgIEhEKCGlm";
		buffer[11] = "aXhfdXJsGNALIAEoCRINCgR1bms5GJYNIAEoCBIYCg9DbGllbnRTZWNyZXRL";
		buffer[12] = "ZXkY0QUgASgJQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GateServer), GateServer.Parser, new string[29]
			{
				"Ip", "LuaUrl", "Port", "RegionName", "Unk1", "ExResourceUrl", "AssetBundleUrl", "Retcode", "Unk2", "Msg",
				"Unk3", "Unk4", "Unk10", "Unk5", "Unk6", "Unk14", "Unk13", "Unk7", "Unk8", "Unk15",
				"Unk16", "IfixVersion", "MdkResVersion", "Unk12", "AssetBundleUrlAndroid", "Unk11", "IfixUrl", "Unk9", "ClientSecretKey"
			}, null, null, null, null)
		}));
	}
}
