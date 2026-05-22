using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetRogueEndlessActivityDataScRsp : IMessage<GetRogueEndlessActivityDataScRsp>, IMessage, IEquatable<GetRogueEndlessActivityDataScRsp>, IDeepCloneable<GetRogueEndlessActivityDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetRogueEndlessActivityDataScRsp> _parser = new MessageParser<GetRogueEndlessActivityDataScRsp>(() => new GetRogueEndlessActivityDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LLHGGPJBNINFieldNumber = 1;

	private uint lLHGGPJBNIN_;

	public const int MOGBNJOHKLAFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_mOGBNJOHKLA_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> mOGBNJOHKLA_ = new RepeatedField<uint>();

	public const int DataFieldNumber = 6;

	private static readonly FieldCodec<NLPPCFGFFDE> _repeated_data_codec = FieldCodec.ForMessage(50u, NLPPCFGFFDE.Parser);

	private readonly RepeatedField<NLPPCFGFFDE> data_ = new RepeatedField<NLPPCFGFFDE>();

	public const int NAGLJDCLGGBFieldNumber = 7;

	private uint nAGLJDCLGGB_;

	public const int RetcodeFieldNumber = 11;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetRogueEndlessActivityDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetRogueEndlessActivityDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LLHGGPJBNIN
	{
		get
		{
			return lLHGGPJBNIN_;
		}
		set
		{
			lLHGGPJBNIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MOGBNJOHKLA => mOGBNJOHKLA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NLPPCFGFFDE> Data => data_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NAGLJDCLGGB
	{
		get
		{
			return nAGLJDCLGGB_;
		}
		set
		{
			nAGLJDCLGGB_ = value;
		}
	}

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
	public GetRogueEndlessActivityDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueEndlessActivityDataScRsp(GetRogueEndlessActivityDataScRsp other)
		: this()
	{
		lLHGGPJBNIN_ = other.lLHGGPJBNIN_;
		mOGBNJOHKLA_ = other.mOGBNJOHKLA_.Clone();
		data_ = other.data_.Clone();
		nAGLJDCLGGB_ = other.nAGLJDCLGGB_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetRogueEndlessActivityDataScRsp Clone()
	{
		return new GetRogueEndlessActivityDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetRogueEndlessActivityDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetRogueEndlessActivityDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LLHGGPJBNIN != other.LLHGGPJBNIN)
		{
			return false;
		}
		if (!mOGBNJOHKLA_.Equals(other.mOGBNJOHKLA_))
		{
			return false;
		}
		if (!data_.Equals(other.data_))
		{
			return false;
		}
		if (NAGLJDCLGGB != other.NAGLJDCLGGB)
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
		if (LLHGGPJBNIN != 0)
		{
			num ^= LLHGGPJBNIN.GetHashCode();
		}
		num ^= mOGBNJOHKLA_.GetHashCode();
		num ^= data_.GetHashCode();
		if (NAGLJDCLGGB != 0)
		{
			num ^= NAGLJDCLGGB.GetHashCode();
		}
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
		if (LLHGGPJBNIN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LLHGGPJBNIN);
		}
		mOGBNJOHKLA_.WriteTo(ref output, _repeated_mOGBNJOHKLA_codec);
		data_.WriteTo(ref output, _repeated_data_codec);
		if (NAGLJDCLGGB != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(NAGLJDCLGGB);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(88);
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
		if (LLHGGPJBNIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LLHGGPJBNIN);
		}
		num += mOGBNJOHKLA_.CalculateSize(_repeated_mOGBNJOHKLA_codec);
		num += data_.CalculateSize(_repeated_data_codec);
		if (NAGLJDCLGGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NAGLJDCLGGB);
		}
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
	public void MergeFrom(GetRogueEndlessActivityDataScRsp other)
	{
		if (other != null)
		{
			if (other.LLHGGPJBNIN != 0)
			{
				LLHGGPJBNIN = other.LLHGGPJBNIN;
			}
			mOGBNJOHKLA_.Add(other.mOGBNJOHKLA_);
			data_.Add(other.data_);
			if (other.NAGLJDCLGGB != 0)
			{
				NAGLJDCLGGB = other.NAGLJDCLGGB;
			}
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
			case 8u:
				LLHGGPJBNIN = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				mOGBNJOHKLA_.AddEntriesFrom(ref input, _repeated_mOGBNJOHKLA_codec);
				break;
			case 50u:
				data_.AddEntriesFrom(ref input, _repeated_data_codec);
				break;
			case 56u:
				NAGLJDCLGGB = input.ReadUInt32();
				break;
			case 88u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
