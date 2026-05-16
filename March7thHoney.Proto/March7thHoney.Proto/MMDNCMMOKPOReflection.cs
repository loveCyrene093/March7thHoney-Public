using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MMDNCMMOKPOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MMDNCMMOKPOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTUROQ01NT0tQTy5wcm90bypHCgtNTUROQ01NT0tQTxIbChdNTUROQ01N" + "T0tQT19CQlBBRUhFRkpIRBAAEhsKF01NRE5DTU1PS1BPX0RNR0RNQ09BQ0dG" + "EAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MMDNCMMOKPO) }, null, null));
	}
}
