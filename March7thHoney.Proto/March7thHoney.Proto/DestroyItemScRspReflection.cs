using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DestroyItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DestroyItemScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZEZXN0cm95SXRlbVNjUnNwLnByb3RvIjgKEERlc3Ryb3lJdGVtU2NSc3AS" + "DwoHcmV0Y29kZRgGIAEoDRITCgtQSUFGQ1BDRENERhgKIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DestroyItemScRsp), DestroyItemScRsp.Parser, new string[2] { "Retcode", "PIAFCPCDCDF" }, null, null, null, null)
		}));
	}
}
