using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OJOLPAEPBDNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OJOLPAEPBDNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSk9MUEFFUEJETi5wcm90bxoRT0JDSkxEREVCSEwucHJvdG8iRQoLT0pP" + "TFBBRVBCRE4SIQoLTk1ISUFGR0NOQk4YByADKAsyDC5PQkNKTERERUJITBIT" + "CgtKQkxJTkFFS0dMShgNIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { OBCJLDDEBHLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OJOLPAEPBDN), OJOLPAEPBDN.Parser, new string[2] { "NMHIAFGCNBN", "JBLINAEKGLJ" }, null, null, null, null)
		}));
	}
}
