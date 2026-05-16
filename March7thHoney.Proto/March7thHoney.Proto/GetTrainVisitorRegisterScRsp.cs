using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetTrainVisitorRegisterScRsp : IMessage<GetTrainVisitorRegisterScRsp>, IMessage, IEquatable<GetTrainVisitorRegisterScRsp>, IDeepCloneable<GetTrainVisitorRegisterScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetTrainVisitorRegisterScRsp> _parser = new MessageParser<GetTrainVisitorRegisterScRsp>(() => new GetTrainVisitorRegisterScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	public const int LLDAFKHFECAFieldNumber = 12;

	private static readonly FieldCodec<HHIAOANDGAL> _repeated_lLDAFKHFECA_codec = FieldCodec.ForMessage(98u, HHIAOANDGAL.Parser);

	private readonly RepeatedField<HHIAOANDGAL> lLDAFKHFECA_ = new RepeatedField<HHIAOANDGAL>();

	public const int GLBPLJPPJPAFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_gLBPLJPPJPA_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> gLBPLJPPJPA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetTrainVisitorRegisterScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetTrainVisitorRegisterScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<HHIAOANDGAL> LLDAFKHFECA => lLDAFKHFECA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GLBPLJPPJPA => gLBPLJPPJPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTrainVisitorRegisterScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTrainVisitorRegisterScRsp(GetTrainVisitorRegisterScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		lLDAFKHFECA_ = other.lLDAFKHFECA_.Clone();
		gLBPLJPPJPA_ = other.gLBPLJPPJPA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTrainVisitorRegisterScRsp Clone()
	{
		return new GetTrainVisitorRegisterScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetTrainVisitorRegisterScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetTrainVisitorRegisterScRsp other)
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
		if (!lLDAFKHFECA_.Equals(other.lLDAFKHFECA_))
		{
			return false;
		}
		if (!gLBPLJPPJPA_.Equals(other.gLBPLJPPJPA_))
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
		num ^= lLDAFKHFECA_.GetHashCode();
		num ^= gLBPLJPPJPA_.GetHashCode();
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
			output.WriteRawTag(88);
			output.WriteUInt32(Retcode);
		}
		lLDAFKHFECA_.WriteTo(ref output, _repeated_lLDAFKHFECA_codec);
		gLBPLJPPJPA_.WriteTo(ref output, _repeated_gLBPLJPPJPA_codec);
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
		num += lLDAFKHFECA_.CalculateSize(_repeated_lLDAFKHFECA_codec);
		num += gLBPLJPPJPA_.CalculateSize(_repeated_gLBPLJPPJPA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetTrainVisitorRegisterScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			lLDAFKHFECA_.Add(other.lLDAFKHFECA_);
			gLBPLJPPJPA_.Add(other.gLBPLJPPJPA_);
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
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				lLDAFKHFECA_.AddEntriesFrom(ref input, _repeated_lLDAFKHFECA_codec);
				break;
			case 104u:
			case 106u:
				gLBPLJPPJPA_.AddEntriesFrom(ref input, _repeated_gLBPLJPPJPA_codec);
				break;
			}
		}
	}
}
