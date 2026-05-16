using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpgradeTeamSlotCsRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpgradeTeamSlotCsRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpVcGdyYWRlVGVhbVNsb3RDc1JzcC5wcm90byJLChRVcGdyYWRlVGVhbVNs" + "b3RDc1JzcBIPCgdyZXRjb2RlGAQgASgNEg0KBWxldmVsGAYgASgNEhMKC0pO" + "R0hNT1BFS0pPGAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpgradeTeamSlotCsRsp), UpgradeTeamSlotCsRsp.Parser, new string[3] { "Retcode", "Level", "JNGHMOPEKJO" }, null, null, null, null)
		}));
	}
}
