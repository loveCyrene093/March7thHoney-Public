using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMapRotationDataScRsp : IMessage<GetMapRotationDataScRsp>, IMessage, IEquatable<GetMapRotationDataScRsp>, IDeepCloneable<GetMapRotationDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetMapRotationDataScRsp> _parser = new MessageParser<GetMapRotationDataScRsp>(() => new GetMapRotationDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int EnergyInfoFieldNumber = 2;

	private RotaterEnergyInfo energyInfo_;

	public const int GPKABIBKJHFFieldNumber = 3;

	private static readonly FieldCodec<ChargerInfo> _repeated_gPKABIBKJHF_codec = FieldCodec.ForMessage(26u, ChargerInfo.Parser);

	private readonly RepeatedField<ChargerInfo> gPKABIBKJHF_ = new RepeatedField<ChargerInfo>();

	public const int JHDLNBPNEKGFieldNumber = 4;

	private int jHDLNBPNEKG_;

	public const int BCPCBHMFIINFieldNumber = 5;

	private uint bCPCBHMFIIN_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int DJHDDOFHMCFFieldNumber = 9;

	private static readonly FieldCodec<RotaterData> _repeated_dJHDDOFHMCF_codec = FieldCodec.ForMessage(74u, RotaterData.Parser);

	private readonly RepeatedField<RotaterData> dJHDDOFHMCF_ = new RepeatedField<RotaterData>();

	public const int DIMOGLIMLBDFieldNumber = 10;

	private bool dIMOGLIMLBD_;

	public const int AMMJECHPGPEFieldNumber = 13;

	private RotateMapInfo aMMJECHPGPE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMapRotationDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMapRotationDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<ChargerInfo> GPKABIBKJHF => gPKABIBKJHF_;

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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<RotaterData> DJHDDOFHMCF => dJHDDOFHMCF_;

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
	public GetMapRotationDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMapRotationDataScRsp(GetMapRotationDataScRsp other)
		: this()
	{
		energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
		gPKABIBKJHF_ = other.gPKABIBKJHF_.Clone();
		jHDLNBPNEKG_ = other.jHDLNBPNEKG_;
		bCPCBHMFIIN_ = other.bCPCBHMFIIN_;
		retcode_ = other.retcode_;
		dJHDDOFHMCF_ = other.dJHDDOFHMCF_.Clone();
		dIMOGLIMLBD_ = other.dIMOGLIMLBD_;
		aMMJECHPGPE_ = ((other.aMMJECHPGPE_ != null) ? other.aMMJECHPGPE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMapRotationDataScRsp Clone()
	{
		return new GetMapRotationDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMapRotationDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMapRotationDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EnergyInfo, other.EnergyInfo))
		{
			return false;
		}
		if (!gPKABIBKJHF_.Equals(other.gPKABIBKJHF_))
		{
			return false;
		}
		if (JHDLNBPNEKG != other.JHDLNBPNEKG)
		{
			return false;
		}
		if (BCPCBHMFIIN != other.BCPCBHMFIIN)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!dJHDDOFHMCF_.Equals(other.dJHDDOFHMCF_))
		{
			return false;
		}
		if (DIMOGLIMLBD != other.DIMOGLIMLBD)
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
		if (energyInfo_ != null)
		{
			num ^= EnergyInfo.GetHashCode();
		}
		num ^= gPKABIBKJHF_.GetHashCode();
		if (JHDLNBPNEKG != 0)
		{
			num ^= JHDLNBPNEKG.GetHashCode();
		}
		if (BCPCBHMFIIN != 0)
		{
			num ^= BCPCBHMFIIN.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= dJHDDOFHMCF_.GetHashCode();
		if (DIMOGLIMLBD)
		{
			num ^= DIMOGLIMLBD.GetHashCode();
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
		if (energyInfo_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(EnergyInfo);
		}
		gPKABIBKJHF_.WriteTo(ref output, _repeated_gPKABIBKJHF_codec);
		if (JHDLNBPNEKG != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(JHDLNBPNEKG);
		}
		if (BCPCBHMFIIN != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(BCPCBHMFIIN);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		dJHDDOFHMCF_.WriteTo(ref output, _repeated_dJHDDOFHMCF_codec);
		if (DIMOGLIMLBD)
		{
			output.WriteRawTag(80);
			output.WriteBool(DIMOGLIMLBD);
		}
		if (aMMJECHPGPE_ != null)
		{
			output.WriteRawTag(106);
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
		if (energyInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnergyInfo);
		}
		num += gPKABIBKJHF_.CalculateSize(_repeated_gPKABIBKJHF_codec);
		if (JHDLNBPNEKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(JHDLNBPNEKG);
		}
		if (BCPCBHMFIIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCPCBHMFIIN);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += dJHDDOFHMCF_.CalculateSize(_repeated_dJHDDOFHMCF_codec);
		if (DIMOGLIMLBD)
		{
			num += 2;
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
	public void MergeFrom(GetMapRotationDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.energyInfo_ != null)
		{
			if (energyInfo_ == null)
			{
				EnergyInfo = new RotaterEnergyInfo();
			}
			EnergyInfo.MergeFrom(other.EnergyInfo);
		}
		gPKABIBKJHF_.Add(other.gPKABIBKJHF_);
		if (other.JHDLNBPNEKG != 0)
		{
			JHDLNBPNEKG = other.JHDLNBPNEKG;
		}
		if (other.BCPCBHMFIIN != 0)
		{
			BCPCBHMFIIN = other.BCPCBHMFIIN;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		dJHDDOFHMCF_.Add(other.dJHDDOFHMCF_);
		if (other.DIMOGLIMLBD)
		{
			DIMOGLIMLBD = other.DIMOGLIMLBD;
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
				if (energyInfo_ == null)
				{
					EnergyInfo = new RotaterEnergyInfo();
				}
				input.ReadMessage(EnergyInfo);
				break;
			case 26u:
				gPKABIBKJHF_.AddEntriesFrom(ref input, _repeated_gPKABIBKJHF_codec);
				break;
			case 32u:
				JHDLNBPNEKG = input.ReadInt32();
				break;
			case 40u:
				BCPCBHMFIIN = input.ReadUInt32();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				dJHDDOFHMCF_.AddEntriesFrom(ref input, _repeated_dJHDDOFHMCF_codec);
				break;
			case 80u:
				DIMOGLIMLBD = input.ReadBool();
				break;
			case 106u:
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
