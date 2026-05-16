using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GFFHJIHOJFL : IMessage<GFFHJIHOJFL>, IMessage, IEquatable<GFFHJIHOJFL>, IDeepCloneable<GFFHJIHOJFL>, IBufferMessage
{
	private static readonly MessageParser<GFFHJIHOJFL> _parser = new MessageParser<GFFHJIHOJFL>(() => new GFFHJIHOJFL());

	private UnknownFieldSet _unknownFields;

	public const int NPPNIHPIHDLFieldNumber = 6;

	private uint nPPNIHPIHDL_;

	public const int MKCHLGOGJNBFieldNumber = 10;

	private uint mKCHLGOGJNB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GFFHJIHOJFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GFFHJIHOJFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NPPNIHPIHDL
	{
		get
		{
			return nPPNIHPIHDL_;
		}
		set
		{
			nPPNIHPIHDL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MKCHLGOGJNB
	{
		get
		{
			return mKCHLGOGJNB_;
		}
		set
		{
			mKCHLGOGJNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFFHJIHOJFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFFHJIHOJFL(GFFHJIHOJFL other)
		: this()
	{
		nPPNIHPIHDL_ = other.nPPNIHPIHDL_;
		mKCHLGOGJNB_ = other.mKCHLGOGJNB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFFHJIHOJFL Clone()
	{
		return new GFFHJIHOJFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GFFHJIHOJFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GFFHJIHOJFL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NPPNIHPIHDL != other.NPPNIHPIHDL)
		{
			return false;
		}
		if (MKCHLGOGJNB != other.MKCHLGOGJNB)
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
		if (NPPNIHPIHDL != 0)
		{
			num ^= NPPNIHPIHDL.GetHashCode();
		}
		if (MKCHLGOGJNB != 0)
		{
			num ^= MKCHLGOGJNB.GetHashCode();
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
		if (NPPNIHPIHDL != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(NPPNIHPIHDL);
		}
		if (MKCHLGOGJNB != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(MKCHLGOGJNB);
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
		if (NPPNIHPIHDL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NPPNIHPIHDL);
		}
		if (MKCHLGOGJNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MKCHLGOGJNB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GFFHJIHOJFL other)
	{
		if (other != null)
		{
			if (other.NPPNIHPIHDL != 0)
			{
				NPPNIHPIHDL = other.NPPNIHPIHDL;
			}
			if (other.MKCHLGOGJNB != 0)
			{
				MKCHLGOGJNB = other.MKCHLGOGJNB;
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
				NPPNIHPIHDL = input.ReadUInt32();
				break;
			case 80u:
				MKCHLGOGJNB = input.ReadUInt32();
				break;
			}
		}
	}
}
