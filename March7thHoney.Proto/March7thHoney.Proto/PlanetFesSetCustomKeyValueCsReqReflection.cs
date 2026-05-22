using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesSetCustomKeyValueCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesSetCustomKeyValueCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVQbGFuZXRGZXNTZXRDdXN0b21LZXlWYWx1ZUNzUmVxLnByb3RvIj0KH1Bs" + "YW5ldEZlc1NldEN1c3RvbUtleVZhbHVlQ3NSZXESCwoDa2V5GAcgASgNEg0K" + "BXZhbHVlGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesSetCustomKeyValueCsReq), PlanetFesSetCustomKeyValueCsReq.Parser, new string[2] { "Key", "Value" }, null, null, null, null)
		}));
	}
}
