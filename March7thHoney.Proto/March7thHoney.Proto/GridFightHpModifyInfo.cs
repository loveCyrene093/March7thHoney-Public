using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightHpModifyInfo : IMessage<GridFightHpModifyInfo>, IMessage, IEquatable<GridFightHpModifyInfo>, IDeepCloneable<GridFightHpModifyInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightHpModifyInfo> _parser = new MessageParser<GridFightHpModifyInfo>(() => new GridFightHpModifyInfo());

	private UnknownFieldSet _unknownFields;

	public const int ReasonFieldNumber = 1;

	private GridFightUpdateGlobalHpReason reason_;

	public const int PDEKDHPNCENFieldNumber = 6;

	private uint pDEKDHPNCEN_;

	public const int FGEDKOINMAGFieldNumber = 8;

	private int fGEDKOINMAG_;

	public const int HPOPDNGCALLFieldNumber = 9;

	private uint hPOPDNGCALL_;

	public const int EHMKLNEKIOEFieldNumber = 11;

	private int eHMKLNEKIOE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightHpModifyInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightHpModifyInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightUpdateGlobalHpReason Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PDEKDHPNCEN
	{
		get
		{
			return pDEKDHPNCEN_;
		}
		set
		{
			pDEKDHPNCEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FGEDKOINMAG
	{
		get
		{
			return fGEDKOINMAG_;
		}
		set
		{
			fGEDKOINMAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HPOPDNGCALL
	{
		get
		{
			return hPOPDNGCALL_;
		}
		set
		{
			hPOPDNGCALL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EHMKLNEKIOE
	{
		get
		{
			return eHMKLNEKIOE_;
		}
		set
		{
			eHMKLNEKIOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHpModifyInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHpModifyInfo(GridFightHpModifyInfo other)
		: this()
	{
		reason_ = other.reason_;
		pDEKDHPNCEN_ = other.pDEKDHPNCEN_;
		fGEDKOINMAG_ = other.fGEDKOINMAG_;
		hPOPDNGCALL_ = other.hPOPDNGCALL_;
		eHMKLNEKIOE_ = other.eHMKLNEKIOE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHpModifyInfo Clone()
	{
		return new GridFightHpModifyInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightHpModifyInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightHpModifyInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (PDEKDHPNCEN != other.PDEKDHPNCEN)
		{
			return false;
		}
		if (FGEDKOINMAG != other.FGEDKOINMAG)
		{
			return false;
		}
		if (HPOPDNGCALL != other.HPOPDNGCALL)
		{
			return false;
		}
		if (EHMKLNEKIOE != other.EHMKLNEKIOE)
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
		if (Reason != GridFightUpdateGlobalHpReason.BakggpnhnneAjbmadndigh)
		{
			num ^= Reason.GetHashCode();
		}
		if (PDEKDHPNCEN != 0)
		{
			num ^= PDEKDHPNCEN.GetHashCode();
		}
		if (FGEDKOINMAG != 0)
		{
			num ^= FGEDKOINMAG.GetHashCode();
		}
		if (HPOPDNGCALL != 0)
		{
			num ^= HPOPDNGCALL.GetHashCode();
		}
		if (EHMKLNEKIOE != 0)
		{
			num ^= EHMKLNEKIOE.GetHashCode();
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
		if (Reason != GridFightUpdateGlobalHpReason.BakggpnhnneAjbmadndigh)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Reason);
		}
		if (PDEKDHPNCEN != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PDEKDHPNCEN);
		}
		if (FGEDKOINMAG != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(FGEDKOINMAG);
		}
		if (HPOPDNGCALL != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(HPOPDNGCALL);
		}
		if (EHMKLNEKIOE != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(EHMKLNEKIOE);
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
		if (Reason != GridFightUpdateGlobalHpReason.BakggpnhnneAjbmadndigh)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (PDEKDHPNCEN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PDEKDHPNCEN);
		}
		if (FGEDKOINMAG != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FGEDKOINMAG);
		}
		if (HPOPDNGCALL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HPOPDNGCALL);
		}
		if (EHMKLNEKIOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EHMKLNEKIOE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightHpModifyInfo other)
	{
		if (other != null)
		{
			if (other.Reason != GridFightUpdateGlobalHpReason.BakggpnhnneAjbmadndigh)
			{
				Reason = other.Reason;
			}
			if (other.PDEKDHPNCEN != 0)
			{
				PDEKDHPNCEN = other.PDEKDHPNCEN;
			}
			if (other.FGEDKOINMAG != 0)
			{
				FGEDKOINMAG = other.FGEDKOINMAG;
			}
			if (other.HPOPDNGCALL != 0)
			{
				HPOPDNGCALL = other.HPOPDNGCALL;
			}
			if (other.EHMKLNEKIOE != 0)
			{
				EHMKLNEKIOE = other.EHMKLNEKIOE;
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
				Reason = (GridFightUpdateGlobalHpReason)input.ReadEnum();
				break;
			case 48u:
				PDEKDHPNCEN = input.ReadUInt32();
				break;
			case 64u:
				FGEDKOINMAG = input.ReadInt32();
				break;
			case 72u:
				HPOPDNGCALL = input.ReadUInt32();
				break;
			case 88u:
				EHMKLNEKIOE = input.ReadInt32();
				break;
			}
		}
	}
}
