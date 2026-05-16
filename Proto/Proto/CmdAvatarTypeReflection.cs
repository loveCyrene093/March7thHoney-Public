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
		buffer[0] = "ChNDbWRBdmF0YXJUeXBlLnByb3RvKoEMCg1DbWRBdmF0YXJUeXBlEhsKF09L";
		buffer[1] = "R0xIS09FSk1NX1BDUERIRUxQS0VNEAASIwoeQ21kR2V0UHJlQXZhdGFyR3Jv";
		buffer[2] = "d3RoSW5mb0NzUmVxELQCEhkKFENtZFRha2VPZmZSZWxpY0NzUmVxEMwCEhoK";
		buffer[3] = "FUNtZEdldEF2YXRhckRhdGFTY1JzcBC2AhIiCh1DbWRBZGRNdWx0aVBhdGhB";
		buffer[4] = "dmF0YXJTY05vdGlmeRDIAhIgChtDbWRUYWtlUHJvbW90aW9uUmV3YXJkQ3NS";
		buffer[5] = "ZXEQ6QISJQogQ21kR2V0UHJlQXZhdGFyQWN0aXZpdHlMaXN0Q3NSZXEQwAIS";
		buffer[6] = "GgoVQ21kQWN0aXZlRWlkb2xvblNjUnNwELACEhwKF0NtZFVubG9ja1NraWxs";
		buffer[7] = "VHJlZUNzUmVxELoCEhgKE0NtZEF2YXRhckV4cFVwQ3NSZXEQigMSGgoVQ21k";
		buffer[8] = "R2V0QXZhdGFyRGF0YUNzUmVxEIcDEh0KGENtZFVubG9ja0F2YXRhclBhdGhT";
		buffer[9] = "Y1JzcBDzAhIiCh1DbWRTZXRHcm93dGhUYXJnZXRBdmF0YXJDc1JlcRDtAhIY";
		buffer[10] = "ChNDbWREcmVzc0F2YXRhckNzUmVxEOsCEh0KGENtZFRha2VPZmZFcXVpcG1l";
		buffer[11] = "bnRDc1JlcRDTAhIZChRDbWRBZGRBdmF0YXJTY05vdGlmeRD2AhIcChdDbWRV";
		buffer[12] = "bmxvY2tTa2lsbHRyZWVTY1JzcBC+AhIaChVDbWRTZXRBdmF0YXJQYXRoU2NS";
		buffer[13] = "c3AQsQISHwoaQ21kQXZhdGFyUGF0aENoYW5nZWROb3RpZnkQtwISJQogQ21k";
		buffer[14] = "R2V0UHJlQXZhdGFyQWN0aXZpdHlMaXN0U2NSc3AQiQMSHAoXQ21kRHJlc3NB";
		buffer[15] = "dmF0YXJTa2luQ3NSZXEQ5gISFwoSQ21kTWFya0F2YXRhclNjUnNwEMECEiMK";
		buffer[16] = "HkNtZFNldE11bHRpcGxlQXZhdGFyUGF0aHNTY1JzcBCvAhIdChhDbWRVbmxv";
		buffer[17] = "Y2tBdmF0YXJQYXRoQ3NSZXEQygISHQoYQ21kVGFrZU9mZkVxdWlwbWVudFNj";
		buffer[18] = "UnNwEK0CEhoKFUNtZFNldEF2YXRhclBhdGhDc1JlcRDuAhIeChlDbWRUYWtl";
		buffer[19] = "T2ZmQXZhdGFyU2tpbkNzUmVxEJADEiMKHkNtZEdldFByZUF2YXRhckdyb3d0";
		buffer[20] = "aEluZm9TY1JzcBC9AhITCg5DbWRBSkxDQUpFS0FHUBDhAhIdChhDbWREcmVz";
		buffer[21] = "c1JlbGljQXZhdGFyQ3NSZXEQ0gISGQoUQ21kVGFrZU9mZlJlbGljU2NSc3AQ";
		buffer[22] = "zQISGAoTQ21kQXZhdGFyRXhwVXBTY1JzcBCLAxIaChVDbWRQcm9tb3RlQXZh";
		buffer[23] = "dGFyU2NSc3AQjgMSGgoVQ21kQWN0aXZlRWlkb2xvbkNzUmVxENECEh4KGUNt";
		buffer[24] = "ZFRha2VPZmZBdmF0YXJTa2luU2NSc3AQhQMSIAobQ21kVGFrZVByb21vdGlv";
		buffer[25] = "blJld2FyZFNjUnNwELMCEiwKJ0NtZEF2YXRhclNwZWNpYWxTa2lsbHRyZWVV";
		buffer[26] = "bmxvY2tTY05vdGlmeRCIAxIXChJDbWRNYXJrQXZhdGFyQ3NSZXEQ5QISIgod";
		buffer[27] = "Q21kU2V0R3Jvd3RoVGFyZ2V0QXZhdGFyU2NSc3AQ9QISIAobQ21kU2V0QXZh";
		buffer[28] = "dGFyRW5oYW5jZWRJZFNjUnNwEPsCEhwKF0NtZFNldFBsYXllck91dGZpdENz";
		buffer[29] = "UmVxEK4CEhwKF0NtZFNldFBsYXllck91dGZpdFNjUnNwEN0CEiAKG0NtZFNl";
		buffer[30] = "dEF2YXRhckVuaGFuY2VkSWRDc1JlcRDiAhIYChNDbWREcmVzc0F2YXRhclNj";
		buffer[31] = "UnNwEMYCEh0KGENtZERyZXNzUmVsaWNBdmF0YXJTY1JzcBD0AhIcChdDbWRE";
		buffer[32] = "cmVzc0F2YXRhclNraW5TY1JzcBDYAhIgChtDbWRVbmxvY2tBdmF0YXJTa2lu";
		buffer[33] = "U2NOb3RpZnkQjAMSGgoVQ21kUHJvbW90ZUF2YXRhckNzUmVxELUCEiMKHkNt";
		buffer[34] = "ZFNldE11bHRpcGxlQXZhdGFyUGF0aHNDc1JlcRDQAkIWqgITTWFyY2g3dGhI";
		buffer[35] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdAvatarType) }, null, null));
	}
}
