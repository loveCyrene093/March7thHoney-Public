using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GLHDNGFKAAD : IMessage<GLHDNGFKAAD>, IMessage, IEquatable<GLHDNGFKAAD>, IDeepCloneable<GLHDNGFKAAD>, IBufferMessage
{
	private static readonly MessageParser<GLHDNGFKAAD> _parser = new MessageParser<GLHDNGFKAAD>(() => new GLHDNGFKAAD());

	private UnknownFieldSet _unknownFields;

	public const int ItemIdFieldNumber = 3;

	private uint itemId_;

	public const int PIMJEDELOHNFieldNumber = 4;

	private uint pIMJEDELOHN_;

	public const int LAALPMJGMLNFieldNumber = 7;

	private ItemCostData lAALPMJGMLN_;

	public const int DKJFDLKJLBEFieldNumber = 10;

	private bool dKJFDLKJLBE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GLHDNGFKAAD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GLHDNGFKAADReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint PIMJEDELOHN
	{
		get
		{
			return pIMJEDELOHN_;
		}
		set
		{
			pIMJEDELOHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData LAALPMJGMLN
	{
		get
		{
			return lAALPMJGMLN_;
		}
		set
		{
			lAALPMJGMLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DKJFDLKJLBE
	{
		get
		{
			return dKJFDLKJLBE_;
		}
		set
		{
			dKJFDLKJLBE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLHDNGFKAAD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLHDNGFKAAD(GLHDNGFKAAD other)
		: this()
	{
		itemId_ = other.itemId_;
		pIMJEDELOHN_ = other.pIMJEDELOHN_;
		lAALPMJGMLN_ = ((other.lAALPMJGMLN_ != null) ? other.lAALPMJGMLN_.Clone() : null);
		dKJFDLKJLBE_ = other.dKJFDLKJLBE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GLHDNGFKAAD Clone()
	{
		return new GLHDNGFKAAD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GLHDNGFKAAD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GLHDNGFKAAD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (PIMJEDELOHN != other.PIMJEDELOHN)
		{
			return false;
		}
		if (!object.Equals(LAALPMJGMLN, other.LAALPMJGMLN))
		{
			return false;
		}
		if (DKJFDLKJLBE != other.DKJFDLKJLBE)
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
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (PIMJEDELOHN != 0)
		{
			num ^= PIMJEDELOHN.GetHashCode();
		}
		if (lAALPMJGMLN_ != null)
		{
			num ^= LAALPMJGMLN.GetHashCode();
		}
		if (DKJFDLKJLBE)
		{
			num ^= DKJFDLKJLBE.GetHashCode();
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
		if (ItemId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ItemId);
		}
		if (PIMJEDELOHN != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(PIMJEDELOHN);
		}
		if (lAALPMJGMLN_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(LAALPMJGMLN);
		}
		if (DKJFDLKJLBE)
		{
			output.WriteRawTag(80);
			output.WriteBool(DKJFDLKJLBE);
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
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (PIMJEDELOHN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PIMJEDELOHN);
		}
		if (lAALPMJGMLN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LAALPMJGMLN);
		}
		if (DKJFDLKJLBE)
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
	public void MergeFrom(GLHDNGFKAAD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ItemId != 0)
		{
			ItemId = other.ItemId;
		}
		if (other.PIMJEDELOHN != 0)
		{
			PIMJEDELOHN = other.PIMJEDELOHN;
		}
		if (other.lAALPMJGMLN_ != null)
		{
			if (lAALPMJGMLN_ == null)
			{
				LAALPMJGMLN = new ItemCostData();
			}
			LAALPMJGMLN.MergeFrom(other.LAALPMJGMLN);
		}
		if (other.DKJFDLKJLBE)
		{
			DKJFDLKJLBE = other.DKJFDLKJLBE;
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
			case 24u:
				ItemId = input.ReadUInt32();
				break;
			case 32u:
				PIMJEDELOHN = input.ReadUInt32();
				break;
			case 58u:
				if (lAALPMJGMLN_ == null)
				{
					LAALPMJGMLN = new ItemCostData();
				}
				input.ReadMessage(LAALPMJGMLN);
				break;
			case 80u:
				DKJFDLKJLBE = input.ReadBool();
				break;
			}
		}
	}
}
