using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FFMODDDADKJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FFMODDDADKJReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFGRk1PREREQURLSi5wcm90byrYAQoLRkZNT0REREFES0oSGwoXRkZNT0RE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "REFES0pfUENQREhFTFBLRU0QABIbChdGRk1PREREQURLSl9GQU1NTElOR0xE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "QRABEhsKF0ZGTU9ERERBREtKX0JIS0lETE1MTktBEAISGwoXRkZNT0REREFE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "S0pfTUNCRE5PQURNSUkQAxIbChdGRk1PREREQURLSl9PRkdFRENCRURNThAE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "EhsKF0ZGTU9ERERBREtKX0xQSE9BSUpGUE5QEAUSGwoXRkZNT0REREFES0pf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "S0pBSUVFSUFDSEkQBkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FFMODDDADKJ) }, null, null));
	}
}
