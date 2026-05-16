using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IHLLBHLEGMDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IHLLBHLEGMDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJSExMQkhMRUdNRC5wcm90byJyCgtJSExMQkhMRUdNRBITCgtDRklETU1G" + "RkJPRRgCIAEoBRIPCgdpdGVtX2lkGAQgASgNEhMKC0tQR01CS0tPR0pHGAcg" + "ASgNEhMKC0FFSEtOR0JLUEJFGAogASgNEhMKC0hLSU9NQ09DRE5GGAwgASgF" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IHLLBHLEGMD), IHLLBHLEGMD.Parser, new string[5] { "CFIDMMFFBOE", "ItemId", "KPGMBKKOGJG", "AEHKNGBKPBE", "HKIOMCOCDNF" }, null, null, null, null)
		}));
	}
}
