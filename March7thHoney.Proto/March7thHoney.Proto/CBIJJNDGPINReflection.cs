using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CBIJJNDGPINReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CBIJJNDGPINReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQklKSk5ER1BJTi5wcm90bxoRUEdIUEhQR0lETUIucHJvdG8iMAoLQ0JJ" + "SkpOREdQSU4SIQoLSEFLT0xPQ0dFRkIYCCADKAsyDC5QR0hQSFBHSURNQkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PGHPHPGIDMBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CBIJJNDGPIN), CBIJJNDGPIN.Parser, new string[1] { "HAKOLOCGEFB" }, null, null, null, null)
		}));
	}
}
