using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdLineupTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdLineupTypeReflection()
	{
		_003C_003Ey__InlineArray20<string> buffer = default(_003C_003Ey__InlineArray20<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 0) = "ChNDbWRMaW5ldXBUeXBlLnByb3RvKrMGCg1DbWRMaW5ldXBUeXBlEhsKF0tF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 1) = "QUNIRkNDQU9JX1BDUERIRUxQS0VNEAASHwoaQ21kQ2hhbmdlTGluZXVwTGVh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 2) = "ZGVyU2NSc3AQwAUSGgoVQ21kU2V0TGluZXVwTmFtZVNjUnNwEN0FEhcKEkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 3) = "ZFF1aXRMaW5ldXBTY1JzcBCeBhIfChpDbWRDaGFuZ2VMaW5ldXBMZWFkZXJD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 4) = "c1JlcRDhBRIgChtDbWRFeHRyYUxpbmV1cERlc3Ryb3lOb3RpZnkQlQYSIAob";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 5) = "Q21kR2V0TGluZXVwQXZhdGFyRGF0YUNzUmVxEL0FEh0KGENtZEdldEFsbExp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 6) = "bmV1cERhdGFDc1JlcRD5BRIuCilDbWRWaXJ0dWFsTGluZXVwVHJpYWxBdmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 7) = "YXJDaGFuZ2VTY05vdGlmeRCcBhIaChVDbWRSZXBsYWNlTGluZXVwU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 8) = "oAYSHQoYQ21kR2V0Q3VyTGluZXVwRGF0YVNjUnNwEJsGEhcKEkNtZEpvaW5M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 9) = "aW5ldXBTY1JzcBDOBRITCg5DbWRBSkpBQU1OREdFSBDGBRIeChlDbWRTd2l0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 10) = "Y2hMaW5ldXBJbmRleENzUmVxEOIFEh4KGUNtZFN3aXRjaExpbmV1cEluZGV4";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 11) = "U2NSc3AQhAYSFwoSQ21kSm9pbkxpbmV1cENzUmVxEMoFEh0KGENtZEdldEN1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 12) = "ckxpbmV1cERhdGFDc1JlcRCaBhIdChhDbWRHZXRBbGxMaW5ldXBEYXRhU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 13) = "c3AQwwUSEwoOQ21kQkNOT0dFTkFISkoQ1gUSIgodQ21kVmlydHVhbExpbmV1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 14) = "cERlc3Ryb3lOb3RpZnkQ9gUSFwoSQ21kU3dhcExpbmV1cENzUmVxEPsFEhwK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 15) = "F0tFQUNIRkNDQU9JX05OTU1OTURKRUxLEJcGEiAKG0NtZEdldExpbmV1cEF2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 16) = "YXRhckRhdGFTY1JzcBCGBhIaChVDbWRSZXBsYWNlTGluZXVwQ3NSZXEQ6AUS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 17) = "GAoTQ21kU3luY0xpbmV1cE5vdGlmeRDjBRIXChJDbWRRdWl0TGluZXVwQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 18) = "ZXEQxQUSGgoVQ21kU2V0TGluZXVwTmFtZUNzUmVxENwFQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 19) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray20<string>, string>(in buffer, 20))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdLineupType) }, null, null));
	}
}
