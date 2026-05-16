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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Ch5HcmlkRmlnaHRFcXVpcENyYWZ0Q3NSZXEucHJvdG8aH0dyaWRGaWdodEVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "dWlwQ3JhZnRTb3VyY2UucHJvdG8iiQEKGEdyaWRGaWdodEVxdWlwQ3JhZnRD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "c1JlcRIXCg9jcmFmdF9tYXRlcmlhbHMYBCADKA0SEwoLQkdFS0FDUE9BT1AY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ByABKA0SKgoGc291cmNlGAggASgOMhouR3JpZEZpZ2h0RXF1aXBDcmFmdFNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "dXJjZRITCgtFR0xPQUNEUE5MRBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { GridFightEquipCraftSourceReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightEquipCraftCsReq), GridFightEquipCraftCsReq.Parser, new string[4] { "CraftMaterials", "BGEKACPOAOP", "Source", "EGLOACDPNLD" }, null, null, null, null)
		}));
	}
}
