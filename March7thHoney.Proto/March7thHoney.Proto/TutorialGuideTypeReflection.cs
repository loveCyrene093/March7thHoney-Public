using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TutorialGuideTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TutorialGuideTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUdXRvcmlhbEd1aWRlVHlwZS5wcm90bypNChFUdXRvcmlhbEd1aWRlVHlw" + "ZRIbChdGR0tMUE1DSkJBQ19OTk1CQUhDQ0tKQRAAEhsKF0ZHS0xQTUNKQkFD" + "X0lQS09IUEZJQU9JEAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(TutorialGuideType) }, null, null));
	}
}
