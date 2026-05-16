using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MHGDJPMEFFNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MHGDJPMEFFNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSEdESlBNRUZGTi5wcm90bypkCgtNSEdESlBNRUZGThIbChdNSEdESlBN" + "RUZGTl9QQ1BESEVMUEtFTRAAEhsKF01IR0RKUE1FRkZOX0pMSEZHRktKS1BC" + "EAESGwoXTUhHREpQTUVGRk5fRUlIRkFCT01QREsQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MHGDJPMEFFN) }, null, null));
	}
}
