using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AGJNFOCANCM : IMessage<AGJNFOCANCM>, IMessage, IEquatable<AGJNFOCANCM>, IDeepCloneable<AGJNFOCANCM>, IBufferMessage
{
	private static readonly MessageParser<AGJNFOCANCM> _parser = new MessageParser<AGJNFOCANCM>(() => new AGJNFOCANCM());

	private UnknownFieldSet _unknownFields;

	public const int BDOFFFHPGLNFieldNumber = 1;

	private static readonly FieldCodec<AGEDPIBJPGL> _repeated_bDOFFFHPGLN_codec = FieldCodec.ForMessage(10u, AGEDPIBJPGL.Parser);

	private readonly RepeatedField<AGEDPIBJPGL> bDOFFFHPGLN_ = new RepeatedField<AGEDPIBJPGL>();

	public const int GCMEODCNGILFieldNumber = 2;

	private static readonly FieldCodec<HCIGONGJHEJ> _repeated_gCMEODCNGIL_codec = FieldCodec.ForMessage(18u, HCIGONGJHEJ.Parser);

	private readonly RepeatedField<HCIGONGJHEJ> gCMEODCNGIL_ = new RepeatedField<HCIGONGJHEJ>();

	public const int FJDFFJIEAKOFieldNumber = 3;

	private static readonly FieldCodec<BGKNEEHCGEB> _repeated_fJDFFJIEAKO_codec = FieldCodec.ForMessage(26u, BGKNEEHCGEB.Parser);

	private readonly RepeatedField<BGKNEEHCGEB> fJDFFJIEAKO_ = new RepeatedField<BGKNEEHCGEB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AGJNFOCANCM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AGJNFOCANCMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AGEDPIBJPGL> BDOFFFHPGLN => bDOFFFHPGLN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HCIGONGJHEJ> GCMEODCNGIL => gCMEODCNGIL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BGKNEEHCGEB> FJDFFJIEAKO => fJDFFJIEAKO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGJNFOCANCM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGJNFOCANCM(AGJNFOCANCM other)
		: this()
	{
		bDOFFFHPGLN_ = other.bDOFFFHPGLN_.Clone();
		gCMEODCNGIL_ = other.gCMEODCNGIL_.Clone();
		fJDFFJIEAKO_ = other.fJDFFJIEAKO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGJNFOCANCM Clone()
	{
		return new AGJNFOCANCM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AGJNFOCANCM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AGJNFOCANCM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bDOFFFHPGLN_.Equals(other.bDOFFFHPGLN_))
		{
			return false;
		}
		if (!gCMEODCNGIL_.Equals(other.gCMEODCNGIL_))
		{
			return false;
		}
		if (!fJDFFJIEAKO_.Equals(other.fJDFFJIEAKO_))
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
		num ^= bDOFFFHPGLN_.GetHashCode();
		num ^= gCMEODCNGIL_.GetHashCode();
		num ^= fJDFFJIEAKO_.GetHashCode();
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
		bDOFFFHPGLN_.WriteTo(ref output, _repeated_bDOFFFHPGLN_codec);
		gCMEODCNGIL_.WriteTo(ref output, _repeated_gCMEODCNGIL_codec);
		fJDFFJIEAKO_.WriteTo(ref output, _repeated_fJDFFJIEAKO_codec);
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
		num += bDOFFFHPGLN_.CalculateSize(_repeated_bDOFFFHPGLN_codec);
		num += gCMEODCNGIL_.CalculateSize(_repeated_gCMEODCNGIL_codec);
		num += fJDFFJIEAKO_.CalculateSize(_repeated_fJDFFJIEAKO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AGJNFOCANCM other)
	{
		if (other != null)
		{
			bDOFFFHPGLN_.Add(other.bDOFFFHPGLN_);
			gCMEODCNGIL_.Add(other.gCMEODCNGIL_);
			fJDFFJIEAKO_.Add(other.fJDFFJIEAKO_);
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
			case 10u:
				bDOFFFHPGLN_.AddEntriesFrom(ref input, _repeated_bDOFFFHPGLN_codec);
				break;
			case 18u:
				gCMEODCNGIL_.AddEntriesFrom(ref input, _repeated_gCMEODCNGIL_codec);
				break;
			case 26u:
				fJDFFJIEAKO_.AddEntriesFrom(ref input, _repeated_fJDFFJIEAKO_codec);
				break;
			}
		}
	}
}
