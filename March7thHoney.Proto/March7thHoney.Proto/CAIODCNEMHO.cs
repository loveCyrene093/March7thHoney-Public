using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CAIODCNEMHO : IMessage<CAIODCNEMHO>, IMessage, IEquatable<CAIODCNEMHO>, IDeepCloneable<CAIODCNEMHO>, IBufferMessage
{
	private static readonly MessageParser<CAIODCNEMHO> _parser = new MessageParser<CAIODCNEMHO>(() => new CAIODCNEMHO());

	private UnknownFieldSet _unknownFields;

	public const int IGNNGJMEBHKFieldNumber = 2;

	private uint iGNNGJMEBHK_;

	public const int DKHKBBMPCICFieldNumber = 3;

	private uint dKHKBBMPCIC_;

	public const int HEFFMGAIKMNFieldNumber = 5;

	private uint hEFFMGAIKMN_;

	public const int AvatarIdFieldNumber = 6;

	private uint avatarId_;

	public const int AEBKEMDACBMFieldNumber = 7;

	private uint aEBKEMDACBM_;

	public const int JFLIGNCAAEJFieldNumber = 9;

	private bool jFLIGNCAAEJ_;

	public const int AIHNKPOGCFIFieldNumber = 10;

	private uint aIHNKPOGCFI_;

	public const int IHOONGPLLHJFieldNumber = 12;

	private bool iHOONGPLLHJ_;

	public const int IDAPPIBPHHHFieldNumber = 14;

	private double iDAPPIBPHHH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CAIODCNEMHO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CAIODCNEMHOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGNNGJMEBHK
	{
		get
		{
			return iGNNGJMEBHK_;
		}
		set
		{
			iGNNGJMEBHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKHKBBMPCIC
	{
		get
		{
			return dKHKBBMPCIC_;
		}
		set
		{
			dKHKBBMPCIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEFFMGAIKMN
	{
		get
		{
			return hEFFMGAIKMN_;
		}
		set
		{
			hEFFMGAIKMN_ = value;
		}
	}

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
	public uint AEBKEMDACBM
	{
		get
		{
			return aEBKEMDACBM_;
		}
		set
		{
			aEBKEMDACBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JFLIGNCAAEJ
	{
		get
		{
			return jFLIGNCAAEJ_;
		}
		set
		{
			jFLIGNCAAEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AIHNKPOGCFI
	{
		get
		{
			return aIHNKPOGCFI_;
		}
		set
		{
			aIHNKPOGCFI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IHOONGPLLHJ
	{
		get
		{
			return iHOONGPLLHJ_;
		}
		set
		{
			iHOONGPLLHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double IDAPPIBPHHH
	{
		get
		{
			return iDAPPIBPHHH_;
		}
		set
		{
			iDAPPIBPHHH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAIODCNEMHO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAIODCNEMHO(CAIODCNEMHO other)
		: this()
	{
		iGNNGJMEBHK_ = other.iGNNGJMEBHK_;
		dKHKBBMPCIC_ = other.dKHKBBMPCIC_;
		hEFFMGAIKMN_ = other.hEFFMGAIKMN_;
		avatarId_ = other.avatarId_;
		aEBKEMDACBM_ = other.aEBKEMDACBM_;
		jFLIGNCAAEJ_ = other.jFLIGNCAAEJ_;
		aIHNKPOGCFI_ = other.aIHNKPOGCFI_;
		iHOONGPLLHJ_ = other.iHOONGPLLHJ_;
		iDAPPIBPHHH_ = other.iDAPPIBPHHH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAIODCNEMHO Clone()
	{
		return new CAIODCNEMHO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CAIODCNEMHO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CAIODCNEMHO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IGNNGJMEBHK != other.IGNNGJMEBHK)
		{
			return false;
		}
		if (DKHKBBMPCIC != other.DKHKBBMPCIC)
		{
			return false;
		}
		if (HEFFMGAIKMN != other.HEFFMGAIKMN)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (AEBKEMDACBM != other.AEBKEMDACBM)
		{
			return false;
		}
		if (JFLIGNCAAEJ != other.JFLIGNCAAEJ)
		{
			return false;
		}
		if (AIHNKPOGCFI != other.AIHNKPOGCFI)
		{
			return false;
		}
		if (IHOONGPLLHJ != other.IHOONGPLLHJ)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(IDAPPIBPHHH, other.IDAPPIBPHHH))
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
		if (IGNNGJMEBHK != 0)
		{
			num ^= IGNNGJMEBHK.GetHashCode();
		}
		if (DKHKBBMPCIC != 0)
		{
			num ^= DKHKBBMPCIC.GetHashCode();
		}
		if (HEFFMGAIKMN != 0)
		{
			num ^= HEFFMGAIKMN.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (AEBKEMDACBM != 0)
		{
			num ^= AEBKEMDACBM.GetHashCode();
		}
		if (JFLIGNCAAEJ)
		{
			num ^= JFLIGNCAAEJ.GetHashCode();
		}
		if (AIHNKPOGCFI != 0)
		{
			num ^= AIHNKPOGCFI.GetHashCode();
		}
		if (IHOONGPLLHJ)
		{
			num ^= IHOONGPLLHJ.GetHashCode();
		}
		if (IDAPPIBPHHH != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(IDAPPIBPHHH);
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
		if (IGNNGJMEBHK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(IGNNGJMEBHK);
		}
		if (DKHKBBMPCIC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DKHKBBMPCIC);
		}
		if (HEFFMGAIKMN != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(HEFFMGAIKMN);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(AvatarId);
		}
		if (AEBKEMDACBM != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(AEBKEMDACBM);
		}
		if (JFLIGNCAAEJ)
		{
			output.WriteRawTag(72);
			output.WriteBool(JFLIGNCAAEJ);
		}
		if (AIHNKPOGCFI != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AIHNKPOGCFI);
		}
		if (IHOONGPLLHJ)
		{
			output.WriteRawTag(96);
			output.WriteBool(IHOONGPLLHJ);
		}
		if (IDAPPIBPHHH != 0.0)
		{
			output.WriteRawTag(113);
			output.WriteDouble(IDAPPIBPHHH);
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
		if (IGNNGJMEBHK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGNNGJMEBHK);
		}
		if (DKHKBBMPCIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKHKBBMPCIC);
		}
		if (HEFFMGAIKMN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEFFMGAIKMN);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (AEBKEMDACBM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AEBKEMDACBM);
		}
		if (JFLIGNCAAEJ)
		{
			num += 2;
		}
		if (AIHNKPOGCFI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AIHNKPOGCFI);
		}
		if (IHOONGPLLHJ)
		{
			num += 2;
		}
		if (IDAPPIBPHHH != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CAIODCNEMHO other)
	{
		if (other != null)
		{
			if (other.IGNNGJMEBHK != 0)
			{
				IGNNGJMEBHK = other.IGNNGJMEBHK;
			}
			if (other.DKHKBBMPCIC != 0)
			{
				DKHKBBMPCIC = other.DKHKBBMPCIC;
			}
			if (other.HEFFMGAIKMN != 0)
			{
				HEFFMGAIKMN = other.HEFFMGAIKMN;
			}
			if (other.AvatarId != 0)
			{
				AvatarId = other.AvatarId;
			}
			if (other.AEBKEMDACBM != 0)
			{
				AEBKEMDACBM = other.AEBKEMDACBM;
			}
			if (other.JFLIGNCAAEJ)
			{
				JFLIGNCAAEJ = other.JFLIGNCAAEJ;
			}
			if (other.AIHNKPOGCFI != 0)
			{
				AIHNKPOGCFI = other.AIHNKPOGCFI;
			}
			if (other.IHOONGPLLHJ)
			{
				IHOONGPLLHJ = other.IHOONGPLLHJ;
			}
			if (other.IDAPPIBPHHH != 0.0)
			{
				IDAPPIBPHHH = other.IDAPPIBPHHH;
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
				IGNNGJMEBHK = input.ReadUInt32();
				break;
			case 24u:
				DKHKBBMPCIC = input.ReadUInt32();
				break;
			case 40u:
				HEFFMGAIKMN = input.ReadUInt32();
				break;
			case 48u:
				AvatarId = input.ReadUInt32();
				break;
			case 56u:
				AEBKEMDACBM = input.ReadUInt32();
				break;
			case 72u:
				JFLIGNCAAEJ = input.ReadBool();
				break;
			case 80u:
				AIHNKPOGCFI = input.ReadUInt32();
				break;
			case 96u:
				IHOONGPLLHJ = input.ReadBool();
				break;
			case 113u:
				IDAPPIBPHHH = input.ReadDouble();
				break;
			}
		}
	}
}
