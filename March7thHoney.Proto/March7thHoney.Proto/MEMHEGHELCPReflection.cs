using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MEMHEGHELCPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MEMHEGHELCPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRU1IRUdIRUxDUC5wcm90byIiCgtNRU1IRUdIRUxDUBITCgtJR0VBQk1G" + "TENHQxgLIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MEMHEGHELCP), MEMHEGHELCP.Parser, new string[1] { "IGEABMFLCGC" }, null, null, null, null)
		}));
	}
}
