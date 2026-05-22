using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishEmotionDialoguePerformanceScRsp : IMessage<FinishEmotionDialoguePerformanceScRsp>, IMessage, IEquatable<FinishEmotionDialoguePerformanceScRsp>, IDeepCloneable<FinishEmotionDialoguePerformanceScRsp>, IBufferMessage
{
	private static readonly MessageParser<FinishEmotionDialoguePerformanceScRsp> _parser = new MessageParser<FinishEmotionDialoguePerformanceScRsp>(() => new FinishEmotionDialoguePerformanceScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ScriptIdFieldNumber = 6;

	private uint scriptId_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	public const int DialogueIdFieldNumber = 9;

	private uint dialogueId_;

	public const int RewardListFieldNumber = 13;

	private ItemList rewardList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishEmotionDialoguePerformanceScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishEmotionDialoguePerformanceScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScriptId
	{
		get
		{
			return scriptId_;
		}
		set
		{
			scriptId_ = value;
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
	public uint DialogueId
	{
		get
		{
			return dialogueId_;
		}
		set
		{
			dialogueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList RewardList
	{
		get
		{
			return rewardList_;
		}
		set
		{
			rewardList_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishEmotionDialoguePerformanceScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishEmotionDialoguePerformanceScRsp(FinishEmotionDialoguePerformanceScRsp other)
		: this()
	{
		scriptId_ = other.scriptId_;
		retcode_ = other.retcode_;
		dialogueId_ = other.dialogueId_;
		rewardList_ = ((other.rewardList_ != null) ? other.rewardList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishEmotionDialoguePerformanceScRsp Clone()
	{
		return new FinishEmotionDialoguePerformanceScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishEmotionDialoguePerformanceScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishEmotionDialoguePerformanceScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScriptId != other.ScriptId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (DialogueId != other.DialogueId)
		{
			return false;
		}
		if (!object.Equals(RewardList, other.RewardList))
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
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (DialogueId != 0)
		{
			num ^= DialogueId.GetHashCode();
		}
		if (rewardList_ != null)
		{
			num ^= RewardList.GetHashCode();
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
		if (ScriptId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ScriptId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Retcode);
		}
		if (DialogueId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(DialogueId);
		}
		if (rewardList_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(RewardList);
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
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (DialogueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DialogueId);
		}
		if (rewardList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RewardList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishEmotionDialoguePerformanceScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ScriptId != 0)
		{
			ScriptId = other.ScriptId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.DialogueId != 0)
		{
			DialogueId = other.DialogueId;
		}
		if (other.rewardList_ != null)
		{
			if (rewardList_ == null)
			{
				RewardList = new ItemList();
			}
			RewardList.MergeFrom(other.RewardList);
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
			case 48u:
				ScriptId = input.ReadUInt32();
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				DialogueId = input.ReadUInt32();
				break;
			case 106u:
				if (rewardList_ == null)
				{
					RewardList = new ItemList();
				}
				input.ReadMessage(RewardList);
				break;
			}
		}
	}
}
