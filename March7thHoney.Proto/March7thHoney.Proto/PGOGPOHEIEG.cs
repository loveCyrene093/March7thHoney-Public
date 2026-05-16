using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PGOGPOHEIEG : IMessage<PGOGPOHEIEG>, IMessage, IEquatable<PGOGPOHEIEG>, IDeepCloneable<PGOGPOHEIEG>, IBufferMessage
{
	private static readonly MessageParser<PGOGPOHEIEG> _parser = new MessageParser<PGOGPOHEIEG>(() => new PGOGPOHEIEG());

	private UnknownFieldSet _unknownFields;

	public const int FIFHKNHEIBDFieldNumber = 1;

	private uint fIFHKNHEIBD_;

	public const int ELHIABGCKIEFieldNumber = 2;

	private uint eLHIABGCKIE_;

	public const int EntityIdFieldNumber = 3;

	private uint entityId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PGOGPOHEIEG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PGOGPOHEIEGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIFHKNHEIBD
	{
		get
		{
			return fIFHKNHEIBD_;
		}
		set
		{
			fIFHKNHEIBD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ELHIABGCKIE
	{
		get
		{
			return eLHIABGCKIE_;
		}
		set
		{
			eLHIABGCKIE_ = value;
		}
	}

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
	public PGOGPOHEIEG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGOGPOHEIEG(PGOGPOHEIEG other)
		: this()
	{
		fIFHKNHEIBD_ = other.fIFHKNHEIBD_;
		eLHIABGCKIE_ = other.eLHIABGCKIE_;
		entityId_ = other.entityId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGOGPOHEIEG Clone()
	{
		return new PGOGPOHEIEG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PGOGPOHEIEG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PGOGPOHEIEG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FIFHKNHEIBD != other.FIFHKNHEIBD)
		{
			return false;
		}
		if (ELHIABGCKIE != other.ELHIABGCKIE)
		{
			return false;
		}
		if (EntityId != other.EntityId)
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
		if (FIFHKNHEIBD != 0)
		{
			num ^= FIFHKNHEIBD.GetHashCode();
		}
		if (ELHIABGCKIE != 0)
		{
			num ^= ELHIABGCKIE.GetHashCode();
		}
		if (EntityId != 0)
		{
			num ^= EntityId.GetHashCode();
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
		if (FIFHKNHEIBD != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(FIFHKNHEIBD);
		}
		if (ELHIABGCKIE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ELHIABGCKIE);
		}
		if (EntityId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EntityId);
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
		if (FIFHKNHEIBD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIFHKNHEIBD);
		}
		if (ELHIABGCKIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ELHIABGCKIE);
		}
		if (EntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EntityId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PGOGPOHEIEG other)
	{
		if (other != null)
		{
			if (other.FIFHKNHEIBD != 0)
			{
				FIFHKNHEIBD = other.FIFHKNHEIBD;
			}
			if (other.ELHIABGCKIE != 0)
			{
				ELHIABGCKIE = other.ELHIABGCKIE;
			}
			if (other.EntityId != 0)
			{
				EntityId = other.EntityId;
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
			case 8u:
				FIFHKNHEIBD = input.ReadUInt32();
				break;
			case 16u:
				ELHIABGCKIE = input.ReadUInt32();
				break;
			case 24u:
				EntityId = input.ReadUInt32();
				break;
			}
		}
	}
}
