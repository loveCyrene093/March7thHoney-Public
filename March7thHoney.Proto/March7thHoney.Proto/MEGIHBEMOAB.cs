using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MEGIHBEMOAB : IMessage<MEGIHBEMOAB>, IMessage, IEquatable<MEGIHBEMOAB>, IDeepCloneable<MEGIHBEMOAB>, IBufferMessage
{
	private static readonly MessageParser<MEGIHBEMOAB> _parser = new MessageParser<MEGIHBEMOAB>(() => new MEGIHBEMOAB());

	private UnknownFieldSet _unknownFields;

	public const int IBEBJMMCIDHFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_iBEBJMMCIDH_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> iBEBJMMCIDH_ = new RepeatedField<uint>();

	public const int FNKKIDJPKIHFieldNumber = 4;

	private uint fNKKIDJPKIH_;

	public const int DMMNCNGGPHLFieldNumber = 5;

	private static readonly FieldCodec<DOBIOOHLGAA> _repeated_dMMNCNGGPHL_codec = FieldCodec.ForMessage(42u, DOBIOOHLGAA.Parser);

	private readonly RepeatedField<DOBIOOHLGAA> dMMNCNGGPHL_ = new RepeatedField<DOBIOOHLGAA>();

	public const int PHGLFHDDACMFieldNumber = 6;

	private static readonly FieldCodec<JAFPMLLOGDI> _repeated_pHGLFHDDACM_codec = FieldCodec.ForMessage(50u, JAFPMLLOGDI.Parser);

	private readonly RepeatedField<JAFPMLLOGDI> pHGLFHDDACM_ = new RepeatedField<JAFPMLLOGDI>();

	public const int AFOLIFFCDHJFieldNumber = 10;

	private uint aFOLIFFCDHJ_;

	public const int CurIndexFieldNumber = 11;

	private uint curIndex_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MEGIHBEMOAB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MEGIHBEMOABReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IBEBJMMCIDH => iBEBJMMCIDH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FNKKIDJPKIH
	{
		get
		{
			return fNKKIDJPKIH_;
		}
		set
		{
			fNKKIDJPKIH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DOBIOOHLGAA> DMMNCNGGPHL => dMMNCNGGPHL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JAFPMLLOGDI> PHGLFHDDACM => pHGLFHDDACM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AFOLIFFCDHJ
	{
		get
		{
			return aFOLIFFCDHJ_;
		}
		set
		{
			aFOLIFFCDHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurIndex
	{
		get
		{
			return curIndex_;
		}
		set
		{
			curIndex_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEGIHBEMOAB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEGIHBEMOAB(MEGIHBEMOAB other)
		: this()
	{
		iBEBJMMCIDH_ = other.iBEBJMMCIDH_.Clone();
		fNKKIDJPKIH_ = other.fNKKIDJPKIH_;
		dMMNCNGGPHL_ = other.dMMNCNGGPHL_.Clone();
		pHGLFHDDACM_ = other.pHGLFHDDACM_.Clone();
		aFOLIFFCDHJ_ = other.aFOLIFFCDHJ_;
		curIndex_ = other.curIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEGIHBEMOAB Clone()
	{
		return new MEGIHBEMOAB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MEGIHBEMOAB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MEGIHBEMOAB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iBEBJMMCIDH_.Equals(other.iBEBJMMCIDH_))
		{
			return false;
		}
		if (FNKKIDJPKIH != other.FNKKIDJPKIH)
		{
			return false;
		}
		if (!dMMNCNGGPHL_.Equals(other.dMMNCNGGPHL_))
		{
			return false;
		}
		if (!pHGLFHDDACM_.Equals(other.pHGLFHDDACM_))
		{
			return false;
		}
		if (AFOLIFFCDHJ != other.AFOLIFFCDHJ)
		{
			return false;
		}
		if (CurIndex != other.CurIndex)
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
		num ^= iBEBJMMCIDH_.GetHashCode();
		if (FNKKIDJPKIH != 0)
		{
			num ^= FNKKIDJPKIH.GetHashCode();
		}
		num ^= dMMNCNGGPHL_.GetHashCode();
		num ^= pHGLFHDDACM_.GetHashCode();
		if (AFOLIFFCDHJ != 0)
		{
			num ^= AFOLIFFCDHJ.GetHashCode();
		}
		if (CurIndex != 0)
		{
			num ^= CurIndex.GetHashCode();
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
		iBEBJMMCIDH_.WriteTo(ref output, _repeated_iBEBJMMCIDH_codec);
		if (FNKKIDJPKIH != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(FNKKIDJPKIH);
		}
		dMMNCNGGPHL_.WriteTo(ref output, _repeated_dMMNCNGGPHL_codec);
		pHGLFHDDACM_.WriteTo(ref output, _repeated_pHGLFHDDACM_codec);
		if (AFOLIFFCDHJ != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AFOLIFFCDHJ);
		}
		if (CurIndex != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CurIndex);
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
		num += iBEBJMMCIDH_.CalculateSize(_repeated_iBEBJMMCIDH_codec);
		if (FNKKIDJPKIH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FNKKIDJPKIH);
		}
		num += dMMNCNGGPHL_.CalculateSize(_repeated_dMMNCNGGPHL_codec);
		num += pHGLFHDDACM_.CalculateSize(_repeated_pHGLFHDDACM_codec);
		if (AFOLIFFCDHJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFOLIFFCDHJ);
		}
		if (CurIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MEGIHBEMOAB other)
	{
		if (other != null)
		{
			iBEBJMMCIDH_.Add(other.iBEBJMMCIDH_);
			if (other.FNKKIDJPKIH != 0)
			{
				FNKKIDJPKIH = other.FNKKIDJPKIH;
			}
			dMMNCNGGPHL_.Add(other.dMMNCNGGPHL_);
			pHGLFHDDACM_.Add(other.pHGLFHDDACM_);
			if (other.AFOLIFFCDHJ != 0)
			{
				AFOLIFFCDHJ = other.AFOLIFFCDHJ;
			}
			if (other.CurIndex != 0)
			{
				CurIndex = other.CurIndex;
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
			case 18u:
				iBEBJMMCIDH_.AddEntriesFrom(ref input, _repeated_iBEBJMMCIDH_codec);
				break;
			case 32u:
				FNKKIDJPKIH = input.ReadUInt32();
				break;
			case 42u:
				dMMNCNGGPHL_.AddEntriesFrom(ref input, _repeated_dMMNCNGGPHL_codec);
				break;
			case 50u:
				pHGLFHDDACM_.AddEntriesFrom(ref input, _repeated_pHGLFHDDACM_codec);
				break;
			case 80u:
				AFOLIFFCDHJ = input.ReadUInt32();
				break;
			case 88u:
				CurIndex = input.ReadUInt32();
				break;
			}
		}
	}
}
