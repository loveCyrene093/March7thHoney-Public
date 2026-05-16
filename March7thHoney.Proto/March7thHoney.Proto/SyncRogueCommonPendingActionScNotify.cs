using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueCommonPendingActionScNotify : IMessage<SyncRogueCommonPendingActionScNotify>, IMessage, IEquatable<SyncRogueCommonPendingActionScNotify>, IDeepCloneable<SyncRogueCommonPendingActionScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueCommonPendingActionScNotify> _parser = new MessageParser<SyncRogueCommonPendingActionScNotify>(() => new SyncRogueCommonPendingActionScNotify());

	private UnknownFieldSet _unknownFields;

	public const int LOIDOGEENOBFieldNumber = 1;

	private uint lOIDOGEENOB_;

	public const int ActionFieldNumber = 15;

	private EPPJHNIHAFL action_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueCommonPendingActionScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueCommonPendingActionScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOIDOGEENOB
	{
		get
		{
			return lOIDOGEENOB_;
		}
		set
		{
			lOIDOGEENOB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPPJHNIHAFL Action
	{
		get
		{
			return action_;
		}
		set
		{
			action_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonPendingActionScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonPendingActionScNotify(SyncRogueCommonPendingActionScNotify other)
		: this()
	{
		lOIDOGEENOB_ = other.lOIDOGEENOB_;
		action_ = ((other.action_ != null) ? other.action_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueCommonPendingActionScNotify Clone()
	{
		return new SyncRogueCommonPendingActionScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueCommonPendingActionScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueCommonPendingActionScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LOIDOGEENOB != other.LOIDOGEENOB)
		{
			return false;
		}
		if (!object.Equals(Action, other.Action))
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
		if (LOIDOGEENOB != 0)
		{
			num ^= LOIDOGEENOB.GetHashCode();
		}
		if (action_ != null)
		{
			num ^= Action.GetHashCode();
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
		if (LOIDOGEENOB != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LOIDOGEENOB);
		}
		if (action_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(Action);
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
		if (LOIDOGEENOB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOIDOGEENOB);
		}
		if (action_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Action);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRogueCommonPendingActionScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LOIDOGEENOB != 0)
		{
			LOIDOGEENOB = other.LOIDOGEENOB;
		}
		if (other.action_ != null)
		{
			if (action_ == null)
			{
				Action = new EPPJHNIHAFL();
			}
			Action.MergeFrom(other.Action);
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
			case 8u:
				LOIDOGEENOB = input.ReadUInt32();
				break;
			case 122u:
				if (action_ == null)
				{
					Action = new EPPJHNIHAFL();
				}
				input.ReadMessage(Action);
				break;
			}
		}
	}
}
