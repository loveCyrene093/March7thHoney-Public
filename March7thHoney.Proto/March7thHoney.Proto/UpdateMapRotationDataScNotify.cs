using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateMapRotationDataScNotify : IMessage<UpdateMapRotationDataScNotify>, IMessage, IEquatable<UpdateMapRotationDataScNotify>, IDeepCloneable<UpdateMapRotationDataScNotify>, IBufferMessage
{
	private static readonly MessageParser<UpdateMapRotationDataScNotify> _parser = new MessageParser<UpdateMapRotationDataScNotify>(() => new UpdateMapRotationDataScNotify());

	private UnknownFieldSet _unknownFields;

	public const int BCPCBHMFIINFieldNumber = 2;

	private uint bCPCBHMFIIN_;

	public const int GPKABIBKJHFFieldNumber = 4;

	private static readonly FieldCodec<ChargerInfo> _repeated_gPKABIBKJHF_codec = FieldCodec.ForMessage(34u, ChargerInfo.Parser);

	private readonly RepeatedField<ChargerInfo> gPKABIBKJHF_ = new RepeatedField<ChargerInfo>();

	public const int DIMOGLIMLBDFieldNumber = 5;

	private bool dIMOGLIMLBD_;

	public const int JHDLNBPNEKGFieldNumber = 8;

	private int jHDLNBPNEKG_;

	public const int AMMJECHPGPEFieldNumber = 12;

	private RotateMapInfo aMMJECHPGPE_;

	public const int DJHDDOFHMCFFieldNumber = 14;

	private static readonly FieldCodec<RotaterData> _repeated_dJHDDOFHMCF_codec = FieldCodec.ForMessage(114u, RotaterData.Parser);

	private readonly RepeatedField<RotaterData> dJHDDOFHMCF_ = new RepeatedField<RotaterData>();

	public const int EnergyInfoFieldNumber = 15;

	private RotaterEnergyInfo energyInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateMapRotationDataScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateMapRotationDataScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<ChargerInfo> GPKABIBKJHF => gPKABIBKJHF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DIMOGLIMLBD
	{
		get
		{
			return dIMOGLIMLBD_;
		}
		set
		{
			dIMOGLIMLBD_ = value;
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
	public RepeatedField<RotaterData> DJHDDOFHMCF => dJHDDOFHMCF_;

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
	public UpdateMapRotationDataScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMapRotationDataScNotify(UpdateMapRotationDataScNotify other)
		: this()
	{
		bCPCBHMFIIN_ = other.bCPCBHMFIIN_;
		gPKABIBKJHF_ = other.gPKABIBKJHF_.Clone();
		dIMOGLIMLBD_ = other.dIMOGLIMLBD_;
		jHDLNBPNEKG_ = other.jHDLNBPNEKG_;
		aMMJECHPGPE_ = ((other.aMMJECHPGPE_ != null) ? other.aMMJECHPGPE_.Clone() : null);
		dJHDDOFHMCF_ = other.dJHDDOFHMCF_.Clone();
		energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMapRotationDataScNotify Clone()
	{
		return new UpdateMapRotationDataScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateMapRotationDataScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateMapRotationDataScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BCPCBHMFIIN != other.BCPCBHMFIIN)
		{
			return false;
		}
		if (!gPKABIBKJHF_.Equals(other.gPKABIBKJHF_))
		{
			return false;
		}
		if (DIMOGLIMLBD != other.DIMOGLIMLBD)
		{
			return false;
		}
		if (JHDLNBPNEKG != other.JHDLNBPNEKG)
		{
			return false;
		}
		if (!object.Equals(AMMJECHPGPE, other.AMMJECHPGPE))
		{
			return false;
		}
		if (!dJHDDOFHMCF_.Equals(other.dJHDDOFHMCF_))
		{
			return false;
		}
		if (!object.Equals(EnergyInfo, other.EnergyInfo))
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
		if (BCPCBHMFIIN != 0)
		{
			num ^= BCPCBHMFIIN.GetHashCode();
		}
		num ^= gPKABIBKJHF_.GetHashCode();
		if (DIMOGLIMLBD)
		{
			num ^= DIMOGLIMLBD.GetHashCode();
		}
		if (JHDLNBPNEKG != 0)
		{
			num ^= JHDLNBPNEKG.GetHashCode();
		}
		if (aMMJECHPGPE_ != null)
		{
			num ^= AMMJECHPGPE.GetHashCode();
		}
		num ^= dJHDDOFHMCF_.GetHashCode();
		if (energyInfo_ != null)
		{
			num ^= EnergyInfo.GetHashCode();
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
		if (BCPCBHMFIIN != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(BCPCBHMFIIN);
		}
		gPKABIBKJHF_.WriteTo(ref output, _repeated_gPKABIBKJHF_codec);
		if (DIMOGLIMLBD)
		{
			output.WriteRawTag(40);
			output.WriteBool(DIMOGLIMLBD);
		}
		if (JHDLNBPNEKG != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(JHDLNBPNEKG);
		}
		if (aMMJECHPGPE_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(AMMJECHPGPE);
		}
		dJHDDOFHMCF_.WriteTo(ref output, _repeated_dJHDDOFHMCF_codec);
		if (energyInfo_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(EnergyInfo);
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
		if (BCPCBHMFIIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCPCBHMFIIN);
		}
		num += gPKABIBKJHF_.CalculateSize(_repeated_gPKABIBKJHF_codec);
		if (DIMOGLIMLBD)
		{
			num += 2;
		}
		if (JHDLNBPNEKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(JHDLNBPNEKG);
		}
		if (aMMJECHPGPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AMMJECHPGPE);
		}
		num += dJHDDOFHMCF_.CalculateSize(_repeated_dJHDDOFHMCF_codec);
		if (energyInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnergyInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateMapRotationDataScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BCPCBHMFIIN != 0)
		{
			BCPCBHMFIIN = other.BCPCBHMFIIN;
		}
		gPKABIBKJHF_.Add(other.gPKABIBKJHF_);
		if (other.DIMOGLIMLBD)
		{
			DIMOGLIMLBD = other.DIMOGLIMLBD;
		}
		if (other.JHDLNBPNEKG != 0)
		{
			JHDLNBPNEKG = other.JHDLNBPNEKG;
		}
		if (other.aMMJECHPGPE_ != null)
		{
			if (aMMJECHPGPE_ == null)
			{
				AMMJECHPGPE = new RotateMapInfo();
			}
			AMMJECHPGPE.MergeFrom(other.AMMJECHPGPE);
		}
		dJHDDOFHMCF_.Add(other.dJHDDOFHMCF_);
		if (other.energyInfo_ != null)
		{
			if (energyInfo_ == null)
			{
				EnergyInfo = new RotaterEnergyInfo();
			}
			EnergyInfo.MergeFrom(other.EnergyInfo);
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
			case 16u:
				BCPCBHMFIIN = input.ReadUInt32();
				break;
			case 34u:
				gPKABIBKJHF_.AddEntriesFrom(ref input, _repeated_gPKABIBKJHF_codec);
				break;
			case 40u:
				DIMOGLIMLBD = input.ReadBool();
				break;
			case 64u:
				JHDLNBPNEKG = input.ReadInt32();
				break;
			case 98u:
				if (aMMJECHPGPE_ == null)
				{
					AMMJECHPGPE = new RotateMapInfo();
				}
				input.ReadMessage(AMMJECHPGPE);
				break;
			case 114u:
				dJHDDOFHMCF_.AddEntriesFrom(ref input, _repeated_dJHDDOFHMCF_codec);
				break;
			case 122u:
				if (energyInfo_ == null)
				{
					EnergyInfo = new RotaterEnergyInfo();
				}
				input.ReadMessage(EnergyInfo);
				break;
			}
		}
	}
}
