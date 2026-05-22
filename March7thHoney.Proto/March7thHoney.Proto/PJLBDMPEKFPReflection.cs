using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PJLBDMPEKFPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PJLBDMPEKFPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQSkxCRE1QRUtGUC5wcm90byJeCgtQSkxCRE1QRUtGUBISCgptb25zdGVy" + "X2lkGAMgASgNEhEKCXJvbGVfc3RhchgGIAEoDRITCgtQTU9HSEZJR0tQTxgK" + "IAEoDRITCgtCRk1FSEdHRUtPTRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PJLBDMPEKFP), PJLBDMPEKFP.Parser, new string[4] { "MonsterId", "RoleStar", "PMOGHFIGKPO", "BFMEHGGEKOM" }, null, null, null, null)
		}));
	}
}
