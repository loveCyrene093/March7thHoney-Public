using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HipplenAgendaResultScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HipplenAgendaResultScNotifyReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "CiFIaXBwbGVuQWdlbmRhUmVzdWx0U2NOb3RpZnkucHJvdG8aEURHS05ETUFI";
		buffer[1] = "TUFQLnByb3RvGhFFS09JSE9NRk1ERS5wcm90bxoRRU9LT0ZGUEJKTUUucHJv";
		buffer[2] = "dG8aEU9PTEhORk5LT0hOLnByb3RvIvIBChtIaXBwbGVuQWdlbmRhUmVzdWx0";
		buffer[3] = "U2NOb3RpZnkSHQoVZ3JpZF9maWdodF90cmFpdF9pbmZvGAEgAygNEiEKC0pQ";
		buffer[4] = "RkJHRklIRERIGAMgASgLMgwuREdLTkRNQUhNQVASEwoLQUVQREdETE1QTUQY";
		buffer[5] = "CCABKAgSEwoLRkNDRUhPTEhGT0MYCSADKA0SIQoLS0JOTElQT0dPTEUYCiAB";
		buffer[6] = "KAsyDC5FT0tPRkZQQkpNRRIhCgtDTEtBSUxEQ1BKQxgMIAMoCzIMLkVLT0lI";
		buffer[7] = "T01GTURFEiEKC0FDSkhHTEdIRUFIGA4gASgLMgwuT09MSE5GTktPSE5CFqoC";
		buffer[8] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			DGKNDMAHMAPReflection.Descriptor,
			EKOIHOMFMDEReflection.Descriptor,
			EOKOFFPBJMEReflection.Descriptor,
			OOLHNFNKOHNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HipplenAgendaResultScNotify), HipplenAgendaResultScNotify.Parser, new string[7] { "GridFightTraitInfo", "JPFBGFIHDDH", "AEPDGDLMPMD", "FCCEHOLHFOC", "KBNLIPOGOLE", "CLKAILDCPJC", "ACJHGLGHEAH" }, null, null, null, null)
		}));
	}
}
