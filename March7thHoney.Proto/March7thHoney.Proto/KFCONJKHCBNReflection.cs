using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KFCONJKHCBNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KFCONJKHCBNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRkNPTkpLSENCTi5wcm90bxoRSEpHRkRJS0RJSE8ucHJvdG8iRQoLS0ZD" + "T05KS0hDQk4SEwoLT0ZIQ05HSEpGSEkYAiABKA0SIQoLR0pNQVBEQkdFUEEY" + "BSADKAsyDC5ISkdGRElLRElIT0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { HJGFDIKDIHOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KFCONJKHCBN), KFCONJKHCBN.Parser, new string[2] { "OFHCNGHJFHI", "GJMAPDBGEPA" }, null, null, null, null)
		}));
	}
}
