using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGetRegionProgressCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGetRegionProgressCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRNb25vcG9seUdldFJlZ2lvblByb2dyZXNzQ3NSZXEucHJvdG8iIAoeTW9u" + "b3BvbHlHZXRSZWdpb25Qcm9ncmVzc0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGetRegionProgressCsReq), MonopolyGetRegionProgressCsReq.Parser, null, null, null, null, null)
		}));
	}
}
