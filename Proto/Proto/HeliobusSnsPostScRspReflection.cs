using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusSnsPostScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusSnsPostScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpIZWxpb2J1c1Nuc1Bvc3RTY1JzcC5wcm90bxoRRExGT0dKR0NDR1AucHJv" + "dG8iSgoUSGVsaW9idXNTbnNQb3N0U2NSc3ASIQoLSUdJUEFLRUxKRkQYCyAB" + "KAsyDC5ETEZPR0pHQ0NHUBIPCgdyZXRjb2RlGAwgASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { DLFOGJGCCGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusSnsPostScRsp), HeliobusSnsPostScRsp.Parser, new string[2] { "IGIPAKELJFD", "Retcode" }, null, null, null, null)
		}));
	}
}
