using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPFENNBOBND : IMessage<DPFENNBOBND>, IMessage, IEquatable<DPFENNBOBND>, IDeepCloneable<DPFENNBOBND>, IBufferMessage
{
	private static readonly MessageParser<DPFENNBOBND> _parser = new MessageParser<DPFENNBOBND>(() => new DPFENNBOBND());

	private UnknownFieldSet _unknownFields;

	public const int RewardFieldNumber = 6;

	private ItemList reward_;

	public const int EFJBFBENGKGFieldNumber = 9;

	private GNANMEADPBD eFJBFBENGKG_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int BLKACGBDAHBFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_bLKACGBDAHB_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> bLKACGBDAHB_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPFENNBOBND> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPFENNBOBNDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public GNANMEADPBD EFJBFBENGKG
	{
		get
		{
			return eFJBFBENGKG_;
		}
		set
		{
			eFJBFBENGKG_ = value;
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
	public RepeatedField<uint> BLKACGBDAHB => bLKACGBDAHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPFENNBOBND()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPFENNBOBND(DPFENNBOBND other)
		: this()
	{
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		eFJBFBENGKG_ = ((other.eFJBFBENGKG_ != null) ? other.eFJBFBENGKG_.Clone() : null);
		retcode_ = other.retcode_;
		bLKACGBDAHB_ = other.bLKACGBDAHB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPFENNBOBND Clone()
	{
		return new DPFENNBOBND(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPFENNBOBND);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPFENNBOBND other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (!object.Equals(EFJBFBENGKG, other.EFJBFBENGKG))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!bLKACGBDAHB_.Equals(other.bLKACGBDAHB_))
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
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (eFJBFBENGKG_ != null)
		{
			num ^= EFJBFBENGKG.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= bLKACGBDAHB_.GetHashCode();
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
		if (reward_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Reward);
		}
		if (eFJBFBENGKG_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(EFJBFBENGKG);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		bLKACGBDAHB_.WriteTo(ref output, _repeated_bLKACGBDAHB_codec);
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
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (eFJBFBENGKG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EFJBFBENGKG);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += bLKACGBDAHB_.CalculateSize(_repeated_bLKACGBDAHB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPFENNBOBND other)
	{
		if (other == null)
		{
			return;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.eFJBFBENGKG_ != null)
		{
			if (eFJBFBENGKG_ == null)
			{
				EFJBFBENGKG = new GNANMEADPBD();
			}
			EFJBFBENGKG.MergeFrom(other.EFJBFBENGKG);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		bLKACGBDAHB_.Add(other.bLKACGBDAHB_);
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
			case 50u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 74u:
				if (eFJBFBENGKG_ == null)
				{
					EFJBFBENGKG = new GNANMEADPBD();
				}
				input.ReadMessage(EFJBFBENGKG);
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				bLKACGBDAHB_.AddEntriesFrom(ref input, _repeated_bLKACGBDAHB_codec);
				break;
			}
		}
	}
}
