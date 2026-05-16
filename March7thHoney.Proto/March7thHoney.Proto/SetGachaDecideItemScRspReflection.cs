using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetGachaDecideItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetGachaDecideItemScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TZXRHYWNoYURlY2lkZUl0ZW1TY1JzcC5wcm90bxoRT0VJRUpIQkNPT00u" + "cHJvdG8iTQoXU2V0R2FjaGFEZWNpZGVJdGVtU2NSc3ASDwoHcmV0Y29kZRgC" + "IAEoDRIhCgtMRUNQSkpBTU5QRhgIIAEoCzIMLk9FSUVKSEJDT09NQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { OEIEJHBCOOMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetGachaDecideItemScRsp), SetGachaDecideItemScRsp.Parser, new string[2] { "Retcode", "LECPJJAMNPF" }, null, null, null, null)
		}));
	}
}
