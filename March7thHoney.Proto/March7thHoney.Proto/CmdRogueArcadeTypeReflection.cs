using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRogueArcadeTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRogueArcadeTypeReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChhDbWRSb2d1ZUFyY2FkZVR5cGUucHJvdG8qsQIKEkNtZFJvZ3VlQXJjYWRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "VHlwZRIbChdKRUpNT0tLRUdMSV9QQ1BESEVMUEtFTRAAEh8KGkNtZFJvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "QXJjYWRlR2V0SW5mb1NjUnNwEP07Eh8KGkNtZFJvZ3VlQXJjYWRlUmVzdGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "dENzUmVxEIE8Eh8KGkNtZFJvZ3VlQXJjYWRlR2V0SW5mb0NzUmVxEOM7Eh0K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "GENtZFJvZ3VlQXJjYWRlU3RhcnRDc1JlcRCHPBIfChpDbWRSb2d1ZUFyY2Fk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "ZVJlc3RhcnRTY1JzcBCSPBIdChhDbWRSb2d1ZUFyY2FkZUxlYXZlU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "5zsSHQoYQ21kUm9ndWVBcmNhZGVTdGFydFNjUnNwEPQ7Eh0KGENtZFJvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "QXJjYWRlTGVhdmVDc1JlcRDpO0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueArcadeType) }, null, null));
	}
}
