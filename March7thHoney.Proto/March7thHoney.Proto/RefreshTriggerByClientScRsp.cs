using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RefreshTriggerByClientScRsp : IMessage<RefreshTriggerByClientScRsp>, IMessage, IEquatable<RefreshTriggerByClientScRsp>, IDeepCloneable<RefreshTriggerByClientScRsp>, IBufferMessage
{
	private static readonly MessageParser<RefreshTriggerByClientScRsp> _parser = new MessageParser<RefreshTriggerByClientScRsp>(() => new RefreshTriggerByClientScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int TriggerNameFieldNumber = 9;

	private string triggerName_ = "";

	public const int TriggerEntityIdFieldNumber = 10;

	private uint triggerEntityId_;

	public const int RefreshTriggerFieldNumber = 13;

	private bool refreshTrigger_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RefreshTriggerByClientScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RefreshTriggerByClientScRspReflection.Descriptor.MessageTypes[0];

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
	public bool RefreshTrigger
	{
		get
		{
			return refreshTrigger_;
		}
		set
		{
			refreshTrigger_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshTriggerByClientScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshTriggerByClientScRsp(RefreshTriggerByClientScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		triggerName_ = other.triggerName_;
		triggerEntityId_ = other.triggerEntityId_;
		refreshTrigger_ = other.refreshTrigger_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshTriggerByClientScRsp Clone()
	{
		return new RefreshTriggerByClientScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RefreshTriggerByClientScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RefreshTriggerByClientScRsp other)
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
		if (TriggerName != other.TriggerName)
		{
			return false;
		}
		if (TriggerEntityId != other.TriggerEntityId)
		{
			return false;
		}
		if (RefreshTrigger != other.RefreshTrigger)
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
		if (TriggerName.Length != 0)
		{
			num ^= TriggerName.GetHashCode();
		}
		if (TriggerEntityId != 0)
		{
			num ^= TriggerEntityId.GetHashCode();
		}
		if (RefreshTrigger)
		{
			num ^= RefreshTrigger.GetHashCode();
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
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (TriggerName.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(TriggerName);
		}
		if (TriggerEntityId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(TriggerEntityId);
		}
		if (RefreshTrigger)
		{
			output.WriteRawTag(104);
			output.WriteBool(RefreshTrigger);
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
		if (TriggerName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TriggerName);
		}
		if (TriggerEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TriggerEntityId);
		}
		if (RefreshTrigger)
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
	public void MergeFrom(RefreshTriggerByClientScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.TriggerName.Length != 0)
			{
				TriggerName = other.TriggerName;
			}
			if (other.TriggerEntityId != 0)
			{
				TriggerEntityId = other.TriggerEntityId;
			}
			if (other.RefreshTrigger)
			{
				RefreshTrigger = other.RefreshTrigger;
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
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				TriggerName = input.ReadString();
				break;
			case 80u:
				TriggerEntityId = input.ReadUInt32();
				break;
			case 104u:
				RefreshTrigger = input.ReadBool();
				break;
			}
		}
	}
}
