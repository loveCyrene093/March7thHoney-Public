using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetChessRogueStoryInfoScRsp : IMessage<GetChessRogueStoryInfoScRsp>, IMessage, IEquatable<GetChessRogueStoryInfoScRsp>, IDeepCloneable<GetChessRogueStoryInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetChessRogueStoryInfoScRsp> _parser = new MessageParser<GetChessRogueStoryInfoScRsp>(() => new GetChessRogueStoryInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DOKHDOGAPKDFieldNumber = 1;

	private static readonly FieldCodec<ADMKICHLGBP> _repeated_dOKHDOGAPKD_codec = FieldCodec.ForMessage(10u, ADMKICHLGBP.Parser);

	private readonly RepeatedField<ADMKICHLGBP> dOKHDOGAPKD_ = new RepeatedField<ADMKICHLGBP>();

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int OLHNBEPHHFGFieldNumber = 12;

	private static readonly FieldCodec<LKCEBEDHNBJ> _repeated_oLHNBEPHHFG_codec = FieldCodec.ForMessage(98u, LKCEBEDHNBJ.Parser);

	private readonly RepeatedField<LKCEBEDHNBJ> oLHNBEPHHFG_ = new RepeatedField<LKCEBEDHNBJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetChessRogueStoryInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetChessRogueStoryInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ADMKICHLGBP> DOKHDOGAPKD => dOKHDOGAPKD_;

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
	public RepeatedField<LKCEBEDHNBJ> OLHNBEPHHFG => oLHNBEPHHFG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChessRogueStoryInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChessRogueStoryInfoScRsp(GetChessRogueStoryInfoScRsp other)
		: this()
	{
		dOKHDOGAPKD_ = other.dOKHDOGAPKD_.Clone();
		retcode_ = other.retcode_;
		oLHNBEPHHFG_ = other.oLHNBEPHHFG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetChessRogueStoryInfoScRsp Clone()
	{
		return new GetChessRogueStoryInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetChessRogueStoryInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetChessRogueStoryInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dOKHDOGAPKD_.Equals(other.dOKHDOGAPKD_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!oLHNBEPHHFG_.Equals(other.oLHNBEPHHFG_))
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
		num ^= dOKHDOGAPKD_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= oLHNBEPHHFG_.GetHashCode();
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
		dOKHDOGAPKD_.WriteTo(ref output, _repeated_dOKHDOGAPKD_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		oLHNBEPHHFG_.WriteTo(ref output, _repeated_oLHNBEPHHFG_codec);
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
		num += dOKHDOGAPKD_.CalculateSize(_repeated_dOKHDOGAPKD_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += oLHNBEPHHFG_.CalculateSize(_repeated_oLHNBEPHHFG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetChessRogueStoryInfoScRsp other)
	{
		if (other != null)
		{
			dOKHDOGAPKD_.Add(other.dOKHDOGAPKD_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			oLHNBEPHHFG_.Add(other.oLHNBEPHHFG_);
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
				dOKHDOGAPKD_.AddEntriesFrom(ref input, _repeated_dOKHDOGAPKD_codec);
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				oLHNBEPHHFG_.AddEntriesFrom(ref input, _repeated_oLHNBEPHHFG_codec);
				break;
			}
		}
	}
}
