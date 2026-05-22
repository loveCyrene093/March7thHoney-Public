using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HDKIAHMLICD : IMessage<HDKIAHMLICD>, IMessage, IEquatable<HDKIAHMLICD>, IDeepCloneable<HDKIAHMLICD>, IBufferMessage
{
	private static readonly MessageParser<HDKIAHMLICD> _parser = new MessageParser<HDKIAHMLICD>(() => new HDKIAHMLICD());

	private UnknownFieldSet _unknownFields;

	public const int IJANKPNHKHAFieldNumber = 3;

	private uint iJANKPNHKHA_;

	public const int MAGCGPMHHEAFieldNumber = 9;

	private uint mAGCGPMHHEA_;

	public const int LGHOOKMNMCLFieldNumber = 10;

	private uint lGHOOKMNMCL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HDKIAHMLICD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HDKIAHMLICDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IJANKPNHKHA
	{
		get
		{
			return iJANKPNHKHA_;
		}
		set
		{
			iJANKPNHKHA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAGCGPMHHEA
	{
		get
		{
			return mAGCGPMHHEA_;
		}
		set
		{
			mAGCGPMHHEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LGHOOKMNMCL
	{
		get
		{
			return lGHOOKMNMCL_;
		}
		set
		{
			lGHOOKMNMCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDKIAHMLICD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDKIAHMLICD(HDKIAHMLICD other)
		: this()
	{
		iJANKPNHKHA_ = other.iJANKPNHKHA_;
		mAGCGPMHHEA_ = other.mAGCGPMHHEA_;
		lGHOOKMNMCL_ = other.lGHOOKMNMCL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDKIAHMLICD Clone()
	{
		return new HDKIAHMLICD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HDKIAHMLICD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HDKIAHMLICD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IJANKPNHKHA != other.IJANKPNHKHA)
		{
			return false;
		}
		if (MAGCGPMHHEA != other.MAGCGPMHHEA)
		{
			return false;
		}
		if (LGHOOKMNMCL != other.LGHOOKMNMCL)
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
		if (IJANKPNHKHA != 0)
		{
			num ^= IJANKPNHKHA.GetHashCode();
		}
		if (MAGCGPMHHEA != 0)
		{
			num ^= MAGCGPMHHEA.GetHashCode();
		}
		if (LGHOOKMNMCL != 0)
		{
			num ^= LGHOOKMNMCL.GetHashCode();
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
		if (IJANKPNHKHA != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IJANKPNHKHA);
		}
		if (MAGCGPMHHEA != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(MAGCGPMHHEA);
		}
		if (LGHOOKMNMCL != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(LGHOOKMNMCL);
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
		if (IJANKPNHKHA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJANKPNHKHA);
		}
		if (MAGCGPMHHEA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAGCGPMHHEA);
		}
		if (LGHOOKMNMCL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LGHOOKMNMCL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HDKIAHMLICD other)
	{
		if (other != null)
		{
			if (other.IJANKPNHKHA != 0)
			{
				IJANKPNHKHA = other.IJANKPNHKHA;
			}
			if (other.MAGCGPMHHEA != 0)
			{
				MAGCGPMHHEA = other.MAGCGPMHHEA;
			}
			if (other.LGHOOKMNMCL != 0)
			{
				LGHOOKMNMCL = other.LGHOOKMNMCL;
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
			case 24u:
				IJANKPNHKHA = input.ReadUInt32();
				break;
			case 72u:
				MAGCGPMHHEA = input.ReadUInt32();
				break;
			case 80u:
				LGHOOKMNMCL = input.ReadUInt32();
				break;
			}
		}
	}
}
