using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EJIJAMBBJMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EJIJAMBBJMNReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFFSklKQU1CQkpNTi5wcm90byr1AQoLRUpJSkFNQkJKTU4SGwoXRUpJSkFN";
		buffer[1] = "QkJKTU5fTEhES0pLT09QSlAQABIbChdFSklKQU1CQkpNTl9CQUtEUEdCS05I";
		buffer[2] = "SBABEhsKF0VKSUpBTUJCSk1OX0FFRkRHRUlLT0JFEAISGwoXRUpJSkFNQkJK";
		buffer[3] = "TU5fT09DSklOR0tFTk0QAxIbChdFSklKQU1CQkpNTl9LRUNMT0RHT0lBSRAE";
		buffer[4] = "EhsKF0VKSUpBTUJCSk1OX0JLTkZNRkdJTklQEAUSGwoXRUpJSkFNQkJKTU5f";
		buffer[5] = "QktESU9MT0VLSUwQBhIbChdFSklKQU1CQkpNTl9LS0dBSU5GR0ZGRxAHQhaq";
		buffer[6] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(EJIJAMBBJMN) }, null, null));
	}
}
