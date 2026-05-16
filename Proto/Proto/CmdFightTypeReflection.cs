using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFightTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFightTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChJDbWRGaWdodFR5cGUucHJvdG8qogIKDENtZEZpZ2h0VHlwZRIbChdIQklE";
		buffer[1] = "R0VPT0lLSF9QQ1BESEVMUEtFTRAAEhQKDkNtZE5QT0ZMSUhOQU5NEMLqARIU";
		buffer[2] = "Cg5DbWRPR1BQQklESU5CSRC56gESFAoOQ21kT0JKR0dKUEZMQUUQyuoBEhQK";
		buffer[3] = "DkNtZFBORUJIQ0ZKR0ZFEI7rARIUCg5DbWRIQUdNTkNDSklCQhCP6wESFAoO";
		buffer[4] = "Q21kTEtPT0FIT0ZKQUMQuuoBEhQKDkNtZE9QT0FDTUxDR0FIEO/qARIdChdI";
		buffer[5] = "QklER0VPT0lLSF9JT0pOREVJTEFFSxCS6wESHQoXSEJJREdFT09JS0hfQUZP";
		buffer[6] = "TEhHTU9CRU8QvuoBEh0KF0hCSURHRU9PSUtIX01HR0dNSExNQ0RFEIvrAUIW";
		buffer[7] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFightType) }, null, null));
	}
}
