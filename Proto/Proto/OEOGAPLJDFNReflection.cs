using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OEOGAPLJDFNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OEOGAPLJDFNReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFPRU9HQVBMSkRGTi5wcm90byrMAgoLT0VPR0FQTEpERk4SGwoXT0VPR0FQ";
		buffer[1] = "TEpERk5fR0NJQkZOQ0VLSUwQABIbChdPRU9HQVBMSkRGTl9LRkNERkdKTElL";
		buffer[2] = "RxABEhsKF09FT0dBUExKREZOX0lNS0lIRkhGQkZQEAISGwoXT0VPR0FQTEpE";
		buffer[3] = "Rk5fSU5KSUFERk9KRUEQAxIbChdPRU9HQVBMSkRGTl9DSE5JTkNIQVBLQhAE";
		buffer[4] = "EhsKF09FT0dBUExKREZOX0tIT0hPRUdFRktKEAUSGwoXT0VPR0FQTEpERk5f";
		buffer[5] = "REdGRE1LTENQR0gQBhIbChdPRU9HQVBMSkRGTl9DR0pFSEJKT1BOQhAHEhsK";
		buffer[6] = "F09FT0dBUExKREZOX0xCSklHTk9LRUxKEAgSGwoXT0VPR0FQTEpERk5fRlBP";
		buffer[7] = "S05FRk9OTk4QCRIbChdPRU9HQVBMSkRGTl9QTUdNSUxFRE1LSBAKQhaqAhNN";
		buffer[8] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(OEOGAPLJDFN) }, null, null));
	}
}
