using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetQuestDataScRsp : IMessage<GetQuestDataScRsp>, IMessage, IEquatable<GetQuestDataScRsp>, IDeepCloneable<GetQuestDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetQuestDataScRsp> _parser = new MessageParser<GetQuestDataScRsp>(() => new GetQuestDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int QuestListFieldNumber = 5;

	private static readonly FieldCodec<Quest> _repeated_questList_codec = FieldCodec.ForMessage(42u, Quest.Parser);

	private readonly RepeatedField<Quest> questList_ = new RepeatedField<Quest>();

	public const int TotalAchievementExpFieldNumber = 14;

	private uint totalAchievementExp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetQuestDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetQuestDataScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<Quest> QuestList => questList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalAchievementExp
	{
		get
		{
			return totalAchievementExp_;
		}
		set
		{
			totalAchievementExp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetQuestDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetQuestDataScRsp(GetQuestDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		questList_ = other.questList_.Clone();
		totalAchievementExp_ = other.totalAchievementExp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetQuestDataScRsp Clone()
	{
		return new GetQuestDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetQuestDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetQuestDataScRsp other)
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
		if (!questList_.Equals(other.questList_))
		{
			return false;
		}
		if (TotalAchievementExp != other.TotalAchievementExp)
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
		num ^= questList_.GetHashCode();
		if (TotalAchievementExp != 0)
		{
			num ^= TotalAchievementExp.GetHashCode();
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
		questList_.WriteTo(ref output, _repeated_questList_codec);
		if (TotalAchievementExp != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(TotalAchievementExp);
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
		num += questList_.CalculateSize(_repeated_questList_codec);
		if (TotalAchievementExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalAchievementExp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetQuestDataScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			questList_.Add(other.questList_);
			if (other.TotalAchievementExp != 0)
			{
				TotalAchievementExp = other.TotalAchievementExp;
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
			case 42u:
				questList_.AddEntriesFrom(ref input, _repeated_questList_codec);
				break;
			case 112u:
				TotalAchievementExp = input.ReadUInt32();
				break;
			}
		}
	}
}
