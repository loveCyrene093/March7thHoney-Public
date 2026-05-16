using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FDMMAAHEFPKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FDMMAAHEFPKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRE1NQUFIRUZQSy5wcm90bypkCgtGRE1NQUFIRUZQSxIbChdGRE1NQUFI" + "RUZQS19PQUZDTVBIQktLTBAAEhsKF0ZETU1BQUhFRlBLX0RHTkZFTk1NSElJ" + "EAESGwoXRkRNTUFBSEVGUEtfSEtFUEFQQkxLRUcQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FDMMAAHEFPK) }, null, null));
	}
}
