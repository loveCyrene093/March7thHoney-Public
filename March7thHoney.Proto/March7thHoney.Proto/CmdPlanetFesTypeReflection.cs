using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPlanetFesTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPlanetFesTypeReflection()
	{
		_003C_003Ey__InlineArray44<string> buffer = default(_003C_003Ey__InlineArray44<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 0) = "ChZDbWRQbGFuZXRGZXNUeXBlLnByb3RvKoEPChBDbWRQbGFuZXRGZXNUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 1) = "EhsKF0ZGQkdBQkNHRERMX1BDUERIRUxQS0VNEAASLgopQ21kUGxhbmV0RmVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 2) = "R2V0RnJpZW5kUmFua2luZ0luZm9MaXN0Q3NSZXEQlEASEwoOQ21kQUZLQ0VP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 3) = "S0hHSEYQq0ASKAojQ21kUGxhbmV0RmVzR2V0QnVzaW5lc3NEYXlJbmZvQ3NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 4) = "ZXEQnUASKAojQ21kUGxhbmV0RmVzQm9udXNFdmVudEludGVyYWN0Q3NSZXEQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 5) = "n0ASHQoYQ21kUGxhbmV0RmVzQnV5TGFuZENzUmVxEIlAEi0KKENtZFBsYW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 6) = "dEZlc0J1c2luZXNzRGF5UmVmcmVzaEV2ZW50U2NSc3AQjkASKAojQ21kUGxh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 7) = "bmV0RmVzQm9udXNFdmVudEludGVyYWN0U2NSc3AQlkASIwoeQ21kUGxhbmV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 8) = "RmVzU3RhcnRNaW5pR2FtZVNjUnNwEJ5AEi0KKENtZFBsYW5ldEZlc0Nob29z";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 9) = "ZUF2YXRhckV2ZW50T3B0aW9uU2NSc3AQkUASJQogQ21kUGxhbmV0RmVzVGFr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 10) = "ZVF1ZXN0UmV3YXJkU2NSc3AQp0ASIwoeQ21kUGxhbmV0RmVzU2V0QXZhdGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 11) = "V29ya0NzUmVxEK5AEi8KKkNtZFBsYW5ldEZlc0RlYWxBdmF0YXJFdmVudE9w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 12) = "dGlvbkl0ZW1TY1JzcBCtQBInCiJDbWRQbGFuZXRGZXNTZXRDdXN0b21LZXlW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 13) = "YWx1ZUNzUmVxEJJAEiUKIENtZFBsYW5ldEZlc1VwZ3JhZGVGZXNMZXZlbENz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 14) = "UmVxELFAEisKJkNtZFBsYW5ldEZlc1Rha2VSZWdpb25QaGFzZVJld2FyZENz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 15) = "UmVxELNAEiMKHkNtZFBsYW5ldEZlc0dldEF2YXRhclN0YXRTY1JzcBCoQBIo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 16) = "CiNDbWRQbGFuZXRGZXNHZXRCdXNpbmVzc0RheUluZm9TY1JzcBC5QBIjCh5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 17) = "bWRQbGFuZXRGZXNDb2xsZWN0SW5jb21lQ3NSZXEQo0ASHQoYQ21kUGxhbmV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 18) = "RmVzRG9HYWNoYVNjUnNwEKxAEi0KKENtZFBsYW5ldEZlc0Nob29zZUF2YXRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 19) = "ckV2ZW50T3B0aW9uQ3NSZXEQqUASHQoYQ21kUGxhbmV0RmVzRG9HYWNoYUNz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 20) = "UmVxELVAEiUKIENtZFBsYW5ldEZlc0RlbGl2ZXJQYW1DYXJnb0NzUmVxEKJA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 21) = "Eh0KGENtZEdldFBsYW5ldEZlc0RhdGFTY1JzcBCPQBIvCipDbWRQbGFuZXRG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 22) = "ZXNEZWFsQXZhdGFyRXZlbnRPcHRpb25JdGVtQ3NSZXEQjEASEwoOQ21kRU1J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 23) = "RkZQSEJNRUkQskASKwomQ21kUGxhbmV0RmVzVGFrZVJlZ2lvblBoYXNlUmV3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 24) = "YXJkU2NSc3AQr0ASJQogQ21kUGxhbmV0RmVzRGVsaXZlclBhbUNhcmdvU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 25) = "c3AQkEASJwoiQ21kUGxhbmV0RmVzU2V0Q3VzdG9tS2V5VmFsdWVTY1JzcBCg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 26) = "QBIiCh1DbWRQbGFuZXRGZXNDbGllbnRTdGF0dXNDc1JlcRCbQBIuCilDbWRQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 27) = "bGFuZXRGZXNHZXRGcmllbmRSYW5raW5nSW5mb0xpc3RTY1JzcBCqQBIwCitD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 28) = "bWRQbGFuZXRGZXNGcmllbmRSYW5raW5nSW5mb0NoYW5nZVNjTm90aWZ5EKFA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 29) = "EiUKIENtZFBsYW5ldEZlc1Rha2VRdWVzdFJld2FyZENzUmVxEJhAEh0KGENt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 30) = "ZEdldFBsYW5ldEZlc0RhdGFDc1JlcRCVQBIjCh5DbWRQbGFuZXRGZXNTeW5j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 31) = "Q2hhbmdlU2NOb3RpZnkQpkASIgodQ21kUGxhbmV0RmVzU2tpbGxMZXZlbFVw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 32) = "U2NSc3AQpUASIwoeQ21kUGxhbmV0RmVzQXZhdGFyTGV2ZWxVcENzUmVxEItA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 33) = "EiYKIUNtZFBsYW5ldEZlc0NvbGxlY3RBbGxJbmNvbWVDc1JlcRC0QBITCg5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 34) = "bWRKT01CSENOSUVNUBCaQBIjCh5DbWRQbGFuZXRGZXNHZXRBdmF0YXJTdGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 35) = "Q3NSZXEQk0ASEwoOQ21kS0lKR0lPS09LUEYQt0ASJwoiQ21kUGxhbmV0RmVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 36) = "QmluZ29HYW1lRmxpcENhcmRDc1JlcRCZQBIjCh5DbWRQbGFuZXRGZXNTdGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 37) = "dE1pbmlHYW1lQ3NSZXEQnEASIwoeQ21kUGxhbmV0RmVzR2FtZUJpbmdvRmxp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 38) = "cFNjUnNwEKRAEhMKDkNtZE1ER09CSk9GT0RCEIpAEiMKHkNtZFBsYW5ldEZl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 39) = "c0F2YXRhckxldmVsVXBTY1JzcBC6QBIdChhDbWRQbGFuZXRGZXNVc2VJdGVt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 40) = "U2NSc3AQsEASEwoOQ21kTkRLTUdJQkNBSEYQjUASJwoiQ21kUGxhbmV0RmVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 41) = "VXBncmFkZVNraWxsTGV2ZWxDc1JlcRC4QBItCihDbWRQbGFuZXRGZXNCdXNp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 42) = "bmVzc0RheVJlZnJlc2hFdmVudENzUmVxEJdAEh0KGENtZFBsYW5ldEZlc1Vz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray44<string>, string>(ref buffer, 43) = "ZUl0ZW1Dc1JlcRC2QEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray44<string>, string>(in buffer, 44))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPlanetFesType) }, null, null));
	}
}
