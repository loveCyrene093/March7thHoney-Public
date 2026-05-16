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
		buffer[0] = "ChtDaGFuZ2VTdG9yeUxpbmVBY3Rpb24ucHJvdG8q7AEKFUNoYW5nZVN0b3J5";
		buffer[1] = "TGluZUFjdGlvbhIeChpDaGFuZ2VTdG9yeUxpbmVBY3Rpb25fTm9uZRAAEiYK";
		buffer[2] = "IkNoYW5nZVN0b3J5TGluZUFjdGlvbl9GaW5pc2hBY3Rpb24QARIgChxDaGFu";
		buffer[3] = "Z2VTdG9yeUxpbmVBY3Rpb25fQ2xpZW50EAISIgoeQ2hhbmdlU3RvcnlMaW5l";
		buffer[4] = "QWN0aW9uX0N1c3RvbU9QEAMSHgoaQ2hhbmdlU3RvcnlMaW5lQWN0aW9uX1Jh";
		buffer[5] = "aWQQBBIlCiFDaGFuZ2VTdG9yeUxpbmVBY3Rpb25fSEtGS0FGUEFKQ08QBUIW";
		buffer[6] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChangeStoryLineAction) }, null, null));
	}
}
