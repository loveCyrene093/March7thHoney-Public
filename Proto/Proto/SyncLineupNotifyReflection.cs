using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncLineupNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncLineupNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChZTeW5jTGluZXVwTm90aWZ5LnByb3RvGhBMaW5ldXBJbmZvLnByb3RvGhZT";
		buffer[1] = "eW5jTGluZXVwUmVhc29uLnByb3RvIlcKEFN5bmNMaW5ldXBOb3RpZnkSGwoG";
		buffer[2] = "bGluZXVwGAIgASgLMgsuTGluZXVwSW5mbxImCgtyZWFzb25fbGlzdBgJIAMo";
		buffer[3] = "DjIRLlN5bmNMaW5ldXBSZWFzb25CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			LineupInfoReflection.Descriptor,
			SyncLineupReasonReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncLineupNotify), SyncLineupNotify.Parser, new string[2] { "Lineup", "ReasonList" }, null, null, null, null)
		}));
	}
}
