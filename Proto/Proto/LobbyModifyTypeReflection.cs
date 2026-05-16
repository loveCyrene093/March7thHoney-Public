using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyModifyTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyModifyTypeReflection()
	{
		InlineArray14<string> buffer = default(InlineArray14<string>);
		buffer[0] = "ChVMb2JieU1vZGlmeVR5cGUucHJvdG8quAQKD0xvYmJ5TW9kaWZ5VHlwZRIb";
		buffer[1] = "ChdCTUROQkhISUNMRF9QQ1BESEVMUEtFTRAAEhsKF0JNRE5CSEhJQ0xEX0dI";
		buffer[2] = "R0FQT0FLR0FCEAESGwoXQk1ETkJISElDTERfR1BKTUtLQURMREMQAhIbChdC";
		buffer[3] = "TUROQkhISUNMRF9CUENFS01MUEpDShADEhsKF0JNRE5CSEhJQ0xEX0lETUpC";
		buffer[4] = "SEpMT0JHEAQSGwoXQk1ETkJISElDTERfTFBBR01KSU9HQ0gQBRIbChdCTURO";
		buffer[5] = "QkhISUNMRF9DR0hBTkhKSUVJRxAGEhsKF0JNRE5CSEhJQ0xEX0VES0xEQkhN";
		buffer[6] = "Tk9KEAcSGwoXQk1ETkJISElDTERfTk1HS0RDTUlIQUIQCBIbChdCTUROQkhI";
		buffer[7] = "SUNMRF9HQkpJTUxFTUdEQhAJEhsKF0JNRE5CSEhJQ0xEX01HTkJFS0NITEhF";
		buffer[8] = "EAoSGwoXQk1ETkJISElDTERfT0REQkZOSExIS0wQCxIbChdCTUROQkhISUNM";
		buffer[9] = "RF9IRk1KT0FPRUlOTRAMEhsKF0JNRE5CSEhJQ0xEX05JUEJOT0dETUJMEA0S";
		buffer[10] = "GwoXQk1ETkJISElDTERfT0pFQUxFQUxJUEoQDhIbChdCTUROQkhISUNMRF9Q";
		buffer[11] = "SU5NSUZPSExPQRAPEhsKF0JNRE5CSEhJQ0xEX0JQRFBJUEJKRU1EEBASGwoX";
		buffer[12] = "Qk1ETkJISElDTERfSEtPRENPR09BTUsQERIbChdCTUROQkhISUNMRF9PSURB";
		buffer[13] = "T05KUEFQQRASQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LobbyModifyType) }, null, null));
	}
}
