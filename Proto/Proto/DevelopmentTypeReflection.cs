using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DevelopmentTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DevelopmentTypeReflection()
	{
		InlineArray14<string> buffer = default(InlineArray14<string>);
		buffer[0] = "ChVEZXZlbG9wbWVudFR5cGUucHJvdG8quAQKD0RldmVsb3BtZW50VHlwZRIb";
		buffer[1] = "ChdLR0hPRFBGSkdMSV9NSkZMREtIS0RBQhAAEhsKF0tHSE9EUEZKR0xJX0lC";
		buffer[2] = "TUJQTUlNSkVHEAESGwoXS0dIT0RQRkpHTElfREZNRkdNQ0dIS0sQAhIbChdL";
		buffer[3] = "R0hPRFBGSkdMSV9ER0RMTEpLTkxNQxADEhsKF0tHSE9EUEZKR0xJX0ZKSkFB";
		buffer[4] = "TkFJS0xQEAQSGwoXS0dIT0RQRkpHTElfUEpQR01MUE1LQkIQBRIbChdLR0hP";
		buffer[5] = "RFBGSkdMSV9DUEhGRE1HSEtEThAGEhsKF0tHSE9EUEZKR0xJX0JQQUpHSEpH";
		buffer[6] = "Q0FNEAcSGwoXS0dIT0RQRkpHTElfUFBLRkVLRkhGR0IQCBIbChdLR0hPRFBG";
		buffer[7] = "SkdMSV9HTkFNRUFLRUJOTBAJEhsKF0tHSE9EUEZKR0xJX0FQQkNISU5NQ0lK";
		buffer[8] = "EAoSGwoXS0dIT0RQRkpHTElfRkJQREdMUEJCSUgQCxIbChdLR0hPRFBGSkdM";
		buffer[9] = "SV9NRUFLRFBPQUtLRhAMEhsKF0tHSE9EUEZKR0xJX0pMQ0RNUEpLUEhEEA0S";
		buffer[10] = "GwoXS0dIT0RQRkpHTElfTUlGSElGSkNHQU0QDhIbChdLR0hPRFBGSkdMSV9C";
		buffer[11] = "SUNNS0pKQkhKRhAPEhsKF0tHSE9EUEZKR0xJX0dBRU9BSlBBSUhMEBASGwoX";
		buffer[12] = "S0dIT0RQRkpHTElfT0hLRE5KR0pBTkgQERIbChdLR0hPRFBGSkdMSV9OT09K";
		buffer[13] = "TUFIS01IQxASQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DevelopmentType) }, null, null));
	}
}
