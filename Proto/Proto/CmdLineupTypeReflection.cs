using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdLineupTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdLineupTypeReflection()
	{
		_003C_003Ey__InlineArray20<string> buffer = default(_003C_003Ey__InlineArray20<string>);
		buffer[0] = "ChNDbWRMaW5ldXBUeXBlLnByb3RvKrMGCg1DbWRMaW5ldXBUeXBlEhsKF0tF";
		buffer[1] = "QUNIRkNDQU9JX1BDUERIRUxQS0VNEAASHwoaQ21kQ2hhbmdlTGluZXVwTGVh";
		buffer[2] = "ZGVyU2NSc3AQwAUSGgoVQ21kU2V0TGluZXVwTmFtZVNjUnNwEN0FEhcKEkNt";
		buffer[3] = "ZFF1aXRMaW5ldXBTY1JzcBCeBhIfChpDbWRDaGFuZ2VMaW5ldXBMZWFkZXJD";
		buffer[4] = "c1JlcRDhBRIgChtDbWRFeHRyYUxpbmV1cERlc3Ryb3lOb3RpZnkQlQYSIAob";
		buffer[5] = "Q21kR2V0TGluZXVwQXZhdGFyRGF0YUNzUmVxEL0FEh0KGENtZEdldEFsbExp";
		buffer[6] = "bmV1cERhdGFDc1JlcRD5BRIuCilDbWRWaXJ0dWFsTGluZXVwVHJpYWxBdmF0";
		buffer[7] = "YXJDaGFuZ2VTY05vdGlmeRCcBhIaChVDbWRSZXBsYWNlTGluZXVwU2NSc3AQ";
		buffer[8] = "oAYSHQoYQ21kR2V0Q3VyTGluZXVwRGF0YVNjUnNwEJsGEhcKEkNtZEpvaW5M";
		buffer[9] = "aW5ldXBTY1JzcBDOBRITCg5DbWRBSkpBQU1OREdFSBDGBRIeChlDbWRTd2l0";
		buffer[10] = "Y2hMaW5ldXBJbmRleENzUmVxEOIFEh4KGUNtZFN3aXRjaExpbmV1cEluZGV4";
		buffer[11] = "U2NSc3AQhAYSFwoSQ21kSm9pbkxpbmV1cENzUmVxEMoFEh0KGENtZEdldEN1";
		buffer[12] = "ckxpbmV1cERhdGFDc1JlcRCaBhIdChhDbWRHZXRBbGxMaW5ldXBEYXRhU2NS";
		buffer[13] = "c3AQwwUSEwoOQ21kQkNOT0dFTkFISkoQ1gUSIgodQ21kVmlydHVhbExpbmV1";
		buffer[14] = "cERlc3Ryb3lOb3RpZnkQ9gUSFwoSQ21kU3dhcExpbmV1cENzUmVxEPsFEhwK";
		buffer[15] = "F0tFQUNIRkNDQU9JX05OTU1OTURKRUxLEJcGEiAKG0NtZEdldExpbmV1cEF2";
		buffer[16] = "YXRhckRhdGFTY1JzcBCGBhIaChVDbWRSZXBsYWNlTGluZXVwQ3NSZXEQ6AUS";
		buffer[17] = "GAoTQ21kU3luY0xpbmV1cE5vdGlmeRDjBRIXChJDbWRRdWl0TGluZXVwQ3NS";
		buffer[18] = "ZXEQxQUSGgoVQ21kU2V0TGluZXVwTmFtZUNzUmVxENwFQhaqAhNNYXJjaDd0";
		buffer[19] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdLineupType) }, null, null));
	}
}
