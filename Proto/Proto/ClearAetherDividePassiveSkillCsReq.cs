using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClearAetherDividePassiveSkillCsReq : IMessage<ClearAetherDividePassiveSkillCsReq>, IMessage, IEquatable<ClearAetherDividePassiveSkillCsReq>, IDeepCloneable<ClearAetherDividePassiveSkillCsReq>, IBufferMessage
{
	private static readonly MessageParser<ClearAetherDividePassiveSkillCsReq> _parser = new MessageParser<ClearAetherDividePassiveSkillCsReq>(() => new ClearAetherDividePassiveSkillCsReq());

	private UnknownFieldSet _unknownFields;

	public const int SlotFieldNumber = 7;

	private uint slot_;

	public const int IMMHJMDHDGCFieldNumber = 15;

	private uint iMMHJMDHDGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClearAetherDividePassiveSkillCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClearAetherDividePassiveSkillCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Slot
	{
		get
		{
			return slot_;
		}
		set
		{
			slot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IMMHJMDHDGC
	{
		get
		{
			return iMMHJMDHDGC_;
		}
		set
		{
			iMMHJMDHDGC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClearAetherDividePassiveSkillCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClearAetherDividePassiveSkillCsReq(ClearAetherDividePassiveSkillCsReq other)
		: this()
	{
		slot_ = other.slot_;
		iMMHJMDHDGC_ = other.iMMHJMDHDGC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClearAetherDividePassiveSkillCsReq Clone()
	{
		return new ClearAetherDividePassiveSkillCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClearAetherDividePassiveSkillCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClearAetherDividePassiveSkillCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Slot != other.Slot)
		{
			return false;
		}
		if (IMMHJMDHDGC != other.IMMHJMDHDGC)
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
		if (Slot != 0)
		{
			num ^= Slot.GetHashCode();
		}
		if (IMMHJMDHDGC != 0)
		{
			num ^= IMMHJMDHDGC.GetHashCode();
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
		if (Slot != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Slot);
		}
		if (IMMHJMDHDGC != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(IMMHJMDHDGC);
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
		if (Slot != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Slot);
		}
		if (IMMHJMDHDGC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IMMHJMDHDGC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClearAetherDividePassiveSkillCsReq other)
	{
		if (other != null)
		{
			if (other.Slot != 0)
			{
				Slot = other.Slot;
			}
			if (other.IMMHJMDHDGC != 0)
			{
				IMMHJMDHDGC = other.IMMHJMDHDGC;
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
			case 56u:
				Slot = input.ReadUInt32();
				break;
			case 120u:
				IMMHJMDHDGC = input.ReadUInt32();
				break;
			}
		}
	}
}
