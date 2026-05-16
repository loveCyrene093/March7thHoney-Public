using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetSwitchMascotDataScRsp : IMessage<GetSwitchMascotDataScRsp>, IMessage, IEquatable<GetSwitchMascotDataScRsp>, IDeepCloneable<GetSwitchMascotDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetSwitchMascotDataScRsp> _parser = new MessageParser<GetSwitchMascotDataScRsp>(() => new GetSwitchMascotDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int OHFBMFGPMJOFieldNumber = 11;

	private static readonly FieldCodec<LIEEDGOEGMK> _repeated_oHFBMFGPMJO_codec = FieldCodec.ForMessage(90u, LIEEDGOEGMK.Parser);

	private readonly RepeatedField<LIEEDGOEGMK> oHFBMFGPMJO_ = new RepeatedField<LIEEDGOEGMK>();

	public const int CPMOOKFKBEGFieldNumber = 13;

	private uint cPMOOKFKBEG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetSwitchMascotDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetSwitchMascotDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<LIEEDGOEGMK> OHFBMFGPMJO => oHFBMFGPMJO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CPMOOKFKBEG
	{
		get
		{
			return cPMOOKFKBEG_;
		}
		set
		{
			cPMOOKFKBEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwitchMascotDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwitchMascotDataScRsp(GetSwitchMascotDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		oHFBMFGPMJO_ = other.oHFBMFGPMJO_.Clone();
		cPMOOKFKBEG_ = other.cPMOOKFKBEG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetSwitchMascotDataScRsp Clone()
	{
		return new GetSwitchMascotDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetSwitchMascotDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetSwitchMascotDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!oHFBMFGPMJO_.Equals(other.oHFBMFGPMJO_))
		{
			return false;
		}
		if (CPMOOKFKBEG != other.CPMOOKFKBEG)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= oHFBMFGPMJO_.GetHashCode();
		if (CPMOOKFKBEG != 0)
		{
			num ^= CPMOOKFKBEG.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		oHFBMFGPMJO_.WriteTo(ref output, _repeated_oHFBMFGPMJO_codec);
		if (CPMOOKFKBEG != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CPMOOKFKBEG);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += oHFBMFGPMJO_.CalculateSize(_repeated_oHFBMFGPMJO_codec);
		if (CPMOOKFKBEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CPMOOKFKBEG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetSwitchMascotDataScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			oHFBMFGPMJO_.Add(other.oHFBMFGPMJO_);
			if (other.CPMOOKFKBEG != 0)
			{
				CPMOOKFKBEG = other.CPMOOKFKBEG;
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
				Retcode = input.ReadUInt32();
				break;
			case 90u:
				oHFBMFGPMJO_.AddEntriesFrom(ref input, _repeated_oHFBMFGPMJO_codec);
				break;
			case 104u:
				CPMOOKFKBEG = input.ReadUInt32();
				break;
			}
		}
	}
}
