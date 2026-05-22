using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KEHGPHDBOBDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KEHGPHDBOBDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRUhHUEhEQk9CRC5wcm90bxoOSXRlbUxpc3QucHJvdG8iVwoLS0VIR1BI" + "REJPQkQSEwoLRUlJQUdBQkFGRUMYAiABKA0SHgoLQUlHTE9CRlBFQUIYBiAB" + "KAsyCS5JdGVtTGlzdBITCgtKQUZOQ09NR0FCRxgPIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KEHGPHDBOBD), KEHGPHDBOBD.Parser, new string[3] { "EIIAGABAFEC", "AIGLOBFPEAB", "JAFNCOMGABG" }, null, null, null, null)
		}));
	}
}
