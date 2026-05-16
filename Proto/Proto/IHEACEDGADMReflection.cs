using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IHEACEDGADMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IHEACEDGADMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJSEVBQ0VER0FETS5wcm90bxoRTk9ETk1OQ0lCRkcucHJvdG8iMAoLSUhF" + "QUNFREdBRE0SIQoLQUZOTU9KT0FGTU4YASABKA4yDC5OT0ROTU5DSUJGR0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NODNMNCIBFGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IHEACEDGADM), IHEACEDGADM.Parser, new string[1] { "AFNMOJOAFMN" }, null, null, null, null)
		}));
	}
}
