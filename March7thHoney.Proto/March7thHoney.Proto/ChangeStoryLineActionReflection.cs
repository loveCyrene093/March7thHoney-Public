using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChangeStoryLineActionReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChangeStoryLineActionReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChtDaGFuZ2VTdG9yeUxpbmVBY3Rpb24ucHJvdG8q7AEKFUNoYW5nZVN0b3J5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "TGluZUFjdGlvbhIeChpDaGFuZ2VTdG9yeUxpbmVBY3Rpb25fTm9uZRAAEiYK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "IkNoYW5nZVN0b3J5TGluZUFjdGlvbl9GaW5pc2hBY3Rpb24QARIgChxDaGFu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "Z2VTdG9yeUxpbmVBY3Rpb25fQ2xpZW50EAISIgoeQ2hhbmdlU3RvcnlMaW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "QWN0aW9uX0N1c3RvbU9QEAMSHgoaQ2hhbmdlU3RvcnlMaW5lQWN0aW9uX1Jh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "aWQQBBIlCiFDaGFuZ2VTdG9yeUxpbmVBY3Rpb25fSEtGS0FGUEFKQ08QBUIW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChangeStoryLineAction) }, null, null));
	}
}
