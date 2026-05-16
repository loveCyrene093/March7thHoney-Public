using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IAMALMLBOEIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IAMALMLBOEIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQU1BTE1MQk9FSS5wcm90byI3CgtJQU1BTE1MQk9FSRITCgtKRU9QTk9O" + "Q0ZOUBgBIAEoDRITCgtOR01BTkxFRk9CShgCIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IAMALMLBOEI), IAMALMLBOEI.Parser, new string[2] { "JEOPNONCFNP", "NGMANLEFOBJ" }, null, null, null, null)
		}));
	}
}
