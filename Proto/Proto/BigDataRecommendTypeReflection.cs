using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BigDataRecommendTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BigDataRecommendTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChpCaWdEYXRhUmVjb21tZW5kVHlwZS5wcm90byq2AwoUQmlnRGF0YVJlY29t";
		buffer[1] = "bWVuZFR5cGUSIAocQklHX0RBVEFfUkVDT01NRU5EX1RZUEVfTk9ORRAAEiUK";
		buffer[2] = "IUJJR19EQVRBX1JFQ09NTUVORF9UWVBFX0VRVUlQTUVOVBABEiYKIkJJR19E";
		buffer[3] = "QVRBX1JFQ09NTUVORF9UWVBFX1JFTElDX1NVSVQQAhIoCiRCSUdfREFUQV9S";
		buffer[4] = "RUNPTU1FTkRfVFlQRV9SRUxJQ19BVkFUQVIQAxIoCiRCSUdfREFUQV9SRUNP";
		buffer[5] = "TU1FTkRfVFlQRV9BVkFUQVJfUkVMSUMQBBIoCiRCSUdfREFUQV9SRUNPTU1F";
		buffer[6] = "TkRfVFlQRV9MT0NBTF9MRUdFTkQQBRIuCipCSUdfREFUQV9SRUNPTU1FTkRf";
		buffer[7] = "VFlQRV9DSEFMTEVOR0VfUEVBS19NT0IQBhIvCitCSUdfREFUQV9SRUNPTU1F";
		buffer[8] = "TkRfVFlQRV9DSEFMTEVOR0VfUEVBS19CT1NTEAcSJQohQklHX0RBVEFfUkVD";
		buffer[9] = "T01NRU5EX1RZUEVfQ0hBTExFTkdFEAgSJwojQklHX0RBVEFfUkVDT01NRU5E";
		buffer[10] = "X1RZUEVfSE1GRkJJQU5LQkYQCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[11] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BigDataRecommendType) }, null, null));
	}
}
