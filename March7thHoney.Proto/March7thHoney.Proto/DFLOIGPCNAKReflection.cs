using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DFLOIGPCNAKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DFLOIGPCNAKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFERkxPSUdQQ05BSy5wcm90byINCgtERkxPSUdQQ05BS0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DFLOIGPCNAK), DFLOIGPCNAK.Parser, null, null, null, null, null)
		}));
	}
}
