using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SubmitOfferingItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SubmitOfferingItemScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TdWJtaXRPZmZlcmluZ0l0ZW1TY1JzcC5wcm90bxoST2ZmZXJpbmdJbmZv" + "LnByb3RvIlAKF1N1Ym1pdE9mZmVyaW5nSXRlbVNjUnNwEiQKDW9mZmVyaW5n" + "X2luZm8YByABKAsyDS5PZmZlcmluZ0luZm8SDwoHcmV0Y29kZRgNIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OfferingInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SubmitOfferingItemScRsp), SubmitOfferingItemScRsp.Parser, new string[2] { "OfferingInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
