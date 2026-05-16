using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KNNODAPAKJAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KNNODAPAKJAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTk5PREFQQUtKQS5wcm90bxoRQUZGSU1CR0JNQkoucHJvdG8iWgoLS05O" + "T0RBUEFLSkESEwoLT09EUERFQklDSEYYAyABKA0SEwoLSklMQUFERUZOR0QY" + "BCADKA0SIQoLUEFEREVKRExGTEEYByADKAsyDC5BRkZJTUJHQk1CSkIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { AFFIMBGBMBJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KNNODAPAKJA), KNNODAPAKJA.Parser, new string[3] { "OODPDEBICHF", "JILAADEFNGD", "PADDEJDLFLA" }, null, null, null, null)
		}));
	}
}
