using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DCFMPNBKKPFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DCFMPNBKKPFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQ0ZNUE5CS0tQRi5wcm90bxoRQ0NLTE1OQ1BHRk8ucHJvdG8aEU5BR0VK" + "TUlHQkJMLnByb3RvIlMKC0RDRk1QTkJLS1BGEiEKC0dMQlBGSkdKRkVFGAEg" + "ASgLMgwuTkFHRUpNSUdCQkwSIQoLQkZQR0JMQUlLSEYYAiABKAsyDC5DQ0tM" + "TU5DUEdGT0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			CCKLMNCPGFOReflection.Descriptor,
			NAGEJMIGBBLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DCFMPNBKKPF), DCFMPNBKKPF.Parser, new string[2] { "GLBPFJGJFEE", "BFPGBLAIKHF" }, null, null, null, null)
		}));
	}
}
