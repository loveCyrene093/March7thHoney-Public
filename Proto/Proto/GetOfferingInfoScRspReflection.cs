using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetOfferingInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetOfferingInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRPZmZlcmluZ0luZm9TY1JzcC5wcm90bxoST2ZmZXJpbmdJbmZvLnBy" + "b3RvIlIKFEdldE9mZmVyaW5nSW5mb1NjUnNwEg8KB3JldGNvZGUYAiABKA0S" + "KQoSb2ZmZXJpbmdfaW5mb19saXN0GAMgAygLMg0uT2ZmZXJpbmdJbmZvQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { OfferingInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetOfferingInfoScRsp), GetOfferingInfoScRsp.Parser, new string[2] { "Retcode", "OfferingInfoList" }, null, null, null, null)
		}));
	}
}
