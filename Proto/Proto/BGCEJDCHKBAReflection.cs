using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BGCEJDCHKBAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BGCEJDCHKBAReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFCR0NFSkRDSEtCQS5wcm90byqvAgoLQkdDRUpEQ0hLQkESGwoXQkdDRUpE";
		buffer[1] = "Q0hLQkFfUENQREhFTFBLRU0QABIbChdCR0NFSkRDSEtCQV9NTk1NR0lBTEFP";
		buffer[2] = "SBABEhsKF0JHQ0VKRENIS0JBX0lETUlDUEJIRU9EEAISGwoXQkdDRUpEQ0hL";
		buffer[3] = "QkFfTklJTExNSk5HRUMQAxIbChdCR0NFSkRDSEtCQV9NT05JTE5NSUJMRxAE";
		buffer[4] = "EhsKF0JHQ0VKRENIS0JBX0NLQUlESUlKSkpGEAUSGwoXQkdDRUpEQ0hLQkFf";
		buffer[5] = "QkVIQkNBQ0pDUEoQBhIbChdCR0NFSkRDSEtCQV9FSUtGRUdPT01DQxAHEhsK";
		buffer[6] = "F0JHQ0VKRENIS0JBX0xPRUhITEJKQUNGEAgSGwoXQkdDRUpEQ0hLQkFfTkRK";
		buffer[7] = "RURNS05KTUIQCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BGCEJDCHKBA) }, null, null));
	}
}
