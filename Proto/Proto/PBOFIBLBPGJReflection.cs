using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PBOFIBLBPGJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PBOFIBLBPGJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQQk9GSUJMQlBHSi5wcm90byqeAQoLUEJPRklCTEJQR0oSGwoXUEJPRklC";
		buffer[1] = "TEJQR0pfSUpMSkZQS0lFT1AQABIbChdQQk9GSUJMQlBHSl9BQk1CT01KUE1O";
		buffer[2] = "RBABEhsKF1BCT0ZJQkxCUEdKX0VGTEpEREJDSUZEEAISGwoXUEJPRklCTEJQ";
		buffer[3] = "R0pfQ0tPRExERVBFUEcQAxIbChdQQk9GSUJMQlBHSl9EQ1BOQUlMSUtGTRAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PBOFIBLBPGJ) }, null, null));
	}
}
