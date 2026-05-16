using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMarbleTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMarbleTypeReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChNDbWRNYXJibGVUeXBlLnByb3RvKtUCCg1DbWRNYXJibGVUeXBlEhsKF0pH";
		buffer[1] = "SU9KREdEQU9EX1BDUERIRUxQS0VNEAASGgoVQ21kTWFyYmxlR2V0RGF0YVNj";
		buffer[2] = "UnNwEOJAEiMKHkNtZE1hcmJsZVB2cERhdGFVcGRhdGVTY05vdGlmeRDfQBIa";
		buffer[3] = "ChVDbWRNYXJibGVHZXREYXRhQ3NSZXEQz0ASIgodQ21kTWFyYmxlVXBkYXRl";
		buffer[4] = "U2hvd25TZWFsQ3NSZXEQ1UASGgoVQ21kTWFyYmxlU2hvcEJ1eVNjUnNwENZA";
		buffer[5] = "EiAKG0NtZE1hcmJsZVVubG9ja1NlYWxTY05vdGlmeRDcQBIiCh1DbWRNYXJi";
		buffer[6] = "bGVVcGRhdGVTaG93blNlYWxTY1JzcBDhQBITCg5DbWRQQ1BKS09IRkVDRRDY";
		buffer[7] = "QBITCg5DbWRJRkpESktNTUFCTBDQQBIaChVDbWRNYXJibGVTaG9wQnV5Q3NS";
		buffer[8] = "ZXEQ3UBCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMarbleType) }, null, null));
	}
}
