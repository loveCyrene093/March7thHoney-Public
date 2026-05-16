using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DABNCEPBKMGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DABNCEPBKMGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQUJOQ0VQQktNRy5wcm90bxoRTURGRUZLREVGTUwucHJvdG8iRQoLREFC" + "TkNFUEJLTUcSEwoLSU9KTUZERFBCSEkYAyADKA0SIQoLSkZFS0tOTkhDT0gY" + "CyADKAsyDC5NREZFRktERUZNTEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { MDFEFKDEFMLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DABNCEPBKMG), DABNCEPBKMG.Parser, new string[2] { "IOJMFDDPBHI", "JFEKKNNHCOH" }, null, null, null, null)
		}));
	}
}
