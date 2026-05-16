using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdTrackPhotoActivityTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdTrackPhotoActivityTypeReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "Ch9DbWRUcmFja1Bob3RvQWN0aXZpdHlUeXBlLnByb3RvKs0CChlDbWRUcmFj";
		buffer[1] = "a1Bob3RvQWN0aXZpdHlUeXBlEhsKF0lHTkFFSkVNQkZPX1BDUERIRUxQS0VN";
		buffer[2] = "EAASIQocQ21kU3RhcnRUcmFja1Bob3RvU3RhZ2VDc1JlcRCDOxIiCh1DbWRT";
		buffer[3] = "ZXR0bGVUcmFja1Bob3RvU3RhZ2VDc1JlcRD/OhITCg5DbWRFQUFITkRPSFBQ";
		buffer[4] = "SBCEOxIiCh1DbWRTZXR0bGVUcmFja1Bob3RvU3RhZ2VTY1JzcBCFOxImCiFD";
		buffer[5] = "bWRHZXRUcmFja1Bob3RvQWN0aXZpdHlEYXRhQ3NSZXEQhzsSIAobQ21kUXVp";
		buffer[6] = "dFRyYWNrUGhvdG9TdGFnZUNzUmVxEIA7EiYKIUNtZEdldFRyYWNrUGhvdG9B";
		buffer[7] = "Y3Rpdml0eURhdGFTY1JzcBCIOxIhChxDbWRTdGFydFRyYWNrUGhvdG9TdGFn";
		buffer[8] = "ZVNjUnNwEII7QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdTrackPhotoActivityType) }, null, null));
	}
}
