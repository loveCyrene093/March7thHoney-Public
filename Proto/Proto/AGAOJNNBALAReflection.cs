using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AGAOJNNBALAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AGAOJNNBALAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFBR0FPSk5OQkFMQS5wcm90bxoRTkpHREtERURCTkIucHJvdG8aEU9NTE9O";
		buffer[1] = "R05PTUFJLnByb3RvInQKC0FHQU9KTk5CQUxBEiEKC0dQT05KQUFQT01OGAYg";
		buffer[2] = "AygLMgwuTkpHREtERURCTkISHAoGc291cmNlGAcgASgLMgwuT01MT05HTk9N";
		buffer[3] = "QUkSEQoJdW5pcXVlX2lkGAkgASgEEhEKCWNvbmZpZ19pZBgMIAEoDUIWqgIT";
		buffer[4] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			NJGDKDEDBNBReflection.Descriptor,
			OMLONGNOMAIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AGAOJNNBALA), AGAOJNNBALA.Parser, new string[4] { "GPONJAAPOMN", "Source", "UniqueId", "ConfigId" }, null, null, null, null)
		}));
	}
}
