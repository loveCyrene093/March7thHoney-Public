using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BGNGLHHBGMI : IMessage<BGNGLHHBGMI>, IMessage, IEquatable<BGNGLHHBGMI>, IDeepCloneable<BGNGLHHBGMI>, IBufferMessage
{
	private static readonly MessageParser<BGNGLHHBGMI> _parser = new MessageParser<BGNGLHHBGMI>(() => new BGNGLHHBGMI());

	private UnknownFieldSet _unknownFields;

	public const int IPDCMHIEKIJFieldNumber = 1;

	private uint iPDCMHIEKIJ_;

	public const int EIHHLAOKAPHFieldNumber = 2;

	private GAPBBJCLMGP eIHHLAOKAPH_;

	public const int GDNIKJGAEBHFieldNumber = 3;

	private uint gDNIKJGAEBH_;

	public const int GridUpdateSrcFieldNumber = 4;

	private PFODGDGFBBN gridUpdateSrc_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BGNGLHHBGMI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BGNGLHHBGMIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPDCMHIEKIJ
	{
		get
		{
			return iPDCMHIEKIJ_;
		}
		set
		{
			iPDCMHIEKIJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GAPBBJCLMGP EIHHLAOKAPH
	{
		get
		{
			return eIHHLAOKAPH_;
		}
		set
		{
			eIHHLAOKAPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GDNIKJGAEBH
	{
		get
		{
			return gDNIKJGAEBH_;
		}
		set
		{
			gDNIKJGAEBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFODGDGFBBN GridUpdateSrc
	{
		get
		{
			return gridUpdateSrc_;
		}
		set
		{
			gridUpdateSrc_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGNGLHHBGMI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGNGLHHBGMI(BGNGLHHBGMI other)
		: this()
	{
		iPDCMHIEKIJ_ = other.iPDCMHIEKIJ_;
		eIHHLAOKAPH_ = other.eIHHLAOKAPH_;
		gDNIKJGAEBH_ = other.gDNIKJGAEBH_;
		gridUpdateSrc_ = other.gridUpdateSrc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGNGLHHBGMI Clone()
	{
		return new BGNGLHHBGMI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BGNGLHHBGMI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BGNGLHHBGMI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IPDCMHIEKIJ != other.IPDCMHIEKIJ)
		{
			return false;
		}
		if (EIHHLAOKAPH != other.EIHHLAOKAPH)
		{
			return false;
		}
		if (GDNIKJGAEBH != other.GDNIKJGAEBH)
		{
			return false;
		}
		if (GridUpdateSrc != other.GridUpdateSrc)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (IPDCMHIEKIJ != 0)
		{
			num ^= IPDCMHIEKIJ.GetHashCode();
		}
		if (EIHHLAOKAPH != GAPBBJCLMGP.Fhmigjbigfc)
		{
			num ^= EIHHLAOKAPH.GetHashCode();
		}
		if (GDNIKJGAEBH != 0)
		{
			num ^= GDNIKJGAEBH.GetHashCode();
		}
		if (GridUpdateSrc != PFODGDGFBBN.Gmiiofmfmpo)
		{
			num ^= GridUpdateSrc.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (IPDCMHIEKIJ != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IPDCMHIEKIJ);
		}
		if (EIHHLAOKAPH != GAPBBJCLMGP.Fhmigjbigfc)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EIHHLAOKAPH);
		}
		if (GDNIKJGAEBH != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GDNIKJGAEBH);
		}
		if (GridUpdateSrc != PFODGDGFBBN.Gmiiofmfmpo)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)GridUpdateSrc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (IPDCMHIEKIJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPDCMHIEKIJ);
		}
		if (EIHHLAOKAPH != GAPBBJCLMGP.Fhmigjbigfc)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EIHHLAOKAPH);
		}
		if (GDNIKJGAEBH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDNIKJGAEBH);
		}
		if (GridUpdateSrc != PFODGDGFBBN.Gmiiofmfmpo)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GridUpdateSrc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BGNGLHHBGMI other)
	{
		if (other != null)
		{
			if (other.IPDCMHIEKIJ != 0)
			{
				IPDCMHIEKIJ = other.IPDCMHIEKIJ;
			}
			if (other.EIHHLAOKAPH != GAPBBJCLMGP.Fhmigjbigfc)
			{
				EIHHLAOKAPH = other.EIHHLAOKAPH;
			}
			if (other.GDNIKJGAEBH != 0)
			{
				GDNIKJGAEBH = other.GDNIKJGAEBH;
			}
			if (other.GridUpdateSrc != PFODGDGFBBN.Gmiiofmfmpo)
			{
				GridUpdateSrc = other.GridUpdateSrc;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				IPDCMHIEKIJ = input.ReadUInt32();
				break;
			case 16u:
				EIHHLAOKAPH = (GAPBBJCLMGP)input.ReadEnum();
				break;
			case 24u:
				GDNIKJGAEBH = input.ReadUInt32();
				break;
			case 32u:
				GridUpdateSrc = (PFODGDGFBBN)input.ReadEnum();
				break;
			}
		}
	}
}
