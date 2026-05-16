using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetRogueExhibitionScRsp : IMessage<SetRogueExhibitionScRsp>, IMessage, IEquatable<SetRogueExhibitionScRsp>, IDeepCloneable<SetRogueExhibitionScRsp>, IBufferMessage
{
	private static readonly MessageParser<SetRogueExhibitionScRsp> _parser = new MessageParser<SetRogueExhibitionScRsp>(() => new SetRogueExhibitionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int FJBIMHAFLEJFieldNumber = 3;

	private static readonly FieldCodec<JJHODFAHHKG> _repeated_fJBIMHAFLEJ_codec = FieldCodec.ForMessage(26u, JJHODFAHHKG.Parser);

	private readonly RepeatedField<JJHODFAHHKG> fJBIMHAFLEJ_ = new RepeatedField<JJHODFAHHKG>();

	public const int OHMPBCHAPKDFieldNumber = 13;

	private static readonly FieldCodec<EEBOPKJEMHK> _repeated_oHMPBCHAPKD_codec = FieldCodec.ForMessage(106u, EEBOPKJEMHK.Parser);

	private readonly RepeatedField<EEBOPKJEMHK> oHMPBCHAPKD_ = new RepeatedField<EEBOPKJEMHK>();

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetRogueExhibitionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetRogueExhibitionScRspReflection.Descriptor.MessageTypes[0];

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
	public SetRogueExhibitionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRogueExhibitionScRsp(SetRogueExhibitionScRsp other)
		: this()
	{
		fJBIMHAFLEJ_ = other.fJBIMHAFLEJ_.Clone();
		oHMPBCHAPKD_ = other.oHMPBCHAPKD_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRogueExhibitionScRsp Clone()
	{
		return new SetRogueExhibitionScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetRogueExhibitionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetRogueExhibitionScRsp other)
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
		num ^= fJBIMHAFLEJ_.GetHashCode();
		num ^= oHMPBCHAPKD_.GetHashCode();
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
		fJBIMHAFLEJ_.WriteTo(ref output, _repeated_fJBIMHAFLEJ_codec);
		oHMPBCHAPKD_.WriteTo(ref output, _repeated_oHMPBCHAPKD_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		num += fJBIMHAFLEJ_.CalculateSize(_repeated_fJBIMHAFLEJ_codec);
		num += oHMPBCHAPKD_.CalculateSize(_repeated_oHMPBCHAPKD_codec);
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
	public void MergeFrom(SetRogueExhibitionScRsp other)
	{
		if (other != null)
		{
			fJBIMHAFLEJ_.Add(other.fJBIMHAFLEJ_);
			oHMPBCHAPKD_.Add(other.oHMPBCHAPKD_);
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
			case 26u:
				fJBIMHAFLEJ_.AddEntriesFrom(ref input, _repeated_fJBIMHAFLEJ_codec);
				break;
			case 106u:
				oHMPBCHAPKD_.AddEntriesFrom(ref input, _repeated_oHMPBCHAPKD_codec);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
