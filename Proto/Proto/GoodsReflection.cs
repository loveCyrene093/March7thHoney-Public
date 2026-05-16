using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GoodsReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GoodsReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgtHb29kcy5wcm90byJjCgVHb29kcxIQCghlbmRfdGltZRgBIAEoAxISCgpi" + "ZWdpbl90aW1lGAkgASgDEhEKCWJ1eV90aW1lcxgKIAEoDRIQCghnb29kc19p" + "ZBgNIAEoDRIPCgdpdGVtX2lkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Goods), Goods.Parser, new string[5] { "EndTime", "BeginTime", "BuyTimes", "GoodsId", "ItemId" }, null, null, null, null)
		}));
	}
}
