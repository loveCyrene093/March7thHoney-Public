using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MMPOOBGAEKEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MMPOOBGAEKEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTVBPT0JHQUVLRS5wcm90bxoRRElDSktKTkVOQ1AucHJvdG8iQAoLTU1Q" + "T09CR0FFS0USEwoLTUtCSU9BTlBNS0UYCCABKA0SHAoGc3RhdHVzGAsgASgO" + "MgwuRElDSktKTkVOQ1BCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { DICJKJNENCPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MMPOOBGAEKE), MMPOOBGAEKE.Parser, new string[2] { "MKBIOANPMKE", "Status" }, null, null, null, null)
		}));
	}
}
