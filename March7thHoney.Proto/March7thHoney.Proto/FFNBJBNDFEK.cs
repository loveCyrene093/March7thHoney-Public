using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FFNBJBNDFEK : IMessage<FFNBJBNDFEK>, IMessage, IEquatable<FFNBJBNDFEK>, IDeepCloneable<FFNBJBNDFEK>, IBufferMessage
{
	private static readonly MessageParser<FFNBJBNDFEK> _parser = new MessageParser<FFNBJBNDFEK>(() => new FFNBJBNDFEK());

	private UnknownFieldSet _unknownFields;

	public const int PEJMPHMPPKOFieldNumber = 1;

	private uint pEJMPHMPPKO_;

	public const int FHADIOPDMHPFieldNumber = 2;

	private uint fHADIOPDMHP_;

	public const int LMEEJJNOFIEFieldNumber = 3;

	private uint lMEEJJNOFIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FFNBJBNDFEK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FFNBJBNDFEKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PEJMPHMPPKO
	{
		get
		{
			return pEJMPHMPPKO_;
		}
		set
		{
			pEJMPHMPPKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FHADIOPDMHP
	{
		get
		{
			return fHADIOPDMHP_;
		}
		set
		{
			fHADIOPDMHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LMEEJJNOFIE
	{
		get
		{
			return lMEEJJNOFIE_;
		}
		set
		{
			lMEEJJNOFIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFNBJBNDFEK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFNBJBNDFEK(FFNBJBNDFEK other)
		: this()
	{
		pEJMPHMPPKO_ = other.pEJMPHMPPKO_;
		fHADIOPDMHP_ = other.fHADIOPDMHP_;
		lMEEJJNOFIE_ = other.lMEEJJNOFIE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFNBJBNDFEK Clone()
	{
		return new FFNBJBNDFEK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FFNBJBNDFEK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FFNBJBNDFEK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PEJMPHMPPKO != other.PEJMPHMPPKO)
		{
			return false;
		}
		if (FHADIOPDMHP != other.FHADIOPDMHP)
		{
			return false;
		}
		if (LMEEJJNOFIE != other.LMEEJJNOFIE)
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
		if (PEJMPHMPPKO != 0)
		{
			num ^= PEJMPHMPPKO.GetHashCode();
		}
		if (FHADIOPDMHP != 0)
		{
			num ^= FHADIOPDMHP.GetHashCode();
		}
		if (LMEEJJNOFIE != 0)
		{
			num ^= LMEEJJNOFIE.GetHashCode();
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
		if (PEJMPHMPPKO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(PEJMPHMPPKO);
		}
		if (FHADIOPDMHP != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(FHADIOPDMHP);
		}
		if (LMEEJJNOFIE != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(LMEEJJNOFIE);
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
		if (PEJMPHMPPKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PEJMPHMPPKO);
		}
		if (FHADIOPDMHP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FHADIOPDMHP);
		}
		if (LMEEJJNOFIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMEEJJNOFIE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FFNBJBNDFEK other)
	{
		if (other != null)
		{
			if (other.PEJMPHMPPKO != 0)
			{
				PEJMPHMPPKO = other.PEJMPHMPPKO;
			}
			if (other.FHADIOPDMHP != 0)
			{
				FHADIOPDMHP = other.FHADIOPDMHP;
			}
			if (other.LMEEJJNOFIE != 0)
			{
				LMEEJJNOFIE = other.LMEEJJNOFIE;
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
				PEJMPHMPPKO = input.ReadUInt32();
				break;
			case 16u:
				FHADIOPDMHP = input.ReadUInt32();
				break;
			case 24u:
				LMEEJJNOFIE = input.ReadUInt32();
				break;
			}
		}
	}
}
