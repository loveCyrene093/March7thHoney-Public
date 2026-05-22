using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightHandBookPortalInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightHandBookPortalInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHcmlkRmlnaHRIYW5kQm9va1BvcnRhbEluZm8ucHJvdG8iVwobR3JpZEZp" + "Z2h0SGFuZEJvb2tQb3J0YWxJbmZvEiMKG2dyaWRfZmlnaHRfcG9ydGFsX2J1" + "ZmZfbGlzdBgCIAMoDRITCgtQRUxKTE9OTEROTRgMIAMoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightHandBookPortalInfo), GridFightHandBookPortalInfo.Parser, new string[2] { "GridFightPortalBuffList", "PELJLONLDNM" }, null, null, null, null)
		}));
	}
}
