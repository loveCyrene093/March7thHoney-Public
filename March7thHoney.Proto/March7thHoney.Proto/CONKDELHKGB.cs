using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CONKDELHKGB : IMessage<CONKDELHKGB>, IMessage, IEquatable<CONKDELHKGB>, IDeepCloneable<CONKDELHKGB>, IBufferMessage
{
	private static readonly MessageParser<CONKDELHKGB> _parser = new MessageParser<CONKDELHKGB>(() => new CONKDELHKGB());

	private UnknownFieldSet _unknownFields;

	public const int LOIJLIKOMJNFieldNumber = 1;

	private uint lOIJLIKOMJN_;

	public const int RankFieldNumber = 2;

	private uint rank_;

	public const int MBAFIOCLMAIFieldNumber = 3;

	private uint mBAFIOCLMAI_;

	public const int ADEAJENPGHNFieldNumber = 4;

	private uint aDEAJENPGHN_;

	public const int CJECINJPIIJFieldNumber = 5;

	private static readonly FieldCodec<EMBCNJNGMKI> _repeated_cJECINJPIIJ_codec = FieldCodec.ForMessage(42u, EMBCNJNGMKI.Parser);

	private readonly RepeatedField<EMBCNJNGMKI> cJECINJPIIJ_ = new RepeatedField<EMBCNJNGMKI>();

	public const int KHIIKNBHMHCFieldNumber = 6;

	private uint kHIIKNBHMHC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CONKDELHKGB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CONKDELHKGBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOIJLIKOMJN
	{
		get
		{
			return lOIJLIKOMJN_;
		}
		set
		{
			lOIJLIKOMJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MBAFIOCLMAI
	{
		get
		{
			return mBAFIOCLMAI_;
		}
		set
		{
			mBAFIOCLMAI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ADEAJENPGHN
	{
		get
		{
			return aDEAJENPGHN_;
		}
		set
		{
			aDEAJENPGHN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EMBCNJNGMKI> CJECINJPIIJ => cJECINJPIIJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KHIIKNBHMHC
	{
		get
		{
			return kHIIKNBHMHC_;
		}
		set
		{
			kHIIKNBHMHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CONKDELHKGB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CONKDELHKGB(CONKDELHKGB other)
		: this()
	{
		lOIJLIKOMJN_ = other.lOIJLIKOMJN_;
		rank_ = other.rank_;
		mBAFIOCLMAI_ = other.mBAFIOCLMAI_;
		aDEAJENPGHN_ = other.aDEAJENPGHN_;
		cJECINJPIIJ_ = other.cJECINJPIIJ_.Clone();
		kHIIKNBHMHC_ = other.kHIIKNBHMHC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CONKDELHKGB Clone()
	{
		return new CONKDELHKGB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CONKDELHKGB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CONKDELHKGB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LOIJLIKOMJN != other.LOIJLIKOMJN)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (MBAFIOCLMAI != other.MBAFIOCLMAI)
		{
			return false;
		}
		if (ADEAJENPGHN != other.ADEAJENPGHN)
		{
			return false;
		}
		if (!cJECINJPIIJ_.Equals(other.cJECINJPIIJ_))
		{
			return false;
		}
		if (KHIIKNBHMHC != other.KHIIKNBHMHC)
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
		if (LOIJLIKOMJN != 0)
		{
			num ^= LOIJLIKOMJN.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (MBAFIOCLMAI != 0)
		{
			num ^= MBAFIOCLMAI.GetHashCode();
		}
		if (ADEAJENPGHN != 0)
		{
			num ^= ADEAJENPGHN.GetHashCode();
		}
		num ^= cJECINJPIIJ_.GetHashCode();
		if (KHIIKNBHMHC != 0)
		{
			num ^= KHIIKNBHMHC.GetHashCode();
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
		if (LOIJLIKOMJN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LOIJLIKOMJN);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Rank);
		}
		if (MBAFIOCLMAI != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MBAFIOCLMAI);
		}
		if (ADEAJENPGHN != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ADEAJENPGHN);
		}
		cJECINJPIIJ_.WriteTo(ref output, _repeated_cJECINJPIIJ_codec);
		if (KHIIKNBHMHC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KHIIKNBHMHC);
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
		if (LOIJLIKOMJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOIJLIKOMJN);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rank);
		}
		if (MBAFIOCLMAI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MBAFIOCLMAI);
		}
		if (ADEAJENPGHN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ADEAJENPGHN);
		}
		num += cJECINJPIIJ_.CalculateSize(_repeated_cJECINJPIIJ_codec);
		if (KHIIKNBHMHC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KHIIKNBHMHC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CONKDELHKGB other)
	{
		if (other != null)
		{
			if (other.LOIJLIKOMJN != 0)
			{
				LOIJLIKOMJN = other.LOIJLIKOMJN;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.MBAFIOCLMAI != 0)
			{
				MBAFIOCLMAI = other.MBAFIOCLMAI;
			}
			if (other.ADEAJENPGHN != 0)
			{
				ADEAJENPGHN = other.ADEAJENPGHN;
			}
			cJECINJPIIJ_.Add(other.cJECINJPIIJ_);
			if (other.KHIIKNBHMHC != 0)
			{
				KHIIKNBHMHC = other.KHIIKNBHMHC;
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
			case 8u:
				LOIJLIKOMJN = input.ReadUInt32();
				break;
			case 16u:
				Rank = input.ReadUInt32();
				break;
			case 24u:
				MBAFIOCLMAI = input.ReadUInt32();
				break;
			case 32u:
				ADEAJENPGHN = input.ReadUInt32();
				break;
			case 42u:
				cJECINJPIIJ_.AddEntriesFrom(ref input, _repeated_cJECINJPIIJ_codec);
				break;
			case 48u:
				KHIIKNBHMHC = input.ReadUInt32();
				break;
			}
		}
	}
}
