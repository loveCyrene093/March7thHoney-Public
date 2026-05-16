using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LGLGCCJEKCLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LGLGCCJEKCLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMR0xHQ0NKRUtDTC5wcm90byJ9CgtMR0xHQ0NKRUtDTBITCgtLSERMTVBB" + "S0VHRhgHIAEoAhITCgtOSUtFRURMSkhQRBgIIAEoCBIOCgZhcmdfaWQYCyAB" + "KA0SEwoLQkdKS0JQTkNOTEUYDCABKAUSHwoXcm9ndWVfZGlhbG9ndWVfZXZl" + "bnRfaWQYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LGLGCCJEKCL), LGLGCCJEKCL.Parser, new string[5] { "KHDLMPAKEGF", "NIKEEDLJHPD", "ArgId", "BGJKBPNCNLE", "RogueDialogueEventId" }, null, null, null, null)
		}));
	}
}
