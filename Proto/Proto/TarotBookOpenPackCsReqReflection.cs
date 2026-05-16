using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookOpenPackCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookOpenPackCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUYXJvdEJvb2tPcGVuUGFja0NzUmVxLnByb3RvIhgKFlRhcm90Qm9va09w" + "ZW5QYWNrQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookOpenPackCsReq), TarotBookOpenPackCsReq.Parser, null, null, null, null, null)
		}));
	}
}
