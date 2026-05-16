using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PunkLordShareTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PunkLordShareTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdQdW5rTG9yZFNoYXJlVHlwZS5wcm90bypqChFQdW5rTG9yZFNoYXJlVHlw" + "ZRIbChdGT09ET1BETkRMS19QQ1BESEVMUEtFTRAAEhsKF0ZPT0RPUERORExL" + "X0RLQ0tEQ0xDUEVMEAESGwoXRk9PRE9QRE5ETEtfUE5NQ0pIRk5CT08QAkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PunkLordShareType) }, null, null));
	}
}
