using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetUpdatedArchiveDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetUpdatedArchiveDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHZXRVcGRhdGVkQXJjaGl2ZURhdGFTY1JzcC5wcm90bxoRQXJjaGl2ZURh" + "dGEucHJvdG8iUQoaR2V0VXBkYXRlZEFyY2hpdmVEYXRhU2NSc3ASDwoHcmV0" + "Y29kZRgHIAEoDRIiCgxhcmNoaXZlX2RhdGEYCCABKAsyDC5BcmNoaXZlRGF0" + "YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ArchiveDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetUpdatedArchiveDataScRsp), GetUpdatedArchiveDataScRsp.Parser, new string[2] { "Retcode", "ArchiveData" }, null, null, null, null)
		}));
	}
}
