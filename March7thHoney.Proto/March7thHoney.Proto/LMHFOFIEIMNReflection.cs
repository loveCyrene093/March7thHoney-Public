using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LMHFOFIEIMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LMHFOFIEIMNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTUhGT0ZJRUlNTi5wcm90byJNCgtMTUhGT0ZJRUlNThITCgtPT1BPQURO" + "SEFCSxgFIAEoDRIUCgxkaWNlX3Nsb3RfaWQYCyABKA0SEwoLTkpNT05HS0xK" + "SkMYDyABKANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LMHFOFIEIMN), LMHFOFIEIMN.Parser, new string[3] { "OOPOADNHABK", "DiceSlotId", "NJMONGKLJJC" }, null, null, null, null)
		}));
	}
}
