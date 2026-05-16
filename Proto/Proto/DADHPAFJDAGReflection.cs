using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DADHPAFJDAGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DADHPAFJDAGReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFEQURIUEFGSkRBRy5wcm90bxoRQkVOT0RDQ0dCS0EucHJvdG8aEUVLSkdM";
		buffer[1] = "SUlKSUJELnByb3RvIpABCgtEQURIUEFGSkRBRxITCgtQSk1JRU1BT05JThgD";
		buffer[2] = "IAEoDRITCgtJQ0FMT09ESEFPShgIIAEoCBIjCgtIRU9DUEZHQkVESBgCIAEo";
		buffer[3] = "CzIMLkJFTk9EQ0NHQktBSAASIwoLS0pFSUpLUFBOQk0YCSABKAsyDC5FS0pH";
		buffer[4] = "TElJSklCREgAQg0KC0pOTElPQ0NFQ0JHQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[5] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BENODCCGBKAReflection.Descriptor,
			EKJGLIIJIBDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DADHPAFJDAG), DADHPAFJDAG.Parser, new string[4] { "PJMIEMAONIN", "ICALOODHAOJ", "HEOCPFGBEDH", "KJEIJKPPNBM" }, new string[1] { "JNLIOCCECBG" }, null, null, null)
		}));
	}
}
