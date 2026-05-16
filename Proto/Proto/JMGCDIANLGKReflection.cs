using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JMGCDIANLGKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JMGCDIANLGKReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFKTUdDRElBTkxHSy5wcm90byqBAQoLSk1HQ0RJQU5MR0sSGwoXSk1HQ0RJ";
		buffer[1] = "QU5MR0tfUENQREhFTFBLRU0QABIbChdKTUdDRElBTkxHS19QTk5QTUxQQUtI";
		buffer[2] = "ShABEhsKF0pNR0NESUFOTEdLX09FSkFGSkNCQkRIEAISGwoXSk1HQ0RJQU5M";
		buffer[3] = "R0tfRklJRkFQRUNJSkMQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(JMGCDIANLGK) }, null, null));
	}
}
