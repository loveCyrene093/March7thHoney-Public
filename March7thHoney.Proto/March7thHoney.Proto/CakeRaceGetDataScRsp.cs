using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CakeRaceGetDataScRsp : IMessage<CakeRaceGetDataScRsp>, IMessage, IEquatable<CakeRaceGetDataScRsp>, IDeepCloneable<CakeRaceGetDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<CakeRaceGetDataScRsp> _parser = new MessageParser<CakeRaceGetDataScRsp>(() => new CakeRaceGetDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int LCHDAPELPGOFieldNumber = 5;

	private uint lCHDAPELPGO_;

	public const int IHGBBHEBLKLFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_iHGBBHEBLKL_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> iHGBBHEBLKL_ = new RepeatedField<uint>();

	public const int ScoreIdFieldNumber = 11;

	private uint scoreId_;

	public const int PKOCDLHBPIMFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_pKOCDLHBPIM_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> pKOCDLHBPIM_ = new RepeatedField<uint>();

	public const int ItemValueFieldNumber = 14;

	private uint itemValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CakeRaceGetDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CakeRaceGetDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint LCHDAPELPGO
	{
		get
		{
			return lCHDAPELPGO_;
		}
		set
		{
			lCHDAPELPGO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IHGBBHEBLKL => iHGBBHEBLKL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PKOCDLHBPIM => pKOCDLHBPIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceGetDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceGetDataScRsp(CakeRaceGetDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		lCHDAPELPGO_ = other.lCHDAPELPGO_;
		iHGBBHEBLKL_ = other.iHGBBHEBLKL_.Clone();
		scoreId_ = other.scoreId_;
		pKOCDLHBPIM_ = other.pKOCDLHBPIM_.Clone();
		itemValue_ = other.itemValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceGetDataScRsp Clone()
	{
		return new CakeRaceGetDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CakeRaceGetDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CakeRaceGetDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (LCHDAPELPGO != other.LCHDAPELPGO)
		{
			return false;
		}
		if (!iHGBBHEBLKL_.Equals(other.iHGBBHEBLKL_))
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (!pKOCDLHBPIM_.Equals(other.pKOCDLHBPIM_))
		{
			return false;
		}
		if (ItemValue != other.ItemValue)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (LCHDAPELPGO != 0)
		{
			num ^= LCHDAPELPGO.GetHashCode();
		}
		num ^= iHGBBHEBLKL_.GetHashCode();
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		num ^= pKOCDLHBPIM_.GetHashCode();
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (LCHDAPELPGO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(LCHDAPELPGO);
		}
		iHGBBHEBLKL_.WriteTo(ref output, _repeated_iHGBBHEBLKL_codec);
		if (ScoreId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ScoreId);
		}
		pKOCDLHBPIM_.WriteTo(ref output, _repeated_pKOCDLHBPIM_codec);
		if (ItemValue != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ItemValue);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (LCHDAPELPGO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LCHDAPELPGO);
		}
		num += iHGBBHEBLKL_.CalculateSize(_repeated_iHGBBHEBLKL_codec);
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		num += pKOCDLHBPIM_.CalculateSize(_repeated_pKOCDLHBPIM_codec);
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CakeRaceGetDataScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.LCHDAPELPGO != 0)
			{
				LCHDAPELPGO = other.LCHDAPELPGO;
			}
			iHGBBHEBLKL_.Add(other.iHGBBHEBLKL_);
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			pKOCDLHBPIM_.Add(other.pKOCDLHBPIM_);
			if (other.ItemValue != 0)
			{
				ItemValue = other.ItemValue;
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
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 40u:
				LCHDAPELPGO = input.ReadUInt32();
				break;
			case 64u:
			case 66u:
				iHGBBHEBLKL_.AddEntriesFrom(ref input, _repeated_iHGBBHEBLKL_codec);
				break;
			case 88u:
				ScoreId = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				pKOCDLHBPIM_.AddEntriesFrom(ref input, _repeated_pKOCDLHBPIM_codec);
				break;
			case 112u:
				ItemValue = input.ReadUInt32();
				break;
			}
		}
	}
}
