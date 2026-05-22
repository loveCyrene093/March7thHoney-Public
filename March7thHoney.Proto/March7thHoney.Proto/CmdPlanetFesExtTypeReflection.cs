using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPlanetFesExtTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPlanetFesExtTypeReflection()
	{
		_003C_003Ey__InlineArray20<string> buffer = default(_003C_003Ey__InlineArray20<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 0) = "ChlDbWRQbGFuZXRGZXNFeHRUeXBlLnByb3RvKqUGChNDbWRQbGFuZXRGZXNF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 1) = "eHRUeXBlEhsKF0FJQU1KQkVITU1DX1BDUERIRUxQS0VNEAASKwomQ21kUGxh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 2) = "bmV0RmVzR2V0RXh0cmFDYXJkUGllY2VJbmZvQ3NSZXEQ70ASKwomQ21kUGxh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 3) = "bmV0RmVzR2V0RXh0cmFDYXJkUGllY2VJbmZvU2NSc3AQ6UASJAofQ21kUGxh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 4) = "bmV0RmVzQXBwbHlDYXJkUGllY2VTY1JzcBDjQBIjCh5DbWRQbGFuZXRGZXNH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 5) = "aXZlQ2FyZFBpZWNlU2NSc3AQj0ESKgolQ21kUGxhbmV0RmVzSGFuZGxlQ2Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 6) = "ZFBpZWNlQXBwbHlDc1JlcRCRQRIoCiNDbWRQbGFuZXRGZXNMYXJnZUJvbnVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 7) = "SW50ZXJhY3RTY1JzcBDlQBIkCh9DbWRQbGFuZXRGZXNBcHBseUNhcmRQaWVj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 8) = "ZUNzUmVxEOdAEjQKL0NtZFBsYW5ldEZlc0NoYW5nZUNhcmRQaWVjZUFwcGx5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 9) = "UGVybWlzc2lvbkNzUmVxEIVBEikKJENtZFBsYW5ldEZlc0dldE9mZmVyZWRD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 10) = "YXJkUGllY2VTY1JzcBCOQRIpCiRDbWRQbGFuZXRGZXNHZXRPZmZlcmVkQ2Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 11) = "ZFBpZWNlQ3NSZXEQ5EASKAojQ21kUGxhbmV0RmVzR2V0RnJpZW5kQ2FyZFBp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 12) = "ZWNlU2NSc3AQ/UASEwoOQ21kSENKS0VESlBHSEIQ8kASKgolQ21kUGxhbmV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 13) = "RmVzRW50ZXJOZXh0QnVzaW5lc3NEYXlDc1JlcRCUQRIoCiNDbWRQbGFuZXRG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 14) = "ZXNHZXRGcmllbmRDYXJkUGllY2VDc1JlcRCAQRI0Ci9DbWRQbGFuZXRGZXND";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 15) = "aGFuZ2VDYXJkUGllY2VBcHBseVBlcm1pc3Npb25TY1JzcBCIQRIjCh5DbWRQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 16) = "bGFuZXRGZXNHaXZlQ2FyZFBpZWNlQ3NSZXEQ9EASKAojQ21kUGxhbmV0RmVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 17) = "TGFyZ2VCb251c0ludGVyYWN0Q3NSZXEQhkESKgolQ21kUGxhbmV0RmVzSGFu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 18) = "ZGxlQ2FyZFBpZWNlQXBwbHlTY1JzcBD1QEIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray20<string>, string>(ref buffer, 19) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray20<string>, string>(in buffer, 20))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPlanetFesExtType) }, null, null));
	}
}
