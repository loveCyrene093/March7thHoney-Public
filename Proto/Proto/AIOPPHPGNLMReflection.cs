using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AIOPPHPGNLMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AIOPPHPGNLMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBSU9QUEhQR05MTS5wcm90bxoRUExJR0lBRk5MQ0IucHJvdG8iMAoLQUlP" + "UFBIUEdOTE0SIQoLRUxMRUxKRkdEUEgYASABKA4yDC5QTElHSUFGTkxDQkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PLIGIAFNLCBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AIOPPHPGNLM), AIOPPHPGNLM.Parser, new string[1] { "ELLELJFGDPH" }, null, null, null, null)
		}));
	}
}
