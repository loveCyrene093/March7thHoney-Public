using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceStartPveCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceStartPveCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDYWtlUmFjZVN0YXJ0UHZlQ3NSZXEucHJvdG8iLAoVQ2FrZVJhY2VTdGFy" + "dFB2ZUNzUmVxEhMKC0pBRk5DT01HQUJHGAIgASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceStartPveCsReq), CakeRaceStartPveCsReq.Parser, new string[1] { "JAFNCOMGABG" }, null, null, null, null)
		}));
	}
}
