using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CCGEOHGFAFDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CCGEOHGFAFDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQ0dFT0hHRkFGRC5wcm90byJCCgtDQ0dFT0hHRkFGRBIRCgl1bmlxdWVf" + "aWQYASABKA0SEwoLSkNNRlBITUZBT04YAiABKA0SCwoDcG9zGAMgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CCGEOHGFAFD), CCGEOHGFAFD.Parser, new string[3] { "UniqueId", "JCMFPHMFAON", "Pos" }, null, null, null, null)
		}));
	}
}
