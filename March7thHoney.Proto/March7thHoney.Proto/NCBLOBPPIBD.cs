using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NCBLOBPPIBD : IMessage<NCBLOBPPIBD>, IMessage, IEquatable<NCBLOBPPIBD>, IDeepCloneable<NCBLOBPPIBD>, IBufferMessage
{
	private static readonly MessageParser<NCBLOBPPIBD> _parser = new MessageParser<NCBLOBPPIBD>(() => new NCBLOBPPIBD());

	private UnknownFieldSet _unknownFields;

	public const int BEKCHIMDNJGFieldNumber = 1;

	private uint bEKCHIMDNJG_;

	public const int MAPDNLBHHCDFieldNumber = 4;

	private uint mAPDNLBHHCD_;

	public const int MMIIINJDLAMFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_mMIIINJDLAM_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> mMIIINJDLAM_ = new RepeatedField<uint>();

	public const int CKJECOHKCLLFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_cKJECOHKCLL_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> cKJECOHKCLL_ = new RepeatedField<uint>();

	public const int JNMBJHJPBOKFieldNumber = 8;

	private uint jNMBJHJPBOK_;

	public const int JGLKNEOCJCHFieldNumber = 10;

	private uint jGLKNEOCJCH_;

	public const int GEPGGGDKBNKFieldNumber = 11;

	private ChimeraDuelPlayerRankData gEPGGGDKBNK_;

	public const int GLCOINHKHMMFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_gLCOINHKHMM_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> gLCOINHKHMM_ = new RepeatedField<uint>();

	public const int EAPLGIOFDDGFieldNumber = 15;

	private static readonly FieldCodec<HPHMMPDFMAK> _repeated_eAPLGIOFDDG_codec = FieldCodec.ForMessage(122u, HPHMMPDFMAK.Parser);

	private readonly RepeatedField<HPHMMPDFMAK> eAPLGIOFDDG_ = new RepeatedField<HPHMMPDFMAK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NCBLOBPPIBD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NCBLOBPPIBDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BEKCHIMDNJG
	{
		get
		{
			return bEKCHIMDNJG_;
		}
		set
		{
			bEKCHIMDNJG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAPDNLBHHCD
	{
		get
		{
			return mAPDNLBHHCD_;
		}
		set
		{
			mAPDNLBHHCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MMIIINJDLAM => mMIIINJDLAM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CKJECOHKCLL => cKJECOHKCLL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JNMBJHJPBOK
	{
		get
		{
			return jNMBJHJPBOK_;
		}
		set
		{
			jNMBJHJPBOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JGLKNEOCJCH
	{
		get
		{
			return jGLKNEOCJCH_;
		}
		set
		{
			jGLKNEOCJCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelPlayerRankData GEPGGGDKBNK
	{
		get
		{
			return gEPGGGDKBNK_;
		}
		set
		{
			gEPGGGDKBNK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GLCOINHKHMM => gLCOINHKHMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HPHMMPDFMAK> EAPLGIOFDDG => eAPLGIOFDDG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCBLOBPPIBD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCBLOBPPIBD(NCBLOBPPIBD other)
		: this()
	{
		bEKCHIMDNJG_ = other.bEKCHIMDNJG_;
		mAPDNLBHHCD_ = other.mAPDNLBHHCD_;
		mMIIINJDLAM_ = other.mMIIINJDLAM_.Clone();
		cKJECOHKCLL_ = other.cKJECOHKCLL_.Clone();
		jNMBJHJPBOK_ = other.jNMBJHJPBOK_;
		jGLKNEOCJCH_ = other.jGLKNEOCJCH_;
		gEPGGGDKBNK_ = ((other.gEPGGGDKBNK_ != null) ? other.gEPGGGDKBNK_.Clone() : null);
		gLCOINHKHMM_ = other.gLCOINHKHMM_.Clone();
		eAPLGIOFDDG_ = other.eAPLGIOFDDG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCBLOBPPIBD Clone()
	{
		return new NCBLOBPPIBD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NCBLOBPPIBD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NCBLOBPPIBD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BEKCHIMDNJG != other.BEKCHIMDNJG)
		{
			return false;
		}
		if (MAPDNLBHHCD != other.MAPDNLBHHCD)
		{
			return false;
		}
		if (!mMIIINJDLAM_.Equals(other.mMIIINJDLAM_))
		{
			return false;
		}
		if (!cKJECOHKCLL_.Equals(other.cKJECOHKCLL_))
		{
			return false;
		}
		if (JNMBJHJPBOK != other.JNMBJHJPBOK)
		{
			return false;
		}
		if (JGLKNEOCJCH != other.JGLKNEOCJCH)
		{
			return false;
		}
		if (!object.Equals(GEPGGGDKBNK, other.GEPGGGDKBNK))
		{
			return false;
		}
		if (!gLCOINHKHMM_.Equals(other.gLCOINHKHMM_))
		{
			return false;
		}
		if (!eAPLGIOFDDG_.Equals(other.eAPLGIOFDDG_))
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
		if (BEKCHIMDNJG != 0)
		{
			num ^= BEKCHIMDNJG.GetHashCode();
		}
		if (MAPDNLBHHCD != 0)
		{
			num ^= MAPDNLBHHCD.GetHashCode();
		}
		num ^= mMIIINJDLAM_.GetHashCode();
		num ^= cKJECOHKCLL_.GetHashCode();
		if (JNMBJHJPBOK != 0)
		{
			num ^= JNMBJHJPBOK.GetHashCode();
		}
		if (JGLKNEOCJCH != 0)
		{
			num ^= JGLKNEOCJCH.GetHashCode();
		}
		if (gEPGGGDKBNK_ != null)
		{
			num ^= GEPGGGDKBNK.GetHashCode();
		}
		num ^= gLCOINHKHMM_.GetHashCode();
		num ^= eAPLGIOFDDG_.GetHashCode();
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
		if (BEKCHIMDNJG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BEKCHIMDNJG);
		}
		if (MAPDNLBHHCD != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MAPDNLBHHCD);
		}
		mMIIINJDLAM_.WriteTo(ref output, _repeated_mMIIINJDLAM_codec);
		cKJECOHKCLL_.WriteTo(ref output, _repeated_cKJECOHKCLL_codec);
		if (JNMBJHJPBOK != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(JNMBJHJPBOK);
		}
		if (JGLKNEOCJCH != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(JGLKNEOCJCH);
		}
		if (gEPGGGDKBNK_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(GEPGGGDKBNK);
		}
		gLCOINHKHMM_.WriteTo(ref output, _repeated_gLCOINHKHMM_codec);
		eAPLGIOFDDG_.WriteTo(ref output, _repeated_eAPLGIOFDDG_codec);
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
		if (BEKCHIMDNJG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BEKCHIMDNJG);
		}
		if (MAPDNLBHHCD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAPDNLBHHCD);
		}
		num += mMIIINJDLAM_.CalculateSize(_repeated_mMIIINJDLAM_codec);
		num += cKJECOHKCLL_.CalculateSize(_repeated_cKJECOHKCLL_codec);
		if (JNMBJHJPBOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JNMBJHJPBOK);
		}
		if (JGLKNEOCJCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JGLKNEOCJCH);
		}
		if (gEPGGGDKBNK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GEPGGGDKBNK);
		}
		num += gLCOINHKHMM_.CalculateSize(_repeated_gLCOINHKHMM_codec);
		num += eAPLGIOFDDG_.CalculateSize(_repeated_eAPLGIOFDDG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NCBLOBPPIBD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BEKCHIMDNJG != 0)
		{
			BEKCHIMDNJG = other.BEKCHIMDNJG;
		}
		if (other.MAPDNLBHHCD != 0)
		{
			MAPDNLBHHCD = other.MAPDNLBHHCD;
		}
		mMIIINJDLAM_.Add(other.mMIIINJDLAM_);
		cKJECOHKCLL_.Add(other.cKJECOHKCLL_);
		if (other.JNMBJHJPBOK != 0)
		{
			JNMBJHJPBOK = other.JNMBJHJPBOK;
		}
		if (other.JGLKNEOCJCH != 0)
		{
			JGLKNEOCJCH = other.JGLKNEOCJCH;
		}
		if (other.gEPGGGDKBNK_ != null)
		{
			if (gEPGGGDKBNK_ == null)
			{
				GEPGGGDKBNK = new ChimeraDuelPlayerRankData();
			}
			GEPGGGDKBNK.MergeFrom(other.GEPGGGDKBNK);
		}
		gLCOINHKHMM_.Add(other.gLCOINHKHMM_);
		eAPLGIOFDDG_.Add(other.eAPLGIOFDDG_);
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
			case 8u:
				BEKCHIMDNJG = input.ReadUInt32();
				break;
			case 32u:
				MAPDNLBHHCD = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				mMIIINJDLAM_.AddEntriesFrom(ref input, _repeated_mMIIINJDLAM_codec);
				break;
			case 56u:
			case 58u:
				cKJECOHKCLL_.AddEntriesFrom(ref input, _repeated_cKJECOHKCLL_codec);
				break;
			case 64u:
				JNMBJHJPBOK = input.ReadUInt32();
				break;
			case 80u:
				JGLKNEOCJCH = input.ReadUInt32();
				break;
			case 90u:
				if (gEPGGGDKBNK_ == null)
				{
					GEPGGGDKBNK = new ChimeraDuelPlayerRankData();
				}
				input.ReadMessage(GEPGGGDKBNK);
				break;
			case 112u:
			case 114u:
				gLCOINHKHMM_.AddEntriesFrom(ref input, _repeated_gLCOINHKHMM_codec);
				break;
			case 122u:
				eAPLGIOFDDG_.AddEntriesFrom(ref input, _repeated_eAPLGIOFDDG_codec);
				break;
			}
		}
	}
}
