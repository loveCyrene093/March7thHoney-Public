using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdAvatarTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdAvatarTypeReflection()
	{
		_003C_003Ey__InlineArray36<string> buffer = default(_003C_003Ey__InlineArray36<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 0) = "ChNDbWRBdmF0YXJUeXBlLnByb3RvKoEMCg1DbWRBdmF0YXJUeXBlEhsKF09L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 1) = "R0xIS09FSk1NX1BDUERIRUxQS0VNEAASIwoeQ21kR2V0UHJlQXZhdGFyR3Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 2) = "d3RoSW5mb0NzUmVxELQCEhkKFENtZFRha2VPZmZSZWxpY0NzUmVxEMwCEhoK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 3) = "FUNtZEdldEF2YXRhckRhdGFTY1JzcBC2AhIiCh1DbWRBZGRNdWx0aVBhdGhB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 4) = "dmF0YXJTY05vdGlmeRDIAhIgChtDbWRUYWtlUHJvbW90aW9uUmV3YXJkQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 5) = "ZXEQ6QISJQogQ21kR2V0UHJlQXZhdGFyQWN0aXZpdHlMaXN0Q3NSZXEQwAIS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 6) = "GgoVQ21kQWN0aXZlRWlkb2xvblNjUnNwELACEhwKF0NtZFVubG9ja1NraWxs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 7) = "VHJlZUNzUmVxELoCEhgKE0NtZEF2YXRhckV4cFVwQ3NSZXEQigMSGgoVQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 8) = "R2V0QXZhdGFyRGF0YUNzUmVxEIcDEh0KGENtZFVubG9ja0F2YXRhclBhdGhT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 9) = "Y1JzcBDzAhIiCh1DbWRTZXRHcm93dGhUYXJnZXRBdmF0YXJDc1JlcRDtAhIY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 10) = "ChNDbWREcmVzc0F2YXRhckNzUmVxEOsCEh0KGENtZFRha2VPZmZFcXVpcG1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 11) = "bnRDc1JlcRDTAhIZChRDbWRBZGRBdmF0YXJTY05vdGlmeRD2AhIcChdDbWRV";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 12) = "bmxvY2tTa2lsbHRyZWVTY1JzcBC+AhIaChVDbWRTZXRBdmF0YXJQYXRoU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 13) = "c3AQsQISHwoaQ21kQXZhdGFyUGF0aENoYW5nZWROb3RpZnkQtwISJQogQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 14) = "R2V0UHJlQXZhdGFyQWN0aXZpdHlMaXN0U2NSc3AQiQMSHAoXQ21kRHJlc3NB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 15) = "dmF0YXJTa2luQ3NSZXEQ5gISFwoSQ21kTWFya0F2YXRhclNjUnNwEMECEiMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 16) = "HkNtZFNldE11bHRpcGxlQXZhdGFyUGF0aHNTY1JzcBCvAhIdChhDbWRVbmxv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 17) = "Y2tBdmF0YXJQYXRoQ3NSZXEQygISHQoYQ21kVGFrZU9mZkVxdWlwbWVudFNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 18) = "UnNwEK0CEhoKFUNtZFNldEF2YXRhclBhdGhDc1JlcRDuAhIeChlDbWRUYWtl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 19) = "T2ZmQXZhdGFyU2tpbkNzUmVxEJADEiMKHkNtZEdldFByZUF2YXRhckdyb3d0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 20) = "aEluZm9TY1JzcBC9AhITCg5DbWRBSkxDQUpFS0FHUBDhAhIdChhDbWREcmVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 21) = "c1JlbGljQXZhdGFyQ3NSZXEQ0gISGQoUQ21kVGFrZU9mZlJlbGljU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 22) = "zQISGAoTQ21kQXZhdGFyRXhwVXBTY1JzcBCLAxIaChVDbWRQcm9tb3RlQXZh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 23) = "dGFyU2NSc3AQjgMSGgoVQ21kQWN0aXZlRWlkb2xvbkNzUmVxENECEh4KGUNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 24) = "ZFRha2VPZmZBdmF0YXJTa2luU2NSc3AQhQMSIAobQ21kVGFrZVByb21vdGlv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 25) = "blJld2FyZFNjUnNwELMCEiwKJ0NtZEF2YXRhclNwZWNpYWxTa2lsbHRyZWVV";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 26) = "bmxvY2tTY05vdGlmeRCIAxIXChJDbWRNYXJrQXZhdGFyQ3NSZXEQ5QISIgod";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 27) = "Q21kU2V0R3Jvd3RoVGFyZ2V0QXZhdGFyU2NSc3AQ9QISIAobQ21kU2V0QXZh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 28) = "dGFyRW5oYW5jZWRJZFNjUnNwEPsCEhwKF0NtZFNldFBsYXllck91dGZpdENz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 29) = "UmVxEK4CEhwKF0NtZFNldFBsYXllck91dGZpdFNjUnNwEN0CEiAKG0NtZFNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 30) = "dEF2YXRhckVuaGFuY2VkSWRDc1JlcRDiAhIYChNDbWREcmVzc0F2YXRhclNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 31) = "UnNwEMYCEh0KGENtZERyZXNzUmVsaWNBdmF0YXJTY1JzcBD0AhIcChdDbWRE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 32) = "cmVzc0F2YXRhclNraW5TY1JzcBDYAhIgChtDbWRVbmxvY2tBdmF0YXJTa2lu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 33) = "U2NOb3RpZnkQjAMSGgoVQ21kUHJvbW90ZUF2YXRhckNzUmVxELUCEiMKHkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 34) = "ZFNldE11bHRpcGxlQXZhdGFyUGF0aHNDc1JlcRDQAkIWqgITTWFyY2g3dGhI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray36<string>, string>(ref buffer, 35) = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray36<string>, string>(in buffer, 36))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdAvatarType) }, null, null));
	}
}
