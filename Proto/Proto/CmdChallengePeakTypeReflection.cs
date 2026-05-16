using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdChallengePeakTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdChallengePeakTypeReflection()
	{
		InlineArray16<string> buffer = default(InlineArray16<string>);
		buffer[0] = "ChpDbWRDaGFsbGVuZ2VQZWFrVHlwZS5wcm90byqEBQoUQ21kQ2hhbGxlbmdl";
		buffer[1] = "UGVha1R5cGUSGwoXQ0tIUERHUEdCSk9fUENQREhFTFBLRU0QABIpCiRDbWRT";
		buffer[2] = "ZXRDaGFsbGVuZ2VQZWFrQm9zc0hhcmRNb2RlQ3NSZXEQ1kUSEwoOQ21kR0ZH";
		buffer[3] = "SUlBTEdMSU0Q6kUSEwoOQ21kQU1PQUFJT0ZFREYQ50USEwoOQ21kTUNGRURB";
		buffer[4] = "UEhETEMQ4kUSIQocQ21kR2V0Q2hhbGxlbmdlUGVha0RhdGFDc1JlcRDRRRIk";
		buffer[5] = "Ch9DbWRUYWtlQ2hhbGxlbmdlUGVha1Jld2FyZFNjUnNwENdFEhMKDkNtZEZB";
		buffer[6] = "QUFHQUdETU5IENlFEiEKHENtZEdldENoYWxsZW5nZVBlYWtEYXRhU2NSc3AQ";
		buffer[7] = "y0USKQokQ21kU2V0Q2hhbGxlbmdlUGVha0Jvc3NIYXJkTW9kZVNjUnNwEPFF";
		buffer[8] = "EiAKG0NtZEdldEN1ckNoYWxsZW5nZVBlYWtTY1JzcBDwRRITCg5DbWRLSURC";
		buffer[9] = "R0pDTU1PRxDKRRITCg5DbWRCRkxGRE1GRE1DTBDoRRIjCh5DbWRDaGFsbGVu";
		buffer[10] = "Z2VQZWFrU2V0dGxlU2NOb3RpZnkQyUUSEwoOQ21kR1BBT0lESUtMTE4Qx0US";
		buffer[11] = "EwoOQ21kTUpQUENOQU1NS1AQ30USEwoOQ21kTk5QR0pKUEtPR0wQ40USEwoO";
		buffer[12] = "Q21kUE1PTUhKSEdNSE4Q3kUSLAonQ21kQ2hhbGxlbmdlUGVha0dyb3VwRGF0";
		buffer[13] = "YVVwZGF0ZVNjTm90aWZ5EMVFEiQKH0NtZFRha2VDaGFsbGVuZ2VQZWFrUmV3";
		buffer[14] = "YXJkQ3NSZXEQ80USIAobQ21kR2V0Q3VyQ2hhbGxlbmdlUGVha0NzUmVxEMZF";
		buffer[15] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdChallengePeakType) }, null, null));
	}
}
