using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPreAvatarGrowthInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPreAvatarGrowthInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRQcmVBdmF0YXJHcm93dGhJbmZvU2NSc3AucHJvdG8aEU5CQkNDS01L" + "Sk5FLnByb3RvIlEKG0dldFByZUF2YXRhckdyb3d0aEluZm9TY1JzcBIPCgdy" + "ZXRjb2RlGAMgASgNEiEKC0FHR0lMSEFPTlBIGAUgAygLMgwuTkJCQ0NLTUtK" + "TkVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { NBBCCKMKJNEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPreAvatarGrowthInfoScRsp), GetPreAvatarGrowthInfoScRsp.Parser, new string[2] { "Retcode", "AGGILHAONPH" }, null, null, null, null)
		}));
	}
}
