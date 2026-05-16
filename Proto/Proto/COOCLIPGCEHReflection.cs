using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class COOCLIPGCEHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static COOCLIPGCEHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDT09DTElQR0NFSC5wcm90bypkCgtDT09DTElQR0NFSBIbChdDT09DTElQ" + "R0NFSF9QQ1BESEVMUEtFTRAAEhsKF0NPT0NMSVBHQ0VIX0VJS0dITUlFS1BF" + "EAESGwoXQ09PQ0xJUEdDRUhfQ0dER0pCTERLTlAQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(COOCLIPGCEH) }, null, null));
	}
}
