using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TravelBrochureSetCustomValueCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TravelBrochureSetCustomValueCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidUcmF2ZWxCcm9jaHVyZVNldEN1c3RvbVZhbHVlQ3NSZXEucHJvdG8iMgoh" + "VHJhdmVsQnJvY2h1cmVTZXRDdXN0b21WYWx1ZUNzUmVxEg0KBXZhbHVlGAwg" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureSetCustomValueCsReq), TravelBrochureSetCustomValueCsReq.Parser, new string[1] { "Value" }, null, null, null, null)
		}));
	}
}
