using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMessageTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMessageTypeReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "ChRDbWRNZXNzYWdlVHlwZS5wcm90byqhAwoOQ21kTWVzc2FnZVR5cGUSGwoX";
		buffer[1] = "UEhMTU1PSlBLSEFfUENQREhFTFBLRU0QABIZChRDbWRGaW5pc2hJdGVtSWRT";
		buffer[2] = "Y1JzcBCeFRIeChlDbWRHZXRNaXNzaW9uTWVzc2FnZVNjUnNwEI0VEiMKHkNt";
		buffer[3] = "ZEZpbmlzaFBlcmZvcm1TZWN0aW9uSWRTY1JzcBCmFRIcChdDbWRGaW5pc2hT";
		buffer[4] = "ZWN0aW9uSWRTY1JzcBDuFRIcChdDbWRGaW5pc2hTZWN0aW9uSWRDc1JlcRCV";
		buffer[5] = "FRIZChRDbWRGaW5pc2hJdGVtSWRDc1JlcRCaFRIjCh5DbWRGaW5pc2hQZXJm";
		buffer[6] = "b3JtU2VjdGlvbklkQ3NSZXEQyxUSGQoUQ21kR2V0TnBjU3RhdHVzQ3NSZXEQ";
		buffer[7] = "6hUSHgoZQ21kR2V0TWlzc2lvbk1lc3NhZ2VDc1JlcRCzFRIfChpDbWRHZXRO";
		buffer[8] = "cGNNZXNzYWdlR3JvdXBDc1JlcRDnFRIfChpDbWRHZXROcGNNZXNzYWdlR3Jv";
		buffer[9] = "dXBTY1JzcBCWFRIZChRDbWRHZXROcGNTdGF0dXNTY1JzcBDrFUIWqgITTWFy";
		buffer[10] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMessageType) }, null, null));
	}
}
