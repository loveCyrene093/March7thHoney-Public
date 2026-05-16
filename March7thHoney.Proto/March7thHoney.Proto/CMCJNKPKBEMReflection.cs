using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CMCJNKPKBEMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CMCJNKPKBEMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTUNKTktQS0JFTS5wcm90byJ1CgtDTUNKTktQS0JFTRIyCgtDRk5QR05N" + "UE5EThgPIAMoCzIdLkNNQ0pOS1BLQkVNLkNGTlBHTk1QTkRORW50cnkaMgoQ" + "Q0ZOUEdOTVBORE5FbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKA06" + "AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CMCJNKPKBEM), CMCJNKPKBEM.Parser, new string[1] { "CFNPGNMPNDN" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
