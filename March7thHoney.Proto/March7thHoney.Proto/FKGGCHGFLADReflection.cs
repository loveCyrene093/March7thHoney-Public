using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FKGGCHGFLADReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FKGGCHGFLADReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGS0dHQ0hHRkxBRC5wcm90byJYCgtGS0dHQ0hHRkxBRBITCgtBT05HT0VB" + "RktPQxgDIAEoDRIKCgJpZBgHIAEoDRITCgtMTUlJQ0VOTU9CSRgKIAEoDRIT" + "CgtESExES0xNUEhORxgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FKGGCHGFLAD), FKGGCHGFLAD.Parser, new string[4] { "AONGOEAFKOC", "Id", "LMIICENMOBI", "DHLDKLMPHNG" }, null, null, null, null)
		}));
	}
}
