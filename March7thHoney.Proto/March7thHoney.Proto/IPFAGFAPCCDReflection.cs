using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPFAGFAPCCDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPFAGFAPCCDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJUEZBR0ZBUENDRC5wcm90bypkCgtJUEZBR0ZBUENDRBIbChdJUEZBR0ZB" + "UENDRF9QQ1BESEVMUEtFTRAAEhsKF0lQRkFHRkFQQ0NEX01MRU1PQUtLSkpI" + "EAESGwoXSVBGQUdGQVBDQ0RfQkFPR0FNS0NMTU8QAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(IPFAGFAPCCD) }, null, null));
	}
}
