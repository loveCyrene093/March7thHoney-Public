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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 0) = "ChVDbWRTcGFjZVpvb1R5cGUucHJvdG8q4wMKD0NtZFNwYWNlWm9vVHlwZRIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 1) = "ChdCR0NESUpETkFHRl9QQ1BESEVMUEtFTRAAEhsKFkNtZFNwYWNlWm9vTXV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 2) = "YXRlU2NSc3AQvjQSGwoWQ21kU3BhY2Vab29NdXRhdGVDc1JlcRC6NBIZChRD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 3) = "bWRTcGFjZVpvb0Jvcm5Dc1JlcRCKNRIeChlDbWRTcGFjZVpvb0RlbGV0ZUNh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 4) = "dFNjUnNwEMY0EhkKFENtZFNwYWNlWm9vVGFrZVNjUnNwELA0Eh4KGUNtZFNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 5) = "YWNlWm9vT3BDYXR0ZXJ5U2NSc3AQjjUSIQocQ21kU3BhY2Vab29FeGNoYW5n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 6) = "ZUl0ZW1Dc1JlcRCtNBIeChlDbWRTcGFjZVpvb0RlbGV0ZUNhdENzUmVxEOs0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 7) = "EhkKFENtZFNwYWNlWm9vQm9yblNjUnNwEIs1Eh8KGkNtZFNwYWNlWm9vQ2F0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 8) = "VXBkYXRlTm90aWZ5ENM0EhMKDkNtZEVJQ0pKSkZGTEJJEPY0Eh4KGUNtZFNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 9) = "YWNlWm9vT3BDYXR0ZXJ5Q3NSZXEQtTQSGQoUQ21kU3BhY2Vab29EYXRhU2NS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 10) = "c3AQtjQSGQoUQ21kU3BhY2Vab29UYWtlQ3NSZXEQ0TQSGQoUQ21kU3BhY2Va";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 11) = "b29EYXRhQ3NSZXEQhzVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray13<string>, string>(ref buffer, 12) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray13<string>, string>(in buffer, 13))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdSpaceZooType) }, null, null));
	}
}
