using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DJCCBIOKNOD : IMessage<DJCCBIOKNOD>, IMessage, IEquatable<DJCCBIOKNOD>, IDeepCloneable<DJCCBIOKNOD>, IBufferMessage
{
	private static readonly MessageParser<DJCCBIOKNOD> _parser = new MessageParser<DJCCBIOKNOD>(() => new DJCCBIOKNOD());

	private UnknownFieldSet _unknownFields;

	public const int BLKACGBDAHBFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_bLKACGBDAHB_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> bLKACGBDAHB_ = new RepeatedField<uint>();

	public const int RewardFieldNumber = 7;

	private ItemList reward_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int IMNOJIDJBNGFieldNumber = 12;

	private NHDKLMIMLKC iMNOJIDJBNG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DJCCBIOKNOD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DJCCBIOKNODReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BLKACGBDAHB => bLKACGBDAHB_;

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
	public NHDKLMIMLKC IMNOJIDJBNG
	{
		get
		{
			return iMNOJIDJBNG_;
		}
		set
		{
			iMNOJIDJBNG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DJCCBIOKNOD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DJCCBIOKNOD(DJCCBIOKNOD other)
		: this()
	{
		bLKACGBDAHB_ = other.bLKACGBDAHB_.Clone();
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		retcode_ = other.retcode_;
		iMNOJIDJBNG_ = ((other.iMNOJIDJBNG_ != null) ? other.iMNOJIDJBNG_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DJCCBIOKNOD Clone()
	{
		return new DJCCBIOKNOD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DJCCBIOKNOD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DJCCBIOKNOD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bLKACGBDAHB_.Equals(other.bLKACGBDAHB_))
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(IMNOJIDJBNG, other.IMNOJIDJBNG))
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
		num ^= bLKACGBDAHB_.GetHashCode();
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (iMNOJIDJBNG_ != null)
		{
			num ^= IMNOJIDJBNG.GetHashCode();
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
		bLKACGBDAHB_.WriteTo(ref output, _repeated_bLKACGBDAHB_codec);
		if (reward_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Reward);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (iMNOJIDJBNG_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(IMNOJIDJBNG);
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
		num += bLKACGBDAHB_.CalculateSize(_repeated_bLKACGBDAHB_codec);
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (iMNOJIDJBNG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMNOJIDJBNG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DJCCBIOKNOD other)
	{
		if (other == null)
		{
			return;
		}
		bLKACGBDAHB_.Add(other.bLKACGBDAHB_);
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.iMNOJIDJBNG_ != null)
		{
			if (iMNOJIDJBNG_ == null)
			{
				IMNOJIDJBNG = new NHDKLMIMLKC();
			}
			IMNOJIDJBNG.MergeFrom(other.IMNOJIDJBNG);
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
			case 10u:
				bLKACGBDAHB_.AddEntriesFrom(ref input, _repeated_bLKACGBDAHB_codec);
				break;
			case 58u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				if (iMNOJIDJBNG_ == null)
				{
					IMNOJIDJBNG = new NHDKLMIMLKC();
				}
				input.ReadMessage(IMNOJIDJBNG);
				break;
			}
		}
	}
}
