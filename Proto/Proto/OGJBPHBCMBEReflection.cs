using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OGJBPHBCMBEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OGJBPHBCMBEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPR0pCUEhCQ01CRS5wcm90bxoRS0FBRUJPTlBLRVAucHJvdG8iQgoLT0dK" + "QlBIQkNNQkUSEAoIZ3JvdXBfaWQYAyABKA0SIQoLSkVGS0NJTUhDQ08YCSAD" + "KAsyDC5LQUFFQk9OUEtFUEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[1] { KAAEBONPKEPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OGJBPHBCMBE), OGJBPHBCMBE.Parser, new string[2] { "GroupId", "JEFKCIMHCCO" }, null, null, null, null)
		}));
	}
}
