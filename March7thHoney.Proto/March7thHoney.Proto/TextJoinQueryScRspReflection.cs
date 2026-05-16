using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TextJoinQueryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TextJoinQueryScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhUZXh0Sm9pblF1ZXJ5U2NSc3AucHJvdG8aEUNFREdOSUlFSU1DLnByb3Rv" + "IksKElRleHRKb2luUXVlcnlTY1JzcBIPCgdyZXRjb2RlGAcgASgNEiQKDnRl" + "eHRfam9pbl9saXN0GAggAygLMgwuQ0VER05JSUVJTUNCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { CEDGNIIEIMCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TextJoinQueryScRsp), TextJoinQueryScRsp.Parser, new string[2] { "Retcode", "TextJoinList" }, null, null, null, null)
		}));
	}
}
