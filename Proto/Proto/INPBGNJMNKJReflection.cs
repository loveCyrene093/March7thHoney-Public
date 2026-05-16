using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class INPBGNJMNKJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static INPBGNJMNKJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFJTlBCR05KTU5LSi5wcm90byqBAQoLSU5QQkdOSk1OS0oSGwoXSU5QQkdO";
		buffer[1] = "Sk1OS0pfUENQREhFTFBLRU0QABIbChdJTlBCR05KTU5LSl9QS0VBSE9CRkdD";
		buffer[2] = "QhABEhsKF0lOUEJHTkpNTktKX09BRklQR01ITlBPEAISGwoXSU5QQkdOSk1O";
		buffer[3] = "S0pfREhORUFLRkdDQksQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(INPBGNJMNKJ) }, null, null));
	}
}
