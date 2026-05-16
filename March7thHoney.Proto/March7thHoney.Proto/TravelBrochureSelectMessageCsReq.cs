using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TravelBrochureSelectMessageCsReq : IMessage<TravelBrochureSelectMessageCsReq>, IMessage, IEquatable<TravelBrochureSelectMessageCsReq>, IDeepCloneable<TravelBrochureSelectMessageCsReq>, IBufferMessage
{
	private static readonly MessageParser<TravelBrochureSelectMessageCsReq> _parser = new MessageParser<TravelBrochureSelectMessageCsReq>(() => new TravelBrochureSelectMessageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DICEPCGFBNOFieldNumber = 4;

	private uint dICEPCGFBNO_;

	public const int HBCJPCMJPHEFieldNumber = 14;

	private uint hBCJPCMJPHE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TravelBrochureSelectMessageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TravelBrochureSelectMessageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DICEPCGFBNO
	{
		get
		{
			return dICEPCGFBNO_;
		}
		set
		{
			dICEPCGFBNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBCJPCMJPHE
	{
		get
		{
			return hBCJPCMJPHE_;
		}
		set
		{
			hBCJPCMJPHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureSelectMessageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureSelectMessageCsReq(TravelBrochureSelectMessageCsReq other)
		: this()
	{
		dICEPCGFBNO_ = other.dICEPCGFBNO_;
		hBCJPCMJPHE_ = other.hBCJPCMJPHE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureSelectMessageCsReq Clone()
	{
		return new TravelBrochureSelectMessageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TravelBrochureSelectMessageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TravelBrochureSelectMessageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DICEPCGFBNO != other.DICEPCGFBNO)
		{
			return false;
		}
		if (HBCJPCMJPHE != other.HBCJPCMJPHE)
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
		if (DICEPCGFBNO != 0)
		{
			num ^= DICEPCGFBNO.GetHashCode();
		}
		if (HBCJPCMJPHE != 0)
		{
			num ^= HBCJPCMJPHE.GetHashCode();
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
		if (DICEPCGFBNO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DICEPCGFBNO);
		}
		if (HBCJPCMJPHE != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HBCJPCMJPHE);
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
		if (DICEPCGFBNO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DICEPCGFBNO);
		}
		if (HBCJPCMJPHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBCJPCMJPHE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TravelBrochureSelectMessageCsReq other)
	{
		if (other != null)
		{
			if (other.DICEPCGFBNO != 0)
			{
				DICEPCGFBNO = other.DICEPCGFBNO;
			}
			if (other.HBCJPCMJPHE != 0)
			{
				HBCJPCMJPHE = other.HBCJPCMJPHE;
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
			case 32u:
				DICEPCGFBNO = input.ReadUInt32();
				break;
			case 112u:
				HBCJPCMJPHE = input.ReadUInt32();
				break;
			}
		}
	}
}
