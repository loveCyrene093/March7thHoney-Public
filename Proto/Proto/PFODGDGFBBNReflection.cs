using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PFODGDGFBBNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PFODGDGFBBNReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQRk9ER0RHRkJCTi5wcm90byqeAQoLUEZPREdER0ZCQk4SGwoXUEZPREdE";
		buffer[1] = "R0ZCQk5fR01JSU9GTUZNUE8QABIbChdQRk9ER0RHRkJCTl9JT01FRUVDT0lP";
		buffer[2] = "QhABEhsKF1BGT0RHREdGQkJOX09KQ0NGSEhGS0FPEAISGwoXUEZPREdER0ZC";
		buffer[3] = "Qk5fRUZOTU1EQkFGR00QAxIbChdQRk9ER0RHRkJCTl9KRExKTEdPQUhPSRAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PFODGDGFBBN) }, null, null));
	}
}
