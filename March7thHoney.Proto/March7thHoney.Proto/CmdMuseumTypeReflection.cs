using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMuseumTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMuseumTypeReflection()
	{
		_003C_003Ey__InlineArray24<string> buffer = default(_003C_003Ey__InlineArray24<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 0) = "ChNDbWRNdXNldW1UeXBlLnByb3RvKtgHCg1DbWRNdXNldW1UeXBlEhsKF09E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 1) = "T09ER0hBSUpOX1BDUERIRUxQS0VNEAASGwoWQ21kU2V0U3R1ZmZUb0FyZWFD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 2) = "c1JlcRDaIRIcChdDbWRVcGdyYWRlQXJlYVN0YXRDc1JlcRDQIRITCg5DbWRJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 3) = "QkZDSkJDS0VOSRCwIhIaChVDbWRGaW5pc2hDdXJUdXJuQ3NSZXEQ8yESJAof";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 4) = "Q21kTXVzZXVtUmFuZG9tRXZlbnRTZWxlY3RDc1JlcRCGIhIjCh5DbWRTeW5j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 5) = "TXVzZXVtVGFyZ2V0U3RhcnROb3RpZnkQpSISGwoWQ21kU2V0U3R1ZmZUb0Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 6) = "ZWFTY1JzcBDeIRIqCiVDbWRTeW5jTXVzZXVtUmFuZG9tRXZlbnRTdGFydFNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 7) = "Tm90aWZ5EO0hEhwKF0NtZFRha2VDb2xsZWN0UmV3YXJkUnNwEOghEhoKFUNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 8) = "ZEdldE11c2V1bUluZm9Dc1JlcRCnIhIYChNDbWRCdXlOcGNTdHVmZlNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 9) = "EKsiEh4KGUNtZFRha2VDb2xsZWN0UmV3YXJkQ3NSZXEQ4SESJAofQ21kTXVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 10) = "ZXVtUmFuZG9tRXZlbnRTZWxlY3RTY1JzcBD4IRImCiFDbWRTeW5jTXVzZXVt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 11) = "RnVuZHNDaGFuZ2VkU2NOb3RpZnkQ7CESIwoeQ21kTXVzZXVtUmFuZG9tRXZl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 12) = "bnRRdWVyeUNzUmVxEIkiEhoKFUNtZEZpbmlzaEN1clR1cm5TY1JzcBDNIRIe";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 13) = "ChlDbWRTeW5jR2V0RXhoaWJpdFNjTm90aWZ5EOYhEhoKFUNtZEdldE11c2V1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 14) = "bUluZm9TY1JzcBDWIRIYChNDbWRVcGdyYWRlQXJlYUNzUmVxEJYiEiQKH0Nt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 15) = "ZFN5bmNNdXNldW1UYXJnZXRSZXdhcmROb3RpZnkQhSISGAoTQ21kQnV5TnBj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 16) = "U3R1ZmZDc1JlcRCqIhIcChdDbWRVcGdyYWRlQXJlYVN0YXRTY1JzcBDyIRIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 17) = "ChtDbWRSZW1vdmVTdHVmZkZyb21BcmVhU2NSc3AQriISIAobQ21kUmVtb3Zl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 18) = "U3R1ZmZGcm9tQXJlYUNzUmVxENUhEiMKHkNtZE11c2V1bVJhbmRvbUV2ZW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 19) = "UXVlcnlTY1JzcBDTIRIlCiBDbWRTeW5jTXVzZXVtSW5mb0NoYW5nZWRTY05v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 20) = "dGlmeRCUIhIYChNDbWRVcGdyYWRlQXJlYVNjUnNwEPEhEisKJkNtZFN5bmNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 21) = "dXNldW1UYXJnZXRNaXNzaW9uRmluaXNoTm90aWZ5EKwiEhwKF0NtZFN5bmNH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 22) = "ZXRTdHVmZlNjTm90aWZ5EIsiQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 23) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray24<string>, string>(in buffer, 24))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMuseumType) }, null, null));
	}
}
