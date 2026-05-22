using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IDIGEJHHPDL : IMessage<IDIGEJHHPDL>, IMessage, IEquatable<IDIGEJHHPDL>, IDeepCloneable<IDIGEJHHPDL>, IBufferMessage
{
	private static readonly MessageParser<IDIGEJHHPDL> _parser = new MessageParser<IDIGEJHHPDL>(() => new IDIGEJHHPDL());

	private UnknownFieldSet _unknownFields;

	public const int IIKCCGFJKABFieldNumber = 3;

	private uint iIKCCGFJKAB_;

	public const int GDPGOBIILNOFieldNumber = 10;

	private uint gDPGOBIILNO_;

	public const int MOLLBAMGLAGFieldNumber = 12;

	private uint mOLLBAMGLAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IDIGEJHHPDL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IDIGEJHHPDLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IIKCCGFJKAB
	{
		get
		{
			return iIKCCGFJKAB_;
		}
		set
		{
			iIKCCGFJKAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GDPGOBIILNO
	{
		get
		{
			return gDPGOBIILNO_;
		}
		set
		{
			gDPGOBIILNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOLLBAMGLAG
	{
		get
		{
			return mOLLBAMGLAG_;
		}
		set
		{
			mOLLBAMGLAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDIGEJHHPDL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDIGEJHHPDL(IDIGEJHHPDL other)
		: this()
	{
		iIKCCGFJKAB_ = other.iIKCCGFJKAB_;
		gDPGOBIILNO_ = other.gDPGOBIILNO_;
		mOLLBAMGLAG_ = other.mOLLBAMGLAG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDIGEJHHPDL Clone()
	{
		return new IDIGEJHHPDL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IDIGEJHHPDL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IDIGEJHHPDL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IIKCCGFJKAB != other.IIKCCGFJKAB)
		{
			return false;
		}
		if (GDPGOBIILNO != other.GDPGOBIILNO)
		{
			return false;
		}
		if (MOLLBAMGLAG != other.MOLLBAMGLAG)
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
		if (IIKCCGFJKAB != 0)
		{
			num ^= IIKCCGFJKAB.GetHashCode();
		}
		if (GDPGOBIILNO != 0)
		{
			num ^= GDPGOBIILNO.GetHashCode();
		}
		if (MOLLBAMGLAG != 0)
		{
			num ^= MOLLBAMGLAG.GetHashCode();
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
		if (IIKCCGFJKAB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(IIKCCGFJKAB);
		}
		if (GDPGOBIILNO != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GDPGOBIILNO);
		}
		if (MOLLBAMGLAG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(MOLLBAMGLAG);
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
		if (IIKCCGFJKAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIKCCGFJKAB);
		}
		if (GDPGOBIILNO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDPGOBIILNO);
		}
		if (MOLLBAMGLAG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOLLBAMGLAG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IDIGEJHHPDL other)
	{
		if (other != null)
		{
			if (other.IIKCCGFJKAB != 0)
			{
				IIKCCGFJKAB = other.IIKCCGFJKAB;
			}
			if (other.GDPGOBIILNO != 0)
			{
				GDPGOBIILNO = other.GDPGOBIILNO;
			}
			if (other.MOLLBAMGLAG != 0)
			{
				MOLLBAMGLAG = other.MOLLBAMGLAG;
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
				IIKCCGFJKAB = input.ReadUInt32();
				break;
			case 80u:
				GDPGOBIILNO = input.ReadUInt32();
				break;
			case 96u:
				MOLLBAMGLAG = input.ReadUInt32();
				break;
			}
		}
	}
}
