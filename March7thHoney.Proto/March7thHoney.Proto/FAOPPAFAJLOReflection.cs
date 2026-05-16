using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FAOPPAFAJLOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FAOPPAFAJLOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQU9QUEFGQUpMTy5wcm90byI3CgtGQU9QUEFGQUpMTxITCgtKTk5LSkFF" + "TU9CThgDIAMoDRITCgtORk9ESUJJSUdNTxgGIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FAOPPAFAJLO), FAOPPAFAJLO.Parser, new string[2] { "JNNKJAEMOBN", "NFODIBIIGMO" }, null, null, null, null)
		}));
	}
}
