using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetStoryLineInfoScRsp : IMessage<GetStoryLineInfoScRsp>, IMessage, IEquatable<GetStoryLineInfoScRsp>, IDeepCloneable<GetStoryLineInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetStoryLineInfoScRsp> _parser = new MessageParser<GetStoryLineInfoScRsp>(() => new GetStoryLineInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int UnfinishedStoryLineIdListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_unfinishedStoryLineIdList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> unfinishedStoryLineIdList_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int TrialAvatarIdListFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

	public const int CurStoryLineIdFieldNumber = 12;

	private uint curStoryLineId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetStoryLineInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetStoryLineInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnfinishedStoryLineIdList => unfinishedStoryLineIdList_;

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
	public RepeatedField<uint> TrialAvatarIdList => trialAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurStoryLineId
	{
		get
		{
			return curStoryLineId_;
		}
		set
		{
			curStoryLineId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetStoryLineInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetStoryLineInfoScRsp(GetStoryLineInfoScRsp other)
		: this()
	{
		unfinishedStoryLineIdList_ = other.unfinishedStoryLineIdList_.Clone();
		retcode_ = other.retcode_;
		trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
		curStoryLineId_ = other.curStoryLineId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetStoryLineInfoScRsp Clone()
	{
		return new GetStoryLineInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetStoryLineInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetStoryLineInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!unfinishedStoryLineIdList_.Equals(other.unfinishedStoryLineIdList_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!trialAvatarIdList_.Equals(other.trialAvatarIdList_))
		{
			return false;
		}
		if (CurStoryLineId != other.CurStoryLineId)
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
		num ^= unfinishedStoryLineIdList_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= trialAvatarIdList_.GetHashCode();
		if (CurStoryLineId != 0)
		{
			num ^= CurStoryLineId.GetHashCode();
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
		unfinishedStoryLineIdList_.WriteTo(ref output, _repeated_unfinishedStoryLineIdList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		trialAvatarIdList_.WriteTo(ref output, _repeated_trialAvatarIdList_codec);
		if (CurStoryLineId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CurStoryLineId);
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
		num += unfinishedStoryLineIdList_.CalculateSize(_repeated_unfinishedStoryLineIdList_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += trialAvatarIdList_.CalculateSize(_repeated_trialAvatarIdList_codec);
		if (CurStoryLineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurStoryLineId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetStoryLineInfoScRsp other)
	{
		if (other != null)
		{
			unfinishedStoryLineIdList_.Add(other.unfinishedStoryLineIdList_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			trialAvatarIdList_.Add(other.trialAvatarIdList_);
			if (other.CurStoryLineId != 0)
			{
				CurStoryLineId = other.CurStoryLineId;
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
			case 48u:
			case 50u:
				unfinishedStoryLineIdList_.AddEntriesFrom(ref input, _repeated_unfinishedStoryLineIdList_codec);
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 64u:
			case 66u:
				trialAvatarIdList_.AddEntriesFrom(ref input, _repeated_trialAvatarIdList_codec);
				break;
			case 96u:
				CurStoryLineId = input.ReadUInt32();
				break;
			}
		}
	}
}
