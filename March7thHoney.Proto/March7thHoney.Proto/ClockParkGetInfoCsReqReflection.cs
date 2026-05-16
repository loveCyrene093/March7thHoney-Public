using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClockParkGetInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClockParkGetInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDbG9ja1BhcmtHZXRJbmZvQ3NSZXEucHJvdG8iFwoVQ2xvY2tQYXJrR2V0" + "SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkGetInfoCsReq), ClockParkGetInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
