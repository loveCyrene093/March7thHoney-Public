using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PIILIJHFHCK : IMessage<PIILIJHFHCK>, IMessage, IEquatable<PIILIJHFHCK>, IDeepCloneable<PIILIJHFHCK>, IBufferMessage
{
	private static readonly MessageParser<PIILIJHFHCK> _parser = new MessageParser<PIILIJHFHCK>(() => new PIILIJHFHCK());

	private UnknownFieldSet _unknownFields;

	public const int FJBIMHAFLEJFieldNumber = 6;

	private static readonly FieldCodec<JJHODFAHHKG> _repeated_fJBIMHAFLEJ_codec = FieldCodec.ForMessage(50u, JJHODFAHHKG.Parser);

	private readonly RepeatedField<JJHODFAHHKG> fJBIMHAFLEJ_ = new RepeatedField<JJHODFAHHKG>();

	public const int OHMPBCHAPKDFieldNumber = 11;

	private static readonly FieldCodec<EEBOPKJEMHK> _repeated_oHMPBCHAPKD_codec = FieldCodec.ForMessage(90u, EEBOPKJEMHK.Parser);

	private readonly RepeatedField<EEBOPKJEMHK> oHMPBCHAPKD_ = new RepeatedField<EEBOPKJEMHK>();

	public const int LNINOMPEBOBFieldNumber = 14;

	private static readonly FieldCodec<EPLGMCCNALG> _repeated_lNINOMPEBOB_codec = FieldCodec.ForMessage(114u, EPLGMCCNALG.Parser);

	private readonly RepeatedField<EPLGMCCNALG> lNINOMPEBOB_ = new RepeatedField<EPLGMCCNALG>();

	public const int IBNNOAJMAKEFieldNumber = 15;

	private static readonly FieldCodec<MMPOOBGAEKE> _repeated_iBNNOAJMAKE_codec = FieldCodec.ForMessage(122u, MMPOOBGAEKE.Parser);

	private readonly RepeatedField<MMPOOBGAEKE> iBNNOAJMAKE_ = new RepeatedField<MMPOOBGAEKE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PIILIJHFHCK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PIILIJHFHCKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JJHODFAHHKG> FJBIMHAFLEJ => fJBIMHAFLEJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EEBOPKJEMHK> OHMPBCHAPKD => oHMPBCHAPKD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EPLGMCCNALG> LNINOMPEBOB => lNINOMPEBOB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MMPOOBGAEKE> IBNNOAJMAKE => iBNNOAJMAKE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PIILIJHFHCK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PIILIJHFHCK(PIILIJHFHCK other)
		: this()
	{
		fJBIMHAFLEJ_ = other.fJBIMHAFLEJ_.Clone();
		oHMPBCHAPKD_ = other.oHMPBCHAPKD_.Clone();
		lNINOMPEBOB_ = other.lNINOMPEBOB_.Clone();
		iBNNOAJMAKE_ = other.iBNNOAJMAKE_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PIILIJHFHCK Clone()
	{
		return new PIILIJHFHCK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PIILIJHFHCK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PIILIJHFHCK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fJBIMHAFLEJ_.Equals(other.fJBIMHAFLEJ_))
		{
			return false;
		}
		if (!oHMPBCHAPKD_.Equals(other.oHMPBCHAPKD_))
		{
			return false;
		}
		if (!lNINOMPEBOB_.Equals(other.lNINOMPEBOB_))
		{
			return false;
		}
		if (!iBNNOAJMAKE_.Equals(other.iBNNOAJMAKE_))
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
		num ^= fJBIMHAFLEJ_.GetHashCode();
		num ^= oHMPBCHAPKD_.GetHashCode();
		num ^= lNINOMPEBOB_.GetHashCode();
		num ^= iBNNOAJMAKE_.GetHashCode();
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
		fJBIMHAFLEJ_.WriteTo(ref output, _repeated_fJBIMHAFLEJ_codec);
		oHMPBCHAPKD_.WriteTo(ref output, _repeated_oHMPBCHAPKD_codec);
		lNINOMPEBOB_.WriteTo(ref output, _repeated_lNINOMPEBOB_codec);
		iBNNOAJMAKE_.WriteTo(ref output, _repeated_iBNNOAJMAKE_codec);
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
		num += fJBIMHAFLEJ_.CalculateSize(_repeated_fJBIMHAFLEJ_codec);
		num += oHMPBCHAPKD_.CalculateSize(_repeated_oHMPBCHAPKD_codec);
		num += lNINOMPEBOB_.CalculateSize(_repeated_lNINOMPEBOB_codec);
		num += iBNNOAJMAKE_.CalculateSize(_repeated_iBNNOAJMAKE_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PIILIJHFHCK other)
	{
		if (other != null)
		{
			fJBIMHAFLEJ_.Add(other.fJBIMHAFLEJ_);
			oHMPBCHAPKD_.Add(other.oHMPBCHAPKD_);
			lNINOMPEBOB_.Add(other.lNINOMPEBOB_);
			iBNNOAJMAKE_.Add(other.iBNNOAJMAKE_);
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
			case 50u:
				fJBIMHAFLEJ_.AddEntriesFrom(ref input, _repeated_fJBIMHAFLEJ_codec);
				break;
			case 90u:
				oHMPBCHAPKD_.AddEntriesFrom(ref input, _repeated_oHMPBCHAPKD_codec);
				break;
			case 114u:
				lNINOMPEBOB_.AddEntriesFrom(ref input, _repeated_lNINOMPEBOB_codec);
				break;
			case 122u:
				iBNNOAJMAKE_.AddEntriesFrom(ref input, _repeated_iBNNOAJMAKE_codec);
				break;
			}
		}
	}
}
