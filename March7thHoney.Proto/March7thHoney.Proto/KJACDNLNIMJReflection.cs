using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KJACDNLNIMJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KJACDNLNIMJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSkFDRE5MTklNSi5wcm90byItCgtLSkFDRE5MTklNShIPCgdzaG9wX2lk" + "GAEgASgNEg0KBWxldmVsGAIgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KJACDNLNIMJ), KJACDNLNIMJ.Parser, new string[2] { "ShopId", "Level" }, null, null, null, null)
		}));
	}
}
