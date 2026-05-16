using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JBMMIPAGDCEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JBMMIPAGDCEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQk1NSVBBR0RDRS5wcm90bxoRRUZFR0tESEVNRk4ucHJvdG8iRQoLSkJN" + "TUlQQUdEQ0USEwoLR0JDUEdPQUZFQkMYByABKA0SIQoLT0JITkhLS0RHSEMY" + "CSABKAsyDC5FRkVHS0RIRU1GTkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { EFEGKDHEMFNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JBMMIPAGDCE), JBMMIPAGDCE.Parser, new string[2] { "GBCPGOAFEBC", "OBHNHKKDGHC" }, null, null, null, null)
		}));
	}
}
