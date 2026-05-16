using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPunkLordMonsterDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPunkLordMonsterDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRQdW5rTG9yZE1vbnN0ZXJEYXRhQ3NSZXEucHJvdG8iHQobR2V0UHVu" + "a0xvcmRNb25zdGVyRGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPunkLordMonsterDataCsReq), GetPunkLordMonsterDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
