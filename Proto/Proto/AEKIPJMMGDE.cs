using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AEKIPJMMGDE : IMessage<AEKIPJMMGDE>, IMessage, IEquatable<AEKIPJMMGDE>, IDeepCloneable<AEKIPJMMGDE>, IBufferMessage
{
	private static readonly MessageParser<AEKIPJMMGDE> _parser = new MessageParser<AEKIPJMMGDE>(() => new AEKIPJMMGDE());

	private UnknownFieldSet _unknownFields;

	public const int ItemIdFieldNumber = 1;

	private uint itemId_;

	public const int ODJNMLMKKFEFieldNumber = 2;

	private uint oDJNMLMKKFE_;

	public const int SkillIdFieldNumber = 3;

	private uint skillId_;

	public const int DisplayValueFieldNumber = 4;

	private int displayValue_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AEKIPJMMGDE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AEKIPJMMGDEReflection.Descriptor.MessageTypes[0];

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
	public uint ODJNMLMKKFE
	{
		get
		{
			return oDJNMLMKKFE_;
		}
		set
		{
			oDJNMLMKKFE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DisplayValue
	{
		get
		{
			return displayValue_;
		}
		set
		{
			displayValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEKIPJMMGDE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEKIPJMMGDE(AEKIPJMMGDE other)
		: this()
	{
		itemId_ = other.itemId_;
		oDJNMLMKKFE_ = other.oDJNMLMKKFE_;
		skillId_ = other.skillId_;
		displayValue_ = other.displayValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEKIPJMMGDE Clone()
	{
		return new AEKIPJMMGDE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AEKIPJMMGDE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AEKIPJMMGDE other)
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
		if (ODJNMLMKKFE != other.ODJNMLMKKFE)
		{
			return false;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (DisplayValue != other.DisplayValue)
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
		if (ODJNMLMKKFE != 0)
		{
			num ^= ODJNMLMKKFE.GetHashCode();
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (DisplayValue != 0)
		{
			num ^= DisplayValue.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(ItemId);
		}
		if (ODJNMLMKKFE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ODJNMLMKKFE);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(SkillId);
		}
		if (DisplayValue != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DisplayValue);
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
		if (ODJNMLMKKFE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODJNMLMKKFE);
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillId);
		}
		if (DisplayValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DisplayValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AEKIPJMMGDE other)
	{
		if (other != null)
		{
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.ODJNMLMKKFE != 0)
			{
				ODJNMLMKKFE = other.ODJNMLMKKFE;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.DisplayValue != 0)
			{
				DisplayValue = other.DisplayValue;
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
				ItemId = input.ReadUInt32();
				break;
			case 16u:
				ODJNMLMKKFE = input.ReadUInt32();
				break;
			case 24u:
				SkillId = input.ReadUInt32();
				break;
			case 32u:
				DisplayValue = input.ReadInt32();
				break;
			}
		}
	}
}
