using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MarkItemCsReq : IMessage<MarkItemCsReq>, IMessage, IEquatable<MarkItemCsReq>, IDeepCloneable<MarkItemCsReq>, IBufferMessage
{
	private static readonly MessageParser<MarkItemCsReq> _parser = new MessageParser<MarkItemCsReq>(() => new MarkItemCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EKLCFBIPGGOFieldNumber = 9;

	private bool eKLCFBIPGGO_;

	public const int ItemIdFieldNumber = 13;

	private uint itemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MarkItemCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MarkItemCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EKLCFBIPGGO
	{
		get
		{
			return eKLCFBIPGGO_;
		}
		set
		{
			eKLCFBIPGGO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkItemCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkItemCsReq(MarkItemCsReq other)
		: this()
	{
		eKLCFBIPGGO_ = other.eKLCFBIPGGO_;
		itemId_ = other.itemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkItemCsReq Clone()
	{
		return new MarkItemCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MarkItemCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MarkItemCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EKLCFBIPGGO != other.EKLCFBIPGGO)
		{
			return false;
		}
		if (ItemId != other.ItemId)
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
		if (EKLCFBIPGGO)
		{
			num ^= EKLCFBIPGGO.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
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
		if (EKLCFBIPGGO)
		{
			output.WriteRawTag(72);
			output.WriteBool(EKLCFBIPGGO);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ItemId);
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
		if (EKLCFBIPGGO)
		{
			num += 2;
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MarkItemCsReq other)
	{
		if (other != null)
		{
			if (other.EKLCFBIPGGO)
			{
				EKLCFBIPGGO = other.EKLCFBIPGGO;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
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
			case 72u:
				EKLCFBIPGGO = input.ReadBool();
				break;
			case 104u:
				ItemId = input.ReadUInt32();
				break;
			}
		}
	}
}
