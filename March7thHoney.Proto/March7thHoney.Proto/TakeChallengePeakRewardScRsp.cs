using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeChallengePeakRewardScRsp : IMessage<TakeChallengePeakRewardScRsp>, IMessage, IEquatable<TakeChallengePeakRewardScRsp>, IDeepCloneable<TakeChallengePeakRewardScRsp>, IBufferMessage
{
	private static readonly MessageParser<TakeChallengePeakRewardScRsp> _parser = new MessageParser<TakeChallengePeakRewardScRsp>(() => new TakeChallengePeakRewardScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int PeakGroupIdFieldNumber = 4;

	private uint peakGroupId_;

	public const int PeakRewardGroupListFieldNumber = 15;

	private static readonly FieldCodec<ChallengePeakRewardGroup> _repeated_peakRewardGroupList_codec = FieldCodec.ForMessage(122u, ChallengePeakRewardGroup.Parser);

	private readonly RepeatedField<ChallengePeakRewardGroup> peakRewardGroupList_ = new RepeatedField<ChallengePeakRewardGroup>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeChallengePeakRewardScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeChallengePeakRewardScRspReflection.Descriptor.MessageTypes[0];

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
	public uint PeakGroupId
	{
		get
		{
			return peakGroupId_;
		}
		set
		{
			peakGroupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ChallengePeakRewardGroup> PeakRewardGroupList => peakRewardGroupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeChallengePeakRewardScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeChallengePeakRewardScRsp(TakeChallengePeakRewardScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		peakGroupId_ = other.peakGroupId_;
		peakRewardGroupList_ = other.peakRewardGroupList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeChallengePeakRewardScRsp Clone()
	{
		return new TakeChallengePeakRewardScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeChallengePeakRewardScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeChallengePeakRewardScRsp other)
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
		if (PeakGroupId != other.PeakGroupId)
		{
			return false;
		}
		if (!peakRewardGroupList_.Equals(other.peakRewardGroupList_))
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
		if (PeakGroupId != 0)
		{
			num ^= PeakGroupId.GetHashCode();
		}
		num ^= peakRewardGroupList_.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (PeakGroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(PeakGroupId);
		}
		peakRewardGroupList_.WriteTo(ref output, _repeated_peakRewardGroupList_codec);
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
		if (PeakGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PeakGroupId);
		}
		num += peakRewardGroupList_.CalculateSize(_repeated_peakRewardGroupList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeChallengePeakRewardScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.PeakGroupId != 0)
			{
				PeakGroupId = other.PeakGroupId;
			}
			peakRewardGroupList_.Add(other.peakRewardGroupList_);
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
				Retcode = input.ReadUInt32();
				break;
			case 32u:
				PeakGroupId = input.ReadUInt32();
				break;
			case 122u:
				peakRewardGroupList_.AddEntriesFrom(ref input, _repeated_peakRewardGroupList_codec);
				break;
			}
		}
	}
}
