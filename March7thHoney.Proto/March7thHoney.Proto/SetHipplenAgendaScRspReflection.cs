using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetHipplenAgendaScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetHipplenAgendaScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTZXRIaXBwbGVuQWdlbmRhU2NSc3AucHJvdG8aEUVLT0lIT01GTURFLnBy" + "b3RvIksKFVNldEhpcHBsZW5BZ2VuZGFTY1JzcBIhCgtDTEtBSUxEQ1BKQxgG" + "IAMoCzIMLkVLT0lIT01GTURFEg8KB3JldGNvZGUYDyABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { EKOIHOMFMDEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetHipplenAgendaScRsp), SetHipplenAgendaScRsp.Parser, new string[2] { "CLKAILDCPJC", "Retcode" }, null, null, null, null)
		}));
	}
}
