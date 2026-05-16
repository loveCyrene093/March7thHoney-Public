using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdClockParkTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdClockParkTypeReflection()
	{
		InlineArray15<string> buffer = default(InlineArray15<string>);
		buffer[0] = "ChZDbWRDbG9ja1BhcmtUeXBlLnByb3RvKtkEChBDbWRDbG9ja1BhcmtUeXBl";
		buffer[1] = "EhsKF0VLREVHTU1IT0RPX1BDUERIRUxQS0VNEAASKQokQ21kQ2xvY2tQYXJr";
		buffer[2] = "SGFuZGxlV2FpdE9wZXJhdGlvblNjUnNwEMw4EhMKDkNtZEJFREZHUElGR0VE";
		buffer[3] = "ENI4EiUKIENtZENsb2NrUGFya0ZpbmlzaFNjcmlwdFNjTm90aWZ5ENE4Eh0K";
		buffer[4] = "GENtZENsb2NrUGFya0dldEluZm9Dc1JlcRCtOBIqCiVDbWRDbG9ja1BhcmtH";
		buffer[5] = "ZXRPbmdvaW5nU2NyaXB0SW5mb0NzUmVxEM84EiIKHUNtZENsb2NrUGFya1Vu";
		buffer[6] = "bG9ja1RhbGVudENzUmVxEMM4EhMKDkNtZE5BSkdJUElHQ0RIELU4EiEKHENt";
		buffer[7] = "ZENsb2NrUGFya1N0YXJ0U2NyaXB0U2NSc3AQoTgSIgodQ21kQ2xvY2tQYXJr";
		buffer[8] = "VW5sb2NrVGFsZW50U2NSc3AQxjgSIAobQ21kQ2xvY2tQYXJrUXVpdFNjcmlw";
		buffer[9] = "dENzUmVxELI4EjIKLUNtZENsb2NrUGFya0hhbmRsZVdhaXRQbGFjZURpY2VP";
		buffer[10] = "cGVyYXRpb25Dc1JlcRCiOBIdChhDbWRDbG9ja1BhcmtHZXRJbmZvU2NSc3AQ";
		buffer[11] = "pzgSIQocQ21kQ2xvY2tQYXJrU3RhcnRTY3JpcHRDc1JlcRClOBIqCiVDbWRD";
		buffer[12] = "bG9ja1BhcmtHZXRPbmdvaW5nU2NyaXB0SW5mb1NjUnNwELM4EhMKDkNtZEFQ";
		buffer[13] = "QkpPQk5QQkFOEM04Eh0KGENtZENsb2NrUGFya1VzZUJ1ZmZDc1JlcRC/OEIW";
		buffer[14] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdClockParkType) }, null, null));
	}
}
