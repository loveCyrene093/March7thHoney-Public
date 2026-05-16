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
		buffer[0] = "ChRDbWRGaXZlRGltVHlwZS5wcm90byrYBAoOQ21kRml2ZURpbVR5cGUSGwoX";
		buffer[1] = "TUtMUEdCRkVKTU9fUENQREhFTFBLRU0QABIcChdDbWRHZXRGaXZlRGltTW9u";
		buffer[2] = "ZXlTY1JzcBDVERIdChhDbWRMZWF2ZUZpdmVEaW1HYW1lU2NSc3AQ0hESHAoX";
		buffer[3] = "TUtMUEdCRkVKTU9fREZJTExGTkxMQUoQzRESJwoiQ21kRml2ZURpbUp1bXBF";
		buffer[4] = "bmVyZ3lDaGFuZ2VTY05vdGlmeRDZERIiCh1DbWRVcGRhdGVGaXZlRGltR2Ft";
		buffer[5] = "ZURhdGFTY1JzcBDTERIcChdNS0xQR0JGRUpNT19MS0xPQkRKSU5PSRDRERIg";
		buffer[6] = "ChtDbWRGaXZlRGltR2FtZVRyYW5zZmVyU2NSc3AQ3hESHAoXTUtMUEdCRkVK";
		buffer[7] = "TU9fQ0pNREJGT0pQSUMQyxESHAoXTUtMUEdCRkVKTU9fSEtHSEJBSElPTUMQ";
		buffer[8] = "zBESHAoXTUtMUEdCRkVKTU9fRkZCSE5GUEtMTUQQ3RESIgodQ21kRml2ZURp";
		buffer[9] = "bU1vbmV5Q2hhbmdlU2NOb3RpZnkQ4BESHQoYQ21kRW50ZXJGaXZlRGltR2Ft";
		buffer[10] = "ZVNjUnNwENgREhwKF01LTFBHQkZFSk1PX09CT0JCREdIQ0ROENwREiUKIENt";
		buffer[11] = "ZEZpdmVEaW1HYW1lRGF0YVVwZGF0ZVNjTm90aWZ5EOMREh8KGkNtZEdldEZp";
		buffer[12] = "dmVEaW1HYW1lRGF0YVNjUnNwEM4REhwKF01LTFBHQkZFSk1PX0lJRENNUE5N";
		buffer[13] = "Q0hNENQREiAKG0NtZEdldEZpdmVEaW1Nb25leURhdGFTY1JzcBDiEUIWqgIT";
		buffer[14] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFiveDimType) }, null, null));
	}
}
