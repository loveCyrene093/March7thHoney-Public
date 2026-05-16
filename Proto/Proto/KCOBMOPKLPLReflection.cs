using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KCOBMOPKLPLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KCOBMOPKLPLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLQ09CTU9QS0xQTC5wcm90byIwCgtLQ09CTU9QS0xQTBIQCghldmVudF9p" + "ZBgKIAEoDRIPCgdyZXRjb2RlGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KCOBMOPKLPL), KCOBMOPKLPL.Parser, new string[2] { "EventId", "Retcode" }, null, null, null, null)
		}));
	}
}
