using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRecyleTimeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRecyleTimeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHZXRSZWN5bGVUaW1lU2NSc3AucHJvdG8aEUpMQUVES01CR0VLLnByb3Rv" + "IkgKEkdldFJlY3lsZVRpbWVTY1JzcBIPCgdyZXRjb2RlGAEgASgNEiEKC0dI" + "R0tDRklGTUJCGAQgAygLMgwuSkxBRURLTUJHRUtCFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { JLAEDKMBGEKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRecyleTimeScRsp), GetRecyleTimeScRsp.Parser, new string[2] { "Retcode", "GHGKCFIFMBB" }, null, null, null, null)
		}));
	}
}
