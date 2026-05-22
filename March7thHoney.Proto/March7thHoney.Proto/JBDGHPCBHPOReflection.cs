using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JBDGHPCBHPOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JBDGHPCBHPOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQkRHSFBDQkhQTy5wcm90bxoRREFESFBBRkpEQUcucHJvdG8iVwoLSkJE" + "R0hQQ0JIUE8SIQoLSEZETUJFSEdDTU4YASADKAsyDC5EQURIUEFGSkRBRxIQ" + "Cghncm91cF9pZBgHIAEoDRITCgtGR0NBSUtBTkRNSBgLIAEoCEIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DADHPAFJDAGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JBDGHPCBHPO), JBDGHPCBHPO.Parser, new string[3] { "HFDMBEHGCMN", "GroupId", "FGCAIKANDMH" }, null, null, null, null)
		}));
	}
}
