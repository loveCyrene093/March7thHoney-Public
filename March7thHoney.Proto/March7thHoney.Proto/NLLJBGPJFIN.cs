using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NLLJBGPJFIN : IMessage<NLLJBGPJFIN>, IMessage, IEquatable<NLLJBGPJFIN>, IDeepCloneable<NLLJBGPJFIN>, IBufferMessage
{
	private static readonly MessageParser<NLLJBGPJFIN> _parser = new MessageParser<NLLJBGPJFIN>(() => new NLLJBGPJFIN());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int BaseAvatarIdListFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

	public const int UnfinishedStoryLineIdListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_unfinishedStoryLineIdList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> unfinishedStoryLineIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NLLJBGPJFIN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NLLJBGPJFINReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> BaseAvatarIdList => baseAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnfinishedStoryLineIdList => unfinishedStoryLineIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLLJBGPJFIN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLLJBGPJFIN(NLLJBGPJFIN other)
		: this()
	{
		retcode_ = other.retcode_;
		baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
		unfinishedStoryLineIdList_ = other.unfinishedStoryLineIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NLLJBGPJFIN Clone()
	{
		return new NLLJBGPJFIN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NLLJBGPJFIN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NLLJBGPJFIN other)
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
		if (!baseAvatarIdList_.Equals(other.baseAvatarIdList_))
		{
			return false;
		}
		if (!unfinishedStoryLineIdList_.Equals(other.unfinishedStoryLineIdList_))
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
		num ^= baseAvatarIdList_.GetHashCode();
		num ^= unfinishedStoryLineIdList_.GetHashCode();
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
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
		unfinishedStoryLineIdList_.WriteTo(ref output, _repeated_unfinishedStoryLineIdList_codec);
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
		num += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
		num += unfinishedStoryLineIdList_.CalculateSize(_repeated_unfinishedStoryLineIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NLLJBGPJFIN other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			baseAvatarIdList_.Add(other.baseAvatarIdList_);
			unfinishedStoryLineIdList_.Add(other.unfinishedStoryLineIdList_);
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
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
				break;
			case 88u:
			case 90u:
				unfinishedStoryLineIdList_.AddEntriesFrom(ref input, _repeated_unfinishedStoryLineIdList_codec);
				break;
			}
		}
	}
}
