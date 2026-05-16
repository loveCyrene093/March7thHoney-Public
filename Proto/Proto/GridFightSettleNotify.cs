using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSettleNotify : IMessage<GridFightSettleNotify>, IMessage, IEquatable<GridFightSettleNotify>, IDeepCloneable<GridFightSettleNotify>, IBufferMessage
{
	private static readonly MessageParser<GridFightSettleNotify> _parser = new MessageParser<GridFightSettleNotify>(() => new GridFightSettleNotify());

	private UnknownFieldSet _unknownFields;

	public const int IIGMOIGOELBFieldNumber = 3;

	private uint iIGMOIGOELB_;

	public const int PGMJPLLNIAKFieldNumber = 5;

	private uint pGMJPLLNIAK_;

	public const int EDKIICIKJKLFieldNumber = 6;

	private uint eDKIICIKJKL_;

	public const int EDIGFNFPBKAFieldNumber = 7;

	private uint eDIGFNFPBKA_;

	public const int BHLDAEKNMCDFieldNumber = 9;

	private uint bHLDAEKNMCD_;

	public const int OHOPKAAKOGFFieldNumber = 12;

	private uint oHOPKAAKOGF_;

	public const int CAMLDAJJKBOFieldNumber = 32;

	private uint cAMLDAJJKBO_;

	public const int EDKJMPACHNJFieldNumber = 214;

	private GridFightFinishInfo eDKJMPACHNJ_;

	public const int HIFNCPPJFENFieldNumber = 668;

	private uint hIFNCPPJFEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSettleNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSettleNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IIGMOIGOELB
	{
		get
		{
			return iIGMOIGOELB_;
		}
		set
		{
			iIGMOIGOELB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PGMJPLLNIAK
	{
		get
		{
			return pGMJPLLNIAK_;
		}
		set
		{
			pGMJPLLNIAK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDKIICIKJKL
	{
		get
		{
			return eDKIICIKJKL_;
		}
		set
		{
			eDKIICIKJKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDIGFNFPBKA
	{
		get
		{
			return eDIGFNFPBKA_;
		}
		set
		{
			eDIGFNFPBKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BHLDAEKNMCD
	{
		get
		{
			return bHLDAEKNMCD_;
		}
		set
		{
			bHLDAEKNMCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OHOPKAAKOGF
	{
		get
		{
			return oHOPKAAKOGF_;
		}
		set
		{
			oHOPKAAKOGF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CAMLDAJJKBO
	{
		get
		{
			return cAMLDAJJKBO_;
		}
		set
		{
			cAMLDAJJKBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightFinishInfo EDKJMPACHNJ
	{
		get
		{
			return eDKJMPACHNJ_;
		}
		set
		{
			eDKJMPACHNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HIFNCPPJFEN
	{
		get
		{
			return hIFNCPPJFEN_;
		}
		set
		{
			hIFNCPPJFEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSettleNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSettleNotify(GridFightSettleNotify other)
		: this()
	{
		iIGMOIGOELB_ = other.iIGMOIGOELB_;
		pGMJPLLNIAK_ = other.pGMJPLLNIAK_;
		eDKIICIKJKL_ = other.eDKIICIKJKL_;
		eDIGFNFPBKA_ = other.eDIGFNFPBKA_;
		bHLDAEKNMCD_ = other.bHLDAEKNMCD_;
		oHOPKAAKOGF_ = other.oHOPKAAKOGF_;
		cAMLDAJJKBO_ = other.cAMLDAJJKBO_;
		eDKJMPACHNJ_ = ((other.eDKJMPACHNJ_ != null) ? other.eDKJMPACHNJ_.Clone() : null);
		hIFNCPPJFEN_ = other.hIFNCPPJFEN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSettleNotify Clone()
	{
		return new GridFightSettleNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSettleNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSettleNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IIGMOIGOELB != other.IIGMOIGOELB)
		{
			return false;
		}
		if (PGMJPLLNIAK != other.PGMJPLLNIAK)
		{
			return false;
		}
		if (EDKIICIKJKL != other.EDKIICIKJKL)
		{
			return false;
		}
		if (EDIGFNFPBKA != other.EDIGFNFPBKA)
		{
			return false;
		}
		if (BHLDAEKNMCD != other.BHLDAEKNMCD)
		{
			return false;
		}
		if (OHOPKAAKOGF != other.OHOPKAAKOGF)
		{
			return false;
		}
		if (CAMLDAJJKBO != other.CAMLDAJJKBO)
		{
			return false;
		}
		if (!object.Equals(EDKJMPACHNJ, other.EDKJMPACHNJ))
		{
			return false;
		}
		if (HIFNCPPJFEN != other.HIFNCPPJFEN)
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
		if (IIGMOIGOELB != 0)
		{
			num ^= IIGMOIGOELB.GetHashCode();
		}
		if (PGMJPLLNIAK != 0)
		{
			num ^= PGMJPLLNIAK.GetHashCode();
		}
		if (EDKIICIKJKL != 0)
		{
			num ^= EDKIICIKJKL.GetHashCode();
		}
		if (EDIGFNFPBKA != 0)
		{
			num ^= EDIGFNFPBKA.GetHashCode();
		}
		if (BHLDAEKNMCD != 0)
		{
			num ^= BHLDAEKNMCD.GetHashCode();
		}
		if (OHOPKAAKOGF != 0)
		{
			num ^= OHOPKAAKOGF.GetHashCode();
		}
		if (CAMLDAJJKBO != 0)
		{
			num ^= CAMLDAJJKBO.GetHashCode();
		}
		if (eDKJMPACHNJ_ != null)
		{
			num ^= EDKJMPACHNJ.GetHashCode();
		}
		if (HIFNCPPJFEN != 0)
		{
			num ^= HIFNCPPJFEN.GetHashCode();
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
		if (IIGMOIGOELB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IIGMOIGOELB);
		}
		if (PGMJPLLNIAK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PGMJPLLNIAK);
		}
		if (EDKIICIKJKL != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(EDKIICIKJKL);
		}
		if (EDIGFNFPBKA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EDIGFNFPBKA);
		}
		if (BHLDAEKNMCD != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(BHLDAEKNMCD);
		}
		if (OHOPKAAKOGF != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(OHOPKAAKOGF);
		}
		if (CAMLDAJJKBO != 0)
		{
			output.WriteRawTag(128, 2);
			output.WriteUInt32(CAMLDAJJKBO);
		}
		if (eDKJMPACHNJ_ != null)
		{
			output.WriteRawTag(178, 13);
			output.WriteMessage(EDKJMPACHNJ);
		}
		if (HIFNCPPJFEN != 0)
		{
			output.WriteRawTag(224, 41);
			output.WriteUInt32(HIFNCPPJFEN);
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
		if (IIGMOIGOELB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIGMOIGOELB);
		}
		if (PGMJPLLNIAK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGMJPLLNIAK);
		}
		if (EDKIICIKJKL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDKIICIKJKL);
		}
		if (EDIGFNFPBKA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDIGFNFPBKA);
		}
		if (BHLDAEKNMCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BHLDAEKNMCD);
		}
		if (OHOPKAAKOGF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OHOPKAAKOGF);
		}
		if (CAMLDAJJKBO != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(CAMLDAJJKBO);
		}
		if (eDKJMPACHNJ_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(EDKJMPACHNJ);
		}
		if (HIFNCPPJFEN != 0)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(HIFNCPPJFEN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSettleNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IIGMOIGOELB != 0)
		{
			IIGMOIGOELB = other.IIGMOIGOELB;
		}
		if (other.PGMJPLLNIAK != 0)
		{
			PGMJPLLNIAK = other.PGMJPLLNIAK;
		}
		if (other.EDKIICIKJKL != 0)
		{
			EDKIICIKJKL = other.EDKIICIKJKL;
		}
		if (other.EDIGFNFPBKA != 0)
		{
			EDIGFNFPBKA = other.EDIGFNFPBKA;
		}
		if (other.BHLDAEKNMCD != 0)
		{
			BHLDAEKNMCD = other.BHLDAEKNMCD;
		}
		if (other.OHOPKAAKOGF != 0)
		{
			OHOPKAAKOGF = other.OHOPKAAKOGF;
		}
		if (other.CAMLDAJJKBO != 0)
		{
			CAMLDAJJKBO = other.CAMLDAJJKBO;
		}
		if (other.eDKJMPACHNJ_ != null)
		{
			if (eDKJMPACHNJ_ == null)
			{
				EDKJMPACHNJ = new GridFightFinishInfo();
			}
			EDKJMPACHNJ.MergeFrom(other.EDKJMPACHNJ);
		}
		if (other.HIFNCPPJFEN != 0)
		{
			HIFNCPPJFEN = other.HIFNCPPJFEN;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 24u:
				IIGMOIGOELB = input.ReadUInt32();
				break;
			case 40u:
				PGMJPLLNIAK = input.ReadUInt32();
				break;
			case 48u:
				EDKIICIKJKL = input.ReadUInt32();
				break;
			case 56u:
				EDIGFNFPBKA = input.ReadUInt32();
				break;
			case 72u:
				BHLDAEKNMCD = input.ReadUInt32();
				break;
			case 96u:
				OHOPKAAKOGF = input.ReadUInt32();
				break;
			case 256u:
				CAMLDAJJKBO = input.ReadUInt32();
				break;
			case 1714u:
				if (eDKJMPACHNJ_ == null)
				{
					EDKJMPACHNJ = new GridFightFinishInfo();
				}
				input.ReadMessage(EDKJMPACHNJ);
				break;
			case 5344u:
				HIFNCPPJFEN = input.ReadUInt32();
				break;
			}
		}
	}
}
