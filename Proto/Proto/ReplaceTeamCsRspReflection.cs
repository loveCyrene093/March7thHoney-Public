using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReplaceTeamCsRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReplaceTeamCsRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZSZXBsYWNlVGVhbUNzUnNwLnByb3RvGhFHS0RFS0pLT0lKTi5wcm90byJG" + "ChBSZXBsYWNlVGVhbUNzUnNwEg8KB3JldGNvZGUYAyABKA0SIQoLT0lDRUpJ" + "TUVPTkcYCCADKAsyDC5HS0RFS0pLT0lKTkIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[1] { GKDEKJKOIJNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReplaceTeamCsRsp), ReplaceTeamCsRsp.Parser, new string[2] { "Retcode", "OICEJIMEONG" }, null, null, null, null)
		}));
	}
}
