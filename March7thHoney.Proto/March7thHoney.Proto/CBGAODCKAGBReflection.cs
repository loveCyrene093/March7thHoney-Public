using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CBGAODCKAGBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CBGAODCKAGBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQkdBT0RDS0FHQi5wcm90byI3CgtDQkdBT0RDS0FHQhITCgtPT1BPQURO" + "SEFCSxgKIAEoDRITCgtOSk1PTkdLTEpKQxgNIAEoA0IWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CBGAODCKAGB), CBGAODCKAGB.Parser, new string[2] { "OOPOADNHABK", "NJMONGKLJJC" }, null, null, null, null)
		}));
	}
}
