using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EAHJLOANBPDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EAHJLOANBPDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQUhKTE9BTkJQRC5wcm90bxoRS0pBR0xJSURCR1AucHJvdG8iQQoLRUFI" + "SkxPQU5CUEQSIQoLQ0xMR0hEQ05QT0kYDiABKAsyDC5LSkFHTElJREJHUBIP" + "CgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { KJAGLIIDBGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EAHJLOANBPD), EAHJLOANBPD.Parser, new string[2] { "CLLGHDCNPOI", "Retcode" }, null, null, null, null)
		}));
	}
}
