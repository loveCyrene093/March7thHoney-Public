using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NMAJCDOJOIIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NMAJCDOJOIIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTUFKQ0RPSk9JSS5wcm90bxoRSEpHRkRJS0RJSE8ucHJvdG8iaAoLTk1B" + "SkNET0pPSUkSIQoLRkVLQUZISUREQUgYAyADKAsyDC5ISkdGRElLRElITxIT" + "CgtPRkhDTkdISkZISRgEIAEoDRIhCgtPSU1JUERPTURBQRgKIAMoCzIMLkhK" + "R0ZESUtESUhPQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { HJGFDIKDIHOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NMAJCDOJOII), NMAJCDOJOII.Parser, new string[3] { "FEKAFHIDDAH", "OFHCNGHJFHI", "OIMIPDOMDAA" }, null, null, null, null)
		}));
	}
}
