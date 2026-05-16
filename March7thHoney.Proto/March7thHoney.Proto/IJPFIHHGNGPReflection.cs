using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IJPFIHHGNGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IJPFIHHGNGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJSlBGSUhIR05HUC5wcm90bxoRQk1PRUVLR0NKQUQucHJvdG8iYwoLSUpQ" + "RklISEdOR1ASEwoLRktGSkFDRk1LS04YBCABKA0SEwoLSUdMT1BPTktIS00Y" + "CiABKA0SKgoUZXF1aXBtZW50X2dvb2RzX2luZm8YDiABKAsyDC5CTU9FRUtH" + "Q0pBREIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BMOEEKGCJADReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IJPFIHHGNGP), IJPFIHHGNGP.Parser, new string[3] { "FKFJACFMKKN", "IGLOPONKHKM", "EquipmentGoodsInfo" }, null, null, null, null)
		}));
	}
}
