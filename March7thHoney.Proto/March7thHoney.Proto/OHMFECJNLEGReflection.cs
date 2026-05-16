using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OHMFECJNLEGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OHMFECJNLEGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSE1GRUNKTkxFRy5wcm90bxoRRU5ET0xFSkNIS1AucHJvdG8iVgoLT0hN" + "RkVDSk5MRUcSEwoLRU9HTUlIRVBDR00YAiADKA0SIQoLQkZNTkFLQ1BHTk4Y" + "AyADKAsyDC5FTkRPTEVKQ0hLUBIPCgdyZXRjb2RlGA4gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ENDOLEJCHKPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OHMFECJNLEG), OHMFECJNLEG.Parser, new string[3] { "EOGMIHEPCGM", "BFMNAKCPGNN", "Retcode" }, null, null, null, null)
		}));
	}
}
