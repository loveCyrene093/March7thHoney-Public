using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CancelDirectDeliveryNoticeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CancelDirectDeliveryNoticeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDYW5jZWxEaXJlY3REZWxpdmVyeU5vdGljZVNjUnNwLnByb3RvIkcKH0Nh" + "bmNlbERpcmVjdERlbGl2ZXJ5Tm90aWNlU2NSc3ASDwoHcmV0Y29kZRgGIAEo" + "DRITCgtPRUNDUEtBTkhNThgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CancelDirectDeliveryNoticeScRsp), CancelDirectDeliveryNoticeScRsp.Parser, new string[2] { "Retcode", "OECCPKANHMN" }, null, null, null, null)
		}));
	}
}
