using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MIOMFOAEHEC : IMessage<MIOMFOAEHEC>, IMessage, IEquatable<MIOMFOAEHEC>, IDeepCloneable<MIOMFOAEHEC>, IBufferMessage
{
	private static readonly MessageParser<MIOMFOAEHEC> _parser = new MessageParser<MIOMFOAEHEC>(() => new MIOMFOAEHEC());

	private UnknownFieldSet _unknownFields;

	public const int IPHHGMECAKBFieldNumber = 5;

	private BLKAIEHOCBC iPHHGMECAKB_;

	public const int MAGCGPMHHEAFieldNumber = 6;

	private uint mAGCGPMHHEA_;

	public const int IJAEBDCFEMGFieldNumber = 12;

	private BLKAIEHOCBC iJAEBDCFEMG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MIOMFOAEHEC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MIOMFOAEHECReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLKAIEHOCBC IPHHGMECAKB
	{
		get
		{
			return iPHHGMECAKB_;
		}
		set
		{
			iPHHGMECAKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAGCGPMHHEA
	{
		get
		{
			return mAGCGPMHHEA_;
		}
		set
		{
			mAGCGPMHHEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLKAIEHOCBC IJAEBDCFEMG
	{
		get
		{
			return iJAEBDCFEMG_;
		}
		set
		{
			iJAEBDCFEMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIOMFOAEHEC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIOMFOAEHEC(MIOMFOAEHEC other)
		: this()
	{
		iPHHGMECAKB_ = ((other.iPHHGMECAKB_ != null) ? other.iPHHGMECAKB_.Clone() : null);
		mAGCGPMHHEA_ = other.mAGCGPMHHEA_;
		iJAEBDCFEMG_ = ((other.iJAEBDCFEMG_ != null) ? other.iJAEBDCFEMG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIOMFOAEHEC Clone()
	{
		return new MIOMFOAEHEC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MIOMFOAEHEC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MIOMFOAEHEC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IPHHGMECAKB, other.IPHHGMECAKB))
		{
			return false;
		}
		if (MAGCGPMHHEA != other.MAGCGPMHHEA)
		{
			return false;
		}
		if (!object.Equals(IJAEBDCFEMG, other.IJAEBDCFEMG))
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
		if (iPHHGMECAKB_ != null)
		{
			num ^= IPHHGMECAKB.GetHashCode();
		}
		if (MAGCGPMHHEA != 0)
		{
			num ^= MAGCGPMHHEA.GetHashCode();
		}
		if (iJAEBDCFEMG_ != null)
		{
			num ^= IJAEBDCFEMG.GetHashCode();
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
		if (iPHHGMECAKB_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(IPHHGMECAKB);
		}
		if (MAGCGPMHHEA != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(MAGCGPMHHEA);
		}
		if (iJAEBDCFEMG_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(IJAEBDCFEMG);
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
		if (iPHHGMECAKB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IPHHGMECAKB);
		}
		if (MAGCGPMHHEA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAGCGPMHHEA);
		}
		if (iJAEBDCFEMG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IJAEBDCFEMG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MIOMFOAEHEC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iPHHGMECAKB_ != null)
		{
			if (iPHHGMECAKB_ == null)
			{
				IPHHGMECAKB = new BLKAIEHOCBC();
			}
			IPHHGMECAKB.MergeFrom(other.IPHHGMECAKB);
		}
		if (other.MAGCGPMHHEA != 0)
		{
			MAGCGPMHHEA = other.MAGCGPMHHEA;
		}
		if (other.iJAEBDCFEMG_ != null)
		{
			if (iJAEBDCFEMG_ == null)
			{
				IJAEBDCFEMG = new BLKAIEHOCBC();
			}
			IJAEBDCFEMG.MergeFrom(other.IJAEBDCFEMG);
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
			case 42u:
				if (iPHHGMECAKB_ == null)
				{
					IPHHGMECAKB = new BLKAIEHOCBC();
				}
				input.ReadMessage(IPHHGMECAKB);
				break;
			case 48u:
				MAGCGPMHHEA = input.ReadUInt32();
				break;
			case 98u:
				if (iJAEBDCFEMG_ == null)
				{
					IJAEBDCFEMG = new BLKAIEHOCBC();
				}
				input.ReadMessage(IJAEBDCFEMG);
				break;
			}
		}
	}
}
