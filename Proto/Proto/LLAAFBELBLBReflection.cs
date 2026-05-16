using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LLAAFBELBLBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LLAAFBELBLBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTEFBRkJFTEJMQi5wcm90byIiCgtMTEFBRkJFTEJMQhITCgtDREtFREZQ" + "RUZJShgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LLAAFBELBLB), LLAAFBELBLB.Parser, new string[1] { "CDKEDFPEFIJ" }, null, null, null, null)
		}));
	}
}
