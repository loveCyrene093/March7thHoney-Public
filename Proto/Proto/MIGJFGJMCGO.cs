using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MIGJFGJMCGO : IMessage<MIGJFGJMCGO>, IMessage, IEquatable<MIGJFGJMCGO>, IDeepCloneable<MIGJFGJMCGO>, IBufferMessage
{
	private static readonly MessageParser<MIGJFGJMCGO> _parser = new MessageParser<MIGJFGJMCGO>(() => new MIGJFGJMCGO());

	private UnknownFieldSet _unknownFields;

	public const int AvatarIdFieldNumber = 1;

	private uint avatarId_;

	public const int KFINACEFCNJFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_kFINACEFCNJ_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> kFINACEFCNJ_ = new RepeatedField<uint>();

	public const int SourceFieldNumber = 3;

	private uint source_;

	public const int DamageFieldNumber = 4;

	private double damage_;

	public const int COIHNJCHNMJFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_cOIHNJCHNMJ_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> cOIHNJCHNMJ_ = new RepeatedField<uint>();

	public const int IIKAMPCHBLNFieldNumber = 6;

	private int iIKAMPCHBLN_;

	public const int MEPKKFLKPGMFieldNumber = 7;

	private double mEPKKFLKPGM_;

	public const int KPKHJJAHHEMFieldNumber = 8;

	private uint kPKHJJAHHEM_;

	public const int WaveFieldNumber = 9;

	private uint wave_;

	public const int EnhancedIdFieldNumber = 10;

	private uint enhancedId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MIGJFGJMCGO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MIGJFGJMCGOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KFINACEFCNJ => kFINACEFCNJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double Damage
	{
		get
		{
			return damage_;
		}
		set
		{
			damage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> COIHNJCHNMJ => cOIHNJCHNMJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int IIKAMPCHBLN
	{
		get
		{
			return iIKAMPCHBLN_;
		}
		set
		{
			iIKAMPCHBLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double MEPKKFLKPGM
	{
		get
		{
			return mEPKKFLKPGM_;
		}
		set
		{
			mEPKKFLKPGM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KPKHJJAHHEM
	{
		get
		{
			return kPKHJJAHHEM_;
		}
		set
		{
			kPKHJJAHHEM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Wave
	{
		get
		{
			return wave_;
		}
		set
		{
			wave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EnhancedId
	{
		get
		{
			return enhancedId_;
		}
		set
		{
			enhancedId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIGJFGJMCGO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIGJFGJMCGO(MIGJFGJMCGO other)
		: this()
	{
		avatarId_ = other.avatarId_;
		kFINACEFCNJ_ = other.kFINACEFCNJ_.Clone();
		source_ = other.source_;
		damage_ = other.damage_;
		cOIHNJCHNMJ_ = other.cOIHNJCHNMJ_.Clone();
		iIKAMPCHBLN_ = other.iIKAMPCHBLN_;
		mEPKKFLKPGM_ = other.mEPKKFLKPGM_;
		kPKHJJAHHEM_ = other.kPKHJJAHHEM_;
		wave_ = other.wave_;
		enhancedId_ = other.enhancedId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MIGJFGJMCGO Clone()
	{
		return new MIGJFGJMCGO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MIGJFGJMCGO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MIGJFGJMCGO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!kFINACEFCNJ_.Equals(other.kFINACEFCNJ_))
		{
			return false;
		}
		if (Source != other.Source)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Damage, other.Damage))
		{
			return false;
		}
		if (!cOIHNJCHNMJ_.Equals(other.cOIHNJCHNMJ_))
		{
			return false;
		}
		if (IIKAMPCHBLN != other.IIKAMPCHBLN)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MEPKKFLKPGM, other.MEPKKFLKPGM))
		{
			return false;
		}
		if (KPKHJJAHHEM != other.KPKHJJAHHEM)
		{
			return false;
		}
		if (Wave != other.Wave)
		{
			return false;
		}
		if (EnhancedId != other.EnhancedId)
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
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		num ^= kFINACEFCNJ_.GetHashCode();
		if (Source != 0)
		{
			num ^= Source.GetHashCode();
		}
		if (Damage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Damage);
		}
		num ^= cOIHNJCHNMJ_.GetHashCode();
		if (IIKAMPCHBLN != 0)
		{
			num ^= IIKAMPCHBLN.GetHashCode();
		}
		if (MEPKKFLKPGM != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MEPKKFLKPGM);
		}
		if (KPKHJJAHHEM != 0)
		{
			num ^= KPKHJJAHHEM.GetHashCode();
		}
		if (Wave != 0)
		{
			num ^= Wave.GetHashCode();
		}
		if (EnhancedId != 0)
		{
			num ^= EnhancedId.GetHashCode();
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
		if (AvatarId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AvatarId);
		}
		kFINACEFCNJ_.WriteTo(ref output, _repeated_kFINACEFCNJ_codec);
		if (Source != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Source);
		}
		if (Damage != 0.0)
		{
			output.WriteRawTag(33);
			output.WriteDouble(Damage);
		}
		cOIHNJCHNMJ_.WriteTo(ref output, _repeated_cOIHNJCHNMJ_codec);
		if (IIKAMPCHBLN != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(IIKAMPCHBLN);
		}
		if (MEPKKFLKPGM != 0.0)
		{
			output.WriteRawTag(57);
			output.WriteDouble(MEPKKFLKPGM);
		}
		if (KPKHJJAHHEM != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(KPKHJJAHHEM);
		}
		if (Wave != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Wave);
		}
		if (EnhancedId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(EnhancedId);
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
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		num += kFINACEFCNJ_.CalculateSize(_repeated_kFINACEFCNJ_codec);
		if (Source != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Source);
		}
		if (Damage != 0.0)
		{
			num += 9;
		}
		num += cOIHNJCHNMJ_.CalculateSize(_repeated_cOIHNJCHNMJ_codec);
		if (IIKAMPCHBLN != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IIKAMPCHBLN);
		}
		if (MEPKKFLKPGM != 0.0)
		{
			num += 9;
		}
		if (KPKHJJAHHEM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KPKHJJAHHEM);
		}
		if (Wave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Wave);
		}
		if (EnhancedId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EnhancedId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MIGJFGJMCGO other)
	{
		if (other != null)
		{
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			kFINACEFCNJ_.Add(other.kFINACEFCNJ_);
			if (other.Source != 0)
			{
				Source = other.Source;
			}
			if (other.Damage != 0.0)
			{
				Damage = other.Damage;
			}
			cOIHNJCHNMJ_.Add(other.cOIHNJCHNMJ_);
			if (other.IIKAMPCHBLN != 0)
			{
				IIKAMPCHBLN = other.IIKAMPCHBLN;
			}
			if (other.MEPKKFLKPGM != 0.0)
			{
				MEPKKFLKPGM = other.MEPKKFLKPGM;
			}
			if (other.KPKHJJAHHEM != 0)
			{
				KPKHJJAHHEM = other.KPKHJJAHHEM;
			}
			if (other.Wave != 0)
			{
				Wave = other.Wave;
			}
			if (other.EnhancedId != 0)
			{
				EnhancedId = other.EnhancedId;
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
				AvatarId = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				kFINACEFCNJ_.AddEntriesFrom(ref input, _repeated_kFINACEFCNJ_codec);
				break;
			case 24u:
				Source = input.ReadUInt32();
				break;
			case 33u:
				Damage = input.ReadDouble();
				break;
			case 40u:
			case 42u:
				cOIHNJCHNMJ_.AddEntriesFrom(ref input, _repeated_cOIHNJCHNMJ_codec);
				break;
			case 48u:
				IIKAMPCHBLN = input.ReadInt32();
				break;
			case 57u:
				MEPKKFLKPGM = input.ReadDouble();
				break;
			case 64u:
				KPKHJJAHHEM = input.ReadUInt32();
				break;
			case 72u:
				Wave = input.ReadUInt32();
				break;
			case 80u:
				EnhancedId = input.ReadUInt32();
				break;
			}
		}
	}
}
