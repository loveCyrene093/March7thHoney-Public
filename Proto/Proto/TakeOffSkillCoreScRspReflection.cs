using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeOffSkillCoreScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeOffSkillCoreScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtUYWtlT2ZmU2tpbGxDb3JlU2NSc3AucHJvdG8aEUpCSklLSkdFQkFILnBy";
		buffer[1] = "b3RvGhFLTkhLQkhBREpHRS5wcm90byJuChVUYWtlT2ZmU2tpbGxDb3JlU2NS";
		buffer[2] = "c3ASDwoHcmV0Y29kZRgCIAEoDRIhCgtHQ05ET0lNQUNBThgLIAEoCzIMLkpC";
		buffer[3] = "SklLSkdFQkFIEiEKC0hLT0hJSENCR0FBGA0gASgLMgwuS05IS0JIQURKR0VC";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			JBJIKJGEBAHReflection.Descriptor,
			KNHKBHADJGEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeOffSkillCoreScRsp), TakeOffSkillCoreScRsp.Parser, new string[3] { "Retcode", "GCNDOIMACAN", "HKOHIHCBGAA" }, null, null, null, null)
		}));
	}
}
