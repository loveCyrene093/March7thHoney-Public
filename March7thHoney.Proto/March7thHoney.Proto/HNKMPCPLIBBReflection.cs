using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HNKMPCPLIBBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HNKMPCPLIBBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITktNUENQTElCQi5wcm90byIiCgtITktNUENQTElCQhITCgtyZWdpb25f" + "bGlzdBgGIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HNKMPCPLIBB), HNKMPCPLIBB.Parser, new string[1] { "RegionList" }, null, null, null, null)
		}));
	}
}
