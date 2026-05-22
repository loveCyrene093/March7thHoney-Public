using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IDHNJFPAEGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IDHNJFPAEGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJREhOSkZQQUVHUC5wcm90bxoRRFBGSFBJTFBOT04ucHJvdG8iVQoLSURI" + "TkpGUEFFR1ASHAoGc3RhdHVzGAMgASgOMgwuRFBGSFBJTFBOT04SEwoLRk5M" + "TlBMSE9FSk4YCyABKA0SEwoLQU5BTU9MQkRDT0wYDiABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { DPFHPILPNONReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IDHNJFPAEGP), IDHNJFPAEGP.Parser, new string[3] { "Status", "FNLNPLHOEJN", "ANAMOLBDCOL" }, null, null, null, null)
		}));
	}
}
