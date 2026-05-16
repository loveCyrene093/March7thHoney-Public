using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BMPOHNCLHMFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BMPOHNCLHMFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTVBPSE5DTEhNRi5wcm90bxoRQ01MRVBMUEJKQ0MucHJvdG8iagoLQk1Q" + "T0hOQ0xITUYSEgoKY29udGVudF9pZBgEIAEoDRIPCgdyZXRjb2RlGAYgASgN" + "EhMKC0dGR0ZMSUhDQ09EGAkgASgNEiEKC0NGS0ZGRURKRERHGA0gAygLMgwu" + "Q01MRVBMUEJKQ0NCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { CMLEPLPBJCCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BMPOHNCLHMF), BMPOHNCLHMF.Parser, new string[4] { "ContentId", "Retcode", "GFGFLIHCCOD", "CFKFFEDJDDG" }, null, null, null, null)
		}));
	}
}
