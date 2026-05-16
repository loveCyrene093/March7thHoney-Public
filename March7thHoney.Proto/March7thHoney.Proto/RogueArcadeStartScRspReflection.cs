using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueArcadeStartScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueArcadeStartScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtSb2d1ZUFyY2FkZVN0YXJ0U2NSc3AucHJvdG8aEUtFRURKQklFSk9GLnBy" + "b3RvIlwKFVJvZ3VlQXJjYWRlU3RhcnRTY1JzcBIPCgdyb29tX2lkGAQgASgN" + "EiEKC0FGTEpKSkZDQklOGAsgASgLMgwuS0VFREpCSUVKT0YSDwoHcmV0Y29k" + "ZRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { KEEDJBIEJOFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueArcadeStartScRsp), RogueArcadeStartScRsp.Parser, new string[3] { "RoomId", "AFLJJJFCBIN", "Retcode" }, null, null, null, null)
		}));
	}
}
