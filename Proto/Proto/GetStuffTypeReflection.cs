using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetStuffTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetStuffTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChJHZXRTdHVmZlR5cGUucHJvdG8q2QEKDEdldFN0dWZmVHlwZRIbChdHQVBE";
		buffer[1] = "T1BGT0dFTl9CTEpFRUhGQ05DTxAAEhsKF0dBUERPUEZPR0VOX1BISkhORUlP";
		buffer[2] = "Q0pNEAESGwoXR0FQRE9QRk9HRU5fR0tQR0FFR1BETkwQAhIbChdHQVBET1BG";
		buffer[3] = "T0dFTl9MS0lLQkJGTlBORBADEhsKF0dBUERPUEZPR0VOX0JEQkVHTEFLT09H";
		buffer[4] = "EAQSGwoXR0FQRE9QRk9HRU5fSEFQUEJHT0ZBTEcQBRIbChdHQVBET1BGT0dF";
		buffer[5] = "Tl9KSktIQ0VLRE9GQxAGQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[6] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GetStuffType) }, null, null));
	}
}
