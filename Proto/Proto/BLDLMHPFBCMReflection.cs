using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BLDLMHPFBCMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BLDLMHPFBCMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTERMTUhQRkJDTS5wcm90bxoRSE5DS0dGR0hKQUMucHJvdG8iMAoLQkxE" + "TE1IUEZCQ00SIQoLUEZCQkhBTU9BR0IYDSABKAsyDC5ITkNLR0ZHSEpBQ0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { HNCKGFGHJACReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BLDLMHPFBCM), BLDLMHPFBCM.Parser, new string[1] { "PFBBHAMOAGB" }, null, null, null, null)
		}));
	}
}
