using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwitchAetherDivideLineUpSlotCsReq : IMessage<SwitchAetherDivideLineUpSlotCsReq>, IMessage, IEquatable<SwitchAetherDivideLineUpSlotCsReq>, IDeepCloneable<SwitchAetherDivideLineUpSlotCsReq>, IBufferMessage
{
	private static readonly MessageParser<SwitchAetherDivideLineUpSlotCsReq> _parser = new MessageParser<SwitchAetherDivideLineUpSlotCsReq>(() => new SwitchAetherDivideLineUpSlotCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FNCINGFDLPAFieldNumber = 6;

	private uint fNCINGFDLPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwitchAetherDivideLineUpSlotCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwitchAetherDivideLineUpSlotCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FNCINGFDLPA
	{
		get
		{
			return fNCINGFDLPA_;
		}
		set
		{
			fNCINGFDLPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchAetherDivideLineUpSlotCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchAetherDivideLineUpSlotCsReq(SwitchAetherDivideLineUpSlotCsReq other)
		: this()
	{
		fNCINGFDLPA_ = other.fNCINGFDLPA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchAetherDivideLineUpSlotCsReq Clone()
	{
		return new SwitchAetherDivideLineUpSlotCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwitchAetherDivideLineUpSlotCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwitchAetherDivideLineUpSlotCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FNCINGFDLPA != other.FNCINGFDLPA)
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
		if (FNCINGFDLPA != 0)
		{
			num ^= FNCINGFDLPA.GetHashCode();
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
		if (FNCINGFDLPA != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(FNCINGFDLPA);
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
		if (FNCINGFDLPA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FNCINGFDLPA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SwitchAetherDivideLineUpSlotCsReq other)
	{
		if (other != null)
		{
			if (other.FNCINGFDLPA != 0)
			{
				FNCINGFDLPA = other.FNCINGFDLPA;
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
			if (num != 48)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				FNCINGFDLPA = input.ReadUInt32();
			}
		}
	}
}
