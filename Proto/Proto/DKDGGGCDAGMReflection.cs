using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DKDGGGCDAGMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DKDGGGCDAGMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFES0RHR0dDREFHTS5wcm90bxoRS05DQklNQUFGSkcucHJvdG8iWgoLREtE" + "R0dHQ0RBR00SIQoLTU5ORE1QQkZQSkUYBSADKAsyDC5LTkNCSU1BQUZKRxIT" + "CgtPRkZJRE1FSkJHSRgJIAEoDRITCgtNRUtMSUtMR0FGSRgLIAMoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { KNCBIMAAFJGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DKDGGGCDAGM), DKDGGGCDAGM.Parser, new string[3] { "MNNDMPBFPJE", "OFFIDMEJBGI", "MEKLIKLGAFI" }, null, null, null, null)
		}));
	}
}
