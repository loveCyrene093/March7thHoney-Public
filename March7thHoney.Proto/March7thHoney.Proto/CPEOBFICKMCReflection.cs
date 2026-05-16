using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CPEOBFICKMCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CPEOBFICKMCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDUEVPQkZJQ0tNQy5wcm90bypHCgtDUEVPQkZJQ0tNQxIbChdDUEVPQkZJ" + "Q0tNQ19JQUNISkRDTEpFSBAAEhsKF0NQRU9CRklDS01DX05QR0lHUE1FSEJI" + "EAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CPEOBFICKMC) }, null, null));
	}
}
