using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwitchMascotUpdateScNotify : IMessage<SwitchMascotUpdateScNotify>, IMessage, IEquatable<SwitchMascotUpdateScNotify>, IDeepCloneable<SwitchMascotUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<SwitchMascotUpdateScNotify> _parser = new MessageParser<SwitchMascotUpdateScNotify>(() => new SwitchMascotUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int NONMONPHBPEFieldNumber = 2;

	private bool nONMONPHBPE_;

	public const int OHFBMFGPMJOFieldNumber = 3;

	private static readonly FieldCodec<LIEEDGOEGMK> _repeated_oHFBMFGPMJO_codec = FieldCodec.ForMessage(26u, LIEEDGOEGMK.Parser);

	private readonly RepeatedField<LIEEDGOEGMK> oHFBMFGPMJO_ = new RepeatedField<LIEEDGOEGMK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwitchMascotUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwitchMascotUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NONMONPHBPE
	{
		get
		{
			return nONMONPHBPE_;
		}
		set
		{
			nONMONPHBPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LIEEDGOEGMK> OHFBMFGPMJO => oHFBMFGPMJO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchMascotUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchMascotUpdateScNotify(SwitchMascotUpdateScNotify other)
		: this()
	{
		nONMONPHBPE_ = other.nONMONPHBPE_;
		oHFBMFGPMJO_ = other.oHFBMFGPMJO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchMascotUpdateScNotify Clone()
	{
		return new SwitchMascotUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwitchMascotUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwitchMascotUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NONMONPHBPE != other.NONMONPHBPE)
		{
			return false;
		}
		if (!oHFBMFGPMJO_.Equals(other.oHFBMFGPMJO_))
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
		if (NONMONPHBPE)
		{
			num ^= NONMONPHBPE.GetHashCode();
		}
		num ^= oHFBMFGPMJO_.GetHashCode();
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
		if (NONMONPHBPE)
		{
			output.WriteRawTag(16);
			output.WriteBool(NONMONPHBPE);
		}
		oHFBMFGPMJO_.WriteTo(ref output, _repeated_oHFBMFGPMJO_codec);
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
		if (NONMONPHBPE)
		{
			num += 2;
		}
		num += oHFBMFGPMJO_.CalculateSize(_repeated_oHFBMFGPMJO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SwitchMascotUpdateScNotify other)
	{
		if (other != null)
		{
			if (other.NONMONPHBPE)
			{
				NONMONPHBPE = other.NONMONPHBPE;
			}
			oHFBMFGPMJO_.Add(other.oHFBMFGPMJO_);
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
				NONMONPHBPE = input.ReadBool();
				break;
			case 26u:
				oHFBMFGPMJO_.AddEntriesFrom(ref input, _repeated_oHFBMFGPMJO_codec);
				break;
			}
		}
	}
}
