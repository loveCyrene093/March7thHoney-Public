using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetOfferingInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetOfferingInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRPZmZlcmluZ0luZm9Dc1JlcS5wcm90byIwChRHZXRPZmZlcmluZ0lu" + "Zm9Dc1JlcRIYChBvZmZlcmluZ19pZF9saXN0GAwgAygNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetOfferingInfoCsReq), GetOfferingInfoCsReq.Parser, new string[1] { "OfferingIdList" }, null, null, null, null)
		}));
	}
}
