using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PICILIIFKBEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PICILIIFKBEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQSUNJTElJRktCRS5wcm90byI1CgtQSUNJTElJRktCRRITCgtETU1GTU5L" + "SEZISBgDIAEoDRIRCglzY3JpcHRfaWQYDSABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PICILIIFKBE), PICILIIFKBE.Parser, new string[2] { "DMMFMNKHFHH", "ScriptId" }, null, null, null, null)
		}));
	}
}
