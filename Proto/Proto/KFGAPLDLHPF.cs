using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KFGAPLDLHPF : IMessage<KFGAPLDLHPF>, IMessage, IEquatable<KFGAPLDLHPF>, IDeepCloneable<KFGAPLDLHPF>, IBufferMessage
{
	private static readonly MessageParser<KFGAPLDLHPF> _parser = new MessageParser<KFGAPLDLHPF>(() => new KFGAPLDLHPF());

	private UnknownFieldSet _unknownFields;

	public const int NumFieldNumber = 9;

	private uint num_;

	public const int GPEAFAJGCPHFieldNumber = 11;

	private uint gPEAFAJGCPH_;

	public const int ItemIdFieldNumber = 13;

	private uint itemId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KFGAPLDLHPF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KFGAPLDLHPFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPEAFAJGCPH
	{
		get
		{
			return gPEAFAJGCPH_;
		}
		set
		{
			gPEAFAJGCPH_ = value;
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
	public KFGAPLDLHPF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFGAPLDLHPF(KFGAPLDLHPF other)
		: this()
	{
		num_ = other.num_;
		gPEAFAJGCPH_ = other.gPEAFAJGCPH_;
		itemId_ = other.itemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFGAPLDLHPF Clone()
	{
		return new KFGAPLDLHPF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KFGAPLDLHPF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KFGAPLDLHPF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Num != other.Num)
		{
			return false;
		}
		if (GPEAFAJGCPH != other.GPEAFAJGCPH)
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
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (GPEAFAJGCPH != 0)
		{
			num ^= GPEAFAJGCPH.GetHashCode();
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
		if (Num != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Num);
		}
		if (GPEAFAJGCPH != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GPEAFAJGCPH);
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
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Num);
		}
		if (GPEAFAJGCPH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPEAFAJGCPH);
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
	public void MergeFrom(KFGAPLDLHPF other)
	{
		if (other != null)
		{
			if (other.Num != 0)
			{
				Num = other.Num;
			}
			if (other.GPEAFAJGCPH != 0)
			{
				GPEAFAJGCPH = other.GPEAFAJGCPH;
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
				Num = input.ReadUInt32();
				break;
			case 88u:
				GPEAFAJGCPH = input.ReadUInt32();
				break;
			case 104u:
				ItemId = input.ReadUInt32();
				break;
			}
		}
	}
}
