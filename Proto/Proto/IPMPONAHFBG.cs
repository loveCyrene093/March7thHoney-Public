using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IPMPONAHFBG : IMessage<IPMPONAHFBG>, IMessage, IEquatable<IPMPONAHFBG>, IDeepCloneable<IPMPONAHFBG>, IBufferMessage
{
	private static readonly MessageParser<IPMPONAHFBG> _parser = new MessageParser<IPMPONAHFBG>(() => new IPMPONAHFBG());

	private UnknownFieldSet _unknownFields;

	public const int JFJJLGFCOMOFieldNumber = 2;

	private uint jFJJLGFCOMO_;

	public const int TotalAutoTurnsFieldNumber = 10;

	private uint totalAutoTurns_;

	public const int GHBNOAMOANDFieldNumber = 11;

	private uint gHBNOAMOAND_;

	public const int IEDPBIABBCKFieldNumber = 12;

	private uint iEDPBIABBCK_;

	public const int TotalTurnsFieldNumber = 14;

	private uint totalTurns_;

	public const int HFLIAJCNJPLFieldNumber = 15;

	private uint hFLIAJCNJPL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IPMPONAHFBG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IPMPONAHFBGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JFJJLGFCOMO
	{
		get
		{
			return jFJJLGFCOMO_;
		}
		set
		{
			jFJJLGFCOMO_ = value;
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
	public uint IEDPBIABBCK
	{
		get
		{
			return iEDPBIABBCK_;
		}
		set
		{
			iEDPBIABBCK_ = value;
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
	public IPMPONAHFBG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPMPONAHFBG(IPMPONAHFBG other)
		: this()
	{
		jFJJLGFCOMO_ = other.jFJJLGFCOMO_;
		totalAutoTurns_ = other.totalAutoTurns_;
		gHBNOAMOAND_ = other.gHBNOAMOAND_;
		iEDPBIABBCK_ = other.iEDPBIABBCK_;
		totalTurns_ = other.totalTurns_;
		hFLIAJCNJPL_ = other.hFLIAJCNJPL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IPMPONAHFBG Clone()
	{
		return new IPMPONAHFBG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IPMPONAHFBG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IPMPONAHFBG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JFJJLGFCOMO != other.JFJJLGFCOMO)
		{
			return false;
		}
		if (TotalAutoTurns != other.TotalAutoTurns)
		{
			return false;
		}
		if (GHBNOAMOAND != other.GHBNOAMOAND)
		{
			return false;
		}
		if (IEDPBIABBCK != other.IEDPBIABBCK)
		{
			return false;
		}
		if (TotalTurns != other.TotalTurns)
		{
			return false;
		}
		if (HFLIAJCNJPL != other.HFLIAJCNJPL)
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
		if (JFJJLGFCOMO != 0)
		{
			num ^= JFJJLGFCOMO.GetHashCode();
		}
		if (TotalAutoTurns != 0)
		{
			num ^= TotalAutoTurns.GetHashCode();
		}
		if (GHBNOAMOAND != 0)
		{
			num ^= GHBNOAMOAND.GetHashCode();
		}
		if (IEDPBIABBCK != 0)
		{
			num ^= IEDPBIABBCK.GetHashCode();
		}
		if (TotalTurns != 0)
		{
			num ^= TotalTurns.GetHashCode();
		}
		if (HFLIAJCNJPL != 0)
		{
			num ^= HFLIAJCNJPL.GetHashCode();
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
		if (JFJJLGFCOMO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JFJJLGFCOMO);
		}
		if (TotalAutoTurns != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(TotalAutoTurns);
		}
		if (GHBNOAMOAND != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GHBNOAMOAND);
		}
		if (IEDPBIABBCK != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(IEDPBIABBCK);
		}
		if (TotalTurns != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(TotalTurns);
		}
		if (HFLIAJCNJPL != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HFLIAJCNJPL);
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
		if (JFJJLGFCOMO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JFJJLGFCOMO);
		}
		if (TotalAutoTurns != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalAutoTurns);
		}
		if (GHBNOAMOAND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GHBNOAMOAND);
		}
		if (IEDPBIABBCK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IEDPBIABBCK);
		}
		if (TotalTurns != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TotalTurns);
		}
		if (HFLIAJCNJPL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HFLIAJCNJPL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IPMPONAHFBG other)
	{
		if (other != null)
		{
			if (other.JFJJLGFCOMO != 0)
			{
				JFJJLGFCOMO = other.JFJJLGFCOMO;
			}
			if (other.TotalAutoTurns != 0)
			{
				TotalAutoTurns = other.TotalAutoTurns;
			}
			if (other.GHBNOAMOAND != 0)
			{
				GHBNOAMOAND = other.GHBNOAMOAND;
			}
			if (other.IEDPBIABBCK != 0)
			{
				IEDPBIABBCK = other.IEDPBIABBCK;
			}
			if (other.TotalTurns != 0)
			{
				TotalTurns = other.TotalTurns;
			}
			if (other.HFLIAJCNJPL != 0)
			{
				HFLIAJCNJPL = other.HFLIAJCNJPL;
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
				JFJJLGFCOMO = input.ReadUInt32();
				break;
			case 80u:
				TotalAutoTurns = input.ReadUInt32();
				break;
			case 88u:
				GHBNOAMOAND = input.ReadUInt32();
				break;
			case 96u:
				IEDPBIABBCK = input.ReadUInt32();
				break;
			case 112u:
				TotalTurns = input.ReadUInt32();
				break;
			case 120u:
				HFLIAJCNJPL = input.ReadUInt32();
				break;
			}
		}
	}
}
