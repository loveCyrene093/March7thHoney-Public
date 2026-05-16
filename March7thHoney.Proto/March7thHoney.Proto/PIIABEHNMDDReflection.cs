using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PIIABEHNMDDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PIIABEHNMDDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQSUlBQkVITk1ERC5wcm90byI2CgtQSUlBQkVITk1ERBISCgppdGVtX2Nv" + "dW50GAggASgNEhMKC0VHSU1QRkhDQ0RKGAwgASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PIIABEHNMDD), PIIABEHNMDD.Parser, new string[2] { "ItemCount", "EGIMPFHCCDJ" }, null, null, null, null)
		}));
	}
}
