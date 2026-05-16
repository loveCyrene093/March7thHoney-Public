using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GDABFHAALMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GDABFHAALMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHREFCRkhBQUxNTC5wcm90bxoRRU1IQUxKUEREQkwucHJvdG8iQQoLR0RB" + "QkZIQUFMTUwSIQoLTUFPTkhEQ0NIUEUYAiABKAsyDC5FTUhBTEpQRERCTBIP" + "CgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { EMHALJPDDBLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GDABFHAALML), GDABFHAALML.Parser, new string[2] { "MAONHDCCHPE", "Retcode" }, null, null, null, null)
		}));
	}
}
