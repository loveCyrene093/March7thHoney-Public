using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RechargeSuccNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RechargeSuccNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChhSZWNoYXJnZVN1Y2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnByb3RvInwK";
		buffer[1] = "ElJlY2hhcmdlU3VjY05vdGlmeRISCgpwcmljZV90aWVyGAMgASgJEiAKGG1v";
		buffer[2] = "bnRoX2NhcmRfb3V0X2RhdGVfdGltZRgEIAEoBBISCgpwcm9kdWN0X2lkGAgg";
		buffer[3] = "ASgJEhwKCWl0ZW1fbGlzdBgMIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0";
		buffer[4] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RechargeSuccNotify), RechargeSuccNotify.Parser, new string[4] { "PriceTier", "MonthCardOutDateTime", "ProductId", "ItemList" }, null, null, null, null)
		}));
	}
}
