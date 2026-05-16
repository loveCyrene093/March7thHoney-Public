using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRechargeBenefitInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRechargeBenefitInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRSZWNoYXJnZUJlbmVmaXRJbmZvU2NSc3AucHJvdG8aEURIS0NEQ0NI" + "TEhQLnByb3RvIlEKG0dldFJlY2hhcmdlQmVuZWZpdEluZm9TY1JzcBIPCgdy" + "ZXRjb2RlGAUgASgNEiEKC0JQT01QTERLSEJMGAwgAygLMgwuREhLQ0RDQ0hM" + "SFBCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { DHKCDCCHLHPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRechargeBenefitInfoScRsp), GetRechargeBenefitInfoScRsp.Parser, new string[2] { "Retcode", "BPOMPLDKHBL" }, null, null, null, null)
		}));
	}
}
