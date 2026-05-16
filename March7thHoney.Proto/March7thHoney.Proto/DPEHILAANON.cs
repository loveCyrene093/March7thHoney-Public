using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPEHILAANON : IMessage<DPEHILAANON>, IMessage, IEquatable<DPEHILAANON>, IDeepCloneable<DPEHILAANON>, IBufferMessage
{
	private static readonly MessageParser<DPEHILAANON> _parser = new MessageParser<DPEHILAANON>(() => new DPEHILAANON());

	private UnknownFieldSet _unknownFields;

	public const int DEAKOOEBLJLFieldNumber = 2;

	private uint dEAKOOEBLJL_;

	public const int GridFightEquipmentIdFieldNumber = 3;

	private uint gridFightEquipmentId_;

	public const int HLKAFPCLMEOFieldNumber = 5;

	private bool hLKAFPCLMEO_;

	public const int HJMJIADBAOCFieldNumber = 11;

	private uint hJMJIADBAOC_;

	public const int DDGEOOLHAPGFieldNumber = 14;

	private uint dDGEOOLHAPG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPEHILAANON> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPEHILAANONReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DEAKOOEBLJL
	{
		get
		{
			return dEAKOOEBLJL_;
		}
		set
		{
			dEAKOOEBLJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightEquipmentId
	{
		get
		{
			return gridFightEquipmentId_;
		}
		set
		{
			gridFightEquipmentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HLKAFPCLMEO
	{
		get
		{
			return hLKAFPCLMEO_;
		}
		set
		{
			hLKAFPCLMEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJMJIADBAOC
	{
		get
		{
			return hJMJIADBAOC_;
		}
		set
		{
			hJMJIADBAOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DDGEOOLHAPG
	{
		get
		{
			return dDGEOOLHAPG_;
		}
		set
		{
			dDGEOOLHAPG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPEHILAANON()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPEHILAANON(DPEHILAANON other)
		: this()
	{
		dEAKOOEBLJL_ = other.dEAKOOEBLJL_;
		gridFightEquipmentId_ = other.gridFightEquipmentId_;
		hLKAFPCLMEO_ = other.hLKAFPCLMEO_;
		hJMJIADBAOC_ = other.hJMJIADBAOC_;
		dDGEOOLHAPG_ = other.dDGEOOLHAPG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPEHILAANON Clone()
	{
		return new DPEHILAANON(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPEHILAANON);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPEHILAANON other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DEAKOOEBLJL != other.DEAKOOEBLJL)
		{
			return false;
		}
		if (GridFightEquipmentId != other.GridFightEquipmentId)
		{
			return false;
		}
		if (HLKAFPCLMEO != other.HLKAFPCLMEO)
		{
			return false;
		}
		if (HJMJIADBAOC != other.HJMJIADBAOC)
		{
			return false;
		}
		if (DDGEOOLHAPG != other.DDGEOOLHAPG)
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
		if (DEAKOOEBLJL != 0)
		{
			num ^= DEAKOOEBLJL.GetHashCode();
		}
		if (GridFightEquipmentId != 0)
		{
			num ^= GridFightEquipmentId.GetHashCode();
		}
		if (HLKAFPCLMEO)
		{
			num ^= HLKAFPCLMEO.GetHashCode();
		}
		if (HJMJIADBAOC != 0)
		{
			num ^= HJMJIADBAOC.GetHashCode();
		}
		if (DDGEOOLHAPG != 0)
		{
			num ^= DDGEOOLHAPG.GetHashCode();
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
		if (DEAKOOEBLJL != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DEAKOOEBLJL);
		}
		if (GridFightEquipmentId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GridFightEquipmentId);
		}
		if (HLKAFPCLMEO)
		{
			output.WriteRawTag(40);
			output.WriteBool(HLKAFPCLMEO);
		}
		if (HJMJIADBAOC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(HJMJIADBAOC);
		}
		if (DDGEOOLHAPG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(DDGEOOLHAPG);
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
		if (DEAKOOEBLJL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DEAKOOEBLJL);
		}
		if (GridFightEquipmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightEquipmentId);
		}
		if (HLKAFPCLMEO)
		{
			num += 2;
		}
		if (HJMJIADBAOC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJMJIADBAOC);
		}
		if (DDGEOOLHAPG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DDGEOOLHAPG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPEHILAANON other)
	{
		if (other != null)
		{
			if (other.DEAKOOEBLJL != 0)
			{
				DEAKOOEBLJL = other.DEAKOOEBLJL;
			}
			if (other.GridFightEquipmentId != 0)
			{
				GridFightEquipmentId = other.GridFightEquipmentId;
			}
			if (other.HLKAFPCLMEO)
			{
				HLKAFPCLMEO = other.HLKAFPCLMEO;
			}
			if (other.HJMJIADBAOC != 0)
			{
				HJMJIADBAOC = other.HJMJIADBAOC;
			}
			if (other.DDGEOOLHAPG != 0)
			{
				DDGEOOLHAPG = other.DDGEOOLHAPG;
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
			case 16u:
				DEAKOOEBLJL = input.ReadUInt32();
				break;
			case 24u:
				GridFightEquipmentId = input.ReadUInt32();
				break;
			case 40u:
				HLKAFPCLMEO = input.ReadBool();
				break;
			case 88u:
				HJMJIADBAOC = input.ReadUInt32();
				break;
			case 112u:
				DDGEOOLHAPG = input.ReadUInt32();
				break;
			}
		}
	}
}
