using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BALJGODBJECReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BALJGODBJECReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFCQUxKR09EQkpFQy5wcm90byqBAQoLQkFMSkdPREJKRUMSGwoXQkFMSkdP";
		buffer[1] = "REJKRUNfUENQREhFTFBLRU0QABIbChdCQUxKR09EQkpFQ19MRURFRUFIQ0RL";
		buffer[2] = "SRABEhsKF0JBTEpHT0RCSkVDX0hDRUtGRUVOTkNBEAISGwoXQkFMSkdPREJK";
		buffer[3] = "RUNfRkhGTU9FTkZMR0sQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BALJGODBJEC) }, null, null));
	}
}
