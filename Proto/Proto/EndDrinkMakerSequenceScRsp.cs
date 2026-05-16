using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EndDrinkMakerSequenceScRsp : IMessage<EndDrinkMakerSequenceScRsp>, IMessage, IEquatable<EndDrinkMakerSequenceScRsp>, IDeepCloneable<EndDrinkMakerSequenceScRsp>, IBufferMessage
{
	private static readonly MessageParser<EndDrinkMakerSequenceScRsp> _parser = new MessageParser<EndDrinkMakerSequenceScRsp>(() => new EndDrinkMakerSequenceScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ExpFieldNumber = 1;

	private uint exp_;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int RewardFieldNumber = 3;

	private ItemList reward_;

	public const int DANFIBMHMNDFieldNumber = 5;

	private static readonly FieldCodec<JLMCNJKMCFG> _repeated_dANFIBMHMND_codec = FieldCodec.ForMessage(42u, JLMCNJKMCFG.Parser);

	private readonly RepeatedField<JLMCNJKMCFG> dANFIBMHMND_ = new RepeatedField<JLMCNJKMCFG>();

	public const int LPDMPNABBENFieldNumber = 6;

	private uint lPDMPNABBEN_;

	public const int EDBOHDJDJAAFieldNumber = 7;

	private uint eDBOHDJDJAA_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int PDPMLDMOMPHFieldNumber = 11;

	private POHIEKPHMGH pDPMLDMOMPH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EndDrinkMakerSequenceScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EndDrinkMakerSequenceScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JLMCNJKMCFG> DANFIBMHMND => dANFIBMHMND_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LPDMPNABBEN
	{
		get
		{
			return lPDMPNABBEN_;
		}
		set
		{
			lPDMPNABBEN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDBOHDJDJAA
	{
		get
		{
			return eDBOHDJDJAA_;
		}
		set
		{
			eDBOHDJDJAA_ = value;
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
	public POHIEKPHMGH PDPMLDMOMPH
	{
		get
		{
			return pDPMLDMOMPH_;
		}
		set
		{
			pDPMLDMOMPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EndDrinkMakerSequenceScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EndDrinkMakerSequenceScRsp(EndDrinkMakerSequenceScRsp other)
		: this()
	{
		exp_ = other.exp_;
		level_ = other.level_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		dANFIBMHMND_ = other.dANFIBMHMND_.Clone();
		lPDMPNABBEN_ = other.lPDMPNABBEN_;
		eDBOHDJDJAA_ = other.eDBOHDJDJAA_;
		retcode_ = other.retcode_;
		pDPMLDMOMPH_ = ((other.pDPMLDMOMPH_ != null) ? other.pDPMLDMOMPH_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EndDrinkMakerSequenceScRsp Clone()
	{
		return new EndDrinkMakerSequenceScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EndDrinkMakerSequenceScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EndDrinkMakerSequenceScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (!dANFIBMHMND_.Equals(other.dANFIBMHMND_))
		{
			return false;
		}
		if (LPDMPNABBEN != other.LPDMPNABBEN)
		{
			return false;
		}
		if (EDBOHDJDJAA != other.EDBOHDJDJAA)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(PDPMLDMOMPH, other.PDPMLDMOMPH))
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
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		num ^= dANFIBMHMND_.GetHashCode();
		if (LPDMPNABBEN != 0)
		{
			num ^= LPDMPNABBEN.GetHashCode();
		}
		if (EDBOHDJDJAA != 0)
		{
			num ^= EDBOHDJDJAA.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (pDPMLDMOMPH_ != null)
		{
			num ^= PDPMLDMOMPH.GetHashCode();
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
		if (Exp != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Exp);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Reward);
		}
		dANFIBMHMND_.WriteTo(ref output, _repeated_dANFIBMHMND_codec);
		if (LPDMPNABBEN != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(LPDMPNABBEN);
		}
		if (EDBOHDJDJAA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EDBOHDJDJAA);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (pDPMLDMOMPH_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(PDPMLDMOMPH);
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
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		num += dANFIBMHMND_.CalculateSize(_repeated_dANFIBMHMND_codec);
		if (LPDMPNABBEN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LPDMPNABBEN);
		}
		if (EDBOHDJDJAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDBOHDJDJAA);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (pDPMLDMOMPH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PDPMLDMOMPH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EndDrinkMakerSequenceScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Exp != 0)
		{
			Exp = other.Exp;
		}
		if (other.Level != 0)
		{
			Level = other.Level;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		dANFIBMHMND_.Add(other.dANFIBMHMND_);
		if (other.LPDMPNABBEN != 0)
		{
			LPDMPNABBEN = other.LPDMPNABBEN;
		}
		if (other.EDBOHDJDJAA != 0)
		{
			EDBOHDJDJAA = other.EDBOHDJDJAA;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.pDPMLDMOMPH_ != null)
		{
			if (pDPMLDMOMPH_ == null)
			{
				PDPMLDMOMPH = new POHIEKPHMGH();
			}
			PDPMLDMOMPH.MergeFrom(other.PDPMLDMOMPH);
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
			case 8u:
				Exp = input.ReadUInt32();
				break;
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 26u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 42u:
				dANFIBMHMND_.AddEntriesFrom(ref input, _repeated_dANFIBMHMND_codec);
				break;
			case 48u:
				LPDMPNABBEN = input.ReadUInt32();
				break;
			case 56u:
				EDBOHDJDJAA = input.ReadUInt32();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				if (pDPMLDMOMPH_ == null)
				{
					PDPMLDMOMPH = new POHIEKPHMGH();
				}
				input.ReadMessage(PDPMLDMOMPH);
				break;
			}
		}
	}
}
