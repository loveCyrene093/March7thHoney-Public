using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMonopolyDailyReportScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMonopolyDailyReportScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRNb25vcG9seURhaWx5UmVwb3J0U2NSc3AucHJvdG8aEU9ET05MSERB" + "UEtCLnByb3RvIlEKG0dldE1vbm9wb2x5RGFpbHlSZXBvcnRTY1JzcBIPCgdy" + "ZXRjb2RlGAcgASgNEiEKC0VPQkVORFBLRkJPGAsgASgLMgwuT0RPTkxIREFQ" + "S0JCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ODONLHDAPKBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMonopolyDailyReportScRsp), GetMonopolyDailyReportScRsp.Parser, new string[2] { "Retcode", "EOBENDPKFBO" }, null, null, null, null)
		}));
	}
}
