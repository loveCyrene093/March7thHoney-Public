using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EPLGMCCNALGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EPLGMCCNALGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFUExHTUNDTkFMRy5wcm90bxoRTEtCR09NR0hHTEcucHJvdG8iVQoLRVBM" + "R01DQ05BTEcSHAoGc3RhdHVzGAYgASgOMgwuTEtCR09NR0hHTEcSEwoLTk9G" + "TE5JTUJET0YYDSABKA0SEwoLTUtCSU9BTlBNS0UYDiABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { LKBGOMGHGLGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EPLGMCCNALG), EPLGMCCNALG.Parser, new string[3] { "Status", "NOFLNIMBDOF", "MKBIOANPMKE" }, null, null, null, null)
		}));
	}
}
