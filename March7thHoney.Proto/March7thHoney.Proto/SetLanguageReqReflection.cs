using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetLanguageReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetLanguageReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTZXRMYW5ndWFnZVJlcS5wcm90bxoSTGFuZ3VhZ2VUeXBlLnByb3RvIjQK" + "DlNldExhbmd1YWdlUmVxEiIKC0JOUEdLREFFSlBCGAsgASgOMg0uTGFuZ3Vh" + "Z2VUeXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { LanguageTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetLanguageReq), SetLanguageReq.Parser, new string[1] { "BNPGKDAEJPB" }, null, null, null, null)
		}));
	}
}
