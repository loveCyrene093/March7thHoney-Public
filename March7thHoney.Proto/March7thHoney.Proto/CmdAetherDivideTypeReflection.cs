using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdAetherDivideTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdAetherDivideTypeReflection()
	{
		_003C_003Ey__InlineArray33<string> buffer = default(_003C_003Ey__InlineArray33<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 0) = "ChlDbWRBZXRoZXJEaXZpZGVUeXBlLnByb3RvKuMKChNDbWRBZXRoZXJEaXZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 1) = "ZGVUeXBlEhsKF0ZJQkdOQktHSE5GX1BDUERIRUxQS0VNEAASHQoYQ21kVGFr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 2) = "ZU9mZlNraWxsQ29yZVNjUnNwENAlEioKJUNtZENsZWFyQWV0aGVyRGl2aWRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 3) = "UGFzc2l2ZVNraWxsQ3NSZXEQ8iUSKQokQ21kU3dpdGNoQWV0aGVyRGl2aWRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 4) = "TGluZVVwU2xvdFNjUnNwENUlEhMKDkNtZE5QQk5QT0tHTkNJENslEikKJENt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 5) = "ZFN0YXJ0QWV0aGVyRGl2aWRlU3RhZ2VCYXR0bGVTY1JzcBDPJRIsCidDbWRB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 6) = "ZXRoZXJEaXZpZGVUYWtlQ2hhbGxlbmdlUmV3YXJkU2NSc3AQ6CUSJgohQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 7) = "QWV0aGVyRGl2aWRlVGFpbmVySW5mb1NjTm90aWZ5EOUlEicKIkNtZEFldGhl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 8) = "ckRpdmlkZVJlZnJlc2hFbmRsZXNzU2NSc3AQ1CUSLQooQ21kU3RhcnRBZXRo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 9) = "ZXJEaXZpZGVDaGFsbGVuZ2VCYXR0bGVTY1JzcBDBJRIpCiRDbWRHZXRBZXRo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 10) = "ZXJEaXZpZGVDaGFsbGVuZ2VJbmZvU2NSc3AQySUSJgohQ21kQWV0aGVyRGl2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 11) = "aWRlU3Bpcml0SW5mb1NjTm90aWZ5EMglEiQKH0NtZEFldGhlckRpdmlkZVNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 12) = "aXJpdEV4cFVwU2NSc3AQ2iUSKQokQ21kR2V0QWV0aGVyRGl2aWRlQ2hhbGxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 13) = "bmdlSW5mb0NzUmVxEOElEiIKHUNtZFNldEFldGhlckRpdmlkZUxpbmVVcENz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 14) = "UmVxENIlEikKJENtZFN3aXRjaEFldGhlckRpdmlkZUxpbmVVcFNsb3RDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 15) = "cRDfJRIsCidDbWRBZXRoZXJEaXZpZGVUYWtlQ2hhbGxlbmdlUmV3YXJkQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 16) = "ZXEQ7iUSLQooQ21kU3RhcnRBZXRoZXJEaXZpZGVDaGFsbGVuZ2VCYXR0bGVD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 17) = "c1JlcRDFJRIgChtDbWRHZXRBZXRoZXJEaXZpZGVJbmZvQ3NSZXEQwiUSJQog";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 18) = "Q21kQWV0aGVyRGl2aWRlU2tpbGxJdGVtU2NOb3RpZnkQ8CUSIgodQ21kU2V0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 19) = "QWV0aGVyRGl2aWRlTGluZVVwU2NSc3AQ7SUSIgodQ21kQWV0aGVyRGl2aWRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 20) = "TGluZXVwU2NOb3RpZnkQ6yUSKgolQ21kQWV0aGVyRGl2aWRlUmVmcmVzaEVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 21) = "ZGxlc3NTY05vdGlmeRDWJRIpCiRDbWRTdGFydEFldGhlckRpdmlkZVNjZW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 22) = "QmF0dGxlU2NSc3AQ5iUSEwoOQ21kSUFLQkxPTUpFTEoQxyUSGwoWQ21kRXF1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 23) = "aXBTa2lsbENvcmVTY1JzcBDDJRIjCh5DbWRMZWF2ZUFldGhlckRpdmlkZVNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 24) = "ZW5lQ3NSZXEQ3iUSIAobQ21kR2V0QWV0aGVyRGl2aWRlSW5mb1NjUnNwEOwl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 25) = "EisKJkNtZEFldGhlckRpdmlkZUZpbmlzaENoYWxsZW5nZVNjTm90aWZ5EMQl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 26) = "EicKIkNtZEFldGhlckRpdmlkZVJlZnJlc2hFbmRsZXNzQ3NSZXEQ5yUSKQok";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 27) = "Q21kU3RhcnRBZXRoZXJEaXZpZGVTdGFnZUJhdHRsZUNzUmVxEPElEikKJENt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 28) = "ZFN0YXJ0QWV0aGVyRGl2aWRlU2NlbmVCYXR0bGVDc1JlcRDjJRIkCh9DbWRB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 29) = "ZXRoZXJEaXZpZGVTcGlyaXRFeHBVcENzUmVxEMYlEioKJUNtZEVxdWlwQWV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 30) = "aGVyRGl2aWRlUGFzc2l2ZVNraWxsQ3NSZXEQ5CUSHAoXRklCR05CS0dITkZf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 31) = "TE1FT0VLREFNQU0QzSVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray33<string>, string>(ref buffer, 32) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray33<string>, string>(in buffer, 33))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdAetherDivideType) }, null, null));
	}
}
