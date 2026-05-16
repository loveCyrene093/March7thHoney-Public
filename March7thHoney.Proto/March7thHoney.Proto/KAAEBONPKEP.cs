using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KAAEBONPKEP : IMessage<KAAEBONPKEP>, IMessage, IEquatable<KAAEBONPKEP>, IDeepCloneable<KAAEBONPKEP>, IBufferMessage
{
	private static readonly MessageParser<KAAEBONPKEP> _parser = new MessageParser<KAAEBONPKEP>(() => new KAAEBONPKEP());

	private UnknownFieldSet _unknownFields;

	public const int JCCOOAEPGEDFieldNumber = 6;

	private uint jCCOOAEPGED_;

	public const int ENKBFGBBHKPFieldNumber = 7;

	private bool eNKBFGBBHKP_;

	public const int NHGHEBJCCCOFieldNumber = 13;

	private uint nHGHEBJCCCO_;

	public const int COOOFFKIDMCFieldNumber = 14;

	private uint cOOOFFKIDMC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KAAEBONPKEP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KAAEBONPKEPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JCCOOAEPGED
	{
		get
		{
			return jCCOOAEPGED_;
		}
		set
		{
			jCCOOAEPGED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ENKBFGBBHKP
	{
		get
		{
			return eNKBFGBBHKP_;
		}
		set
		{
			eNKBFGBBHKP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NHGHEBJCCCO
	{
		get
		{
			return nHGHEBJCCCO_;
		}
		set
		{
			nHGHEBJCCCO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COOOFFKIDMC
	{
		get
		{
			return cOOOFFKIDMC_;
		}
		set
		{
			cOOOFFKIDMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAAEBONPKEP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAAEBONPKEP(KAAEBONPKEP other)
		: this()
	{
		jCCOOAEPGED_ = other.jCCOOAEPGED_;
		eNKBFGBBHKP_ = other.eNKBFGBBHKP_;
		nHGHEBJCCCO_ = other.nHGHEBJCCCO_;
		cOOOFFKIDMC_ = other.cOOOFFKIDMC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAAEBONPKEP Clone()
	{
		return new KAAEBONPKEP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KAAEBONPKEP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KAAEBONPKEP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JCCOOAEPGED != other.JCCOOAEPGED)
		{
			return false;
		}
		if (ENKBFGBBHKP != other.ENKBFGBBHKP)
		{
			return false;
		}
		if (NHGHEBJCCCO != other.NHGHEBJCCCO)
		{
			return false;
		}
		if (COOOFFKIDMC != other.COOOFFKIDMC)
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
		if (JCCOOAEPGED != 0)
		{
			num ^= JCCOOAEPGED.GetHashCode();
		}
		if (ENKBFGBBHKP)
		{
			num ^= ENKBFGBBHKP.GetHashCode();
		}
		if (NHGHEBJCCCO != 0)
		{
			num ^= NHGHEBJCCCO.GetHashCode();
		}
		if (COOOFFKIDMC != 0)
		{
			num ^= COOOFFKIDMC.GetHashCode();
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
		if (JCCOOAEPGED != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(JCCOOAEPGED);
		}
		if (ENKBFGBBHKP)
		{
			output.WriteRawTag(56);
			output.WriteBool(ENKBFGBBHKP);
		}
		if (NHGHEBJCCCO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(NHGHEBJCCCO);
		}
		if (COOOFFKIDMC != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(COOOFFKIDMC);
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
		if (JCCOOAEPGED != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JCCOOAEPGED);
		}
		if (ENKBFGBBHKP)
		{
			num += 2;
		}
		if (NHGHEBJCCCO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NHGHEBJCCCO);
		}
		if (COOOFFKIDMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COOOFFKIDMC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KAAEBONPKEP other)
	{
		if (other != null)
		{
			if (other.JCCOOAEPGED != 0)
			{
				JCCOOAEPGED = other.JCCOOAEPGED;
			}
			if (other.ENKBFGBBHKP)
			{
				ENKBFGBBHKP = other.ENKBFGBBHKP;
			}
			if (other.NHGHEBJCCCO != 0)
			{
				NHGHEBJCCCO = other.NHGHEBJCCCO;
			}
			if (other.COOOFFKIDMC != 0)
			{
				COOOFFKIDMC = other.COOOFFKIDMC;
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
			case 48u:
				JCCOOAEPGED = input.ReadUInt32();
				break;
			case 56u:
				ENKBFGBBHKP = input.ReadBool();
				break;
			case 104u:
				NHGHEBJCCCO = input.ReadUInt32();
				break;
			case 112u:
				COOOFFKIDMC = input.ReadUInt32();
				break;
			}
		}
	}
}
