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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 0) = "ChdDbWRSb2d1ZU1hZ2ljVHlwZS5wcm90byqtCwoRQ21kUm9ndWVNYWdpY1R5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 1) = "cGUSGwoXTkZKRUpQTkxMQU1fQU1GSkJCTkpQTEkQABIqCiVDbWRSb2d1ZU1h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 2) = "Z2ljUmV2aXZlQ29zdFVwZGF0ZVNjTm90aWZ5ELU8EhMKDkNtZExNR0pETERH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 3) = "S01NEPQ8EhMKDkNtZEZHQ0JNR0VJR0ZMEMU8EiMKHkNtZFJvZ3VlTWFnaWNS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 4) = "ZXZpdmVBdmF0YXJDc1JlcRDRPBIqCiVDbWRSb2d1ZU1hZ2ljR2V0TWlzY1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 5) = "YWxUaW1lRGF0YVNjUnNwEPE8EhwKF05GSkVKUE5MTEFNX05QSklPTkRKS0dB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 6) = "EJw8EhwKF0NtZFJvZ3VlTWFnaWNTdGFydENzUmVxEO88EikKJENtZFJvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 7) = "TWFnaWNTY2VwdGVyVGFrZU9mZlVuaXRDc1JlcRDNPBIpCiRDbWRSb2d1ZU1h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 8) = "Z2ljU3RvcnlJbmZvVXBkYXRlU2NOb3RpZnkQ1jwSIQocQ21kUm9ndWVNYWdp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 9) = "Y0VudGVyTGF5ZXJDc1JlcRC7PBIpCiRDbWRSb2d1ZU1hZ2ljTGV2ZWxJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 10) = "VXBkYXRlU2NOb3RpZnkQ3jwSIgodQ21kUm9ndWVNYWdpY1VuaXRDb21wb3Nl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 11) = "Q3NSZXEQsDwSIwoeQ21kUm9ndWVNYWdpY1Jldml2ZUF2YXRhclNjUnNwEJs8";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 12) = "Ei4KKUNtZFJvZ3VlTWFnaWNCYXR0bGVGYWlsU2V0dGxlSW5mb1NjTm90aWZ5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 13) = "ELQ8EhwKF0NtZFJvZ3VlTWFnaWNTdGFydFNjUnNwEJ48EhwKF0NtZFJvZ3Vl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 14) = "TWFnaWNMZWF2ZVNjUnNwEKY8EhMKDkNtZEpFUEFKQ0VHUEFEEKk8Ei4KKUNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 15) = "ZFJvZ3VlTWFnaWNTZXRBdXRvRHJlc3NJbk1hZ2ljVW5pdFNjUnNwEOM8Eh0K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 16) = "GENtZFJvZ3VlTWFnaWNTZXR0bGVTY1JzcBD2PBIhChxDbWRSb2d1ZU1hZ2lj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 17) = "RW50ZXJMYXllclNjUnNwEJU8EhMKDkNtZEtCRElCS0xFQktQEMk8EjQKL0Nt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 18) = "ZFJvZ3VlTWFnaWNBdXRvRHJlc3NJbk1hZ2ljVW5pdENoYW5nZVNjTm90aWZ5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 19) = "EJk8EikKJENtZFJvZ3VlTWFnaWNTY2VwdGVyRHJlc3NJblVuaXRDc1JlcRDt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 20) = "PBIjCh5DbWRSb2d1ZU1hZ2ljRW5hYmxlVGFsZW50Q3NSZXEQxzwSIAobQ21k";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 21) = "Um9ndWVNYWdpY0VudGVyUm9vbUNzUmVxENM8EiQKH0NtZFJvZ3VlTWFnaWNB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 22) = "cmVhVXBkYXRlU2NOb3RpZnkQuTwSIAobQ21kUm9ndWVNYWdpY0VudGVyUm9v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 23) = "bVNjUnNwEK48EhwKF0NtZFJvZ3VlTWFnaWNFbnRlclNjUnNwEPM8EiMKHkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 24) = "ZFJvZ3VlTWFnaWNFbmFibGVUYWxlbnRTY1JzcBCtPBIcChdDbWRSb2d1ZU1h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 25) = "Z2ljTGVhdmVDc1JlcRCiPBIcChdORkpFSlBOTExBTV9DR0ZCRkVJSUhNTxDd";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 26) = "PBIqCiVDbWRSb2d1ZU1hZ2ljR2V0TWlzY1JlYWxUaW1lRGF0YUNzUmVxEKg8";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 27) = "EhMKDkNtZEVBSEpMT0FOQlBEEKU8EhwKF0NtZFJvZ3VlTWFnaWNRdWVyeVNj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 28) = "UnNwEMA8EiIKHUNtZFJvZ3VlTWFnaWNVbml0Q29tcG9zZVNjUnNwENU8Ei4K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 29) = "KUNtZFJvZ3VlTWFnaWNTZXRBdXRvRHJlc3NJbk1hZ2ljVW5pdENzUmVxEMo8";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 30) = "EiYKIUNtZFJvZ3VlTWFnaWNBdXRvRHJlc3NJblVuaXRDc1JlcRCWPBIcChdD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 31) = "bWRSb2d1ZU1hZ2ljUXVlcnlDc1JlcRDOPBIcChdDbWRSb2d1ZU1hZ2ljRW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 32) = "ZXJDc1JlcRDyPBIdChhDbWRSb2d1ZU1hZ2ljU2V0dGxlQ3NSZXEQnTxCFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray34<string>, string>(ref buffer, 33) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray34<string>, string>(in buffer, 34))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueMagicType) }, null, null));
	}
}
