using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GACNMNIKJBFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GACNMNIKJBFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQUNOTU5JS0pCRi5wcm90bxoRQ0JKQUVKQUZDS0cucHJvdG8iMAoLR0FD" + "Tk1OSUtKQkYSIQoLS01LR0hKSklKQ04YDyABKAsyDC5DQkpBRUpBRkNLR0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { CBJAEJAFCKGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GACNMNIKJBF), GACNMNIKJBF.Parser, new string[1] { "KMKGHJJIJCN" }, null, null, null, null)
		}));
	}
}
