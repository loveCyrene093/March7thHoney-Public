using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectPamSkinCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectPamSkinCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZWxlY3RQYW1Ta2luQ3NSZXEucHJvdG8iJgoSU2VsZWN0UGFtU2tpbkNz" + "UmVxEhAKCHBhbV9za2luGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectPamSkinCsReq), SelectPamSkinCsReq.Parser, new string[1] { "PamSkin" }, null, null, null, null)
		}));
	}
}
