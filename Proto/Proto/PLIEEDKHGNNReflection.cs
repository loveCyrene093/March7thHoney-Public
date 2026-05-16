using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PLIEEDKHGNNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PLIEEDKHGNNReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQTElFRURLSEdOTi5wcm90byKLAQoLUExJRUVES0hHTk4SEwoLREdMSVBM";
		buffer[1] = "QUhNQkYYASADKA0SEwoLQ0FKQ0FHTkJHRUsYBSABKAgSEwoLSENBRkNHS0xL";
		buffer[2] = "RkQYByADKA0SEwoLQURERU1IRkpKQUgYCSABKA0SEwoLSkxEUEFJUEFNTkIY";
		buffer[3] = "DSABKA0SEwoLQk1HRUJGSEhDT0QYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[4] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PLIEEDKHGNN), PLIEEDKHGNN.Parser, new string[6] { "DGLIPLAHMBF", "CAJCAGNBGEK", "HCAFCGKLKFD", "ADDEMHFJJAH", "JLDPAIPAMNB", "BMGEBFHHCOD" }, null, null, null, null)
		}));
	}
}
