using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPlotTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPlotTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDbWRQbG90VHlwZS5wcm90bypYCgtDbWRQbG90VHlwZRIbChdLRkZES0dN" + "S1BLTF9QQ1BESEVMUEtFTRAAEhcKEkNtZEZpbmlzaFBsb3RDc1JlcRCnCRIT" + "Cg5DbWRGRUZKSkZFTU1GRRDWCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPlotType) }, null, null));
	}
}
