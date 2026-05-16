using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AGLNDMMGFMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AGLNDMMGFMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBR0xORE1NR0ZNTC5wcm90bxoRSU1NTU5MRUFJQkgucHJvdG8aEUpJUEFD" + "REVKS0pDLnByb3RvIlMKC0FHTE5ETU1HRk1MEiEKC0RJSEVDSUlLRUxFGAYg" + "ASgLMgwuSklQQUNERUpLSkMSIQoLRkhQTUVQSk5CQkYYDiABKA4yDC5JTU1N" + "TkxFQUlCSEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			IMMMNLEAIBHReflection.Descriptor,
			JIPACDEJKJCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AGLNDMMGFML), AGLNDMMGFML.Parser, new string[2] { "DIHECIIKELE", "FHPMEPJNBBF" }, null, null, null, null)
		}));
	}
}
