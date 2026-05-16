using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RelicReforgeCsReq : IMessage<RelicReforgeCsReq>, IMessage, IEquatable<RelicReforgeCsReq>, IDeepCloneable<RelicReforgeCsReq>, IBufferMessage
{
	private static readonly MessageParser<RelicReforgeCsReq> _parser = new MessageParser<RelicReforgeCsReq>(() => new RelicReforgeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ReforgeBlockSubAffixIdFieldNumber = 6;

	private uint reforgeBlockSubAffixId_;

	public const int RelicUniqueIdFieldNumber = 15;

	private uint relicUniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RelicReforgeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RelicReforgeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ReforgeBlockSubAffixId
	{
		get
		{
			return reforgeBlockSubAffixId_;
		}
		set
		{
			reforgeBlockSubAffixId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RelicUniqueId
	{
		get
		{
			return relicUniqueId_;
		}
		set
		{
			relicUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicReforgeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicReforgeCsReq(RelicReforgeCsReq other)
		: this()
	{
		reforgeBlockSubAffixId_ = other.reforgeBlockSubAffixId_;
		relicUniqueId_ = other.relicUniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RelicReforgeCsReq Clone()
	{
		return new RelicReforgeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RelicReforgeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RelicReforgeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ReforgeBlockSubAffixId != other.ReforgeBlockSubAffixId)
		{
			return false;
		}
		if (RelicUniqueId != other.RelicUniqueId)
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
		if (ReforgeBlockSubAffixId != 0)
		{
			num ^= ReforgeBlockSubAffixId.GetHashCode();
		}
		if (RelicUniqueId != 0)
		{
			num ^= RelicUniqueId.GetHashCode();
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
		if (ReforgeBlockSubAffixId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ReforgeBlockSubAffixId);
		}
		if (RelicUniqueId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(RelicUniqueId);
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
		if (ReforgeBlockSubAffixId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ReforgeBlockSubAffixId);
		}
		if (RelicUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RelicUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RelicReforgeCsReq other)
	{
		if (other != null)
		{
			if (other.ReforgeBlockSubAffixId != 0)
			{
				ReforgeBlockSubAffixId = other.ReforgeBlockSubAffixId;
			}
			if (other.RelicUniqueId != 0)
			{
				RelicUniqueId = other.RelicUniqueId;
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
			case 48u:
				ReforgeBlockSubAffixId = input.ReadUInt32();
				break;
			case 120u:
				RelicUniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
