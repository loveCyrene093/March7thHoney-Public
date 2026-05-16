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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFGRkxJTUxNRkFCUC5wcm90byr1AQoLRkZMSU1MTUZBQlASGwoXRkZMSU1M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "TUZBQlBfUENQREhFTFBLRU0QABIbChdGRkxJTUxNRkFCUF9JTU1ESUNOSU1M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "RBABEhsKF0ZGTElNTE1GQUJQX0ZCSE5OSUpCS0NLEAISGwoXRkZMSU1MTUZB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "QlBfR0dMRk5ITkhJR08QAxIbChdGRkxJTUxNRkFCUF9IRktGTkZBR0FGQhAE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "EhsKF0ZGTElNTE1GQUJQX05OR05FTlBGT0lIEAUSGwoXRkZMSU1MTUZBQlBf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "RUZGUEFLQUxPRUsQBhIbChdGRkxJTUxNRkFCUF9FR05ESkdLS0pITxAHQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FFLIMLMFABP) }, null, null));
	}
}
