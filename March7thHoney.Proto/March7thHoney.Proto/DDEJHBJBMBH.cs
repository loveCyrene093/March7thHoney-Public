using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DDEJHBJBMBH : IMessage<DDEJHBJBMBH>, IMessage, IEquatable<DDEJHBJBMBH>, IDeepCloneable<DDEJHBJBMBH>, IBufferMessage
{
	private static readonly MessageParser<DDEJHBJBMBH> _parser = new MessageParser<DDEJHBJBMBH>(() => new DDEJHBJBMBH());

	private UnknownFieldSet _unknownFields;

	public const int LOHJDJICMFJFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_lOHJDJICMFJ_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> lOHJDJICMFJ_ = new RepeatedField<uint>();

	public const int KOLOCKHJEDKFieldNumber = 5;

	private uint kOLOCKHJEDK_;

	public const int OFHCNGHJFHIFieldNumber = 7;

	private uint oFHCNGHJFHI_;

	public const int DOCEBPCDLJKFieldNumber = 10;

	private CGHGBGJJBEO dOCEBPCDLJK_;

	public const int LEFOJLCJEEJFieldNumber = 14;

	private uint lEFOJLCJEEJ_;

	public const int FCHPJKAIBHBFieldNumber = 15;

	private uint fCHPJKAIBHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DDEJHBJBMBH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DDEJHBJBMBHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LOHJDJICMFJ => lOHJDJICMFJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KOLOCKHJEDK
	{
		get
		{
			return kOLOCKHJEDK_;
		}
		set
		{
			kOLOCKHJEDK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFHCNGHJFHI
	{
		get
		{
			return oFHCNGHJFHI_;
		}
		set
		{
			oFHCNGHJFHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGHGBGJJBEO DOCEBPCDLJK
	{
		get
		{
			return dOCEBPCDLJK_;
		}
		set
		{
			dOCEBPCDLJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LEFOJLCJEEJ
	{
		get
		{
			return lEFOJLCJEEJ_;
		}
		set
		{
			lEFOJLCJEEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCHPJKAIBHB
	{
		get
		{
			return fCHPJKAIBHB_;
		}
		set
		{
			fCHPJKAIBHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDEJHBJBMBH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDEJHBJBMBH(DDEJHBJBMBH other)
		: this()
	{
		lOHJDJICMFJ_ = other.lOHJDJICMFJ_.Clone();
		kOLOCKHJEDK_ = other.kOLOCKHJEDK_;
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		dOCEBPCDLJK_ = other.dOCEBPCDLJK_;
		lEFOJLCJEEJ_ = other.lEFOJLCJEEJ_;
		fCHPJKAIBHB_ = other.fCHPJKAIBHB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDEJHBJBMBH Clone()
	{
		return new DDEJHBJBMBH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DDEJHBJBMBH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DDEJHBJBMBH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lOHJDJICMFJ_.Equals(other.lOHJDJICMFJ_))
		{
			return false;
		}
		if (KOLOCKHJEDK != other.KOLOCKHJEDK)
		{
			return false;
		}
		if (OFHCNGHJFHI != other.OFHCNGHJFHI)
		{
			return false;
		}
		if (DOCEBPCDLJK != other.DOCEBPCDLJK)
		{
			return false;
		}
		if (LEFOJLCJEEJ != other.LEFOJLCJEEJ)
		{
			return false;
		}
		if (FCHPJKAIBHB != other.FCHPJKAIBHB)
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
		num ^= lOHJDJICMFJ_.GetHashCode();
		if (KOLOCKHJEDK != 0)
		{
			num ^= KOLOCKHJEDK.GetHashCode();
		}
		if (OFHCNGHJFHI != 0)
		{
			num ^= OFHCNGHJFHI.GetHashCode();
		}
		if (DOCEBPCDLJK != CGHGBGJJBEO.Ohdhfkcnamc)
		{
			num ^= DOCEBPCDLJK.GetHashCode();
		}
		if (LEFOJLCJEEJ != 0)
		{
			num ^= LEFOJLCJEEJ.GetHashCode();
		}
		if (FCHPJKAIBHB != 0)
		{
			num ^= FCHPJKAIBHB.GetHashCode();
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
		lOHJDJICMFJ_.WriteTo(ref output, _repeated_lOHJDJICMFJ_codec);
		if (KOLOCKHJEDK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(KOLOCKHJEDK);
		}
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(OFHCNGHJFHI);
		}
		if (DOCEBPCDLJK != CGHGBGJJBEO.Ohdhfkcnamc)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)DOCEBPCDLJK);
		}
		if (LEFOJLCJEEJ != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LEFOJLCJEEJ);
		}
		if (FCHPJKAIBHB != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FCHPJKAIBHB);
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
		num += lOHJDJICMFJ_.CalculateSize(_repeated_lOHJDJICMFJ_codec);
		if (KOLOCKHJEDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KOLOCKHJEDK);
		}
		if (OFHCNGHJFHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFHCNGHJFHI);
		}
		if (DOCEBPCDLJK != CGHGBGJJBEO.Ohdhfkcnamc)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DOCEBPCDLJK);
		}
		if (LEFOJLCJEEJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LEFOJLCJEEJ);
		}
		if (FCHPJKAIBHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCHPJKAIBHB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DDEJHBJBMBH other)
	{
		if (other != null)
		{
			lOHJDJICMFJ_.Add(other.lOHJDJICMFJ_);
			if (other.KOLOCKHJEDK != 0)
			{
				KOLOCKHJEDK = other.KOLOCKHJEDK;
			}
			if (other.OFHCNGHJFHI != 0)
			{
				OFHCNGHJFHI = other.OFHCNGHJFHI;
			}
			if (other.DOCEBPCDLJK != CGHGBGJJBEO.Ohdhfkcnamc)
			{
				DOCEBPCDLJK = other.DOCEBPCDLJK;
			}
			if (other.LEFOJLCJEEJ != 0)
			{
				LEFOJLCJEEJ = other.LEFOJLCJEEJ;
			}
			if (other.FCHPJKAIBHB != 0)
			{
				FCHPJKAIBHB = other.FCHPJKAIBHB;
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
			case 26u:
				lOHJDJICMFJ_.AddEntriesFrom(ref input, _repeated_lOHJDJICMFJ_codec);
				break;
			case 40u:
				KOLOCKHJEDK = input.ReadUInt32();
				break;
			case 56u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			case 80u:
				DOCEBPCDLJK = (CGHGBGJJBEO)input.ReadEnum();
				break;
			case 112u:
				LEFOJLCJEEJ = input.ReadUInt32();
				break;
			case 120u:
				FCHPJKAIBHB = input.ReadUInt32();
				break;
			}
		}
	}
}
