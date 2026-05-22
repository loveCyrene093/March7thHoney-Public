using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StoryLineInfoScNotify : IMessage<StoryLineInfoScNotify>, IMessage, IEquatable<StoryLineInfoScNotify>, IDeepCloneable<StoryLineInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<StoryLineInfoScNotify> _parser = new MessageParser<StoryLineInfoScNotify>(() => new StoryLineInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int TrialAvatarIdListFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

	public const int JBBJBGGNALEFieldNumber = 2;

	private uint jBBJBGGNALE_;

	public const int CurStoryLineIdFieldNumber = 9;

	private uint curStoryLineId_;

	public const int UnfinishedStoryLineIdListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_unfinishedStoryLineIdList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> unfinishedStoryLineIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StoryLineInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StoryLineInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TrialAvatarIdList => trialAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JBBJBGGNALE
	{
		get
		{
			return jBBJBGGNALE_;
		}
		set
		{
			jBBJBGGNALE_ = value;
		}
	}

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
	public RepeatedField<uint> UnfinishedStoryLineIdList => unfinishedStoryLineIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StoryLineInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StoryLineInfoScNotify(StoryLineInfoScNotify other)
		: this()
	{
		trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
		jBBJBGGNALE_ = other.jBBJBGGNALE_;
		curStoryLineId_ = other.curStoryLineId_;
		unfinishedStoryLineIdList_ = other.unfinishedStoryLineIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StoryLineInfoScNotify Clone()
	{
		return new StoryLineInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StoryLineInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StoryLineInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!trialAvatarIdList_.Equals(other.trialAvatarIdList_))
		{
			return false;
		}
		if (JBBJBGGNALE != other.JBBJBGGNALE)
		{
			return false;
		}
		if (CurStoryLineId != other.CurStoryLineId)
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
		num ^= trialAvatarIdList_.GetHashCode();
		if (JBBJBGGNALE != 0)
		{
			num ^= JBBJBGGNALE.GetHashCode();
		}
		if (CurStoryLineId != 0)
		{
			num ^= CurStoryLineId.GetHashCode();
		}
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
		trialAvatarIdList_.WriteTo(ref output, _repeated_trialAvatarIdList_codec);
		if (JBBJBGGNALE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JBBJBGGNALE);
		}
		if (CurStoryLineId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CurStoryLineId);
		}
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
		num += trialAvatarIdList_.CalculateSize(_repeated_trialAvatarIdList_codec);
		if (JBBJBGGNALE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JBBJBGGNALE);
		}
		if (CurStoryLineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurStoryLineId);
		}
		num += unfinishedStoryLineIdList_.CalculateSize(_repeated_unfinishedStoryLineIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StoryLineInfoScNotify other)
	{
		if (other != null)
		{
			trialAvatarIdList_.Add(other.trialAvatarIdList_);
			if (other.JBBJBGGNALE != 0)
			{
				JBBJBGGNALE = other.JBBJBGGNALE;
			}
			if (other.CurStoryLineId != 0)
			{
				CurStoryLineId = other.CurStoryLineId;
			}
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
			case 8u:
			case 10u:
				trialAvatarIdList_.AddEntriesFrom(ref input, _repeated_trialAvatarIdList_codec);
				break;
			case 16u:
				JBBJBGGNALE = input.ReadUInt32();
				break;
			case 72u:
				CurStoryLineId = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				unfinishedStoryLineIdList_.AddEntriesFrom(ref input, _repeated_unfinishedStoryLineIdList_codec);
				break;
			}
		}
	}
}
