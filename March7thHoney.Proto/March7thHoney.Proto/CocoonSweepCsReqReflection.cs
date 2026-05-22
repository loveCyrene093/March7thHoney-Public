using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CocoonSweepCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CocoonSweepCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZDb2Nvb25Td2VlcENzUmVxLnByb3RvIjoKEENvY29vblN3ZWVwQ3NSZXES" + "EQoJY29jb29uX2lkGAQgASgNEhMKC3dvcmxkX2xldmVsGAwgASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CocoonSweepCsReq), CocoonSweepCsReq.Parser, new string[2] { "CocoonId", "WorldLevel" }, null, null, null, null)
		}));
	}
}
