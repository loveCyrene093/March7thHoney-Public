using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetRogueCollectionScRsp : IMessage<SetRogueCollectionScRsp>, IMessage, IEquatable<SetRogueCollectionScRsp>, IDeepCloneable<SetRogueCollectionScRsp>, IBufferMessage
{
	private static readonly MessageParser<SetRogueCollectionScRsp> _parser = new MessageParser<SetRogueCollectionScRsp>(() => new SetRogueCollectionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IBNNOAJMAKEFieldNumber = 1;

	private static readonly FieldCodec<MMPOOBGAEKE> _repeated_iBNNOAJMAKE_codec = FieldCodec.ForMessage(10u, MMPOOBGAEKE.Parser);

	private readonly RepeatedField<MMPOOBGAEKE> iBNNOAJMAKE_ = new RepeatedField<MMPOOBGAEKE>();

	public const int LNINOMPEBOBFieldNumber = 8;

	private static readonly FieldCodec<EPLGMCCNALG> _repeated_lNINOMPEBOB_codec = FieldCodec.ForMessage(66u, EPLGMCCNALG.Parser);

	private readonly RepeatedField<EPLGMCCNALG> lNINOMPEBOB_ = new RepeatedField<EPLGMCCNALG>();

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetRogueCollectionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetRogueCollectionScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MMPOOBGAEKE> IBNNOAJMAKE => iBNNOAJMAKE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EPLGMCCNALG> LNINOMPEBOB => lNINOMPEBOB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRogueCollectionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRogueCollectionScRsp(SetRogueCollectionScRsp other)
		: this()
	{
		iBNNOAJMAKE_ = other.iBNNOAJMAKE_.Clone();
		lNINOMPEBOB_ = other.lNINOMPEBOB_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRogueCollectionScRsp Clone()
	{
		return new SetRogueCollectionScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetRogueCollectionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetRogueCollectionScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iBNNOAJMAKE_.Equals(other.iBNNOAJMAKE_))
		{
			return false;
		}
		if (!lNINOMPEBOB_.Equals(other.lNINOMPEBOB_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= iBNNOAJMAKE_.GetHashCode();
		num ^= lNINOMPEBOB_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		iBNNOAJMAKE_.WriteTo(ref output, _repeated_iBNNOAJMAKE_codec);
		lNINOMPEBOB_.WriteTo(ref output, _repeated_lNINOMPEBOB_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		num += iBNNOAJMAKE_.CalculateSize(_repeated_iBNNOAJMAKE_codec);
		num += lNINOMPEBOB_.CalculateSize(_repeated_lNINOMPEBOB_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetRogueCollectionScRsp other)
	{
		if (other != null)
		{
			iBNNOAJMAKE_.Add(other.iBNNOAJMAKE_);
			lNINOMPEBOB_.Add(other.lNINOMPEBOB_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 10u:
				iBNNOAJMAKE_.AddEntriesFrom(ref input, _repeated_iBNNOAJMAKE_codec);
				break;
			case 66u:
				lNINOMPEBOB_.AddEntriesFrom(ref input, _repeated_lNINOMPEBOB_codec);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
