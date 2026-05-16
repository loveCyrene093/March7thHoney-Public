using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRogueTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRogueTypeReflection()
	{
		_003C_003Ey__InlineArray37<string> buffer = default(_003C_003Ey__InlineArray37<string>);
		buffer[0] = "ChJDbWRSb2d1ZVR5cGUucHJvdG8qxQwKDENtZFJvZ3VlVHlwZRIbChdPRUVM";
		buffer[1] = "TkpMT0tIS19QQ1BESEVMUEtFTRAAEhcKEkNtZFN0YXJ0Um9ndWVTY1JzcBDn";
		buffer[2] = "DhIZChRDbWRHZXRSb2d1ZUluZm9TY1JzcBCSDhIXChJDbWRMZWF2ZVJvZ3Vl";
		buffer[3] = "Q3NSZXEQkQ4SIwoeQ21kRXhjaGFuZ2VSb2d1ZVJld2FyZEtleVNjUnNwENUO";
		buffer[4] = "Eh4KGUNtZEVudGVyUm9ndWVNYXBSb29tU2NSc3AQ5Q4SHQoYQ21kU3luY1Jv";
		buffer[5] = "Z3VlQWVvblNjTm90aWZ5EMwOEhMKDkNtZExPUE9KREFBSVBPENwOEhMKDkNt";
		buffer[6] = "ZFBOSEdJQU5HTkFFEJ4OEiAKG0NtZFN5bmNSb2d1ZUdldEl0ZW1TY05vdGlm";
		buffer[7] = "eRDEDhIjCh5DbWRFeGNoYW5nZVJvZ3VlUmV3YXJkS2V5Q3NSZXEQlA4SIQoc";
		buffer[8] = "Q21kVGFrZVJvZ3VlU2NvcmVSZXdhcmRTY1JzcBDCDhITCg5DbWRBQUJGTEdL";
		buffer[9] = "Q0hDQRCpDhIXChJDbWRTdGFydFJvZ3VlQ3NSZXEQ5g4SJAofQ21kRmluaXNo";
		buffer[10] = "QWVvbkRpYWxvZ3VlR3JvdXBTY1JzcBCqDhIlCiBDbWRUYWtlUm9ndWVBZW9u";
		buffer[11] = "TGV2ZWxSZXdhcmRDc1JlcRDrDhIdChhDbWRHZXRSb2d1ZUFlb25JbmZvU2NS";
		buffer[12] = "c3AQ1A4SHAoXT0VFTE5KTE9LSEtfR0lFSUZPTEVPRUcQig4SEwoOQ21kSkJP";
		buffer[13] = "RUxMRkJGSEIQlw4SFwoSQ21kRW50ZXJSb2d1ZUNzUmVxEJYOEhMKDkNtZEdM";
		buffer[14] = "S1BDUExCUExOEOgOEh0KGENtZEdldFJvZ3VlQWVvbkluZm9Dc1JlcRC4DhIT";
		buffer[15] = "Cg5DbWROTExKQkdQSkZJThDQDhIjCh5DbWRTeW5jUm9ndWVSZXZpdmVJbmZv";
		buffer[16] = "U2NOb3RpZnkQ0Q4SFgoRQ21kUXVpdFJvZ3VlU2NSc3AQkA4SHgoZQ21kRW50";
		buffer[17] = "ZXJSb2d1ZU1hcFJvb21Dc1JlcRCcDhITCg5DbWRHSktPUEtMREZHQhCVDhIj";
		buffer[18] = "Ch5DbWRTeW5jUm9ndWVFeHBsb3JlV2luU2NOb3RpZnkQuw4SHwoaQ21kU3lu";
		buffer[19] = "Y1JvZ3VlU3RhdHVzU2NOb3RpZnkQ2Q4SHgoZQ21kRW5hYmxlUm9ndWVUYWxl";
		buffer[20] = "bnRDc1JlcRDfDhIkCh9DbWRGaW5pc2hBZW9uRGlhbG9ndWVHcm91cENzUmVx";
		buffer[21] = "ELYOEhYKEUNtZFF1aXRSb2d1ZUNzUmVxEL0OEhMKDkNtZEtFUE5HTUhDTkRO";
		buffer[22] = "EOEOEhcKEkNtZExlYXZlUm9ndWVTY1JzcBDqDhIfChpDbWRHZXRSb2d1ZVRh";
		buffer[23] = "bGVudEluZm9Dc1JlcRDADhIcChdPRUVMTkpMT0tIS19PREVQT0lHQk1DQhCP";
		buffer[24] = "DhITCg5DbWRCSURNSE9GRENJQxDsDhIlCiBDbWRTeW5jUm9ndWVTZWFzb25G";
		buffer[25] = "aW5pc2hTY05vdGlmeRChDhIjCh5DbWRTeW5jUm9ndWVBcmVhVW5sb2NrU2NO";
		buffer[26] = "b3RpZnkQ2g4SHwoaQ21kU3luY1JvZ3VlRmluaXNoU2NOb3RpZnkQjA4SHgoZ";
		buffer[27] = "Q21kRW5hYmxlUm9ndWVUYWxlbnRTY1JzcBCjDhIfChpDbWRHZXRSb2d1ZVRh";
		buffer[28] = "bGVudEluZm9TY1JzcBC1DhIhChxDbWRHZXRSb2d1ZUluaXRpYWxTY29yZVNj";
		buffer[29] = "UnNwELkOEhMKDkNtZENJR0lJQ0VKTEpFEK4OEhsKFkNtZE9wZW5Sb2d1ZUNo";
		buffer[30] = "ZXN0U2NSc3AQpQ4SJAofQ21kR2V0Um9ndWVTY29yZVJld2FyZEluZm9TY1Jz";
		buffer[31] = "cBDYDhITCg5DbWRESkZJQ01DQk5BRRDFDhIXChJDbWRFbnRlclJvZ3VlU2NS";
		buffer[32] = "c3AQmg4SHAoXT0VFTE5KTE9LSEtfR0xHUEVGTUFMUEUQ3g4SEwoOQ21kTU1J";
		buffer[33] = "QkFDRk5FTEIQtA4SGwoWQ21kT3BlblJvZ3VlQ2hlc3RDc1JlcRDDDhIgChtD";
		buffer[34] = "bWRTeW5jUm9ndWVNYXBSb29tU2NOb3RpZnkQyg4SGQoUQ21kR2V0Um9ndWVJ";
		buffer[35] = "bmZvQ3NSZXEQ4w4SKAojQ21kU3luY1JvZ3VlVmlydHVhbEl0ZW1JbmZvU2NO";
		buffer[36] = "b3RpZnkQtw5CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueType) }, null, null));
	}
}
