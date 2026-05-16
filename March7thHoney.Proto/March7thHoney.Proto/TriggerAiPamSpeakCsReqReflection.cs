using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TriggerAiPamSpeakCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TriggerAiPamSpeakCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUcmlnZ2VyQWlQYW1TcGVha0NzUmVxLnByb3RvIi0KFlRyaWdnZXJBaVBh" + "bVNwZWFrQ3NSZXESEwoLQ0VISkpHRUlNQ0wYCyABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TriggerAiPamSpeakCsReq), TriggerAiPamSpeakCsReq.Parser, new string[1] { "CEHJJGEIMCL" }, null, null, null, null)
		}));
	}
}
