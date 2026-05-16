using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GCJAMHEGKGE : IMessage<GCJAMHEGKGE>, IMessage, IEquatable<GCJAMHEGKGE>, IDeepCloneable<GCJAMHEGKGE>, IBufferMessage
{
	private static readonly MessageParser<GCJAMHEGKGE> _parser = new MessageParser<GCJAMHEGKGE>(() => new GCJAMHEGKGE());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 1;

	private static readonly FieldCodec<DiceCombatAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage(10u, DiceCombatAvatar.Parser);

	private readonly RepeatedField<DiceCombatAvatar> avatarList_ = new RepeatedField<DiceCombatAvatar>();

	public const int GEPHFOKBIEOFieldNumber = 2;

	private KKJHOOBJCGG gEPHFOKBIEO_;

	public const int MGGCNMLFCBIFieldNumber = 3;

	private NIGBBJGOJML mGGCNMLFCBI_;

	public const int FOOLMIADMMHFieldNumber = 4;

	private uint fOOLMIADMMH_;

	public const int EBCAFMGMFEOFieldNumber = 5;

	private uint eBCAFMGMFEO_;

	public const int PIEBLJJGCMKFieldNumber = 6;

	private uint pIEBLJJGCMK_;

	public const int MHKAKBKMNFJFieldNumber = 7;

	private bool mHKAKBKMNFJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GCJAMHEGKGE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GCJAMHEGKGEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DiceCombatAvatar> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKJHOOBJCGG GEPHFOKBIEO
	{
		get
		{
			return gEPHFOKBIEO_;
		}
		set
		{
			gEPHFOKBIEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NIGBBJGOJML MGGCNMLFCBI
	{
		get
		{
			return mGGCNMLFCBI_;
		}
		set
		{
			mGGCNMLFCBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FOOLMIADMMH
	{
		get
		{
			return fOOLMIADMMH_;
		}
		set
		{
			fOOLMIADMMH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EBCAFMGMFEO
	{
		get
		{
			return eBCAFMGMFEO_;
		}
		set
		{
			eBCAFMGMFEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PIEBLJJGCMK
	{
		get
		{
			return pIEBLJJGCMK_;
		}
		set
		{
			pIEBLJJGCMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MHKAKBKMNFJ
	{
		get
		{
			return mHKAKBKMNFJ_;
		}
		set
		{
			mHKAKBKMNFJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCJAMHEGKGE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCJAMHEGKGE(GCJAMHEGKGE other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		gEPHFOKBIEO_ = ((other.gEPHFOKBIEO_ != null) ? other.gEPHFOKBIEO_.Clone() : null);
		mGGCNMLFCBI_ = ((other.mGGCNMLFCBI_ != null) ? other.mGGCNMLFCBI_.Clone() : null);
		fOOLMIADMMH_ = other.fOOLMIADMMH_;
		eBCAFMGMFEO_ = other.eBCAFMGMFEO_;
		pIEBLJJGCMK_ = other.pIEBLJJGCMK_;
		mHKAKBKMNFJ_ = other.mHKAKBKMNFJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCJAMHEGKGE Clone()
	{
		return new GCJAMHEGKGE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GCJAMHEGKGE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GCJAMHEGKGE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (!object.Equals(GEPHFOKBIEO, other.GEPHFOKBIEO))
		{
			return false;
		}
		if (!object.Equals(MGGCNMLFCBI, other.MGGCNMLFCBI))
		{
			return false;
		}
		if (FOOLMIADMMH != other.FOOLMIADMMH)
		{
			return false;
		}
		if (EBCAFMGMFEO != other.EBCAFMGMFEO)
		{
			return false;
		}
		if (PIEBLJJGCMK != other.PIEBLJJGCMK)
		{
			return false;
		}
		if (MHKAKBKMNFJ != other.MHKAKBKMNFJ)
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
		num ^= avatarList_.GetHashCode();
		if (gEPHFOKBIEO_ != null)
		{
			num ^= GEPHFOKBIEO.GetHashCode();
		}
		if (mGGCNMLFCBI_ != null)
		{
			num ^= MGGCNMLFCBI.GetHashCode();
		}
		if (FOOLMIADMMH != 0)
		{
			num ^= FOOLMIADMMH.GetHashCode();
		}
		if (EBCAFMGMFEO != 0)
		{
			num ^= EBCAFMGMFEO.GetHashCode();
		}
		if (PIEBLJJGCMK != 0)
		{
			num ^= PIEBLJJGCMK.GetHashCode();
		}
		if (MHKAKBKMNFJ)
		{
			num ^= MHKAKBKMNFJ.GetHashCode();
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
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (gEPHFOKBIEO_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(GEPHFOKBIEO);
		}
		if (mGGCNMLFCBI_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MGGCNMLFCBI);
		}
		if (FOOLMIADMMH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(FOOLMIADMMH);
		}
		if (EBCAFMGMFEO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(EBCAFMGMFEO);
		}
		if (PIEBLJJGCMK != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PIEBLJJGCMK);
		}
		if (MHKAKBKMNFJ)
		{
			output.WriteRawTag(56);
			output.WriteBool(MHKAKBKMNFJ);
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
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (gEPHFOKBIEO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GEPHFOKBIEO);
		}
		if (mGGCNMLFCBI_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MGGCNMLFCBI);
		}
		if (FOOLMIADMMH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FOOLMIADMMH);
		}
		if (EBCAFMGMFEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EBCAFMGMFEO);
		}
		if (PIEBLJJGCMK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PIEBLJJGCMK);
		}
		if (MHKAKBKMNFJ)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GCJAMHEGKGE other)
	{
		if (other == null)
		{
			return;
		}
		avatarList_.Add(other.avatarList_);
		if (other.gEPHFOKBIEO_ != null)
		{
			if (gEPHFOKBIEO_ == null)
			{
				GEPHFOKBIEO = new KKJHOOBJCGG();
			}
			GEPHFOKBIEO.MergeFrom(other.GEPHFOKBIEO);
		}
		if (other.mGGCNMLFCBI_ != null)
		{
			if (mGGCNMLFCBI_ == null)
			{
				MGGCNMLFCBI = new NIGBBJGOJML();
			}
			MGGCNMLFCBI.MergeFrom(other.MGGCNMLFCBI);
		}
		if (other.FOOLMIADMMH != 0)
		{
			FOOLMIADMMH = other.FOOLMIADMMH;
		}
		if (other.EBCAFMGMFEO != 0)
		{
			EBCAFMGMFEO = other.EBCAFMGMFEO;
		}
		if (other.PIEBLJJGCMK != 0)
		{
			PIEBLJJGCMK = other.PIEBLJJGCMK;
		}
		if (other.MHKAKBKMNFJ)
		{
			MHKAKBKMNFJ = other.MHKAKBKMNFJ;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 18u:
				if (gEPHFOKBIEO_ == null)
				{
					GEPHFOKBIEO = new KKJHOOBJCGG();
				}
				input.ReadMessage(GEPHFOKBIEO);
				break;
			case 26u:
				if (mGGCNMLFCBI_ == null)
				{
					MGGCNMLFCBI = new NIGBBJGOJML();
				}
				input.ReadMessage(MGGCNMLFCBI);
				break;
			case 32u:
				FOOLMIADMMH = input.ReadUInt32();
				break;
			case 40u:
				EBCAFMGMFEO = input.ReadUInt32();
				break;
			case 48u:
				PIEBLJJGCMK = input.ReadUInt32();
				break;
			case 56u:
				MHKAKBKMNFJ = input.ReadBool();
				break;
			}
		}
	}
}
