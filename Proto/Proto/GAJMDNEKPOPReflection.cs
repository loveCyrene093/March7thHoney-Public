using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GAJMDNEKPOPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GAJMDNEKPOPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHQUpNRE5FS1BPUC5wcm90bxoURXhwZWRpdGlvbkluZm8ucHJvdG8igQEK";
		buffer[1] = "C0dBSk1ETkVLUE9QEhMKC0tBTUJCRkRFQkFNGAYgASgDEh4KFnRvdGFsX2V4";
		buffer[2] = "cGVkaXRpb25fY291bnQYCSABKA0SKAoPZXhwZWRpdGlvbl9pbmZvGAsgAygL";
		buffer[3] = "Mg8uRXhwZWRpdGlvbkluZm8SEwoLTkJLRkFFRE9HUEcYDCADKA1CFqoCE01h";
		buffer[4] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ExpeditionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GAJMDNEKPOP), GAJMDNEKPOP.Parser, new string[4] { "KAMBBFDEBAM", "TotalExpeditionCount", "ExpeditionInfo", "NBKFAEDOGPG" }, null, null, null, null)
		}));
	}
}
