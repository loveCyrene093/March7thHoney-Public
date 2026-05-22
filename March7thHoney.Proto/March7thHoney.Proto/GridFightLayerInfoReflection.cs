using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightLayerInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightLayerInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHcmlkRmlnaHRMYXllckluZm8ucHJvdG8aGEdyaWRGaWdodFJvdXRlSW5m" + "by5wcm90byJYChJHcmlkRmlnaHRMYXllckluZm8SGAoQcm91dGVfaXNfcGVu" + "ZGluZxgLIAEoCBIoCgpyb3V0ZV9pbmZvGK0PIAEoCzITLkdyaWRGaWdodFJv" + "dXRlSW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GridFightRouteInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightLayerInfo), GridFightLayerInfo.Parser, new string[2] { "RouteIsPending", "RouteInfo" }, null, null, null, null)
		}));
	}
}
