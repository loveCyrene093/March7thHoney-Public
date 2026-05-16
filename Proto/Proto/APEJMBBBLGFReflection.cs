using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APEJMBBBLGFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APEJMBBBLGFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBUEVKTUJCQkxHRi5wcm90bxoRQkpMSUFFSk5ESksucHJvdG8iRQoLQVBF" + "Sk1CQkJMR0YSEwoLSktQR0FDTEtFRUMYDSABKA0SIQoLS0dOREhHS0tPTU0Y" + "DiABKAsyDC5CSkxJQUVKTkRKS0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { BJLIAEJNDJKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APEJMBBBLGF), APEJMBBBLGF.Parser, new string[2] { "JKPGACLKEEC", "KGNDHGKKOMM" }, null, null, null, null)
		}));
	}
}
