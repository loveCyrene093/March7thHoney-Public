using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournStartScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournStartScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChpSb2d1ZVRvdXJuU3RhcnRTY1JzcC5wcm90bxoRQVBNSERHUERHTlAucHJv";
		buffer[1] = "dG8aEUJGRUlQRUxGQ0RGLnByb3RvIoIBChRSb2d1ZVRvdXJuU3RhcnRTY1Jz";
		buffer[2] = "cBITCgtJUE9ITEpCTEtPQRgBIAEoDRIhCgtBRkxKSkpGQ0JJThgFIAEoCzIM";
		buffer[3] = "LkJGRUlQRUxGQ0RGEg8KB3JldGNvZGUYByABKA0SIQoLSEhETEVBREJKR04Y";
		buffer[4] = "DyABKAsyDC5BUE1IREdQREdOUEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[5] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			APMHDGPDGNPReflection.Descriptor,
			BFEIPELFCDFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournStartScRsp), RogueTournStartScRsp.Parser, new string[4] { "IPOHLJBLKOA", "AFLJJJFCBIN", "Retcode", "HHDLEADBJGN" }, null, null, null, null)
		}));
	}
}
