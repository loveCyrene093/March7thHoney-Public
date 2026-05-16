using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DGCGFFLKKAA : IMessage<DGCGFFLKKAA>, IMessage, IEquatable<DGCGFFLKKAA>, IDeepCloneable<DGCGFFLKKAA>, IBufferMessage
{
	private static readonly MessageParser<DGCGFFLKKAA> _parser = new MessageParser<DGCGFFLKKAA>(() => new DGCGFFLKKAA());

	private UnknownFieldSet _unknownFields;

	public const int COOOFFKIDMCFieldNumber = 10;

	private uint cOOOFFKIDMC_;

	public const int KODPDMCLFEIFieldNumber = 14;

	private uint kODPDMCLFEI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DGCGFFLKKAA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DGCGFFLKKAAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint KODPDMCLFEI
	{
		get
		{
			return kODPDMCLFEI_;
		}
		set
		{
			kODPDMCLFEI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGCGFFLKKAA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGCGFFLKKAA(DGCGFFLKKAA other)
		: this()
	{
		cOOOFFKIDMC_ = other.cOOOFFKIDMC_;
		kODPDMCLFEI_ = other.kODPDMCLFEI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGCGFFLKKAA Clone()
	{
		return new DGCGFFLKKAA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DGCGFFLKKAA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DGCGFFLKKAA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (COOOFFKIDMC != other.COOOFFKIDMC)
		{
			return false;
		}
		if (KODPDMCLFEI != other.KODPDMCLFEI)
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
		if (COOOFFKIDMC != 0)
		{
			num ^= COOOFFKIDMC.GetHashCode();
		}
		if (KODPDMCLFEI != 0)
		{
			num ^= KODPDMCLFEI.GetHashCode();
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
		if (COOOFFKIDMC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(COOOFFKIDMC);
		}
		if (KODPDMCLFEI != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(KODPDMCLFEI);
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
		if (COOOFFKIDMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COOOFFKIDMC);
		}
		if (KODPDMCLFEI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KODPDMCLFEI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DGCGFFLKKAA other)
	{
		if (other != null)
		{
			if (other.COOOFFKIDMC != 0)
			{
				COOOFFKIDMC = other.COOOFFKIDMC;
			}
			if (other.KODPDMCLFEI != 0)
			{
				KODPDMCLFEI = other.KODPDMCLFEI;
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
			case 80u:
				COOOFFKIDMC = input.ReadUInt32();
				break;
			case 112u:
				KODPDMCLFEI = input.ReadUInt32();
				break;
			}
		}
	}
}
