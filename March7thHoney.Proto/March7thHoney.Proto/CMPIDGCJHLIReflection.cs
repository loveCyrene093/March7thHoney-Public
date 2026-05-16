using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CMPIDGCJHLIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CMPIDGCJHLIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTVBJREdDSkhMSS5wcm90bxoRT0ZQR0pLRURLRUIucHJvdG8iMwoLQ01Q" + "SURHQ0pITEkSJAoOcGVuZGluZ19hY3Rpb24YCCABKAsyDC5PRlBHSktFREtF" + "QkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OFPGJKEDKEBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CMPIDGCJHLI), CMPIDGCJHLI.Parser, new string[1] { "PendingAction" }, null, null, null, null)
		}));
	}
}
