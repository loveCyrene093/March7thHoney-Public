using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRelicPresetTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRelicPresetTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChhDbWRSZWxpY1ByZXNldFR5cGUucHJvdG8qpAIKEkNtZFJlbGljUHJlc2V0";
		buffer[1] = "VHlwZRIbChdMQkpJQVBETU9BSF9QQ1BESEVMUEtFTRAAEhMKDkNtZEdCRkdB";
		buffer[2] = "QkhGQkNOEPpMEh8KGkNtZFJlbGljUHJlc2V0QWRkUGxhbkNzUmVxEPJMEhMK";
		buffer[3] = "DkNtZEFPR0hLREdFRkdBEIRNEiIKHUNtZFJlbGljUHJlc2V0RGVsZXRlUGxh";
		buffer[4] = "bkNzUmVxEP9MEhMKDkNtZEFJT0RNRU5DUEtBEPdMEh8KGkNtZFJlbGljUHJl";
		buffer[5] = "c2V0R2V0UGxhbkNzUmVxEPFMEiIKHUNtZFJlbGljUHJlc2V0VXBkYXRlUGxh";
		buffer[6] = "bkNzUmVxEP5MEhMKDkNtZE9HTUREREZETkpQEIFNEhMKDkNtZEhMUE1ET1BI";
		buffer[7] = "Tk9HEPhMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRelicPresetType) }, null, null));
	}
}
