using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OKPICJKFILN : IMessage<OKPICJKFILN>, IMessage, IEquatable<OKPICJKFILN>, IDeepCloneable<OKPICJKFILN>, IBufferMessage
{
	private static readonly MessageParser<OKPICJKFILN> _parser = new MessageParser<OKPICJKFILN>(() => new OKPICJKFILN());

	private UnknownFieldSet _unknownFields;

	public const int MMBIMPGOGBKFieldNumber = 7;

	private uint mMBIMPGOGBK_;

	public const int EJMNPLGFFJIFieldNumber = 9;

	private uint eJMNPLGFFJI_;

	public const int MGFMDOJFDFGFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_mGFMDOJFDFG_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> mGFMDOJFDFG_ = new RepeatedField<uint>();

	public const int KACDGAJHNBIFieldNumber = 14;

	private uint kACDGAJHNBI_;

	public const int PEJIFFPBLOPFieldNumber = 15;

	private uint pEJIFFPBLOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OKPICJKFILN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OKPICJKFILNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMBIMPGOGBK
	{
		get
		{
			return mMBIMPGOGBK_;
		}
		set
		{
			mMBIMPGOGBK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EJMNPLGFFJI
	{
		get
		{
			return eJMNPLGFFJI_;
		}
		set
		{
			eJMNPLGFFJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MGFMDOJFDFG => mGFMDOJFDFG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KACDGAJHNBI
	{
		get
		{
			return kACDGAJHNBI_;
		}
		set
		{
			kACDGAJHNBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PEJIFFPBLOP
	{
		get
		{
			return pEJIFFPBLOP_;
		}
		set
		{
			pEJIFFPBLOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKPICJKFILN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKPICJKFILN(OKPICJKFILN other)
		: this()
	{
		mMBIMPGOGBK_ = other.mMBIMPGOGBK_;
		eJMNPLGFFJI_ = other.eJMNPLGFFJI_;
		mGFMDOJFDFG_ = other.mGFMDOJFDFG_.Clone();
		kACDGAJHNBI_ = other.kACDGAJHNBI_;
		pEJIFFPBLOP_ = other.pEJIFFPBLOP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OKPICJKFILN Clone()
	{
		return new OKPICJKFILN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OKPICJKFILN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OKPICJKFILN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MMBIMPGOGBK != other.MMBIMPGOGBK)
		{
			return false;
		}
		if (EJMNPLGFFJI != other.EJMNPLGFFJI)
		{
			return false;
		}
		if (!mGFMDOJFDFG_.Equals(other.mGFMDOJFDFG_))
		{
			return false;
		}
		if (KACDGAJHNBI != other.KACDGAJHNBI)
		{
			return false;
		}
		if (PEJIFFPBLOP != other.PEJIFFPBLOP)
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
		if (MMBIMPGOGBK != 0)
		{
			num ^= MMBIMPGOGBK.GetHashCode();
		}
		if (EJMNPLGFFJI != 0)
		{
			num ^= EJMNPLGFFJI.GetHashCode();
		}
		num ^= mGFMDOJFDFG_.GetHashCode();
		if (KACDGAJHNBI != 0)
		{
			num ^= KACDGAJHNBI.GetHashCode();
		}
		if (PEJIFFPBLOP != 0)
		{
			num ^= PEJIFFPBLOP.GetHashCode();
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
		if (MMBIMPGOGBK != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(MMBIMPGOGBK);
		}
		if (EJMNPLGFFJI != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(EJMNPLGFFJI);
		}
		mGFMDOJFDFG_.WriteTo(ref output, _repeated_mGFMDOJFDFG_codec);
		if (KACDGAJHNBI != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(KACDGAJHNBI);
		}
		if (PEJIFFPBLOP != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(PEJIFFPBLOP);
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
		if (MMBIMPGOGBK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMBIMPGOGBK);
		}
		if (EJMNPLGFFJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EJMNPLGFFJI);
		}
		num += mGFMDOJFDFG_.CalculateSize(_repeated_mGFMDOJFDFG_codec);
		if (KACDGAJHNBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KACDGAJHNBI);
		}
		if (PEJIFFPBLOP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PEJIFFPBLOP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OKPICJKFILN other)
	{
		if (other != null)
		{
			if (other.MMBIMPGOGBK != 0)
			{
				MMBIMPGOGBK = other.MMBIMPGOGBK;
			}
			if (other.EJMNPLGFFJI != 0)
			{
				EJMNPLGFFJI = other.EJMNPLGFFJI;
			}
			mGFMDOJFDFG_.Add(other.mGFMDOJFDFG_);
			if (other.KACDGAJHNBI != 0)
			{
				KACDGAJHNBI = other.KACDGAJHNBI;
			}
			if (other.PEJIFFPBLOP != 0)
			{
				PEJIFFPBLOP = other.PEJIFFPBLOP;
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
			case 56u:
				MMBIMPGOGBK = input.ReadUInt32();
				break;
			case 72u:
				EJMNPLGFFJI = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				mGFMDOJFDFG_.AddEntriesFrom(ref input, _repeated_mGFMDOJFDFG_codec);
				break;
			case 112u:
				KACDGAJHNBI = input.ReadUInt32();
				break;
			case 120u:
				PEJIFFPBLOP = input.ReadUInt32();
				break;
			}
		}
	}
}
