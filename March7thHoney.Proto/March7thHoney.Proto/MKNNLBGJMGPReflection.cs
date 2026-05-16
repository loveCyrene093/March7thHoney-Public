using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MKNNLBGJMGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MKNNLBGJMGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNS05OTEJHSk1HUC5wcm90byINCgtNS05OTEJHSk1HUEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MKNNLBGJMGP), MKNNLBGJMGP.Parser, null, null, null, null, null)
		}));
	}
}
