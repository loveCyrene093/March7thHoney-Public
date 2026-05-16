using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DIMFOAAJNGNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DIMFOAAJNGNReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFESU1GT0FBSk5HTi5wcm90byqeAQoLRElNRk9BQUpOR04SGwoXRElNRk9B";
		buffer[1] = "QUpOR05fQ01CQ0NMSUFJSUsQABIbChdESU1GT0FBSk5HTl9KSFBER0tLTExC";
		buffer[2] = "SRABEhsKF0RJTUZPQUFKTkdOX0hDTkhBUEJBUEdEEAISGwoXRElNRk9BQUpO";
		buffer[3] = "R05fRE9KT0hHTk9GRkwQAxIbChdESU1GT0FBSk5HTl9JTEJQUExORk1IThAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DIMFOAAJNGN) }, null, null));
	}
}
