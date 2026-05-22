using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GMMAGELGJOL : IMessage<GMMAGELGJOL>, IMessage, IEquatable<GMMAGELGJOL>, IDeepCloneable<GMMAGELGJOL>, IBufferMessage
{
	private static readonly MessageParser<GMMAGELGJOL> _parser = new MessageParser<GMMAGELGJOL>(() => new GMMAGELGJOL());

	private UnknownFieldSet _unknownFields;

	public const int EGIMPFHCCDJFieldNumber = 2;

	private uint eGIMPFHCCDJ_;

	public const int DDNIJHDACEBFieldNumber = 15;

	private uint dDNIJHDACEB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GMMAGELGJOL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GMMAGELGJOLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EGIMPFHCCDJ
	{
		get
		{
			return eGIMPFHCCDJ_;
		}
		set
		{
			eGIMPFHCCDJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DDNIJHDACEB
	{
		get
		{
			return dDNIJHDACEB_;
		}
		set
		{
			dDNIJHDACEB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMMAGELGJOL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMMAGELGJOL(GMMAGELGJOL other)
		: this()
	{
		eGIMPFHCCDJ_ = other.eGIMPFHCCDJ_;
		dDNIJHDACEB_ = other.dDNIJHDACEB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GMMAGELGJOL Clone()
	{
		return new GMMAGELGJOL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GMMAGELGJOL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GMMAGELGJOL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EGIMPFHCCDJ != other.EGIMPFHCCDJ)
		{
			return false;
		}
		if (DDNIJHDACEB != other.DDNIJHDACEB)
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
		if (EGIMPFHCCDJ != 0)
		{
			num ^= EGIMPFHCCDJ.GetHashCode();
		}
		if (DDNIJHDACEB != 0)
		{
			num ^= DDNIJHDACEB.GetHashCode();
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
		if (EGIMPFHCCDJ != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EGIMPFHCCDJ);
		}
		if (DDNIJHDACEB != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DDNIJHDACEB);
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
		if (EGIMPFHCCDJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EGIMPFHCCDJ);
		}
		if (DDNIJHDACEB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DDNIJHDACEB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GMMAGELGJOL other)
	{
		if (other != null)
		{
			if (other.EGIMPFHCCDJ != 0)
			{
				EGIMPFHCCDJ = other.EGIMPFHCCDJ;
			}
			if (other.DDNIJHDACEB != 0)
			{
				DDNIJHDACEB = other.DDNIJHDACEB;
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
				EGIMPFHCCDJ = input.ReadUInt32();
				break;
			case 120u:
				DDNIJHDACEB = input.ReadUInt32();
				break;
			}
		}
	}
}
