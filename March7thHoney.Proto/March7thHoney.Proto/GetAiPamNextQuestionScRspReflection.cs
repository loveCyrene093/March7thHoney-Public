using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAiPamNextQuestionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAiPamNextQuestionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRBaVBhbU5leHRRdWVzdGlvblNjUnNwLnByb3RvGhFKRFBQR0NJRUhL" + "Ri5wcm90byJPChlHZXRBaVBhbU5leHRRdWVzdGlvblNjUnNwEg8KB3JldGNv" + "ZGUYBiABKA0SIQoLS0tDSk1QTEdLQ0wYCSADKAsyDC5KRFBQR0NJRUhLRkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JDPPGCIEHKFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAiPamNextQuestionScRsp), GetAiPamNextQuestionScRsp.Parser, new string[2] { "Retcode", "KKCJMPLGKCL" }, null, null, null, null)
		}));
	}
}
