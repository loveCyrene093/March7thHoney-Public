using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookFinishInteractionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookFinishInteractionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVUYXJvdEJvb2tGaW5pc2hJbnRlcmFjdGlvblNjUnNwLnByb3RvIkcKH1Rh" + "cm90Qm9va0ZpbmlzaEludGVyYWN0aW9uU2NSc3ASDwoHcmV0Y29kZRgJIAEo" + "DRITCgtOR0VJSkJNQ1BOQRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookFinishInteractionScRsp), TarotBookFinishInteractionScRsp.Parser, new string[2] { "Retcode", "NGEIJBMCPNA" }, null, null, null, null)
		}));
	}
}
