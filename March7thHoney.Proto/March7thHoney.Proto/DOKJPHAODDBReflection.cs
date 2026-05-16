using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DOKJPHAODDBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DOKJPHAODDBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFET0tKUEhBT0REQi5wcm90byI3CgtET0tKUEhBT0REQhITCgtJR01IUEpL" + "QU1NQhgDIAEoDRITCgtGQklIS0ZETkpKThgHIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DOKJPHAODDB), DOKJPHAODDB.Parser, new string[2] { "IGMHPJKAMMB", "FBIHKFDNJJN" }, null, null, null, null)
		}));
	}
}
