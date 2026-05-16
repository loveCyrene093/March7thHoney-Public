using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RefreshTriggerByClientScNotify : IMessage<RefreshTriggerByClientScNotify>, IMessage, IEquatable<RefreshTriggerByClientScNotify>, IDeepCloneable<RefreshTriggerByClientScNotify>, IBufferMessage
{
	private static readonly MessageParser<RefreshTriggerByClientScNotify> _parser = new MessageParser<RefreshTriggerByClientScNotify>(() => new RefreshTriggerByClientScNotify());

	private UnknownFieldSet _unknownFields;

	public const int TriggerNameFieldNumber = 1;

	private string triggerName_ = "";

	public const int TriggerTargetIdListFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_triggerTargetIdList_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> triggerTargetIdList_ = new RepeatedField<uint>();

	public const int TriggerEntityIdFieldNumber = 5;

	private uint triggerEntityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RefreshTriggerByClientScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RefreshTriggerByClientScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TriggerName
	{
		get
		{
			return triggerName_;
		}
		set
		{
			triggerName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TriggerTargetIdList => triggerTargetIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TriggerEntityId
	{
		get
		{
			return triggerEntityId_;
		}
		set
		{
			triggerEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshTriggerByClientScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshTriggerByClientScNotify(RefreshTriggerByClientScNotify other)
		: this()
	{
		triggerName_ = other.triggerName_;
		triggerTargetIdList_ = other.triggerTargetIdList_.Clone();
		triggerEntityId_ = other.triggerEntityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshTriggerByClientScNotify Clone()
	{
		return new RefreshTriggerByClientScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RefreshTriggerByClientScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RefreshTriggerByClientScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TriggerName != other.TriggerName)
		{
			return false;
		}
		if (!triggerTargetIdList_.Equals(other.triggerTargetIdList_))
		{
			return false;
		}
		if (TriggerEntityId != other.TriggerEntityId)
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
		if (TriggerName.Length != 0)
		{
			num ^= TriggerName.GetHashCode();
		}
		num ^= triggerTargetIdList_.GetHashCode();
		if (TriggerEntityId != 0)
		{
			num ^= TriggerEntityId.GetHashCode();
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
		if (TriggerName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(TriggerName);
		}
		triggerTargetIdList_.WriteTo(ref output, _repeated_triggerTargetIdList_codec);
		if (TriggerEntityId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(TriggerEntityId);
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
		if (TriggerName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TriggerName);
		}
		num += triggerTargetIdList_.CalculateSize(_repeated_triggerTargetIdList_codec);
		if (TriggerEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TriggerEntityId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RefreshTriggerByClientScNotify other)
	{
		if (other != null)
		{
			if (other.TriggerName.Length != 0)
			{
				TriggerName = other.TriggerName;
			}
			triggerTargetIdList_.Add(other.triggerTargetIdList_);
			if (other.TriggerEntityId != 0)
			{
				TriggerEntityId = other.TriggerEntityId;
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
			case 10u:
				TriggerName = input.ReadString();
				break;
			case 24u:
			case 26u:
				triggerTargetIdList_.AddEntriesFrom(ref input, _repeated_triggerTargetIdList_codec);
				break;
			case 40u:
				TriggerEntityId = input.ReadUInt32();
				break;
			}
		}
	}
}
