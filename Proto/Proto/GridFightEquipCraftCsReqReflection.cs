using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEquipCraftCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEquipCraftCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch5HcmlkRmlnaHRFcXVpcENyYWZ0Q3NSZXEucHJvdG8aH0dyaWRGaWdodEVx";
		buffer[1] = "dWlwQ3JhZnRTb3VyY2UucHJvdG8iiQEKGEdyaWRGaWdodEVxdWlwQ3JhZnRD";
		buffer[2] = "c1JlcRIXCg9jcmFmdF9tYXRlcmlhbHMYBCADKA0SEwoLQkdFS0FDUE9BT1AY";
		buffer[3] = "ByABKA0SKgoGc291cmNlGAggASgOMhouR3JpZEZpZ2h0RXF1aXBDcmFmdFNv";
		buffer[4] = "dXJjZRITCgtFR0xPQUNEUE5MRBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[5] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightEquipCraftSourceReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightEquipCraftCsReq), GridFightEquipCraftCsReq.Parser, new string[4] { "CraftMaterials", "BGEKACPOAOP", "Source", "EGLOACDPNLD" }, null, null, null, null)
		}));
	}
}
