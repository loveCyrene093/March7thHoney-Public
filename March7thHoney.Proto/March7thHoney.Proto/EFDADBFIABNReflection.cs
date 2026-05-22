using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EFDADBFIABNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EFDADBFIABNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRkRBREJGSUFCTi5wcm90bxoRSURIQ0tDREFFQkEucHJvdG8iMAoLRUZE" + "QURCRklBQk4SIQoLTkFMTk5CRUNCUEEYAiABKAsyDC5JREhDS0NEQUVCQUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { IDHCKCDAEBAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EFDADBFIABN), EFDADBFIABN.Parser, new string[1] { "NALNNBECBPA" }, null, null, null, null)
		}));
	}
}
