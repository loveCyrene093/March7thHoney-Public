using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EKHNMPALBLDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EKHNMPALBLDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFS0hOTVBBTEJMRC5wcm90bxoRT0JFQ0JNTU1ESEMucHJvdG8iMAoLRUtI" + "Tk1QQUxCTEQSIQoLTkpFTEdFQkhBT1AYASABKAsyDC5PQkVDQk1NTURIQ0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { OBECBMMMDHCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EKHNMPALBLD), EKHNMPALBLD.Parser, new string[1] { "NJELGEBHAOP" }, null, null, null, null)
		}));
	}
}
