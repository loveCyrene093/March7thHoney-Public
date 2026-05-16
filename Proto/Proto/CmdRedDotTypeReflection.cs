using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRedDotTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRedDotTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChNDbWRSZWREb3RUeXBlLnByb3RvKsYBCg1DbWRSZWREb3RUeXBlEhsKF0hG";
		buffer[1] = "R09GSk5DRUFCX1BDUERIRUxQS0VNEAASEwoOQ21kRUJCRUdES0dPSEwQsi4S";
		buffer[2] = "HAoXSEZHT0ZKTkNFQUJfQkxNRExLQ0dOR0EQry4SHAoXSEZHT0ZKTkNFQUJf";
		buffer[3] = "SUxIUEVQTEFCRUQQqi4SEwoOQ21kS0RGQkxJUE5IT0wQpy4SHQoYQ21kR2V0";
		buffer[4] = "QWxsUmVkRG90RGF0YUNzUmVxEJkuEhMKDkNtZEtOR0VGSk1LTEtDEJMuQhaq";
		buffer[5] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRedDotType) }, null, null));
	}
}
