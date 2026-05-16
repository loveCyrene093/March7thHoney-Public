using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEquipDressCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEquipDressCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch5HcmlkRmlnaHRFcXVpcERyZXNzQ3NSZXEucHJvdG8aH0dyaWRGaWdodEVx";
		buffer[1] = "dWlwRHJlc3NTb3VyY2UucHJvdG8ijQEKGEdyaWRGaWdodEVxdWlwRHJlc3ND";
		buffer[2] = "c1JlcRIcChRkcmVzc19yb2xlX3VuaXF1ZV9pZBgCIAEoDRIwCgxkcmVzc19z";
		buffer[3] = "b3VyY2UYBSABKA4yGi5HcmlkRmlnaHRFcXVpcERyZXNzU291cmNlEiEKGWRy";
		buffer[4] = "ZXNzX2VxdWlwbWVudF91bmlxdWVfaWQYCSABKA1CFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightEquipDressSourceReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightEquipDressCsReq), GridFightEquipDressCsReq.Parser, new string[3] { "DressRoleUniqueId", "DressSource", "DressEquipmentUniqueId" }, null, null, null, null)
		}));
	}
}
