using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AKGLAEKCFNO : IMessage<AKGLAEKCFNO>, IMessage, IEquatable<AKGLAEKCFNO>, IDeepCloneable<AKGLAEKCFNO>, IBufferMessage
{
	private static readonly MessageParser<AKGLAEKCFNO> _parser = new MessageParser<AKGLAEKCFNO>(() => new AKGLAEKCFNO());

	private UnknownFieldSet _unknownFields;

	public const int KPNNKBILLBLFieldNumber = 1;

	private uint kPNNKBILLBL_;

	public const int CHCGMAMOBMHFieldNumber = 4;

	private bool cHCGMAMOBMH_;

	public const int LOLJHLDHPPNFieldNumber = 7;

	private static readonly FieldCodec<DAKIKKDICAN> _repeated_lOLJHLDHPPN_codec = FieldCodec.ForMessage(58u, DAKIKKDICAN.Parser);

	private readonly RepeatedField<DAKIKKDICAN> lOLJHLDHPPN_ = new RepeatedField<DAKIKKDICAN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AKGLAEKCFNO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AKGLAEKCFNOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KPNNKBILLBL
	{
		get
		{
			return kPNNKBILLBL_;
		}
		set
		{
			kPNNKBILLBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CHCGMAMOBMH
	{
		get
		{
			return cHCGMAMOBMH_;
		}
		set
		{
			cHCGMAMOBMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DAKIKKDICAN> LOLJHLDHPPN => lOLJHLDHPPN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKGLAEKCFNO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKGLAEKCFNO(AKGLAEKCFNO other)
		: this()
	{
		kPNNKBILLBL_ = other.kPNNKBILLBL_;
		cHCGMAMOBMH_ = other.cHCGMAMOBMH_;
		lOLJHLDHPPN_ = other.lOLJHLDHPPN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AKGLAEKCFNO Clone()
	{
		return new AKGLAEKCFNO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AKGLAEKCFNO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AKGLAEKCFNO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KPNNKBILLBL != other.KPNNKBILLBL)
		{
			return false;
		}
		if (CHCGMAMOBMH != other.CHCGMAMOBMH)
		{
			return false;
		}
		if (!lOLJHLDHPPN_.Equals(other.lOLJHLDHPPN_))
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
		if (KPNNKBILLBL != 0)
		{
			num ^= KPNNKBILLBL.GetHashCode();
		}
		if (CHCGMAMOBMH)
		{
			num ^= CHCGMAMOBMH.GetHashCode();
		}
		num ^= lOLJHLDHPPN_.GetHashCode();
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
		if (KPNNKBILLBL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KPNNKBILLBL);
		}
		if (CHCGMAMOBMH)
		{
			output.WriteRawTag(32);
			output.WriteBool(CHCGMAMOBMH);
		}
		lOLJHLDHPPN_.WriteTo(ref output, _repeated_lOLJHLDHPPN_codec);
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
		if (KPNNKBILLBL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPNNKBILLBL);
		}
		if (CHCGMAMOBMH)
		{
			num += 2;
		}
		num += lOLJHLDHPPN_.CalculateSize(_repeated_lOLJHLDHPPN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AKGLAEKCFNO other)
	{
		if (other != null)
		{
			if (other.KPNNKBILLBL != 0)
			{
				KPNNKBILLBL = other.KPNNKBILLBL;
			}
			if (other.CHCGMAMOBMH)
			{
				CHCGMAMOBMH = other.CHCGMAMOBMH;
			}
			lOLJHLDHPPN_.Add(other.lOLJHLDHPPN_);
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
				KPNNKBILLBL = input.ReadUInt32();
				break;
			case 32u:
				CHCGMAMOBMH = input.ReadBool();
				break;
			case 58u:
				lOLJHLDHPPN_.AddEntriesFrom(ref input, _repeated_lOLJHLDHPPN_codec);
				break;
			}
		}
	}
}
