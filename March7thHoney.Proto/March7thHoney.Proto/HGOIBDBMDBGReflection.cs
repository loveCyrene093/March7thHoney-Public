using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HGOIBDBMDBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HGOIBDBMDBGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIR09JQkRCTURCRy5wcm90byIeCgtIR09JQkRCTURCRxIPCgdyZXRjb2Rl" + "GAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HGOIBDBMDBG), HGOIBDBMDBG.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
