using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HMJGADLIONA : IMessage<HMJGADLIONA>, IMessage, IEquatable<HMJGADLIONA>, IDeepCloneable<HMJGADLIONA>, IBufferMessage
{
	private static readonly MessageParser<HMJGADLIONA> _parser = new MessageParser<HMJGADLIONA>(() => new HMJGADLIONA());

	private UnknownFieldSet _unknownFields;

	public const int EntityIdFieldNumber = 4;

	private uint entityId_;

	public const int MotionFieldNumber = 14;

	private MotionInfo motion_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HMJGADLIONA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HMJGADLIONAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EntityId
	{
		get
		{
			return entityId_;
		}
		set
		{
			entityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo Motion
	{
		get
		{
			return motion_;
		}
		set
		{
			motion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMJGADLIONA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMJGADLIONA(HMJGADLIONA other)
		: this()
	{
		entityId_ = other.entityId_;
		motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMJGADLIONA Clone()
	{
		return new HMJGADLIONA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HMJGADLIONA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HMJGADLIONA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EntityId != other.EntityId)
		{
			return false;
		}
		if (!object.Equals(Motion, other.Motion))
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
		if (EntityId != 0)
		{
			num ^= EntityId.GetHashCode();
		}
		if (motion_ != null)
		{
			num ^= Motion.GetHashCode();
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
		if (EntityId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EntityId);
		}
		if (motion_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(Motion);
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
		if (EntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntityId);
		}
		if (motion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Motion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HMJGADLIONA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EntityId != 0)
		{
			EntityId = other.EntityId;
		}
		if (other.motion_ != null)
		{
			if (motion_ == null)
			{
				Motion = new MotionInfo();
			}
			Motion.MergeFrom(other.Motion);
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
			case 32u:
				EntityId = input.ReadUInt32();
				break;
			case 114u:
				if (motion_ == null)
				{
					Motion = new MotionInfo();
				}
				input.ReadMessage(Motion);
				break;
			}
		}
	}
}
