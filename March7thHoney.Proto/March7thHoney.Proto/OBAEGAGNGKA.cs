using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OBAEGAGNGKA : IMessage<OBAEGAGNGKA>, IMessage, IEquatable<OBAEGAGNGKA>, IDeepCloneable<OBAEGAGNGKA>, IBufferMessage
{
	private static readonly MessageParser<OBAEGAGNGKA> _parser = new MessageParser<OBAEGAGNGKA>(() => new OBAEGAGNGKA());

	private UnknownFieldSet _unknownFields;

	public const int CLGBLBALKMDFieldNumber = 2;

	private uint cLGBLBALKMD_;

	public const int AOGHJBOKKBKFieldNumber = 15;

	private uint aOGHJBOKKBK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OBAEGAGNGKA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OBAEGAGNGKAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CLGBLBALKMD
	{
		get
		{
			return cLGBLBALKMD_;
		}
		set
		{
			cLGBLBALKMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AOGHJBOKKBK
	{
		get
		{
			return aOGHJBOKKBK_;
		}
		set
		{
			aOGHJBOKKBK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBAEGAGNGKA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBAEGAGNGKA(OBAEGAGNGKA other)
		: this()
	{
		cLGBLBALKMD_ = other.cLGBLBALKMD_;
		aOGHJBOKKBK_ = other.aOGHJBOKKBK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OBAEGAGNGKA Clone()
	{
		return new OBAEGAGNGKA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OBAEGAGNGKA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OBAEGAGNGKA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CLGBLBALKMD != other.CLGBLBALKMD)
		{
			return false;
		}
		if (AOGHJBOKKBK != other.AOGHJBOKKBK)
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
		if (CLGBLBALKMD != 0)
		{
			num ^= CLGBLBALKMD.GetHashCode();
		}
		if (AOGHJBOKKBK != 0)
		{
			num ^= AOGHJBOKKBK.GetHashCode();
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
		if (CLGBLBALKMD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CLGBLBALKMD);
		}
		if (AOGHJBOKKBK != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(AOGHJBOKKBK);
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
		if (CLGBLBALKMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CLGBLBALKMD);
		}
		if (AOGHJBOKKBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOGHJBOKKBK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OBAEGAGNGKA other)
	{
		if (other != null)
		{
			if (other.CLGBLBALKMD != 0)
			{
				CLGBLBALKMD = other.CLGBLBALKMD;
			}
			if (other.AOGHJBOKKBK != 0)
			{
				AOGHJBOKKBK = other.AOGHJBOKKBK;
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
				CLGBLBALKMD = input.ReadUInt32();
				break;
			case 120u:
				AOGHJBOKKBK = input.ReadUInt32();
				break;
			}
		}
	}
}
