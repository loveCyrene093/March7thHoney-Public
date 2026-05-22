using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesSetCustomKeyValueScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesSetCustomKeyValueScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVQbGFuZXRGZXNTZXRDdXN0b21LZXlWYWx1ZVNjUnNwLnByb3RvIk4KH1Bs" + "YW5ldEZlc1NldEN1c3RvbUtleVZhbHVlU2NSc3ASCwoDa2V5GAkgASgNEg8K" + "B3JldGNvZGUYCiABKA0SDQoFdmFsdWUYDyABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesSetCustomKeyValueScRsp), PlanetFesSetCustomKeyValueScRsp.Parser, new string[3] { "Key", "Retcode", "Value" }, null, null, null, null)
		}));
	}
}
