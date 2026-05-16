using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PLIGIAFNLCBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PLIGIAFNLCBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTElHSUFGTkxDQi5wcm90bypkCgtQTElHSUFGTkxDQhIbChdQTElHSUFG" + "TkxDQl9QQ1BESEVMUEtFTRAAEhsKF1BMSUdJQUZOTENCX0hMTERNRktHQ0RB" + "EAESGwoXUExJR0lBRk5MQ0JfS0dDQ0NNR0xHRUcQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PLIGIAFNLCB) }, null, null));
	}
}
