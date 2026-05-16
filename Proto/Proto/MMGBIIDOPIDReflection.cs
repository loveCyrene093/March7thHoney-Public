using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MMGBIIDOPIDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MMGBIIDOPIDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTUdCSUlET1BJRC5wcm90bxoRRERLSEVGRUJGQUoucHJvdG8iXwoLTU1H" + "QklJRE9QSUQSEwoLQ0xBRk5ETEdEQU8YByABKA0SGAoQaXRlbV9zdGFja19j" + "b3VudBgMIAEoDRIhCgtNSkRNTE9JSExQQRgPIAEoDjIMLkRES0hFRkVCRkFK" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { DDKHEFEBFAJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MMGBIIDOPID), MMGBIIDOPID.Parser, new string[3] { "CLAFNDLGDAO", "ItemStackCount", "MJDMLOIHLPA" }, null, null, null, null)
		}));
	}
}
