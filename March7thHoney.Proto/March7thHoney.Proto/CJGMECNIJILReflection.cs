using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CJGMECNIJILReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CJGMECNIJILReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDSkdNRUNOSUpJTC5wcm90bxoRRE1MS0VLRktOUEwucHJvdG8iZwoLQ0pH" + "TUVDTklKSUwSEAoIdHJhaXRfaWQYASABKA0SIQoLS0JNQkZKT0xCQk4YAiAD" + "KAsyDC5ETUxLRUtGS05QTBIOCgZkYW1hZ2UYAyABKAESEwoLQk9JRUdQQVBI" + "T1AYBCABKAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { DMLKEKFKNPLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CJGMECNIJIL), CJGMECNIJIL.Parser, new string[4] { "TraitId", "KBMBFJOLBBN", "Damage", "BOIEGPAPHOP" }, null, null, null, null)
		}));
	}
}
