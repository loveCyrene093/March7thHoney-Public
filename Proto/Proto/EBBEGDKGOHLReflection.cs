using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EBBEGDKGOHLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EBBEGDKGOHLReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFFQkJFR0RLR09ITC5wcm90bxoRSEhNRE9ORU9FQUsucHJvdG8iegoLRUJC";
		buffer[1] = "RUdES0dPSEwSDwoHcmV0Y29kZRgFIAEoDRITCgtPR0hGTU9BTFBFTxgHIAEo";
		buffer[2] = "DRIQCghwYW5lbF9pZBgJIAEoDRIQCghncm91cF9pZBgKIAEoDRIhCgtGUE9P";
		buffer[3] = "R0hFSkREThgMIAEoCzIMLkhITURPTkVPRUFLQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[4] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HHMDONEOEAKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EBBEGDKGOHL), EBBEGDKGOHL.Parser, new string[5] { "Retcode", "OGHFMOALPEO", "PanelId", "GroupId", "FPOOGHEJDDN" }, null, null, null, null)
		}));
	}
}
