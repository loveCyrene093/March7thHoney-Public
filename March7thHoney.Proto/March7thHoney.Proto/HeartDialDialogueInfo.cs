using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeartDialDialogueInfo : IMessage<HeartDialDialogueInfo>, IMessage, IEquatable<HeartDialDialogueInfo>, IDeepCloneable<HeartDialDialogueInfo>, IBufferMessage
{
	private static readonly MessageParser<HeartDialDialogueInfo> _parser = new MessageParser<HeartDialDialogueInfo>(() => new HeartDialDialogueInfo());

	private UnknownFieldSet _unknownFields;

	public const int DialogueIdFieldNumber = 3;

	private uint dialogueId_;

	public const int KOLJIDNMPONFieldNumber = 5;

	private bool kOLJIDNMPON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeartDialDialogueInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeartDialDialogueInfoReflection.Descriptor.MessageTypes[0];

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
	public bool KOLJIDNMPON
	{
		get
		{
			return kOLJIDNMPON_;
		}
		set
		{
			kOLJIDNMPON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialDialogueInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialDialogueInfo(HeartDialDialogueInfo other)
		: this()
	{
		dialogueId_ = other.dialogueId_;
		kOLJIDNMPON_ = other.kOLJIDNMPON_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialDialogueInfo Clone()
	{
		return new HeartDialDialogueInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeartDialDialogueInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeartDialDialogueInfo other)
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
		if (KOLJIDNMPON != other.KOLJIDNMPON)
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
		if (KOLJIDNMPON)
		{
			num ^= KOLJIDNMPON.GetHashCode();
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
		if (KOLJIDNMPON)
		{
			output.WriteRawTag(40);
			output.WriteBool(KOLJIDNMPON);
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
		if (KOLJIDNMPON)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeartDialDialogueInfo other)
	{
		if (other != null)
		{
			if (other.DialogueId != 0)
			{
				DialogueId = other.DialogueId;
			}
			if (other.KOLJIDNMPON)
			{
				KOLJIDNMPON = other.KOLJIDNMPON;
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
			case 40u:
				KOLJIDNMPON = input.ReadBool();
				break;
			}
		}
	}
}
