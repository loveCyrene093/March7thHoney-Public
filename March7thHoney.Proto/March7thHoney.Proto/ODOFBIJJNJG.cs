using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ODOFBIJJNJG : IMessage<ODOFBIJJNJG>, IMessage, IEquatable<ODOFBIJJNJG>, IDeepCloneable<ODOFBIJJNJG>, IBufferMessage
{
	private static readonly MessageParser<ODOFBIJJNJG> _parser = new MessageParser<ODOFBIJJNJG>(() => new ODOFBIJJNJG());

	private UnknownFieldSet _unknownFields;

	public const int AOKDBDGDCHBFieldNumber = 1;

	private uint aOKDBDGDCHB_;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int HLKAFPCLMEOFieldNumber = 3;

	private bool hLKAFPCLMEO_;

	public const int DiceSlotIdFieldNumber = 4;

	private uint diceSlotId_;

	public const int JKBLMPEHIHMFieldNumber = 5;

	private static readonly MapField<uint, uint>.Codec _map_jKBLMPEHIHM_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 42u);

	private readonly MapField<uint, uint> jKBLMPEHIHM_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ODOFBIJJNJG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ODOFBIJJNJGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AOKDBDGDCHB
	{
		get
		{
			return aOKDBDGDCHB_;
		}
		set
		{
			aOKDBDGDCHB_ = value;
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
	public uint DiceSlotId
	{
		get
		{
			return diceSlotId_;
		}
		set
		{
			diceSlotId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> JKBLMPEHIHM => jKBLMPEHIHM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODOFBIJJNJG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODOFBIJJNJG(ODOFBIJJNJG other)
		: this()
	{
		aOKDBDGDCHB_ = other.aOKDBDGDCHB_;
		level_ = other.level_;
		hLKAFPCLMEO_ = other.hLKAFPCLMEO_;
		diceSlotId_ = other.diceSlotId_;
		jKBLMPEHIHM_ = other.jKBLMPEHIHM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODOFBIJJNJG Clone()
	{
		return new ODOFBIJJNJG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ODOFBIJJNJG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ODOFBIJJNJG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AOKDBDGDCHB != other.AOKDBDGDCHB)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (HLKAFPCLMEO != other.HLKAFPCLMEO)
		{
			return false;
		}
		if (DiceSlotId != other.DiceSlotId)
		{
			return false;
		}
		if (!JKBLMPEHIHM.Equals(other.JKBLMPEHIHM))
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
		if (AOKDBDGDCHB != 0)
		{
			num ^= AOKDBDGDCHB.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (HLKAFPCLMEO)
		{
			num ^= HLKAFPCLMEO.GetHashCode();
		}
		if (DiceSlotId != 0)
		{
			num ^= DiceSlotId.GetHashCode();
		}
		num ^= JKBLMPEHIHM.GetHashCode();
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
		if (AOKDBDGDCHB != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AOKDBDGDCHB);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		if (HLKAFPCLMEO)
		{
			output.WriteRawTag(24);
			output.WriteBool(HLKAFPCLMEO);
		}
		if (DiceSlotId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DiceSlotId);
		}
		jKBLMPEHIHM_.WriteTo(ref output, _map_jKBLMPEHIHM_codec);
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
		if (AOKDBDGDCHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOKDBDGDCHB);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (HLKAFPCLMEO)
		{
			num += 2;
		}
		if (DiceSlotId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DiceSlotId);
		}
		num += jKBLMPEHIHM_.CalculateSize(_map_jKBLMPEHIHM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ODOFBIJJNJG other)
	{
		if (other != null)
		{
			if (other.AOKDBDGDCHB != 0)
			{
				AOKDBDGDCHB = other.AOKDBDGDCHB;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.HLKAFPCLMEO)
			{
				HLKAFPCLMEO = other.HLKAFPCLMEO;
			}
			if (other.DiceSlotId != 0)
			{
				DiceSlotId = other.DiceSlotId;
			}
			jKBLMPEHIHM_.MergeFrom(other.jKBLMPEHIHM_);
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
				AOKDBDGDCHB = input.ReadUInt32();
				break;
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 24u:
				HLKAFPCLMEO = input.ReadBool();
				break;
			case 32u:
				DiceSlotId = input.ReadUInt32();
				break;
			case 42u:
				jKBLMPEHIHM_.AddEntriesFrom(ref input, _map_jKBLMPEHIHM_codec);
				break;
			}
		}
	}
}
