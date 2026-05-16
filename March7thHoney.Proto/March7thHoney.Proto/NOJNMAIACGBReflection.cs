using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NOJNMAIACGBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NOJNMAIACGBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOT0pOTUFJQUNHQi5wcm90bxoRQUdCTExGR09CS0UucHJvdG8iUAoLTk9K" + "Tk1BSUFDR0ISEQoJdW5pcXVlX2lkGAEgASgFEhkKA3BvcxgHIAEoCzIMLkFH" + "QkxMRkdPQktFEhMKC0ZHTUxNS0tDTUpNGAsgASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { AGBLLFGOBKEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NOJNMAIACGB), NOJNMAIACGB.Parser, new string[3] { "UniqueId", "Pos", "FGMLMKKCMJM" }, null, null, null, null)
		}));
	}
}
