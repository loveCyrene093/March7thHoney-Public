using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRogueMagicTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRogueMagicTypeReflection()
	{
		_003C_003Ey__InlineArray34<string> buffer = default(_003C_003Ey__InlineArray34<string>);
		buffer[0] = "ChdDbWRSb2d1ZU1hZ2ljVHlwZS5wcm90byqtCwoRQ21kUm9ndWVNYWdpY1R5";
		buffer[1] = "cGUSGwoXTkZKRUpQTkxMQU1fQU1GSkJCTkpQTEkQABIqCiVDbWRSb2d1ZU1h";
		buffer[2] = "Z2ljUmV2aXZlQ29zdFVwZGF0ZVNjTm90aWZ5ELU8EhMKDkNtZExNR0pETERH";
		buffer[3] = "S01NEPQ8EhMKDkNtZEZHQ0JNR0VJR0ZMEMU8EiMKHkNtZFJvZ3VlTWFnaWNS";
		buffer[4] = "ZXZpdmVBdmF0YXJDc1JlcRDRPBIqCiVDbWRSb2d1ZU1hZ2ljR2V0TWlzY1Jl";
		buffer[5] = "YWxUaW1lRGF0YVNjUnNwEPE8EhwKF05GSkVKUE5MTEFNX05QSklPTkRKS0dB";
		buffer[6] = "EJw8EhwKF0NtZFJvZ3VlTWFnaWNTdGFydENzUmVxEO88EikKJENtZFJvZ3Vl";
		buffer[7] = "TWFnaWNTY2VwdGVyVGFrZU9mZlVuaXRDc1JlcRDNPBIpCiRDbWRSb2d1ZU1h";
		buffer[8] = "Z2ljU3RvcnlJbmZvVXBkYXRlU2NOb3RpZnkQ1jwSIQocQ21kUm9ndWVNYWdp";
		buffer[9] = "Y0VudGVyTGF5ZXJDc1JlcRC7PBIpCiRDbWRSb2d1ZU1hZ2ljTGV2ZWxJbmZv";
		buffer[10] = "VXBkYXRlU2NOb3RpZnkQ3jwSIgodQ21kUm9ndWVNYWdpY1VuaXRDb21wb3Nl";
		buffer[11] = "Q3NSZXEQsDwSIwoeQ21kUm9ndWVNYWdpY1Jldml2ZUF2YXRhclNjUnNwEJs8";
		buffer[12] = "Ei4KKUNtZFJvZ3VlTWFnaWNCYXR0bGVGYWlsU2V0dGxlSW5mb1NjTm90aWZ5";
		buffer[13] = "ELQ8EhwKF0NtZFJvZ3VlTWFnaWNTdGFydFNjUnNwEJ48EhwKF0NtZFJvZ3Vl";
		buffer[14] = "TWFnaWNMZWF2ZVNjUnNwEKY8EhMKDkNtZEpFUEFKQ0VHUEFEEKk8Ei4KKUNt";
		buffer[15] = "ZFJvZ3VlTWFnaWNTZXRBdXRvRHJlc3NJbk1hZ2ljVW5pdFNjUnNwEOM8Eh0K";
		buffer[16] = "GENtZFJvZ3VlTWFnaWNTZXR0bGVTY1JzcBD2PBIhChxDbWRSb2d1ZU1hZ2lj";
		buffer[17] = "RW50ZXJMYXllclNjUnNwEJU8EhMKDkNtZEtCRElCS0xFQktQEMk8EjQKL0Nt";
		buffer[18] = "ZFJvZ3VlTWFnaWNBdXRvRHJlc3NJbk1hZ2ljVW5pdENoYW5nZVNjTm90aWZ5";
		buffer[19] = "EJk8EikKJENtZFJvZ3VlTWFnaWNTY2VwdGVyRHJlc3NJblVuaXRDc1JlcRDt";
		buffer[20] = "PBIjCh5DbWRSb2d1ZU1hZ2ljRW5hYmxlVGFsZW50Q3NSZXEQxzwSIAobQ21k";
		buffer[21] = "Um9ndWVNYWdpY0VudGVyUm9vbUNzUmVxENM8EiQKH0NtZFJvZ3VlTWFnaWNB";
		buffer[22] = "cmVhVXBkYXRlU2NOb3RpZnkQuTwSIAobQ21kUm9ndWVNYWdpY0VudGVyUm9v";
		buffer[23] = "bVNjUnNwEK48EhwKF0NtZFJvZ3VlTWFnaWNFbnRlclNjUnNwEPM8EiMKHkNt";
		buffer[24] = "ZFJvZ3VlTWFnaWNFbmFibGVUYWxlbnRTY1JzcBCtPBIcChdDbWRSb2d1ZU1h";
		buffer[25] = "Z2ljTGVhdmVDc1JlcRCiPBIcChdORkpFSlBOTExBTV9DR0ZCRkVJSUhNTxDd";
		buffer[26] = "PBIqCiVDbWRSb2d1ZU1hZ2ljR2V0TWlzY1JlYWxUaW1lRGF0YUNzUmVxEKg8";
		buffer[27] = "EhMKDkNtZEVBSEpMT0FOQlBEEKU8EhwKF0NtZFJvZ3VlTWFnaWNRdWVyeVNj";
		buffer[28] = "UnNwEMA8EiIKHUNtZFJvZ3VlTWFnaWNVbml0Q29tcG9zZVNjUnNwENU8Ei4K";
		buffer[29] = "KUNtZFJvZ3VlTWFnaWNTZXRBdXRvRHJlc3NJbk1hZ2ljVW5pdENzUmVxEMo8";
		buffer[30] = "EiYKIUNtZFJvZ3VlTWFnaWNBdXRvRHJlc3NJblVuaXRDc1JlcRCWPBIcChdD";
		buffer[31] = "bWRSb2d1ZU1hZ2ljUXVlcnlDc1JlcRDOPBIcChdDbWRSb2d1ZU1hZ2ljRW50";
		buffer[32] = "ZXJDc1JlcRDyPBIdChhDbWRSb2d1ZU1hZ2ljU2V0dGxlQ3NSZXEQnTxCFqoC";
		buffer[33] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueMagicType) }, null, null));
	}
}
