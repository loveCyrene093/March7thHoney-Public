using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFiveDimTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFiveDimTypeReflection()
	{
		InlineArray15<string> buffer = default(InlineArray15<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 0) = "ChRDbWRGaXZlRGltVHlwZS5wcm90byrYBAoOQ21kRml2ZURpbVR5cGUSGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 1) = "TUtMUEdCRkVKTU9fUENQREhFTFBLRU0QABIcChdDbWRHZXRGaXZlRGltTW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 2) = "ZXlTY1JzcBDVERIdChhDbWRMZWF2ZUZpdmVEaW1HYW1lU2NSc3AQ0hESHAoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 3) = "TUtMUEdCRkVKTU9fREZJTExGTkxMQUoQzRESJwoiQ21kRml2ZURpbUp1bXBF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 4) = "bmVyZ3lDaGFuZ2VTY05vdGlmeRDZERIiCh1DbWRVcGRhdGVGaXZlRGltR2Ft";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 5) = "ZURhdGFTY1JzcBDTERIcChdNS0xQR0JGRUpNT19MS0xPQkRKSU5PSRDRERIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 6) = "ChtDbWRGaXZlRGltR2FtZVRyYW5zZmVyU2NSc3AQ3hESHAoXTUtMUEdCRkVK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 7) = "TU9fQ0pNREJGT0pQSUMQyxESHAoXTUtMUEdCRkVKTU9fSEtHSEJBSElPTUMQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 8) = "zBESHAoXTUtMUEdCRkVKTU9fRkZCSE5GUEtMTUQQ3RESIgodQ21kRml2ZURp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 9) = "bU1vbmV5Q2hhbmdlU2NOb3RpZnkQ4BESHQoYQ21kRW50ZXJGaXZlRGltR2Ft";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 10) = "ZVNjUnNwENgREhwKF01LTFBHQkZFSk1PX09CT0JCREdIQ0ROENwREiUKIENt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 11) = "ZEZpdmVEaW1HYW1lRGF0YVVwZGF0ZVNjTm90aWZ5EOMREh8KGkNtZEdldEZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 12) = "dmVEaW1HYW1lRGF0YVNjUnNwEM4REhwKF01LTFBHQkZFSk1PX0lJRENNUE5N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 13) = "Q0hNENQREiAKG0NtZEdldEZpdmVEaW1Nb25leURhdGFTY1JzcBDiEUIWqgIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 14) = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray15<string>, string>(in buffer, 15))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFiveDimType) }, null, null));
	}
}
