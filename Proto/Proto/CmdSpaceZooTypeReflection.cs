using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdSpaceZooTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdSpaceZooTypeReflection()
	{
		InlineArray13<string> buffer = default(InlineArray13<string>);
		buffer[0] = "ChVDbWRTcGFjZVpvb1R5cGUucHJvdG8q4wMKD0NtZFNwYWNlWm9vVHlwZRIb";
		buffer[1] = "ChdCR0NESUpETkFHRl9QQ1BESEVMUEtFTRAAEhsKFkNtZFNwYWNlWm9vTXV0";
		buffer[2] = "YXRlU2NSc3AQvjQSGwoWQ21kU3BhY2Vab29NdXRhdGVDc1JlcRC6NBIZChRD";
		buffer[3] = "bWRTcGFjZVpvb0Jvcm5Dc1JlcRCKNRIeChlDbWRTcGFjZVpvb0RlbGV0ZUNh";
		buffer[4] = "dFNjUnNwEMY0EhkKFENtZFNwYWNlWm9vVGFrZVNjUnNwELA0Eh4KGUNtZFNw";
		buffer[5] = "YWNlWm9vT3BDYXR0ZXJ5U2NSc3AQjjUSIQocQ21kU3BhY2Vab29FeGNoYW5n";
		buffer[6] = "ZUl0ZW1Dc1JlcRCtNBIeChlDbWRTcGFjZVpvb0RlbGV0ZUNhdENzUmVxEOs0";
		buffer[7] = "EhkKFENtZFNwYWNlWm9vQm9yblNjUnNwEIs1Eh8KGkNtZFNwYWNlWm9vQ2F0";
		buffer[8] = "VXBkYXRlTm90aWZ5ENM0EhMKDkNtZEVJQ0pKSkZGTEJJEPY0Eh4KGUNtZFNw";
		buffer[9] = "YWNlWm9vT3BDYXR0ZXJ5Q3NSZXEQtTQSGQoUQ21kU3BhY2Vab29EYXRhU2NS";
		buffer[10] = "c3AQtjQSGQoUQ21kU3BhY2Vab29UYWtlQ3NSZXEQ0TQSGQoUQ21kU3BhY2Va";
		buffer[11] = "b29EYXRhQ3NSZXEQhzVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[12] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdSpaceZooType) }, null, null));
	}
}
