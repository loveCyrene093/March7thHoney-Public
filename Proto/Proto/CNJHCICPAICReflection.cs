using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CNJHCICPAICReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CNJHCICPAICReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTkpIQ0lDUEFJQy5wcm90bxoRQ0FES0JPS0VKTUQucHJvdG8iMAoLQ05K" + "SENJQ1BBSUMSIQoLT0ZPT0RPQkpLQkoYBCABKAsyDC5DQURLQk9LRUpNREIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { CADKBOKEJMDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CNJHCICPAIC), CNJHCICPAIC.Parser, new string[1] { "OFOODOBJKBJ" }, null, null, null, null)
		}));
	}
}
