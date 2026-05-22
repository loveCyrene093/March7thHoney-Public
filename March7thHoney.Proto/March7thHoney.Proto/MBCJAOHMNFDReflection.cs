using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MBCJAOHMNFDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MBCJAOHMNFDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQkNKQU9ITU5GRC5wcm90byJyCgtNQkNKQU9ITU5GRBISCgpoYXNfcGFz" + "c2VkGAEgASgIEhAKCGV2ZW50X2lkGAIgASgNEhMKC0hBQUFQRkxHTkJNGAQg" + "ASgNEhMKC0JJTUtIQUJMR01DGAogASgNEhMKC0xJRk5HRkpERUZEGA4gASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MBCJAOHMNFD), MBCJAOHMNFD.Parser, new string[5] { "HasPassed", "EventId", "HAAAPFLGNBM", "BIMKHABLGMC", "LIFNGFJDEFD" }, null, null, null, null)
		}));
	}
}
