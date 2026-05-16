using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FFLIMLMFABPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FFLIMLMFABPReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFGRkxJTUxNRkFCUC5wcm90byr1AQoLRkZMSU1MTUZBQlASGwoXRkZMSU1M";
		buffer[1] = "TUZBQlBfUENQREhFTFBLRU0QABIbChdGRkxJTUxNRkFCUF9JTU1ESUNOSU1M";
		buffer[2] = "RBABEhsKF0ZGTElNTE1GQUJQX0ZCSE5OSUpCS0NLEAISGwoXRkZMSU1MTUZB";
		buffer[3] = "QlBfR0dMRk5ITkhJR08QAxIbChdGRkxJTUxNRkFCUF9IRktGTkZBR0FGQhAE";
		buffer[4] = "EhsKF0ZGTElNTE1GQUJQX05OR05FTlBGT0lIEAUSGwoXRkZMSU1MTUZBQlBf";
		buffer[5] = "RUZGUEFLQUxPRUsQBhIbChdGRkxJTUxNRkFCUF9FR05ESkdLS0pITxAHQhaq";
		buffer[6] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FFLIMLMFABP) }, null, null));
	}
}
