using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRaidCollectionTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRaidCollectionTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChtDbWRSYWlkQ29sbGVjdGlvblR5cGUucHJvdG8q3wEKFUNtZFJhaWRDb2xs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "ZWN0aW9uVHlwZRIbChdNQlBQSUlFQkJESl9QQ1BESEVMUEtFTRAAEhMKDkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "ZEZCS01MQkFGS0ZMEJ42EigKI0NtZFJhaWRDb2xsZWN0aW9uRW50ZXJOZXh0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "UmFpZFNjUnNwEKs2EigKI0NtZFJhaWRDb2xsZWN0aW9uRW50ZXJOZXh0UmFp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "ZENzUmVxEKY2Eh8KGkNtZFJhaWRDb2xsZWN0aW9uRGF0YVNjUnNwELA2Eh8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "GkNtZFJhaWRDb2xsZWN0aW9uRGF0YUNzUmVxEJ02QhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRaidCollectionType) }, null, null));
	}
}
