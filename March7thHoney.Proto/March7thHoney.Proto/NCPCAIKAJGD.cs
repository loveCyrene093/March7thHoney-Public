using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NCPCAIKAJGD : IMessage<NCPCAIKAJGD>, IMessage, IEquatable<NCPCAIKAJGD>, IDeepCloneable<NCPCAIKAJGD>, IBufferMessage
{
	private static readonly MessageParser<NCPCAIKAJGD> _parser = new MessageParser<NCPCAIKAJGD>(() => new NCPCAIKAJGD());

	private UnknownFieldSet _unknownFields;

	public const int GCIIMIOKFKLFieldNumber = 4;

	private bool gCIIMIOKFKL_;

	public const int FOPHPJNGPDEFieldNumber = 5;

	private static readonly FieldCodec<OBNLNNNNFPO> _repeated_fOPHPJNGPDE_codec = FieldCodec.ForMessage(42u, OBNLNNNNFPO.Parser);

	private readonly RepeatedField<OBNLNNNNFPO> fOPHPJNGPDE_ = new RepeatedField<OBNLNNNNFPO>();

	public const int IFHMNCGLCKPFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_iFHMNCGLCKP_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> iFHMNCGLCKP_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NCPCAIKAJGD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NCPCAIKAJGDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GCIIMIOKFKL
	{
		get
		{
			return gCIIMIOKFKL_;
		}
		set
		{
			gCIIMIOKFKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OBNLNNNNFPO> FOPHPJNGPDE => fOPHPJNGPDE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IFHMNCGLCKP => iFHMNCGLCKP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCPCAIKAJGD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCPCAIKAJGD(NCPCAIKAJGD other)
		: this()
	{
		gCIIMIOKFKL_ = other.gCIIMIOKFKL_;
		fOPHPJNGPDE_ = other.fOPHPJNGPDE_.Clone();
		iFHMNCGLCKP_ = other.iFHMNCGLCKP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCPCAIKAJGD Clone()
	{
		return new NCPCAIKAJGD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NCPCAIKAJGD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NCPCAIKAJGD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GCIIMIOKFKL != other.GCIIMIOKFKL)
		{
			return false;
		}
		if (!fOPHPJNGPDE_.Equals(other.fOPHPJNGPDE_))
		{
			return false;
		}
		if (!iFHMNCGLCKP_.Equals(other.iFHMNCGLCKP_))
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
		if (GCIIMIOKFKL)
		{
			num ^= GCIIMIOKFKL.GetHashCode();
		}
		num ^= fOPHPJNGPDE_.GetHashCode();
		num ^= iFHMNCGLCKP_.GetHashCode();
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
		if (GCIIMIOKFKL)
		{
			output.WriteRawTag(32);
			output.WriteBool(GCIIMIOKFKL);
		}
		fOPHPJNGPDE_.WriteTo(ref output, _repeated_fOPHPJNGPDE_codec);
		iFHMNCGLCKP_.WriteTo(ref output, _repeated_iFHMNCGLCKP_codec);
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
		if (GCIIMIOKFKL)
		{
			num += 2;
		}
		num += fOPHPJNGPDE_.CalculateSize(_repeated_fOPHPJNGPDE_codec);
		num += iFHMNCGLCKP_.CalculateSize(_repeated_iFHMNCGLCKP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NCPCAIKAJGD other)
	{
		if (other != null)
		{
			if (other.GCIIMIOKFKL)
			{
				GCIIMIOKFKL = other.GCIIMIOKFKL;
			}
			fOPHPJNGPDE_.Add(other.fOPHPJNGPDE_);
			iFHMNCGLCKP_.Add(other.iFHMNCGLCKP_);
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
				GCIIMIOKFKL = input.ReadBool();
				break;
			case 42u:
				fOPHPJNGPDE_.AddEntriesFrom(ref input, _repeated_fOPHPJNGPDE_codec);
				break;
			case 72u:
			case 74u:
				iFHMNCGLCKP_.AddEntriesFrom(ref input, _repeated_iFHMNCGLCKP_codec);
				break;
			}
		}
	}
}
