using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearUpdatePinRelicScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearUpdatePinRelicScNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CipSZWxpY1NtYXJ0V2VhclVwZGF0ZVBpblJlbGljU2NOb3RpZnkucHJvdG8a";
		buffer[1] = "EUJERUtFSUtBS01MLnByb3RvIoUBCiRSZWxpY1NtYXJ0V2VhclVwZGF0ZVBp";
		buffer[2] = "blJlbGljU2NOb3RpZnkSIQoLQktERUlIRUtHSUMYBCADKAsyDC5CREVLRUlL";
		buffer[3] = "QUtNTBIhCgtOQUVJUE1JSUlFQxgFIAMoCzIMLkJERUtFSUtBS01MEhcKD3Jl";
		buffer[4] = "bGljX3VuaXF1ZV9pZBgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[5] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BDEKEIKAKMLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearUpdatePinRelicScNotify), RelicSmartWearUpdatePinRelicScNotify.Parser, new string[3] { "BKDEIHEKGIC", "NAEIPMIIIEC", "RelicUniqueId" }, null, null, null, null)
		}));
	}
}
