using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearUpdatePinRelicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearUpdatePinRelicScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidSZWxpY1NtYXJ0V2VhclVwZGF0ZVBpblJlbGljU2NSc3AucHJvdG8aEUJE";
		buffer[1] = "RUtFSUtBS01MLnByb3RvIlcKIVJlbGljU21hcnRXZWFyVXBkYXRlUGluUmVs";
		buffer[2] = "aWNTY1JzcBIhCgtEQUNNUEpMSkdCQxgHIAEoCzIMLkJERUtFSUtBS01MEg8K";
		buffer[3] = "B3JldGNvZGUYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BDEKEIKAKMLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearUpdatePinRelicScRsp), RelicSmartWearUpdatePinRelicScRsp.Parser, new string[2] { "DACMPJLJGBC", "Retcode" }, null, null, null, null)
		}));
	}
}
