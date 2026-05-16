using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdTutorialTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdTutorialTypeReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 0) = "ChVDbWRUdXRvcmlhbFR5cGUucHJvdG8qnAMKD0NtZFR1dG9yaWFsVHlwZRIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 1) = "ChdGRU9GQUVFQk5QQV9QQ1BESEVMUEtFTRAAEiAKG0NtZFVubG9ja1R1dG9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 2) = "aWFsR3VpZGVTY1JzcBCiDRIdChhDbWRHZXRUdXRvcmlhbEd1aWRlQ3NSZXEQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 3) = "ng0SGAoTQ21kR2V0VHV0b3JpYWxDc1JlcRCbDRIgChtDbWRVbmxvY2tUdXRv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 4) = "cmlhbEd1aWRlQ3NSZXEQyQwSHQoYQ21kR2V0VHV0b3JpYWxHdWlkZVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 5) = "EJ8NEhsKFkNtZEZpbmlzaFR1dG9yaWFsU2NSc3AQ2gwSGAoTQ21kR2V0VHV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 6) = "b3JpYWxTY1JzcBDKDBIgChtDbWRGaW5pc2hUdXRvcmlhbEd1aWRlU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 7) = "wQwSGwoWQ21kRmluaXNoVHV0b3JpYWxDc1JlcRD/DBIgChtDbWRGaW5pc2hU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 8) = "dXRvcmlhbEd1aWRlQ3NSZXEQ5wwSGwoWQ21kVW5sb2NrVHV0b3JpYWxDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 9) = "cRDODBIbChZDbWRVbmxvY2tUdXRvcmlhbFNjUnNwENIMQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 10) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray11<string>, string>(in buffer, 11))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdTutorialType) }, null, null));
	}
}
