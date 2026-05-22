using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRollShopTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRollShopTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChVDbWRSb2xsU2hvcFR5cGUucHJvdG8q7AEKD0NtZFJvbGxTaG9wVHlwZRIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "ChdNTkNJQUFBRlBLS19QQ1BESEVMUEtFTRAAEhwKF0NtZEdldFJvbGxTaG9w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "SW5mb0NzUmVxEPU1Eh4KGUNtZERvR2FjaGFJblJvbGxTaG9wQ3NSZXEQ9jUS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "HAoXQ21kR2V0Um9sbFNob3BJbmZvU2NSc3AQiDYSHgoZQ21kRG9HYWNoYUlu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "Um9sbFNob3BTY1JzcBD+NRIfChpDbWRUYWtlUm9sbFNob3BSZXdhcmRTY1Jz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "cBD8NRIfChpDbWRUYWtlUm9sbFNob3BSZXdhcmRDc1JlcRCDNkIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRollShopType) }, null, null));
	}
}
