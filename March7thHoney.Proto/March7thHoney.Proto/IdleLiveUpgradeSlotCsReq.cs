using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveUpgradeSlotCsReq : IMessage<IdleLiveUpgradeSlotCsReq>, IMessage, IEquatable<IdleLiveUpgradeSlotCsReq>, IDeepCloneable<IdleLiveUpgradeSlotCsReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveUpgradeSlotCsReq> _parser = new MessageParser<IdleLiveUpgradeSlotCsReq>(() => new IdleLiveUpgradeSlotCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JNGHMOPEKJOFieldNumber = 12;

	private uint jNGHMOPEKJO_;

	public const int LevelFieldNumber = 13;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveUpgradeSlotCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveUpgradeSlotCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JNGHMOPEKJO
	{
		get
		{
			return jNGHMOPEKJO_;
		}
		set
		{
			jNGHMOPEKJO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveUpgradeSlotCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveUpgradeSlotCsReq(IdleLiveUpgradeSlotCsReq other)
		: this()
	{
		jNGHMOPEKJO_ = other.jNGHMOPEKJO_;
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveUpgradeSlotCsReq Clone()
	{
		return new IdleLiveUpgradeSlotCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveUpgradeSlotCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveUpgradeSlotCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JNGHMOPEKJO != other.JNGHMOPEKJO)
		{
			return false;
		}
		if (Level != other.Level)
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
		if (JNGHMOPEKJO != 0)
		{
			num ^= JNGHMOPEKJO.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
		if (JNGHMOPEKJO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(JNGHMOPEKJO);
		}
		if (Level != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Level);
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
		if (JNGHMOPEKJO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JNGHMOPEKJO);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveUpgradeSlotCsReq other)
	{
		if (other != null)
		{
			if (other.JNGHMOPEKJO != 0)
			{
				JNGHMOPEKJO = other.JNGHMOPEKJO;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
			case 96u:
				JNGHMOPEKJO = input.ReadUInt32();
				break;
			case 104u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
