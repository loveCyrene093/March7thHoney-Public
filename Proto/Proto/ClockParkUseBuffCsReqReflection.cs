using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClockParkUseBuffCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClockParkUseBuffCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDbG9ja1BhcmtVc2VCdWZmQ3NSZXEucHJvdG8iUgoVQ2xvY2tQYXJrVXNl" + "QnVmZkNzUmVxEhMKC05ORkFNT0pBSENIGAIgASgNEhEKCXVuaXF1ZV9pZBgJ" + "IAEoBBIRCglzY3JpcHRfaWQYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkUseBuffCsReq), ClockParkUseBuffCsReq.Parser, new string[3] { "NNFAMOJAHCH", "UniqueId", "ScriptId" }, null, null, null, null)
		}));
	}
}
