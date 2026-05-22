using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGuessBuyInformationCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGuessBuyInformationCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZNb25vcG9seUd1ZXNzQnV5SW5mb3JtYXRpb25Dc1JlcS5wcm90byIiCiBN" + "b25vcG9seUd1ZXNzQnV5SW5mb3JtYXRpb25Dc1JlcUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGuessBuyInformationCsReq), MonopolyGuessBuyInformationCsReq.Parser, null, null, null, null, null)
		}));
	}
}
