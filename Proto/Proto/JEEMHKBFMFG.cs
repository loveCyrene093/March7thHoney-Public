using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JEEMHKBFMFG : IMessage<JEEMHKBFMFG>, IMessage, IEquatable<JEEMHKBFMFG>, IDeepCloneable<JEEMHKBFMFG>, IBufferMessage
{
	private static readonly MessageParser<JEEMHKBFMFG> _parser = new MessageParser<JEEMHKBFMFG>(() => new JEEMHKBFMFG());

	private UnknownFieldSet _unknownFields;

	public const int MEGCAGNHMIEFieldNumber = 2;

	private uint mEGCAGNHMIE_;

	public const int CGOABGKCBEFFieldNumber = 4;

	private uint cGOABGKCBEF_;

	public const int DKKBAMNMFLIFieldNumber = 5;

	private static readonly FieldCodec<NBFDKMNGBKD> _repeated_dKKBAMNMFLI_codec = FieldCodec.ForMessage(42u, NBFDKMNGBKD.Parser);

	private readonly RepeatedField<NBFDKMNGBKD> dKKBAMNMFLI_ = new RepeatedField<NBFDKMNGBKD>();

	public const int ENHOIMLIBJNFieldNumber = 8;

	private uint eNHOIMLIBJN_;

	public const int AACDKGKECAHFieldNumber = 11;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_aACDKGKECAH_codec = FieldCodec.ForMessage(90u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> aACDKGKECAH_ = new RepeatedField<GKDEKJKOIJN>();

	public const int DJEFPHDFACOFieldNumber = 14;

	private uint dJEFPHDFACO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JEEMHKBFMFG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JEEMHKBFMFGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MEGCAGNHMIE
	{
		get
		{
			return mEGCAGNHMIE_;
		}
		set
		{
			mEGCAGNHMIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CGOABGKCBEF
	{
		get
		{
			return cGOABGKCBEF_;
		}
		set
		{
			cGOABGKCBEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NBFDKMNGBKD> DKKBAMNMFLI => dKKBAMNMFLI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ENHOIMLIBJN
	{
		get
		{
			return eNHOIMLIBJN_;
		}
		set
		{
			eNHOIMLIBJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> AACDKGKECAH => aACDKGKECAH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DJEFPHDFACO
	{
		get
		{
			return dJEFPHDFACO_;
		}
		set
		{
			dJEFPHDFACO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEEMHKBFMFG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEEMHKBFMFG(JEEMHKBFMFG other)
		: this()
	{
		mEGCAGNHMIE_ = other.mEGCAGNHMIE_;
		cGOABGKCBEF_ = other.cGOABGKCBEF_;
		dKKBAMNMFLI_ = other.dKKBAMNMFLI_.Clone();
		eNHOIMLIBJN_ = other.eNHOIMLIBJN_;
		aACDKGKECAH_ = other.aACDKGKECAH_.Clone();
		dJEFPHDFACO_ = other.dJEFPHDFACO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEEMHKBFMFG Clone()
	{
		return new JEEMHKBFMFG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JEEMHKBFMFG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JEEMHKBFMFG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MEGCAGNHMIE != other.MEGCAGNHMIE)
		{
			return false;
		}
		if (CGOABGKCBEF != other.CGOABGKCBEF)
		{
			return false;
		}
		if (!dKKBAMNMFLI_.Equals(other.dKKBAMNMFLI_))
		{
			return false;
		}
		if (ENHOIMLIBJN != other.ENHOIMLIBJN)
		{
			return false;
		}
		if (!aACDKGKECAH_.Equals(other.aACDKGKECAH_))
		{
			return false;
		}
		if (DJEFPHDFACO != other.DJEFPHDFACO)
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
		if (MEGCAGNHMIE != 0)
		{
			num ^= MEGCAGNHMIE.GetHashCode();
		}
		if (CGOABGKCBEF != 0)
		{
			num ^= CGOABGKCBEF.GetHashCode();
		}
		num ^= dKKBAMNMFLI_.GetHashCode();
		if (ENHOIMLIBJN != 0)
		{
			num ^= ENHOIMLIBJN.GetHashCode();
		}
		num ^= aACDKGKECAH_.GetHashCode();
		if (DJEFPHDFACO != 0)
		{
			num ^= DJEFPHDFACO.GetHashCode();
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
		if (MEGCAGNHMIE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MEGCAGNHMIE);
		}
		if (CGOABGKCBEF != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CGOABGKCBEF);
		}
		dKKBAMNMFLI_.WriteTo(ref output, _repeated_dKKBAMNMFLI_codec);
		if (ENHOIMLIBJN != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ENHOIMLIBJN);
		}
		aACDKGKECAH_.WriteTo(ref output, _repeated_aACDKGKECAH_codec);
		if (DJEFPHDFACO != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(DJEFPHDFACO);
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
		if (MEGCAGNHMIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MEGCAGNHMIE);
		}
		if (CGOABGKCBEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CGOABGKCBEF);
		}
		num += dKKBAMNMFLI_.CalculateSize(_repeated_dKKBAMNMFLI_codec);
		if (ENHOIMLIBJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ENHOIMLIBJN);
		}
		num += aACDKGKECAH_.CalculateSize(_repeated_aACDKGKECAH_codec);
		if (DJEFPHDFACO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DJEFPHDFACO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JEEMHKBFMFG other)
	{
		if (other != null)
		{
			if (other.MEGCAGNHMIE != 0)
			{
				MEGCAGNHMIE = other.MEGCAGNHMIE;
			}
			if (other.CGOABGKCBEF != 0)
			{
				CGOABGKCBEF = other.CGOABGKCBEF;
			}
			dKKBAMNMFLI_.Add(other.dKKBAMNMFLI_);
			if (other.ENHOIMLIBJN != 0)
			{
				ENHOIMLIBJN = other.ENHOIMLIBJN;
			}
			aACDKGKECAH_.Add(other.aACDKGKECAH_);
			if (other.DJEFPHDFACO != 0)
			{
				DJEFPHDFACO = other.DJEFPHDFACO;
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
				MEGCAGNHMIE = input.ReadUInt32();
				break;
			case 32u:
				CGOABGKCBEF = input.ReadUInt32();
				break;
			case 42u:
				dKKBAMNMFLI_.AddEntriesFrom(ref input, _repeated_dKKBAMNMFLI_codec);
				break;
			case 64u:
				ENHOIMLIBJN = input.ReadUInt32();
				break;
			case 90u:
				aACDKGKECAH_.AddEntriesFrom(ref input, _repeated_aACDKGKECAH_codec);
				break;
			case 112u:
				DJEFPHDFACO = input.ReadUInt32();
				break;
			}
		}
	}
}
