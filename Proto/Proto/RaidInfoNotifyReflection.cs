using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RaidInfoNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RaidInfoNotifyReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChRSYWlkSW5mb05vdGlmeS5wcm90bxoOSXRlbUxpc3QucHJvdG8aEFJhaWRT";
		buffer[1] = "dGF0dXMucHJvdG8aFFJhaWRUYXJnZXRJbmZvLnByb3RvIrYBCg5SYWlkSW5m";
		buffer[2] = "b05vdGlmeRIpChByYWlkX3RhcmdldF9pbmZvGAEgAygLMg8uUmFpZFRhcmdl";
		buffer[3] = "dEluZm8SGwoGc3RhdHVzGAMgASgOMgsuUmFpZFN0YXR1cxIYChByYWlkX2Zp";
		buffer[4] = "bmlzaF90aW1lGAUgASgEEhMKC3dvcmxkX2xldmVsGAggASgNEg8KB3JhaWRf";
		buffer[5] = "aWQYCyABKA0SHAoJaXRlbV9saXN0GAwgASgLMgkuSXRlbUxpc3RCFqoCE01h";
		buffer[6] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			ItemListReflection.Descriptor,
			RaidStatusReflection.Descriptor,
			RaidTargetInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RaidInfoNotify), RaidInfoNotify.Parser, new string[6] { "RaidTargetInfo", "Status", "RaidFinishTime", "WorldLevel", "RaidId", "ItemList" }, null, null, null, null)
		}));
	}
}
