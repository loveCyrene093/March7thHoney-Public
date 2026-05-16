using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EDHFGMGGOJHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EDHFGMGGOJHReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFFREhGR01HR09KSC5wcm90byrYAQoLRURIRkdNR0dPSkgSGwoXRURIRkdN";
		buffer[1] = "R0dPSkhfUENQREhFTFBLRU0QABIbChdFREhGR01HR09KSF9KUEZLSUxLTkpM";
		buffer[2] = "TxABEhsKF0VESEZHTUdHT0pIX0dPUEVFQk9JQlBGEAISGwoXRURIRkdNR0dP";
		buffer[3] = "SkhfQU1BT0lFTUJISEwQAxIbChdFREhGR01HR09KSF9NS0ZLR0ZITExHTxAE";
		buffer[4] = "EhsKF0VESEZHTUdHT0pIX0xLT0VGREREUEJBEAUSGwoXRURIRkdNR0dPSkhf";
		buffer[5] = "R0JLT0dOQ0FCRUkQBkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(EDHFGMGGOJH) }, null, null));
	}
}
