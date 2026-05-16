using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LNMBJPJONPEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LNMBJPJONPEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTk1CSlBKT05QRS5wcm90byJECgtMTk1CSlBKT05QRRINCgV2YWx1ZRgH" + "IAEoBRIRCgl1bmlxdWVfaWQYCSABKA0SEwoLUEdIREtGUEdQSUgYDCABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LNMBJPJONPE), LNMBJPJONPE.Parser, new string[3] { "Value", "UniqueId", "PGHDKFPGPIH" }, null, null, null, null)
		}));
	}
}
