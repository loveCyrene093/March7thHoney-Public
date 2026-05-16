using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdActivityTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdActivityTypeReflection()
	{
		_003C_003Ey__InlineArray27<string> buffer = default(_003C_003Ey__InlineArray27<string>);
		buffer[0] = "ChVDbWRBY3Rpdml0eVR5cGUucHJvdG8q3wgKD0NtZEFjdGl2aXR5VHlwZRIb";
		buffer[1] = "ChdGUExFSEZPQUVLRl9QQ1BESEVMUEtFTRAAEhMKDkNtZEdJTkRLSkdMUEpN";
		buffer[2] = "EIAVEi0KKENtZFRha2VNYXRlcmlhbFN1Ym1pdEFjdGl2aXR5UmV3YXJkU2NS";
		buffer[3] = "c3AQ4hQSHQoYQ21kR2V0TG9naW5BY3Rpdml0eVNjUnNwELIUEioKJUNtZEdl";
		buffer[4] = "dE1hdGVyaWFsU3VibWl0QWN0aXZpdHlEYXRhQ3NSZXEQ8BQSKgolQ21kR2V0";
		buffer[5] = "TWF0ZXJpYWxTdWJtaXRBY3Rpdml0eURhdGFTY1JzcBDIFBIkCh9DbWRUYWtl";
		buffer[6] = "VHJpYWxBY3Rpdml0eVJld2FyZENzUmVxEMUUEh0KGENtZEdldExvZ2luQWN0";
		buffer[7] = "aXZpdHlDc1JlcRCDFRImCiFDbWRHZXRBY3Rpdml0eVNjaGVkdWxlQ29uZmln";
		buffer[8] = "Q3NSZXEQthQSMQosQ21kU3VibWl0TWF0ZXJpYWxTdWJtaXRBY3Rpdml0eU1h";
		buffer[9] = "dGVyaWFsQ3NSZXEQyRQSIQocQ21kR2V0VHJpYWxBY3Rpdml0eURhdGFDc1Jl";
		buffer[10] = "cRCEFRIbChZDbWRUcmlhbEFjdGl2aXR5Tm90aWZ5ENwUEiQKH0NtZFRha2VM";
		buffer[11] = "b2dpbkFjdGl2aXR5UmV3YXJkQ3NSZXEQhhUSGgoVQ21kU3RhcnRUcmlhbEFj";
		buffer[12] = "dGl2aXR5ELgUEiAKG0NtZEdldEF2YXRhclJld2FyZERhdGFTY1JzcBDtFBIk";
		buffer[13] = "Ch9DbWRUYWtlTG9naW5BY3Rpdml0eVJld2FyZFNjUnNwEIcVEiAKG0NtZEdl";
		buffer[14] = "dEF2YXRhclJld2FyZERhdGFDc1JlcRCCFRIZChRDbWRDaG9vc2VBdmF0YXJD";
		buffer[15] = "c1JlcRDRFBIkCh9DbWRFbnRlclRyaWFsQWN0aXZpdHlTdGFnZVNjUnNwEOMU";
		buffer[16] = "EjEKLENtZFN1Ym1pdE1hdGVyaWFsU3VibWl0QWN0aXZpdHlNYXRlcmlhbFNj";
		buffer[17] = "UnNwEOUUEh8KGkNtZFN0YXJ0VHJpYWxBY3Rpdml0eUNzUmVxEPUUEhcKEkNt";
		buffer[18] = "ZFRha2VSZXdhcmRDc1JlcRDuFBIcChdGUExFSEZPQUVLRl9CTU5DREFKRExQ";
		buffer[19] = "QRDSFBIfChpDbWRMZWF2ZVRyaWFsQWN0aXZpdHlDc1JlcRCuFBIZChRDbWRD";
		buffer[20] = "aG9vc2VBdmF0YXJTY1JzcBDmFBInCiJDbWRUcmlhbEFjdGl2aXR5RGF0YUNo";
		buffer[21] = "YW5nZVNjTm90aWZ5EPYUEiEKHENtZEdldFRyaWFsQWN0aXZpdHlEYXRhU2NS";
		buffer[22] = "c3AQwBQSJAofQ21kVGFrZVRyaWFsQWN0aXZpdHlSZXdhcmRTY1JzcBC0FBIm";
		buffer[23] = "CiFDbWRHZXRBY3Rpdml0eVNjaGVkdWxlQ29uZmlnU2NSc3AQuhQSFwoSQ21k";
		buffer[24] = "VGFrZVJld2FyZFNjUnNwEOwUEi0KKENtZFRha2VNYXRlcmlhbFN1Ym1pdEFj";
		buffer[25] = "dGl2aXR5UmV3YXJkQ3NSZXEQrxRCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[26] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdActivityType) }, null, null));
	}
}
