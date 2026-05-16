using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GDKPBDAAKBH : IMessage<GDKPBDAAKBH>, IMessage, IEquatable<GDKPBDAAKBH>, IDeepCloneable<GDKPBDAAKBH>, IBufferMessage
{
	private static readonly MessageParser<GDKPBDAAKBH> _parser = new MessageParser<GDKPBDAAKBH>(() => new GDKPBDAAKBH());

	private UnknownFieldSet _unknownFields;

	public const int MPJPBLLCMHKFieldNumber = 4;

	private uint mPJPBLLCMHK_;

	public const int DGGAIEANNBJFieldNumber = 7;

	private uint dGGAIEANNBJ_;

	public const int IGFHEGBCGBHFieldNumber = 8;

	private uint iGFHEGBCGBH_;

	public const int FELAADBOAKDFieldNumber = 11;

	private uint fELAADBOAKD_;

	public const int DPEJNGNBHDMFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_dPEJNGNBHDM_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> dPEJNGNBHDM_ = new RepeatedField<uint>();

	public const int DHFGLLAIFHPFieldNumber = 15;

	private uint dHFGLLAIFHP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GDKPBDAAKBH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GDKPBDAAKBHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MPJPBLLCMHK
	{
		get
		{
			return mPJPBLLCMHK_;
		}
		set
		{
			mPJPBLLCMHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DGGAIEANNBJ
	{
		get
		{
			return dGGAIEANNBJ_;
		}
		set
		{
			dGGAIEANNBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGFHEGBCGBH
	{
		get
		{
			return iGFHEGBCGBH_;
		}
		set
		{
			iGFHEGBCGBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FELAADBOAKD
	{
		get
		{
			return fELAADBOAKD_;
		}
		set
		{
			fELAADBOAKD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DPEJNGNBHDM => dPEJNGNBHDM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DHFGLLAIFHP
	{
		get
		{
			return dHFGLLAIFHP_;
		}
		set
		{
			dHFGLLAIFHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDKPBDAAKBH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDKPBDAAKBH(GDKPBDAAKBH other)
		: this()
	{
		mPJPBLLCMHK_ = other.mPJPBLLCMHK_;
		dGGAIEANNBJ_ = other.dGGAIEANNBJ_;
		iGFHEGBCGBH_ = other.iGFHEGBCGBH_;
		fELAADBOAKD_ = other.fELAADBOAKD_;
		dPEJNGNBHDM_ = other.dPEJNGNBHDM_.Clone();
		dHFGLLAIFHP_ = other.dHFGLLAIFHP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDKPBDAAKBH Clone()
	{
		return new GDKPBDAAKBH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GDKPBDAAKBH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GDKPBDAAKBH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MPJPBLLCMHK != other.MPJPBLLCMHK)
		{
			return false;
		}
		if (DGGAIEANNBJ != other.DGGAIEANNBJ)
		{
			return false;
		}
		if (IGFHEGBCGBH != other.IGFHEGBCGBH)
		{
			return false;
		}
		if (FELAADBOAKD != other.FELAADBOAKD)
		{
			return false;
		}
		if (!dPEJNGNBHDM_.Equals(other.dPEJNGNBHDM_))
		{
			return false;
		}
		if (DHFGLLAIFHP != other.DHFGLLAIFHP)
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
		if (MPJPBLLCMHK != 0)
		{
			num ^= MPJPBLLCMHK.GetHashCode();
		}
		if (DGGAIEANNBJ != 0)
		{
			num ^= DGGAIEANNBJ.GetHashCode();
		}
		if (IGFHEGBCGBH != 0)
		{
			num ^= IGFHEGBCGBH.GetHashCode();
		}
		if (FELAADBOAKD != 0)
		{
			num ^= FELAADBOAKD.GetHashCode();
		}
		num ^= dPEJNGNBHDM_.GetHashCode();
		if (DHFGLLAIFHP != 0)
		{
			num ^= DHFGLLAIFHP.GetHashCode();
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
		if (MPJPBLLCMHK != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MPJPBLLCMHK);
		}
		if (DGGAIEANNBJ != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(DGGAIEANNBJ);
		}
		if (IGFHEGBCGBH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(IGFHEGBCGBH);
		}
		if (FELAADBOAKD != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FELAADBOAKD);
		}
		dPEJNGNBHDM_.WriteTo(ref output, _repeated_dPEJNGNBHDM_codec);
		if (DHFGLLAIFHP != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DHFGLLAIFHP);
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
		if (MPJPBLLCMHK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MPJPBLLCMHK);
		}
		if (DGGAIEANNBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DGGAIEANNBJ);
		}
		if (IGFHEGBCGBH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGFHEGBCGBH);
		}
		if (FELAADBOAKD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FELAADBOAKD);
		}
		num += dPEJNGNBHDM_.CalculateSize(_repeated_dPEJNGNBHDM_codec);
		if (DHFGLLAIFHP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHFGLLAIFHP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GDKPBDAAKBH other)
	{
		if (other != null)
		{
			if (other.MPJPBLLCMHK != 0)
			{
				MPJPBLLCMHK = other.MPJPBLLCMHK;
			}
			if (other.DGGAIEANNBJ != 0)
			{
				DGGAIEANNBJ = other.DGGAIEANNBJ;
			}
			if (other.IGFHEGBCGBH != 0)
			{
				IGFHEGBCGBH = other.IGFHEGBCGBH;
			}
			if (other.FELAADBOAKD != 0)
			{
				FELAADBOAKD = other.FELAADBOAKD;
			}
			dPEJNGNBHDM_.Add(other.dPEJNGNBHDM_);
			if (other.DHFGLLAIFHP != 0)
			{
				DHFGLLAIFHP = other.DHFGLLAIFHP;
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
				MPJPBLLCMHK = input.ReadUInt32();
				break;
			case 56u:
				DGGAIEANNBJ = input.ReadUInt32();
				break;
			case 64u:
				IGFHEGBCGBH = input.ReadUInt32();
				break;
			case 88u:
				FELAADBOAKD = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				dPEJNGNBHDM_.AddEntriesFrom(ref input, _repeated_dPEJNGNBHDM_codec);
				break;
			case 120u:
				DHFGLLAIFHP = input.ReadUInt32();
				break;
			}
		}
	}
}
