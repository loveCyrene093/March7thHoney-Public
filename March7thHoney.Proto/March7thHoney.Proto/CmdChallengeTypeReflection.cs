using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdChallengeTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdChallengeTypeReflection()
	{
		_003C_003Ey__InlineArray18<string> buffer = default(_003C_003Ey__InlineArray18<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 0) = "ChZDbWRDaGFsbGVuZ2VUeXBlLnByb3RvKuoFChBDbWRDaGFsbGVuZ2VUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 1) = "EhsKF0JOTEdKQktLS0JLX1BDUERIRUxQS0VNEAASHQoYQ21kQ2hhbGxlbmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 2) = "U2V0dGxlTm90aWZ5EK0NEigKI0NtZEdldENoYWxsZW5nZUdyb3VwU3RhdGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 3) = "dGljc0NzUmVxEOwNEhsKFkNtZExlYXZlQ2hhbGxlbmdlQ3NSZXEQsg0SGQoU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 4) = "Q21kR2V0Q2hhbGxlbmdlQ3NSZXEQ/w0SIgodQ21kU3RhcnRQYXJ0aWFsQ2hh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 5) = "bGxlbmdlU2NSc3AQ4Q0SKAojQ21kR2V0Q2hhbGxlbmdlR3JvdXBTdGF0aXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 6) = "aWNzU2NSc3AQxA0SIAobQ21kVGFrZUNoYWxsZW5nZVJld2FyZFNjUnNwEMoN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 7) = "EiAKG0NtZFRha2VDaGFsbGVuZ2VSZXdhcmRDc1JlcRCoDRIbChZDbWRTdGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 8) = "dENoYWxsZW5nZVNjUnNwEIMOEhwKF0NtZEdldEN1ckNoYWxsZW5nZVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 9) = "EMsNEiQKH0NtZEVudGVyQ2hhbGxlbmdlTmV4dFBoYXNlQ3NSZXEQiA4SHAoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 10) = "Q21kR2V0Q3VyQ2hhbGxlbmdlQ3NSZXEQvg0SJAofQ21kRW50ZXJDaGFsbGVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 11) = "Z2VOZXh0UGhhc2VTY1JzcBD9DRIbChZDbWRMZWF2ZUNoYWxsZW5nZVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 12) = "ELYNEhsKFkNtZFN0YXJ0Q2hhbGxlbmdlQ3NSZXEQgg4SIgodQ21kUmVzdGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 13) = "dENoYWxsZW5nZVBoYXNlU2NSc3AQ0A0SJgohQ21kQ2hhbGxlbmdlQm9zc1Bo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 14) = "YXNlU2V0dGxlTm90aWZ5EIQOEh0KGENtZFBhcnRpYWxDaGFsbGVuZ2VDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 15) = "cRDFDRIZChRDbWRHZXRDaGFsbGVuZ2VTY1JzcBCuDRIiCh1DbWRSZXN0YXJ0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 16) = "Q2hhbGxlbmdlUGhhc2VDc1JlcRDeDRIdChhDbWRDaGFsbGVuZ2VMaW5ldXBO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray18<string>, string>(ref buffer, 17) = "b3RpZnkQpQ1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray18<string>, string>(in buffer, 18))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdChallengeType) }, null, null));
	}
}
