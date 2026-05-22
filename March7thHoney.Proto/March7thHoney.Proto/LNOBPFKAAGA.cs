using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LNOBPFKAAGA : IMessage<LNOBPFKAAGA>, IMessage, IEquatable<LNOBPFKAAGA>, IDeepCloneable<LNOBPFKAAGA>, IBufferMessage
{
	private static readonly MessageParser<LNOBPFKAAGA> _parser = new MessageParser<LNOBPFKAAGA>(() => new LNOBPFKAAGA());

	private UnknownFieldSet _unknownFields;

	public const int CGLIPMIMMJGFieldNumber = 4;

	private static readonly FieldCodec<NEIIDDAMPGL> _repeated_cGLIPMIMMJG_codec = FieldCodec.ForMessage(34u, NEIIDDAMPGL.Parser);

	private readonly RepeatedField<NEIIDDAMPGL> cGLIPMIMMJG_ = new RepeatedField<NEIIDDAMPGL>();

	public const int UseItemIdFieldNumber = 5;

	private uint useItemId_;

	public const int DIBNKMICOODFieldNumber = 7;

	private static readonly FieldCodec<HDNOFFGMDNJ> _repeated_dIBNKMICOOD_codec = FieldCodec.ForMessage(58u, HDNOFFGMDNJ.Parser);

	private readonly RepeatedField<HDNOFFGMDNJ> dIBNKMICOOD_ = new RepeatedField<HDNOFFGMDNJ>();

	public const int IJGJODCIDJAFieldNumber = 12;

	private uint iJGJODCIDJA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LNOBPFKAAGA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LNOBPFKAAGAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NEIIDDAMPGL> CGLIPMIMMJG => cGLIPMIMMJG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UseItemId
	{
		get
		{
			return useItemId_;
		}
		set
		{
			useItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HDNOFFGMDNJ> DIBNKMICOOD => dIBNKMICOOD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IJGJODCIDJA
	{
		get
		{
			return iJGJODCIDJA_;
		}
		set
		{
			iJGJODCIDJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNOBPFKAAGA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNOBPFKAAGA(LNOBPFKAAGA other)
		: this()
	{
		cGLIPMIMMJG_ = other.cGLIPMIMMJG_.Clone();
		useItemId_ = other.useItemId_;
		dIBNKMICOOD_ = other.dIBNKMICOOD_.Clone();
		iJGJODCIDJA_ = other.iJGJODCIDJA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNOBPFKAAGA Clone()
	{
		return new LNOBPFKAAGA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LNOBPFKAAGA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LNOBPFKAAGA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cGLIPMIMMJG_.Equals(other.cGLIPMIMMJG_))
		{
			return false;
		}
		if (UseItemId != other.UseItemId)
		{
			return false;
		}
		if (!dIBNKMICOOD_.Equals(other.dIBNKMICOOD_))
		{
			return false;
		}
		if (IJGJODCIDJA != other.IJGJODCIDJA)
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
		num ^= cGLIPMIMMJG_.GetHashCode();
		if (UseItemId != 0)
		{
			num ^= UseItemId.GetHashCode();
		}
		num ^= dIBNKMICOOD_.GetHashCode();
		if (IJGJODCIDJA != 0)
		{
			num ^= IJGJODCIDJA.GetHashCode();
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
		cGLIPMIMMJG_.WriteTo(ref output, _repeated_cGLIPMIMMJG_codec);
		if (UseItemId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(UseItemId);
		}
		dIBNKMICOOD_.WriteTo(ref output, _repeated_dIBNKMICOOD_codec);
		if (IJGJODCIDJA != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(IJGJODCIDJA);
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
		num += cGLIPMIMMJG_.CalculateSize(_repeated_cGLIPMIMMJG_codec);
		if (UseItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UseItemId);
		}
		num += dIBNKMICOOD_.CalculateSize(_repeated_dIBNKMICOOD_codec);
		if (IJGJODCIDJA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJGJODCIDJA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LNOBPFKAAGA other)
	{
		if (other != null)
		{
			cGLIPMIMMJG_.Add(other.cGLIPMIMMJG_);
			if (other.UseItemId != 0)
			{
				UseItemId = other.UseItemId;
			}
			dIBNKMICOOD_.Add(other.dIBNKMICOOD_);
			if (other.IJGJODCIDJA != 0)
			{
				IJGJODCIDJA = other.IJGJODCIDJA;
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
			case 34u:
				cGLIPMIMMJG_.AddEntriesFrom(ref input, _repeated_cGLIPMIMMJG_codec);
				break;
			case 40u:
				UseItemId = input.ReadUInt32();
				break;
			case 58u:
				dIBNKMICOOD_.AddEntriesFrom(ref input, _repeated_dIBNKMICOOD_codec);
				break;
			case 96u:
				IJGJODCIDJA = input.ReadUInt32();
				break;
			}
		}
	}
}
