using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HCJPOGHDAAH : IMessage<HCJPOGHDAAH>, IMessage, IEquatable<HCJPOGHDAAH>, IDeepCloneable<HCJPOGHDAAH>, IBufferMessage
{
	private static readonly MessageParser<HCJPOGHDAAH> _parser = new MessageParser<HCJPOGHDAAH>(() => new HCJPOGHDAAH());

	private UnknownFieldSet _unknownFields;

	public const int ICHMKFMAIBBFieldNumber = 3;

	private static readonly FieldCodec<OJMLKJJCDIG> _repeated_iCHMKFMAIBB_codec = FieldCodec.ForMessage(26u, OJMLKJJCDIG.Parser);

	private readonly RepeatedField<OJMLKJJCDIG> iCHMKFMAIBB_ = new RepeatedField<OJMLKJJCDIG>();

	public const int EPLBCNFMLILFieldNumber = 7;

	private uint ePLBCNFMLIL_;

	public const int KDAOKODEIEJFieldNumber = 10;

	private float kDAOKODEIEJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HCJPOGHDAAH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HCJPOGHDAAHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OJMLKJJCDIG> ICHMKFMAIBB => iCHMKFMAIBB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPLBCNFMLIL
	{
		get
		{
			return ePLBCNFMLIL_;
		}
		set
		{
			ePLBCNFMLIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public float KDAOKODEIEJ
	{
		get
		{
			return kDAOKODEIEJ_;
		}
		set
		{
			kDAOKODEIEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCJPOGHDAAH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCJPOGHDAAH(HCJPOGHDAAH other)
		: this()
	{
		iCHMKFMAIBB_ = other.iCHMKFMAIBB_.Clone();
		ePLBCNFMLIL_ = other.ePLBCNFMLIL_;
		kDAOKODEIEJ_ = other.kDAOKODEIEJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HCJPOGHDAAH Clone()
	{
		return new HCJPOGHDAAH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HCJPOGHDAAH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HCJPOGHDAAH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iCHMKFMAIBB_.Equals(other.iCHMKFMAIBB_))
		{
			return false;
		}
		if (EPLBCNFMLIL != other.EPLBCNFMLIL)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(KDAOKODEIEJ, other.KDAOKODEIEJ))
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
		num ^= iCHMKFMAIBB_.GetHashCode();
		if (EPLBCNFMLIL != 0)
		{
			num ^= EPLBCNFMLIL.GetHashCode();
		}
		if (KDAOKODEIEJ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(KDAOKODEIEJ);
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
		iCHMKFMAIBB_.WriteTo(ref output, _repeated_iCHMKFMAIBB_codec);
		if (EPLBCNFMLIL != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EPLBCNFMLIL);
		}
		if (KDAOKODEIEJ != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(KDAOKODEIEJ);
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
		num += iCHMKFMAIBB_.CalculateSize(_repeated_iCHMKFMAIBB_codec);
		if (EPLBCNFMLIL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPLBCNFMLIL);
		}
		if (KDAOKODEIEJ != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HCJPOGHDAAH other)
	{
		if (other != null)
		{
			iCHMKFMAIBB_.Add(other.iCHMKFMAIBB_);
			if (other.EPLBCNFMLIL != 0)
			{
				EPLBCNFMLIL = other.EPLBCNFMLIL;
			}
			if (other.KDAOKODEIEJ != 0f)
			{
				KDAOKODEIEJ = other.KDAOKODEIEJ;
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
			case 26u:
				iCHMKFMAIBB_.AddEntriesFrom(ref input, _repeated_iCHMKFMAIBB_codec);
				break;
			case 56u:
				EPLBCNFMLIL = input.ReadUInt32();
				break;
			case 85u:
				KDAOKODEIEJ = input.ReadFloat();
				break;
			}
		}
	}
}
