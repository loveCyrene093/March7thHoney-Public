using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LHPIHPJIMFAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LHPIHPJIMFAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMSFBJSFBKSU1GQS5wcm90bxoRQkpMSUFFSk5ESksucHJvdG8iMAoLTEhQ" + "SUhQSklNRkESIQoLS0dOREhHS0tPTU0YDyABKAsyDC5CSkxJQUVKTkRKS0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BJLIAEJNDJKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LHPIHPJIMFA), LHPIHPJIMFA.Parser, new string[1] { "KGNDHGKKOMM" }, null, null, null, null)
		}));
	}
}
