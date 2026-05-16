using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GFADBCMGFFFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GFADBCMGFFFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHRkFEQkNNR0ZGRi5wcm90bxoRS0ZHQVBMRExIUEYucHJvdG8iQgoLR0ZB" + "REJDTUdGRkYSIQoLSEJORUNFRUxKQkoYAyADKAsyDC5LRkdBUExETEhQRhIQ" + "CghwYW5lbF9pZBgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[1] { KFGAPLDLHPFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GFADBCMGFFF), GFADBCMGFFF.Parser, new string[2] { "HBNECEELJBJ", "PanelId" }, null, null, null, null)
		}));
	}
}
