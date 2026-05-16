using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MADEENABOKE : IMessage<MADEENABOKE>, IMessage, IEquatable<MADEENABOKE>, IDeepCloneable<MADEENABOKE>, IBufferMessage
{
	private static readonly MessageParser<MADEENABOKE> _parser = new MessageParser<MADEENABOKE>(() => new MADEENABOKE());

	private UnknownFieldSet _unknownFields;

	public const int GPKABIBKJHFFieldNumber = 2;

	private static readonly FieldCodec<ChargerInfo> _repeated_gPKABIBKJHF_codec = FieldCodec.ForMessage(18u, ChargerInfo.Parser);

	private readonly RepeatedField<ChargerInfo> gPKABIBKJHF_ = new RepeatedField<ChargerInfo>();

	public const int EnergyInfoFieldNumber = 4;

	private RotaterEnergyInfo energyInfo_;

	public const int JHDLNBPNEKGFieldNumber = 5;

	private int jHDLNBPNEKG_;

	public const int DJHDDOFHMCFFieldNumber = 6;

	private static readonly FieldCodec<RotaterData> _repeated_dJHDDOFHMCF_codec = FieldCodec.ForMessage(50u, RotaterData.Parser);

	private readonly RepeatedField<RotaterData> dJHDDOFHMCF_ = new RepeatedField<RotaterData>();

	public const int AOLFFOLEJLBFieldNumber = 11;

	private bool aOLFFOLEJLB_;

	public const int BCPCBHMFIINFieldNumber = 13;

	private uint bCPCBHMFIIN_;

	public const int AMMJECHPGPEFieldNumber = 15;

	private RotateMapInfo aMMJECHPGPE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MADEENABOKE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MADEENABOKEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ChargerInfo> GPKABIBKJHF => gPKABIBKJHF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotaterEnergyInfo EnergyInfo
	{
		get
		{
			return energyInfo_;
		}
		set
		{
			energyInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int JHDLNBPNEKG
	{
		get
		{
			return jHDLNBPNEKG_;
		}
		set
		{
			jHDLNBPNEKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RotaterData> DJHDDOFHMCF => dJHDDOFHMCF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AOLFFOLEJLB
	{
		get
		{
			return aOLFFOLEJLB_;
		}
		set
		{
			aOLFFOLEJLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCPCBHMFIIN
	{
		get
		{
			return bCPCBHMFIIN_;
		}
		set
		{
			bCPCBHMFIIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotateMapInfo AMMJECHPGPE
	{
		get
		{
			return aMMJECHPGPE_;
		}
		set
		{
			aMMJECHPGPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MADEENABOKE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MADEENABOKE(MADEENABOKE other)
		: this()
	{
		gPKABIBKJHF_ = other.gPKABIBKJHF_.Clone();
		energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
		jHDLNBPNEKG_ = other.jHDLNBPNEKG_;
		dJHDDOFHMCF_ = other.dJHDDOFHMCF_.Clone();
		aOLFFOLEJLB_ = other.aOLFFOLEJLB_;
		bCPCBHMFIIN_ = other.bCPCBHMFIIN_;
		aMMJECHPGPE_ = ((other.aMMJECHPGPE_ != null) ? other.aMMJECHPGPE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MADEENABOKE Clone()
	{
		return new MADEENABOKE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MADEENABOKE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MADEENABOKE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gPKABIBKJHF_.Equals(other.gPKABIBKJHF_))
		{
			return false;
		}
		if (!object.Equals(EnergyInfo, other.EnergyInfo))
		{
			return false;
		}
		if (JHDLNBPNEKG != other.JHDLNBPNEKG)
		{
			return false;
		}
		if (!dJHDDOFHMCF_.Equals(other.dJHDDOFHMCF_))
		{
			return false;
		}
		if (AOLFFOLEJLB != other.AOLFFOLEJLB)
		{
			return false;
		}
		if (BCPCBHMFIIN != other.BCPCBHMFIIN)
		{
			return false;
		}
		if (!object.Equals(AMMJECHPGPE, other.AMMJECHPGPE))
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
		num ^= gPKABIBKJHF_.GetHashCode();
		if (energyInfo_ != null)
		{
			num ^= EnergyInfo.GetHashCode();
		}
		if (JHDLNBPNEKG != 0)
		{
			num ^= JHDLNBPNEKG.GetHashCode();
		}
		num ^= dJHDDOFHMCF_.GetHashCode();
		if (AOLFFOLEJLB)
		{
			num ^= AOLFFOLEJLB.GetHashCode();
		}
		if (BCPCBHMFIIN != 0)
		{
			num ^= BCPCBHMFIIN.GetHashCode();
		}
		if (aMMJECHPGPE_ != null)
		{
			num ^= AMMJECHPGPE.GetHashCode();
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
		gPKABIBKJHF_.WriteTo(ref output, _repeated_gPKABIBKJHF_codec);
		if (energyInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(EnergyInfo);
		}
		if (JHDLNBPNEKG != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(JHDLNBPNEKG);
		}
		dJHDDOFHMCF_.WriteTo(ref output, _repeated_dJHDDOFHMCF_codec);
		if (AOLFFOLEJLB)
		{
			output.WriteRawTag(88);
			output.WriteBool(AOLFFOLEJLB);
		}
		if (BCPCBHMFIIN != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BCPCBHMFIIN);
		}
		if (aMMJECHPGPE_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(AMMJECHPGPE);
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
		num += gPKABIBKJHF_.CalculateSize(_repeated_gPKABIBKJHF_codec);
		if (energyInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnergyInfo);
		}
		if (JHDLNBPNEKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(JHDLNBPNEKG);
		}
		num += dJHDDOFHMCF_.CalculateSize(_repeated_dJHDDOFHMCF_codec);
		if (AOLFFOLEJLB)
		{
			num += 2;
		}
		if (BCPCBHMFIIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCPCBHMFIIN);
		}
		if (aMMJECHPGPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AMMJECHPGPE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MADEENABOKE other)
	{
		if (other == null)
		{
			return;
		}
		gPKABIBKJHF_.Add(other.gPKABIBKJHF_);
		if (other.energyInfo_ != null)
		{
			if (energyInfo_ == null)
			{
				EnergyInfo = new RotaterEnergyInfo();
			}
			EnergyInfo.MergeFrom(other.EnergyInfo);
		}
		if (other.JHDLNBPNEKG != 0)
		{
			JHDLNBPNEKG = other.JHDLNBPNEKG;
		}
		dJHDDOFHMCF_.Add(other.dJHDDOFHMCF_);
		if (other.AOLFFOLEJLB)
		{
			AOLFFOLEJLB = other.AOLFFOLEJLB;
		}
		if (other.BCPCBHMFIIN != 0)
		{
			BCPCBHMFIIN = other.BCPCBHMFIIN;
		}
		if (other.aMMJECHPGPE_ != null)
		{
			if (aMMJECHPGPE_ == null)
			{
				AMMJECHPGPE = new RotateMapInfo();
			}
			AMMJECHPGPE.MergeFrom(other.AMMJECHPGPE);
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
			case 18u:
				gPKABIBKJHF_.AddEntriesFrom(ref input, _repeated_gPKABIBKJHF_codec);
				break;
			case 34u:
				if (energyInfo_ == null)
				{
					EnergyInfo = new RotaterEnergyInfo();
				}
				input.ReadMessage(EnergyInfo);
				break;
			case 40u:
				JHDLNBPNEKG = input.ReadInt32();
				break;
			case 50u:
				dJHDDOFHMCF_.AddEntriesFrom(ref input, _repeated_dJHDDOFHMCF_codec);
				break;
			case 88u:
				AOLFFOLEJLB = input.ReadBool();
				break;
			case 104u:
				BCPCBHMFIIN = input.ReadUInt32();
				break;
			case 122u:
				if (aMMJECHPGPE_ == null)
				{
					AMMJECHPGPE = new RotateMapInfo();
				}
				input.ReadMessage(AMMJECHPGPE);
				break;
			}
		}
	}
}
