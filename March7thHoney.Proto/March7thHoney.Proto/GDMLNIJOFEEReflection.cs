using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GDMLNIJOFEEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GDMLNIJOFEEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHRE1MTklKT0ZFRS5wcm90byJ2CgtHRE1MTklKT0ZFRRITCgtGRUxFUEtD" + "QUZQQRgEIAEoCBITCgtBREtCRU9QTkJJTxgHIAEoCBIXCg9pc190YWtlbl9y" + "ZXdhcmQYCCABKAgSEwoLQ0VCUEFKQUFKUFAYCiABKAgSDwoHYXJlYV9pZBgL" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GDMLNIJOFEE), GDMLNIJOFEE.Parser, new string[5] { "FELEPKCAFPA", "ADKBEOPNBIO", "IsTakenReward", "CEBPAJAAJPP", "AreaId" }, null, null, null, null)
		}));
	}
}
