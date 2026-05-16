using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdTarotBookTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdTarotBookTypeReflection()
	{
		InlineArray16<string> buffer = default(InlineArray16<string>);
		buffer[0] = "ChZDbWRUYXJvdEJvb2tUeXBlLnByb3RvKo0FChBDbWRUYXJvdEJvb2tUeXBl";
		buffer[1] = "EhsKF09FTEtDR0FESkJHX1BDUERIRUxQS0VNEAASJwoiQ21kVGFyb3RCb29r";
		buffer[2] = "RmluaXNoSW50ZXJhY3Rpb25Dc1JlcRDfPxIlCiBDbWRUYXJvdEJvb2tNb2Rp";
		buffer[3] = "ZnlFbmVyZ3lTY05vdGlmeRDTPxIhChxDbWRUYXJvdEJvb2tTeW5jRGF0YVNj";
		buffer[4] = "Tm90aWZ5EM8/EiEKHENtZFRhcm90Qm9va0ZpbmlzaFN0b3J5Q3NSZXEQ2j8S";
		buffer[5] = "JwoiQ21kVGFyb3RCb29rVW5sb2NrSW50ZXJhY3Rpb25Dc1JlcRDePxIhChxD";
		buffer[6] = "bWRUYXJvdEJvb2tGaW5pc2hTdG9yeVNjUnNwEN0/Eh0KGENtZFRhcm90Qm9v";
		buffer[7] = "a0dldERhdGFDc1JlcRDNPxIxCixDbWRUYXJvdEJvb2tNdWx0aU9wZW5QYWNr";
		buffer[8] = "QW5kVW5sb2NrU3RvcnlDc1JlcRDVPxIdChhDbWRUYXJvdEJvb2tHZXREYXRh";
		buffer[9] = "U2NSc3AQ4D8SHgoZQ21kVGFyb3RCb29rT3BlblBhY2tDc1JlcRDOPxIeChlD";
		buffer[10] = "bWRUYXJvdEJvb2tPcGVuUGFja1NjUnNwENY/EiEKHENtZFRhcm90Qm9va1Vu";
		buffer[11] = "bG9ja1N0b3J5U2NSc3AQ1D8SMQosQ21kVGFyb3RCb29rTXVsdGlPcGVuUGFj";
		buffer[12] = "a0FuZFVubG9ja1N0b3J5U2NSc3AQ2T8SJwoiQ21kVGFyb3RCb29rRmluaXNo";
		buffer[13] = "SW50ZXJhY3Rpb25TY1JzcBDXPxInCiJDbWRUYXJvdEJvb2tVbmxvY2tJbnRl";
		buffer[14] = "cmFjdGlvblNjUnNwENA/EiEKHENtZFRhcm90Qm9va1VubG9ja1N0b3J5Q3NS";
		buffer[15] = "ZXEQ2z9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdTarotBookType) }, null, null));
	}
}
