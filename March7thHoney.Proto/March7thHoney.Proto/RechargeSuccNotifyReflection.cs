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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChhSZWNoYXJnZVN1Y2NOb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnByb3RvInwK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ElJlY2hhcmdlU3VjY05vdGlmeRISCgpwcmljZV90aWVyGAMgASgJEiAKGG1v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "bnRoX2NhcmRfb3V0X2RhdGVfdGltZRgEIAEoBBISCgpwcm9kdWN0X2lkGAgg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ASgJEhwKCWl0ZW1fbGlzdBgMIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RechargeSuccNotify), RechargeSuccNotify.Parser, new string[4] { "PriceTier", "MonthCardOutDateTime", "ProductId", "ItemList" }, null, null, null, null)
		}));
	}
}
