using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetHeartDialInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetHeartDialInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRIZWFydERpYWxJbmZvQ3NSZXEucHJvdG8iFwoVR2V0SGVhcnREaWFs" + "SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetHeartDialInfoCsReq), GetHeartDialInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
