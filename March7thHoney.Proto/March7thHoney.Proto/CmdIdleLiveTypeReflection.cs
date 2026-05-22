using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdIdleLiveTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdIdleLiveTypeReflection()
	{
		_003C_003Ey__InlineArray42<string> buffer = default(_003C_003Ey__InlineArray42<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 0) = "ChVDbWRJZGxlTGl2ZVR5cGUucHJvdG8qlQ4KD0NtZElkbGVMaXZlVHlwZRIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 1) = "ChdJTkpKTEFBSkdERV9QQ1BESEVMUEtFTRAAEigKI0NtZElkbGVMaXZlVXBk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 2) = "YXRlTGl2ZVJvb21UaXRsZUNzUmVxEKNJEhgKE0NtZFJlcGxhY2VUZWFtQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 3) = "c3AQrEkSJAofQ21kSWRsZUxpdmVHZXRQZW5kaW5nRXF1aXBDc1JlcRCnSRIc";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 4) = "ChdDbWRJZGxlTGl2ZUdldERhdGFDc1JlcRDhSRITCg5DbWRHSkJJTkVFQUJJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 5) = "UBCgSRIoCiNDbWRJZGxlTGl2ZUdldEZyaWVuZEFzc2lzdExpc3RDc1JlcRCk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 6) = "SRIpCiRDbWRJZGxlTGl2ZUZpbmlzaE5vZGVCYXR0bGVRdWl0Q3NSZXEQj0kS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 7) = "IwoeQ21kSWRsZUxpdmVUYWtlVGFza1Jld2FyZENzUmVxEMdJEhMKDkNtZEFQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 8) = "S1BHSU9MTE5QEMBJEhMKDkNtZE5NQkdMS0FMTEJNEOhJEiUKIENtZElkbGVM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 9) = "aXZlVGFrZUFzc2lzdFJld2FyZFNjUnNwEIlJEh8KGkNtZEhhbmRsZVBlbmRp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 10) = "bmdFcXVpcFNjUnNwEOZJEigKI0NtZEdldEZyaWVuZE5ld0Fzc2lzdFJld2Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 11) = "ZFNjTm90aWZ5EOJJEiUKIENtZElkbGVMaXZlSGFuZGxlUGVuZGluZ0VxdWlw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 12) = "UmVxEN9JEikKJENtZElkbGVMaXZlTWFudWFsRmluaXNoUXVlc3Rpb25Dc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 13) = "cRDTSRIfChpDbWRJZGxlTGl2ZUVuZER1bmdlb25Dc1JlcRC3SRIlCiBDbWRJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 14) = "ZGxlTGl2ZVRha2VBc3Npc3RSZXdhcmRDc1JlcRCqSRIeChlDbWRJZGxlTGl2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 15) = "ZVN0YXJ0Tm9kZUNzUmVxEORJEhsKFkNtZFRha2VUYXNrUmV3YXJkU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 16) = "z0kSHAoXQ21kVXBncmFkZVRlYW1TbG90Q3NSc3AQwUkSIQocQ21kSWRsZUxp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 17) = "dmVHZXRTdGF0aXN0aWNDc1JlcRC/SRIdChhDbWRVcGRhdGVDdXN0b21JbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 18) = "U2NSc3AQkkkSEwoOQ21kTkZQRURCT09GRkYQ5UkSJgohQ21kSWRsZUxpdmVU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 19) = "YWtlQ29udGVudFJld2FyZENzUmVxENVJEiQKH0NtZElkbGVMaXZlU3RhcnRO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 20) = "b2RlQmF0dGxlQ3NSZXEQlEkSIAobQ21kSWRsZUxpdmVSZXBsYWNlVGVhbUNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 21) = "UmVxEIpJEhgKE0NtZFRha2VDb250ZW50U2NSc3AQmkkSFwoSQ21kRW5kRHVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 22) = "Z2VvblNjUnNwEMhJEiYKIUNtZElkbGVMaXZlRHJlc3NTcGVjaWFsRXF1aXBD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 23) = "c1JlcRCySRITCg5DbWRMQ0ZHRkdGRExPRhCHSRIiCh1DbWRJZGxlTGl2ZUNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 24) = "bGxlY3RJbmNvbWVDc1JlcRDOSRIpCiRDbWRHZXRGcmllbmREdW5nZW9uUmFu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 25) = "a2luZ0luZm9zU2NSc3AQkUkSGQoUQ21kU3RhcnREdW5nZW9uU2NSc3AQiEkS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 26) = "JAofQ21kVGVjaFRyZWVDaGFuZ2VOb2RlU3RhdGVDc1JzcBCOSRIcChdDbWRJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 27) = "ZGxlTGl2ZU9wZW5DaGVzdFJlcRCNSRIZChRDbWRGaW5pc2hRdWVzdGlvblJz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 28) = "cBCWSRIjCh5DbWRJZGxlTGl2ZVRha2VRdWVzdEVxdWlwQ3NSZXEQnkkSHAoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 29) = "Q21kSWRsZUxpdmVEb0dhY2hhQ3NSZXEQl0kSFQoQQ21kRG9HYWNoYVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 30) = "MhC5SRIcChdDbWRTdGFydE5vZGVCYXR0bGVTY1JzcBCYSRIVChBDbWRTeW5j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 31) = "Q2hhbmdlTnRmEKJJEiMKHkNtZElkbGVMaXZlRmluaXNoRmluYWxBY3RDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 32) = "cRCtSRIxCixDbWRJZGxlTGl2ZUdldEZyaWVuZER1bmdlb25SYW5raW5nSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 33) = "b3NDc1JlcRCLSRIoCiNDbWRJZGxlTGl2ZUdldEZyaWVuZEFzc2lzdExpc3RT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 34) = "Y1JzcBDNSRInCiJDbWRJZGxlTGl2ZUNoYW5nZVRlY2hUcmVlTm9kZUNzUmVx";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 35) = "ELtJEiAKG0NtZElkbGVMaXZlVXBncmFkZVNsb3RDc1JlcRCwSRIkCh9DbWRJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 36) = "ZGxlTGl2ZUZpbmlzaE5vZGVFdmVudENzUmVxEMVJEhMKDkNtZEhCQ01CUEtH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 37) = "QkpLEKZJEhsKFkNtZFRha2VRdWVzdEVxdWlwQ3NSc3AQ1EkSEwoOQ21kR1BL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 38) = "Q0VES0hMQUQQm0kSEwoOQ21kSkZLTUZHTE9QT0YQw0kSIQocQ21kSWRsZUxp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 39) = "dmVTdGFydER1bmdlb25Dc1JlcRDjSRIcChdDbWRJZGxlTGl2ZUdldERhdGFT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 40) = "Y1JzcBCQSRIeChlDbWREcmVzc1NwZWNpYWxFcXVpcFNjUnNwEOpJQhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 41) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray42<string>, string>(in buffer, 42))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdIdleLiveType) }, null, null));
	}
}
