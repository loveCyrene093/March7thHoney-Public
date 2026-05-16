using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HNDCKMIALOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HNDCKMIALOGReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFITkRDS01JQUxPRy5wcm90byqeAQoLSE5EQ0tNSUFMT0cSGwoXSE5EQ0tN";
		buffer[1] = "SUFMT0dfT0pBT0dCREpDTE0QABIbChdITkRDS01JQUxPR19LTkFMSUhGTElJ";
		buffer[2] = "TxABEhsKF0hORENLTUlBTE9HX01BTVBEUEFIREhPEAISGwoXSE5EQ0tNSUFM";
		buffer[3] = "T0dfR0JGREtLQkdCRU8QAxIbChdITkRDS01JQUxPR19NR05OUEZNSkJFRBAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(HNDCKMIALOG) }, null, null));
	}
}
