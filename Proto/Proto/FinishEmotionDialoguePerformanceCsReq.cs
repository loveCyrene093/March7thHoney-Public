using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishEmotionDialoguePerformanceCsReq : IMessage<FinishEmotionDialoguePerformanceCsReq>, IMessage, IEquatable<FinishEmotionDialoguePerformanceCsReq>, IDeepCloneable<FinishEmotionDialoguePerformanceCsReq>, IBufferMessage
{
	private static readonly MessageParser<FinishEmotionDialoguePerformanceCsReq> _parser = new MessageParser<FinishEmotionDialoguePerformanceCsReq>(() => new FinishEmotionDialoguePerformanceCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DialogueIdFieldNumber = 3;

	private uint dialogueId_;

	public const int AILOMBIMICBFieldNumber = 4;

	private uint aILOMBIMICB_;

	public const int ScriptIdFieldNumber = 15;

	private uint scriptId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishEmotionDialoguePerformanceCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishEmotionDialoguePerformanceCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint AILOMBIMICB
	{
		get
		{
			return aILOMBIMICB_;
		}
		set
		{
			aILOMBIMICB_ = value;
		}
	}

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
	public FinishEmotionDialoguePerformanceCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishEmotionDialoguePerformanceCsReq(FinishEmotionDialoguePerformanceCsReq other)
		: this()
	{
		dialogueId_ = other.dialogueId_;
		aILOMBIMICB_ = other.aILOMBIMICB_;
		scriptId_ = other.scriptId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishEmotionDialoguePerformanceCsReq Clone()
	{
		return new FinishEmotionDialoguePerformanceCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishEmotionDialoguePerformanceCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishEmotionDialoguePerformanceCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DialogueId != other.DialogueId)
		{
			return false;
		}
		if (AILOMBIMICB != other.AILOMBIMICB)
		{
			return false;
		}
		if (ScriptId != other.ScriptId)
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
		if (DialogueId != 0)
		{
			num ^= DialogueId.GetHashCode();
		}
		if (AILOMBIMICB != 0)
		{
			num ^= AILOMBIMICB.GetHashCode();
		}
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
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
		if (DialogueId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DialogueId);
		}
		if (AILOMBIMICB != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AILOMBIMICB);
		}
		if (ScriptId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ScriptId);
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
		if (DialogueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DialogueId);
		}
		if (AILOMBIMICB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AILOMBIMICB);
		}
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishEmotionDialoguePerformanceCsReq other)
	{
		if (other != null)
		{
			if (other.DialogueId != 0)
			{
				DialogueId = other.DialogueId;
			}
			if (other.AILOMBIMICB != 0)
			{
				AILOMBIMICB = other.AILOMBIMICB;
			}
			if (other.ScriptId != 0)
			{
				ScriptId = other.ScriptId;
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
				DialogueId = input.ReadUInt32();
				break;
			case 32u:
				AILOMBIMICB = input.ReadUInt32();
				break;
			case 120u:
				ScriptId = input.ReadUInt32();
				break;
			}
		}
	}
}
