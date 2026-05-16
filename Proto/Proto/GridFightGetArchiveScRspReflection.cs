using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGetArchiveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGetArchiveScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch5HcmlkRmlnaHRHZXRBcmNoaXZlU2NSc3AucHJvdG8aEUFQRFBBRUNKUElI";
		buffer[1] = "LnByb3RvGhpHcmlkRmlnaHRBcmNoaXZlRGF0YS5wcm90byJzChhHcmlkRmln";
		buffer[2] = "aHRHZXRBcmNoaXZlU2NSc3ASDwoHcmV0Y29kZRgDIAEoDRIqCgtLR0tJRERP";
		buffer[3] = "UEhFTxgKIAMoCzIVLkdyaWRGaWdodEFyY2hpdmVEYXRhEhoKBHR5cGUYDCAB";
		buffer[4] = "KA4yDC5BUERQQUVDSlBJSEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[5] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			APDPAECJPIHReflection.Descriptor,
			GridFightArchiveDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGetArchiveScRsp), GridFightGetArchiveScRsp.Parser, new string[3] { "Retcode", "KGKIDDOPHEO", "Type" }, null, null, null, null)
		}));
	}
}
