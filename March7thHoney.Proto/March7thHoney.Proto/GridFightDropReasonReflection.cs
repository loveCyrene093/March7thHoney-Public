using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightDropReasonReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightDropReasonReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHcmlkRmlnaHREcm9wUmVhc29uLnByb3RvKmwKE0dyaWRGaWdodERyb3BS" + "ZWFzb24SGwoXSU1QTUxBREpJTkRfR0RLQktDRkpETUcQABIbChdJTVBNTEFE" + "SklORF9DTEFDSkJISkNJRRABEhsKF0lNUE1MQURKSU5EX0tNRElCRU1GSUJK" + "EAJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GridFightDropReason) }, null, null));
	}
}
