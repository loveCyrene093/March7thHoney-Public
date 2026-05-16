using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DECAOHONNJGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DECAOHONNJGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFERUNBT0hPTk5KRy5wcm90bxoRQ0FFQUJISk5MTUkucHJvdG8iMAoLREVD" + "QU9IT05OSkcSIQoLR0JIUEhDTUdCR0sYByADKAsyDC5DQUVBQkhKTkxNSUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { CAEABHJNLMIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DECAOHONNJG), DECAOHONNJG.Parser, new string[1] { "GBHPHCMGBGK" }, null, null, null, null)
		}));
	}
}
