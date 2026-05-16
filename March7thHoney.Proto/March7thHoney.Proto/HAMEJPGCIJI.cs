using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HAMEJPGCIJI : IMessage<HAMEJPGCIJI>, IMessage, IEquatable<HAMEJPGCIJI>, IDeepCloneable<HAMEJPGCIJI>, IBufferMessage
{
	private static readonly MessageParser<HAMEJPGCIJI> _parser = new MessageParser<HAMEJPGCIJI>(() => new HAMEJPGCIJI());

	private UnknownFieldSet _unknownFields;

	public const int HFLIAJCNJPLFieldNumber = 2;

	private uint hFLIAJCNJPL_;

	public const int GHBNOAMOANDFieldNumber = 3;

	private uint gHBNOAMOAND_;

	public const int TotalDamageFieldNumber = 6;

	private uint totalDamage_;

	public const int TotalAutoTurnsFieldNumber = 7;

	private uint totalAutoTurns_;

	public const int CostTimeFieldNumber = 10;

	private uint costTime_;

	public const int TotalTurnsFieldNumber = 12;

	private uint totalTurns_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HAMEJPGCIJI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HAMEJPGCIJIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HFLIAJCNJPL
	{
		get
		{
			return hFLIAJCNJPL_;
		}
		set
		{
			hFLIAJCNJPL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GHBNOAMOAND
	{
		get
		{
			return gHBNOAMOAND_;
		}
		set
		{
			gHBNOAMOAND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalAutoTurns
	{
		get
		{
			return totalAutoTurns_;
		}
		set
		{
			totalAutoTurns_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CostTime
	{
		get
		{
			return costTime_;
		}
		set
		{
			costTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TotalTurns
	{
		get
		{
			return totalTurns_;
		}
		set
		{
			totalTurns_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAMEJPGCIJI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAMEJPGCIJI(HAMEJPGCIJI other)
		: this()
	{
		hFLIAJCNJPL_ = other.hFLIAJCNJPL_;
		gHBNOAMOAND_ = other.gHBNOAMOAND_;
		totalDamage_ = other.totalDamage_;
		totalAutoTurns_ = other.totalAutoTurns_;
		costTime_ = other.costTime_;
		totalTurns_ = other.totalTurns_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HAMEJPGCIJI Clone()
	{
		return new HAMEJPGCIJI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HAMEJPGCIJI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HAMEJPGCIJI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HFLIAJCNJPL != other.HFLIAJCNJPL)
		{
			return false;
		}
		if (GHBNOAMOAND != other.GHBNOAMOAND)
		{
			return false;
		}
		if (TotalDamage != other.TotalDamage)
		{
			return false;
		}
		if (TotalAutoTurns != other.TotalAutoTurns)
		{
			return false;
		}
		if (CostTime != other.CostTime)
		{
			return false;
		}
		if (TotalTurns != other.TotalTurns)
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
		if (HFLIAJCNJPL != 0)
		{
			num ^= HFLIAJCNJPL.GetHashCode();
		}
		if (GHBNOAMOAND != 0)
		{
			num ^= GHBNOAMOAND.GetHashCode();
		}
		if (TotalDamage != 0)
		{
			num ^= TotalDamage.GetHashCode();
		}
		if (TotalAutoTurns != 0)
		{
			num ^= TotalAutoTurns.GetHashCode();
		}
		if (CostTime != 0)
		{
			num ^= CostTime.GetHashCode();
		}
		if (TotalTurns != 0)
		{
			num ^= TotalTurns.GetHashCode();
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
		if (HFLIAJCNJPL != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(HFLIAJCNJPL);
		}
		if (GHBNOAMOAND != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GHBNOAMOAND);
		}
		if (TotalDamage != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(TotalDamage);
		}
		if (TotalAutoTurns != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(TotalAutoTurns);
		}
		if (CostTime != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CostTime);
		}
		if (TotalTurns != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(TotalTurns);
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
		if (HFLIAJCNJPL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HFLIAJCNJPL);
		}
		if (GHBNOAMOAND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GHBNOAMOAND);
		}
		if (TotalDamage != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalDamage);
		}
		if (TotalAutoTurns != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalAutoTurns);
		}
		if (CostTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CostTime);
		}
		if (TotalTurns != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalTurns);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HAMEJPGCIJI other)
	{
		if (other != null)
		{
			if (other.HFLIAJCNJPL != 0)
			{
				HFLIAJCNJPL = other.HFLIAJCNJPL;
			}
			if (other.GHBNOAMOAND != 0)
			{
				GHBNOAMOAND = other.GHBNOAMOAND;
			}
			if (other.TotalDamage != 0)
			{
				TotalDamage = other.TotalDamage;
			}
			if (other.TotalAutoTurns != 0)
			{
				TotalAutoTurns = other.TotalAutoTurns;
			}
			if (other.CostTime != 0)
			{
				CostTime = other.CostTime;
			}
			if (other.TotalTurns != 0)
			{
				TotalTurns = other.TotalTurns;
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
				HFLIAJCNJPL = input.ReadUInt32();
				break;
			case 24u:
				GHBNOAMOAND = input.ReadUInt32();
				break;
			case 48u:
				TotalDamage = input.ReadUInt32();
				break;
			case 56u:
				TotalAutoTurns = input.ReadUInt32();
				break;
			case 80u:
				CostTime = input.ReadUInt32();
				break;
			case 96u:
				TotalTurns = input.ReadUInt32();
				break;
			}
		}
	}
}
