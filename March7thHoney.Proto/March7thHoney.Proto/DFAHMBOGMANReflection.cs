using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DFAHMBOGMANReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DFAHMBOGMANReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFERkFITUJPR01BTi5wcm90bxoRSEVITUZOTEhPSkkucHJvdG8iSAoLREZB" + "SE1CT0dNQU4SIQoLQ0tPT0tGTkJQQUYYCiABKAsyDC5IRUhNRk5MSE9KSRIW" + "Cg5xdWV1ZV9wb3NpdGlvbhgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { HEHMFNLHOJIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DFAHMBOGMAN), DFAHMBOGMAN.Parser, new string[2] { "CKOOKFNBPAF", "QueuePosition" }, null, null, null, null)
		}));
	}
}
